#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')
## TupleBase.Length Property
Determines the amount of items in the tuple type.  
```csharp
public byte Length { get; }
```
#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The number of generics in the current type.  

Implements [Length](KeepCoding_ITuple_Length.md 'KeepCoding.ITuple.Length')  
### Example
The following example illustrates how a method can use the [Length](KeepCoding_TupleBase_Length.md 'KeepCoding.TupleBase.Length') parameter as a way of determining the tuple item count being odd. [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)') is used to convert all tuples to [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean').  
```csharp
using KeepCoding;  
  
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
        Log(Extensions.IsOdds(new TupleBase(), // 0 items  
            0.ToTuple(), // 1 item  
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
The length is the amount of items in the tuple, which can be used to index [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray') or the indexer [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]').  
#### See Also
- [this[byte]](KeepCoding_TupleBase_this_byte_.md 'KeepCoding.TupleBase.this[byte]')
- [ToArray](KeepCoding_TupleBase_ToArray.md 'KeepCoding.TupleBase.ToArray')
- [ConvertAll&lt;TInput,TOutput&gt;(TInput[], Converter&lt;TInput,TOutput&gt;)](KeepCoding_ArrayHelper_ConvertAll_TInput_TOutput_(TInput___System_Converter_TInput_TOutput_).md 'KeepCoding.ArrayHelper.ConvertAll&lt;TInput,TOutput&gt;(TInput[], System.Converter&lt;TInput,TOutput&gt;)')
