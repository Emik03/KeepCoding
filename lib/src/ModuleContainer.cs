using System;
using UnityEngine;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// Container for both regular and needy modules.
    /// </summary>
    public sealed class ModuleContainer
    {
        /// <summary>
        /// Encapsulates either a regular or needy module.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="bombModule">The instance of a normal module.</param>
        /// <param name="needyModule">The instance of a needy module.</param>
        public ModuleContainer(KMBombModule bombModule = null, KMNeedyModule needyModule = null)
        {
            if (bombModule is null == needyModule is null)
                throw new ConstructorArgumentException(bombModule is null ? "Both KMBombModule and KMNeedyModule is null, and since this datatype is immutable after the constructor, cannot return anything." : "Both KMBombModule and KMNeedyModule are assigned, which will mean that it is unable to return both when calling a function that returns a single MonoBehaviour.");

            _bombModule = bombModule;
            _needyModule = needyModule;
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
        public KMBombModule Regular => _bombModule ?? throw new NullReferenceException("KMBombModule is null, yet you are trying to access it.");

        /// <value>
        /// Returns <see cref="KMNeedyModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </value>
        /// <exception cref="NullReferenceException"></exception>
        public KMNeedyModule Needy => _needyModule ?? throw new NullReferenceException("KMNeedyModule is null, yet you are trying to access it.");

        /// <value>
        /// Returns <see cref="KMBombModule"/>, or if null, <see cref="KMNeedyModule"/>.
        /// </value>
        public MonoBehaviour Module => _bombModule ?? (MonoBehaviour)_needyModule;

        private readonly KMBombModule _bombModule;

        private readonly KMNeedyModule _needyModule;

        private static readonly UnrecognizedTypeException _unreachableException = new UnrecognizedTypeException("Module is neither a KMBombModule or a KMNeedyModule. This is a bug caused by the library, please file a bug report alongside the source code.");

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
    }
}