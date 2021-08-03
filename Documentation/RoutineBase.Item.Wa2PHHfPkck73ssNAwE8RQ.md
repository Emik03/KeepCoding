#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase')
## RoutineBase.this[int] Property
Indexes into [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
```csharp
public Coroutine this[int index] { get; }
```
#### Parameters
<a name='KeepCoding.Internal.RoutineBase.this.int..index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index to index into [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').
  
#### Property Value
[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')
A coroutine from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') based on the index that was passed in.  
#### Exceptions
[System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
The parameter [index](RoutineBase.Item.Wa2PHHfPkck73ssNAwE8RQ.md#KeepCoding.Internal.RoutineBase.this.int..index 'KeepCoding.Internal.RoutineBase.this[int].index') is out of range from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').
### Example
The following example illustrates using one of the implementations of [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase'), in this case [Routine](Routine.md 'KeepCoding.Routine') to index into [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines'), to show that using the indexer is the same as using [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines'). This is because [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') by itself does not allow you to append any coroutines.  
```csharp
using System.Collections;  
using KeepCoding;  
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
[Foo #1] True  
```
  
It is important to note that this is a getter-only property. This means that the following statement cannot be done. Use [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()'), [StopAll()](RoutineBase.StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()'), or other methods by implemented classes to mutate [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
```csharp
// Invalid. There is no setter for this indexer.  
routine[1] = routine[0];  
```
### Remarks
Given that [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') acts as a wrapper for handling mulitple coroutines, all of which stored in a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'), this acts as shorthand for accessing a specific index from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').  
#### See Also
- [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines')
- [Routine](Routine.md 'KeepCoding.Routine')
- [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()')
- [StopAll()](RoutineBase.StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()')
