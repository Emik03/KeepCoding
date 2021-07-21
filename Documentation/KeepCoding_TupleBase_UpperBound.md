#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.UpperBound Property
Determines the upperbound of the amount of the length.  
```csharp
public byte UpperBound { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
[Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length') - 1.  
            
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The length is 0, and therefore the upper bound doesn't exist.

Implements [UpperBound](KeepCoding_ITuple_UpperBound.md 'KeepCoding.ITuple.UpperBound')  
### Example
The following example illusrates a method that retrieves the last item of the tuple.  
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
This can be used for indexing [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray') or the indexer [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]'), getting the last item of the tuple. Calling [UpperBound](KeepCoding_TupleBase_UpperBound.md 'KeepCoding.TupleBase.UpperBound') assumes that there is at least 1 generic in this type.  
#### See Also
- [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]')
- [Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length')
- [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray')
