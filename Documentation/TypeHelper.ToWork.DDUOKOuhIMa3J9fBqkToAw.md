#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, Func&lt;T1,T2,TResult&gt;, bool) Method
Converts argument to a new [Work&lt;T1,T2,TResult&gt;](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')
```csharp
public static KeepCoding.Work<T1,T2,TResult> ToWork<T1,T2,TResult>(this uint maximumThreadsActive, System.Func<T1,T2,TResult> func, bool allowSimultaneousActive=false);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T1'></a>
`T1`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T2'></a>
`T2`  
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The action to run when the thread is active.
  
<a name='KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[KeepCoding.Work&lt;](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')[T1](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T1 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).T1')[,](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')[T2](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).T2 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).T2')[,](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')[TResult](TypeHelper.ToWork.DDUOKOuhIMa3J9fBqkToAw.md#KeepCoding.TypeHelper.ToWork.T1.T2.TResult.(uint.System.Func.T1.T2.TResult..bool).TResult 'KeepCoding.TypeHelper.ToWork&lt;T1,T2,TResult&gt;(uint, System.Func&lt;T1,T2,TResult&gt;, bool).TResult')[&gt;](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;')  
A new [Work&lt;T1,T2,TResult&gt;](Work.T1.T2.TResult..md 'KeepCoding.Work&lt;T1,T2,TResult&gt;') consisting of the arguments provided.
