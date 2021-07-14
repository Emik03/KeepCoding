#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase')
## WorkBase.WaitForOtherThreads() Method
Waits until it is allowed to run a thread.  
```csharp
private protected System.Collections.IEnumerator WaitForOtherThreads();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[UnityEngine.WaitWhile](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.WaitWhile 'UnityEngine.WaitWhile') until [ThreadsActive](KeepCoding_WorkBase_ThreadsActive.md 'KeepCoding.WorkBase.ThreadsActive') is strictly less than [KeepCoding.WorkBase._maximumThreadsActive](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.WorkBase._maximumThreadsActive 'KeepCoding.WorkBase._maximumThreadsActive').
