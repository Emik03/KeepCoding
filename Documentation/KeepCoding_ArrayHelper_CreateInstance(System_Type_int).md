#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.CreateInstance(Type, int) Method
Creates a one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') and length, with zero-based indexing.  
```csharp
public static System.Array CreateInstance(this System.Type elementType, int length);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int)_elementType'></a>
`elementType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
<a name='KeepCoding_ArrayHelper_CreateInstance(System_Type_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The size of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to create.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of the specified [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') with the specified length, using zero-based indexing.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.createinstance?view=net-5.0#System_Array_CreateInstance_System_Type_System_Int32_')
