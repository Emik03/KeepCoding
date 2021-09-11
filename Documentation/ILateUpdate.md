#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ILateUpdate Interface
[LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()') is called every frame, if the [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') is enabled.  
            
```csharp
public interface ILateUpdate
```
### Remarks
[LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()') is called after all [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()') functions have been called. This is useful to order script execution. For example a follow [UnityEngine.Camera](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Camera 'UnityEngine.Camera') should always be implemented in [LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()') because it tracks objects that might have moved inside [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()'). In order to get the elapsed time since last call to [LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()'), use [UnityEngine.Time.deltaTime](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Time.deltaTime 'UnityEngine.Time.deltaTime'). This function is only called if the [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') is enabled. Override this function in order to provide your [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')'s functionality.  
            

| Methods | |
| :--- | :--- |
| [LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()') | [LateUpdate()](ILateUpdate.LateUpdate().md 'KeepCoding.ILateUpdate.LateUpdate()') is called every frame, if the [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') is enabled.<br/>             |
#### See Also
- [https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.LateUpdate.html](https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.LateUpdate.html 'https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.LateUpdate.html')
