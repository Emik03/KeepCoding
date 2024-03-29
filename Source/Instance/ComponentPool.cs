﻿using System;
using System.Collections.Generic;
using System.Linq;
using static KeepCoding.ComponentPool.ComponentSource;
using static KeepCoding.ComponentPool.SpecialComponentTypeEnum;

namespace KeepCoding
{
    /// <summary>
    /// A ComponentPool is a collection of Module Types. The generator will pick <see cref="Count"/> times from this list and instantiate a component of the chosen type.
    /// </summary>
    public sealed class ComponentPool
    {
        /// <summary>
        /// Controls where this pool will draw from (e.g. the base game modules, modules from mods, or both).
        /// </summary>
        [Flags]
        public enum ComponentSource
        {
            /// <summary>
            /// Indicates that the module is from the base game.
            /// </summary>
            Base = 0x1,

            /// <summary>
            /// Indicates that the module is from mods.
            /// </summary>
            Mods = 0x2
        }

        /// <summary>
        /// Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). Set to "None" to select specific module types.
        /// </summary>
        public enum SpecialComponentTypeEnum
        {
            /// <summary>
            /// Indicates that the mission will choose a set of modules that are self-defined.
            /// </summary>
            None,

            /// <summary>
            /// Indicates that the mission will randomly pull any of the game's loaded solvable modules.
            /// </summary>
            ALL_SOLVABLE,

            /// <summary>
            /// Indicates that the mission will randomly pull any of the game's loaded needy modules.
            /// </summary>
            ALL_NEEDY
        }

        /// <summary>
        /// The module types in the base game.
        /// </summary>
        public enum ComponentTypeEnum
        {
            /// <summary>
            /// No module. Uses the bomb backing.
            /// </summary>
            Empty,

            /// <summary>
            /// The timer component.
            /// </summary>
            Timer,

            /// <summary>
            /// On the Subject of Wires.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Wires.html"/></remarks>
            Wires,

            /// <summary>
            /// On the Subject of The Button.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/The%20Button.html"/></remarks>
            BigButton,

            /// <summary>
            /// On the Subject of Keypads.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Keypad.html"/></remarks>
            Keypad,

            /// <summary>
            /// On the Subject of Simon Says. 
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Simon%20Says.html"/></remarks>
            Simon,

            /// <summary>
            /// On the Subject of Who's on First.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Who's%20On%20First.html"/></remarks>
            WhosOnFirst,

            /// <summary>
            /// On the Subject of Memory.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Memory.html"/></remarks>
            Memory,

            /// <summary>
            /// On the Subject of Morse Code.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Morse%20Code.html"/></remarks>
            Morse,

            /// <summary>
            /// On the Subject of Complicated Wires.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Complicated%20Wires.html"/></remarks>
            Venn,

            /// <summary>
            /// On the Subject of Wire Sequences.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Wire%20Sequence.html"/></remarks>
            WireSequence,

            /// <summary>
            /// On the Subject of Mazes.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Maze.html"/></remarks>
            Maze,

            /// <summary>
            /// On the Subject of Passwords.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Password.html"/></remarks>
            Password,

            /// <summary>
            /// On the Subject of Venting Gas.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Venting%20Gas.html"/></remarks>
            NeedyVentGas,

            /// <summary>
            /// On the Subject of Capacitor Discharge.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Capacitor%20Discharge.html"/></remarks>
            NeedyCapacitor,

            /// <summary>
            /// On the Subject of Knobs.
            /// </summary>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Knob.html"/></remarks>
            NeedyKnob,

            /// <summary>
            /// Any solvable modded module.
            /// </summary>
            Mod,

            /// <summary>
            /// Any needy modded module.
            /// </summary>
            NeedyMod
        }

        /// <summary>
        /// Creates a pool of selectable modules.
        /// </summary>
        /// <param name="count">The amount of times this pool should be used.</param>
        /// <param name="allowedSources">Determines the source of the modules.</param>
        /// <param name="specialComponentType">Determines more random-based module picking.</param>
        /// <param name="modTypes">The different modded modules to pick from.</param>
        /// <param name="componentTypes">The different vanilla modules to pick from.</param>
        public ComponentPool(int count, ComponentSource allowedSources, SpecialComponentTypeEnum specialComponentType, List<string> modTypes, List<ComponentTypeEnum> componentTypes)
        {
            Count = count;
            AllowedSources = allowedSources;
            SpecialComponentType = specialComponentType;
            ModTypes = modTypes;
            ComponentTypes = componentTypes;
        }

        /// <summary>
        /// How many components from this pool should be selected.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Controls where components can come from (either the base game, mods, or both).
        /// </summary>
        public ComponentSource AllowedSources { get; } = Base;

        /// <summary>
        /// A list of mod types to be included in the pool, if they exist.
        /// </summary>
        public List<string> ModTypes { get; }

        /// <summary>
        /// The list of component types, not including any calculated at runtime special types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list.
        /// </summary>
        public List<ComponentTypeEnum> ComponentTypes { get; }

        /// <summary>
        /// Special types which are calculated at runtime, such as <see cref="ALL_SOLVABLE"/>.
        /// </summary>
        public SpecialComponentTypeEnum SpecialComponentType { get; }

        /// <summary>
        /// Converts itself to a string.
        /// </summary>
        /// <returns>The list of mod types with a count at the end.</returns>
        public override string ToString() => SpecialComponentType is None
                ? $"[{ComponentTypes.Select(c => c.ToString()).Concat(ModTypes.Where(s => !s.IsNullOrEmpty())).Stringify()}] Count: {Count}"
                : $"[{SpecialComponentType}] Count: {Count}";
    }
}
