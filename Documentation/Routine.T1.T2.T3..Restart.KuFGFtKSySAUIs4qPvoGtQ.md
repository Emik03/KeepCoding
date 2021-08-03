#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3&gt;](Routine.T1.T2.T3..md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')
## Routine&lt;T1,T2,T3&gt;.Restart(T1, T2, T3, bool) Method
Stops and restarts the first coroutine that was run.  
```csharp
public void Restart(T1 t1, T2 t2, T3 t3, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.T1.T2.T3..Restart(T1.T2.T3.bool).t1'></a>
`t1` [T1](Routine.T1.T2.T3..md#KeepCoding.Routine.T1.T2.T3..T1 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3..Restart(T1.T2.T3.bool).t2'></a>
`t2` [T2](Routine.T1.T2.T3..md#KeepCoding.Routine.T1.T2.T3..T2 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3..Restart(T1.T2.T3.bool).t3'></a>
`t3` [T3](Routine.T1.T2.T3..md#KeepCoding.Routine.T1.T2.T3..T3 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T3')  
The third argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T1.T2.T3..Restart(T1.T2.T3.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
