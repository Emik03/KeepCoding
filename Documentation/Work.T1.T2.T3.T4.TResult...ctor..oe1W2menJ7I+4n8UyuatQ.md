#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T1,T2,T3,T4,TResult&gt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')
## Work&lt;T1,T2,T3,T4,TResult&gt;.Work(Func&lt;T1,T2,T3,T4,TResult&gt;, bool, uint) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Func<T1,T2,T3,T4,TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..Work(System.Func.T1.T2.T3.T4.TResult..bool.uint).work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Work.T1.T2.T3.T4.TResult..md#KeepCoding.Work.T1.T2.T3.T4.TResult..T1 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Work.T1.T2.T3.T4.TResult..md#KeepCoding.Work.T1.T2.T3.T4.TResult..T2 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Work.T1.T2.T3.T4.TResult..md#KeepCoding.Work.T1.T2.T3.T4.TResult..T3 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Work.T1.T2.T3.T4.TResult..md#KeepCoding.Work.T1.T2.T3.T4.TResult..T4 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](Work.T1.T2.T3.T4.TResult..md#KeepCoding.Work.T1.T2.T3.T4.TResult..TResult 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The method to call when thread starts.
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..Work(System.Func.T1.T2.T3.T4.TResult..bool.uint).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding.Work.T1.T2.T3.T4.TResult..Work(System.Func.T1.T2.T3.T4.TResult..bool.uint).maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
