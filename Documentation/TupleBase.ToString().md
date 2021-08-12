#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.ToString() Method
Joins [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items') to a string, with a space as a delimiter.  
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items') from [Stringify&lt;T&gt;(T, StringifyFormat)](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat)').
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
Each element of [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items') is passed into [Stringify&lt;T&gt;(T, StringifyFormat)](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat)') to unpack iterators and allow each element to be seen. For more details about stringification, refer to [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString').  
#### See Also
- [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items')
- [Stringify&lt;T&gt;(T, StringifyFormat)](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat)')
