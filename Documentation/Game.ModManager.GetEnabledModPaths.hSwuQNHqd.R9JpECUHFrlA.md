#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Game](Game.md 'KeepCoding.Game').[ModManager](Game.ModManager.md 'KeepCoding.Game.ModManager')
## Game.ModManager.GetEnabledModPaths(ModSourceEnum) Method
Gets all of the enabled mod paths within the [ModSourceEnum](Game.ModSourceEnum.md 'KeepCoding.Game.ModSourceEnum') constraint.  
```csharp
public static System.Collections.Generic.List<string> GetEnabledModPaths(KeepCoding.Game.ModSourceEnum source);
```
#### Parameters
<a name='KeepCoding.Game.ModManager.GetEnabledModPaths(KeepCoding.Game.ModSourceEnum).source'></a>
`source` [ModSourceEnum](Game.ModSourceEnum.md 'KeepCoding.Game.ModSourceEnum')  
The [ModSourceEnum](Game.ModSourceEnum.md 'KeepCoding.Game.ModSourceEnum') source that the mod needs to come from to be included in the [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1').
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
A [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') of all enabled mod paths from a given [ModSourceEnum](Game.ModSourceEnum.md 'KeepCoding.Game.ModSourceEnum').
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
[UnrecognizedValueException](UnrecognizedValueException.md 'KeepCoding.Internal.UnrecognizedValueException')  
### Remarks
Default: New instance of [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1'), with no elements.  
