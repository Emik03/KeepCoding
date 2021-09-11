#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## IStart Interface
[Start()](IStart.Start().md 'KeepCoding.IStart.Start()') is called on the frame when a script is enabled just before any of the [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()') methods is called the first time.  
            
```csharp
public interface IStart
```

Derived  
&#8627; [ReflectionScript](ReflectionScript.md 'KeepCoding.Internal.ReflectionScript')  
### Remarks
Like the [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') function, [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') is called exactly once in the lifetime of the script. However, [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called when the script object is initialised, regardless of whether or not the script is enabled. [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') may not be called on the same frame as [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') if the script is not enabled at initialisation time. The [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') function is called on all objects in the scene before any object's [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') function is called. This fact is useful in cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be done in [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') while A's should be done in [Start()](IStart.Start().md 'KeepCoding.IStart.Start()'). Where objects are instantiated during gameplay, their [Awake](https://docs.microsoft.com/en-us/dotnet/api/Awake 'Awake') function will naturally be called after the [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') functions of scene objects have already completed.  

| Methods | |
| :--- | :--- |
| [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') | [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') is called on the frame when a script is enabled just before any of the [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()') methods is called the first time.<br/>             |
#### See Also
- [https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html 'https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html')
