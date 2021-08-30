#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work](Work.md 'KeepCoding.Work')
## Work.Work(Action, bool, int) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Action work, bool allowSimultaneousActive, int maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding.Work.Work(System.Action.bool.int).work'></a>
`work` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The method to call when thread starts.
  
<a name='KeepCoding.Work.Work(System.Action.bool.int).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding.Work.Work(System.Action.bool.int).maximumThreadsActive'></a>
`maximumThreadsActive` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of threads this class, and all of its overloads can run at once.
  
