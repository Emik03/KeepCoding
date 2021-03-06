#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.IndexOf&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,int,bool&gt;) Method
Returns the index of the first element in this [source](UtilityHelper.IndexOf.V85eDPlmafN3ETF+JkhsRQ.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).source 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).source') satisfying the specified [predicate](UtilityHelper.IndexOf.V85eDPlmafN3ETF+JkhsRQ.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).predicate 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).predicate'). The second parameter receives the index of each element. If no such elements are found,  
returns `-1`.
```csharp
public static int IndexOf<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,int,bool> predicate);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.IndexOf.V85eDPlmafN3ETF+JkhsRQ.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityHelper.IndexOf.V85eDPlmafN3ETF+JkhsRQ.md#KeepCoding.UtilityHelper.IndexOf.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T 'KeepCoding.UtilityHelper.IndexOf&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
