#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Indistinct&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Filters an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), only allowing duplicated items.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Indistinct<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters
<a name='KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_)_T'></a>
`T`  
The type of the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Parameters
<a name='KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_).md#KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_)_T 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to filter through.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_).md#KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_)_T 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A new instance of [source](KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_).md#KeepCoding_Helper_Indistinct_T_(System_Collections_Generic_IEnumerable_T_)_source 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source') that only includes elements which are repeated in the array.
