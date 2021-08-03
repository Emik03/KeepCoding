#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Find&lt;T&gt;(T[], Predicate&lt;T&gt;) Method
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static T Find<T>(this T[] array, System.Predicate<T> match);
```
#### Type parameters
<a name='KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).array'></a>
`array` [T](ArrayHelper.Find.sB3qvrP9TnVkVX0X91oXhw.md#KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based array to search.
  
<a name='KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).match'></a>
`match` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](ArrayHelper.Find.sB3qvrP9TnVkVX0X91oXhw.md#KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The predicate that defines the conditions of the element to search for.
  
#### Returns
[T](ArrayHelper.Find.sB3qvrP9TnVkVX0X91oXhw.md#KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T')  
The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type [T](ArrayHelper.Find.sB3qvrP9TnVkVX0X91oXhw.md#KeepCoding.ArrayHelper.Find.T.(T...System.Predicate.T.).T 'KeepCoding.ArrayHelper.Find&lt;T&gt;(T[], System.Predicate&lt;T&gt;).T').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=net-5.0')
