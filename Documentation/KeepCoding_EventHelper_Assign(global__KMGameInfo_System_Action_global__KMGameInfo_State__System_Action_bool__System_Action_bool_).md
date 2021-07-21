#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMGameInfo, Action&lt;State&gt;, Action&lt;bool&gt;, Action&lt;bool&gt;) Method
Assigns events specified into [gameInfo](KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_).md#KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_)_gameInfo 'KeepCoding.EventHelper.Assign(global::KMGameInfo, System.Action&lt;global::KMGameInfo.State&gt;, System.Action&lt;bool&gt;, System.Action&lt;bool&gt;).gameInfo'). Reassigning them will replace their values.  
```csharp
public static global::KMGameInfo Assign(this global::KMGameInfo gameInfo, System.Action<global::KMGameInfo.State> onStateChange=null, System.Action<bool> onAlarmClockChange=null, System.Action<bool> onLightsChange=null);
```
#### Parameters
<a name='KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_)_gameInfo'></a>
`gameInfo` [KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo')  
The game info instance to assign events to.
  
<a name='KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_)_onStateChange'></a>
`onStateChange` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[KMGameInfo.State](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo.State 'KMGameInfo.State')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the state of the game changes.
  
<a name='KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_)_onAlarmClockChange'></a>
`onAlarmClockChange` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the alarm clock changes state, and passes in whether it's on or off.
  
<a name='KeepCoding_EventHelper_Assign(global__KMGameInfo_System_Action_global__KMGameInfo_State__System_Action_bool__System_Action_bool_)_onLightsChange'></a>
`onLightsChange` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the lights change state, and passes in whether it's on or off.
  
#### Returns
[KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo')  
#### Exceptions
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.  
