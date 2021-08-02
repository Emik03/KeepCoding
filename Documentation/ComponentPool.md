#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ComponentPool Class
A ComponentPool is a collection of Module Types. The generator will pick [Count](ComponentPool_Count.md 'KeepCoding.ComponentPool.Count') times from this list and instantiate a component of the chosen type.  
```csharp
public sealed class ComponentPool
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ComponentPool  

| Constructors | |
| :--- | :--- |
| [ComponentPool(int, ComponentSource, SpecialComponentTypeEnum, List&lt;string&gt;, List&lt;ComponentTypeEnum&gt;)](ComponentPool__ctor_hRPxj+6BQ4zKAf1XsQHATw.md 'KeepCoding.ComponentPool.ComponentPool(int, KeepCoding.ComponentPool.ComponentSource, KeepCoding.ComponentPool.SpecialComponentTypeEnum, System.Collections.Generic.List&lt;string&gt;, System.Collections.Generic.List&lt;KeepCoding.ComponentPool.ComponentTypeEnum&gt;)') | Creates a pool of selectable modules.<br/> |

| Properties | |
| :--- | :--- |
| [AllowedSources](ComponentPool_AllowedSources.md 'KeepCoding.ComponentPool.AllowedSources') | Controls where components can come from (either the base game, mods, or both).<br/> |
| [ComponentTypes](ComponentPool_ComponentTypes.md 'KeepCoding.ComponentPool.ComponentTypes') | The list of component types, not including any calculated at runtime special types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list.<br/> |
| [Count](ComponentPool_Count.md 'KeepCoding.ComponentPool.Count') | How many components from this pool should be selected.<br/> |
| [ModTypes](ComponentPool_ModTypes.md 'KeepCoding.ComponentPool.ModTypes') | A list of mod types to be included in the pool, if they exist.<br/> |
| [SpecialComponentType](ComponentPool_SpecialComponentType.md 'KeepCoding.ComponentPool.SpecialComponentType') | Special types which are calculated at runtime, such as [ALL_SOLVABLE](ComponentPool_SpecialComponentTypeEnum.md#KeepCoding_ComponentPool_SpecialComponentTypeEnum_ALL_SOLVABLE 'KeepCoding.ComponentPool.SpecialComponentTypeEnum.ALL_SOLVABLE').<br/> |

| Methods | |
| :--- | :--- |
| [ToString()](ComponentPool_ToString().md 'KeepCoding.ComponentPool.ToString()') | Converts itself to a string.<br/> |
