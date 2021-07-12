### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.CreateInstance(Type, int[]) Method
Creates a multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.  
```csharp
public static System.Array CreateInstance(this System.Type elementType, params int[] lengths);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int__)_elementType'></a>
`elementType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int__)_lengths'></a>
`lengths` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of 32-bit integers that represent the size of each dimension of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.
