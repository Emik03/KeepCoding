#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Sound Class
Class meant to encapsulate all types of sound effects [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') uses. Currently used in [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript').  
```csharp
public sealed class Sound :
System.IEquatable<KeepCoding.Sound>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Sound  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Sound](KeepCoding_Sound.md 'KeepCoding.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [Sound(SoundEffect)](KeepCoding_Sound_Sound(global__KMSoundOverride_SoundEffect).md 'KeepCoding.Sound.Sound(global::KMSoundOverride.SoundEffect)') | An instance of sound where [Game](KeepCoding_Sound_Game.md 'KeepCoding.Sound.Game') is defined.<br/> |
| [Sound(string)](KeepCoding_Sound_Sound(string).md 'KeepCoding.Sound.Sound(string)') | An instance of Sound where [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
| [Sound(AudioClip)](KeepCoding_Sound_Sound(UnityEngine_AudioClip).md 'KeepCoding.Sound.Sound(UnityEngine.AudioClip)') | An instance of Sound where [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |

| Properties | |
| :--- | :--- |
| [AlarmClockBeep](KeepCoding_Sound_AlarmClockBeep.md 'KeepCoding.Sound.AlarmClockBeep') | Plays when the alarm clock goes off. This sound loops.<br/> |
| [AlarmClockSnooze](KeepCoding_Sound_AlarmClockSnooze.md 'KeepCoding.Sound.AlarmClockSnooze') | Plays when you hit snooze button on the alarm clock.<br/> |
| [BigButtonPress](KeepCoding_Sound_BigButtonPress.md 'KeepCoding.Sound.BigButtonPress') | Plays when pressing down the button on the Big Button vanilla module.<br/> |
| [BigButtonRelease](KeepCoding_Sound_BigButtonRelease.md 'KeepCoding.Sound.BigButtonRelease') | Plays when releasing the button on the Big Button vanilla module.<br/> |
| [BinderDrop](KeepCoding_Sound_BinderDrop.md 'KeepCoding.Sound.BinderDrop') | Plays as the mission binder hits the desk.<br/> |
| [BombDefused](KeepCoding_Sound_BombDefused.md 'KeepCoding.Sound.BombDefused') | Plays immediately after a bomb is defused. Plays before [KMSoundOverride.SoundEffect.GameOverFanfare](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect.GameOverFanfare 'KMSoundOverride.SoundEffect.GameOverFanfare').<br/> |
| [BombDrop](KeepCoding_Sound_BombDrop.md 'KeepCoding.Sound.BombDrop') | Plays when the bomb is set down on the desk.<br/> |
| [BombExplode](KeepCoding_Sound_BombExplode.md 'KeepCoding.Sound.BombExplode') | Plays when the bomb explodes.<br/> |
| [BriefcaseClose](KeepCoding_Sound_BriefcaseClose.md 'KeepCoding.Sound.BriefcaseClose') | Plays when the freeplay briefcase is closed.<br/> |
| [BriefcaseOpen](KeepCoding_Sound_BriefcaseOpen.md 'KeepCoding.Sound.BriefcaseOpen') | Plays when the freeplay briefcase is opened.<br/> |
| [ButtonPress](KeepCoding_Sound_ButtonPress.md 'KeepCoding.Sound.ButtonPress') | Plays when pressing down a button.<br/> |
| [ButtonRelease](KeepCoding_Sound_ButtonRelease.md 'KeepCoding.Sound.ButtonRelease') | Plays when releasing a button.<br/> |
| [CapacitorPop](KeepCoding_Sound_CapacitorPop.md 'KeepCoding.Sound.CapacitorPop') | Plays when Capacitor Discharge fills up completely.<br/> |
| [CorrectChime](KeepCoding_Sound_CorrectChime.md 'KeepCoding.Sound.CorrectChime') | Plays in the tutorial for completing a step correctly.<br/> |
| [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') | The custom sound, written out by name.<br/> |
| [DossierOptionPressed](KeepCoding_Sound_DossierOptionPressed.md 'KeepCoding.Sound.DossierOptionPressed') | Plays when you change a setting in the menu folder.<br/> |
| [EmergencyAlarm](KeepCoding_Sound_EmergencyAlarm.md 'KeepCoding.Sound.EmergencyAlarm') | Plays when there is less than a minute left on the bomb, this sound loops.<br/> |
| [FastestTimerBeep](KeepCoding_Sound_FastestTimerBeep.md 'KeepCoding.Sound.FastestTimerBeep') | Plays when the bomb has at least 2 or more strikes.<br/> |
| [FastTimerBeep](KeepCoding_Sound_FastTimerBeep.md 'KeepCoding.Sound.FastTimerBeep') | Plays when the bomb has 1 strike.<br/> |
| [FreeplayDeviceDrop](KeepCoding_Sound_FreeplayDeviceDrop.md 'KeepCoding.Sound.FreeplayDeviceDrop') | Plays as the freeplay briefcase hits the desk.<br/> |
| [Game](KeepCoding_Sound_Game.md 'KeepCoding.Sound.Game') | The in-game sound.<br/> |
| [GameOverFanfare](KeepCoding_Sound_GameOverFanfare.md 'KeepCoding.Sound.GameOverFanfare') | Plays when all bombs are defused. Finishes before the post game screen.<br/> |
| [LightBuzz](KeepCoding_Sound_LightBuzz.md 'KeepCoding.Sound.LightBuzz') | Plays when the lights go out.<br/> |
| [LightBuzzShort](KeepCoding_Sound_LightBuzzShort.md 'KeepCoding.Sound.LightBuzzShort') | Plays when the lights start to come back on.<br/> |
| [MenuButtonPressed](KeepCoding_Sound_MenuButtonPressed.md 'KeepCoding.Sound.MenuButtonPressed') | Plays when you start a mission from the mission binder.<br/> |
| [MenuDrop](KeepCoding_Sound_MenuDrop.md 'KeepCoding.Sound.MenuDrop') | Plays as the mission folder hits the desk.<br/> |
| [NeedyActivated](KeepCoding_Sound_NeedyActivated.md 'KeepCoding.Sound.NeedyActivated') | Plays when a needy gets activated.<br/> |
| [NeedyWarning](KeepCoding_Sound_NeedyWarning.md 'KeepCoding.Sound.NeedyWarning') | Plays when a needy is running out of time. This sound loops.<br/> |
| [NormalTimerBeep](KeepCoding_Sound_NormalTimerBeep.md 'KeepCoding.Sound.NormalTimerBeep') | Plays when the bomb has no strikes.<br/> |
| [PageTurn](KeepCoding_Sound_PageTurn.md 'KeepCoding.Sound.PageTurn') | Plays when a page is turned in the Missions binder.<br/> |
| [Reference](KeepCoding_Sound_Reference.md 'KeepCoding.Sound.Reference') | The audio reference that is playing the sound.<br/> |
| [SelectionTick](KeepCoding_Sound_SelectionTick.md 'KeepCoding.Sound.SelectionTick') | Plays as you hover over something interactable.<br/> |
| [Stamp](KeepCoding_Sound_Stamp.md 'KeepCoding.Sound.Stamp') | Plays during the post game screen, when either the defused or exploded text is stamped onto the binder.<br/> |
| [Strike](KeepCoding_Sound_Strike.md 'KeepCoding.Sound.Strike') | Plays when you get a strike.<br/> |
| [Switch](KeepCoding_Sound_Switch.md 'KeepCoding.Sound.Switch') | Plays when a switch is toggled.<br/> |
| [TitleMenuPressed](KeepCoding_Sound_TitleMenuPressed.md 'KeepCoding.Sound.TitleMenuPressed') | Plays when pressing a button in one of the tutorials.<br/> |
| [TypewriterKey](KeepCoding_Sound_TypewriterKey.md 'KeepCoding.Sound.TypewriterKey') | Plays during the post game screen as the mission information gets typed out.<br/> |
| [WireSequenceMechanism](KeepCoding_Sound_WireSequenceMechanism.md 'KeepCoding.Sound.WireSequenceMechanism') | Plays when switching between sets of wires in Wire Sequence.<br/> |
| [WireSnip](KeepCoding_Sound_WireSnip.md 'KeepCoding.Sound.WireSnip') | Played when a wire is cut on a module like Complicated Wires.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(Sound)](KeepCoding_Sound_Equals(KeepCoding_Sound).md 'KeepCoding.Sound.Equals(KeepCoding.Sound)') | Determines if both [Sound](KeepCoding_Sound.md 'KeepCoding.Sound') variables are equal.<br/> |
| [Equals(object)](KeepCoding_Sound_Equals(object).md 'KeepCoding.Sound.Equals(object)') | Determines if both [Sound](KeepCoding_Sound.md 'KeepCoding.Sound') variables are equal.<br/> |
| [GetHashCode()](KeepCoding_Sound_GetHashCode().md 'KeepCoding.Sound.GetHashCode()') | Gets the current hash code.<br/> |
| [Method(KMAudio)](KeepCoding_Sound_Method(global__KMAudio).md 'KeepCoding.Sound.Method(global::KMAudio)') | Gets the corresponding sound method matching the arguments of this instance of [Sound](KeepCoding_Sound.md 'KeepCoding.Sound').<br/> |
| [StopSound()](KeepCoding_Sound_StopSound().md 'KeepCoding.Sound.StopSound()') | Stops the [Reference](KeepCoding_Sound_Reference.md 'KeepCoding.Sound.Reference')'s sound.<br/> |
| [ToString()](KeepCoding_Sound_ToString().md 'KeepCoding.Sound.ToString()') | Converts the current sound to a string, returning the current sound.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator SoundEffect(Sound)](KeepCoding_Sound_op_Explicitglobal__KMSoundOverride_SoundEffect(KeepCoding_Sound).md 'KeepCoding.Sound.op_Explicit global::KMSoundOverride.SoundEffect(KeepCoding.Sound)') | Returns [Game](KeepCoding_Sound_Game.md 'KeepCoding.Sound.Game') for the current variable.<br/> |
| [explicit operator string(Sound)](KeepCoding_Sound_op_Explicitstring(KeepCoding_Sound).md 'KeepCoding.Sound.op_Explicit string(KeepCoding.Sound)') | Returns [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') for the current variable.<br/> |
| [explicit operator Nullable&lt;SoundEffect&gt;(Sound)](KeepCoding_Sound_op_ExplicitSystem_Nullable_global__KMSoundOverride_SoundEffect_(KeepCoding_Sound).md 'KeepCoding.Sound.op_Explicit System.Nullable&lt;global::KMSoundOverride.SoundEffect&gt;(KeepCoding.Sound)') | Returns [Game](KeepCoding_Sound_Game.md 'KeepCoding.Sound.Game') for the current variable.<br/> |
| [implicit operator Sound(SoundEffect)](KeepCoding_Sound_op_ImplicitKeepCoding_Sound(global__KMSoundOverride_SoundEffect).md 'KeepCoding.Sound.op_Implicit KeepCoding.Sound(global::KMSoundOverride.SoundEffect)') | An instance of Sound where [Game](KeepCoding_Sound_Game.md 'KeepCoding.Sound.Game') is defined.<br/> |
| [implicit operator Sound(string)](KeepCoding_Sound_op_ImplicitKeepCoding_Sound(string).md 'KeepCoding.Sound.op_Implicit KeepCoding.Sound(string)') | An instance of Sound where [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
| [implicit operator Sound(AudioClip)](KeepCoding_Sound_op_ImplicitKeepCoding_Sound(UnityEngine_AudioClip).md 'KeepCoding.Sound.op_Implicit KeepCoding.Sound(UnityEngine.AudioClip)') | An instance of Sound where [Custom](KeepCoding_Sound_Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
