#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMBombModule, Action, Action, Action) Method
Assigns events specified into [bombModule](KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action).md#KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action)_bombModule 'KeepCoding.EventHelper.Assign(global::KMBombModule, System.Action, System.Action, System.Action).bombModule'). Reassigning them will replace their values.  
```csharp
public static global::KMBombModule Assign(this global::KMBombModule bombModule, System.Action onActivate=null, System.Action onPass=null, System.Action onStrike=null);
```
#### Parameters
<a name='KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action)_bombModule'></a>
`bombModule` [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')  
The bomb instance to assign events to.
  
<a name='KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action)_onActivate'></a>
`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the lights turn on.
  
<a name='KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action)_onPass'></a>
`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the module is solved.
  
<a name='KeepCoding_EventHelper_Assign(global__KMBombModule_System_Action_System_Action_System_Action)_onStrike'></a>
`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the module strikes.
  
#### Returns
[KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.  
