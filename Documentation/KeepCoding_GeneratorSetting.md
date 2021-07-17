#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## GeneratorSetting Class
Everything needed to generate a single bomb.  
```csharp
public sealed class GeneratorSetting
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GeneratorSetting  

| Constructors | |
| :--- | :--- |
| [GeneratorSetting()](KeepCoding_GeneratorSetting_GeneratorSetting().md 'KeepCoding.GeneratorSetting.GeneratorSetting()') | Creates a generator setting with the default parameters.<br/> |
| [GeneratorSetting(bool, int, int, int, float, List&lt;ComponentPool&gt;)](KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_).md 'KeepCoding.GeneratorSetting.GeneratorSetting(bool, int, int, int, float, System.Collections.Generic.List&lt;KeepCoding.ComponentPool&gt;)') | Creates a generator setting based on the provided parameters.<br/> |

| Properties | |
| :--- | :--- |
| [ComponentPools](KeepCoding_GeneratorSetting_ComponentPools.md 'KeepCoding.GeneratorSetting.ComponentPools') | The pools of modules that will be used when generating a bomb.<br/> |
| [FrontFaceOnly](KeepCoding_GeneratorSetting_FrontFaceOnly.md 'KeepCoding.GeneratorSetting.FrontFaceOnly') | Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.<br/> |
| [NumStrikes](KeepCoding_GeneratorSetting_NumStrikes.md 'KeepCoding.GeneratorSetting.NumStrikes') | The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3.<br/> |
| [OptionalWidgetCount](KeepCoding_GeneratorSetting_OptionalWidgetCount.md 'KeepCoding.GeneratorSetting.OptionalWidgetCount') | Set how many optional widgets (widgets other than serial number) that should be placed on the bomb.<br/> |
| [TimeBeforeNeedyActivation](KeepCoding_GeneratorSetting_TimeBeforeNeedyActivation.md 'KeepCoding.GeneratorSetting.TimeBeforeNeedyActivation') | Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.<br/> |
| [TimeLimit](KeepCoding_GeneratorSetting_TimeLimit.md 'KeepCoding.GeneratorSetting.TimeLimit') | Initial value for the timer when the bomb is activated, in seconds.<br/> |

| Methods | |
| :--- | :--- |
| [GetComponentCount()](KeepCoding_GeneratorSetting_GetComponentCount().md 'KeepCoding.GeneratorSetting.GetComponentCount()') | The total count of modules that will be added according to the component pools.<br/> |
| [ToString()](KeepCoding_GeneratorSetting_ToString().md 'KeepCoding.GeneratorSetting.ToString()') | Converts itself to a string.<br/> |
