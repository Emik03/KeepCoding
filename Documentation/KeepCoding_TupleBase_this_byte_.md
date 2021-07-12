### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.this[byte] Property
Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.  
```csharp
public object this[byte index] { get; set; }
```
#### Parameters
<a name='KeepCoding_TupleBase_this_byte__index'></a>
`index` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The index to use.
  
#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
#### Exceptions
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
[WrongDatatypeException](KeepCoding_WrongDatatypeException.md 'KeepCoding.WrongDatatypeException')  

Implements [this[byte]](KeepCoding_ITuple_this_byte_.md 'KeepCoding.ITuple.this[byte]')  
