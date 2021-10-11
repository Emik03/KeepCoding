#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## RoutineBase Class
Provides the base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') for the multiple routine types.  
```csharp
public abstract class RoutineBase :
System.Collections.Generic.IEnumerable<Coroutine>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RoutineBase  

Derived  
&#8627; [Routine](Routine.md 'KeepCoding.Routine')  
&#8627; [Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;')  
&#8627; [Routine&lt;T1,T2&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')  
&#8627; [Routine&lt;T1,T2,T3&gt;](Routine.T1.T2.T3..md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')  
&#8627; [Routine&lt;T1,T2,T3,T4&gt;](Routine.T1.T2.T3.T4..md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')  

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
### Example
The following example illustrates a method for returning a [Tuple&lt;T1,T2&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;') of the first and last coroutines, using [ToTuple&lt;T1,T2&gt;(T1, T2)](TypeHelper.ToTuple.LI2EmOv9CB.9ftgGskWBBQ.md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)') as shorthand for constructing the tuple. This method needs a [RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') with at least 1 coroutine, so an exception is raised if [Count](RoutineBase.Count.md 'KeepCoding.Internal.RoutineBase.Count') is 0.  
```csharp
using KeepCoding;
using KeepCoding.Internal;
using UnityEngine;

public static class CoroutineHelper
{
    public static Tuple<Coroutine, Coroutine> FirstAndLast(RoutineBase routine)
    {
        if (routine.Count == 0)
            throw new EmptyIteratorException("routine");
            
        return routine[0].ToTuple(routine[routine.Count - 1]);
    }
}
```
  
This can be called with anything that inherits from this type to get the coroutines. This example will use the types [Routine](Routine.md 'KeepCoding.Routine') and [Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;').  
```csharp
using System.Collections;
using KeepCoding;
using UnityEngine;

public sealed class FooModule : ModuleScript
{
    private void Start()
    {
        Routine routine = new Routine(() => NoParameters(), this);
        Routine otherRoutine = new Routine(i => OneParameter(i), this);
        
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
[RoutineBase](RoutineBase.md 'KeepCoding.Internal.RoutineBase') provides the general functionality that different types of routines share in common with. As each different type of routine gives different amounts of generics, this base [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') is therefore non-generic and provides every method that doesn't require it. This can therefore be used as a way of passing in an ambiguous type of routine.  
            

| Properties | |
| :--- | :--- |
| [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') | The collection of all coroutines.<br/> |
| [Count](RoutineBase.Count.md 'KeepCoding.Internal.RoutineBase.Count') | The amount of coroutines stored.<br/> |
| [IsRunning](RoutineBase.IsRunning.md 'KeepCoding.Internal.RoutineBase.IsRunning') | Determines whether it is currently running any coroutines.<br/> |
| [this[int]](RoutineBase.Item.Wa2PHHfPkck73ssNAwE8RQ.md 'KeepCoding.Internal.RoutineBase.this[int]') | Indexes into [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').<br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](RoutineBase.GetEnumerator().md 'KeepCoding.Internal.RoutineBase.GetEnumerator()') | Gets the [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') of the [Routine](Routine.md 'KeepCoding.Routine') from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').<br/> |
| [Stop()](RoutineBase.Stop().md 'KeepCoding.Internal.RoutineBase.Stop()') | Stops the first coroutine that was called, and removes it from [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines').<br/> |
| [StopAll()](RoutineBase.StopAll().md 'KeepCoding.Internal.RoutineBase.StopAll()') | Stops all coroutines that were called, and makes [Coroutines](RoutineBase.Coroutines.md 'KeepCoding.Internal.RoutineBase.Coroutines') empty.<br/> |
#### See Also
- [Count](RoutineBase.Count.md 'KeepCoding.Internal.RoutineBase.Count')
- [Routine](Routine.md 'KeepCoding.Routine')
- [Tuple&lt;T1,T2&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')
- [ToTuple&lt;T1,T2&gt;(T1, T2)](TypeHelper.ToTuple.LI2EmOv9CB.9ftgGskWBBQ.md 'KeepCoding.TypeHelper.ToTuple&lt;T1,T2&gt;(T1, T2)')
