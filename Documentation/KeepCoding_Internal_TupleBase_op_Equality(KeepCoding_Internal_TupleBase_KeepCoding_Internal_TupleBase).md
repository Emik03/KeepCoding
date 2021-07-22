#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.operator ==(TupleBase, TupleBase) Operator
Overrides comparison by checking for individual item equality rather than itself.  
```csharp
public static bool operator ==(KeepCoding.Internal.TupleBase left, KeepCoding.Internal.TupleBase right);
```
#### Parameters
<a name='KeepCoding_Internal_TupleBase_op_Equality(KeepCoding_Internal_TupleBase_KeepCoding_Internal_TupleBase)_left'></a>
`left` [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase')  
The left-hand side [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase') comparison to compare to.
  
<a name='KeepCoding_Internal_TupleBase_op_Equality(KeepCoding_Internal_TupleBase_KeepCoding_Internal_TupleBase)_right'></a>
`right` [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase')  
The right-hand side [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase') comparison to compare to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if all items in the tuple equal the other items of the same index.
### Remarks
For more details about comparison, look at [Equals(TupleBase)](KeepCoding_Internal_TupleBase_Equals(KeepCoding_Internal_TupleBase).md 'KeepCoding.Internal.TupleBase.Equals(KeepCoding.Internal.TupleBase)').  
