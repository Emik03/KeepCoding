#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.Stop() Method
Stops the first coroutine that was called, and removes it from [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').  
```csharp
public void Stop();
```
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
[Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') is empty.
### Remarks
Every time a coroutine gets added, it does so at the end of the [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'). When [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') is called, the first and therefore oldest coroutine gets removed from this list in a similar vein to [System.Collections.Queue](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Queue 'System.Collections.Queue'). Note that when the coroutines are finished, they do not get removed from the list. If [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') is called on a coroutine which has already stopped, the first coroutine will still be attempted to be stopped, which will in that case do nothing, and be removed from the list.
#### See Also
- [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines')
