### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMBombInfo, Action, Action) Method
Assigns events specified into [bombInfo](KeepCoding_EventHelper_Assign(KMBombInfo_System_Action_System_Action).md#KeepCoding_EventHelper_Assign(KMBombInfo_System_Action_System_Action)_bombInfo 'KeepCoding.EventHelper.Assign(KMBombInfo, System.Action, System.Action).bombInfo'). Reassigning them will replace their values.  
```csharp
public static void Assign(this KMBombInfo bombInfo, System.Action onBombExploded=null, System.Action onBombSolved=null);
```
#### Parameters
<a name='KeepCoding_EventHelper_Assign(KMBombInfo_System_Action_System_Action)_bombInfo'></a>
`bombInfo` [KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo')  
The bomb info instance to assign events to.
  
<a name='KeepCoding_EventHelper_Assign(KMBombInfo_System_Action_System_Action)_onBombExploded'></a>
`onBombExploded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the bomb explodes.
  
<a name='KeepCoding_EventHelper_Assign(KMBombInfo_System_Action_System_Action)_onBombSolved'></a>
`onBombSolved` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the bomb is defused.
  
#### Exceptions
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.  
