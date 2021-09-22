using System;
using System.Collections.Generic;
using Assets.Scripts.Missions;
using KeepCoding.Internal;
using UnityEngine;
using static System.Delegate;
using static KeepCoding.Game;
using static NeedyTimer;

namespace KeepCoding
{
    /// <summary>
    /// Contains and encapsulates both solvable and needy modules, in both modded and vanilla forms.
    /// </summary>
    public sealed class ModuleContainer : IEquatable<ModuleContainer>
    {
        private object _bombComponent;

        private readonly KMBombModule _bombModule;

        private readonly KMNeedyModule _needyModule;

        private static readonly InvalidOperationException s_remove = new InvalidOperationException("This event is adder-only.");

        private static readonly MissingReferenceException s_none = new MissingReferenceException($"{nameof(Module)} is none of {nameof(KMBombModule)}, {nameof(KMNeedyModule)}, or BombComponent.");

        private static readonly ImmutableException s_immutable = new ImmutableException("This member is immutable.");

        /// <summary>
        /// Encapsulates either a modded solvable or modded needy module by using <see cref="CacheableBehaviour.Get{T}(bool)"/>. An exception is thrown if <see cref="KMBombModule"/> and <see cref="KMNeedyModule"/> are both <see langword="null"/> or both not <see langword="null"/>.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="behaviour">The component to get the module from.</param>
        [CLSCompliant(false)]
        public ModuleContainer(CacheableBehaviour behaviour) : this(behaviour.Get<KMBombModule>(allowNull: true), behaviour.Get<KMNeedyModule>(allowNull: true)) { }

        /// <summary>
        /// Encapsulates either a modded solvable or modded needy module by using <see cref="Component.GetComponent{T}"/>. An exception is thrown if <see cref="KMBombModule"/> and <see cref="KMNeedyModule"/> are both <see langword="null"/> or both not <see langword="null"/>.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="component">The component to get the module from.</param>
        [CLSCompliant(false)]
        public ModuleContainer(Component component) : this(component.GetComponent<KMBombModule>(), component.GetComponent<KMNeedyModule>()) { }

        /// <summary>
        /// Encapsulates a modded solvable module.
        /// </summary>
        /// <param name="solvable">The instance of a normal module.</param>
        [CLSCompliant(false)]
        public ModuleContainer(KMBombModule solvable) : this(solvable, null) { }

        /// <summary>
        /// Encapsulates a modded needy module.
        /// </summary>
        /// <param name="needy">The instance of a needy module.</param>
        [CLSCompliant(false)]
        public ModuleContainer(KMNeedyModule needy) : this(null, needy) { }

        /// <summary>
        /// Encapsulates either a modded solvable or modded needy module. An exception is thrown if <see cref="KMBombModule"/> and <see cref="KMNeedyModule"/> are both <see langword="null"/> or both not <see langword="null"/>.
        /// </summary>
        /// <exception cref="ConstructorArgumentException"></exception>
        /// <param name="solvable">The instance of a normal module.</param>
        /// <param name="needy">The instance of a needy module.</param>
        [CLSCompliant(false)]
        public ModuleContainer(KMBombModule solvable, KMNeedyModule needy) : this(solvable, needy, false) { }

        /// <summary>
        /// Encapsulates either a solvable or needy module. If a BombComponent (or derived) is passed in, the vanilla module component will be stored instead. Uses <see cref="Component.GetComponent{T}"/>.
        /// </summary>
        /// <param name="monoBehaviour">The <see cref="MonoBehaviour"/> to get the module from.</param>
        [CLSCompliant(false)]
        public ModuleContainer(MonoBehaviour monoBehaviour) : this(monoBehaviour.GetComponent<KMBombModule>(), monoBehaviour.GetComponent<KMNeedyModule>(), true)
        {
            if (IsKtane)
                AssignBombComponent(monoBehaviour);
        }

