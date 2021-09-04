#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## WorkBase Class
Abstract class for the [Work](Work.md 'KeepCoding.Work') datatype, since the different overloads are similar to each other.  
```csharp
public abstract class WorkBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; WorkBase  

Derived  
&#8627; [Work](Work.md 'KeepCoding.Work')  
&#8627; [Work&lt;T&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')  
&#8627; [Work&lt;T,TResult&gt;](Work.T.TResult..md 'KeepCoding.Work&lt;T,TResult&gt;')  
&#8627; [Work&lt;T1,T2,T3,T4,TResult&gt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')  
&#8627; [Work&lt;T1,T2,T3,TResult&gt;](Work.T1.T2.T3.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')  
&#8627; [Work&lt;T1,T2,TResult&gt;](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')  

| Properties | |
| :--- | :--- |
| [AllowSimultaneousActive](WorkBase.AllowSimultaneousActive.md 'KeepCoding.Internal.WorkBase.AllowSimultaneousActive') | Determines whether it should skip on starting a thread if it doesn't allow multiple.<br/> |
| [IsRunning](WorkBase.IsRunning.md 'KeepCoding.Internal.WorkBase.IsRunning') | Determines whether any thread in this class is running.<br/> |
| [Thread](WorkBase.Thread.md 'KeepCoding.Internal.WorkBase.Thread') | The thread of the class.<br/> |
| [ThreadsActive](WorkBase.ThreadsActive.md 'KeepCoding.Internal.WorkBase.ThreadsActive') | Counts the number of threads currently active within this class, and all of its overloads.<br/> |

| Methods | |
| :--- | :--- |
| [~WorkBase()](WorkBase.~WorkBase().md 'KeepCoding.Internal.WorkBase.~WorkBase()') | This aborts the thread. It's to prevent the Editor from freezing from unloading the thread while it is in use, and potentially prevent issues in-game from similar actions.<br/> |
| [Stop()](WorkBase.Stop().md 'KeepCoding.Internal.WorkBase.Stop()') | Interrupts the thread.<br/> |
| [WaitForOtherThreads()](WorkBase.WaitForOtherThreads().md 'KeepCoding.Internal.WorkBase.WaitForOtherThreads()') | Waits until it is allowed to run a thread.<br/> |
| [WaitForOwnThread()](WorkBase.WaitForOwnThread().md 'KeepCoding.Internal.WorkBase.WaitForOwnThread()') | Waits until its own thread is no longer running..<br/> |
