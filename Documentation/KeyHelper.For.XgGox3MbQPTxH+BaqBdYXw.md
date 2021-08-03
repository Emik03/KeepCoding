#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.For&lt;T&gt;(T, Func&lt;T,T&gt;, Predicate&lt;T&gt;, Func&lt;T,T&gt;) Method
The [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for') statement executes a statement or a block of statements while a specified Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static System.Collections.Generic.IEnumerable<T> For<T>(this T item, System.Func<T,T> func, System.Predicate<T> condition=null, System.Func<T,T> loop=null);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T'></a>
`T`  
The type of the declaring variable.
  
#### Parameters
<a name='KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).item'></a>
`item` [T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')  
The item to read and write on.
  
<a name='KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function for each loop.
  
<a name='KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).condition'></a>
`condition` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The condition for whether the loop should continue.
  
<a name='KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).loop'></a>
`loop` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run after [func](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).func 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).func').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
All instances that [func](KeyHelper.For.XgGox3MbQPTxH+BaqBdYXw.md#KeepCoding.KeyHelper.For.T.(T.System.Func.T.T..System.Predicate.T..System.Func.T.T.).func 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Func&lt;T,T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).func') used in an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement')
