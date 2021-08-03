#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine](Routine.md 'KeepCoding.Routine')
## Routine.StartOrRestart(bool, bool) Method
Starts a coroutine if no coroutines are running, otherwise restarts.  
```csharp
public void StartOrRestart(bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.StartOrRestart(bool.bool).allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding.Routine.StartOrRestart(bool.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