        private ModuleContainer(KMBombModule solvable, KMNeedyModule needy, bool bypassCheck)
        {
            if (!bypassCheck && (bool)solvable == needy)
                throw new
#if LITE
                    KeepCodingException(
#else
                    ConstructorArgumentException(
#endif
                        solvable ? "Both KMBombModule and KMNeedyModule are assigned, which will mean that it is unable to return both when calling a function that returns a single MonoBehaviour." : "Both KMBombModule and KMNeedyModule is null, and since this data type is immutable after the constructor, it is unable to return anything.");

            _bombModule = solvable;
            _needyModule = needy;
        }

        /// <summary>
        /// Determines whether this instance is a non-module, which are <see cref="ComponentPool.ComponentTypeEnum.Empty"/> or <see cref="ComponentPool.ComponentTypeEnum.Timer"/>.
        /// </summary>
        public bool IsEmptyOrTimer => OfType(
            _ => false,
            _ => false,
            () => ((BombComponent)_bombComponent).ComponentType is ComponentTypeEnum.Empty || ((BombComponent)_bombComponent).ComponentType is ComponentTypeEnum.Timer);

        /// <summary>
        /// Determines whether this instance contains a modded module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsModded => !IsVanilla;

        /// <summary>
        /// Determines whether this instance isn't a non-module, which are <see cref="ComponentPool.ComponentTypeEnum.Empty"/> or <see cref="ComponentPool.ComponentTypeEnum.Timer"/>.
        /// </summary>
        public bool IsModule => !IsEmptyOrTimer;

        /// <summary>
        /// Determines whether this instance contains a needy module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsNeedy => OfType(
            _ => false,
            _ => true,
            () => IsModule && _bombComponent is NeedyComponent);

        /// <summary>
        /// Determines whether this instance contains a vanilla module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsVanilla => OfType(
            _ => false,
            _ => false,
            () => true);

        /// <summary>
        /// Determines whether this instance contains a solvable module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsSolvable => IsModule && !IsNeedy;

        /// <summary>
        /// Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool RequiresTimerVisibility
        {
            get => OfType(
                b => b.RequiresTimerVisibility,
                n => n.RequiresTimerVisibility,
                () => ((BombComponent)_bombComponent).RequiresTimerVisibility);
            set => OfType(
                b => b.RequiresTimerVisibility = value,
                n => n.RequiresTimerVisibility = value,
                () => ((BombComponent)_bombComponent).RequiresTimerVisibility = value);
        }

        /// <summary>
        /// Needy Only: Determines whether <see cref="Sound.NeedyWarning"/> plays when 5 seconds or less remain.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public bool NeedyWarnAtFiveSeconds
        {
            get => OfType(
                _ => throw Missing,
                n => n.WarnAtFiveSeconds,
                () => ((NeedyTimer)NeedyTimer).WarnTime is 5);
            set => OfType(
                _ => throw Missing,
                n => n.WarnAtFiveSeconds = value,
                () => ((NeedyTimer)NeedyTimer).WarnTime = value ? 5 : 0);
        }

        /// <summary>
        /// Needy Only: The amount of time on the needy timer whenever this module is activated.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public float NeedyStartingTime
        {
            get => OfType(
                _ => throw Missing,
                n => n.CountdownTime,
                () => _bombComponent is NeedyComponent needy ? needy.CountdownTime : throw Missing);
            set => OfType(
                _ => throw Missing,
                n => n.CountdownTime = value,
                () => (_bombComponent is NeedyComponent needy ? needy : throw Missing).CountdownTime = value);
        }

        /// <summary>
        /// The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID". This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ImmutableException"></exception>
        public string Id
        {
            get => OfType(
                b => b.ModuleType,
                n => n.ModuleType,
                () => ((BombComponent)_bombComponent).ComponentType.ToString());
            set => OfType(
                b => b.ModuleType = value,
                n => n.ModuleType = value,
                () => throw s_immutable);
        }

