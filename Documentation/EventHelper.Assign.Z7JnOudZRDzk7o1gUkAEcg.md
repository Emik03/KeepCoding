#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMBombInfo, Action, Action) Method
Assigns events specified into [bombInfo](EventHelper.Assign.Z7JnOudZRDzk7o1gUkAEcg.md#KeepCoding.EventHelper.Assign(KMBombInfo.System.Action.System.Action).bombInfo 'KeepCoding.EventHelper.Assign(KMBombInfo, System.Action, System.Action).bombInfo'). Reassigning them will replace their values.  
```csharp
public static KMBombInfo Assign(this KMBombInfo bombInfo, System.Action onBombExploded=null, System.Action onBombSolved=null);
```
#### Parameters
<a name='KeepCoding.EventHelper.Assign(KMBombInfo.System.Action.System.Action).bombInfo'></a>
`bombInfo` [KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo')  
The bomb info instance to assign events to.
  
<a name='KeepCoding.EventHelper.Assign(KMBombInfo.System.Action.System.Action).onBombExploded'></a>
`onBombExploded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the bomb explodes.
  
<a name='KeepCoding.EventHelper.Assign(KMBombInfo.System.Action.System.Action).onBombSolved'></a>
`onBombSolved` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the bomb is defused.
  
#### Returns
[KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo')  
#### Exceptions
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.  
