#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ComponentPool](ComponentPool.md 'KeepCoding.ComponentPool')
## ComponentPool.SpecialComponentTypeEnum Enum
Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). Set to "None" to select specific module types.  
```csharp
public enum ComponentPool.SpecialComponentTypeEnum

```
#### Fields
<a name='KeepCoding_ComponentPool_SpecialComponentTypeEnum_ALL_NEEDY'></a>
`ALL_NEEDY` 2  
Indicates that the mission will randomly pull any of the game's loaded needy modules.  
  
<a name='KeepCoding_ComponentPool_SpecialComponentTypeEnum_ALL_SOLVABLE'></a>
`ALL_SOLVABLE` 1  
Indicates that the mission will randomly pull any of the game's loaded solvable modules.  
  
<a name='KeepCoding_ComponentPool_SpecialComponentTypeEnum_None'></a>
`None` 0  
Indicates that the mission will choose a set of modules that are self-defined.  
  