        /// <summary>
        /// The nice display name shown to players. e.g. "The Button". This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ImmutableException"></exception>
        public string Name
        {
            get => OfType(
                b => b.ModuleDisplayName,
                n => n.ModuleDisplayName,
                () => ((BombComponent)_bombComponent).GetModuleDisplayName());
            set => OfType(
                b => b.ModuleDisplayName = value,
                n => n.ModuleDisplayName = value,
                () => throw s_immutable);
        }

        /// <summary>
        /// Returns BombComponent boxed as <see cref="object"/>, or if <see langword="null"/>, throws a <see cref="NullReferenceException"/>.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        public object Vanilla => _bombComponent.NullCheck("BombComponent is null, yet you are trying to access it.");

        /// <summary>
        /// Invoked when the lights turn on. This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ImmutableException"></exception>
        public ModuleEvent<Action> Activate => _activate ??= new ModuleEvent<Action>(AddActivate, GetActivate, RemoveActivate, SetActivate, SignatureActivate);
        private ModuleEvent<Action> _activate;

        private void AddActivate(object value) => OfType(
            b => b.OnActivate += (KMBombModule.KMModuleActivateEvent)value,
            n => n.OnActivate += (KMNeedyModule.KMModuleActivateEvent)value,
            () => throw s_immutable);

        private void SetActivate(object value) => OfType(
            b => b.OnActivate = (KMBombModule.KMModuleActivateEvent)value,
            n => n.OnActivate = (KMNeedyModule.KMModuleActivateEvent)value,
            () => throw s_immutable);

        private void RemoveActivate(object value) => OfType(
            b => b.OnActivate -= (KMBombModule.KMModuleActivateEvent)value,
            n => n.OnActivate -= (KMNeedyModule.KMModuleActivateEvent)value,
            () => throw s_immutable);

        private Action GetActivate() => OfType<Action>(
            b => () => b.OnActivate(),
            n => () => n.OnActivate(),
            () => ((BombComponent)_bombComponent).Activate);

        private Type SignatureActivate() => OfType(
            _ => typeof(KMBombModule.KMModuleActivateEvent),
            _ => typeof(KMNeedyModule.KMModuleActivateEvent),
            () => throw s_immutable);

        /// <summary>
        /// Modded Needy Only: Invoked when the needy activates.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Action> NeedyActivate => _needyActivate ??= new ModuleEvent<Action>(AddNeedyActivate, GetNeedyActivate, RemoveNeedyActivate, SetNeedyActivate, SignatureNeedyActivate);
        private ModuleEvent<Action> _needyActivate;

        private void AddNeedyActivate(object value) => OfType(
            null,
            n => n.OnNeedyActivation += (KMNeedyModule.KMNeedyActivationEvent)value,
            null);

        private void SetNeedyActivate(object value) => OfType(
            null,
            n => n.OnNeedyActivation = (KMNeedyModule.KMNeedyActivationEvent)value,
            null);

        private void RemoveNeedyActivate(object value) => OfType(
            null,
            n => n.OnNeedyActivation -= (KMNeedyModule.KMNeedyActivationEvent)value,
            null);

        private Action GetNeedyActivate() => OfType<Action>(
            null,
            n => () => n.OnNeedyActivation(),
            null);

        private Type SignatureNeedyActivate() => OfType(
            null,
            _ => typeof(KMNeedyModule.KMNeedyActivationEvent),
            null);

        /// <summary>
        /// Modded Needy Only: Invoked when the needy deactivates.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Action> NeedyDeactivate => _needyDeactivate ??= new ModuleEvent<Action>(AddNeedyDeactivate, GetNeedyDeactivate, RemoveNeedyDeactivate, SetNeedyDeactivate, SignatureNeedyDeactivate);
        private ModuleEvent<Action> _needyDeactivate;

        private void AddNeedyDeactivate(object value) => OfType(
            null,
            n => n.OnNeedyDeactivation += (KMNeedyModule.KMNeedyDeactivationEvent)value,
            null);

