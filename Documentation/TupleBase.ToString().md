#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.ToString() Method
Joins [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') to a string, with a space as a delimiter.  
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') from [Helper.Stringify<T>(T)](https://docs.microsoft.com/en-us/dotnet/api/Helper.Stringify<T>#Helper_Stringify<T>_T_ 'Helper.Stringify<T>(T)').
### Example
The following example illustrates how a tuple gets converted to a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Tuple<int, string[], bool> tuple = 0.ToTuple(new[] { "test1", "test2", "test3" }, false);  
              
        Log(first.ToString());  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] 0, test1, test2, test3, False  
```
### Remarks
Each element of [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') is passed into [Helper.Stringify<T>(T)](https://docs.microsoft.com/en-us/dotnet/api/Helper.Stringify<T>#Helper_Stringify<T>_T_ 'Helper.Stringify<T>(T)') to unpack iterators and allow each element to be seen. For more details about stringification, refer to [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString').  
#### See Also
- [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray')
- [Helper.Stringify<T>(T)](https://docs.microsoft.com/en-us/dotnet/api/Helper.Stringify<T>#Helper_Stringify<T>_T_ 'Helper.Stringify<T>(T)')
