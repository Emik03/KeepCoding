#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMNeedyModule, Action, Action, Action, Action, Action, Action) Method
Assigns events specified into [needyModule](KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action).md#KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_needyModule 'KeepCoding.EventHelper.Assign(KMNeedyModule, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action).needyModule'). Reassigning them will replace their values.  
```csharp
public static void Assign(this KMNeedyModule needyModule, System.Action onActivate=null, System.Action onNeedyActivation=null, System.Action onNeedyDeactivation=null, System.Action onPass=null, System.Action onStrike=null, System.Action onTimerExpired=null);
```
#### Parameters
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_needyModule'></a>
`needyModule` [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule')  
The needy instance to assign events to.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onActivate'></a>
`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the lights turn on.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onNeedyActivation'></a>
`onNeedyActivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy activates.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onNeedyDeactivation'></a>
`onNeedyDeactivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy deactivates.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onPass'></a>
`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy is solved.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onStrike'></a>
`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy strikes.
  
<a name='KeepCoding_EventHelper_Assign(KMNeedyModule_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onTimerExpired'></a>
`onTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the timer runs out of time.
  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.  
