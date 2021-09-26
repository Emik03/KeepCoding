#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float) Method
Presses a sequence of buttons in order of [selectables](TPScript.TModule..OnInteractSequence.AhOFDrmmnRpVPkl37xNrYA.md#KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float).selectables 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float).selectables'), waiting [wait](TPScript.TModule..OnInteractSequence.AhOFDrmmnRpVPkl37xNrYA.md#KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float).wait 'KeepCoding.TPScript&lt;TModule&gt;.OnInteractSequence(KMSelectable[], float).wait') seconds in-between each, and interrupting as soon as [HasStruck](ModuleScript.HasStruck.md 'KeepCoding.ModuleScript.HasStruck') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
protected System.Collections.Generic.IEnumerable<WaitForSecondsRealtime> OnInteractSequence(KMSelectable[] selectables, float wait);
```
#### Parameters
<a name='KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float).selectables'></a>
`selectables` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of selectables to interact with.
  
<a name='KeepCoding.TPScript.TModule..OnInteractSequence(KMSelectable...float).wait'></a>
`wait` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The delay between each button press in seconds.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[UnityEngine.WaitForSecondsRealtime](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.WaitForSecondsRealtime 'UnityEngine.WaitForSecondsRealtime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.
