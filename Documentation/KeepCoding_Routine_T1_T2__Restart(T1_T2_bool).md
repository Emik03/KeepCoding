#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2&gt;](KeepCoding_Routine_T1_T2_.md 'KeepCoding.Routine&lt;T1,T2&gt;')
## Routine&lt;T1,T2&gt;.Restart(T1, T2, bool) Method
Stops and restarts the first coroutine that was run.  
```csharp
public void Restart(T1 t1, T2 t2, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2__Restart(T1_T2_bool)_t1'></a>
`t1` [T1](KeepCoding_Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T1 'KeepCoding.Routine&lt;T1,T2&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2__Restart(T1_T2_bool)_t2'></a>
`t2` [T2](KeepCoding_Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T2 'KeepCoding.Routine&lt;T1,T2&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2__Restart(T1_T2_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
