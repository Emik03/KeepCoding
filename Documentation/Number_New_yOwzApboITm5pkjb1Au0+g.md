#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.New&lt;T&gt;(T) Method
Creates a new [Number](Number.md 'KeepCoding.Number') with the inner type being the type specified.  
```csharp
public static KeepCoding.Number New<T>(T _=default(T));
```
#### Type parameters
<a name='KeepCoding_Number_New_T_(T)_T'></a>
`T`  
The inner type of the [Number](Number.md 'KeepCoding.Number').
  
#### Parameters
<a name='KeepCoding_Number_New_T_(T)__'></a>
`_` [T](Number_New_yOwzApboITm5pkjb1Au0+g.md#KeepCoding_Number_New_T_(T)_T 'KeepCoding.Number.New&lt;T&gt;(T).T')  
  
#### Returns
[Number](Number.md 'KeepCoding.Number')  
A [Number](Number.md 'KeepCoding.Number') with inner [T](Number_New_yOwzApboITm5pkjb1Au0+g.md#KeepCoding_Number_New_T_(T)_T 'KeepCoding.Number.New&lt;T&gt;(T).T').
#### Exceptions
[UnrecognizedTypeException](UnrecognizedTypeException.md 'KeepCoding.Internal.UnrecognizedTypeException')  
### Remarks
Calling this will assume that the value is [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), and [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'), [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'), [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'), [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'), [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), or [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal'). An exception is thrown outherwise.  
