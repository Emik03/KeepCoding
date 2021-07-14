#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine(Action, Action[]) Method
Combines actions together, only if these actions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Action Combine(this System.Action self, params System.Action[] others);
```
#### Parameters
<a name='KeepCoding_EventHelper_Combine(System_Action_System_Action__)_self'></a>
`self` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to modify.
  
<a name='KeepCoding_EventHelper_Combine(System_Action_System_Action__)_others'></a>
`others` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The actions to combine with [self](KeepCoding_EventHelper_Combine(System_Action_System_Action__).md#KeepCoding_EventHelper_Combine(System_Action_System_Action__)_self 'KeepCoding.EventHelper.Combine(System.Action, System.Action[]).self').
  
#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
[self](KeepCoding_EventHelper_Combine(System_Action_System_Action__).md#KeepCoding_EventHelper_Combine(System_Action_System_Action__)_self 'KeepCoding.EventHelper.Combine(System.Action, System.Action[]).self') with [others](KeepCoding_EventHelper_Combine(System_Action_System_Action__).md#KeepCoding_EventHelper_Combine(System_Action_System_Action__)_others 'KeepCoding.EventHelper.Combine(System.Action, System.Action[]).others') appended.
