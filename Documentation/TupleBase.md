#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## TupleBase Class
Provides the base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') for the multiple tuple types.  
```csharp
public abstract class TupleBase :
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.Internal.TupleBase>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TupleBase  

Derived  
&#8627; [Tuple&lt;T&gt;](Tuple.T..md 'KeepCoding.Tuple&lt;T&gt;')  

Implements [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Example
The following example illustrates a method for returning the last item of any tuple that uses [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase').  
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
  
This can then used on any kind of tuple. A constructor can be used, but in this example the extension method [ToTuple&lt;T1,T2&gt;(T1, T2)](TypeHelper.ToTuple.LI2EmOv9CB.9ftgGskWBBQ.md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)') is used instead.  
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
[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.  
            

| Properties | |
| :--- | :--- |
| [Length](TupleBase.Length.md 'KeepCoding.Internal.TupleBase.Length') | Determines the amount of items in the tuple type.<br/> |
| [this[byte]](TupleBase.Item.xD9oSgxwMFO7sQCYiZEn.g.md 'KeepCoding.Internal.TupleBase.this[byte]') | Passes an index into the tuple, where items are considered ordered and part of an array.<br/> |
| [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') | Converts all items to an array.<br/> |
| [UpperBound](TupleBase.UpperBound.md 'KeepCoding.Internal.TupleBase.UpperBound') | Determines the upperbound of the amount of the length.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(TupleBase)](TupleBase.Equals.HuhNuJeXWPM+umotXvsseQ.md 'KeepCoding.Internal.TupleBase.Equals(KeepCoding.Internal.TupleBase)') | Compares itself and another [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') to determine if they contain the same values.<br/> |
| [Equals(object)](TupleBase.Equals.amqDAq1qhQ3GOIML433Idw.md 'KeepCoding.Internal.TupleBase.Equals(object)') | Compares itself and another object attempted to casted as [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') to determine if they contain the same values.<br/> |
| [GetEnumerator()](TupleBase.GetEnumerator().md 'KeepCoding.Internal.TupleBase.GetEnumerator()') | Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').<br/> |
| [GetHashCode()](TupleBase.GetHashCode().md 'KeepCoding.Internal.TupleBase.GetHashCode()') | Gets the hash code of [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').<br/> |
| [ToString()](TupleBase.ToString().md 'KeepCoding.Internal.TupleBase.ToString()') | Joins [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') to a string, with a space as a delimiter.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(TupleBase, TupleBase)](TupleBase.op_Equality.s5GsIBlGxCppnFCGceJQcQ.md 'KeepCoding.Internal.TupleBase.op_Equality(KeepCoding.Internal.TupleBase, KeepCoding.Internal.TupleBase)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
| [operator !=(TupleBase, TupleBase)](TupleBase.op_Inequality.pEQp7JTYsbs8qi3AYLpxRA.md 'KeepCoding.Internal.TupleBase.op_Inequality(KeepCoding.Internal.TupleBase, KeepCoding.Internal.TupleBase)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
#### See Also
- [ToTuple&lt;T1,T2&gt;(T1, T2)](TypeHelper.ToTuple.LI2EmOv9CB.9ftgGskWBBQ.md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)')
