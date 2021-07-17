#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.StopAll() Method
Stops all coroutines that were called, and makes [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') empty.  
```csharp
public void StopAll();
```
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') is empty.
### Example
The following example illustrates running [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') twice to demonstrate the error using the [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class')[Routine](KeepCoding_Routine.md 'KeepCoding.Routine') which inherits from [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase'). As [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') expects at least 1 coroutine, the code will cause an [EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException').  
```csharp
using KeepCoding;  
using System.Collections;  
using UnityEngine;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Routine routine = new Routine(Example(), this);  
          
        // This creates the first coroutine.  
        routine.Start();  
          
        // This creates the second coroutine.  
        routine.Start();  
          
        // This stops the first and second coroutine.  
        routine.StopAll();  
          
        // This will cause an error because there are no coroutines to remove.  
        routine.StopAll();  
    }  
      
    private IEnumerator Example()  
    {  
        yield return null;  
    }  
}  
```
### Remarks
[StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') stops and removes all coroutines from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines'), as such, it cannot be called twice in a row without throwing an exception or adding a coroutine in-between. Note that when the coroutines are finished, they do not get removed from the list. If [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') is called on coroutines which have already stopped, those coroutines will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.
#### See Also
- [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines')
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
