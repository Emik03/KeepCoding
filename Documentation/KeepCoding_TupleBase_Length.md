#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.Length Property
Determines the amount of items in the tuple type.  
```csharp
public byte Length { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

Implements [Length](KeepCoding_ITuple_Length.md 'KeepCoding.ITuple.Length')  
### Example
The following example illustrates how a method can use the [Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length') parameter as a way of determining the tuple item count being odd.  
```csharp
using KeepCoding;  
  
public static class Extensions  
{  
    public static bool IsOddLength(TupleBase tuple)  
    {  
        return tuple.Length % 2 == 1;  
    }  
}  
```
  
Next is five variables of all different lengths are now being tested.  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        TupleBase zero = new TupleBase();  
        Tuple<int> one = 0.ToTuple();  
        Tuple<int, int> two = 0.ToTuple(0);  
        Tuple<int, int, int> three = 0.ToTuple(0, 0);  
        Tuple<int, int, int, int> four = 0.ToTuple(0, 0, 0);  
    }  
}  
```
### Remarks
The number of generics there are is considered the amount of items there are, since with each new item there needs to be a new generic.  
