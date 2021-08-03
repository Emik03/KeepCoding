#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FirstOrNull&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;) Method
Returns the first element of a sequence that satisfies a given predicate, or `null` if the sequence  
contains no elements.
```csharp
public static System.Nullable<T> FirstOrNull<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T'></a>
`T`  
The type of the elements of [source](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source').
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
<a name='KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Only consider elements that satisfy this predicate.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
`null` if [source](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source') is empty; otherwise, the first element in [source](UtilityExtensions.FirstOrNull.RLy3lkWhwORZodxSXU52Ew.md#KeepCoding.UtilityExtensions.FirstOrNull.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source 'KeepCoding.UtilityExtensions.FirstOrNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source').
