#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FirstOrDefault&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;, T) Method
Returns the first element of a sequence, or a default value if the sequence contains no elements.
```csharp
public static T FirstOrDefault<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate, T @default);
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).T'></a>
`T`  
The type of the elements of [source](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).source').
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A function to test each element for a condition.
  
<a name='KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).default'></a>
`default` [T](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).T')  
The default value to return if the sequence contains no elements.
  
#### Returns
[T](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).T')  
[default](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).default 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).default') if [source](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).source') is empty or if no element passes the test specified by  
                [predicate](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).predicate 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).predicate'); otherwise, the first element in [source](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).source') that passes the test  
                specified by [predicate](UtilityExtensions.FirstOrDefault.JLoR6CGqquT9ChEwoGEUwg.md#KeepCoding.UtilityExtensions.FirstOrDefault.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool..T).predicate 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, T).predicate').
