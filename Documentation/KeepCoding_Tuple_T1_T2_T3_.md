#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Tuple&lt;T1,T2,T3&gt; Class
A basic tuple data type for C# 4.   
```csharp
public class Tuple<T1,T2,T3> : KeepCoding.Tuple<T1, T2>
```
#### Type parameters
<a name='KeepCoding_Tuple_T1_T2_T3__T1'></a>
`T1`  
  
<a name='KeepCoding_Tuple_T1_T2_T3__T2'></a>
`T2`  
  
<a name='KeepCoding_Tuple_T1_T2_T3__T3'></a>
`T3`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase') &#129106; [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')[T1](KeepCoding_Tuple_T1_T2_T3_.md#KeepCoding_Tuple_T1_T2_T3__T1 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.T1')[&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;') &#129106; [KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T1](KeepCoding_Tuple_T1_T2_T3_.md#KeepCoding_Tuple_T1_T2_T3__T1 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.T1')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[T2](KeepCoding_Tuple_T1_T2_T3_.md#KeepCoding_Tuple_T1_T2_T3__T2 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.T2')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;') &#129106; Tuple&lt;T1,T2,T3&gt;  

Derived  
&#8627; [Tuple&lt;T1,T2,T3,T4&gt;](KeepCoding_Tuple_T1_T2_T3_T4_.md 'KeepCoding.Tuple&lt;T1,T2,T3,T4&gt;')  

| Constructors | |
| :--- | :--- |
| [Tuple()](KeepCoding_Tuple_T1_T2_T3__Tuple().md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.Tuple()') | Creates a singleton tuple of default values.<br/> |
| [Tuple(T1, T2, T3)](KeepCoding_Tuple_T1_T2_T3__Tuple(T1_T2_T3).md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.Tuple(T1, T2, T3)') | Creates a tuple of size 3.<br/> |

| Properties | |
| :--- | :--- |
| [Item3](KeepCoding_Tuple_T1_T2_T3__Item3.md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.Item3') | The third item of the tuple.<br/> |
| [this[byte]](KeepCoding_Tuple_T1_T2_T3__this_byte_.md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](KeepCoding_Tuple_T1_T2_T3__ToArray.md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |

| Methods | |
| :--- | :--- |
| [Destruct(T1, T2, T3)](KeepCoding_Tuple_T1_T2_T3__Destruct(T1_T2_T3).md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;.Destruct(T1, T2, T3)') | Destructs the tuple.<br/> |
