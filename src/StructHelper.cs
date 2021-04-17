using System;
using System.Linq;
using UnityEngine;

namespace KeepCoding.v131
{
    /// <summary>
    /// Allows you to modify colors' individual RGBA or vectors' XYZW components relatively and absolutely. Written by Emik.
    /// </summary>
    public static class StructHelper
    {
        /// <summary>
        /// Converts a hexadecimal string into colors.
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <param name="hex">A string of hexadecimal, which can be formatted as "FFFFFF", "#FFFFFF", or "0xFFFFFF"</param>
        /// <returns><see cref="Color32"/> converted from hexadecimal string.</returns>
        public static Color32 HexToColor(this string hex)
        {
            hex = hex.Replace("0x", "").Replace("#", "");

            if (hex.Length != 6 && hex.Length != 8)
                throw new FormatException($"The hexadecimal code provided has the wrong length: {hex}");

            if (hex.Any(c => !"0123456789ABCDEFabcdef".Contains(c.ToString())))
                throw new FormatException($"The hexadecimal code provided has invalid characters: {hex}");

            return new Color32(byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber), byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber), byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber), (byte)(hex.Length < 8 ? 255 : byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber)));
        }

        /// <summary>
        /// Takes the vector, and replaces the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Replace(ref Vector2 vector, float? x = null, float? y = null)
            => vector = new Vector2(
                x ?? vector.x,
                y ?? vector.y);

        /// <summary>
        /// Takes the vector, and replaces the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Replace(ref Vector3 vector, float? x = null, float? y = null, float? z = null)
            => vector = new Vector3(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z);

        /// <summary>
        /// Takes the vector, and replaces the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Replace(ref Vector4 vector, float? x = null, float? y = null, float? z = null, float? w = null)
            => vector = new Vector4(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z,
                w ?? vector.w);

        /// <summary>
        /// Duplicates the vector, and replaces the x and y components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector2 Replace(this Vector2 vector, float? x = null, float? y = null)
            => new Vector2(
                x ?? vector.x,
                y ?? vector.y);

        /// <summary>
        /// Duplicates the vector, and replaces the x, y, and z components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector3 Replace(this Vector3 vector, float? x = null, float? y = null, float? z = null)
            => new Vector3(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z);

        /// <summary>
        /// Duplicates the vector, and replaces the x, y, z, and w components only if they are specified.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to duplicate and modify.</param>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="z">The z value.</param>
        /// <param name="w">The w value.</param>
        /// <returns>A new instance of <paramref name="vector"/>, with the arguments replacing the values.</returns>
        public static Vector4 Replace(this Vector4 vector, float? x = null, float? y = null, float? z = null, float? w = null)
            => new Vector4(
                x ?? vector.x,
                y ?? vector.y,
                z ?? vector.z,
                w ?? vector.w);

        /// <summary>
        /// Duplicates the color, and replaces the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Replace(this Color32 color, float? r = null, float? g = null, float? b = null, float? a = null)
            => new Color32(
                r.HasValue ? (byte)(r.Value * byte.MaxValue) : color.r,
                g.HasValue ? (byte)(g.Value * byte.MaxValue) : color.g,
                b.HasValue ? (byte)(b.Value * byte.MaxValue) : color.b,
                a.HasValue ? (byte)(a.Value * byte.MaxValue) : color.a);

        /// <summary>
        /// Duplicates the color, and replaces the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color32"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color32 Replace(this Color32 color, byte? r = null, byte? g = null, byte? b = null, byte? a = null)
            => new Color32(
                r ?? color.r,
                g ?? color.g,
                b ?? color.b,
                a ?? color.a);

        /// <summary>
        /// Duplicates the color, and replaces the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Replace(this Color color, float? r = null, float? g = null, float? b = null, float? a = null)
            => new Color(
                r ?? color.r,
                g ?? color.g,
                b ?? color.b,
                a ?? color.a);

        /// <summary>
        /// Duplicates the color, and replaces the RGBA components only if they are specified.
        /// </summary>
        /// <param name="color">The <see cref="Color"/> to duplicate and modify.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The blue component.</param>
        /// <param name="b">The green component.</param>
        /// <param name="a">The alpha component; opacity.</param>
        /// <returns>A new instance of the <paramref name="color"/>, with the arguments replacing the values.</returns>
        public static Color Replace(this Color color, byte? r = null, byte? g = null, byte? b = null, byte? a = null)
            => new Color(
                r.HasValue ? (float)r.Value / byte.MaxValue : color.r,
                g.HasValue ? (float)g.Value / byte.MaxValue : color.g,
                b.HasValue ? (float)b.Value / byte.MaxValue : color.b,
                a.HasValue ? (float)a.Value / byte.MaxValue : color.a);

        /// <summary>
        /// Takes the vector, and replaces the x and y components only if they are specified.
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
        /// Takes the vector, and replaces the x, y, and z components only if they are specified.
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
        /// Takes the vector, and replaces the x, y, z, and w components only if they are specified.
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
        /// Duplicates the vector, and replaces the x and y components only if they are specified.
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
        /// Duplicates the vector, and replaces the x, y, and z components only if they are specified.
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
        /// Duplicates the vector, and replaces the x, y, z, and w components only if they are specified.
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
                (byte)((r * byte.MaxValue) + color.r),
                (byte)((g * byte.MaxValue) + color.g),
                (byte)((b * byte.MaxValue) + color.b),
                (byte)((a * byte.MaxValue) + color.a));

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
                ((float)r / byte.MaxValue) + color.r,
                ((float)g / byte.MaxValue) + color.g,
                ((float)b / byte.MaxValue) + color.b,
                ((float)a / byte.MaxValue) + color.a);

        /// <summary>
        /// Sets the <see cref="Renderer.material"/>'s color to be a mix of 2 colors.
        /// </summary>
        /// <param name="renderer">The renderer to change the color of.</param>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        public static void IntertwineColor(this Renderer renderer, Color32 colorA, Color32 colorB, float concentrationOfB = 0.5f)
            => renderer.material.color = colorA.IntertwineColor(colorB, concentrationOfB);

        /// <summary>
        /// Sets the <see cref="Renderer.material"/>'s color to be a mix of 2 colors.
        /// </summary>
        /// <param name="renderer">The renderer to change the color of.</param>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        public static void IntertwineColor(this Renderer renderer, Color colorA, Color colorB, float concentrationOfB = 0.5f)
            => renderer.material.color = colorA.IntertwineColor(colorB, concentrationOfB);

        /// <summary>
        /// Creates an in-between color between 2 different colors.
        /// </summary>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>A blended color of the 2 provided.</returns>
        public static Color32 IntertwineColor(this Color32 colorA, Color32 colorB, float concentrationOfB = 0.5f)
            => new Color32(
                (byte)((colorA.r * (1 - concentrationOfB)) + (colorB.r * concentrationOfB)),
                (byte)((colorA.g * (1 - concentrationOfB)) + (colorB.g * concentrationOfB)),
                (byte)((colorA.b * (1 - concentrationOfB)) + (colorB.b * concentrationOfB)),
                (byte)((colorA.a * (1 - concentrationOfB)) + (colorB.a * concentrationOfB)));

        /// <summary>
        /// Creates an in-between color between 2 different colors.
        /// </summary>
        /// <param name="colorA">The first color, with 0 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="colorB">The second color, with 1 <paramref name="concentrationOfB"/> being biased towards this color.</param>
        /// <param name="concentrationOfB">The bias towards either color, between 0-1. 0.5 blends both colors equally.</param>
        /// <returns>A blended color of the 2 provided.</returns>
        public static Color IntertwineColor(this Color colorA, Color colorB, float concentrationOfB = 0.5f)
            => new Color(
                (colorA.r * (1 - concentrationOfB)) + (colorB.r * concentrationOfB),
                (colorA.g * (1 - concentrationOfB)) + (colorB.g * concentrationOfB),
                (colorA.b * (1 - concentrationOfB)) + (colorB.b * concentrationOfB),
                (colorA.a * (1 - concentrationOfB)) + (colorB.a * concentrationOfB));

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
        public static bool IsAnyEqual(this Color32[] colors, Color32 color) => colors.NullCheck("You cannot iterate over a null array.", true).Any(c => c.Equals(color));

        /// <summary>
        /// Checks if any elements in the array <paramref name="colors"/> are equal to <paramref name="color"/>.
        /// </summary>
        /// <exception cref="NullIteratorException"></exception>
        /// <param name="colors">The array of colors to compare to <paramref name="color"/>.</param>
        /// <param name="color">The color to compare it to.</param>
        /// <returns>Boolean, true only if any color in <paramref name="colors"/> is the exact same as <paramref name="color"/>'s R, G, B, and A values.</returns>
        public static bool IsAnyEqual(this Color[] colors, Color color) => colors.NullCheck("You cannot iterate over a null array.", true).Any(c => c.Equals(color));
    }
}
