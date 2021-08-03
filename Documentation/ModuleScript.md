#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleScript Class
Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes.  
```csharp
public abstract class ModuleScript : KeepCoding.CacheableBehaviour,
KeepCoding.IDump,
KeepCoding.ILog
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; ModuleScript  

Implements [IDump](IDump.md 'KeepCoding.IDump'), [ILog](ILog.md 'KeepCoding.ILog')  

| Fields | |
| :--- | :--- |
| [Colorblind](ModuleScript_Colorblind.md 'KeepCoding.ModuleScript.Colorblind') | Contains colorblind information.<br/> |

| Properties | |
| :--- | :--- |
| [Bomb](ModuleScript_Bomb.md 'KeepCoding.ModuleScript.Bomb') | The bomb that this module is in.<br/> |
| [HasStruck](ModuleScript_HasStruck.md 'KeepCoding.ModuleScript.HasStruck') | Determines whether the module has been struck. [OnInteractSequence(KMSelectable[], float, int[])](TPScript_TModule__OnInteractSequence_BDCqLwYKYl5pAjSBekGAmQ.md 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[])') will set this to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') when a command is interrupted.<br/> |
| [Id](ModuleScript_Id.md 'KeepCoding.ModuleScript.Id') | The Unique Id for the module of this type.<br/> |
| [IsActive](ModuleScript_IsActive.md 'KeepCoding.ModuleScript.IsActive') | Determines whether the bomb is currently active, and the timer is ticking.<br/> |
| [IsColorblind](ModuleScript_IsColorblind.md 'KeepCoding.ModuleScript.IsColorblind') | Determines whether the module's colorblind mode is enabled.<br/> |
| [IsEditor](ModuleScript_IsEditor.md 'KeepCoding.ModuleScript.IsEditor') | Determines whether the application is running from inside unity.<br/> |
| [IsLastInstantiated](ModuleScript_IsLastInstantiated.md 'KeepCoding.ModuleScript.IsLastInstantiated') | Determines whether this module is the last instantiated instance.<br/> |
| [IsNeedyActive](ModuleScript_IsNeedyActive.md 'KeepCoding.ModuleScript.IsNeedyActive') | Determines whether the needy is active.<br/> |
| [IsSolved](ModuleScript_IsSolved.md 'KeepCoding.ModuleScript.IsSolved') | Determines whether the module has been solved.<br/> |
| [IsVR](ModuleScript_IsVR.md 'KeepCoding.ModuleScript.IsVR') | Determines whether the game is being played in Virtual Reality. In the Editor, it always returns false.<br/> |
| [LastId](ModuleScript_LastId.md 'KeepCoding.ModuleScript.LastId') | The last Id instantiation for the module of this type.<br/> |
| [Module](ModuleScript_Module.md 'KeepCoding.ModuleScript.Module') | Contains either [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') or [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule'), and allows for running commands through context.<br/> |
| [Modules](ModuleScript_Modules.md 'KeepCoding.ModuleScript.Modules') | Contains every modded module in [Bomb](ModuleScript_Bomb.md 'KeepCoding.ModuleScript.Bomb'), separated by type.<br/> |
| [Sounds](ModuleScript_Sounds.md 'KeepCoding.ModuleScript.Sounds') | Contains an instance for every [Sound](Sound.md 'KeepCoding.Sound') played by this module using [PlaySound(Transform, bool, Sound[])](ModuleScript_PlaySound_Eo7fMZRxz07dxI+QmUMs9w.md 'KeepCoding.ModuleScript.PlaySound(Transform, bool, KeepCoding.Sound[])') or any of its overloads.<br/> |
| [TimeLeft](ModuleScript_TimeLeft.md 'KeepCoding.ModuleScript.TimeLeft') | The amount of time left on the bomb, in seconds, rounded down.<br/> |
| [TP](ModuleScript_TP.md 'KeepCoding.ModuleScript.TP') | Gets the Twitch Plays [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') attached to this [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject').<br/> |
| [Version](ModuleScript_Version.md 'KeepCoding.ModuleScript.Version') | The version number of the entire mod.<br/> |

| Methods | |
| :--- | :--- |
| [Assign(Action, Action, Action, Action, Action, Action)](ModuleScript_Assign_eITDwtAT1SCchKiHMuO9Vg.md 'KeepCoding.ModuleScript.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Assigns events specified into [Module](ModuleScript_Module.md 'KeepCoding.ModuleScript.Module'). Reassigning them will replace their values.<br/> |
| [Awake()](ModuleScript_Awake().md 'KeepCoding.ModuleScript.Awake()') | Sets up base functionality for the module. If you declare this method yourself, make sure to call `base.Awake()` to ensure that the module initializes correctly, or use [OnAwake()](ModuleScript_OnAwake().md 'KeepCoding.ModuleScript.OnAwake()') instead.<br/> |
| [ButtonEffect(KMSelectable, float, Sound[])](ModuleScript_ButtonEffect_m6oblontlDXgXnuZyRA2fQ.md 'KeepCoding.ModuleScript.ButtonEffect(KMSelectable, float, KeepCoding.Sound[])') | Handles typical button [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract') behaviour.<br/> |
| [Dump&lt;T&gt;(T, bool)](ModuleScript_Dump_rPFgKMTJ6Yx29zwCI4Mh5Q.md 'KeepCoding.ModuleScript.Dump&lt;T&gt;(T, bool)') | Dumps all information that it can find of the type using reflection. This should only be used to debug.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](ModuleScript_Dump_s7HN7dAEk6hZXpJGQ6UR2w.md 'KeepCoding.ModuleScript.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](ModuleScript_Dump_u7AJX2Z70L44FZHpKBTmxw.md 'KeepCoding.ModuleScript.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Log&lt;T&gt;(T, LogType)](ModuleScript_Log_p+nIKGfe9rpfPEgPOFv8OA.md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ModuleScript_Log_j_XfWH0BSgC6a6A+Y3WL8g.md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ModuleScript_LogMultiple_+yq7ctJoFJgYL_6_OkqGfA.md 'KeepCoding.ModuleScript.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [OnActivate()](ModuleScript_OnActivate().md 'KeepCoding.ModuleScript.OnActivate()') | Called when the lights turn on.<br/> |
| [OnAwake()](ModuleScript_OnAwake().md 'KeepCoding.ModuleScript.OnAwake()') | Called when the module instantiates, well before the lights turn on.<br/> |
| [OnColorblindChanged(bool)](ModuleScript_OnColorblindChanged_v_B8pFA9oBJ43uADUD5ZpQ.md 'KeepCoding.ModuleScript.OnColorblindChanged(bool)') | Called when colorblind support needs to be updated for the module.<br/> |
| [OnDestroy()](ModuleScript_OnDestroy().md 'KeepCoding.ModuleScript.OnDestroy()') | Removes the module from [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived'). If you declare this method, make sure to call `base.OnDestroy()` to ensure that the module cleans up correctly.<br/> |
| [OnDestruct()](ModuleScript_OnDestruct().md 'KeepCoding.ModuleScript.OnDestruct()') | Called when the module destroys itself, after the bomb unloads.<br/> |
| [OnModuleStrike(string)](ModuleScript_OnModuleStrike_MUPuIM99ct4yNa4EgzAU0A.md 'KeepCoding.ModuleScript.OnModuleStrike(string)') | Called when any module on the current bomb has issued a strike.<br/> |
| [OnNeedySolved(string)](ModuleScript_OnNeedySolved_Qhy3nCuSXavj4NqCT0E0bA.md 'KeepCoding.ModuleScript.OnNeedySolved(string)') | Called when any [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') on the current bomb has been solved.<br/> |
| [OnSolvableSolved(string)](ModuleScript_OnSolvableSolved_MDFRwwyawutqM6KSZwb63w.md 'KeepCoding.ModuleScript.OnSolvableSolved(string)') | Called when any [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') on the current bomb has been solved.<br/> |
| [OnTimerTick()](ModuleScript_OnTimerTick().md 'KeepCoding.ModuleScript.OnTimerTick()') | Called when the timer's seconds-digit changes.<br/> |
| [PlaySound(bool, Sound[])](ModuleScript_PlaySound_T5G7nbY4x1hKLD9ZB1hwFg.md 'KeepCoding.ModuleScript.PlaySound(bool, KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Sound[])](ModuleScript_PlaySound_rd+g+nK_gRmxxJyPxkHmaw.md 'KeepCoding.ModuleScript.PlaySound(KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, bool, Sound[])](ModuleScript_PlaySound_Eo7fMZRxz07dxI+QmUMs9w.md 'KeepCoding.ModuleScript.PlaySound(Transform, bool, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, Sound[])](ModuleScript_PlaySound_Idi_GqAU2I99mGiMT8jLAA.md 'KeepCoding.ModuleScript.PlaySound(Transform, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [Read&lt;T&gt;(string, string, bool)](ModuleScript_Read_gpV96rvnXGomhesS_iqiBg.md 'KeepCoding.ModuleScript.Read&lt;T&gt;(string, string, bool)') | Allows you to read a module's data that uses [Write&lt;T&gt;(string, T)](ModuleScript_Write_MUlE8lXsuyARXkdh4ORgbw.md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)'), even from a different assembly.<br/> |
| [Solve(string[])](ModuleScript_Solve_WjRcsScSXE_zSXwp7LIugg.md 'KeepCoding.ModuleScript.Solve(string[])') | Solves the module, and logs all of the parameters.<br/> |
| [Strike(string[])](ModuleScript_Strike_OGXTq67vxX8ph6+FzIPHtA.md 'KeepCoding.ModuleScript.Strike(string[])') | Strikes the module, and logs all of the parameters.<br/> |
| [Write&lt;T&gt;(string, T)](ModuleScript_Write_MUlE8lXsuyARXkdh4ORgbw.md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)') | Sends information to a static variable such that other modules can access it.<br/> |