using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static System.Linq.Enumerable;
using static System.Reflection.BindingFlags;
using static UnityEngine.Application;
using Object = UnityEngine.Object;

namespace KeepCoding
{
    /// <summary>
    /// Editor-only behaviour that gets values from <see cref="Component"/>s in real-time.
    /// </summary>
    public sealed class ReflectionScript : MonoBehaviour
    {
        private enum Methods
        {
            Get,
            GetChild,
            GetParent,
            Find
        }

        private struct None { }

        private const BindingFlags Flags = IgnoreCase | Instance | Static | Public | NonPublic | FlattenHierarchy;

        private Component[] Components => _method switch
        {
            Methods.Get => GetComponents<Component>(),
            Methods.GetChild => GetComponentsInChildren<Component>(true),
            Methods.GetParent => GetComponentsInParent<Component>(true),
            Methods.Find => FindObjectsOfType<Component>(),
            _ => throw new NotImplementedException(),
        };

        [SerializeField]
#pragma warning disable IDE0044 // Add readonly modifier
        private string _name;
#pragma warning restore IDE0044 // Add readonly modifier

        [SerializeField]
#pragma warning disable IDE0044 // Add readonly modifier
        private Methods _method;
#pragma warning restore IDE0044 // Add readonly modifier

        [SerializeField]
        private string[] _values;

        [SerializeField]
        private Object[] _components;

        private IEnumerable<object> _current = Empty<object>();

        private IEnumerable<Tuple<Component, object>> _members = Empty<Tuple<Component, object>>();

        private readonly Logger _log = new Logger(nameof(ReflectionScript));

        private void OnValidate()
        {
            if (_name is null)
                return;

            _members = Components
                .Select(c => c.ToTuple(GetDeepValue(c, _name.Split('.'))))
                .Where(t => !(t.Item2 is None));
        }

        private void Start()
        {
            if (isEditor)
            {
                StartCoroutine(Loop());
                return;
            }

            Logger.Self($"A {nameof(ReflectionScript)} showed up in-game! Automatically deleting component...");
            Destroy(this);
        }

        private static object GetDeepValue(object instance, string[] names)
        {
            foreach (var name in names)
            {
                var type = instance?.GetType();

                object[] vs = new[] 
                { 
                    GetField(type, instance, name),
                    GetProperty(type, instance, name),
                };

                instance = vs.All(o => o is None) ? new None() : vs.First(o => !(o is None));
            }

            return instance;
        }

        private static object GetField(Type type, object instance, string name)
        {
            FieldInfo field = type?.GetField(name);

            return field is null ? new None()
                : field.IsStatic ? field.GetValue(null)
                : field.GetValue(instance);
        }

        private static object GetProperty(Type type, object instance, string name)
        {
            PropertyInfo property = type?.GetProperty(name);

            return property is null ? new None()
                : property.GetAccessors(false).Any(x => x.IsStatic) ? property.GetValue(null, null)
                : property.GetValue(instance, null);
        }

        private IEnumerator Loop()
        {
            while (true)
            {
                yield return new WaitUntil(() => enabled);

                yield return new WaitForSecondsRealtime(0.1f);

                IEnumerable<object> objects = _members.Select(o => o.Item2);

                _values = objects
                    .Where(o => !(o is Object))
                    .ToArray()
                    .ConvertAll(o => o.UnwrapToString());

                _components = objects
                    .Where(o => o is Object)
                    .ToArray()
                    .ConvertAll(o => (Object)o);

                if (_current.SequenceEqual(objects))
                    continue;

                _current = objects;

                new Logger($"{nameof(ReflectionScript)} ({_name})").Log(_values.Select(o => '\n' + o.UnwrapToString()));
            }
        }
    }
}
