### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Find&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T Find<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_array'></a>
`array` [T](KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based array to search.
  
<a name='KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The predicate that defines the conditions of the element to search for.
  
#### Returns
[T](KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')  
The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type [T](KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_Find_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0')
