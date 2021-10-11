#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.GetEnumerator() Method
Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of the [Routine](Routine.md 'KeepCoding.Routine') from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
```csharp
public System.Collections.IEnumerator GetEnumerator();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') as [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') using [System.Collections.Generic.List&lt;&gt;.GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.GetEnumerator 'System.Collections.Generic.List`1.GetEnumerator').

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')  
### Example
The following example illustrates how [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is empty by default by using [GetEnumerator()](RoutineBase.GetEnumerator().md 'KeepCoding.Internal.RoutineBase.GetEnumerator()') with [Routine](Routine.md 'KeepCoding.Routine') which derives from [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase').  
```csharp
using System.Collections;
using KeepCoding;
using UnityEngine;

public sealed class FooModule : ModuleScript
{
    private void Start()
    {
        IEnumerator ienumerator = new Routine(Example(), this).GetEnumerator();
        
        while (ienumerator.MoveNext())
            throw new Exception("This will not happen.");
            
        Log("Done!");
    }
    
    private IEnumerator Example()
    {
        yield return null;
    }
}
```
  
This is the output from the console.  
```csharp
[Foo #1] Done!
```
### Remarks
This retrieves the [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') as an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator'). Note that [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is never [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') but is empty by default.  
#### See Also
- [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](Routine.md 'KeepCoding.Routine')
