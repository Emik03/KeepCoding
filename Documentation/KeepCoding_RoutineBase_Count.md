#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.Count Property
The amount of coroutines stored.  
```csharp
public int Count { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') representing the length of [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').  
### Example
The following example illustrates a method that uses [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') to remove one entry from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') and returns the size of the collection using [Count](KeepCoding_RoutineBase_Count.md 'KeepCoding.RoutineBase.Count').  
```csharp
using KeepCoding;  
  
public static class CoroutineHelper  
{  
    public static int StopAndCount(RoutineBase routine)  
    {  
        routine.Stop();  
          
        return routine.Count;  
    }  
}  
```
  
This will now be called using [Routine](KeepCoding_Routine.md 'KeepCoding.Routine').  
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
Given that [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') acts as a wrapper for handling mulitple coroutines, all of which stored in a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'), this acts as shorthand for accessing the [System.Collections.Generic.List&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.Count 'System.Collections.Generic.List`1.Count') from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines'). [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') will never be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') which means [Count](KeepCoding_RoutineBase_Count.md 'KeepCoding.RoutineBase.Count') never throws an exception. Note that this does not store the amount of coroutines running, as finished coroutines will still be kept inside the [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines'). When [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') or [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') is called however, the coroutines to get removed from the [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') which will change the count and therefore this getter.  
#### See Also
- [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines')
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
- [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()')
- [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()')