        private void SetNeedyDeactivate(object value) => OfType(
            null,
            n => n.OnNeedyDeactivation = (KMNeedyModule.KMNeedyDeactivationEvent)value,
            null);

        private void RemoveNeedyDeactivate(object value) => OfType(
            null,
            n => n.OnNeedyDeactivation -= (KMNeedyModule.KMNeedyDeactivationEvent)value,
            null);

        private Action GetNeedyDeactivate() => OfType<Action>(
            null,
            n => () => n.OnNeedyDeactivation(),
            null);

        private Type SignatureNeedyDeactivate() => OfType(
            null,
            _ => typeof(KMNeedyModule.KMNeedyDeactivationEvent),
            null);

        /// <summary>
        /// Needy Only: Invoked when the needy timer expires.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Action> NeedyTimerExpired => _needyTimerExpired ??= new ModuleEvent<Action>(AddNeedyTimerExpired, GetNeedyTimerExpired, RemoveNeedyTimerExpired, SetNeedyTimerExpired, SignatureNeedyTimerExpired);
        private ModuleEvent<Action> _needyTimerExpired;

        private void AddNeedyTimerExpired(object value) => OfType(
            null,
            n => n.OnTimerExpired += (KMNeedyModule.KMTimerExpiredEvent)value,
            () => ((NeedyTimer)NeedyTimer).OnTimerExpire += (NeedyTimerExpireEvent)value);

        private void SetNeedyTimerExpired(object value) => OfType(
            null,
            n => n.OnTimerExpired = (KMNeedyModule.KMTimerExpiredEvent)value,
            () => ((NeedyTimer)NeedyTimer).OnTimerExpire = (NeedyTimerExpireEvent)value);

        private void RemoveNeedyTimerExpired(object value) => OfType(
            null,
            n => n.OnTimerExpired -= (KMNeedyModule.KMTimerExpiredEvent)value,
            () => ((NeedyTimer)NeedyTimer).OnTimerExpire -= (NeedyTimerExpireEvent)value);

        private Action GetNeedyTimerExpired() => OfType<Action>(
            null,
            n => () => n.OnTimerExpired(),
            () => _bombComponent is NeedyComponent needy ? (Action)(() => ((NeedyTimer)NeedyTimer).OnTimerExpire()) : throw Missing);

        private Type SignatureNeedyTimerExpired() => OfType(
            null,
            _ => typeof(KMNeedyModule.KMTimerExpiredEvent),
            () => typeof(NeedyTimerExpireEvent));

        /// <summary>
        /// Call this when the entire module has been solved.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Action> Solve => _solve ??= new ModuleEvent<Action>(AddSolve, GetSolve, RemoveSolve, SetSolve, SignatureSolve, Converter);
        private ModuleEvent<Action> _solve;

        private void AddSolve(object value) => OfType(
            b => b.OnPass += (KMBombModule.KMPassEvent)value,
            n => n.OnPass += (KMNeedyModule.KMPassEvent)value,
            () => ((BombComponent)_bombComponent).OnPass += (PassEvent)value);

        private void SetSolve(object value) => OfType(
            b => b.OnPass += (KMBombModule.KMPassEvent)value,
            n => n.OnPass += (KMNeedyModule.KMPassEvent)value,
            () => ((BombComponent)_bombComponent).OnPass += (PassEvent)value);

        private void RemoveSolve(object value) => OfType(
            b => b.OnPass -= (KMBombModule.KMPassEvent)value,
            n => n.OnPass -= (KMNeedyModule.KMPassEvent)value,
            () => ((BombComponent)_bombComponent).OnPass -= (PassEvent)value);

        private Action GetSolve() => OfType<Action>(
            b => () => b.OnPass(),
            n => () => n.OnPass(),
            () => () => ((BombComponent)_bombComponent).OnPass(null));

