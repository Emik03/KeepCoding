### [KeepCoding](KeepCoding.md 'KeepCoding')
## TPScript&lt;TModule&gt; Class
Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.  
```csharp
public abstract class TPScript<TModule> : KeepCoding.CacheableBehaviour,
KeepCoding.ITP
    where TModule : KeepCoding.ModuleScript
```
#### Type parameters
<a name='KeepCoding_TPScript_TModule__TModule'></a>
`TModule`  
  

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') &#129106; TPScript&lt;TModule&gt;  

Implements [ITP](KeepCoding_ITP.md 'KeepCoding.ITP')  

| Fields | |
| :--- | :--- |
| [AutoSolve](KeepCoding_TPScript_TModule__AutoSolve.md 'KeepCoding.TPScript&lt;TModule&gt;.AutoSolve') |  |
| [CancelDetonate](KeepCoding_TPScript_TModule__CancelDetonate.md 'KeepCoding.TPScript&lt;TModule&gt;.CancelDetonate') |  |
| [Cancelled](KeepCoding_TPScript_TModule__Cancelled.md 'KeepCoding.TPScript&lt;TModule&gt;.Cancelled') |  |
| [EndMultipleStrikes](KeepCoding_TPScript_TModule__EndMultipleStrikes.md 'KeepCoding.TPScript&lt;TModule&gt;.EndMultipleStrikes') |  |
| [EndWaitingMusic](KeepCoding_TPScript_TModule__EndWaitingMusic.md 'KeepCoding.TPScript&lt;TModule&gt;.EndWaitingMusic') |  |
| [HideCamera](KeepCoding_TPScript_TModule__HideCamera.md 'KeepCoding.TPScript&lt;TModule&gt;.HideCamera') |  |
| [MultipleStrikes](KeepCoding_TPScript_TModule__MultipleStrikes.md 'KeepCoding.TPScript&lt;TModule&gt;.MultipleStrikes') |  |
| [Solve](KeepCoding_TPScript_TModule__Solve.md 'KeepCoding.TPScript&lt;TModule&gt;.Solve') |  |
| [Strike](KeepCoding_TPScript_TModule__Strike.md 'KeepCoding.TPScript&lt;TModule&gt;.Strike') |  |
| [ToggleWaitingMusic](KeepCoding_TPScript_TModule__ToggleWaitingMusic.md 'KeepCoding.TPScript&lt;TModule&gt;.ToggleWaitingMusic') |  |
| [TryCancelSequence](KeepCoding_TPScript_TModule__TryCancelSequence.md 'KeepCoding.TPScript&lt;TModule&gt;.TryCancelSequence') |  |
| [UnsubmittablePenalty](KeepCoding_TPScript_TModule__UnsubmittablePenalty.md 'KeepCoding.TPScript&lt;TModule&gt;.UnsubmittablePenalty') |  |
| [WaitingMusic](KeepCoding_TPScript_TModule__WaitingMusic.md 'KeepCoding.TPScript&lt;TModule&gt;.WaitingMusic') |  |

| Properties | |
| :--- | :--- |
| [Abandons](KeepCoding_TPScript_TModule__Abandons.md 'KeepCoding.TPScript&lt;TModule&gt;.Abandons') |  |
| [Help](KeepCoding_TPScript_TModule__Help.md 'KeepCoding.TPScript&lt;TModule&gt;.Help') |  |
| [IsCancelCommand](KeepCoding_TPScript_TModule__IsCancelCommand.md 'KeepCoding.TPScript&lt;TModule&gt;.IsCancelCommand') |  |
| [IsTime](KeepCoding_TPScript_TModule__IsTime.md 'KeepCoding.TPScript&lt;TModule&gt;.IsTime') |  |
| [IsTimeSkippable](KeepCoding_TPScript_TModule__IsTimeSkippable.md 'KeepCoding.TPScript&lt;TModule&gt;.IsTimeSkippable') |  |
| [IsTP](KeepCoding_TPScript_TModule__IsTP.md 'KeepCoding.TPScript&lt;TModule&gt;.IsTP') |  |
| [IsZen](KeepCoding_TPScript_TModule__IsZen.md 'KeepCoding.TPScript&lt;TModule&gt;.IsZen') |  |
| [Manual](KeepCoding_TPScript_TModule__Manual.md 'KeepCoding.TPScript&lt;TModule&gt;.Manual') |  |
| [Module](KeepCoding_TPScript_TModule__Module.md 'KeepCoding.TPScript&lt;TModule&gt;.Module') |  |

