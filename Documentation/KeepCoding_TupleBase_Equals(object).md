#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.Equals(object) Method
Overrides [System.Object.Equals(System.Object)](https://docs.microsoft.com/en-us/dotnet/api/System.Object.Equals#System_Object_Equals_System_Object_ 'System.Object.Equals(System.Object)') by checking for individual item equality rather than itself.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='KeepCoding_TupleBase_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if all items in the tuple equal the other items of the same index.
### Remarks
For more details about comparison, look at [Equals(ITuple)](KeepCoding_TupleBase_Equals(KeepCoding_ITuple).md 'KeepCoding.TupleBase.Equals(KeepCoding.ITuple)').  
