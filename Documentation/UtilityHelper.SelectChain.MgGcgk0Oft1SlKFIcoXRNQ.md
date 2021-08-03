#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.SelectChain&lt;T&gt;(T, Func&lt;T,T&gt;) Method
Enumerates a chain of objects where each object refers to the next one. The chain starts with the specified  
object and ends when null is encountered.
```csharp
public static System.Collections.Generic.IEnumerable<T> SelectChain<T>(this T obj, System.Func<T,T> next)
    where T : class;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).T'></a>
`T`  
Type of object to enumerate.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).obj'></a>
`obj` [T](UtilityHelper.SelectChain.MgGcgk0Oft1SlKFIcoXRNQ.md#KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).T 'KeepCoding.UtilityHelper.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
Initial object.
  
<a name='KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).next'></a>
`next` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityHelper.SelectChain.MgGcgk0Oft1SlKFIcoXRNQ.md#KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).T 'KeepCoding.UtilityHelper.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityHelper.SelectChain.MgGcgk0Oft1SlKFIcoXRNQ.md#KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).T 'KeepCoding.UtilityHelper.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A function that returns the next object given the current one. If null is returned, enumeration will end.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.SelectChain.MgGcgk0Oft1SlKFIcoXRNQ.md#KeepCoding.UtilityHelper.SelectChain.T.(T.System.Func.T.T.).T 'KeepCoding.UtilityHelper.SelectChain&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
