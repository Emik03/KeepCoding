#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;')
## Routine&lt;T&gt;.RestartAll(T, bool) Method
Restarts all coroutines currently running.  
```csharp
public void RestartAll(T t, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding_Routine_T__RestartAll(T_bool)_t'></a>
`t` [T](KeepCoding_Routine_T_.md#KeepCoding_Routine_T__T 'KeepCoding.Routine&lt;T&gt;.T')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding_Routine_T__RestartAll(T_bool)_oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](KeepCoding_Internal_EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
