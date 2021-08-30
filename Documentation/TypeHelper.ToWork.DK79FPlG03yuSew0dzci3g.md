#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, Func&lt;T1,T2,T3,T4,TResult&gt;, bool) Method
Converts argument to a new [Work&lt;T1,T2,T3,T4,TResult&gt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')
```csharp
public static KeepCoding.Work<T1,T2,T3,T4,TResult> ToWork<T1,T2,T3,T4,TResult>(this int maximumThreadsActive, System.Func<T1,T2,T3,T4,TResult> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T1'></a>
`T1`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T2'></a>
`T2`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T3'></a>
`T3`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T4'></a>
`T4`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).maximumThreadsActive'></a>
`maximumThreadsActive` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T4 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The action to run when the thread is active.
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')[T1](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T1')[,](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')[T2](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T2')[,](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')[T3](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T3 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T3')[,](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')[T4](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).T4 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).T4')[,](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')[TResult](TypeHelper.ToWork.DK79FPlG03yuSew0dzci3g.md#KeepCoding.TypeHelper.ToWork.T1.T2.T3.T4.TResult.(int.System.Func.T1.T2.T3.T4.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,T3,T4,TResult&gt;(int, System.Func&lt;T1,T2,T3,T4,TResult&gt;, bool).TResult')[&gt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;')  
A new [Work&lt;T1,T2,T3,T4,TResult&gt;](Work.T1.T2.T3.T4.TResult..md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;') consisting of the arguments provided.
