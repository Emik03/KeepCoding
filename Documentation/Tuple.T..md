#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Tuple&lt;T&gt; Class
A basic tuple data type for C# 4.  
```csharp
public class Tuple<T> : KeepCoding.Internal.TupleBase
```
#### Type parameters
<a name='KeepCoding.Tuple.T..T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') &#129106; Tuple&lt;T&gt;  

Derived  
&#8627; [Tuple&lt;T1,T2&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  

| Constructors | |
| :--- | :--- |
| [Tuple()](Tuple.T..Tuple().md 'KeepCoding.Tuple&lt;T&gt;.Tuple()') | Creates a singleton tuple of default values.<br/> |
| [Tuple(T)](Tuple.T...ctor.rlxvpsaXElmrmlnoMpEd4g.md 'KeepCoding.Tuple&lt;T&gt;.Tuple(T)') | Creates a singleton tuple.<br/> |

| Properties | |
| :--- | :--- |
| [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') | The first item of the tuple.<br/> |
| [this[byte]](Tuple.T..Item.oi5GOCxZadHbjK3qPaMAWQ.md 'KeepCoding.Tuple&lt;T&gt;.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](Tuple.T..ToArray.md 'KeepCoding.Tuple&lt;T&gt;.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |

| Methods | |
| :--- | :--- |
| [Destruct(T)](Tuple.T..Destruct.uFurjOgCcolGJlh+ZMhtCw.md 'KeepCoding.Tuple&lt;T&gt;.Destruct(T)') | Destructs the tuple.<br/> |
