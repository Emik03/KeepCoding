#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.FindIndex&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static int FindIndex<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).array'></a>
`array` [T](ArrayHelper.FindIndex.6TciVmjmSdHSFEiwspNQZA.md#KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.FindIndex&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to search.
  
<a name='KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](ArrayHelper.FindIndex.6TciVmjmSdHSFEiwspNQZA.md#KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.FindIndex&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The [System.Predicate&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1') that defines the conditions of the element to search for.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the first occurrence of an element that matches the conditions defined by [match](ArrayHelper.FindIndex.6TciVmjmSdHSFEiwspNQZA.md#KeepCoding.ArrayHelper.FindIndex.T.(T...System.Predicate.T.).match 'KeepCoding.ArrayHelper.FindIndex&lt;T&gt;(T[], System.Predicate&lt;T&gt;).match'), if found; otherwise, -1.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
