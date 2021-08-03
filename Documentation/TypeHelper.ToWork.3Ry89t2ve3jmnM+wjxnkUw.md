#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork(uint, Action, bool) Method
Converts argument to a new [Work](Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work ToWork(this uint maximumThreadsActive, System.Action action, bool allowSimultaneousActive=false);
```
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork(uint.System.Action.bool).maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding.TypeHelper.ToWork(uint.System.Action.bool).action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when the thread is active.
  
<a name='KeepCoding.TypeHelper.ToWork(uint.System.Action.bool).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[Work](Work.md 'KeepCoding.Work')  
A new [Work](Work.md 'KeepCoding.Work') consisting of the arguments provided.
