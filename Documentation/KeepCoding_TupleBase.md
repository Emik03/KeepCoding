#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## TupleBase Class
An abstract type meant for the tuple data type for C# 4.  
```csharp
public abstract class TupleBase :
KeepCoding.ITuple,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TupleBase  

Derived  
&#8627; [Tuple&lt;T&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')  

Implements [ITuple](KeepCoding_ITuple.md 'KeepCoding.ITuple'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Properties | |
| :--- | :--- |
| [IsEmpty](KeepCoding_TupleBase_IsEmpty.md 'KeepCoding.TupleBase.IsEmpty') |  |
| [Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length') |  |
| [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray') |  |
| [UpperBound](KeepCoding_TupleBase_UpperBound.md 'KeepCoding.TupleBase.UpperBound') |  |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](KeepCoding_TupleBase_GetEnumerator().md 'KeepCoding.TupleBase.GetEnumerator()') | Gets the enumerator of the tuple, using [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray').<br/> |
