#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[RoutineBase](KeepCoding_Internal_RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.GetEnumerator() Method
Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') from [Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
```csharp
public System.Collections.IEnumerator GetEnumerator();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') as [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') using [System.Collections.Generic.List&lt;&gt;.GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.GetEnumerator 'System.Collections.Generic.List`1.GetEnumerator').

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')  
### Example
The following example illustrates how [Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is empty by default by using [GetEnumerator()](KeepCoding_Internal_RoutineBase_GetEnumerator().md 'KeepCoding.Internal.RoutineBase.GetEnumerator()') with [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') which derives from [RoutineBase](KeepCoding_Internal_RoutineBase.md 'KeepCoding.Internal.RoutineBase').  
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
This retrieves the [Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') as an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator'). Note that [Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is never [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') but is empty by default.  
#### See Also
- [Coroutines](KeepCoding_Internal_RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
