#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.GetUpperBound&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Returns the last index of the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').  
```csharp
public static int GetUpperBound<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters
<a name='KeepCoding_Helper_GetUpperBound_T_(System_Collections_Generic_IEnumerable_T_)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_Helper_GetUpperBound_T_(System_Collections_Generic_IEnumerable_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper_GetUpperBound_OiFPAWOlKoyGQjAD3JYtzQ.md#KeepCoding_Helper_GetUpperBound_T_(System_Collections_Generic_IEnumerable_T_)_T 'KeepCoding.Helper.GetUpperBound&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to check length for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
[source](Helper_GetUpperBound_OiFPAWOlKoyGQjAD3JYtzQ.md#KeepCoding_Helper_GetUpperBound_T_(System_Collections_Generic_IEnumerable_T_)_source 'KeepCoding.Helper.GetUpperBound&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source').Count() - 1