| Methods | |
| :--- | :--- |
| [AwardPoints(int)](KeepCoding_TPScript_TModule__AwardPoints(int).md 'KeepCoding.TPScript&lt;TModule&gt;.AwardPoints(int)') | Yield return this to award the user that sent the command points directly, this is currently used for mods like Souvenir to give points to users that answered the questions equally.<br/> |
| [AwardPointsOnSolve(int)](KeepCoding_TPScript_TModule__AwardPointsOnSolve(int).md 'KeepCoding.TPScript&lt;TModule&gt;.AwardPointsOnSolve(int)') | Yield return this to award the last user that sent the command points when the module is solved. The module must prevent any user from sending commands afterward in order for Twitch Plays to award points to the correct user. This is currently used by the Twin module when extra points must be given but the module is not solved immediately.<br/> |
| [Detonate(Nullable&lt;float&gt;, string)](KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string).md 'KeepCoding.TPScript&lt;TModule&gt;.Detonate(System.Nullable&lt;float&gt;, string)') | Yield return this to explode the bomb instantly. [time](KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string).md#KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_time 'KeepCoding.TPScript&lt;TModule&gt;.Detonate(System.Nullable&lt;float&gt;, string).time') is specified in number of seconds before the bomb explodes. (Note, sending another detonate command will auto-cancel the previous one on the same module if it hasn't happened already.). [message](KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string).md#KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_message 'KeepCoding.TPScript&lt;TModule&gt;.Detonate(System.Nullable&lt;float&gt;, string).message') is the message to send to chat upon detonation. Both of the parameters are optional.<br/> |
| [Evaluate&lt;T&gt;(bool, T, object)](KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object).md 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object)') | Works as a ternary operator. Returns [then](KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object).md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_then 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).then') if [condition](KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object).md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_condition 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).condition') is true, otherwise [otherwise](KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object).md#KeepCoding_TPScript_TModule__Evaluate_T_(bool_T_object)_otherwise 'KeepCoding.TPScript&lt;TModule&gt;.Evaluate&lt;T&gt;(bool, T, object).otherwise').<br/> |
| [ForceSolve()](KeepCoding_TPScript_TModule__ForceSolve().md 'KeepCoding.TPScript&lt;TModule&gt;.ForceSolve()') | When the module runs into an exception or the module is forced to be solved, it calls this method.<br/> |
| [IsMatch(string, string, bool, RegexOptions)](KeepCoding_TPScript_TModule__IsMatch(string_string_bool_System_Text_RegularExpressions_RegexOptions).md 'KeepCoding.TPScript&lt;TModule&gt;.IsMatch(string, string, bool, System.Text.RegularExpressions.RegexOptions)') | Determines whether the input string matches the regex of the pattern.<br/> |
| [OnInteractSequence(KMSelectable[], float, int[])](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[])') | Presses a sequence of buttons according to [indices](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_indices 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).indices') within [selectables](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_selectables 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).selectables'), waiting [wait](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_wait 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).wait') seconds in-between each, and interrupting as soon as [HasStruck](KeepCoding_ModuleScript_HasStruck.md 'KeepCoding.ModuleScript.HasStruck') is true.<br/> |
| [Process(string)](KeepCoding_TPScript_TModule__Process(string).md 'KeepCoding.TPScript&lt;TModule&gt;.Process(string)') | When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.<br/> |
| [SendDelayedMessage(float, string)](KeepCoding_TPScript_TModule__SendDelayedMessage(float_string).md 'KeepCoding.TPScript&lt;TModule&gt;.SendDelayedMessage(float, string)') | Yield return this to send a message to chat after [time](KeepCoding_TPScript_TModule__SendDelayedMessage(float_string).md#KeepCoding_TPScript_TModule__SendDelayedMessage(float_string)_time 'KeepCoding.TPScript&lt;TModule&gt;.SendDelayedMessage(float, string).time') seconds.<br/> |
| [SendToChat(string)](KeepCoding_TPScript_TModule__SendToChat(string).md 'KeepCoding.TPScript&lt;TModule&gt;.SendToChat(string)') | Yield return this to send a chat directly to twitch chat.<br/> |
| [SendToChatError(string)](KeepCoding_TPScript_TModule__SendToChatError(string).md 'KeepCoding.TPScript&lt;TModule&gt;.SendToChatError(string)') | Yield return this to send a message to the chat about why a users' command was invalid.<br/> |
| [SkipTime(string)](KeepCoding_TPScript_TModule__SkipTime(string).md 'KeepCoding.TPScript&lt;TModule&gt;.SkipTime(string)') | Yield return this to try advancing the clock to the specified time. You must put the full time you wish to skip to, and this time either needs to be less than the current time, if in normal/time mode, or greater than the current time, if in zen mode. Example, if you wanted to set the clock to 5:24, then you do "skiptime 324" or "skiptime 5:24". You can target partway through the seconds, such as "skiptime 45.28", which would then set the clock to 45.28, provided that time has NOT gone by already. You must also set [IsTimeSkippable](KeepCoding_TPScript_TModule__IsTimeSkippable.md 'KeepCoding.TPScript&lt;TModule&gt;.IsTimeSkippable') to true, for this function to work.<br/> |
| [StrikeMessage(string)](KeepCoding_TPScript_TModule__StrikeMessage(string).md 'KeepCoding.TPScript&lt;TModule&gt;.StrikeMessage(string)') | Yield return this to allow you to tell the user why they got a strike if it isn't clear.<br/> |
| [TryCancel(string)](KeepCoding_TPScript_TModule__TryCancel(string).md 'KeepCoding.TPScript&lt;TModule&gt;.TryCancel(string)') | Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield. Just know that you won't be able to clean up if you do your cancel this way, and there is a pending !cancel or !stop.<br/> |
| [TryWaitCancel(float, string)](KeepCoding_TPScript_TModule__TryWaitCancel(float_string).md 'KeepCoding.TPScript&lt;TModule&gt;.TryWaitCancel(float, string)') | Yield return this to cause Twitch Plays to wait for the given time, and any time during the entire duration, the command may cancel. Like "trycancel", you won't be able to clean up if you cancel this way. Also like "trycancel", [message](KeepCoding_TPScript_TModule__TryWaitCancel(float_string).md#KeepCoding_TPScript_TModule__TryWaitCancel(float_string)_message 'KeepCoding.TPScript&lt;TModule&gt;.TryWaitCancel(float, string).message') is optional.<br/> |
| [YieldUntil&lt;T&gt;(T, Func&lt;bool&gt;)](KeepCoding_TPScript_TModule__YieldUntil_T_(T_System_Func_bool_).md 'KeepCoding.TPScript&lt;TModule&gt;.YieldUntil&lt;T&gt;(T, System.Func&lt;bool&gt;)') | You can yield return this to repeatedly yield return an item until a condition is met.<br/> |
| [YieldWhile&lt;T&gt;(T, Func&lt;bool&gt;)](KeepCoding_TPScript_TModule__YieldWhile_T_(T_System_Func_bool_).md 'KeepCoding.TPScript&lt;TModule&gt;.YieldWhile&lt;T&gt;(T, System.Func&lt;bool&gt;)') | You can yield return this to repeatedly yield return an item until a condition is no longer met.<br/> |
