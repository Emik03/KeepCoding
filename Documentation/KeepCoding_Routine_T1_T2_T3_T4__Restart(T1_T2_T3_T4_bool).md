### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3,T4&gt;](KeepCoding_Routine_T1_T2_T3_T4_.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;')
## Routine&lt;T1,T2,T3,T4&gt;.Restart(T1, T2, T3, T4, bool) Method
Stops and restarts the first coroutine that was run.  
```csharp
public void Restart(T1 t1, T2 t2, T3 t3, T4 t4, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2_T3_T4__Restart(T1_T2_T3_T4_bool)_t1'></a>
`t1` [T1](KeepCoding_Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T1 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__Restart(T1_T2_T3_T4_bool)_t2'></a>
`t2` [T2](KeepCoding_Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T2 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__Restart(T1_T2_T3_T4_bool)_t3'></a>
`t3` [T3](KeepCoding_Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T3 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T3')  
The third argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__Restart(T1_T2_T3_T4_bool)_t4'></a>
`t4` [T4](KeepCoding_Routine_T1_T2_T3_T4_.md#KeepCoding_Routine_T1_T2_T3_T4__T4 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;.T4')  
The fourth argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3_T4__Restart(T1_T2_T3_T4_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException')  
