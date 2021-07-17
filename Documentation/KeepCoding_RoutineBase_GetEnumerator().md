#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.GetEnumerator() Method
Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').  
```csharp
public System.Collections.IEnumerator GetEnumerator();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') as [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') using [System.Collections.Generic.List&lt;&gt;.GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.GetEnumerator 'System.Collections.Generic.List`1.GetEnumerator').

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')  
### Example
The following example illustrates how [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') is empty by default by using [GetEnumerator()](KeepCoding_RoutineBase_GetEnumerator().md 'KeepCoding.RoutineBase.GetEnumerator()') with [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') which derives from [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase').  
```csharp
using KeepCoding;  
using System.Collections;  
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
}```
  
This is the output from the console.  
```csharp
[Foo #1] Done!```
### Remarks
This retrieves the [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') as an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator'). Note that [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') is never [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') but is empty by default.
#### See Also
- [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines')
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
