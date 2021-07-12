### [KeepCoding](KeepCoding.md 'KeepCoding')
## WorkBase Class
Abstract class for the [Work](KeepCoding_Work.md 'KeepCoding.Work') datatype, since the different overloads are similar to each other. Written by Emik.  
```csharp
public abstract class WorkBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; WorkBase  

Derived  
&#8627; [Work](KeepCoding_Work.md 'KeepCoding.Work')  
&#8627; [Work&lt;T&gt;](KeepCoding_Work_T_.md 'KeepCoding.Work&lt;T&gt;')  
&#8627; [Work&lt;T,TResult&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')  
&#8627; [Work&lt;T1,T2,T3,T4,TResult&gt;](KeepCoding_Work_T1_T2_T3_T4_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')  
&#8627; [Work&lt;T1,T2,T3,TResult&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;')  
&#8627; [Work&lt;T1,T2,TResult&gt;](KeepCoding_Work_T1_T2_TResult_.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')  

| Properties | |
| :--- | :--- |
| [AllowSimultaneousActive](KeepCoding_WorkBase_AllowSimultaneousActive.md 'KeepCoding.WorkBase.AllowSimultaneousActive') |  |
| [IsRunning](KeepCoding_WorkBase_IsRunning.md 'KeepCoding.WorkBase.IsRunning') |  |
| [Thread](KeepCoding_WorkBase_Thread.md 'KeepCoding.WorkBase.Thread') |  |
| [ThreadsActive](KeepCoding_WorkBase_ThreadsActive.md 'KeepCoding.WorkBase.ThreadsActive') |  |

| Methods | |
| :--- | :--- |
| [Stop()](KeepCoding_WorkBase_Stop().md 'KeepCoding.WorkBase.Stop()') | Interrupts the thread.<br/> |
| [WaitForOtherThreads()](KeepCoding_WorkBase_WaitForOtherThreads().md 'KeepCoding.WorkBase.WaitForOtherThreads()') | Waits until it is allowed to run a thread.<br/> |
| [WaitForOwnThread()](KeepCoding_WorkBase_WaitForOwnThread().md 'KeepCoding.WorkBase.WaitForOwnThread()') | Waits until its own thread is no longer running..<br/> |
