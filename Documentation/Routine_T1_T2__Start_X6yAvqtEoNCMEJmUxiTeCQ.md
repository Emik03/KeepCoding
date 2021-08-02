#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T1,T2&gt;](Routine_T1_T2_.md 'KeepCoding.Routine&lt;T1,T2&gt;')
## Routine&lt;T1,T2&gt;.Start(T1, T2, bool, bool) Method
Starts the coroutine. Unless specified by [allowMultiple](Routine_T1_T2__Start_X6yAvqtEoNCMEJmUxiTeCQ.md#KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_allowMultiple 'KeepCoding.Routine&lt;T1,T2&gt;.Start(T1, T2, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.  
```csharp
public void Start(T1 t1, T2 t2, bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_t1'></a>
`t1` [T1](Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T1 'KeepCoding.Routine&lt;T1,T2&gt;.T1')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_t2'></a>
`t2` [T2](Routine_T1_T2_.md#KeepCoding_Routine_T1_T2__T2 'KeepCoding.Routine&lt;T1,T2&gt;.T2')  
The second argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding_Routine_T1_T2__Start(T1_T2_bool_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
