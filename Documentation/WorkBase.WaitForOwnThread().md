#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase')
## WorkBase.WaitForOwnThread() Method
Waits until its own thread is no longer running..  
```csharp
private protected System.Collections.IEnumerator WaitForOwnThread();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[UnityEngine.WaitWhile](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.WaitWhile 'UnityEngine.WaitWhile') until [IsRunning](WorkBase.IsRunning.md 'KeepCoding.Internal.WorkBase.IsRunning') is no longer true.
