#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3,T4&gt;](Routine.T1.T2.T3.T4..md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')
## Routine&lt;T1,T2,T3,T4&gt;.Start(T1, T2, T3, T4, bool, bool) Method
Starts the coroutine. Unless specified by [allowMultiple](Routine.T1.T2.T3.T4..Start.bLZl9t3VFS8o30l4VzrfEg.md#KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).allowMultiple 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.Start(T1, T2, T3, T4, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.  
```csharp
public void Start(T1 t1, T2 t2, T3 t3, T4 t4, bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).t1'></a>
`t1` [T1](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T1 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).t2'></a>
`t2` [T2](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T2 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).t3'></a>
`t3` [T3](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T3 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T3')  
The third argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).t4'></a>
`t4` [T4](Routine.T1.T2.T3.T4..md#KeepCoding.Routine.T1.T2.T3.T4..T4 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T4')  
The fourth argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding.Routine.T1.T2.T3.T4..Start(T1.T2.T3.T4.bool.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
