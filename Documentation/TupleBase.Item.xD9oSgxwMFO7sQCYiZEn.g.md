#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.this[byte] Property
Passes an index into the tuple, where items are considered ordered and part of an array.  
```csharp
public object this[byte index] { get; set; }
```
#### Parameters
<a name='KeepCoding.Internal.TupleBase.this.byte..index'></a>
`index` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The index to pass into [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items').
  
#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
[Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items') with the index specified.  
            
#### Exceptions
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
The parameter [index](TupleBase.Item.xD9oSgxwMFO7sQCYiZEn.g.md#KeepCoding.Internal.TupleBase.this.byte..index 'KeepCoding.Internal.TupleBase.this[byte].index') is out of range because there are no items in this tuple type.
### Example
The following example illustrates how an [System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException') will always be thrown no matter what index is passed in.  
```csharp
using KeepCoding;  
using KeepCoding.Internal;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        TupleBase tuple = new TupleBase();  
          
        // This uses the getter.  
        Try(b => Log(tuple[b]));  
          
        // This uses the setter.  
        Try(b => tuple[b] = 0);  
    }  
      
    private void Try(Action<byte> act)  
    {  
        for (byte b = byte.MinValue; i < byte.MaxValue; i++)  
        {  
            try  
            {  
                act(b);  
                  
                throw new ArgumentException("This exception will never be thrown because the above operation will always fail!");  
            }  
            catch (IndexOutOfRangeException)  
            {  
                continue;  
            }  
        }  
    }  
}  
```
### Remarks
A [TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase') will always throw an [System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException') regardless if the getter or setter is called as it contains no items to index into. The purpose of this indexer is to provide all derived classes the same [System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException') message. As there is type ambiguity between multiple generics, the [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') type has to be [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') as any value is passed into each item.  
#### See Also
- [Items](TupleBase.Items.md 'KeepCoding.Internal.TupleBase.Items')
