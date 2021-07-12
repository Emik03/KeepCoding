### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T,TResult&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;')
## Work&lt;T,TResult&gt;.Work(Func&lt;T,TResult&gt;, bool, uint) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Func<T,TResult> work, bool allowSimultaneousActive, uint maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding_Work_T_TResult__Work(System_Func_T_TResult__bool_uint)_work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_Work_T_TResult_.md#KeepCoding_Work_T_TResult__T 'KeepCoding.Work&lt;T,TResult&gt;.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_Work_T_TResult_.md#KeepCoding_Work_T_TResult__TResult 'KeepCoding.Work&lt;T,TResult&gt;.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The method to call when thread starts.
  
<a name='KeepCoding_Work_T_TResult__Work(System_Func_T_TResult__bool_uint)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding_Work_T_TResult__Work(System_Func_T_TResult__bool_uint)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
