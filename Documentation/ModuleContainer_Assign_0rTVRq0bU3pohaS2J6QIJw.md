#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.Assign(Action, Action, Action, Action, Action, Action) Method
Assigns events to a module container, replacing their values.  
```csharp
public void Assign(System.Action onActivate=null, System.Action onNeedyActivation=null, System.Action onNeedyDeactivation=null, System.Action onPass=null, System.Action onStrike=null, System.Action onTimerExpired=null);
```
#### Parameters
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onActivate'></a>
`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the lights turn on.
  
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onNeedyActivation'></a>
`onNeedyActivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy activates.
  
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onNeedyDeactivation'></a>
`onNeedyDeactivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy deactivates.
  
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onPass'></a>
`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy is solved.
  
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onStrike'></a>
`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy strikes.
  
<a name='KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action)_onTimerExpired'></a>
`onTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the timer runs out of time.
  
