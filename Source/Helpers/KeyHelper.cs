using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Linq.Enumerable;

namespace KeepCoding
{
    /// <summary>
    /// Inline methods for when typically key words are used.
    /// </summary>
    public static class KeyHelper
    {
        /// <summary>
        /// The <see langword="as"/> operator explicitly converts the result of an expression to a given reference or nullable value type. If the conversion is not possible, the <see langword="as"/> operator returns <see langword="null"/>. Unlike a cast expression, the <see langword="as"/> operator never throws an exception.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast the object into.</typeparam>
        /// <param name="obj">The object to cast into.</param>
        /// <returns><c><paramref name="obj"/> <see langword="as"/> <typeparamref name="T"/></c></returns>
        public static T As<T>(this object obj) where T : class => obj as T;

        /// <summary>
        /// The <see langword="as"/> operator explicitly converts the result of an expression to a given reference or nullable value type. If the conversion is not possible, the <see langword="as"/> operator returns <see langword="null"/>. Unlike a cast expression, the <see langword="as"/> operator never throws an exception.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast the object into.</typeparam>
        /// <param name="obj">The object to cast into.</param>
        /// <returns><c><paramref name="obj"/> <see langword="as"/> <typeparamref name="T"/></c></returns>
        public static T? AsValue<T>(this object obj) where T : struct => obj as T?;

