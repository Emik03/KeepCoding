#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.FindLastIndex&lt;T&gt;(T[], int, Predicate&lt;T&gt;) Method
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that extends from the specified index to the last element.  
```csharp
public static int FindLastIndex<T>(this T[] array, int startIndex, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).array'></a>
`array` [T](ArrayHelper.FindLastIndex.iFXW8Lp+S1YSzvCfiRwlIw.md#KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).T 'KeepCoding.ArrayHelper.FindLastIndex&lt;T&gt;(T[], int, System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).startIndex'></a>
`startIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based starting index of the search.
  
<a name='KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](ArrayHelper.FindLastIndex.iFXW8Lp+S1YSzvCfiRwlIw.md#KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).T 'KeepCoding.ArrayHelper.FindLastIndex&lt;T&gt;(T[], int, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The [System.Predicate&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1') that defines the conditions of the element to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the last occurrence of an element that matches the conditions defined by [match](ArrayHelper.FindLastIndex.iFXW8Lp+S1YSzvCfiRwlIw.md#KeepCoding.ArrayHelper.FindLastIndex.T.(T...int.System.Predicate.T.).match 'KeepCoding.ArrayHelper.FindLastIndex&lt;T&gt;(T[], int, System.Predicate&lt;T&gt;).match'), if found; otherwise, -1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Predicate___0__](https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Predicate___0__ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Predicate___0__')
