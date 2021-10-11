#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[Tuple](Tuple.md 'KeepCoding.Internal.Tuple')
## Tuple.UpperBound Property
Determines the upperbound of the amount of the length.  
```csharp
public byte UpperBound { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
[Length](Tuple.Length.md 'KeepCoding.Internal.Tuple.Length') - 1.  
            
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The length is 0, and therefore the upper bound doesn't exist.
### Example
The following example illusrates a method that retrieves the last item of the tuple.  
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
  
Now the method will be tested.  
```csharp
using KeepCoding;

public sealed class FooModule : ModuleScript
{
    private void Start()
    {
        Log(Extensions.Last(0.ToTuple()));
        Log(Extensions.Last(1.ToTuple(2)));
        Log(Extensions.Last(3.ToTuple(4, 5)));
        Log(Extensions.Last(6.ToTuple(7, 8, 9)));
    }
}
```
  
This is the output from the console.  
```csharp
[Foo #1] 0
[Foo #1] 2
[Foo #1] 5
[Foo #1] 9
```
### Remarks
This can be used for indexing [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items') or the indexer [this[byte]](Tuple.Item.VXJ58El9nJ4r0Zn7YdkEyA.md 'KeepCoding.Internal.Tuple.this[byte]'), getting the last item of the tuple. Calling [UpperBound](Tuple.UpperBound.md 'KeepCoding.Internal.Tuple.UpperBound') assumes that there is at least 1 generic in this type.  
#### See Also
- [this[byte]](Tuple.Item.VXJ58El9nJ4r0Zn7YdkEyA.md 'KeepCoding.Internal.Tuple.this[byte]')
- [Length](Tuple.Length.md 'KeepCoding.Internal.Tuple.Length')
- [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items')
