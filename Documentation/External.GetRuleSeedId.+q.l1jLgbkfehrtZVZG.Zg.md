#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[External](External.md 'KeepCoding.External')
## External.GetRuleSeedId(ModuleContainer, int) Method
Gets the rule seed number, or a default value.  
```csharp
public static int GetRuleSeedId(KeepCoding.ModuleContainer module, int editorValue);
```
#### Parameters
<a name='KeepCoding.External.GetRuleSeedId(KeepCoding.ModuleContainer.int).module'></a>
`module` [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')  
The module to retrieve the id from.
  
<a name='KeepCoding.External.GetRuleSeedId(KeepCoding.ModuleContainer.int).editorValue'></a>
`editorValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') if played on the Unity Editor.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
If successful, the rule seed's number that is used as the seed in [MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom'). The default value is 1, or [editorValue](External.GetRuleSeedId.+q.l1jLgbkfehrtZVZG.Zg.md#KeepCoding.External.GetRuleSeedId(KeepCoding.ModuleContainer.int).editorValue 'KeepCoding.External.GetRuleSeedId(KeepCoding.ModuleContainer, int).editorValue') if played in the Unity Editor.
