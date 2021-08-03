#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.GetHashCode() Method
Gets the hash code of [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The hash code of this instance.
### Example
The following example illustrates how two of the same values will result in the same hash code.  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Tuple<int> first = 2.ToTuple(),  
            second = 2.ToTuple();  
              
        Log(first.GetHashCode() == second.GetHashCode());  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] True  
```
### Remarks
Hash codes are a way of quickly asserting equality. It converts all of the given relevant variables into hash codes and combines into a number that makes it unlikely for two different types to have the same hash code. That being said, it is still possible for the hash codes to be identical but not for the same values to have different hash codes, which is why it only should be used as the first step in determining equality and confirming by making the final comparisons to those with equal hash codes. For more information, see [System.Object.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/System.Object.GetHashCode 'System.Object.GetHashCode').  
#### See Also
- [ToArray](TupleBase.ToArray.md 'KeepCoding.Internal.TupleBase.ToArray')
