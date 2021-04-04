using System;
using UnityEngine;

namespace KeepCodingAndNobodyExplodes
{
    /// <summary>
    /// KMFramework extension methods that makes it easier to assign multiple events to a variable in one statement. Written by Emik.
    /// </summary>
    public static class EventHelper
    {
        /// <summary>
        /// Assigns events specified into <paramref name="kmSelectable"/>. Reassigning them will replace their values. The number passed into each method represents the index that came from the array.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.
        /// </remarks>
        /// <exception cref="NullIteratorException"></exception>
        /// <exception cref="EmptyIteratorException"></exception>
        /// <exception cref="UnassignedReferenceException"></exception>
        /// <param name="kmSelectable">The <see cref="KMSelectable"/> array to add events to.</param>
        /// <param name="onCancel">Called when player backs out of this selectable.</param>
        /// <param name="onDefocus">Called when a different selectable becomes the focus, or the module has been backed out of.</param>
        /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
        /// <param name="onFocus">Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected.</param>
        /// <param name="onHighlight">Called when the highlight is turned on. This will not work correctly in Virtual Reality.</param>
        /// <param name="onHighlightEnded">Called when the highlight is turned off. This will not work correctly in Virtual Reality.</param>
        /// <param name="onInteract">Called when player interacts with the selctable.</param>
        /// <param name="onInteractEnded">Called when a player interacting with the selectable releases the mouse or controller button.</param>
        /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
        /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
        /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
        /// <param name="overrideBoolean">Return true will make it act as a module/submodule, and false as a button.</param>
        public static void Assign(this KMSelectable[] kmSelectable, Action<int> onCancel = null, Action<int> onDefocus = null, Action<int> onDeselect = null, Action<int> onFocus = null, Action<int> onHighlight = null, Action<int> onHighlightEnded = null, Action<int> onInteract = null, Action<int> onInteractEnded = null, Action<int> onLeft = null, Action<int> onRight = null, Action<int> onSelect = null, bool? overrideBoolean = null)
        {
            kmSelectable.ThrowIfNullOrEmpty("The array is not populated. Please check your public fields in Unity.");

            kmSelectable.Call((s, i) => s.Assign(
                onCancel.ToAction(i),
                onDefocus.ToAction(i),
                onDeselect.ToAction(i),
                onFocus.ToAction(i),
                onHighlight.ToAction(i),
                onHighlightEnded.ToAction(i),
                onInteract.ToAction(i),
                onInteractEnded.ToAction(i),
                onLeft.ToAction(i),
                onRight.ToAction(i),
                onSelect.ToAction(i),
                overrideBoolean));
        }

        /// <summary>
        /// Assigns events specified into <paramref name="kmSelectable"/>. Reassigning them will replace their values.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.
        /// </remarks>
        /// <exception cref="UnassignedReferenceException"></exception>
        /// <param name="kmSelectable">The KMSelectable array to add events to.</param>
        /// <param name="onCancel">Called when player backs out of this selectable. Return true will make it act as a module/submodule, and false as a button.</param>
        /// <param name="onDefocus">Called when a different selectable becomes the focus, or the module has been backed out of.</param>
        /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
        /// <param name="onFocus">Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected.</param>
        /// <param name="onHighlight">Called when the highlight is turned on. This will not work correctly in Virtual Reality.</param>
        /// <param name="onHighlightEnded">Called when the highlight is turned off. This will not work correctly in Virtual Reality.</param>
        /// <param name="onInteract">Called when player interacts with the selctable. Return true will make it act as a module/submodule, and false as a button.</param>
        /// <param name="onInteractEnded">Called when a player interacting with the selectable releases the mouse or controller button.</param>
        /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
        /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
        /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
        /// <param name="overrideBoolean">Return true will make it act as a module/submodule, and false as a button.</param>
        public static void Assign(this KMSelectable kmSelectable, Action onCancel = null, Action onDefocus = null, Action onDeselect = null, Action onFocus = null, Action onHighlight = null, Action onHighlightEnded = null, Action onInteract = null, Action onInteractEnded = null, Action onLeft = null, Action onRight = null, Action onSelect = null, bool? overrideBoolean = null)
        {
            if (kmSelectable is null)
                throw new UnassignedReferenceException("The KMSelectable is null. You cannot assign events to a KMSelectable without a reference to a KMSelectable.");

            overrideBoolean ??= kmSelectable.IsParent();

            onCancel.ToFunc(overrideBoolean.Value).Set(ref kmSelectable.OnCancel);
            onDefocus.Set(ref kmSelectable.OnDefocus);
            onDeselect.Set(ref kmSelectable.OnDeselect);
            onFocus.Set(ref kmSelectable.OnFocus);
            onHighlight.Set(ref kmSelectable.OnHighlight);
            onHighlightEnded.Set(ref kmSelectable.OnHighlightEnded);
            onInteract.ToFunc(overrideBoolean.Value).Set(ref kmSelectable.OnInteract);
            onInteractEnded.Set(ref kmSelectable.OnInteractEnded);
            onLeft.Set(ref kmSelectable.OnLeft);
            onRight.Set(ref kmSelectable.OnRight);
            onSelect.Set(ref kmSelectable.OnSelect);
        }

