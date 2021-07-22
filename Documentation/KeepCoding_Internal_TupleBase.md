#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal')
## TupleBase Class
Provides the base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') for the multiple tuple types.  
```csharp
public abstract class TupleBase :
KeepCoding.Internal.ITuple,
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.Internal.ITuple>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TupleBase  

Derived  
&#8627; [Tuple&lt;T&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;')  

Implements [ITuple](KeepCoding_Internal_ITuple.md 'KeepCoding.Internal.ITuple'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ITuple](KeepCoding_Internal_ITuple.md 'KeepCoding.Internal.ITuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Example
The following example illustrates a method for returning the last item of any tuple that uses [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase').  
```csharp
using KeepCoding.Internal;  
  
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
[TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase') provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.  
            

| Properties | |
| :--- | :--- |
| [Length](KeepCoding_Internal_TupleBase_Length.md 'KeepCoding.Internal.TupleBase.Length') | Determines the amount of items in the tuple type.<br/> |
| [this[byte]](KeepCoding_Internal_TupleBase_this_byte_.md 'KeepCoding.Internal.TupleBase.this[byte]') | Passes an index into the tuple, where items are considered ordered and part of an array.<br/> |
| [ToArray](KeepCoding_Internal_TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') | Converts all items to an array.<br/> |
| [UpperBound](KeepCoding_Internal_TupleBase_UpperBound.md 'KeepCoding.Internal.TupleBase.UpperBound') | Determines the upperbound of the amount of the length.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(ITuple)](KeepCoding_Internal_TupleBase_Equals(KeepCoding_Internal_ITuple).md 'KeepCoding.Internal.TupleBase.Equals(KeepCoding.Internal.ITuple)') | Compares itself and another [ITuple](KeepCoding_Internal_ITuple.md 'KeepCoding.Internal.ITuple') to determine if they contain the same values.<br/> |
| [Equals(object)](KeepCoding_Internal_TupleBase_Equals(object).md 'KeepCoding.Internal.TupleBase.Equals(object)') | Compares itself and another object attempted to casted as [ITuple](KeepCoding_Internal_ITuple.md 'KeepCoding.Internal.ITuple') to determine if they contain the same values.<br/> |
| [GetEnumerator()](KeepCoding_Internal_TupleBase_GetEnumerator().md 'KeepCoding.Internal.TupleBase.GetEnumerator()') | Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of [ToArray](KeepCoding_Internal_TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').<br/> |
| [GetHashCode()](KeepCoding_Internal_TupleBase_GetHashCode().md 'KeepCoding.Internal.TupleBase.GetHashCode()') | Gets the hash code of [ToArray](KeepCoding_Internal_TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').<br/> |
| [ToString()](KeepCoding_Internal_TupleBase_ToString().md 'KeepCoding.Internal.TupleBase.ToString()') | Joins [ToArray](KeepCoding_Internal_TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') to a string, with a space as a delimiter.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(TupleBase, TupleBase)](KeepCoding_Internal_TupleBase_op_Equality(KeepCoding_Internal_TupleBase_KeepCoding_Internal_TupleBase).md 'KeepCoding.Internal.TupleBase.op_Equality(KeepCoding.Internal.TupleBase, KeepCoding.Internal.TupleBase)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
| [operator !=(TupleBase, TupleBase)](KeepCoding_Internal_TupleBase_op_Inequality(KeepCoding_Internal_TupleBase_KeepCoding_Internal_TupleBase).md 'KeepCoding.Internal.TupleBase.op_Inequality(KeepCoding.Internal.TupleBase, KeepCoding.Internal.TupleBase)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
#### See Also
- [ToTuple&lt;T1,T2&gt;(T1, T2)](KeepCoding_TypeHelper_ToTuple_T1_T2_(T1_T2).md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)')
