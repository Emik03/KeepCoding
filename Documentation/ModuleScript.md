#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleScript Class
Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes.  
```csharp
public abstract class ModuleScript : KeepCoding.CacheableBehaviour,
KeepCoding.IAwake,
KeepCoding.IDump,
KeepCoding.ILog
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; ModuleScript  

Implements [IAwake](IAwake.md 'KeepCoding.IAwake'), [IDump](IDump.md 'KeepCoding.IDump'), [ILog](ILog.md 'KeepCoding.ILog')  

| Properties | |
| :--- | :--- |
| [Bomb](ModuleScript.Bomb.md 'KeepCoding.ModuleScript.Bomb') | The bomb that this module is in.<br/> |
| [Colorblind](ModuleScript.Colorblind.md 'KeepCoding.ModuleScript.Colorblind') | Contains colorblind information. This property will return [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') in the event that [OnColorblindChanged(bool)](ModuleScript.OnColorblindChanged.v.B8pFA9oBJ43uADUD5ZpQ.md 'KeepCoding.ModuleScript.OnColorblindChanged(bool)') isn't implemented.<br/> |
| [HasStruck](ModuleScript.HasStruck.md 'KeepCoding.ModuleScript.HasStruck') | Determines whether the module has been struck. [OnInteractSequence(KMSelectable[], float, int[])](TPScript.TModule..OnInteractSequence.BDCqLwYKYl5pAjSBekGAmQ.md 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[])') will set this to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') when a command is interrupted.<br/> |
| [Id](ModuleScript.Id.md 'KeepCoding.ModuleScript.Id') | The Unique Id for the module of this type.<br/> |
| [IgnoredModules](ModuleScript.IgnoredModules.md 'KeepCoding.ModuleScript.IgnoredModules') | The ignored modules of this module from the Boss Module Manager.<br/> |
| [IsActive](ModuleScript.IsActive.md 'KeepCoding.ModuleScript.IsActive') | Determines whether the bomb is currently active, and the timer is ticking.<br/> |
| [IsColorblind](ModuleScript.IsColorblind.md 'KeepCoding.ModuleScript.IsColorblind') | Determines whether the module's colorblind mode is enabled.<br/> |
| [IsEditor](ModuleScript.IsEditor.md 'KeepCoding.ModuleScript.IsEditor') | Determines whether the application is running from inside unity.<br/> |
| [IsLastInstantiated](ModuleScript.IsLastInstantiated.md 'KeepCoding.ModuleScript.IsLastInstantiated') | Determines whether this module is the last instantiated instance.<br/> |
| [IsNeedyActive](ModuleScript.IsNeedyActive.md 'KeepCoding.ModuleScript.IsNeedyActive') | Determines whether the needy is active.<br/> |
| [IsSolved](ModuleScript.IsSolved.md 'KeepCoding.ModuleScript.IsSolved') | Determines whether the module has been solved.<br/> |
| [IsVR](ModuleScript.IsVR.md 'KeepCoding.ModuleScript.IsVR') | Determines whether the game is being played with motion virtual reality. In the Editor, it always returns false.<br/> |
| [LastId](ModuleScript.LastId.md 'KeepCoding.ModuleScript.LastId') | The last Id instantiation for the module of this type.<br/> |
| [Module](ModuleScript.Module.md 'KeepCoding.ModuleScript.Module') | Contains either [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') or [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule'), and allows for running commands through context.<br/> |
| [Modules](ModuleScript.Modules.md 'KeepCoding.ModuleScript.Modules') | Contains every modded module in [Bomb](ModuleScript.Bomb.md 'KeepCoding.ModuleScript.Bomb'), separated by type.<br/> |
| [RuleSeed](ModuleScript.RuleSeed.md 'KeepCoding.ModuleScript.RuleSeed') | The pseudo-random number generator whose number generations are based on the current Rule Seed.<br/> |
| [RuleSeedId](ModuleScript.RuleSeedId.md 'KeepCoding.ModuleScript.RuleSeedId') | Gets the rule seed number.<br/> |
| [Sounds](ModuleScript.Sounds.md 'KeepCoding.ModuleScript.Sounds') | Contains an instance for every [Sound](Sound.md 'KeepCoding.Sound') played by this module using [PlaySound(Transform, bool, Sound[])](ModuleScript.PlaySound.Eo7fMZRxz07dxI+QmUMs9w.md 'KeepCoding.ModuleScript.PlaySound(Transform, bool, KeepCoding.Sound[])') or any of its overloads.<br/> |
| [TimeLeft](ModuleScript.TimeLeft.md 'KeepCoding.ModuleScript.TimeLeft') | The amount of time left on the bomb, in seconds, rounded down.<br/> |
| [TP](ModuleScript.TP.md 'KeepCoding.ModuleScript.TP') | Gets the Twitch Plays [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') attached to this [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject').<br/> |
| [Version](ModuleScript.Version.md 'KeepCoding.ModuleScript.Version') | The version number of the entire mod.<br/> |

| Methods | |
| :--- | :--- |
| [Append(Action, Action, Action, Action, Action, Action, Action&lt;float&gt;, Func&lt;int&gt;, Func&lt;float&gt;)](ModuleScript.Append.3Om3PbSoIeXpwe5wlBFQnw.md 'KeepCoding.ModuleScript.Append(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action&lt;float&gt;, System.Func&lt;int&gt;, System.Func&lt;float&gt;)') | Appends events to this instance's [Module](ModuleScript.Module.md 'KeepCoding.ModuleScript.Module'), preserving their existing values.<br/> |
| [Assign(Action, Action, Action, Action, Action, Action, Action&lt;float&gt;, Func&lt;int&gt;, Func&lt;float&gt;)](ModuleScript.Assign.XGNq9Lb.wz39JCrOWlC3JQ.md 'KeepCoding.ModuleScript.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action&lt;float&gt;, System.Func&lt;int&gt;, System.Func&lt;float&gt;)') | Assigns events to this instance's [Module](ModuleScript.Module.md 'KeepCoding.ModuleScript.Module'), replacing their existing values.<br/> |
| [Awake()](ModuleScript.Awake().md 'KeepCoding.ModuleScript.Awake()') | Sets up base functionality for the module. If you declare this method yourself, make sure to call `base.Awake()` to ensure that the module initializes correctly, or use [OnAwake()](ModuleScript.OnAwake().md 'KeepCoding.ModuleScript.OnAwake()') instead.<br/> |
| [ButtonEffect(KMSelectable, float, Sound[])](ModuleScript.ButtonEffect.m6oblontlDXgXnuZyRA2fQ.md 'KeepCoding.ModuleScript.ButtonEffect(KMSelectable, float, KeepCoding.Sound[])') | Handles typical button [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract') behaviour.<br/> |
| [Dump&lt;T&gt;(T, bool)](ModuleScript.Dump.rPFgKMTJ6Yx29zwCI4Mh5Q.md 'KeepCoding.ModuleScript.Dump&lt;T&gt;(T, bool)') | Dumps all information that it can find of the type using reflection. This should only be used to debug.<br/> |
| [Dump(bool, Expression&lt;Func&lt;object&gt;&gt;[])](ModuleScript.Dump.s7HN7dAEk6hZXpJGQ6UR2w.md 'KeepCoding.ModuleScript.Dump(bool, System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [Dump(Expression&lt;Func&lt;object&gt;&gt;[])](ModuleScript.Dump.u7AJX2Z70L44FZHpKBTmxw.md 'KeepCoding.ModuleScript.Dump(System.Linq.Expressions.Expression&lt;System.Func&lt;object&gt;&gt;[])') | Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.<br/> |
| [GetIgnoredModules(string)](ModuleScript.GetIgnoredModules.zUIy+bTAgmYAHrE1BZmr1g.md 'KeepCoding.ModuleScript.GetIgnoredModules(string)') | Retrieves the ignore list from the Boss Module Manager mod used primarily by boss modules.<br/> |
| [Log&lt;T&gt;(T, LogType)](ModuleScript.Log.p+nIKGfe9rpfPEgPOFv8OA.md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](ModuleScript.Log.j.XfWH0BSgC6a6A+Y3WL8g.md 'KeepCoding.ModuleScript.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](ModuleScript.LogMultiple.+yq7ctJoFJgYL.6.OkqGfA.md 'KeepCoding.ModuleScript.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [ModulesOfBomb(KMBomb)](ModuleScript.ModulesOfBomb.3ju6QGb1hN6EmBGsUYZDvg.md 'KeepCoding.ModuleScript.ModulesOfBomb(KMBomb)') | Allows you to get the collection of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') from a [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb').<br/> |
| [OnActivate()](ModuleScript.OnActivate().md 'KeepCoding.ModuleScript.OnActivate()') | Called when the lights turn on.<br/> |
| [OnAwake()](ModuleScript.OnAwake().md 'KeepCoding.ModuleScript.OnAwake()') | Called when the module instantiates, well before the lights turn on.<br/> |
| [OnColorblindChanged(bool)](ModuleScript.OnColorblindChanged.v.B8pFA9oBJ43uADUD5ZpQ.md 'KeepCoding.ModuleScript.OnColorblindChanged(bool)') | Called when colorblind support needs to be updated for the module.<br/> |
| [OnDestroy()](ModuleScript.OnDestroy().md 'KeepCoding.ModuleScript.OnDestroy()') | Removes the module from [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived'). If you declare this method, make sure to call `base.OnDestroy()` to ensure that the module cleans up correctly.<br/> |
| [OnDestruct()](ModuleScript.OnDestruct().md 'KeepCoding.ModuleScript.OnDestruct()') | Called when the module destroys itself, after the bomb unloads.<br/> |
| [OnModuleSolved(ModuleContainer)](ModuleScript.OnModuleSolved.bvIMgOP3LybWE.GORqZALQ.md 'KeepCoding.ModuleScript.OnModuleSolved(KeepCoding.ModuleContainer)') | Called when any [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') or BombComponent on the current bomb has been solved.<br/> |
| [OnModuleStrike(ModuleContainer)](ModuleScript.OnModuleStrike.1NWg1QzzIjdklo5Fdd9fCg.md 'KeepCoding.ModuleScript.OnModuleStrike(KeepCoding.ModuleContainer)') | Called when any module on the current bomb has issued a strike.<br/> |
| [OnNeedyActivate()](ModuleScript.OnNeedyActivate().md 'KeepCoding.ModuleScript.OnNeedyActivate()') | Called when the needy activates.<br/> |
| [OnNeedyDeactivate()](ModuleScript.OnNeedyDeactivate().md 'KeepCoding.ModuleScript.OnNeedyDeactivate()') | Called when the needy deactivates or runs out of time.<br/> |
| [OnTimerTick()](ModuleScript.OnTimerTick().md 'KeepCoding.ModuleScript.OnTimerTick()') | Called when the timer's seconds-digit changes.<br/> |
| [PlaySound(bool, Sound[])](ModuleScript.PlaySound.T5G7nbY4x1hKLD9ZB1hwFg.md 'KeepCoding.ModuleScript.PlaySound(bool, KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Sound[])](ModuleScript.PlaySound.rd+g+nK.gRmxxJyPxkHmaw.md 'KeepCoding.ModuleScript.PlaySound(KeepCoding.Sound[])') | Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, bool, Sound[])](ModuleScript.PlaySound.Eo7fMZRxz07dxI+QmUMs9w.md 'KeepCoding.ModuleScript.PlaySound(Transform, bool, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [PlaySound(Transform, Sound[])](ModuleScript.PlaySound.Idi.GqAU2I99mGiMT8jLAA.md 'KeepCoding.ModuleScript.PlaySound(Transform, KeepCoding.Sound[])') | Plays a sound. Requires [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to be assigned.<br/> |
| [Read&lt;T&gt;(string, string, bool)](ModuleScript.Read.gpV96rvnXGomhesS.iqiBg.md 'KeepCoding.ModuleScript.Read&lt;T&gt;(string, string, bool)') | Allows you to read a module's data that uses [Write&lt;T&gt;(string, T)](ModuleScript.Write.MUlE8lXsuyARXkdh4ORgbw.md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)'), even from a different assembly.<br/> |
| [Solve(string[])](ModuleScript.Solve.WjRcsScSXE.zSXwp7LIugg.md 'KeepCoding.ModuleScript.Solve(string[])') | Solves the module, and logs all of the parameters.<br/> |
| [Strike(string[])](ModuleScript.Strike.OGXTq67vxX8ph6+FzIPHtA.md 'KeepCoding.ModuleScript.Strike(string[])') | Strikes the module, and logs all of the parameters.<br/> |
| [Write&lt;T&gt;(string, T)](ModuleScript.Write.MUlE8lXsuyARXkdh4ORgbw.md 'KeepCoding.ModuleScript.Write&lt;T&gt;(string, T)') | Sends information to a static variable such that other modules can access it.<br/> |
