#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work](Work.md 'KeepCoding.Work')
## Work.Work(Action) Constructor
Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.  
```csharp
public Work(System.Action work);
```
#### Parameters
<a name='KeepCoding_Work_Work(System_Action)_work'></a>
`work` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The method to call when thread starts.
  
