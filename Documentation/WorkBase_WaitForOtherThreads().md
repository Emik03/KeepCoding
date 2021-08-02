#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal').[WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase')
## WorkBase.WaitForOtherThreads() Method
Waits until it is allowed to run a thread.  
```csharp
private protected System.Collections.IEnumerator WaitForOtherThreads();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[UnityEngine.WaitWhile](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.WaitWhile 'UnityEngine.WaitWhile') until [ThreadsActive](WorkBase_ThreadsActive.md 'KeepCoding.Internal.WorkBase.ThreadsActive') is strictly less than [KeepCoding.Internal.WorkBase._maximumThreadsActive](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.Internal.WorkBase._maximumThreadsActive 'KeepCoding.Internal.WorkBase._maximumThreadsActive').
