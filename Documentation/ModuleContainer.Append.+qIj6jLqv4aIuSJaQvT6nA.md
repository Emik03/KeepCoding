#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.Append(Action, Action, Action, Action, Action, Action, Action&lt;float&gt;, Func&lt;int&gt;, Func&lt;float&gt;) Method
Appends events to this instance, preserving their existing values.  
```csharp
public void Append(System.Action activate=null, System.Action needyActivate=null, System.Action needyDeactivate=null, System.Action needyTimerExpired=null, System.Action solve=null, System.Action strike=null, System.Action<float> needyTimerSet=null, System.Func<int> ruleGeneration=null, System.Func<float> needyTimerGet=null);
```
#### Parameters
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).activate'></a>
`activate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the lights turn on.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).needyActivate'></a>
`needyActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy activates.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).needyDeactivate'></a>
`needyDeactivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy deactivates.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).needyTimerExpired'></a>
`needyTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the timer runs out of time.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).solve'></a>
`solve` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy is solved.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).strike'></a>
`strike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the needy strikes.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).needyTimerSet'></a>
`needyTimerSet` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when [KMNeedyModule.GetNeedyTimeRemaining](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.GetNeedyTimeRemaining 'KMNeedyModule.GetNeedyTimeRemaining') is called.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).ruleGeneration'></a>
`ruleGeneration` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
Called when [KMBombModule.GetRuleGenerationSeed](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.GetRuleGenerationSeed 'KMBombModule.GetRuleGenerationSeed') or [KMNeedyModule.GetRuleGenerationSeed](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.GetRuleGenerationSeed 'KMNeedyModule.GetRuleGenerationSeed') is called.
  
<a name='KeepCoding.ModuleContainer.Append(System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.System.Action.float..System.Func.int..System.Func.float.).needyTimerGet'></a>
`needyTimerGet` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
Called when [KMNeedyModule.SetNeedyTimeRemaining(System.Single)](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule.SetNeedyTimeRemaining#KMNeedyModule_SetNeedyTimeRemaining_System_Single_ 'KMNeedyModule.SetNeedyTimeRemaining(System.Single)') is called.
  
