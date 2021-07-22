#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.AsEnumerable&lt;T&gt;(IEnumerator&lt;T&gt;) Method
Converts an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').  
```csharp
public static System.Collections.Generic.IEnumerable<T> AsEnumerable<T>(this System.Collections.Generic.IEnumerator<T> source);
```
#### Type parameters
<a name='KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_)_T'></a>
`T`  
The parameter and return type.
  
#### Parameters
<a name='KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_).md#KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_)_T 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
The [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to convert.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_).md#KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_)_T 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_).md#KeepCoding_Helper_AsEnumerable_T_(System_Collections_Generic_IEnumerator_T_)_source 'KeepCoding.Helper.AsEnumerable&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;).source') as an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable').
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