        /// <summary>
        /// Assigns events specified into <paramref name="kmGameInfo"/>. Reassigning them will replace their values.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.
        /// </remarks>
        /// <param name="kmGameInfo">The game info instance to assign events to.</param>
        /// <param name="onAlarmClockChange">Called when the alarm clock changes state, and passes in whether it's on or off.</param>
        /// <param name="onLightsChange">Called when the lights change state, and passes in whether it's on or off.</param>
        public static void Assign(this KMGameInfo kmGameInfo, Action<bool> onAlarmClockChange = null, Action<bool> onLightsChange = null)
        {
            onAlarmClockChange.Set(ref kmGameInfo.OnAlarmClockChange);
            onLightsChange.Set(ref kmGameInfo.OnLightsChange);
        }

        /// <summary>
        /// Assigns events specified into <paramref name="kmBombInfo"/>. Reassigning them will replace their values.
        /// </summary>
        /// <remarks>
        /// An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.
        /// </remarks>
        /// <param name="kmBombInfo">The bomb info instance to assign events to.</param>
        /// <param name="onBombExploded">Called when the bomb explodes.</param>
        /// <param name="onBombSolved">Called when the bomb is defused.</param>
        public static void Assign(this KMBombInfo kmBombInfo, Action onBombExploded = null, Action onBombSolved = null)
        {
            onBombExploded.Set(ref kmBombInfo.OnBombExploded);
            onBombSolved.Set(ref kmBombInfo.OnBombSolved);
        }

        /// <summary>
        /// Casts a <see cref="Delegate"/> onto the type <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>
        /// Both types must have the same parameter and return types, and the <paramref name="dele"/> argument cannot have its <see cref="Delegate.Target"/> or <see cref="Delegate.Method"/> be null.
        /// </remarks>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type to cast the delegate into.</typeparam>
        /// <param name="dele">The delegate to cast.</param>
        /// <returns><paramref name="dele"/> as <typeparamref name="T"/>.</returns>
        public static T Cast<T>(this Delegate dele) where T : Delegate
        {
            if (dele is null) 
                return null;

            var multicast = (dele as MulticastDelegate)?.GetInvocationList();

            if (multicast is not null)
            {
                switch (multicast.Length)
                {
                    case 0:
                        return null;

                    case 1:
                        if (multicast[0] != dele)
                            return multicast[0].Cast<T>();
                        break;

                    default:
                        var convertedItems = new Delegate[multicast.Length];

                        for (int i = 0; i < multicast.Length; i++)
                            convertedItems[i] = (Delegate)(object)multicast[i].Cast<T>();

                        return (T)Delegate.Combine(convertedItems);
                }
            }

            return (T)Delegate.CreateDelegate(typeof(T), dele.Target, dele.Method, true);
        }

        /// <summary>
        /// Adds a <see cref="Delegate"/> onto the referenced variable.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <typeparam name="T">The type of the <paramref name="mutator"/> and <see cref="Delegate"/> casting.</typeparam>
        /// <param name="dele">The <see cref="Delegate"/> to add.</param>
        /// <param name="mutator">The variable that transmutates and adds <paramref name="dele"/> onto itself.</param>
        public static void Set<T>(this Delegate dele, ref T mutator) where T : Delegate => mutator = dele is null ? mutator : dele.Cast<T>();

        private static Action ToAction(this Action<int> action, int i) => action is null ? (Action)null : () => action(i);

        private static Func<bool> ToFunc(this Action action, bool b) => action is null ? (Func<bool>)null : () => { action(); return b; };
    }
}
