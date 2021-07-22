#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2,T3&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;')
## Routine&lt;T1,T2,T3&gt;.RestartAll(T1, T2, T3, bool) Method
Restarts all coroutines currently running.  
```csharp
public void RestartAll(T1 t1, T2 t2, T3 t3, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2_T3__RestartAll(T1_T2_T3_bool)_t1'></a>
`t1` [T1](KeepCoding_Routine_T1_T2_T3_.md#KeepCoding_Routine_T1_T2_T3__T1 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3__RestartAll(T1_T2_T3_bool)_t2'></a>
`t2` [T2](KeepCoding_Routine_T1_T2_T3_.md#KeepCoding_Routine_T1_T2_T3__T2 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3__RestartAll(T1_T2_T3_bool)_t3'></a>
`t3` [T3](KeepCoding_Routine_T1_T2_T3_.md#KeepCoding_Routine_T1_T2_T3__T3 'KeepCoding.Routine&lt;T1,T2,T3&gt;.T3')  
The third argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2_T3__RestartAll(T1_T2_T3_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