        private Type SignatureSolve() => OfType(
            _ => typeof(KMBombModule.KMPassEvent),
            _ => typeof(KMNeedyModule.KMPassEvent),
            () => typeof(PassEvent));

        /// <summary>
        /// Call this on any mistake that you want to cause a bomb strike.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Action> Strike => _strike ??= new ModuleEvent<Action>(AddStrike, GetStrike, RemoveStrike, SetStrike, SignatureStrike, Converter);
        private ModuleEvent<Action> _strike;

        private void AddStrike(object value) => OfType(
            b => b.OnStrike += (KMBombModule.KMStrikeEvent)value,
            n => n.OnStrike += (KMNeedyModule.KMStrikeEvent)value,
            () => ((BombComponent)_bombComponent).OnStrike += (StrikeEvent)value);

        private void SetStrike(object value) => OfType(
            b => b.OnStrike = (KMBombModule.KMStrikeEvent)value,
            n => n.OnStrike = (KMNeedyModule.KMStrikeEvent)value,
            () => ((BombComponent)_bombComponent).OnStrike = (StrikeEvent)value);

        private void RemoveStrike(object value) => OfType(
            b => b.OnStrike -= (KMBombModule.KMStrikeEvent)value,
            n => n.OnStrike -= (KMNeedyModule.KMStrikeEvent)value,
            () => ((BombComponent)_bombComponent).OnStrike -= (StrikeEvent)value);

        private Action GetStrike() => OfType<Action>(
            b => () => b.OnStrike(),
            n => () => n.OnStrike(),
            () => () => ((BombComponent)_bombComponent).OnStrike(null));

        private Type SignatureStrike() => OfType(
            _ => typeof(KMBombModule.KMStrikeEvent),
            _ => typeof(KMNeedyModule.KMStrikeEvent),
            () => typeof(StrikeEvent));

        /// <summary>
        /// Needy Only: An encapsulated <see cref="Action{T}"/> that when called, sets the time remaining to the parameter passed in. This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ImmutableException"></exception>
        public ModuleEvent<Action<float>> NeedyTimerSet => _needyTimerSet ??= new ModuleEvent<Action<float>>(AddNeedyTimerSet, GetNeedyTimerSet, RemoveNeedyTimerSet, SetNeedyTimerSet, SignatureNeedyTimerSet);
        private ModuleEvent<Action<float>> _needyTimerSet;

