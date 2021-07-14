#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.TrueForAll&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Determines whether every element in the array matches the conditions defined by the specified predicate.  
```csharp
public static bool TrueForAll<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_array'></a>
`array` [T](KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.TrueForAll&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to check against the conditions.
  
<a name='KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_T 'KeepCoding.ArrayHelper.TrueForAll&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The predicate that defines the conditions to check against the elements.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if every element in [array](KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_).md#KeepCoding_ArrayHelper_TrueForAll_T_(T___System_Predicate_T_)_array 'KeepCoding.ArrayHelper.TrueForAll&lt;T&gt;(T[], System.Predicate&lt;T&gt;).array') matches the conditions defined by the specified predicate; otherwise, `false`. If there are no elements in the array, the return value is `true`.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.trueforall?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.trueforall?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.trueforall?view=net-5.0')
