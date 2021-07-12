### [KeepCoding](KeepCoding.md 'KeepCoding').[Work&lt;T&gt;](KeepCoding_Work_T_.md 'KeepCoding.Work&lt;T&gt;')
## Work&lt;T&gt;.Work(Func&lt;T&gt;, bool, uint) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Func<T> work, bool allowSimultaneousActive, uint maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding_Work_T__Work(System_Func_T__bool_uint)_work'></a>
`work` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeepCoding_Work_T_.md#KeepCoding_Work_T__T 'KeepCoding.Work&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The method to call when thread starts.
  
<a name='KeepCoding_Work_T__Work(System_Func_T__bool_uint)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding_Work_T__Work(System_Func_T__bool_uint)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