        /// <summary>
        /// A cast expression of the form <c>(<typeparamref name="T"/>)<typeparamref name="E"/></c> performs an explicit conversion of the result of expression <c><typeparamref name="E"/></c> to type <c><typeparamref name="T"/></c>. If no explicit conversion exists from the type of <c><typeparamref name="E"/></c> to type <c><typeparamref name="T"/></c>, a compile-time error occurs. At run time, an explicit conversion might not succeed and a cast expression might throw an exception.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <typeparam name="E">The initial type.</typeparam>
        /// <typeparam name="T">The type to convert to.</typeparam>
        /// <param name="item">The item to cast.</param>
        /// <returns><c>(<typeparamref name="T"/>)<paramref name="item"/></c></returns>
        public static T Cast<E, T>(this E item) where T : E => (T)item;

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="action">The action to try.</param>
        /// <param name="when">The condition for catching the exception.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <param name="final">The action to run on either clause.</param>
        /// <returns><paramref name="action"/> with <paramref name="caught"/> if an <see cref="Exception"/> caught passed in <paramref name="when"/> returns <see langword="true"/>.</returns>
        public static Action Catch(this Action action, Predicate<Exception> when, Action<Exception> caught = null, Action final = null) => () =>
        {
            try
            {
                action.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (when(e))
            {
                caught?.Invoke(e);
            }
            finally
            {
                final?.Invoke();
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type to catch.</typeparam>
        /// <param name="action">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <param name="final">The action to run on either clause.</param>
        /// <returns><paramref name="action"/> with <paramref name="caught"/> if <typeparamref name="T"/> is caught.</returns>
        public static Action Catch<T>(this Action action, Action<T> caught = null, Action final = null) where T : Exception => () =>
        {
            try
            {
                action.NullCheck("The action cannot be null.")();
            }
            catch (T e)
            {
                caught?.Invoke(e);
            }
            finally
            {
                final?.Invoke();
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <param name="action">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <param name="final">The action to run on either clause.</param>
        /// <returns><paramref name="action"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Action Catch<T1, T2>(this Action action, Action<Exception> caught = null, Action final = null) where T1 : Exception where T2 : Exception => () =>
        {
            try
            {
                action.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2)
            {
                caught?.Invoke(e);
            }
            finally
            {
                final?.Invoke();
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <typeparam name="T3">The third type to catch.</typeparam>
        /// <param name="action">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <param name="final">The action to run on either clause.</param>
        /// <returns><paramref name="action"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Action Catch<T1, T2, T3>(this Action action, Action<Exception> caught = null, Action final = null) where T1 : Exception where T2 : Exception where T3 : Exception => () =>
        {
            try
            {
                action.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2 || e is T3)
            {
                caught?.Invoke(e);
            }
            finally
            {
                final?.Invoke();
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <typeparam name="T3">The third type to catch.</typeparam>
        /// <typeparam name="T4">The fourth type to catch.</typeparam>
        /// <param name="action">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <param name="final">The action to run on either clause.</param>
        /// <returns><paramref name="action"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Action Catch<T1, T2, T3, T4>(this Action action, Action<Exception> caught = null, Action final = null) where T1 : Exception where T2 : Exception where T3 : Exception where T4 : Exception => () =>
        {
            try
            {
                action.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2 || e is T3 || e is T4)
            {
                caught?.Invoke(e);
            }
            finally
            {
                final?.Invoke();
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The return type.</typeparam>
        /// <param name="func">The action to try.</param>
        /// <param name="when">The condition for catching the exception.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <returns><paramref name="func"/> with <paramref name="caught"/> if an <see cref="Exception"/> caught passed in <paramref name="when"/> returns <see langword="true"/>.</returns>
        public static Func<T> Catch<T>(this Func<T> func, Predicate<Exception> when, Func<Exception, T> caught) => () =>
        {
            try
            {
                return func.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (when(e))
            {
                return caught.NullCheck("The caught cannot be null.")(e);
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type to catch.</typeparam>
        /// <typeparam name="TResult">The return type.</typeparam>
        /// <param name="func">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <returns><paramref name="func"/> with <paramref name="caught"/> if <typeparamref name="T"/> is caught.</returns>
        public static Func<TResult> Catch<T, TResult>(this Func<TResult> func, Func<T, TResult> caught) where T : Exception => () =>
        {
            try
            {
                return func.NullCheck("The action cannot be null.")();
            }
            catch (T e)
            {
                return caught.NullCheck("The caught cannot be null.")(e);
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <typeparam name="TResult">The return type.</typeparam>
        /// <param name="func">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <returns><paramref name="func"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Func<TResult> Catch<T1, T2, TResult>(this Func<TResult> func, Func<Exception, TResult> caught) where T1 : Exception where T2 : Exception => () =>
        {
            try
            {
                return func.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2)
            {
                return caught.NullCheck("The caught cannot be null.")(e);
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <typeparam name="T3">The third type to catch.</typeparam>
        /// <typeparam name="TResult">The return type.</typeparam>
        /// <param name="func">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <returns><paramref name="func"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Func<TResult> Catch<T1, T2, T3, TResult>(this Func<TResult> func, Func<Exception, TResult> caught) where T1 : Exception where T2 : Exception where T3 : Exception => () =>
        {
            try
            {
                return func.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2 || e is T3)
            {
                return caught.NullCheck("The caught cannot be null.")(e);
            }
        };

        /// <summary>
        /// The try-catch statement consists of a <see langword="try"/> block followed by one or more <see langword="catch"/> clauses, which specify handlers for different exceptions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T1">The first type to catch.</typeparam>
        /// <typeparam name="T2">The second type to catch.</typeparam>
        /// <typeparam name="T3">The third type to catch.</typeparam>
        /// <typeparam name="T4">The fourth type to catch.</typeparam>
        /// <typeparam name="TResult">The return type.</typeparam>
        /// <param name="func">The action to try.</param>
        /// <param name="caught">The action to run when an exception is caught.</param>
        /// <returns><paramref name="func"/> with <paramref name="caught"/> if the specified <see cref="Exception"/>s are caught.</returns>
        public static Func<TResult> Catch<T1, T2, T3, T4, TResult>(this Func<TResult> func, Func<Exception, TResult> caught) where T1 : Exception where T2 : Exception where T3 : Exception where T4 : Exception => () =>
        {
            try
            {
                return func.NullCheck("The action cannot be null.")();
            }
            catch (Exception e) when (e is T1 || e is T2 || e is T3 || e is T4)
            {
                return caught.NullCheck("The caught cannot be null.")(e);
            }
        };

        /// <summary>
        /// The <see langword="checked"/> keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="action">The action to run inside a <see langword="checked"/> block.</param>
        public static void Checked(this Action action)
        {
            checked
            {
                action.NullCheck("The action cannot be null.")();
            }
        }

        /// <summary>
        /// The <see langword="checked"/> keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="func">The function to run inside a <see langword="checked"/> block.</param>
        /// <returns><c><see langword="checked"/>(<paramref name="func"/>())</c></returns>
        public static T Checked<T>(this Func<T> func) => checked(func.NullCheck("The action cannot be null.")());

        /// <summary>
        /// A default value expression produces the default value of a type.
        /// </summary>
        /// <typeparam name="T">The type to return a default value.</typeparam>
        /// <param name="_">The discard.</param>
        /// <returns><c><see langword="default"/>(<typeparamref name="T"/>)</c></returns>
        public static T Default<T>(this T _) => default;

        /// <summary>
        /// The <see langword="do"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>. Because that expression is evaluated after each execution of the loop, a <see langword="do"/> loop executes one or more times. This differs from a <see langword="while"/> loop, which executes zero or more times.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="action">The action to run in the loop.</param>
        /// <param name="condition">The condition to determine whether the loop should keep going.</param>
        public static void DoWhile(this Action action, Func<bool> condition)
        {
            action.NullCheck("The action cannot be null.")();
            While(action, condition);
        }

        /// <summary>
        /// The <see langword="do"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>. Because that expression is evaluated after each execution of the loop, a <see langword="do"/> loop executes one or more times. This differs from a <see langword="while"/> loop, which executes zero or more times.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="func">The function to run in the loop.</param>
        /// <param name="condition">The condition to determine whether the loop should keep going.</param>
        /// <returns>All instances that <paramref name="func"/> used in an <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<T> DoWhile<T>(this Func<T> func, Func<bool> condition) => func.NullCheck("The action cannot be null.")().Yield().Concat(While(func, condition));

        /// <summary>
        /// The <see langword="for"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="length">The length to reach to in the for loop.</param>
        /// <param name="action">The action for each loop.</param>
        /// <returns><paramref name="length"/></returns>
        public static int For(this int length, Action<int> action)
        {
            action.NullCheck("The action cannot be null.");

            for (int i = 0; i < length; i++)
                action(i);

            return length;
        }

        /// <summary>
        /// The <see langword="for"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the declaring variable.</typeparam>
        /// <param name="item">The item to read and write on.</param>
        /// <param name="action">The action for each loop.</param>
        /// <param name="condition">The condition for whether the loop should continue.</param>
        /// <param name="loop">The action to run after <paramref name="action"/>.</param>
        /// <returns><paramref name="item"/></returns>
        public static T For<T>(this T item, Action<T> action, Predicate<T> condition = null, Func<T, T> loop = null)
        {
            action.NullCheck("The action cannot be null.");

            for (; condition?.Invoke(item) ?? true;)
            {
                action(item);

                if (loop is { })
                    item = loop(item);
            }

            return item;
        }

        /// <summary>
        /// The <see langword="for"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="length">The length to reach to in the for loop.</param>
        /// <param name="func">The function for each loop.</param>
        /// <returns>All instances that <paramref name="func"/> used in an <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<T> For<T>(this int length, Func<int, T> func)
        {
            var output = new List<T>();

            func.NullCheck("The action cannot be null.");

            for (int i = 0; i < length; i++)
                output.Add(func(i));

            return output;
        }

        /// <summary>
        /// The <see langword="for"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of the declaring variable.</typeparam>
        /// <param name="item">The item to read and write on.</param>
        /// <param name="func">The function for each loop.</param>
        /// <param name="condition">The condition for whether the loop should continue.</param>
        /// <param name="loop">The action to run after <paramref name="func"/>.</param>
        /// <returns>All instances that <paramref name="func"/> used in an <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<T> For<T>(this T item, Func<T, T> func, Predicate<T> condition = null, Func<T, T> loop = null)
        {
            var output = new List<T>();

            func.NullCheck("The action cannot be null.");

            for (; condition?.Invoke(item) ?? true;)
            {
                output.Add(func(item));

                if (loop is { })
                    item = loop(item);
            }

            return output;
        }

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable ForEach(this IEnumerable iterator, Action<object> action) => ForEach(iterator.NullCheck("The iterator cannot be null.").Cast<object>(), action);

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable ForEach(this IEnumerable iterator, Action<object, int> action) => ForEach(iterator.NullCheck("The iterator cannot be null.").Cast<object>(), action);

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of iterator.</typeparam>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> iterator, Action<T> action)
        {
            action.NullCheck("The action cannot be null.");

            foreach (T item in iterator)
                action(item);

            return iterator;
        }

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of iterator.</typeparam>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> iterator, Action<T, int> action)
        {
            action.NullCheck("The action cannot be null.");

            int i = 0;

            foreach (T item in iterator)
                action(item, checked(i++));

            return iterator;
        }

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable ForEach(this IEnumerator iterator, Action<object> action) => ForEach(iterator.AsEnumerable(), action);

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable ForEach(this IEnumerator iterator, Action<object, int> action) => ForEach(iterator.AsEnumerable(), action);

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of iterator.</typeparam>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerator<T> iterator, Action<T> action) => ForEach(iterator.AsEnumerable(), action);

        /// <summary>
        /// The <see langword="foreach"/> statement executes a statement or a block of statements for each element in an instance of the type that implements the <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> interface.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of iterator.</typeparam>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerator<T> iterator, Action<T, int> action) => ForEach(iterator.AsEnumerable(), action);

        /// <summary>
        /// An <see langword="if"/> statement identifies which statement to run based on the value of a Boolean expression.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="condition">The condition to check.</param>
        /// <param name="consequent">The action to run when <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="otherwise">The action to run when <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><paramref name="condition"/></returns>
        public static bool If(this bool condition, Action consequent, Action otherwise = null)
        {
            consequent.NullCheck("The action cannot be null.");

            if (condition)
                consequent();
            else
                otherwise?.Invoke();

            return condition;
        }

        /// <summary>
        /// An <see langword="if"/> statement identifies which statement to run based on the value of a Boolean expression.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="condition">The condition to check.</param>
        /// <param name="consequent">The action to run when <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="alternative">The action to run when <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><c><paramref name="condition"/> ? <paramref name="consequent"/>() : <paramref name="alternative"/>()</c></returns>
        public static T If<T>(this bool condition, Func<T> consequent, Func<T> alternative) => condition ? consequent.NullCheck("The action cannot be null.")() : alternative.NullCheck("The otherwise cannot be null.")();

        /// <summary>
        /// The conditional operator <c>?:</c>, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="condition">The condition to check.</param>
        /// <param name="consequent">The action to run when <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="alternative">The action to run when <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><c><paramref name="condition"/> ? <paramref name="consequent"/> : <paramref name="alternative"/></c></returns>
        public static T If<T>(this bool condition, T consequent, T alternative) => condition ? consequent : alternative;

        /// <summary>
        /// The conditional operator <c>?:</c>, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        /// <typeparam name="T1">The type for the return if <paramref name="condition"/> is <see langword="true"/>.</typeparam>
        /// <typeparam name="T2">The type for the return if <paramref name="condition"/> is <see langword="false"/>.</typeparam>
        /// <param name="condition">The <see cref="bool"/> to either return <paramref name="consequent"/> or <paramref name="alternative"/>.</param>
        /// <param name="consequent">The item to return if <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="alternative">The item to return if <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><c><paramref name="condition"/> ? <paramref name="consequent"/> : <paramref name="alternative"/></c></returns>
        public static object If<T1, T2>(this bool condition, T1 consequent, T2 alternative) => condition ? (object)consequent : alternative;

        /// <summary>
        /// The conditional operator <c>?:</c>, also known as the ternary conditional operator, evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        /// <typeparam name="T1">The type for the return if <paramref name="condition"/> is <see langword="true"/>.</typeparam>
        /// <typeparam name="T2">The type for the return if <paramref name="condition"/> is <see langword="false"/>.</typeparam>
        /// <typeparam name="TResult">The return type that is shared for both <typeparamref name="T1"/> and <typeparamref name="T2"/>.</typeparam>
        /// <param name="condition">The <see cref="bool"/> to either return <paramref name="consequent"/> or <paramref name="alternative"/>.</param>
        /// <param name="consequent">The item to return if <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="alternative">The item to return if <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><c><paramref name="condition"/> ? <paramref name="consequent"/> : <paramref name="alternative"/></c></returns>
        public static TResult If<T1, T2, TResult>(this bool condition, T1 consequent, T2 alternative) where TResult : T1, T2 => condition ? (TResult)consequent : (TResult)alternative;

        /// <summary>
        /// The <see langword="is"/> operator checks if the result of an expression is compatible with a given type.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast into.</typeparam>
        /// <param name="obj">The object to cast.</param>
        /// <returns><c><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/></c></returns>
        public static bool Is<T>(this object obj) => obj is T;

        /// <summary>
        /// The <see langword="is"/> operator checks if the result of an expression is compatible with a given type.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast into.</typeparam>
        /// <param name="obj">The object to cast.</param>
        /// <param name="item">The object casted into the type.</param>
        /// <returns><c><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/> <paramref name="item"/></c></returns>
        public static bool Is<T>(this object obj, out T item) where T : class => (item = obj as T) is T;

        /// <summary>
        /// The <see langword="is"/> operator checks if the result of an expression is compatible with a given type.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast into.</typeparam>
        /// <param name="obj">The object to cast.</param>
        /// <param name="action">The action to run when <paramref name="obj"/> is <typeparamref name="T"/>.</param>
        /// <param name="otherwise">The action to run when <paramref name="obj"/> is not <typeparamref name="T"/>.</param>
        /// <returns><c><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/> item</c></returns>
        public static bool Is<T>(this object obj, Action<T> action, Action otherwise = null) where T : class
        {
            action.NullCheck("The action cannot be null!");

            if (obj is T t)
            {
                action(t);
                return true;
            }

            otherwise?.Invoke();
            return false;
        }

        /// <summary>
        /// The <see langword="lock"/> statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of item to lock.</typeparam>
        /// <param name="item">The item to lock.</param>
        /// <param name="action">The action to run while the item is locked.</param>
        /// <returns><c><see langword="lock"/> (<paramref name="item"/>) <paramref name="action"/>(<paramref name="item"/>) <see langword="return"/> <paramref name="item"/></c></returns>
        public static T Lock<T>(this T item, Action<T> action) where T : notnull
        {
            lock (item)
                action.NullCheck("The action cannot be null.")(item);
            return item;
        }

        /// <summary>
        /// The <see langword="lock"/> statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of item to lock.</typeparam>
        /// <param name="item">The item to lock.</param>
        /// <param name="func">The function to run while the item is locked.</param>
        /// <returns><c><see langword="lock"/> (<paramref name="item"/>) <see langword="return"/> <paramref name="func"/>(<paramref name="item"/>)</c></returns>
        public static T Lock<T>(this T item, Func<T, T> func) where T : notnull
        {
            lock (item)
                return func.NullCheck("The action cannot be null.")(item);
        }

        /// <summary>
        /// A <see langword="nameof"/> expression produces the name of a variable, type, or member as the string constant.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof"/>
        /// </remarks>
        /// <typeparam name="T">The type of item.</typeparam>
        /// <param name="expression">The expression to get the name from.</param>
        /// <returns>The name of the variable inside <paramref name="expression"/>.</returns>
        public static string NameOf<T>(this Expression<Func<T>> expression)
        {
            try
            {
                return ((MemberExpression)expression.Body).Member.Name;
            }
            catch (InvalidCastException)
            {
                return expression.Compile()()?.ToString() ?? "<unknown>";
            }
        }

        /// <summary>
        /// The <see langword="new"/> operator creates a new instance of a type.
        /// </summary>
        /// <typeparam name="T">The type of the retrurn.</typeparam>
        /// <returns><c><see langword="new"/> <typeparamref name="T"/>()</c></returns>
        public static T New<T>(this T a) where T : new() => new T();

        /// <summary>
        /// The <see langword="typeof"/> operator obtains the <see cref="Type"/> instance for a type.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="item">The item to get the <see cref="Type"/> of.</param>
        /// <returns><c><see langword="typeof"/>(<typeparamref name="T"/>)</c></returns>
        public static Type TypeOf<T>(this T item) => typeof(T);

        /// <summary>
        /// The <see langword="unchecked"/> keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="action">The action to ignore overflow-checking.</param>
        public static void Unchecked(this Action action)
        {
            unchecked
            {
                action.NullCheck("The action cannot be null.")();
            }
        }

        /// <summary>
        /// The <see langword="unchecked"/> keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="func">The function to ignore overflow-checking.</param>
        /// <returns><c><see langword="unchecked"/>(<paramref name="func"/>())</c></returns>
        public static T Unchecked<T>(this Func<T> func) => unchecked(func.NullCheck("The action cannot be null.")());

        /// <summary>
        /// Provides a convenient syntax that ensures the correct use of <see cref="IDisposable"/> objects.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of <see cref="IDisposable"/>.</typeparam>
        /// <param name="item">The item to use.</param>
        /// <param name="action">The action to use <paramref name="item"/> on.</param>
        /// <returns><c><see langword="using"/> (<paramref name="item"/>) <paramref name="action"/>(<paramref name="item"/>)</c></returns>
        public static T Using<T>(this T item, Action<T> action) where T : IDisposable
        {
            using (item)
                action.NullCheck("The action cannot be null.")(item);
            return item;
        }

        /// <summary>
        /// Provides a convenient syntax that ensures the correct use of <see cref="IDisposable"/> objects.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <typeparam name="T">The type of <see cref="IDisposable"/>.</typeparam>
        /// <param name="item">The item to use.</param>
        /// <param name="func">The function to use <paramref name="item"/> on.</param>
        /// <returns><c><see langword="using"/> (<paramref name="item"/>) <see langword="return"/> <paramref name="func"/>(<paramref name="item"/>)</c></returns>
        public static T Using<T>(this T item, Func<T, T> func) where T : IDisposable
        {
            using (item)
                return func.NullCheck("The action cannot be null.")(item);
        }

        /// <summary>
        /// The <see langword="while"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>. Because that expression is evaluated before each execution of the loop, a <see langword="while"/> loop executes zero or more times. This differs from a <see langword="do"/> loop, which executes one or more times.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="action">The action to run in the loop.</param>
        /// <param name="condition">The condition to determine whether the loop should keep going.</param>
        public static void While(this Action action, Func<bool> condition)
        {
            action.NullCheck("The action cannot be null.");
            condition.NullCheck("The condition cannot be null.");

            while (condition())
                action();
        }

        /// <summary>
        /// The <see langword="while"/> statement executes a statement or a block of statements while a specified Boolean expression evaluates to <see langword="true"/>. Because that expression is evaluated before each execution of the loop, a <see langword="while"/> loop executes zero or more times. This differs from a <see langword="do"/> loop, which executes one or more times.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="func">The function to run in the loop.</param>
        /// <param name="condition">The condition to determine whether the loop should keep going.</param>
        /// <returns>All instances that <paramref name="func"/> used in an <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<T> While<T>(this Func<T> func, Func<bool> condition)
        {
            var output = new List<T>();

            func.NullCheck("The action cannot be null.");
            condition.NullCheck("The condition cannot be null.");

            while (condition())
                output.Add(func());

            return output;
        }

        /// <summary>
        /// Wraps this object instance into an <see cref="IEnumerable{T}"/> consisting of a single item.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="item">The instance that will be wrapped.</param>
        /// <returns><c><see langword="yield"/> <see langword="return"/> <paramref name="item"/></c></returns>
        public static IEnumerable<T> Yield<T>(this T item)
        {
            yield return item;
        }
    }
}
