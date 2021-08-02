#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Tuple&lt;T&gt; Class
A basic tuple data type for C# 4.  
```csharp
public class Tuple<T> : KeepCoding.Internal.TupleBase
```
#### Type parameters
<a name='KeepCoding_Tuple_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') &#129106; Tuple&lt;T&gt;  

Derived  
&#8627; [Tuple&lt;T1,T2&gt;](Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  

| Constructors | |
| :--- | :--- |
| [Tuple()](Tuple_T__Tuple().md 'KeepCoding.Tuple&lt;T&gt;.Tuple()') | Creates a singleton tuple of default values.<br/> |
| [Tuple(T)](Tuple_T___ctor_rlxvpsaXElmrmlnoMpEd4g.md 'KeepCoding.Tuple&lt;T&gt;.Tuple(T)') | Creates a singleton tuple.<br/> |

| Properties | |
| :--- | :--- |
| [Item1](Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') | The first item of the tuple.<br/> |
| [this[byte]](Tuple_T__Item_oi5GOCxZadHbjK3qPaMAWQ.md 'KeepCoding.Tuple&lt;T&gt;.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](Tuple_T__ToArray.md 'KeepCoding.Tuple&lt;T&gt;.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |

| Methods | |
| :--- | :--- |
| [Destruct(T)](Tuple_T__Destruct_uFurjOgCcolGJlh+ZMhtCw.md 'KeepCoding.Tuple&lt;T&gt;.Destruct(T)') | Destructs the tuple.<br/> |
