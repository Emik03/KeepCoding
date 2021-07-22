#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.SetOrReplace&lt;T&gt;(IDictionary&lt;T,int&gt;, T, Func&lt;int,int&gt;) Method
Sets or replaces the value of a dictionary with a given function.  
```csharp
public static int SetOrReplace<T>(this System.Collections.Generic.IDictionary<T,int> source, T key, System.Func<int,int> func);
```
#### Type parameters
<a name='KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_T'></a>
`T`  
Type of the key of the dictionary.
  
#### Parameters
<a name='KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[T](KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_).md#KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_T 'KeepCoding.Helper.SetOrReplace&lt;T&gt;(System.Collections.Generic.IDictionary&lt;T,int&gt;, T, System.Func&lt;int,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_key'></a>
`key` [T](KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_).md#KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_T 'KeepCoding.Helper.SetOrReplace&lt;T&gt;(System.Collections.Generic.IDictionary&lt;T,int&gt;, T, System.Func&lt;int,int&gt;).T')  
Key at which the list is located in the dictionary.
  
<a name='KeepCoding_Helper_SetOrReplace_T_(System_Collections_Generic_IDictionary_T_int__T_System_Func_int_int_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function that returns the new value.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The new value at the specified key.
#### Exceptions
[NullIteratorException](KeepCoding_Internal_NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
