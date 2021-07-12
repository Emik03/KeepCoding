### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;')
## Routine&lt;T&gt;.StartOrRestart(T, bool, bool) Method
Starts a coroutine if no coroutines are running, otherwise restarts.  
```csharp
public void StartOrRestart(T t, bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T__StartOrRestart(T_bool_bool)_t'></a>
`t` [T](KeepCoding_Routine_T_.md#KeepCoding_Routine_T__T 'KeepCoding.Routine&lt;T&gt;.T')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T__StartOrRestart(T_bool_bool)_allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding_Routine_T__StartOrRestart(T_bool_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
