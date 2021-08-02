#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMSelectable, Nullable&lt;bool&gt;, Action, Action, Action, Action, Action, Action, Action, Action, Action&lt;float&gt;, Action, Action, Action, Action&lt;KMSelectable&gt;) Method
Assigns events specified into [selectable](EventHelper_Assign_zd19DEOUheW+Vj6W3ulUrA.md#KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_selectable 'KeepCoding.EventHelper.Assign(KMSelectable, System.Nullable&lt;bool&gt;, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action&lt;float&gt;, System.Action, System.Action, System.Action, System.Action&lt;KMSelectable&gt;).selectable'). Reassigning them will replace their values.  
```csharp
public static KMSelectable Assign(this KMSelectable selectable, System.Nullable<bool> overrideReturn=null, System.Action onCancel=null, System.Action onDefocus=null, System.Action onDeselect=null, System.Action onFocus=null, System.Action onHighlight=null, System.Action onHighlightEnded=null, System.Action onInteract=null, System.Action onInteractEnded=null, System.Action<float> onInteractionPunch=null, System.Action onLeft=null, System.Action onRight=null, System.Action onSelect=null, System.Action<KMSelectable> onUpdateChildren=null);
```
#### Parameters
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_selectable'></a>
`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
The KMSelectable array to add events to.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_overrideReturn'></a>
`overrideReturn` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
True will make it act as a module/submodule, and false as a button. Null (default) will set it to true or false based on [IsParent(KMSelectable)](Helper_IsParent_GWtuAi5QnEZOBh_iPNli+Q.md 'KeepCoding.Helper.IsParent(KMSelectable)'). Note that in VR, [KMSelectable.OnHighlight](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnHighlight 'KMSelectable.OnHighlight') and [KMSelectable.OnHighlightEnded](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnHighlightEnded 'KMSelectable.OnHighlightEnded') are skipped out on.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onCancel'></a>
`onCancel` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when player backs out of this selectable. Return true will make it act as a module/submodule, and false as a button.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onDefocus'></a>
`onDefocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when a different selectable becomes the focus, or the module has been backed out of.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onDeselect'></a>
`onDeselect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the selectable stops being the current selectable.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onFocus'></a>
`onFocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onHighlight'></a>
`onHighlight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the highlight is turned on.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onHighlightEnded'></a>
`onHighlightEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the highlight is turned off.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onInteract'></a>
`onInteract` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when player interacts with the selctable. Return true will make it act as a module/submodule, and false as a button.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onInteractEnded'></a>
`onInteractEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when a player interacting with the selectable releases the mouse or controller button.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onInteractionPunch'></a>
`onInteractionPunch` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the interaction punch method is called.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onLeft'></a>
`onLeft` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the left controller stick is pulled while selected.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onRight'></a>
`onRight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called when the right controller stick is pulled while selected.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onSelect'></a>
`onSelect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Called whenever the selectable becomes the current selectable.
  
<a name='KeepCoding_EventHelper_Assign(KMSelectable_System_Nullable_bool__System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_System_Action_float__System_Action_System_Action_System_Action_System_Action_KMSelectable_)_onUpdateChildren'></a>
`onUpdateChildren` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the selectable updates its children.
  
#### Returns
[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
#### Exceptions
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.  
