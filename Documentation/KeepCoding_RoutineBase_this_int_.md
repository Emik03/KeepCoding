#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.this[int] Property
Indexes into [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').  
```csharp
public Coroutine this[int index] { get; }
```
#### Parameters
<a name='KeepCoding_RoutineBase_this_int__index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index to index into [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').
  
#### Property Value
[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')
#### Exceptions
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
The parameter [index](KeepCoding_RoutineBase_this_int_.md#KeepCoding_RoutineBase_this_int__index 'KeepCoding.RoutineBase.this[int].index') is out of range from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').
### Example
The following example illustrates using one of the implementations of [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase'), in this case [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') to index into [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines'), to show that using the indexer is the same as using [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines'). This is because [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') by itself does not allow you to append any coroutines.  
```csharp
  
using KeepCoding;  
using System.Collections;  
using UnityEngine;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Routine routine = new Routine(Example(), this);  
          
        // This creates a coroutine inside of this variable. There is now 1 coroutine which can be indexed.  
        routine.Start();  
          
        // Because they are the same instance, this expression returns true.  
        Log(routine[0] == routine.Coroutines[0]);  
    }  
      
    private IEnumerator Example()  
    {  
        yield return null;  
    }  
}  
```
  
This is the output from the console.  
```csharp
  
True  
```
  
It is important to note that this is a getter-only property. This means that the following statement cannot be done. Use [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()'), [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()'), or other methods by implemented classes to mutate [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').  
```csharp
  
// Invalid. There is no setter for this indexer.  
routine[1] = routine[0];  
```
### Remarks
Given that [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') acts as a wrapper for handling mulitple coroutines, all of which stored in a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'), this acts as shorthand for accessing a specific index from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').
#### See Also
- [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines')
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
- [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()')
- [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()')
