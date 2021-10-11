#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.Count Property
The amount of coroutines stored.  
```csharp
public int Count { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') representing the length of [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
### Example
The following example illustrates a method that uses [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') to remove one entry from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') and returns the size of the collection using [Count](RoutineBase.Count.md 'KeepCoding.Internal.RoutineBase.Count').  
```csharp
using KeepCoding.Internal;

public static class CoroutineHelper
{
    public static int StopAndCount(RoutineBase routine)
    {
        routine.Stop();
        
        return routine.Count;
    }
}
```
  
This will now be called using [Routine](Routine.md 'KeepCoding.Routine').  
```csharp
using KeepCoding;
using System.Collections;
using UnityEngine;

public sealed class FooModule : ModuleScript
{
    private void Start()
    {
        Routine routine = new Routine(Example(), this);
        
        // This increases the count to 1 because a coroutine gets appended.
        routine.Start();
        
        Log(routine.Count);
        
        // This will stop which removes 1 and return the new length which is 0.
        Log(CoroutineHelper.StopAndCount(routine));
    }
    
    private IEnumerator Example()
    {
        yield return null;
    }
}
```
  
This is the output from the console.  
```csharp
[Foo #1] 1
[Foo #1] 0
```
### Remarks
Given that [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') acts as a wrapper for handling mulitple coroutines, all of which stored in a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'), this acts as shorthand for accessing the [System.Collections.Generic.List&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.Count 'System.Collections.Generic.List`1.Count') from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines'). [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') will never be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') which means [Count](RoutineBase.Count.md 'KeepCoding.Internal.RoutineBase.Count') never throws an exception. Note that this does not store the amount of coroutines running, as finished coroutines will still be kept inside the [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines'). When [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') or [StopAll()](RoutineBase.StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') is called however, the coroutines to get removed from the [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') which will change the count and therefore this getter.  
#### See Also
- [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](Routine.md 'KeepCoding.Routine')
- [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()')
- [StopAll()](RoutineBase.StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()')
