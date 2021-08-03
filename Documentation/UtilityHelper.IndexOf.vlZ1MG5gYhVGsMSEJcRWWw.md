#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.IndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;) Method
Returns the index of the first element in this [source](UtilityHelper.IndexOf.vlZ1MG5gYhVGsMSEJcRWWw.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).source') satisfying the specified [predicate](UtilityHelper.IndexOf.vlZ1MG5gYhVGsMSEJcRWWw.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).predicate 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).predicate'). If no such elements are found, returns `-1`.
```csharp
public static int IndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,bool> predicate);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.IndexOf.vlZ1MG5gYhVGsMSEJcRWWw.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityHelper.IndexOf.vlZ1MG5gYhVGsMSEJcRWWw.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.bool.).T 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
