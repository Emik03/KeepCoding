#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Tuple&lt;T&gt; Class
A basic tuple data type for C# 4.  
```csharp
public class Tuple<T> : KeepCoding.TupleBase,
System.IEquatable<KeepCoding.Tuple<T>>
```
#### Type parameters
<a name='KeepCoding_Tuple_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase') &#129106; Tuple&lt;T&gt;  

Derived  
&#8627; [Tuple&lt;T1,T2&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[KeepCoding.Tuple&lt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')[T](KeepCoding_Tuple_T_.md#KeepCoding_Tuple_T__T 'KeepCoding.Tuple&lt;T&gt;.T')[&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [Tuple()](KeepCoding_Tuple_T__Tuple().md 'KeepCoding.Tuple&lt;T&gt;.Tuple()') | Creates a singleton tuple of default values.<br/> |
| [Tuple(T)](KeepCoding_Tuple_T__Tuple(T).md 'KeepCoding.Tuple&lt;T&gt;.Tuple(T)') | Creates a singleton tuple.<br/> |

| Properties | |
| :--- | :--- |
| [Item1](KeepCoding_Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') |  |
| [this[byte]](KeepCoding_Tuple_T__this_byte_.md 'KeepCoding.Tuple&lt;T&gt;.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](KeepCoding_Tuple_T__ToArray.md 'KeepCoding.Tuple&lt;T&gt;.ToArray') |  |

| Methods | |
| :--- | :--- |
| [Destruct(T)](KeepCoding_Tuple_T__Destruct(T).md 'KeepCoding.Tuple&lt;T&gt;.Destruct(T)') | Destructs the tuple.<br/> |
| [Equals(Tuple&lt;T&gt;)](KeepCoding_Tuple_T__Equals(KeepCoding_Tuple_T_).md 'KeepCoding.Tuple&lt;T&gt;.Equals(KeepCoding.Tuple&lt;T&gt;)') | Determines whether the tuple is equal.<br/> |
| [Equals(object)](KeepCoding_Tuple_T__Equals(object).md 'KeepCoding.Tuple&lt;T&gt;.Equals(object)') | Determines whether the tuple is equal.<br/> |
| [GetHashCode()](KeepCoding_Tuple_T__GetHashCode().md 'KeepCoding.Tuple&lt;T&gt;.GetHashCode()') | Gets the hash code of [Item1](KeepCoding_Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1').<br/> |
| [ToString()](KeepCoding_Tuple_T__ToString().md 'KeepCoding.Tuple&lt;T&gt;.ToString()') | Gets the item, and returns it as a string.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(Tuple&lt;T&gt;, Tuple&lt;T&gt;)](KeepCoding_Tuple_T__op_Equality(KeepCoding_Tuple_T__KeepCoding_Tuple_T_).md 'KeepCoding.Tuple&lt;T&gt;.op_Equality(KeepCoding.Tuple&lt;T&gt;, KeepCoding.Tuple&lt;T&gt;)') | Evaluates whether the item in the tuple is the same.<br/> |
| [operator !=(Tuple&lt;T&gt;, Tuple&lt;T&gt;)](KeepCoding_Tuple_T__op_Inequality(KeepCoding_Tuple_T__KeepCoding_Tuple_T_).md 'KeepCoding.Tuple&lt;T&gt;.op_Inequality(KeepCoding.Tuple&lt;T&gt;, KeepCoding.Tuple&lt;T&gt;)') | Evaluates whether the item in the tuple is not the same.<br/> |
