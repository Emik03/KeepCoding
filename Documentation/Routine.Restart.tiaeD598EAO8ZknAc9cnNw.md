#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine](Routine.md 'KeepCoding.Routine')
## Routine.Restart(bool) Method
Stops and restarts the first coroutine that was run.  
```csharp
public void Restart(bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.Restart(bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
#### Exceptions
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
