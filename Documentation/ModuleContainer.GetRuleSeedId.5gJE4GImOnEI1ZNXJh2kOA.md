#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.GetRuleSeedId(int) Method
Gets the rule seed number, or a default value.  
```csharp
public int GetRuleSeedId(int editorValue);
```
#### Parameters
<a name='KeepCoding.ModuleContainer.GetRuleSeedId(int).editorValue'></a>
`editorValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') if played on the Unity Editor.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
If successful, the rule seed's number that is used as the seed in [MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom'). The default value is 1, or [editorValue](ModuleContainer.GetRuleSeedId.5gJE4GImOnEI1ZNXJh2kOA.md#KeepCoding.ModuleContainer.GetRuleSeedId(int).editorValue 'KeepCoding.ModuleContainer.GetRuleSeedId(int).editorValue') if played in the Unity Editor.
