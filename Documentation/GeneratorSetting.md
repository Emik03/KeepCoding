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
| [GeneratorSetting()](GeneratorSetting.GeneratorSetting().md 'KeepCoding.GeneratorSetting.GeneratorSetting()') | Creates a generator setting with the default parameters.<br/> |
| [GeneratorSetting(bool, int, int, int, float, List&lt;ComponentPool&gt;)](GeneratorSetting..ctor.oGvH3EZskjNJ0cnQuWWHxA.md 'KeepCoding.GeneratorSetting.GeneratorSetting(bool, int, int, int, float, System.Collections.Generic.List&lt;KeepCoding.ComponentPool&gt;)') | Creates a generator setting based on the provided parameters.<br/> |

| Properties | |
| :--- | :--- |
| [ComponentPools](GeneratorSetting.ComponentPools.md 'KeepCoding.GeneratorSetting.ComponentPools') | The pools of modules that will be used when generating a bomb.<br/> |
| [FrontFaceOnly](GeneratorSetting.FrontFaceOnly.md 'KeepCoding.GeneratorSetting.FrontFaceOnly') | Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.<br/> |
| [NumStrikes](GeneratorSetting.NumStrikes.md 'KeepCoding.GeneratorSetting.NumStrikes') | The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3.<br/> |
| [OptionalWidgetCount](GeneratorSetting.OptionalWidgetCount.md 'KeepCoding.GeneratorSetting.OptionalWidgetCount') | Set how many optional widgets (widgets other than serial number) that should be placed on the bomb.<br/> |
| [TimeBeforeNeedyActivation](GeneratorSetting.TimeBeforeNeedyActivation.md 'KeepCoding.GeneratorSetting.TimeBeforeNeedyActivation') | Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.<br/> |
| [TimeLimit](GeneratorSetting.TimeLimit.md 'KeepCoding.GeneratorSetting.TimeLimit') | Initial value for the timer when the bomb is activated, in seconds.<br/> |

| Methods | |
| :--- | :--- |
| [GetComponentCount()](GeneratorSetting.GetComponentCount().md 'KeepCoding.GeneratorSetting.GetComponentCount()') | The total count of modules that will be added according to the component pools.<br/> |
| [ToString()](GeneratorSetting.ToString().md 'KeepCoding.GeneratorSetting.ToString()') | Converts itself to a string.<br/> |
