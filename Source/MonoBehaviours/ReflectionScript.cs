﻿#if !LITE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static System.Linq.Enumerable;
using static System.Reflection.BindingFlags;
using static System.String;
using static KeepCoding.Logger;
using static UnityEngine.Application;
using Object = UnityEngine.Object;

namespace KeepCoding.Internal
{
    /// <summary>
    /// Editor-only behaviour that gets values from <see cref="Component"/>s in real-time.
    /// </summary>
    [CLSCompliant(false)]
    public sealed class ReflectionScript : MonoBehaviour, IStart, IFixedUpdate, ILog
    {
        private class NullableObject
        {
            internal NullableObject(object o) => _value = o;

            internal readonly object _value;
        }

        private enum Methods
        {
            Get,
            GetChild,
            GetParent,
            Find
        }

        [SerializeField]
#pragma warning disable 649, IDE0044 // Add readonly modifier
        private int _limitResults = -1;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        [SerializeField]
#pragma warning disable 649, IDE0044 // Add readonly modifier
        private Methods _method;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        [SerializeField]
#pragma warning disable 649, IDE0044 // Add readonly modifier
        private string _variable;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        [SerializeField]
        private string[] _values;

        [SerializeField]
        private Object[] _components;

        private List<Tuple<Component, NullableObject>> _members = Empty, _current = Empty;

        private readonly Logger _logger = new Logger(nameof(ReflectionScript), true, false);

        private const BindingFlags Flags = Instance | Static | Public | NonPublic | FlattenHierarchy;

        private Component[] Components => _method switch
        {
            Methods.Get => GetComponents<Component>(),
            Methods.GetChild => GetComponentsInChildren<Component>(true),
            Methods.GetParent => GetComponentsInParent<Component>(true),
            Methods.Find => FindObjectsOfType<Component>(),
            _ => throw new NotImplementedException(),
        };

        private static List<Tuple<Component, NullableObject>> Empty => Empty<Tuple<Component, NullableObject>>().ToList();

        /// <summary>
        /// Logs message, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="logType">The type of logging. Different logging types have different icons within the editor.</param>
        public void Log<T>(T message, LogType logType = LogType.Log) => _logger.Log(message, logType);

        /// <summary>
        /// Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.
        /// </summary>
        /// <exception cref="UnrecognizedValueException"></exception>
        /// <param name="message">The message to log.</param>
        /// <param name="args">All of the arguments to embed into <paramref name="message"/>.</param>
        public void Log<T>(T message, params object[] args) => _logger.Log(message, args);

        /// <summary>
        /// Logs multiple entries to the console.
        /// </summary>
        /// <param name="logs">The array of logs to individual output into the console.</param>
        public void LogMultiple(params string[] logs) => _logger.LogMultiple(logs);

        private void OnValidate()
        {
            if (_variable is null)
                return;

            _members = Empty<Tuple<Component, NullableObject>>().ToList();

            foreach (Component component in Components)
            {
                if (_members.Count > _limitResults && _limitResults >= 0)
                    break;

                var tuple = component.ToTuple(GetDeepValue(component, _variable.Split('.')));

                if (tuple.Item2 is null)
                    continue;

                _members.Add(tuple);
            }
        }

        /// <summary>
        /// Deletes itself if being ran in-game.
        /// </summary>
        public void Start()
        {
            if (isEditor)
                return;

            Self($"A {nameof(ReflectionScript)} showed up in-game. Automatically deleting component...");
            Destroy(this);
        }

        /// <summary>
        /// Reflects and gets the values of the specified variables.
        /// </summary>
        public void FixedUpdate()
        {
            if (_current.SequenceEqual(_members))
                return;

            _current = _members;

            _components = _members.Select(o => o.Item1).ToArray();

            _values = _members.Select(o => o.Item2._value.Stringify()).ToArray();

            if (!_current.IsNullOrEmpty())
                _logger.Log($"{gameObject.name}, {_variable}\n{Join(", ", _members.Select(m => m.Item2._value.ToString()).ToArray())}");
        }

        private static NullableObject GetDeepValue(in object instance, in string[] names)
        {
            var current = new NullableObject(instance);

            foreach (string name in names)
            {
                if (current is null)
                    return null;

                Type type = current._value?.GetType();

                NullableObject[] vs = new[]
                {
                    GetField(type, name, current._value),
                    GetProperty(type, name, current._value),
                };

                current = vs.All(o => o is null) ? null : new NullableObject(vs.First(o => o is { })._value);
            }

            return current;
        }

        private static NullableObject GetField(in Type type, in string name, in object instance)
        {
            FieldInfo field = type.GetField(name, Flags);

            return field is null ? null
                : new NullableObject(field.IsStatic ? field.GetValue(null)
                : field.GetValue(instance));
        }

        private static NullableObject GetProperty(in Type type, in string name, in object instance)
        {
            PropertyInfo property = type.GetProperty(name, Flags);

            return property is null ? null
                : new NullableObject(property.GetAccessors(false).Any(x => x.IsStatic) ? property.GetValue(null, null)
                : property.GetValue(instance, null));
        }
    }
}
#endif
