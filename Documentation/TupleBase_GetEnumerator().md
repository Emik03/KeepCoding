#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[TupleBase](TupleBase.md 'KeepCoding.Internal.TupleBase')
## TupleBase.GetEnumerator() Method
Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of [ToArray](TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray').  
```csharp
public System.Collections.IEnumerator GetEnumerator();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')  
### Example
The following example illustrates how items in [ToArray](TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') get converted into an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator'), and using that [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to print every value.  
```csharp
using System.Collections;  
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Tuple<int, string[], bool> tuple = 0.ToTuple(new[] { "test1", "test2", "test3" }, false);  
              
        IEnumerator ienumerator = tuple.GetEnumerator();  
  
        while (ienumerator.MoveNext())  
            Log(ienumerator.Current);  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] 0  
[Foo #1] test1  
[Foo #1] test2  
[Foo #1] test3  
[Foo #1] False  
```
### Remarks
This method is needed to implement [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') interface. It takes [ToArray](TupleBase_ToArray.md 'KeepCoding.Internal.TupleBase.ToArray') and performs [System.Array.GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Array.GetEnumerator 'System.Array.GetEnumerator').  