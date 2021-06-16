using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Globalization.NumberStyles;

namespace KeepCoding
{
    /// <summary>
    /// Extension methods to help you create data types easier. Written by Emik.
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// Checks if both colors have the same RGBA values.
        /// </summary>
        /// <param name="colorA">The first color.</param>
        /// <param name="colorB">The second color.</param>
        /// <returns>Boolean, true only if both colors have the same R, G, B, and A values.</returns>
        public static bool IsEqual(this Color32 colorA, Color32 colorB) => colorA.r == colorB.r && colorA.g == colorB.g && colorA.b == colorB.b && colorA.a == colorB.a;

        /// <summary>
        /// Checks if both colors have the same RGBA values.
        /// </summary>
        /// <param name="colorA">The first color.</param>
        /// <param name="colorB">The second color.</param>
        /// <returns>Boolean, true only if both colors have the same R, G, B, and A values.</returns>
        public static bool IsEqual(this Color colorA, Color colorB) => colorA.r == colorB.r && colorA.g == colorB.g && colorA.b == colorB.b && colorA.a == colorB.a;

        /// <summary>
        /// Checks if any elements in the array <paramref name="colors"/> are equal to <paramref name="color"/>.
        /// </summary>
        /// <param name="colors">The array of colors to compare to <paramref name="color"/>.</param>
        /// <param name="color">The color to compare it to.</param>
        /// <returns>Boolean, true only if any color in <paramref name="colors"/> is the exact same as <paramref name="color"/>'s R, G, B, and A values.</returns>
        public static bool IsAnyEqual(this Color32[] colors, Color32 color) => colors.NullCheck("You cannot iterate over a null array.").Any(c => c.IsEqual(color));

        /// <summary>
        /// Checks if any elements in the array <paramref name="colors"/> are equal to <paramref name="color"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="colors">The array of colors to compare to <paramref name="color"/>.</param>
        /// <param name="color">The color to compare it to.</param>
        /// <returns>Boolean, true only if any color in <paramref name="colors"/> is the exact same as <paramref name="color"/>'s R, G, B, and A values.</returns>
        public static bool IsAnyEqual(this Color[] colors, Color color) => colors.NullCheck("You cannot iterate over a null array.").Any(c => c.IsEqual(color));

        /// <summary>
        /// Duplicates the color, and adds the RGBA components only if they are specified.
        /// </summary>
        /// <remarks>
        /// You can also use negative numbers to subtract.
        /// </remarks>
        /// <param name="color">The color to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Add(this Color color, float r = 0, float g = 0, float b = 0, float a = 0)
            => new Color(
                r + color.r,
                g + color.g,
                b + color.b,
                a + color.a);

        /// <summary>
        /// Duplicates the color, and adds the RGBA components only if they are specified.
        /// </summary>
        /// <remarks>
        /// You can also use negative numbers to subtract.
        /// </remarks>
        /// <param name="color">The <see cref="Color"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Add(this Color color, byte r = 0, byte g = 0, byte b = 0, byte a = 0)
            => new Color(
                (float)r / byte.MaxValue + color.r,
                (float)g / byte.MaxValue + color.g,
                (float)b / byte.MaxValue + color.b,
                (float)a / byte.MaxValue + color.a);

        /// <summary>
        /// Creates an in-between color between 2 different colors.
        /// </summary>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>A blended color of the 2 provided.</returns>
        public static Color IntertwineColor(this Color colorA, Color colorB, float concentrationOfB = 0.5f)
            => new Color(
                colorA.r * (1 - concentrationOfB) + colorB.r * concentrationOfB,
                colorA.g * (1 - concentrationOfB) + colorB.g * concentrationOfB,
                colorA.b * (1 - concentrationOfB) + colorB.b * concentrationOfB,
                colorA.a * (1 - concentrationOfB) + colorB.a * concentrationOfB);

        /// <summary>
        /// Sets the <see cref="Renderer.material"/>'s color to be a mix of 2 colors.
        /// </summary>
        /// <param name="renderer">The renderer to change the color of.</param>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>The resulting color that the <paramref name="renderer"/> becomes.</returns>
        public static Color IntertwineColor(this Renderer renderer, Color colorA, Color colorB, float concentrationOfB = 0.5f)
            => renderer.material.color = colorA.IntertwineColor(colorB, concentrationOfB);

        /// <summary>
        /// Duplicates the color, and sets the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Set(this Color color, float? r = null, float? g = null, float? b = null, float? a = null)
            => new Color(
                r ?? color.r,
                g ?? color.g,
                b ?? color.b,
                a ?? color.a);

