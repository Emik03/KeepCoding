using System;
using System.Collections.Generic;
using System.Data;
using KeepCoding.Internal;
using UnityEngine;
using static System.Delegate;
using static KeepCoding.Game;

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

        private static readonly MissingReferenceException s_none = new MissingReferenceException($"{nameof(Module)} is none of {nameof(KMBombModule)}, {nameof(KMNeedyModule)}, or BombComponent.");

        private static readonly ReadOnlyException s_immutable = new ReadOnlyException("This member is immutable.");

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
        /// Encapsulates either a solvable or needy module. If a BombComponent (or derived) is passed in, the vanilla module component will be stored instead. Uses <see cref="Component.GetComponent{T}"/>. An exception is thrown if <see cref="KMBombModule"/> and <see cref="KMNeedyModule"/> are both <see langword="null"/> or both not <see langword="null"/>.
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
                throw new ConstructorArgumentException(solvable ? "Both KMBombModule and KMNeedyModule are assigned, which will mean that it is unable to return both when calling a function that returns a single MonoBehaviour." : "Both KMBombModule and KMNeedyModule is null, and since this data type is immutable after the constructor, it is unable to return anything.");

            _bombModule = solvable;
            _needyModule = needy;
        }

        /// <summary>
        /// Determines whether this instance contains a modded module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsModded => !IsVanilla;

        /// <summary>
        /// Determines whether this instance contains a needy module.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        public bool IsNeedy => OfType(
            _ => false,
            _ => true,
            () => _bombComponent is NeedyComponent);

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
        public bool IsSolvable => !IsNeedy;

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
        public bool WarnAtFiveSeconds
        {
            get => OfType(
                b => throw Missing,
                n => n.WarnAtFiveSeconds,
                () => ((NeedyTimer)NeedyTimer).WarnTime is 5);
            set => OfType(
                b => throw Missing,
                n => n.WarnAtFiveSeconds = value,
                () => ((NeedyTimer)NeedyTimer).WarnTime = value ? 5 : 0);
        }

        /// <summary>
        /// Needy Only: The amount of time on the needy timer whenever this module is activated.
        /// </summary>
        /// <exception cref="MissingMethodException"></exception>
        /// <exception cref="MissingReferenceException"></exception>
        public float StartingTime
        {
            get => OfType(
                b => throw Missing,
                n => n.CountdownTime,
                () => _bombComponent is NeedyComponent needy ? needy.CountdownTime : throw Missing);
            set => OfType(
                b => throw Missing,
                n => n.CountdownTime = value,
                () => (_bombComponent is NeedyComponent needy ? needy : throw Missing).CountdownTime = value);
        }

        /// <summary>
        /// The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID". This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ReadOnlyException"></exception>
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
        /// <exception cref="ReadOnlyException"></exception>
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
        [CLSCompliant(false)]
        public object Vanilla => _bombComponent.NullCheck("BombComponent is null, yet you are trying to access it.");

        /// <summary>
        /// Invoked when the lights turn on. This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        /// <exception cref="MissingReferenceException"></exception>
        /// <exception cref="ReadOnlyException"></exception>
        public Action Activate
        {
            get => OfType<Action>(
                b => () => b.OnActivate(),
                n => () => n.OnActivate(),
                () => ((BombComponent)_bombComponent).Activate);
            set => OfType(
                b => b.OnActivate = () => value(),
                n => n.OnActivate = () => value(),
                () => throw s_immutable);
        }

        /// <summary>
        /// Adder Only: A more efficient adder for <see cref="Activate"/>. This value is immutable for vanilla modules, and an exception will be thrown when attempted.
        /// </summary>
        public event Action ActivateAdder
        {
            add => OfType(
                b => b.OnActivate += () => value(),
                n => n.OnActivate += () => value(),
                () => throw s_immutable);
            remove 
        }

        public Action NeedyActivate
        {
            get => OfType<Action>(
                b => throw Missing,
                n => () => n.OnNeedyActivation(),
                () => throw Missing);
            set => OfType(
                b => throw Missing,
                n => n.OnNeedyActivation = () => value(),
                () => throw Missing);
        }

        public event Action NeedyActivateAdder
        {
            add => OfType(
                b => throw Missing,
                n => n.OnNeedyActivation += () => value(),
                () => throw Missing);
            remove { }
        }

        public Action NeedyDeactivate
        {
            get => OfType<Action>(
                b => throw Missing,
                n => () => n.OnNeedyDeactivation(),
                () => throw Missing);
            set => OfType(
                b => throw Missing,
                n => n.OnNeedyDeactivation = () => value(),
                () => throw Missing);
        }

        public event Action NeedyDeactivateAdder
        {
            add => OfType(
                b => throw Missing,
                n => n.OnNeedyActivation += () => value(),
                () => throw Missing);
            remove { }
        }

        public Action NeedyTimerExpired
        {
            get => OfType<Action>(
                b => throw Missing,
                n => () => n.OnTimerExpired(),
                () => _bombComponent is NeedyComponent needy ? (Action)(() => ((NeedyTimer)NeedyTimer).OnTimerExpire()) : throw Missing);
            set => OfType(
                b => throw Missing,
                n => n.OnTimerExpired = () => value(),
                () => ((NeedyTimer)NeedyTimer).OnTimerExpire = () => value());
        }

        public event Action NeedyTimerExpiredAdder
        {
            add => OfType(
                b => throw Missing,
                n => n.OnTimerExpired += () => value(),
                () => ((NeedyTimer)NeedyTimer).OnTimerExpire += () => value());
            remove { }
        }

        /// <summary>
        /// Call this when the entire module has been solved.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action Solve
        {
            get => OfType<Action>(
                b => () => b.OnPass(),
                n => () => n.OnPass(),
                () => () => ((BombComponent)_bombComponent).OnPass(null));
            set => OfType(
                b => b.OnPass = () =>
                {
                    value();
                    return false;
                },
                n => n.OnPass = () =>
                {
                    value();
                    return false;
                },
                () => ((BombComponent)_bombComponent).OnPass = (PassEvent)CreateDelegate(typeof(PassEvent), this, ((Func<MonoBehaviour, bool>)(m =>
                {
                    value();
                    return false;
                })).Method));
        }

        public event Action SolveAdder
        {
            add => OfType(
                b => b.OnPass += () =>
                {
                    value();
                    return false;
                },
                n => n.OnPass += () =>
                {
                    value();
                    return false;
                },
                () => ((BombComponent)_bombComponent).OnPass += (PassEvent)CreateDelegate(typeof(PassEvent), this, ((Func<MonoBehaviour, bool>)(m =>
                {
                    value();
                    return false;
                })).Method));
            remove { }
        }

        /// <summary>
        /// Call this on any mistake that you want to cause a bomb strike.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Action Strike
        {
            get => OfType<Action>(
                b => () => b.OnStrike(),
                n => () => n.OnStrike(),
                () => () => ((BombComponent)_bombComponent).OnStrike(null));
            set => OfType(
                b => b.OnStrike = () =>
                {
                    value();
                    return false;
                },
                n => n.OnStrike = () =>
                {
                    value();
                    return false;
                },
                () => ((BombComponent)_bombComponent).OnStrike = (StrikeEvent)CreateDelegate(typeof(StrikeEvent), this, ((Func<MonoBehaviour, bool>)(m =>
                {
                    value();
                    return false;
                })).Method));
        }

        public event Action StrikeAdder
        {
            add => OfType(
                b => b.OnStrike += () =>
                {
                    value();
                    return false;
                },
                n => n.OnStrike += () =>
                {
                    value();
                    return false;
                },
                () => ((BombComponent)_bombComponent).OnStrike += (StrikeEvent)CreateDelegate(typeof(StrikeEvent), this, ((Func<MonoBehaviour, bool>)(m =>
                {
                    value();
                    return false;
                })).Method));
            remove { }
        }

        public Action<float> NeedyTimerSet
        {
            get => OfType<Action<float>>(
                b => throw Missing,
                n => f => n.SetNeedyTimeRemainingHandler(f),
                () => (Action<float>)(f => ((NeedyTimer)NeedyTimer).TimeRemaining = f));
            set => OfType(
                b => throw Missing,
                n => n.SetNeedyTimeRemainingHandler = f => value(f),
                () => throw Missing);
        }

        public event Action<float> NeedyTimerSetAdder
        {
            add => OfType(
                b => throw Missing,
                n => n.SetNeedyTimeRemainingHandler = f => value(f),
                () => throw Missing);
            remove { }
        }

        /// <summary>
        /// Returns the random seed used to generate the rules for this game. Not currently used.
        /// </summary>
        /// <exception cref="UnrecognizedTypeException"></exception>
        public Func<int> RuleGeneration => OfType<Func<int>>(b => b.GetRuleGenerationSeed, n => n.GetRuleGenerationSeed, () => throw Missing);

        public Func<float> NeedyTimerGet
        {
            get => OfType<Func<float>>(
                b => throw Missing,
                n => () => n.GetNeedyTimeRemainingHandler(),
                () => (Func<float>)(() => ((NeedyTimer)NeedyTimer).TimeRemaining));
            set => OfType(
                b => throw Missing,
                n => n.GetNeedyTimeRemainingHandler = () => value(),
                () => throw Missing);
        }

        public event Func<float> NeedyTimerGetAdder
        {
            add => OfType(
                b => throw Missing,
                n => n.GetNeedyTimeRemainingHandler += () => value(),
                () => throw Missing);
            remove { }
        }

        public Tuple<float, float> ResetDelay
        {
            get => OfType(
                b => throw Missing,
                n => n.ResetDelayMin.ToTuple(n.ResetDelayMax),
                () => _bombComponent is NeedyComponent needy ? needy.ResetDelayMin.ToTuple(needy.ResetDelayMax) : throw Missing);
            set => OfType(
                b => throw Missing,
                n => value.Destruct(out n.ResetDelayMin, out n.ResetDelayMax),
                () => value.Destruct(out (_bombComponent is NeedyComponent needy ? needy : throw Missing).ResetDelayMin, out needy.ResetDelayMax));
        }

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
            Activate = onActivate;
            throw new NotImplementedException();
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

        internal void AssignBombComponent(object component)
        {
            if (component is BombComponent)
                _bombComponent = component;
        }

        internal void OfType(Action<KMBombModule> onBombModule, Action<KMNeedyModule> onNeedyModule, Action onBombComponent)
        {
            switch (Module)
            {
                case KMBombModule bombModule:
                    onBombModule(bombModule);
                    break;

                case KMNeedyModule needyModule:
                    onNeedyModule(needyModule);
                    break;

                case Component _:
                    if (IsKtane)
                        onBombComponent();
                    else
                        throw s_none;
                    break;
            }

            throw s_none;
        }

        internal T OfType<T>(Func<KMBombModule, T> onBombModule, Func<KMNeedyModule, T> onNeedyModule, Func<T> onBombComponent) => Module switch
        {
            KMBombModule bombModule => onBombModule(bombModule),
            KMNeedyModule needyModule => onNeedyModule(needyModule),
            Component _ => IsKtane ? onBombComponent() : throw s_none,
            _ => throw s_none
        };
    }
}
