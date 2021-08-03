#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Assign(KMSelectable[], Nullable&lt;bool&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int,float&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int&gt;, Action&lt;int,KMSelectable&gt;) Method
Assigns events specified into [selectable](EventHelper.Assign.VpEffVE9O6e87QnH1sBxPw.md#KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).selectable 'KeepCoding.EventHelper.Assign(KMSelectable[], System.Nullable&lt;bool&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int,float&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int&gt;, System.Action&lt;int,KMSelectable&gt;).selectable'). Reassigning them will replace their values. The number passed into each method represents the index that came from the array.  
```csharp
public static KMSelectable[] Assign(this KMSelectable[] selectable, System.Nullable<bool> overrideReturn=null, System.Action<int> onCancel=null, System.Action<int> onDefocus=null, System.Action<int> onDeselect=null, System.Action<int> onFocus=null, System.Action<int> onHighlight=null, System.Action<int> onHighlightEnded=null, System.Action<int> onInteract=null, System.Action<int> onInteractEnded=null, System.Action<int,float> onInteractionPunch=null, System.Action<int> onLeft=null, System.Action<int> onRight=null, System.Action<int> onSelect=null, System.Action<int,KMSelectable> onUpdateChildren=null);
```
#### Parameters
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).selectable'></a>
`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') array to add events to.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).overrideReturn'></a>
`overrideReturn` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
True will make it act as a module/submodule, and false as a button. Null (default) will set it to true or false based on [IsParent(KMSelectable)](Helper.IsParent.GWtuAi5QnEZOBh.iPNli+Q.md 'KeepCoding.Helper.IsParent(KMSelectable)'). Note that in VR, [KMSelectable.OnHighlight](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnHighlight 'KMSelectable.OnHighlight') and [KMSelectable.OnHighlightEnded](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnHighlightEnded 'KMSelectable.OnHighlightEnded') are skipped out on.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onCancel'></a>
`onCancel` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when player backs out of this selectable.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onDefocus'></a>
`onDefocus` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when a different selectable becomes the focus, or the module has been backed out of.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onDeselect'></a>
`onDeselect` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the selectable stops being the current selectable.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onFocus'></a>
`onFocus` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onHighlight'></a>
`onHighlight` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the highlight is turned on.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onHighlightEnded'></a>
`onHighlightEnded` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the highlight is turned off.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onInteract'></a>
`onInteract` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when player interacts with the selctable.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onInteractEnded'></a>
`onInteractEnded` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when a player interacting with the selectable releases the mouse or controller button.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onInteractionPunch'></a>
`onInteractionPunch` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
Called when the interaction punch method is called.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onLeft'></a>
`onLeft` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the left controller stick is pulled while selected.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onRight'></a>
`onRight` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called when the right controller stick is pulled while selected.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onSelect'></a>
`onSelect` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Called whenever the selectable becomes the current selectable.
  
<a name='KeepCoding.EventHelper.Assign(KMSelectable...System.Nullable.bool..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int..System.Action.int.float..System.Action.int..System.Action.int..System.Action.int..System.Action.int.KMSelectable.).onUpdateChildren'></a>
`onUpdateChildren` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
Called when the selectable updates its children.
  
#### Returns
[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
[UnityEngine.UnassignedReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UnassignedReferenceException 'UnityEngine.UnassignedReferenceException')  
### Remarks
An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.  
