#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Sound Class
Class meant to encapsulate all types of sound effects [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') uses. Currently used in [ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript').  
```csharp
public sealed class Sound :
System.IEquatable<KeepCoding.Sound>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Sound  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Sound](Sound.md 'KeepCoding.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [Sound(AudioClip)](Sound..ctor.hIDiGbTX3EJcCHwWr4+itA.md 'KeepCoding.Sound.Sound(AudioClip)') | An instance of Sound where [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
| [Sound(string)](Sound..ctor.SEB2CwcDvjVVhxlQhJ3X9Q.md 'KeepCoding.Sound.Sound(string)') | An instance of Sound where [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |

| Properties | |
| :--- | :--- |
| [AlarmClockBeep](Sound.AlarmClockBeep.md 'KeepCoding.Sound.AlarmClockBeep') | Plays when the alarm clock goes off. This sound loops.<br/> |
| [AlarmClockSnooze](Sound.AlarmClockSnooze.md 'KeepCoding.Sound.AlarmClockSnooze') | Plays when you hit snooze button on the alarm clock.<br/> |
| [BigButtonPress](Sound.BigButtonPress.md 'KeepCoding.Sound.BigButtonPress') | Plays when pressing down the button on the Big Button vanilla module.<br/> |
| [BigButtonRelease](Sound.BigButtonRelease.md 'KeepCoding.Sound.BigButtonRelease') | Plays when releasing the button on the Big Button vanilla module.<br/> |
| [BinderDrop](Sound.BinderDrop.md 'KeepCoding.Sound.BinderDrop') | Plays as the mission binder hits the desk.<br/> |
| [BombDefused](Sound.BombDefused.md 'KeepCoding.Sound.BombDefused') | Plays immediately after a bomb is defused. Plays before [KMSoundOverride.SoundEffect.GameOverFanfare](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect.GameOverFanfare 'KMSoundOverride.SoundEffect.GameOverFanfare').<br/> |
| [BombDrop](Sound.BombDrop.md 'KeepCoding.Sound.BombDrop') | Plays when the bomb is set down on the desk.<br/> |
| [BombExplode](Sound.BombExplode.md 'KeepCoding.Sound.BombExplode') | Plays when the bomb explodes.<br/> |
| [BriefcaseClose](Sound.BriefcaseClose.md 'KeepCoding.Sound.BriefcaseClose') | Plays when the freeplay briefcase is closed.<br/> |
| [BriefcaseOpen](Sound.BriefcaseOpen.md 'KeepCoding.Sound.BriefcaseOpen') | Plays when the freeplay briefcase is opened.<br/> |
| [ButtonPress](Sound.ButtonPress.md 'KeepCoding.Sound.ButtonPress') | Plays when pressing down a button.<br/> |
| [ButtonRelease](Sound.ButtonRelease.md 'KeepCoding.Sound.ButtonRelease') | Plays when releasing a button.<br/> |
| [CapacitorPop](Sound.CapacitorPop.md 'KeepCoding.Sound.CapacitorPop') | Plays when Capacitor Discharge fills up completely.<br/> |
| [CorrectChime](Sound.CorrectChime.md 'KeepCoding.Sound.CorrectChime') | Plays in the tutorial for completing a step correctly.<br/> |
| [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') | The custom sound, written out by name.<br/> |
| [DossierOptionPressed](Sound.DossierOptionPressed.md 'KeepCoding.Sound.DossierOptionPressed') | Plays when you change a setting in the menu folder.<br/> |
| [EmergencyAlarm](Sound.EmergencyAlarm.md 'KeepCoding.Sound.EmergencyAlarm') | Plays when there is less than a minute left on the bomb, this sound loops.<br/> |
| [FastestTimerBeep](Sound.FastestTimerBeep.md 'KeepCoding.Sound.FastestTimerBeep') | Plays when the bomb has at least 2 or more strikes.<br/> |
| [FastTimerBeep](Sound.FastTimerBeep.md 'KeepCoding.Sound.FastTimerBeep') | Plays when the bomb has 1 strike.<br/> |
| [FreeplayDeviceDrop](Sound.FreeplayDeviceDrop.md 'KeepCoding.Sound.FreeplayDeviceDrop') | Plays as the freeplay briefcase hits the desk.<br/> |
| [Game](Sound.Game.md 'KeepCoding.Sound.Game') | The in-game sound.<br/> |
| [GameOverFanfare](Sound.GameOverFanfare.md 'KeepCoding.Sound.GameOverFanfare') | Plays when all bombs are defused. Finishes before the post game screen.<br/> |
| [LightBuzz](Sound.LightBuzz.md 'KeepCoding.Sound.LightBuzz') | Plays when the lights go out.<br/> |
| [LightBuzzShort](Sound.LightBuzzShort.md 'KeepCoding.Sound.LightBuzzShort') | Plays when the lights start to come back on.<br/> |
| [MenuButtonPressed](Sound.MenuButtonPressed.md 'KeepCoding.Sound.MenuButtonPressed') | Plays when you start a mission from the mission binder.<br/> |
| [MenuDrop](Sound.MenuDrop.md 'KeepCoding.Sound.MenuDrop') | Plays as the mission folder hits the desk.<br/> |
| [NeedyActivated](Sound.NeedyActivated.md 'KeepCoding.Sound.NeedyActivated') | Plays when a needy gets activated.<br/> |
| [NeedyWarning](Sound.NeedyWarning.md 'KeepCoding.Sound.NeedyWarning') | Plays when a needy is running out of time. This sound loops.<br/> |
| [NormalTimerBeep](Sound.NormalTimerBeep.md 'KeepCoding.Sound.NormalTimerBeep') | Plays when the bomb has no strikes.<br/> |
| [PageTurn](Sound.PageTurn.md 'KeepCoding.Sound.PageTurn') | Plays when a page is turned in the Missions binder.<br/> |
| [Reference](Sound.Reference.md 'KeepCoding.Sound.Reference') | The audio reference that is playing the sound.<br/> |
| [SelectionTick](Sound.SelectionTick.md 'KeepCoding.Sound.SelectionTick') | Plays as you hover over something interactable.<br/> |
| [Stamp](Sound.Stamp.md 'KeepCoding.Sound.Stamp') | Plays during the post game screen, when either the defused or exploded text is stamped onto the binder.<br/> |
| [Strike](Sound.Strike.md 'KeepCoding.Sound.Strike') | Plays when you get a strike.<br/> |
| [Switch](Sound.Switch.md 'KeepCoding.Sound.Switch') | Plays when a switch is toggled.<br/> |
| [TitleMenuPressed](Sound.TitleMenuPressed.md 'KeepCoding.Sound.TitleMenuPressed') | Plays when pressing a button in one of the tutorials.<br/> |
| [TypewriterKey](Sound.TypewriterKey.md 'KeepCoding.Sound.TypewriterKey') | Plays during the post game screen as the mission information gets typed out.<br/> |
| [WireSequenceMechanism](Sound.WireSequenceMechanism.md 'KeepCoding.Sound.WireSequenceMechanism') | Plays when switching between sets of wires in Wire Sequence.<br/> |
| [WireSnip](Sound.WireSnip.md 'KeepCoding.Sound.WireSnip') | Played when a wire is cut on a module like Complicated Wires.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(Sound)](Sound.Equals.c6uGonaS3e4ASyDzvkttuw.md 'KeepCoding.Sound.Equals(KeepCoding.Sound)') | Determines if both [Sound](Sound.md 'KeepCoding.Sound') variables are equal.<br/> |
| [Equals(object)](Sound.Equals.FPfKaUiVpkRnA41gfKxjYQ.md 'KeepCoding.Sound.Equals(object)') | Determines if both [Sound](Sound.md 'KeepCoding.Sound') variables are equal.<br/> |
| [GetHashCode()](Sound.GetHashCode().md 'KeepCoding.Sound.GetHashCode()') | Gets the current hash code.<br/> |
| [Method(KMAudio)](Sound.Method.24QuhqsELxRIr9EQ4sXIPg.md 'KeepCoding.Sound.Method(KMAudio)') | Gets the corresponding sound method matching the arguments of this instance of [Sound](Sound.md 'KeepCoding.Sound').<br/> |
| [StopSound()](Sound.StopSound().md 'KeepCoding.Sound.StopSound()') | Stops the [Reference](Sound.Reference.md 'KeepCoding.Sound.Reference')'s sound.<br/> |
| [ToString()](Sound.ToString().md 'KeepCoding.Sound.ToString()') | Converts the current sound to a string, returning the current sound.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator string(Sound)](Sound.op_Explicit.iRGhnmJkgxDgJ9AH9Ez1Iw.md 'KeepCoding.Sound.op_Explicit string(KeepCoding.Sound)') | Returns [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') for the current variable.<br/> |
| [implicit operator Sound(AudioClip)](Sound.op_Implicit.1VVtMvd0MhUc57.Uh+cStw.md 'KeepCoding.Sound.op_Implicit KeepCoding.Sound(AudioClip)') | An instance of Sound where [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
| [implicit operator Sound(string)](Sound.op_Implicit.9LcqouHaO9eloVUnV6Vf5A.md 'KeepCoding.Sound.op_Implicit KeepCoding.Sound(string)') | An instance of Sound where [Custom](Sound.Custom.md 'KeepCoding.Sound.Custom') is defined.<br/> |
