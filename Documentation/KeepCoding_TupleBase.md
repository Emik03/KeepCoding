#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## TupleBase Class
Provides the base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') for the multiple tuple types.  
```csharp
public abstract class TupleBase :
KeepCoding.ITuple,
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.ITuple>,
System.IEquatable<KeepCoding.TupleBase>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TupleBase  

Derived  
&#8627; [Tuple&lt;T&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')  

Implements [ITuple](KeepCoding_ITuple.md 'KeepCoding.ITuple'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ITuple](KeepCoding_ITuple.md 'KeepCoding.ITuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Example
The following example illustrates a method for returning the last item of any tuple that uses [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase').  
```csharp
using KeepCoding;  
  
public static class Extensions  
{  
    public static object Last(TupleBase tuple)  
    {  
        return tuple[tuple.UpperBound];  
    }  
}  
```
  
This can then used on any kind of tuple. A constructor can be used, but in this example the extension method [ToTuple&lt;T1,T2&gt;(T1, T2)](KeepCoding_TypeHelper_ToTuple_T1_T2_(T1_T2).md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)') is used instead.  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Tuple<int, string> tuple = 0.ToTuple("bar");  
          
        object o = Extensions.Last(tuple);  
          
        Log(o);  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] bar  
```
### Remarks
[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase') provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.  
            

| Properties | |
| :--- | :--- |
| [IsEmpty](KeepCoding_TupleBase_IsEmpty.md 'KeepCoding.TupleBase.IsEmpty') | undefined<br/> |
| [Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length') | undefined<br/> |
| [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]') | Passes an index into the tuple, where items are considered ordered and part of an array.<br/> |
| [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray') | undefined<br/> |
| [UpperBound](KeepCoding_TupleBase_UpperBound.md 'KeepCoding.TupleBase.UpperBound') | undefined<br/> |

| Methods | |
| :--- | :--- |
| [Equals(ITuple)](KeepCoding_TupleBase_Equals(KeepCoding_ITuple).md 'KeepCoding.TupleBase.Equals(KeepCoding.ITuple)') | undefined<br/> |
| [Equals(TupleBase)](KeepCoding_TupleBase_Equals(KeepCoding_TupleBase).md 'KeepCoding.TupleBase.Equals(KeepCoding.TupleBase)') | undefined<br/> |
| [Equals(object)](KeepCoding_TupleBase_Equals(object).md 'KeepCoding.TupleBase.Equals(object)') | undefined<br/> |
| [GetEnumerator()](KeepCoding_TupleBase_GetEnumerator().md 'KeepCoding.TupleBase.GetEnumerator()') | undefined<br/> |
| [GetHashCode()](KeepCoding_TupleBase_GetHashCode().md 'KeepCoding.TupleBase.GetHashCode()') | undefined<br/> |
| [ToString()](KeepCoding_TupleBase_ToString().md 'KeepCoding.TupleBase.ToString()') | undefined<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(TupleBase, TupleBase)](KeepCoding_TupleBase_op_Equality(KeepCoding_TupleBase_KeepCoding_TupleBase).md 'KeepCoding.TupleBase.op_Equality(KeepCoding.TupleBase, KeepCoding.TupleBase)') | undefined<br/> |
| [operator !=(TupleBase, TupleBase)](KeepCoding_TupleBase_op_Inequality(KeepCoding_TupleBase_KeepCoding_TupleBase).md 'KeepCoding.TupleBase.op_Inequality(KeepCoding.TupleBase, KeepCoding.TupleBase)') | undefined<br/> |
#### See Also
- [ToTuple&lt;T1,T2&gt;(T1, T2)](KeepCoding_TypeHelper_ToTuple_T1_T2_(T1_T2).md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)')
