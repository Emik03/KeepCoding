#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork(Action) Method
Converts argument to a new [Work](KeepCoding_Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work ToWork(this System.Action action);
```
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork(System_Action)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when the thread is active.
  
#### Returns
[Work](KeepCoding_Work.md 'KeepCoding.Work')  
A new [Work](KeepCoding_Work.md 'KeepCoding.Work') consisting of the arguments provided.