        /// <summary>
        /// Duplicates the color, and sets the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Set(this Color color, byte? r = null, byte? g = null, byte? b = null, byte? a = null)
            => new Color(
                r.HasValue ? (float)r.Value / byte.MaxValue : color.r,
                g.HasValue ? (float)g.Value / byte.MaxValue : color.g,
                b.HasValue ? (float)b.Value / byte.MaxValue : color.b,
                a.HasValue ? (float)a.Value / byte.MaxValue : color.a);

        /// <summary>
        /// Duplicates the color, and adds the RGBA components only if they are specified.
        /// </summary>
        /// <remarks>
        /// You can also use negative numbers to subtract. As this is <see cref="Color32"/>, be careful of byte underflows/overflows.
        /// </remarks>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Add(this Color32 color, float r = 0, float g = 0, float b = 0, float a = 0)
            => new Color32(
                (byte)(r * byte.MaxValue + color.r),
                (byte)(g * byte.MaxValue + color.g),
                (byte)(b * byte.MaxValue + color.b),
                (byte)(a * byte.MaxValue + color.a));

        /// <summary>
        /// Duplicates the color, and adds the RGBA components only if they are specified.
        /// </summary>
        /// <remarks>
        /// You can also use negative numbers to subtract. As this is <see cref="Color32"/>, be careful of byte underflows/overflows.
        /// </remarks>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Add(this Color32 color, byte r = 0, byte g = 0, byte b = 0, byte a = 0)
            => new Color32(
                (byte)(r + color.r),
                (byte)(g + color.g),
                (byte)(b + color.b),
                (byte)(a + color.a));

        /// <summary>
        /// Converts a hexadecimal string into colors.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <param name="hex">A string of hexadecimal, which can be formatted as "FFFFFF", "#FFFFFF", or "0xFFFFFF"</param>
        /// <returns><see cref="Color32"/> converted from hexadecimal string.</returns>
        public static Color32 HexToColor(this string hex)
        {
            hex = hex.Replace("0x", "").Replace("#", "");

            return hex.Length != 6 && hex.Length != 8
                ? throw new FormatException($"The hexadecimal code provided has the wrong length: {hex}")
                : hex.Any(c => !"0123456789ABCDEFabcdef".Contains(c.ToString()))
                ? throw new FormatException($"The hexadecimal code provided has invalid characters: {hex}")
                : new Color32(byte.Parse(hex.Substring(0, 2), HexNumber), byte.Parse(hex.Substring(2, 2), HexNumber), byte.Parse(hex.Substring(4, 2), HexNumber), (byte)(hex.Length < 8 ? 255 : byte.Parse(hex.Substring(6, 2), HexNumber)));
        }

        /// <summary>
        /// Creates an in-between color between 2 different colors.
        /// </summary>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>A blended color of the 2 provided.</returns>
        public static Color32 IntertwineColor(this Color32 colorA, Color32 colorB, float concentrationOfB = 0.5f)
            => new Color32(
                (byte)(colorA.r * (1 - concentrationOfB) + colorB.r * concentrationOfB),
                (byte)(colorA.g * (1 - concentrationOfB) + colorB.g * concentrationOfB),
                (byte)(colorA.b * (1 - concentrationOfB) + colorB.b * concentrationOfB),
                (byte)(colorA.a * (1 - concentrationOfB) + colorB.a * concentrationOfB));

        /// <summary>
        /// Sets the <see cref="Renderer.material"/>'s color to be a mix of 2 colors.
        /// </summary>
        /// <param name="renderer">The renderer to change the color of.</param>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>The resulting color that the <paramref name="renderer"/> becomes.</returns>
        public static Color32 IntertwineColor(this Renderer renderer, Color32 colorA, Color32 colorB, float concentrationOfB = 0.5f)
            => renderer.material.color = colorA.IntertwineColor(colorB, concentrationOfB);

        /// <summary>
        /// Duplicates the color, and sets the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Set(this Color32 color, float? r = null, float? g = null, float? b = null, float? a = null)
            => new Color32(
                r.HasValue ? (byte)(r.Value * byte.MaxValue) : color.r,
                g.HasValue ? (byte)(g.Value * byte.MaxValue) : color.g,
                b.HasValue ? (byte)(b.Value * byte.MaxValue) : color.b,
                a.HasValue ? (byte)(a.Value * byte.MaxValue) : color.a);

        /// <summary>
        /// Duplicates the color, and sets the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Set(this Color32 color, byte? r = null, byte? g = null, byte? b = null, byte? a = null)
            => new Color32(
                r ?? color.r,
                g ?? color.g,
                b ?? color.b,
                a ?? color.a);

