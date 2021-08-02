#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.CreateInstance(Type, int[], int[]) Method
Creates a multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') and dimension lengths, with the specified lower bounds.  
```csharp
public static System.Array CreateInstance(this System.Type elementType, int[] lengths, int[] lowerBounds);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int___int__)_elementType'></a>
`elementType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int___int__)_lengths'></a>
`lengths` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A one-dimensional array that contains the size of each dimension of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int___int__)_lowerBounds'></a>
`lowerBounds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A one-dimensional array that contains the lower bound (starting index) of each dimension of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new multidimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') with the specified length and lower bound for each dimension.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
[https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32___System_Int32___](https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32___System_Int32___ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32___System_Int32___')
