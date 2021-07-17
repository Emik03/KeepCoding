#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.Coroutines Property
The collection of all coroutines.  
```csharp
public System.Collections.Generic.List<Coroutine> Coroutines { get; set; }
```
#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') which contains all of the stored coroutines.  
### Example
The following example illustrates how [Coroutines](KeepCoding_RoutineBase_Coroutines.md 'KeepCoding.RoutineBase.Coroutines') starts out as empty. A helper method will be first created to check for an empty list.  
```csharp
using System.Collections;  
  
public static class Helper  
{  
    public static bool IsEmpty(this T list) where T : IList  
    {  
        if (list == null)  
            throw new NullIteratorException("list");  
              
        return list.Count;  
    }  
}  
```
  
Now a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class') which implements [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') such as [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') can demonstrate this effect.  
```csharp
using KeepCoding;  
using System.Collections;  
using UnityEngine;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        // This grabs the list of coroutines right after the constructor is finished, and abanndons the rest of the routine type.  
        List<Coroutine> coroutines = new Routine(Example(), this).Coroutines;  
  
        // Due to the fact that nothing was done with the routine, this would return true.  
        Log(coroutines.IsEmpty());  
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
### Remarks
[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') can store multiple coroutines in order to be able to handle multiple coroutines. This [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') starts out empty and will never be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
#### See Also
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
