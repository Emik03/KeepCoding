#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.operator !=(TupleBase, TupleBase) Operator
Overrides comparison by checking for individual item equality rather than itself.  
```csharp
public static bool operator !=(KeepCoding.TupleBase left, KeepCoding.TupleBase right);
```
#### Parameters
<a name='KeepCoding_TupleBase_op_Inequality(KeepCoding_TupleBase_KeepCoding_TupleBase)_left'></a>
`left` [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')  
The left-hand side [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase') comparison to compare to.
  
<a name='KeepCoding_TupleBase_op_Inequality(KeepCoding_TupleBase_KeepCoding_TupleBase)_right'></a>
`right` [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')  
The right-hand side [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase') comparison to compare to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if any item in the tuple does not equal the other item of the same index.
### Remarks
For more details about comparison, look at [Equals(ITuple)](KeepCoding_TupleBase_Equals(KeepCoding_ITuple).md 'KeepCoding.TupleBase.Equals(KeepCoding.ITuple)').  
