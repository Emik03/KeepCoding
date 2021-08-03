#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Routine&lt;T&gt;](Routine.T..md 'KeepCoding.Routine&lt;T&gt;')
## Routine&lt;T&gt;.Start(T, bool, bool) Method
Starts the coroutine. Unless specified by [allowMultiple](Routine.T..Start.5YTEEAMvgsalavt.xnhsvQ.md#KeepCoding.Routine.T..Start(T.bool.bool).allowMultiple 'KeepCoding.Routine&lt;T&gt;.Start(T, bool, bool).allowMultiple'), it will not be called if this class is in the middle of running the coroutine.  
```csharp
public void Start(T t, bool allowMultiple=true, bool oneByOne=false);
```
#### Parameters
<a name='KeepCoding.Routine.T..Start(T.bool.bool).t'></a>
`t` [T](Routine.T..md#KeepCoding.Routine.T..T 'KeepCoding.Routine&lt;T&gt;.T')  
The first argument to pass into the coroutine.
  
<a name='KeepCoding.Routine.T..Start(T.bool.bool).allowMultiple'></a>
`allowMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should be allowed to create another instance of the coroutine even if it's running another one.
  
<a name='KeepCoding.Routine.T..Start(T.bool.bool).oneByOne'></a>
`oneByOne` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
If called multiple times, waits until the others are finished.
  