        private void AddNeedyTimerSet(object value) => OfType(
            null,
            n => n.SetNeedyTimeRemainingHandler += (KMNeedyModule.KMSetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private void SetNeedyTimerSet(object value) => OfType(
            null,
            n => n.SetNeedyTimeRemainingHandler = (KMNeedyModule.KMSetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private void RemoveNeedyTimerSet(object value) => OfType(
            null,
            n => n.SetNeedyTimeRemainingHandler -= (KMNeedyModule.KMSetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private Action<float> GetNeedyTimerSet() => OfType<Action<float>>(
            null,
            n => f => n.SetNeedyTimeRemainingHandler(f),
            () => (Action<float>)(f => ((NeedyTimer)NeedyTimer).TimeRemaining = f));

        private Type SignatureNeedyTimerSet() => OfType(
            null,
            _ => typeof(KMNeedyModule.KMSetNeedyTimeRemainingDelegate),
            () => throw s_immutable);

        /// <summary>
        /// Modded Only: Returns the random seed used to generate the rules for this game. Not currently used.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public ModuleEvent<Func<int>> RuleGeneration => _ruleGeneration ??= new ModuleEvent<Func<int>>(AddRuleGeneration, GetRuleGeneration, RemoveRuleGeneration, SetRuleGeneration, SignatureRuleGeneration);
        private ModuleEvent<Func<int>> _ruleGeneration;

        private void AddRuleGeneration(object value) => OfType(
            b => b.GetRuleGenerationSeedHandler += (KMBombModule.KMRuleGenerationSeedDelegate)value,
            n => n.GetRuleGenerationSeedHandler += (KMNeedyModule.KMRuleGenerationSeedDelegate)value,
            null);

        private void SetRuleGeneration(object value) => OfType(
            b => b.GetRuleGenerationSeedHandler = (KMBombModule.KMRuleGenerationSeedDelegate)value,
            n => n.GetRuleGenerationSeedHandler = (KMNeedyModule.KMRuleGenerationSeedDelegate)value,
            null);

        private void RemoveRuleGeneration(object value) => OfType(
            b => b.GetRuleGenerationSeedHandler -= (KMBombModule.KMRuleGenerationSeedDelegate)value,
            n => n.GetRuleGenerationSeedHandler -= (KMNeedyModule.KMRuleGenerationSeedDelegate)value,
            null);

        private Func<int> GetRuleGeneration() => OfType<Func<int>>(
            b => () => b.GetRuleGenerationSeedHandler(),
            n => () => n.GetRuleGenerationSeedHandler(),
            null);

        private Type SignatureRuleGeneration() => OfType(
            _ => typeof(KMBombModule.KMRuleGenerationSeedDelegate),
            _ => typeof(KMNeedyModule.KMRuleGenerationSeedDelegate),
            null);

        /// <summary>
        /// Needy Only: An encapsulated <see cref="Func{T}"/> that when called, gets the time remaining. This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ImmutableException"></exception>
        public ModuleEvent<Func<float>> NeedyTimerGet => _needyTimerGet ??= new ModuleEvent<Func<float>>(AddNeedyTimerGet, GetNeedyTimerGet, RemoveNeedyTimerGet, SetNeedyTimerGet, SignatureNeedyTimerGet);
        private ModuleEvent<Func<float>> _needyTimerGet;

        private void AddNeedyTimerGet(object value) => OfType(
            null,
            n => n.GetNeedyTimeRemainingHandler += (KMNeedyModule.KMGetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private void SetNeedyTimerGet(object value) => OfType(
            null,
            n => n.GetNeedyTimeRemainingHandler = (KMNeedyModule.KMGetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private void RemoveNeedyTimerGet(object value) => OfType(
            null,
            n => n.GetNeedyTimeRemainingHandler -= (KMNeedyModule.KMGetNeedyTimeRemainingDelegate)value,
            () => throw s_immutable);

        private Func<float> GetNeedyTimerGet() => OfType<Func<float>>(
            null,
            n => () => n.GetNeedyTimeRemainingHandler(),
            () => (Func<float>)(() => ((NeedyTimer)NeedyTimer).TimeRemaining));

        private Type SignatureNeedyTimerGet() => OfType(
            null,
            _ => typeof(KMNeedyModule.KMGetNeedyTimeRemainingDelegate),
            () => throw s_immutable);

        /// <summary>
        /// Returns <see cref="KMBombModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        [CLSCompliant(false)]
        public KMBombModule Solvable => _bombModule.NullCheck("KMBombModule is null, yet you are trying to access it.");

        /// <summary>
        /// Returns <see cref="KMNeedyModule"/>, or if null, throws a <see cref="NullReferenceException"/>.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        [CLSCompliant(false)]
        public KMNeedyModule Needy => _needyModule.NullCheck("KMNeedyModule is null, yet you are trying to access it.");

        /// <summary>
        /// Returns <see cref="KMBombModule"/>, or if <see langword="null"/>, <see cref="KMNeedyModule"/>, or if <see langword="null"/>, BombComponent, or if <see langword="null"/>, throws.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        [CLSCompliant(false)]
        public MonoBehaviour Module => _bombComponent as MonoBehaviour ?? _bombModule as MonoBehaviour ?? _needyModule ?? throw s_none;

        /// <summary>
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Solvable"/> is defined.
        /// </summary>
        /// <param name="solvable">The solvable module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="solvable"/>.</returns>
        [CLSCompliant(false)]
        public static implicit operator ModuleContainer(KMBombModule solvable) => new ModuleContainer(solvable: solvable);

        /// <summary>
        /// Creates a new instance of <see cref="ModuleContainer"/> where <see cref="Needy"/> is defined.
        /// </summary>
        /// <param name="needy">The needy module to create a new <see cref="ModuleContainer"/> of.</param>
        /// <returns>A <see cref="ModuleContainer"/> with parameter <paramref name="needy"/>.</returns>
        [CLSCompliant(false)]
        public static implicit operator ModuleContainer(KMNeedyModule needy) => new ModuleContainer(needy: needy);

        /// <summary>
        /// Returns the instance of <see cref="KMBombModule"/> from <see cref="Solvable"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMBombModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Solvable"/>.</returns>
        [CLSCompliant(false)]
        public static explicit operator KMBombModule(ModuleContainer container) => container.Solvable;

        /// <summary>
        /// Returns the instance of <see cref="KMNeedyModule"/> from <see cref="Needy"/>.
        /// </summary>
        /// <param name="container">The <see cref="ModuleContainer"/> to get the <see cref="KMNeedyModule"/> from.</param>
        /// <returns>A <see cref="KMBombModule"/> from <see cref="Needy"/>.</returns>
        [CLSCompliant(false)]
        public static explicit operator KMNeedyModule(ModuleContainer container) => container.Needy;

        private object NeedyTimer => _needyTimer ??= ((_bombComponent is NeedyComponent needy ? needy : throw Missing).GetComponentInChildren(typeof(NeedyTimer)));
        private object _needyTimer;

        private MissingMethodException Missing => new MissingMethodException($"The current type of the component (\"{Module.GetType().Name}\") lacks this method.");

        /// <summary>
        /// Appends events to this instance, preserving their existing values.
        /// </summary>
        /// <param name="activate">Called when the lights turn on.</param>
        /// <param name="needyActivate">Called when the needy activates.</param>
        /// <param name="needyDeactivate">Called when the needy deactivates.</param>
        /// <param name="needyTimerExpired">Called when the timer runs out of time.</param>
        /// <param name="solve">Called when the needy is solved.</param>
        /// <param name="strike">Called when the needy strikes.</param>
        /// <param name="needyTimerSet">Called when <see cref="KMNeedyModule.GetNeedyTimeRemaining"/> is called.</param>
        /// <param name="ruleGeneration">Called when <see cref="KMBombModule.GetRuleGenerationSeed"/> or <see cref="KMNeedyModule.GetRuleGenerationSeed"/> is called.</param>
        /// <param name="needyTimerGet">Called when <see cref="KMNeedyModule.SetNeedyTimeRemaining(float)"/> is called.</param>
        public void Append(Action activate = null, Action needyActivate = null, Action needyDeactivate = null, Action needyTimerExpired = null, Action solve = null, Action strike = null, Action<float> needyTimerSet = null, Func<int> ruleGeneration = null, Func<float> needyTimerGet = null)
        {
            if (activate is { })
                Activate.Add(activate);
            if (solve is { })
                Solve.Add(solve);
            if (strike is { })
                Strike.Add(strike);

            if (needyTimerSet is { })
                NeedyTimerSet.Add(needyTimerSet);
            if (ruleGeneration is { })
                RuleGeneration.Add(ruleGeneration);
            if (needyTimerGet is { })
                NeedyTimerGet.Add(needyTimerGet);

            if (IsSolvable)
                return;

            if (needyActivate is { })
                NeedyActivate.Add(needyActivate);
            if (needyDeactivate is { })
                NeedyDeactivate.Add(needyDeactivate);
            if (needyTimerExpired is { })
                NeedyTimerExpired.Add(needyTimerExpired);
        }
        /// <summary>
        /// Assigns events to this instance, replacing their existing values.
        /// </summary>
        /// <param name="activate">Called when the lights turn on.</param>
        /// <param name="needyActivate">Called when the needy activates.</param>
        /// <param name="needyDeactivate">Called when the needy deactivates.</param>
        /// <param name="needyTimerExpired">Called when the timer runs out of time.</param>
        /// <param name="solve">Called when the needy is solved.</param>
        /// <param name="strike">Called when the needy strikes.</param>
        /// <param name="needyTimerSet">Called when <see cref="KMNeedyModule.GetNeedyTimeRemaining"/> is called.</param>
        /// <param name="ruleGeneration">Called when <see cref="KMBombModule.GetRuleGenerationSeed"/> or <see cref="KMNeedyModule.GetRuleGenerationSeed"/> is called.</param>
        /// <param name="needyTimerGet">Called when <see cref="KMNeedyModule.SetNeedyTimeRemaining(float)"/> is called.</param>
        public void Assign(Action activate = null, Action needyActivate = null, Action needyDeactivate = null, Action needyTimerExpired = null, Action solve = null, Action strike = null, Action<float> needyTimerSet = null, Func<int> ruleGeneration = null, Func<float> needyTimerGet = null)
        {
            if (activate is { })
                Activate.Set(activate);
            if (solve is { })
                Solve.Set(solve);
            if (strike is { })
                Strike.Set(strike);

            if (needyTimerSet is { })
                NeedyTimerSet.Set(needyTimerSet);
            if (ruleGeneration is { })
                RuleGeneration.Set(ruleGeneration);
            if (needyTimerGet is { })
                NeedyTimerGet.Set(needyTimerGet);

            if (IsSolvable)
                return;

            if (needyActivate is { })
                NeedyActivate.Set(needyActivate);
            if (needyDeactivate is { })
                NeedyDeactivate.Set(needyDeactivate);
            if (needyTimerExpired is { })
                NeedyTimerExpired.Set(needyTimerExpired);
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
        public bool Equals(ModuleContainer other) => other is { } && Module == other.Module;

        /// <summary>
        /// Gets the current hash code.
        /// </summary>
        /// <returns>The <see cref="Module"/>'s hash code.</returns>
        public override int GetHashCode() => 1212890949 + EqualityComparer<MonoBehaviour>.Default.GetHashCode(Module);

        /// <summary>
        /// Gets the <see cref="Name"/> and <see cref="Id"/> of the module.
        /// </summary>
        /// <returns><see cref="Name"/> and <see cref="Id"/></returns>
        public override string ToString() => $"{Name} ({Id})";

        private void AssignBombComponent(object component)
        {
            if (component is BombComponent)
                _bombComponent = component;
        }

        private void OfType(Action<KMBombModule> onBombModule, Action<KMNeedyModule> onNeedyModule, Action onBombComponent)
        {
            switch (Module)
            {
                case KMBombModule bombModule:
                    onBombModule(bombModule);
                    break;

                case KMNeedyModule needyModule:
                    onNeedyModule(needyModule);
                    break;

                case MonoBehaviour _:
                    if (IsKtane)
                        onBombComponent();
                    else
                        throw s_none;
                    break;

                default:
                    throw s_none;
            }
        }

        private Delegate Converter(Action action) => OfType<Delegate>(
            _ => (Func<bool>)(() =>
            {
                action();
                return false;
            }),
            _ => (Func<bool>)(() =>
            {
                action();
                return false;
            }),
            () => (Func<MonoBehaviour, bool>)(_ =>
            {
                action();
                return false;
            }));

        private T OfType<T>(Func<KMBombModule, T> onBombModule, Func<KMNeedyModule, T> onNeedyModule, Func<T> onBombComponent) => Module switch
        {
            KMBombModule bombModule => (onBombModule ?? throw Missing).Invoke(bombModule),
            KMNeedyModule needyModule => (onNeedyModule ?? throw Missing)(needyModule),
            MonoBehaviour _ => IsKtane ? (onBombComponent ?? throw Missing)() : throw s_none,
            _ => throw s_none
        };
    }
}
