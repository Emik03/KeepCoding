### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.FindLast&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T FindLast<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_array'></a>
`array` [T](KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.FindLast&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.FindLast&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The [System.Predicate&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1') that defines the conditions of the element to search for.
  
#### Returns
[T](KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.FindLast&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')  
The last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type [T](KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_FindLast_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.FindLast&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T').
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.findlast?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.findlast?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.findlast?view=net-5.0')
