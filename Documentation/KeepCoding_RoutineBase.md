### [KeepCoding](KeepCoding.md 'KeepCoding')
## RoutineBase Class
Abstract class for the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') datatype, since the different overloads are similar to each other. Written by Emik.  
```csharp
public abstract class RoutineBase :
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RoutineBase  

Derived  
&#8627; [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')  
&#8627; [Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;')  
&#8627; [Routine&lt;T1,T2&gt;](KeepCoding_Routine_T1_T2_.md 'KeepCoding.Routine&lt;T1,T2&gt;')  
&#8627; [Routine&lt;T1,T2,T3&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')  
&#8627; [Routine&lt;T1,T2,T3,T4&gt;](KeepCoding_Routine_T1_T2_T3_T4_.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')  

Implements [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Constructors | |
| :--- | :--- |
| [RoutineBase(MonoBehaviour)](KeepCoding_RoutineBase_RoutineBase(MonoBehaviour).md 'KeepCoding.RoutineBase.RoutineBase(MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Properties | |
| :--- | :--- |
| [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') |  |
| [Count](KeepCoding_RoutineBase_Count.md 'KeepCoding.RoutineBase.Count') |  |
| [IsRunning](KeepCoding_RoutineBase_IsRunning.md 'KeepCoding.RoutineBase.IsRunning') |  |
| [this[int]](KeepCoding_RoutineBase_this_int_.md 'KeepCoding.RoutineBase.this[int]') | Indexes into [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').<br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](KeepCoding_RoutineBase_GetEnumerator().md 'KeepCoding.RoutineBase.GetEnumerator()') | Gets the enumerator of the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine'), using [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').<br/> |
| [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') | Stops the first coroutine that was called, and removes it from the list of coroutines.<br/> |
| [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') | Stops all instances of the coroutine, and clears the list of coroutines.<br/> |
