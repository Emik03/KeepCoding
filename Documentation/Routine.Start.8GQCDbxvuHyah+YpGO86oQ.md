#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine](Routine.md 'KeepCoding.Routine')
## Routine.Start(bool, bool) Method
Starts the coroutine. Unless specified by [allowMultiple](Routine.Start.8GQCDbxvuHyah+YpGO86oQ.md#KeepCoding.Routine.Start(bool.bool).allowMultiple 'KeepCoding.Routine.Start(bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.  
```csharp
public void Start(bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.Start(bool.bool).allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding.Routine.Start(bool.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
