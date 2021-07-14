#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Exists&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Determines whether the specified array contains elements that match the conditions defined by the specified predicate.  
```csharp
public static bool Exists<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_array'></a>
`array` [T](KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Exists&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Exists&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The [System.Predicate&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1') that defines the conditions of the elements to search for.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [array](KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Exists_T_(T___System_Predicate_T_)_array 'KeepCoding.ArrayHelper.Exists&lt;T&gt;(T[], System.Predicate&lt;T&gt;).array') contains one or more elements that match the conditions defined by the specified predicate; otherwise, `false`.
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-5.0')
