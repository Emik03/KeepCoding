#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2&gt;](Routine.T1.T2..md 'KeepCoding.Routine&lt;T1,T2&gt;')
## Routine&lt;T1,T2&gt;.StartOrRestart(T1, T2, bool, bool) Method
Starts a coroutine if no coroutines are running, otherwise restarts.  
```csharp
public void StartOrRestart(T1 t1, T2 t2, bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.T1.T2..StartOrRestart(T1.T2.bool.bool).t1'></a>
`t1` [T1](Routine.T1.T2..md#KeepCoding.Routine.T1.T2..T1 'KeepCoding.Routine&lt;T1,T2&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2..StartOrRestart(T1.T2.bool.bool).t2'></a>
`t2` [T2](Routine.T1.T2..md#KeepCoding.Routine.T1.T2..T2 'KeepCoding.Routine&lt;T1,T2&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2..StartOrRestart(T1.T2.bool.bool).allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding.Routine.T1.T2..StartOrRestart(T1.T2.bool.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
