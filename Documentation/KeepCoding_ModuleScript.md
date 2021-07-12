### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleScript Class
Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes.   
```csharp
public abstract class ModuleScript : KeepCoding.CacheableBehaviour,
KeepCoding.IDump,
KeepCoding.ILog
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; ModuleScript  

Implements [IDump](KeepCoding_IDump.md 'KeepCoding.IDump'), [ILog](KeepCoding_ILog.md 'KeepCoding.ILog')  

| Properties | |
| :--- | :--- |
| [Bomb](KeepCoding_ModuleScript_Bomb.md 'KeepCoding.ModuleScript.Bomb') |  |
| [HasStruck](KeepCoding_ModuleScript_HasStruck.md 'KeepCoding.ModuleScript.HasStruck') |  |
| [Id](KeepCoding_ModuleScript_Id.md 'KeepCoding.ModuleScript.Id') |  |
| [IsActive](KeepCoding_ModuleScript_IsActive.md 'KeepCoding.ModuleScript.IsActive') |  |
| [IsEditor](KeepCoding_ModuleScript_IsEditor.md 'KeepCoding.ModuleScript.IsEditor') |  |
| [IsLastInstantiated](KeepCoding_ModuleScript_IsLastInstantiated.md 'KeepCoding.ModuleScript.IsLastInstantiated') |  |
| [IsNeedyActive](KeepCoding_ModuleScript_IsNeedyActive.md 'KeepCoding.ModuleScript.IsNeedyActive') |  |
| [IsSolved](KeepCoding_ModuleScript_IsSolved.md 'KeepCoding.ModuleScript.IsSolved') |  |
| [IsVR](KeepCoding_ModuleScript_IsVR.md 'KeepCoding.ModuleScript.IsVR') |  |
| [LastId](KeepCoding_ModuleScript_LastId.md 'KeepCoding.ModuleScript.LastId') | The last Id instantiation for the module of this type.<br/> |
| [Module](KeepCoding_ModuleScript_Module.md 'KeepCoding.ModuleScript.Module') |  |
| [Modules](KeepCoding_ModuleScript_Modules.md 'KeepCoding.ModuleScript.Modules') | Contains every modded module in [Bomb](KeepCoding_ModuleScript_Bomb.md 'KeepCoding.ModuleScript.Bomb'), separated by type.<br/> |
| [Sounds](KeepCoding_ModuleScript_Sounds.md 'KeepCoding.ModuleScript.Sounds') |  |
| [TimeLeft](KeepCoding_ModuleScript_TimeLeft.md 'KeepCoding.ModuleScript.TimeLeft') |  |
| [TP](KeepCoding_ModuleScript_TP.md 'KeepCoding.ModuleScript.TP') |  |
| [Version](KeepCoding_ModuleScript_Version.md 'KeepCoding.ModuleScript.Version') |  |

| Methods | |
| :--- | :--- |
| [Assign(Action, Action, Action, Action, Action, Action)](KeepCoding_ModuleScript_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action).md 'KeepCoding.ModuleScript.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Assigns events specified into [Module](KeepCoding_ModuleScript_Module.md 'KeepCoding.ModuleScript.Module'). Reassigning them will replace their values.<br/> |
| [Awake()](KeepCoding_ModuleScript_Awake().md 'KeepCoding.ModuleScript.Awake()') | This initalizes the module. If you have an Awake method, be sure to call `base.Awake()` as the first statement.<br/> |
| [ButtonEffect(KMSelectable, float, Sound[])](KeepCoding_ModuleScript_ButtonEffect(KMSelectable_float_KeepCoding_Sound__).md 'KeepCoding.ModuleScript.ButtonEffect(KMSelectable, float, KeepCoding.Sound[])') | Handles typical button [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract') behaviour.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_ModuleScript_Dump(bool_System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.ModuleScript.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](KeepCoding_ModuleScript_Dump(System_Linq_Expressions_Expression_System_Func_object____).md 'KeepCoding.ModuleScript.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Log&lt;T&gt;(T, LogType)](KeepCoding_ModuleScript_Log_T_(T_LogType).md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](KeepCoding_ModuleScript_Log_T_(T_object__).md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](KeepCoding_ModuleScript_LogMultiple(string__).md 'KeepCoding.ModuleScript.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [OnActivate()](KeepCoding_ModuleScript_OnActivate().md 'KeepCoding.ModuleScript.OnActivate()') | Called when the lights turn on.<br/> |
| [OnDestroy()](KeepCoding_ModuleScript_OnDestroy().md 'KeepCoding.ModuleScript.OnDestroy()') | This removed the exception catcher. If you have an OnDestroy method, be sure to call `base.OnDestroy()` as the first statement.<br/> |
| [OnModuleStrike(string)](KeepCoding_ModuleScript_OnModuleStrike(string).md 'KeepCoding.ModuleScript.OnModuleStrike(string)') | Called when any module on the current bomb has issued a strike.<br/> |
| [OnNeedySolved(string)](KeepCoding_ModuleScript_OnNeedySolved(string).md 'KeepCoding.ModuleScript.OnNeedySolved(string)') | Called when any [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') on the current bomb has been solved.<br/> |
| [OnSolvableSolved(string)](KeepCoding_ModuleScript_OnSolvableSolved(string).md 'KeepCoding.ModuleScript.OnSolvableSolved(string)') | Called when any [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') on the current bomb has been solved.<br/> |
| [OnTimerTick()](KeepCoding_ModuleScript_OnTimerTick().md 'KeepCoding.ModuleScript.OnTimerTick()') | Called when the timer's seconds-digit changes.<br/> |
| [PlaySound(bool, Sound[])](KeepCoding_ModuleScript_PlaySound(bool_KeepCoding_Sound__).md 'KeepCoding.ModuleScript.PlaySound(bool, KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Sound[])](KeepCoding_ModuleScript_PlaySound(KeepCoding_Sound__).md 'KeepCoding.ModuleScript.PlaySound(KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, bool, Sound[])](KeepCoding_ModuleScript_PlaySound(Transform_bool_KeepCoding_Sound__).md 'KeepCoding.ModuleScript.PlaySound(Transform, bool, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, Sound[])](KeepCoding_ModuleScript_PlaySound(Transform_KeepCoding_Sound__).md 'KeepCoding.ModuleScript.PlaySound(Transform, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [Read&lt;T&gt;(string, string, bool)](KeepCoding_ModuleScript_Read_T_(string_string_bool).md 'KeepCoding.ModuleScript.Read&lt;T&gt;(string, string, bool)') | Allows you to read a module's data that uses [Write&lt;T&gt;(string, T)](KeepCoding_ModuleScript_Write_T_(string_T).md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)'), even from a different assembly.<br/> |
| [Solve(string[])](KeepCoding_ModuleScript_Solve(string__).md 'KeepCoding.ModuleScript.Solve(string[])') | Solves the module, and logs all of the parameters.<br/> |
| [Strike(string[])](KeepCoding_ModuleScript_Strike(string__).md 'KeepCoding.ModuleScript.Strike(string[])') | Strikes the module, and logs all of the parameters.<br/> |
| [Write&lt;T&gt;(string, T)](KeepCoding_ModuleScript_Write_T_(string_T).md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)') | Sends information to a static variable such that other modules can access it.<br/> |
