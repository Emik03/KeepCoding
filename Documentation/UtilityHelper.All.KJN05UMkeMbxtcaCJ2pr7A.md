#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.All&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,int,bool&gt;) Method
Determines whether all elements of a sequence satisfy a condition by incorporating the element's index.
```csharp
public static bool All<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,int,bool> predicate);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T'></a>
`T`  
The type of the elements of [source](UtilityHelper.All.KJN05UMkeMbxtcaCJ2pr7A.md#KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).source 'KeepCoding.UtilityHelper.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).source').
  
#### Parameters
<a name='KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.All.KJN05UMkeMbxtcaCJ2pr7A.md#KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T 'KeepCoding.UtilityHelper.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') that contains the elements to apply the predicate to.
  
<a name='KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](UtilityHelper.All.KJN05UMkeMbxtcaCJ2pr7A.md#KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).T 'KeepCoding.UtilityHelper.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
A function to test each element for a condition; the second parameter of the function represents the index of  
the source element.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if every element of the source sequence passes the test in the specified [predicate](UtilityHelper.All.KJN05UMkeMbxtcaCJ2pr7A.md#KeepCoding.UtilityHelper.All.T.(System.Collections.Generic.IEnumerable.T..System.Func.T.int.bool.).predicate 'KeepCoding.UtilityHelper.All&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,int,bool&gt;).predicate'), or if the sequence is empty; otherwise, false.
