#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.Length Property
Determines the amount of items in the tuple type.  
```csharp
public byte Length { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The number of generics in the current type.  
### Example
The following example illustrates how a method can use the [Length](TupleBase.Length.md 'KeepCoding.Internal.TupleBase.Length') parameter as a way of determining the tuple item count being odd. [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)') is used to convert all tuples to [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean').  
```csharp
using KeepCoding;  
using KeepCoding.Internal;  
  
public static class Extensions  
{  
    public static bool[] IsOdds(params[] TupleBase tuples)  
    {  
        return tuples.ConvertAll(t => t.Length % 2 == 1);  
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
        Log(Extensions.IsOdds(0.ToTuple(), // 1 item  
            0.ToTuple(0), // 2 items  
            0.ToTuple(0, 0), // 3 items  
            0.ToTuple(0, 0, 0))); // 4 items  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] False, True, False, True, False  
```
### Remarks
The length is the amount of items in the tuple, which can be used to index [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items') or the indexer [this[byte]](TupleBase.Item.xD9oSgxwMFO7sQCYiZEn.g.md 'KeepCoding.Internal.TupleBase.this[byte]').  
#### See Also
- [this[byte]](TupleBase.Item.xD9oSgxwMFO7sQCYiZEn.g.md 'KeepCoding.Internal.TupleBase.this[byte]')
- [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items')
- [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)')
