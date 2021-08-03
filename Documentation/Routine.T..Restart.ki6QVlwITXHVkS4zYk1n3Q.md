#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;')
## Routine&lt;T&gt;.Restart(T, bool) Method
Stops and restarts the first coroutine that was run.  
```csharp
public void Restart(T t, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.T..Restart(T.bool).t'></a>
`t` [T](Routine.T..md#KeepCoding.Routine.T..T 'KeepCoding.Routine&lt;T&gt;.T')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T..Restart(T.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
