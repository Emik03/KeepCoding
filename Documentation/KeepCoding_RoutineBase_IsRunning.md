#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase')
## RoutineBase.IsRunning Property
Determines whether it is currently running any coroutines.  
```csharp
public bool IsRunning { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') representing the state in which any coroutines are running.  
### Example
The following example illustrates using an [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') and an [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator') to run separately despite being called at the same time.  
```csharp
using KeepCoding;  
using System.Collections;  
using UnityEngine;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Routine routine = new Routine(First(), this);  
          
        routine.Start();  
          
        StartCoroutine(Second(routine));  
    }  
      
    private IEnumerator First()  
    {  
        foreach (string log in new[] { "First1", "First2", "First3" }  
        {  
            Log(log);  
            yield return new WaitForSeconds(1);  
        }  
    }  
      
    private IEnumerator Second(Routine routine)  
    {  
        yield return new WaitWhile(() => routine.IsRunning);  
        Log("Second");  
    }  
}```
  
This is the output from the console.  
```csharp
[Foo #1] First1  
[Foo #1] First2  
[Foo #1] First3  
[Foo #1] Second```
### Remarks
Typically when coroutines are running they act as a black box with no way to access whether they have finished or not. This property allows you to determine if the containing variable is handling any coroutines. Multiple coroutines running at the same time will still return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), and there is no way to determine the amount of coroutines running at once.
#### See Also
- [Routine](KeepCoding_Routine.md 'KeepCoding.Routine')
