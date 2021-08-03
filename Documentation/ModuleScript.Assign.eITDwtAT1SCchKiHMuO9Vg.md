#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleScript](ModuleScript.md 'KeepCoding.ModuleScript')
## ModuleScript.Assign(Action, Action, Action, Action, Action, Action) Method
Assigns events specified into [Module](ModuleScript.Module.md 'KeepCoding.ModuleScript.Module'). Reassigning them will replace their values.  
```csharp
public void Assign(System.Action onActivate=null, System.Action onNeedyActivation=null, System.Action onNeedyDeactivation=null, System.Action onPass=null, System.Action onStrike=null, System.Action onTimerExpired=null);
```
#### Parameters
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onActivate'></a>
`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the lights turn on.
  
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onNeedyActivation'></a>
`onNeedyActivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy activates.
  
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onNeedyDeactivation'></a>
`onNeedyDeactivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy deactivates.
  
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onPass'></a>
`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy is solved.
  
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onStrike'></a>
`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy strikes.
  
<a name='KeepCoding.ModuleScript.Assign(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action).onTimerExpired'></a>
`onTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the timer runs out of time.
  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.  
