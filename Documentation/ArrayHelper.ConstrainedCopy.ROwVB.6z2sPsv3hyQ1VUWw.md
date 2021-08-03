#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.ConstrainedCopy(Array, int, Array, int, int) Method
Copies a range of elements from an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified source index and pastes them to another [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.  
```csharp
public static System.Array ConstrainedCopy(this System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length);
```
#### Parameters
<a name='KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).sourceArray'></a>
`sourceArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the data to copy.
  
<a name='KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).sourceIndex'></a>
`sourceIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the index in the [sourceArray](ArrayHelper.ConstrainedCopy.ROwVB.6z2sPsv3hyQ1VUWw.md#KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).sourceArray 'KeepCoding.ArrayHelper.ConstrainedCopy(System.Array, int, System.Array, int, int).sourceArray') at which copying begins.
  
<a name='KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).destinationArray'></a>
`destinationArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that receives the data.
  
<a name='KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).destinationIndex'></a>
`destinationIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the index in the [destinationArray](ArrayHelper.ConstrainedCopy.ROwVB.6z2sPsv3hyQ1VUWw.md#KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).destinationArray 'KeepCoding.ArrayHelper.ConstrainedCopy(System.Array, int, System.Array, int, int).destinationArray') at which storing begins.
  
<a name='KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the number of elements to copy.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[destinationArray](ArrayHelper.ConstrainedCopy.ROwVB.6z2sPsv3hyQ1VUWw.md#KeepCoding.ArrayHelper.ConstrainedCopy(System.Array.int.System.Array.int.int).destinationArray 'KeepCoding.ArrayHelper.ConstrainedCopy(System.Array, int, System.Array, int, int).destinationArray')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.constrainedcopy?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.constrainedcopy?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.constrainedcopy?view=net-5.0')
