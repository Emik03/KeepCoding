#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.Stop() Method
Stops the first coroutine that was called, and removes it from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
```csharp
public void Stop();
```
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') is empty.
### Example
The following example illustrates running [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') three times despite only having two coroutines using the [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class')[Routine](Routine.md 'KeepCoding.Routine') which inherits from [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase'). As [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') expects at least 1 coroutine, the code will cause an [EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException').  
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
        
        // This stops the first coroutine.
        routine.Stop();
        
        // This stops the second coroutine.
        routine.Stop();
        
        // Uncomment the line below to cause an error because there are no coroutines to remove.
        // routine.Stop();
    }
    
    private IEnumerator Example()
    {
        yield return null;
    }
}
```
### Remarks
Every time a coroutine gets added, it does so at the end of the [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'). When [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') is called, the first and therefore oldest coroutine gets removed from this list in a similar vein to [System.Collections.Queue](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Queue 'System.Collections.Queue'). Note that when the coroutines are finished, they do not get removed from the list. If [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') is called on a coroutine which has already stopped, the first coroutine will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.  
#### See Also
- [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](Routine.md 'KeepCoding.Routine')
