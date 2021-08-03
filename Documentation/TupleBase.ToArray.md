#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.ToArray Property
Converts all items to an array.  
```csharp
public abstract object[] ToArray { get; }
```
#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
All items.  
### Example
The following example illustrates how an entire tuple can be printed using [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray'), since [Log&lt;T&gt;(T, object[])](Logger.Log.VQRwxNpiXEL9B9w1CEt5IA.md 'KeepCoding.Logger.Log&lt;T&gt;(T, object[])') can print arrays.  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Log(4.ToTuple(3, 2, 1).ToArray);  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] 4, 3, 2, 1  
```
### Remarks
As the types are not determined, they have to be boxed in [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object').  
#### See Also
- [Log&lt;T&gt;(T, object[])](Logger.Log.VQRwxNpiXEL9B9w1CEt5IA.md 'KeepCoding.Logger.Log&lt;T&gt;(T, object[])')
