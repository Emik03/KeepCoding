#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[Tuple](Tuple.md 'KeepCoding.Internal.Tuple')
## Tuple.Length Property
Determines the amount of items in the tuple type.  
```csharp
public byte Length { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The number of generics in the current type.  
### Example
The following example illustrates how a method can use the [Length](Tuple.Length.md 'KeepCoding.Internal.Tuple.Length') parameter as a way of determining the tuple item count being odd. [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)') is used to convert all tuples to [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean').  
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
The length is the amount of items in the tuple, which can be used to index [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items') or the indexer [this[byte]](Tuple.Item.VXJ58El9nJ4r0Zn7YdkEyA.md 'KeepCoding.Internal.Tuple.this[byte]').  
#### See Also
- [this[byte]](Tuple.Item.VXJ58El9nJ4r0Zn7YdkEyA.md 'KeepCoding.Internal.Tuple.this[byte]')
- [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items')
- [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](ArrayHelper.ConvertAll.Nd6Y1H3fix1AnfN9NVjGiA.md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)')
