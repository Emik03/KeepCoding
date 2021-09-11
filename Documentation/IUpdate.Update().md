#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[IUpdate](IUpdate.md 'KeepCoding.IUpdate')
## IUpdate.Update() Method
[Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()') is called every frame, if the [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') is enabled.  
            
```csharp
void Update();
```
### Remarks
[Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()') is the most commonly used function to implement any kind of game script. Not every [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') script needs [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()'). In order to get the elapsed time since last call to [Update()](IUpdate.Update().md 'KeepCoding.IUpdate.Update()'), use [UnityEngine.Time.deltaTime](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Time.deltaTime 'UnityEngine.Time.deltaTime'). This function is only called if the [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') is enabled. Override this function in order to provide your [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')'s functionality.  
            
#### See Also
- [https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html 'https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html')
