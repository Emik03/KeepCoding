#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]) Method
Presses a sequence of buttons according to [indices](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_indices 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).indices') within [selectables](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_selectables 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).selectables'), waiting [wait](KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__).md#KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_wait 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).wait') seconds in-between each, and interrupting as soon as [HasStruck](KeepCoding_ModuleScript_HasStruck.md 'KeepCoding.ModuleScript.HasStruck') is true.  
```csharp
protected System.Collections.IEnumerator OnInteractSequence(KMSelectable[] selectables, float wait, params int[] indices);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_selectables'></a>
`selectables` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of selectables to interact with.
  
<a name='KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_wait'></a>
`wait` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The delay between each button press in seconds.
  
<a name='KeepCoding_TPScript_TModule__OnInteractSequence(KMSelectable___float_int__)_indices'></a>
`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The indices to press within the array.
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A sequence of button presses for Twitch Plays to process.
