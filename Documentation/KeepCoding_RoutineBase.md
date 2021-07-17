#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## RoutineBase Class
Provides the base class for the multiple [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') types.  
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
### Example
The following example illustrates a method for returning a [Tuple&lt;T1,T2&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;') of the first and last coroutines, using [ToTuple&lt;T1,T2&gt;(T1, T2)](KeepCoding_TypeHelper_ToTuple_T1_T2_(T1_T2).md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)') as shorthand for constructing the tuple.  
```csharp
  
public static class CoroutineHelper  
{  
    public static Tuple<Coroutine, Coroutine> FirstAndLast(RoutineBase routine)  
    {  
        if (routine.Coroutines.Count == 0)  
            throw new EmptyIteratorException("The routine has no coroutines running!");  
        return routine[0].ToTuple(routine[routine.Count - 1]);  
    }  
}  
```
  
This can be called with anything that inherits from this type to get the coroutines. This example will the type [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') and [Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;').  
```csharp
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Routine routine = new Routine(() => NoParameters(), this);  
        Routine otherRoutine = new Routine(i => NoParameters(i), this);  
          
        // We need to create coroutines before passing them into the method.  
        for (int i = 0; i < 5; i++)  
        {  
            routine.Start();  
              
            // This line ends up logging the numbers [ 1, 2, 3, 4, 5 ] due to OneParameter() calling Log()  
            otherRoutine.Start(i);  
        }  
          
        Tuple<Coroutine, Coroutine> coroutineTuple = CoroutineHelper.FirstAndLast(routine)  
          
        // Stops the first coroutine.  
        StopCoroutine(coroutineTuple.Item1);  
          
        coroutineTuple = CoroutineHelper.FirstAndLast(otherRoutine);  
          
        // Stops the last coroutine.  
        StopCoroutine(coroutineTuple.Item2);  
          
        // This empties the list of coroutines it has internally.  
        routine.StopAll();  
          
        // Uncomment this line below to see an EmptyIteratorException being thrown due to the above line clearing the list.  
        // coroutineTuple = CoroutineHelper.FirstAndLast(routine);  
    }  
      
    private IEnumerator NoParameters()  
    {  
        yield return null;  
    }  
      
    private IEnumerator OneParameter(int i)  
    {  
        Log(i);  
        yield return null;  
    }  
}  
```
### Remarks
[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') provides the general functionality that different types of [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') share in common with. As each different type of [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') gives different amounts of generics, this base class is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of [Routine](KeepCoding_Routine.md 'KeepCoding.Routine').  
            

| Constructors | |
| :--- | :--- |
| [RoutineBase(MonoBehaviour)](KeepCoding_RoutineBase_RoutineBase(MonoBehaviour).md 'KeepCoding.RoutineBase.RoutineBase(MonoBehaviour)') | Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.<br/> |

| Properties | |
| :--- | :--- |
| [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') | The list of all coroutines currently running.<br/> |
| [Count](KeepCoding_RoutineBase_Count.md 'KeepCoding.RoutineBase.Count') | The amount of coroutines stored.<br/> |
| [IsRunning](KeepCoding_RoutineBase_IsRunning.md 'KeepCoding.RoutineBase.IsRunning') | Determines whether it is currently running any coroutines.<br/> |
| [this[int]](KeepCoding_RoutineBase_this_int_.md 'KeepCoding.RoutineBase.this[int]') | Indexes into [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').<br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](KeepCoding_RoutineBase_GetEnumerator().md 'KeepCoding.RoutineBase.GetEnumerator()') | Gets the enumerator of the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine'), using [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines').<br/> |
| [Stop()](KeepCoding_RoutineBase_Stop().md 'KeepCoding.RoutineBase.Stop()') | Stops the first coroutine that was called, and removes it from the list of coroutines.<br/> |
| [StopAll()](KeepCoding_RoutineBase_StopAll().md 'KeepCoding.RoutineBase.StopAll()') | Stops all instances of the coroutine, and clears the list of coroutines.<br/> |
#### See Also
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
