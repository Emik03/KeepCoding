using System;
using System.Collections.Generic;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Container for both regular and needy modules. Written by Emik.
    /// </summary>
    public sealed class ModuleContainer : IEquatable<ModuleContainer>
    {
        /// <summary>
        /// Encapsulates either a regular or needy module.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="regular">The instance of a normal module.</param>
        /// <param name="needy">The instance of a needy module.</param>
        public ModuleContainer(KMBombModule regular = null, KMNeedyModule needy = null)
        {
            if ((bool)regular == needy)
                throw new ConstructorArgumentException(regular ? "Both KMBombModule and KMNeedyModule are assigned, which will mean that it is unable to return both when calling a function that returns a single MonoBehaviour." : "Both KMBombModule and KMNeedyModule is null, and since this data type is immutable after the constructor, it is unable to return anything.");
            
            _bombModule = regular;
            _needyModule = needy;
        }

        /// <value>
        /// Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public bool RequiresTimerVisibility => Module switch
        {
            KMBombModule bombModule => bombModule.RequiresTimerVisibility,
            KMNeedyModule needyModule => needyModule.RequiresTimerVisibility,
            _ => throw _unreachableException,
        };

        /// <value>
        /// The nice display name shown to players. e.g. "The Button"
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public string ModuleDisplayName => Module switch
        {
            KMBombModule bombModule => bombModule.ModuleDisplayName,
            KMNeedyModule needyModule => needyModule.ModuleDisplayName,
            _ => throw _unreachableException,
        };

        /// <value>
        /// The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public string ModuleType => Module switch
        {
            KMBombModule bombModule => bombModule.ModuleType,
            KMNeedyModule needyModule => needyModule.ModuleType,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Call this when the entire module has been solved.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action HandlePass => Module switch
        {
            KMBombModule bombModule => bombModule.HandlePass,
            KMNeedyModule needyModule => needyModule.HandlePass,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Call this on any mistake that you want to cause a bomb strike.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action HandleStrike => Module switch
        {
            KMBombModule bombModule => bombModule.HandleStrike,
            KMNeedyModule needyModule => needyModule.HandleStrike,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Returns the random seed used to generate the rules for this game. Not currently used.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Func<int> GetRuleGenerationSeed => Module switch
        {
            KMBombModule bombModule => bombModule.GetRuleGenerationSeed,
            KMNeedyModule needyModule => needyModule.GetRuleGenerationSeed,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Returns <see cref="KMBombModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </value>
        /// <exception cref="NullReferenceException"></exception>
        public KMBombModule Regular => _bombModule.NullCheck("KMBombModule is null, yet you are trying to access it.");

        /// <value>
        /// Returns <see cref="KMNeedyModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </value>
        /// <exception cref="NullReferenceException"></exception>
        public KMNeedyModule Needy => _needyModule.NullCheck("KMNeedyModule is null, yet you are trying to access it.");

        /// <value>
        /// Returns <see cref="KMBombModule"/>, or if null, <see cref="KMNeedyModule"/>.
        /// </value>
        public MonoBehaviour Module => _bombModule ?? (MonoBehaviour)_needyModule;

        /// <summary>
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Regular"/> is defined.
        /// </summary>
        /// <param name="regular">The regular module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="regular"/>.</returns>
        public static implicit operator ModuleContainer(KMBombModule regular) => new(regular: regular);

        /// <summary>
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Needy"/> is defined.
        /// </summary>
        /// <param name="needy">The needy module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="needy"/>.</returns>
        public static implicit operator ModuleContainer(KMNeedyModule needy) => new(needy: needy);

        /// <summary>
        /// Returns the instance of <see cref="KMBombModule"/> from <see cref="Regular"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMBombModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Regular"/>.</returns>
        public static explicit operator KMBombModule(ModuleContainer container) => container.Regular;

        /// <summary>
        /// Returns the instance of <see cref="KMNeedyModule"/> from <see cref="Needy"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMNeedyModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Needy"/>.</returns>
        public static explicit operator KMNeedyModule(ModuleContainer container) => container.Needy;

        /// <summary>
        /// Sets the action of OnActivate.
        /// </summary>
        /// <param name="action">The delegate to set.</param>
        public void OnActivate(Action action)
        {
            switch (Module)
            {
                case KMBombModule bombModule:
                    action.Set(ref bombModule.OnActivate);
                    break;

                case KMNeedyModule needyModule:
                    action.Set(ref needyModule.OnActivate);
                    break;

                default:
                    throw _unreachableException;
            }
        }

        /// <summary>
        /// Determines if both <see cref="ModuleContainer"/> variables are equal.
        /// </summary>
        /// <param name="obj">The comparison.</param>
        /// <returns>True if both contain the same instance of <see cref="KMBombModule"/>, <c>null</c>, <see cref="KMNeedyModule"/></returns>
        public override bool Equals(object obj) => Equals(obj as ModuleContainer);

        /// <summary>
        /// Determines if both <see cref="ModuleContainer"/> variables are equal.
        /// </summary>
        /// <param name="other">The comparison.</param>
        /// <returns>True if both contain the same instance of <see cref="KMBombModule"/>, <c>null</c>, <see cref="KMNeedyModule"/></returns>
        public bool Equals(ModuleContainer other) => Module == other.Module;

        /// <summary>
        /// Gets the current hash code.
        /// </summary>
        /// <returns>The <see cref="Module"/>'s hash code.</returns>
        public override int GetHashCode() => 1212890949 + EqualityComparer<MonoBehaviour>.Default.GetHashCode(Module);

        private readonly KMBombModule _bombModule;

        private readonly KMNeedyModule _needyModule;

        private static readonly UnrecognizedTypeException _unreachableException = new("Module is neither a KMBombModule or a KMNeedyModule. This is a bug caused by the library, please file a bug report alongside the source code.");
    }
}