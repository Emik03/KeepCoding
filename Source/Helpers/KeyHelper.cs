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
        /// <returns><paramref name="obj"/> <see langword="as"/> <typeparamref name="T"/></returns>
        public static T As<T>(this object obj) where T : class => obj as T;

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
        /// <returns>The output of <paramref name="func"/>.</returns>
        public static T Checked<T>(this Func<T> func) => checked(func.NullCheck("The action cannot be null.")());

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
        /// <typeparam name="T">The type of iterator.</typeparam>
        /// <param name="iterator">The collection of items to go through one-by-one.</param>
        /// <param name="action">The action to do on each item in <paramref name="iterator"/>.</param>
        /// <returns><paramref name="iterator"/></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerator<T> iterator, Action<T> action) => ForEach(iterator.AsEnumerable(), action);

        /// <summary>
        /// An <see langword="if"/> statement identifies which statement to run based on the value of a Boolean expression.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else"/>
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <param name="condition">The condition to check.</param>
        /// <param name="action">The action to run when <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="otherwise">The action to run when <paramref name="condition"/> is <see langword="false"/>.</param>
        /// <returns><paramref name="condition"/></returns>
        public static bool If(this bool condition, Action action, Action otherwise = null)
        {
            action.NullCheck("The action cannot be null.");

            if (condition)
                action();
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
        /// <param name="action">The action to run when <paramref name="condition"/> is <see langword="true"/>.</param>
        /// <param name="otherwise">The action to run when <paramref name="condition"/> is <see langword="false"/>.</param>
        public static T If<T>(this bool condition, Func<T> action, Func<T> otherwise) => condition ? action.NullCheck("The action cannot be null.")() : otherwise.NullCheck("The otherwise cannot be null.")();

        /// <summary>
        /// The <see langword="is"/> operator checks if the result of an expression is compatible with a given type.
        /// </summary>
        /// <remarks>
        /// <seealso href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is"/>
        /// </remarks>
        /// <typeparam name="T">The type to cast into.</typeparam>
        /// <param name="obj">The object to cast.</param>
        /// <returns><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/></returns>
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
        /// <returns><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/> <paramref name="item"/></returns>
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
        /// <returns><paramref name="obj"/> <see langword="is"/> <typeparamref name="T"/> item</returns>
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
        public static T Lock<T>(this T item, Action<T> action)
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
        /// <returns>The output of <paramref name="func"/>.</returns>
        public static T Lock<T>(this T item, Func<T, T> func)
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
        /// <returns>The name of the expression.</returns>
        public static string NameOf<T>(this Expression<Func<T>> expression)
        {
            try
            {
                return ((MemberExpression)expression.Body).Member.Name;
            }
            catch (InvalidCastException)
            {
                return expression.Compile()().ToString() ?? "<unknown>";
            }
        }

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
        /// <returns>The output of <paramref name="func"/>.</returns>
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
        /// <returns><paramref name="item"/></returns>
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
        /// <returns>The output of <paramref name="func"/>.</returns>
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
        /// <returns>An <see cref="IEnumerable{T}"/> consisting of a single item.</returns>
        public static IEnumerable<T> Yield<T>(this T item)
        {
            yield return item;
        }
    }
}
