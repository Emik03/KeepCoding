#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.StopAll() Method
Stops all coroutines that were called, and makes [Coroutines](RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') empty.  
```csharp
public void StopAll();
```
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[Coroutines](RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is empty.
### Example
The following example illustrates running [StopAll()](RoutineBase_StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') twice to demonstrate the error using the [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class')[Routine](Routine.md 'KeepCoding.Routine') which inherits from [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase'). As [StopAll()](RoutineBase_StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') expects at least 1 coroutine, the code will cause an [EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException').  
```csharp
using System.Collections;  
using KeepCoding;  
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
          
        // Uncomment the line below to cause an error because there are no coroutines to remove.  
        // routine.StopAll();  
    }  
      
    private IEnumerator Example()  
    {  
        yield return null;  
    }  
}  
```
### Remarks
[StopAll()](RoutineBase_StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') stops and removes all coroutines from [Coroutines](RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines'), as such, it cannot be called twice in a row without throwing an exception or adding a coroutine in-between. Note that when the coroutines are finished, they do not get removed from the list. If [StopAll()](RoutineBase_StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') is called on coroutines which have already stopped, those coroutines will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.  
            
#### See Also
- [Coroutines](RoutineBase_Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](Routine.md 'KeepCoding.Routine')
