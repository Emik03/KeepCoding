#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## Tuple Class
Provides the base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') for the multiple tuple types.  
```csharp
public abstract class Tuple :
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.Internal.Tuple>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Tuple  

Derived  
&#8627; [Tuple&lt;T&gt;](Tuple.T..md 'KeepCoding.Tuple&lt;T&gt;')  

Implements [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Tuple](Tuple.md 'KeepCoding.Internal.Tuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Example
The following example illustrates a method for returning the last item of any tuple that uses [Tuple](Tuple.md 'KeepCoding.Internal.Tuple').  
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
[Tuple](Tuple.md 'KeepCoding.Internal.Tuple') provides the general functionality that different types of tuples share in common with. As each different type of tuple gives different amounts of generics, this base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of tuple.  
            

| Properties | |
| :--- | :--- |
| [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items') | Converts all items to an array.<br/> |
| [Length](Tuple.Length.md 'KeepCoding.Internal.Tuple.Length') | Determines the amount of items in the tuple type.<br/> |
| [this[byte]](Tuple.Item.VXJ58El9nJ4r0Zn7YdkEyA.md 'KeepCoding.Internal.Tuple.this[byte]') | Passes an index into the tuple, where items are considered ordered and part of an array.<br/> |
| [UpperBound](Tuple.UpperBound.md 'KeepCoding.Internal.Tuple.UpperBound') | Determines the upperbound of the amount of the length.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(Tuple)](Tuple.Equals.xuvtsrnmJPfxho6gW7dWgA.md 'KeepCoding.Internal.Tuple.Equals(KeepCoding.Internal.Tuple)') | Compares itself and another [Tuple](Tuple.md 'KeepCoding.Internal.Tuple') to determine if they contain the same values.<br/> |
| [Equals(object)](Tuple.Equals.qPlTOxZ7sZxu7IqwzcsoVg.md 'KeepCoding.Internal.Tuple.Equals(object)') | Compares itself and another object attempted to casted as [Tuple](Tuple.md 'KeepCoding.Internal.Tuple') to determine if they contain the same values.<br/> |
| [GetEnumerator()](Tuple.GetEnumerator().md 'KeepCoding.Internal.Tuple.GetEnumerator()') | Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items').<br/> |
| [GetHashCode()](Tuple.GetHashCode().md 'KeepCoding.Internal.Tuple.GetHashCode()') | Gets the hash code of [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items').<br/> |
| [ToString()](Tuple.ToString().md 'KeepCoding.Internal.Tuple.ToString()') | Joins [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items') to a string, with a space as a delimiter.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(Tuple, Tuple)](Tuple.op_Equality.Z.AcGBR3oJrwRX0pb6qyxg.md 'KeepCoding.Internal.Tuple.op_Equality(KeepCoding.Internal.Tuple, KeepCoding.Internal.Tuple)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
| [operator !=(Tuple, Tuple)](Tuple.op_Inequality.WUgFrEItkKnfaYHpDtqdKg.md 'KeepCoding.Internal.Tuple.op_Inequality(KeepCoding.Internal.Tuple, KeepCoding.Internal.Tuple)') | Overrides comparison by checking for individual item equality rather than itself.<br/> |
#### See Also
- [ToTuple&lt;T1,T2&gt;(T1, T2)](TypeHelper.ToTuple.LI2EmOv9CB.9ftgGskWBBQ.md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)')
