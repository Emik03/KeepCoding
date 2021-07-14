#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.LastValue&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,T&gt;) Method
Returns the last element which doesn't return null, or null if all of them return null.  
```csharp
public static T LastValue<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,T> func);
```
#### Type parameters
<a name='KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_T'></a>
`T`  
The type of array, and method.
  
#### Parameters
<a name='KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The array to iterate on.
  
<a name='KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The method which returns
  
#### Returns
[T](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_T 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).T')  
The last value from [source](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_source 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).source') where [func](KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_).md#KeepCoding_Helper_LastValue_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_T_)_func 'KeepCoding.Helper.LastValue&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,T&gt;).func') doesn't return null, or null.
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
