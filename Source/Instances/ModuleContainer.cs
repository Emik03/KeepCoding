using System;
using System.Collections.Generic;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Container for both solvable and needy modules.
    /// </summary>
    public sealed class ModuleContainer : IEquatable<ModuleContainer>
    {
        /// <summary>
        /// Encapsulates either a solvable or needy module. Uses <see cref="CacheableBehaviour.Get{T}(bool)"/>.
        /// </summary>
        /// <param name="behaviour">The component to get the modules from.</param>
        public ModuleContainer(CacheableBehaviour behaviour) : this(behaviour.Get<KMBombModule>(allowNull: true), behaviour.Get<KMNeedyModule>(allowNull: true)) { }

        /// <summary>
        /// Encapsulates either a solvable or needy module. Uses <see cref="Component.GetComponent{T}"/>.
        /// </summary>
        /// <param name="component">The component to get the modules from.</param>
        public ModuleContainer(Component component) : this(component.GetComponent<KMBombModule>(), component.GetComponent<KMNeedyModule>()) { }

        /// <summary>
        /// Encapsulates either a solvable module.
        /// </summary>
        /// <param name="solvable">The instance of a normal module.</param>
        public ModuleContainer(KMBombModule solvable) : this(solvable, null) { }

        /// <summary>
        /// Encapsulates either a solvable module.
        /// </summary>
        /// <param name="needy">The instance of a needy module.</param>
        public ModuleContainer(KMNeedyModule needy) : this(null, needy) { }

        /// <summary>
        /// Encapsulates either a solvable or needy module.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="solvable">The instance of a normal module.</param>
        /// <param name="needy">The instance of a needy module.</param>
        public ModuleContainer(KMBombModule solvable = null, KMNeedyModule needy = null)
        {
            if ((bool)solvable == needy)
                throw new ConstructorArgumentException(solvable ? "Both KMBombModule and KMNeedyModule are assigned, which will mean that it is unable to return both when calling a function that returns a single MonoBehaviour." : "Both KMBombModule and KMNeedyModule is null, and since this data type is immutable after the constructor, it is unable to return anything.");

            _bombModule = solvable;
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
        public string Name => Module switch
        {
            KMBombModule bombModule => bombModule.ModuleDisplayName,
            KMNeedyModule needyModule => needyModule.ModuleDisplayName,
            _ => throw _unreachableException,
        };

        /// <value>
        /// The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public string Id => Module switch
        {
            KMBombModule bombModule => bombModule.ModuleType,
            KMNeedyModule needyModule => needyModule.ModuleType,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Call this when the entire module has been solved.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action Solve => Module switch
        {
            KMBombModule bombModule => bombModule.HandlePass,
            KMNeedyModule needyModule => needyModule.HandlePass,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Call this on any mistake that you want to cause a bomb strike.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action Strike => Module switch
        {
            KMBombModule bombModule => bombModule.HandleStrike,
            KMNeedyModule needyModule => needyModule.HandleStrike,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Returns the random seed used to generate the rules for this game. Not currently used.
        /// </value>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Func<int> RuleGeneration => Module switch
        {
            KMBombModule bombModule => bombModule.GetRuleGenerationSeed,
            KMNeedyModule needyModule => needyModule.GetRuleGenerationSeed,
            _ => throw _unreachableException,
        };

        /// <value>
        /// Returns <see cref="KMBombModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </value>
        /// <exception cref="NullReferenceException"></exception>
        public KMBombModule Solvable => _bombModule.NullCheck("KMBombModule is null, yet you are trying to access it.");

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
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Solvable"/> is defined.
        /// </summary>
        /// <param name="solvable">The solvable module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="solvable"/>.</returns>
        public static implicit operator ModuleContainer(KMBombModule solvable) => new ModuleContainer(solvable: solvable);

        /// <summary>
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Needy"/> is defined.
        /// </summary>
        /// <param name="needy">The needy module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="needy"/>.</returns>
        public static implicit operator ModuleContainer(KMNeedyModule needy) => new ModuleContainer(needy: needy);

        /// <summary>
        /// Returns the instance of <see cref="KMBombModule"/> from <see cref="Solvable"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMBombModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Solvable"/>.</returns>
        public static explicit operator KMBombModule(ModuleContainer container) => container.Solvable;

        /// <summary>
        /// Returns the instance of <see cref="KMNeedyModule"/> from <see cref="Needy"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMNeedyModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Needy"/>.</returns>
        public static explicit operator KMNeedyModule(ModuleContainer container) => container.Needy;

        /// <summary>
        /// Assigns events to a module container, replacing their values.
        /// </summary>
        /// <param name="onActivate">Called when the lights turn on.</param>
        /// <param name="onNeedyActivation">Called when the needy activates.</param>
        /// <param name="onNeedyDeactivation">Called when the needy deactivates.</param>
        /// <param name="onPass">Called when the needy is solved.</param>
        /// <param name="onStrike">Called when the needy strikes.</param>
        /// <param name="onTimerExpired">Called when the timer runs out of time.</param>
        public void Assign(Action onActivate = null, Action onNeedyActivation = null, Action onNeedyDeactivation = null, Action onPass = null, Action onStrike = null, Action onTimerExpired = null)
        {
            switch (Module)
            {
                case KMBombModule bombModule:
                    bombModule.Assign(onActivate, onPass, onStrike);
                    break;

                case KMNeedyModule needyModule:
                    needyModule.Assign(onActivate, onNeedyActivation, onNeedyDeactivation, onPass, onStrike, onTimerExpired);
                    break;

                default:
                    throw _unreachableException;
            }
        }

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

        private static readonly UnrecognizedTypeException _unreachableException = new UnrecognizedTypeException("Module is neither a KMBombModule or a KMNeedyModule. This is a bug caused by the library, please file a bug report alongside the source code.");
    }
}