#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## IAwake Interface
[Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called when the script instance is being loaded.  
            
```csharp
public interface IAwake
```

Derived  
&#8627; [AudioScript](AudioScript.md 'KeepCoding.AudioScript')  
&#8627; [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')  
### Remarks
[Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is used to initialize any variables or game state before the game starts. [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called only once during the lifetime of the script instance. [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called after all objects are initialized so you can safely speak to other objects or query them using for example [UnityEngine.GameObject.FindWithTag(System.String)](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject.FindWithTag#UnityEngine_GameObject_FindWithTag_System_String_ 'UnityEngine.GameObject.FindWithTag(System.String)'). Each GameObject's [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called in a random order between objects. Because of this, you should use [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') to set up references between scripts, and use [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') to pass any information back and forth. [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is always called before any [Start()](IStart.Start().md 'KeepCoding.IStart.Start()') functions. This allows you to order initialization of scripts. [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') can not act as a coroutine. Note: Use [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') instead of the constructor for initialization, as the serialized state of the [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') is undefined at construction time. [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called once, just like the constructor.  
            

| Methods | |
| :--- | :--- |
| [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') | [Awake()](IAwake.Awake().md 'KeepCoding.IAwake.Awake()') is called when the script instance is being loaded.<br/>             |
#### See Also
- [https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Awake.html](https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Awake.html 'https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Awake.html')