        /// <summary>
        /// Converts arguments to a new <see cref="Logger"/>.
        /// </summary>
        /// <typeparam name="T">The type of the argument, which is used as the name if <paramref name="name"/> is null.</typeparam>
        /// <param name="_">The discard which is only needed for the type.</param>
        /// <param name="name">The name of the value.</param>
        /// <param name="showId">Determines whether to show the unique identifier when logging.</param>
        /// <returns>A new <see cref="Logger"/> containing the arguments specified.</returns>
        public static Logger ToLogger<T>(this T _, string name = null, bool showId = false) => new Logger(name ?? typeof(T).Name, showId);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine"/> containing the arguments provided.</returns>
        public static Routine ToRoutine(this MonoBehaviour monoBehaviour, Func<IEnumerator> func) => new Routine(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T}"/> containing the arguments provided.</returns>
        public static Routine<T> ToRoutine<T>(this MonoBehaviour monoBehaviour, Func<T, IEnumerator> func) => new Routine<T>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2> ToRoutine<T1, T2>(this MonoBehaviour monoBehaviour, Func<T1, T2, IEnumerator> func) => new Routine<T1, T2>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2, T3}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2, T3}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2, T3> ToRoutine<T1, T2, T3>(this MonoBehaviour monoBehaviour, Func<T1, T2, T3, IEnumerator> func) => new Routine<T1, T2, T3>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Routine{T1, T2, T3, T4}"/>.
        /// </summary>
        /// <param name="func">The function to call when the <see cref="IEnumerator"/> is called.</param>
        /// <param name="monoBehaviour">The instance of the <see cref="MonoBehaviour"/> to start the <see cref="Coroutine"/> from.</param>
        /// <returns>A new <see cref="Routine{T1, T2, T3, T4}"/> containing the arguments provided.</returns>
        public static Routine<T1, T2, T3, T4> ToRoutine<T1, T2, T3, T4>(this MonoBehaviour monoBehaviour, Func<T1, T2, T3, T4, IEnumerator> func) => new Routine<T1, T2, T3, T4>(func, monoBehaviour);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of tuple.</typeparam>
        /// <param name="item">The argument to pass into the tuple.</param>
        /// <returns>A new <see cref="Tuple{T}"/> containing <paramref name="item"/>.</returns>
        public static Tuple<T> ToTuple<T>(this T item) => new Tuple<T>(item);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2}"/> containing <paramref name="item1"/> and <paramref name="item2"/></returns>
        public static Tuple<T1, T2> ToTuple<T1, T2>(this T1 item1, T2 item2) => new Tuple<T1, T2>(item1, item2);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2, T3}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <typeparam name="T3">The third type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <param name="item3">The third argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2, T3}"/> containing <paramref name="item1"/>, <paramref name="item2"/>, and <paramref name="item3"/></returns>
        public static Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(this T1 item1, T2 item2, T3 item3) => new Tuple<T1, T2, T3>(item1, item2, item3);

        /// <summary>
        /// Converts arguments to a new <see cref="Tuple{T1, T2, T3, T4}"/>.
        /// </summary>
        /// <typeparam name="T1">The first type of the tuple.</typeparam>
        /// <typeparam name="T2">The second type of the tuple.</typeparam>
        /// <typeparam name="T3">The third type of the tuple.</typeparam>
        /// <typeparam name="T4">The fourth type of the tuple.</typeparam>
        /// <param name="item1">The first argument to pass into the tuple.</param>
        /// <param name="item2">The second argument to pass into the tuple.</param>
        /// <param name="item3">The third argument to pass into the tuple.</param>
        /// <param name="item4">The fourth argument to pass into the tuple.</param>
        /// <returns>A new <seealso cref="Tuple{T1, T2, T3, T4}"/> containing <paramref name="item1"/>, <paramref name="item2"/>, <paramref name="item3"/>, and <paramref name="item4"/></returns>
        public static Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(this T1 item1, T2 item2, T3 item3, T4 item4) => new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        
        /// <summary>
        /// Duplicates the vector, and sets the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Add(ref Vector2 vector, float x = 0, float y = 0)
            => vector = new Vector2(
                x + vector.x,
                y + vector.y);

        /// <summary>
        /// Takes the vector, and sets the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Add(this Vector2 vector, float x = 0, float y = 0)
            => new Vector2(
                x + vector.x,
                y + vector.y);

        /// <summary>
        /// Duplicates the vector, and sets the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Add(ref Vector3 vector, float x = 0, float y = 0, float z = 0)
            => vector = new Vector3(
                x + vector.x,
                y + vector.y,
                z + vector.z);

        /// <summary>
        /// Takes the vector, and sets the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Add(this Vector3 vector, float x = 0, float y = 0, float z = 0)
            => new Vector3(
                x + vector.x,
                y + vector.y,
                z + vector.z);

        /// <summary>
        /// Duplicates the vector, and sets the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Add(ref Vector4 vector, float x = 0, float y = 0, float z = 0, float w = 0)
            => vector = new Vector4(
                x + vector.x,
                y + vector.y,
                z + vector.z,
                w + vector.w);

        /// <summary>
        /// Takes the vector, and sets the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Add(this Vector4 vector, float x = 0, float y = 0, float z = 0, float w = 0)
            => new Vector4(
                x + vector.x,
                y + vector.y,
                z + vector.z,
                w + vector.w);

        /// <summary>
        /// Takes the vector, and sets the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Set(ref Vector2 vector, float? x = null, float? y = null)
            => vector = new Vector2(
                x ?? vector.x,
                y ?? vector.y);

        /// <summary>
        /// Duplicates the vector, and sets the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Set(this Vector2 vector, float? x = null, float? y = null)
            => new Vector2(
                x ?? vector.x,
                y ?? vector.y);

        /// <summary>
        /// Takes the vector, and sets the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Set(ref Vector3 vector, float? x = null, float? y = null, float? z = null)
            => vector = new Vector3(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z);

        /// <summary>
        /// Duplicates the vector, and sets the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Set(this Vector3 vector, float? x = null, float? y = null, float? z = null)
            => new Vector3(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z);

        /// <summary>
        /// Takes the vector, and sets the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Set(ref Vector4 vector, float? x = null, float? y = null, float? z = null, float? w = null)
            => vector = new Vector4(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z,
                w ?? vector.w);

        /// <summary>
        /// Duplicates the vector, and sets the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Set(this Vector4 vector, float? x = null, float? y = null, float? z = null, float? w = null)
            => new Vector4(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z,
                w ?? vector.w);
        
        /// <summary>
        /// Converts argument to a new <see cref="Version"/>. Major-only versions are compatible.
        /// </summary>
        /// <param name="s">The string to convert to a version.</param>
        /// <returns>A new <see cref="Version"/> representing the input <paramref name="s"/>.</returns>
        public static Version ToVersion(this string s) => new Version(s + (s.Split('.').Length == 1 ? ".0" : ""));

        /// <summary>
        /// Converts argument to a new <see cref="Work"/>
        /// </summary>
        /// <param name="action">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work"/> consisting of the arguments provided.</returns>
        public static Work ToWork(this uint maximumThreadsActive, Action action, bool allowSimultaneousActive = false) => new Work(action, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T}"/> consisting of the arguments provided.</returns>
        public static Work<T> ToWork<T>(this uint maximumThreadsActive, Func<T> func, bool allowSimultaneousActive = false) => new Work<T>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T, TResult> ToWork<T, TResult>(this uint maximumThreadsActive, Func<T, TResult> func, bool allowSimultaneousActive = false) => new Work<T, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, TResult> ToWork<T1, T2, TResult>(this uint maximumThreadsActive, Func<T1, T2, TResult> func, bool allowSimultaneousActive = false) => new Work<T1, T2, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, T3, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, T3, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, T3, TResult> ToWork<T1, T2, T3, TResult>(this uint maximumThreadsActive, Func<T1, T2, T3, TResult> func, bool allowSimultaneousActive = false) => new Work<T1, T2, T3, TResult>(func, allowSimultaneousActive, maximumThreadsActive);

        /// <summary>
        /// Converts argument to a new <see cref="Work{T1, T2, T3, T4, TResult}"/>
        /// </summary>
        /// <param name="func">The action to run when the thread is active.</param>
        /// <param name="allowSimultaneousActive">Whether it should allow multiple of itself to be running at once.</param>
        /// <param name="maximumThreadsActive">The amount of threads this class, and all of its overloads can run at once.</param>
        /// <returns>A new <see cref="Work{T1, T2, T3, T4, TResult}"/> consisting of the arguments provided.</returns>
        public static Work<T1, T2, T3, T4, TResult> ToWork<T1, T2, T3, T4, TResult>(this uint maximumThreadsActive, Func<T1, T2, T3, T4, TResult> func, bool allowSimultaneousActive = false) => new Work<T1, T2, T3, T4, TResult>(func, allowSimultaneousActive, maximumThreadsActive);
    }
}
