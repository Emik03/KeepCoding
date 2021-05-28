using System;
using System.Collections.Generic;
using System.Linq;
using static KeepCoding.ComponentPool.SpecialComponentTypeEnum;

namespace KeepCoding
{
    /// <summary>
    /// A ComponentPool is a collection of Module Types. The generator will pick Count times from this list and instantiate a component of the chosen type. Written by Emik.
    /// </summary>
    public sealed class ComponentPool
    {
        /// <summary>
        /// Creates a Component pool.
        /// </summary>
        /// <param name="count">How many components from this pool should be selected.</param>
        /// <param name="allowedSources">Controls where components can come from (either the base game, mods, or both).</param>
        /// <param name="specialComponentType">Special types which are calculated at runtime, such as <see cref="SpecialComponentTypeEnum.ALL_SOLVABLE"/>.</param>
        /// <param name="modTypes">A list of mod types to be included in the pool, if they exist.</param>
        /// <param name="componentTypes">The list of component types, not including any calculated at runtime special types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list.</param>
        public ComponentPool(int count, ComponentSource allowedSources, SpecialComponentTypeEnum specialComponentType, List<string> modTypes, List<ComponentTypeEnum> componentTypes)
        {
            Count = count;
            AllowedSources = allowedSources;
            SpecialComponentType = specialComponentType;
            ModTypes = modTypes;
            ComponentTypes = componentTypes;
        }

        /// <summary>
        /// Controls where this pool will draw from (e.g. the base game modules, modules from mods, or both).
        /// </summary>
        [Flags]
        public enum ComponentSource
        {
            /// <value>
            /// Indicates that the module is from the base game.
            /// </value>
            Base = 0x1,

            /// <value>
            /// Indicates that the module is from mods.
            /// </value>
            Mods = 0x2
        }

        /// <summary>
        /// Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). Set to "None" to select specific module types.
        /// </summary>
        public enum SpecialComponentTypeEnum
        {
            /// <value>
            /// Indicates that the mission will choose a set of modules that are self-defined.
            /// </value>
            None,

            /// <value>
            /// Indicates that the mission will randomly pull any of the game's loaded solvable modules.
            /// </value>
            ALL_SOLVABLE,

            /// <value>
            /// Indicates that the mission will randomly pull any of the game's loaded needy modules.
            /// </value>
            ALL_NEEDY
        }

        /// <summary>
        /// The module types in the base game.
        /// </summary>
        public enum ComponentTypeEnum
        {
            /// <value>
            /// No module. Uses the bomb backing.
            /// </value>
            Empty,

            /// <value>
            /// The timer component.
            /// </value>
            Timer,

            /// <value>
            /// On the Subject of Wires.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Wires.html"/></remarks>
            Wires,

            /// <value>
            /// On the Subject of The Button.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/The%20Button.html"/></remarks>
            BigButton,

            /// <value>
            /// On the Subject of Keypads.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Keypad.html"/></remarks>
            Keypad,

            /// <value>
            /// On the Subject of Simon Says. 
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Simon%20Says.html"/></remarks>
            Simon,

            /// <value>
            /// On the Subject of Who's on First.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Who's%20On%20First.html"/></remarks>
            WhosOnFirst,

            /// <value>
            /// On the Subject of Memory.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Memory.html"/></remarks>
            Memory,

            /// <value>
            /// On the Subject of Morse Code.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Morse%20Code.html"/></remarks>
            Morse,

            /// <value>
            /// On the Subject of Complicated Wires.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Complicated%20Wires.html"/></remarks>
            Venn,

            /// <value>
            /// On the Subject of Wire Sequences.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Wire%20Sequence.html"/></remarks>
            WireSequence,

            /// <value>
            /// On the Subject of Mazes.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Maze.html"/></remarks>
            Maze,

            /// <value>
            /// On the Subject of Passwords.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Password.html"/></remarks>
            Password,

            /// <value>
            /// On the Subject of Venting Gas.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Venting%20Gas.html"/></remarks>
            NeedyVentGas,

            /// <value>
            /// On the Subject of Capacitor Discharge.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Capacitor%20Discharge.html"/></remarks>
            NeedyCapacitor,

            /// <value>
            /// On the Subject of Knobs.
            /// </value>
            /// <remarks><seealso href="https://ktane.timwi.de/HTML/Knob.html"/></remarks>
            NeedyKnob,

            /// <value>
            /// Any solvable modded module.
            /// </value>
            Mod,

            /// <value>
            /// Any needy modded module.
            /// </value>
            NeedyMod
        }

        /// <value>
        /// How many components from this pool should be selected.
        /// </value>
        public int Count { get; private set; }

        /// <value>
        /// Controls where components can come from (either the base game, mods, or both).
        /// </value>
        public ComponentSource AllowedSources { get; private set; } = ComponentSource.Base;

        /// <value>
        /// Special types which are calculated at runtime, such as <see cref="SpecialComponentTypeEnum.ALL_SOLVABLE"/>.
        /// </value>
        public SpecialComponentTypeEnum SpecialComponentType { get; private set; }

        /// <value>
        /// A list of mod types to be included in the pool, if they exist.
        /// </value>
        public List<string> ModTypes { get; private set; }

        /// <value>
        /// The list of component types, not including any calculated at runtime special types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list.
        /// </value>
        public List<ComponentTypeEnum> ComponentTypes { get; private set; }

        /// <summary>
        /// Converts itself to a string.
        /// </summary>
        /// <returns>The list of mod types with a count at the end.</returns>
        public override string ToString() => SpecialComponentType == None
                ? $"[{ComponentTypes.Select(c => c.ToString()).Concat(ModTypes.Where(s => !s.IsNullOrEmpty())).UnwrapToString()}] Count: {Count}"
                : $"[{SpecialComponentType}] Count: {Count}";
    }
}
