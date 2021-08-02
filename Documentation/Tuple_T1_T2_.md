#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Tuple&lt;T1,T2&gt; Class
A basic tuple data type for C# 4.   
```csharp
public class Tuple<T1,T2> : KeepCoding.Tuple<T1>
```
#### Type parameters
<a name='KeepCoding_Tuple_T1_T2__T1'></a>
`T1`  
  
<a name='KeepCoding_Tuple_T1_T2__T2'></a>
`T2`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') &#129106; [KeepCoding.Tuple&lt;](Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')[T1](Tuple_T1_T2_.md#KeepCoding_Tuple_T1_T2__T1 'KeepCoding.Tuple&lt;T1,T2&gt;.T1')[&gt;](Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;') &#129106; Tuple&lt;T1,T2&gt;  

Derived  
&#8627; [Tuple&lt;T1,T2,T3&gt;](Tuple_T1_T2_T3_.md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;')  

| Constructors | |
| :--- | :--- |
| [Tuple()](Tuple_T1_T2__Tuple().md 'KeepCoding.Tuple&lt;T1,T2&gt;.Tuple()') | Creates a singleton tuple of default values.<br/> |
| [Tuple(T1, T2)](Tuple_T1_T2___ctor_E7xW8ZpoLwfb0hszhKAyaw.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Tuple(T1, T2)') | Creates a tuple of size 2.<br/> |

| Properties | |
| :--- | :--- |
| [Item2](Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') | The second item of the tuple.<br/> |
| [this[byte]](Tuple_T1_T2__Item_W7Pkzsy_8wxWZqBmDAYlWg.md 'KeepCoding.Tuple&lt;T1,T2&gt;.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](Tuple_T1_T2__ToArray.md 'KeepCoding.Tuple&lt;T1,T2&gt;.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |

| Methods | |
| :--- | :--- |
| [Destruct(T1, T2)](Tuple_T1_T2__Destruct_ebEbC6FCVwjL5jafy1Wyuw.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Destruct(T1, T2)') | Destructs the tuple.<br/> |
