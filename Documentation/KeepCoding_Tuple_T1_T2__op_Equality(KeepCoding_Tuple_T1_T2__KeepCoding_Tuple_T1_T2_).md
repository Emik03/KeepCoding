### [KeepCoding](KeepCoding.md 'KeepCoding').[Tuple&lt;T1,T2&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')
## Tuple&lt;T1,T2&gt;.operator ==(Tuple&lt;T1,T2&gt;, Tuple&lt;T1,T2&gt;) Operator
Evaluates whether the item in the tuple is the same.  
```csharp
public static bool operator ==(KeepCoding.Tuple<T1,T2> tupleA, KeepCoding.Tuple<T1,T2> tupleB);
```
#### Parameters
<a name='KeepCoding_Tuple_T1_T2__op_Equality(KeepCoding_Tuple_T1_T2__KeepCoding_Tuple_T1_T2_)_tupleA'></a>
`tupleA` [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T1](KeepCoding_Tuple_T1_T2_.md#KeepCoding_Tuple_T1_T2__T1 'KeepCoding.Tuple&lt;T1,T2&gt;.T1')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T2](KeepCoding_Tuple_T1_T2_.md#KeepCoding_Tuple_T1_T2__T2 'KeepCoding.Tuple&lt;T1,T2&gt;.T2')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The left-hand side comparison.
  
<a name='KeepCoding_Tuple_T1_T2__op_Equality(KeepCoding_Tuple_T1_T2__KeepCoding_Tuple_T1_T2_)_tupleB'></a>
`tupleB` [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T1](KeepCoding_Tuple_T1_T2_.md#KeepCoding_Tuple_T1_T2__T1 'KeepCoding.Tuple&lt;T1,T2&gt;.T1')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T2](KeepCoding_Tuple_T1_T2_.md#KeepCoding_Tuple_T1_T2__T2 'KeepCoding.Tuple&lt;T1,T2&gt;.T2')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
The right-hand side comparison.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if tupleA.ToArray.ToArray and all of tupleB.ToArray.ToArray are equal in sequence.
