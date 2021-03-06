#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]) Method
Presses a sequence of buttons according to [indices](TPScript.TModule..OnInteractSequence.BDCqLwYKYl5pAjSBekGAmQ.md#KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).indices 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).indices') within [selectables](TPScript.TModule..OnInteractSequence.BDCqLwYKYl5pAjSBekGAmQ.md#KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).selectables 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).selectables'), waiting [wait](TPScript.TModule..OnInteractSequence.BDCqLwYKYl5pAjSBekGAmQ.md#KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).wait 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float, int[]).wait') seconds in-between each, and interrupting as soon as [HasStruck](ModuleScript.HasStruck.md 'KeepCoding.ModuleScript.HasStruck') is true.  
```csharp
protected System.Collections.Generic.IEnumerable<WaitForSecondsRealtime> OnInteractSequence(KMSelectable[] selectables, float wait, params int[] indices);
```
#### Parameters
<a name='KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).selectables'></a>
`selectables` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of selectables to interact with.
  
<a name='KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).wait'></a>
`wait` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The delay between each button press in seconds.
  
<a name='KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float.int..).indices'></a>
`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The indices to press within the array.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[UnityEngine.WaitForSecondsRealtime](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.WaitForSecondsRealtime 'UnityEngine.WaitForSecondsRealtime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.
