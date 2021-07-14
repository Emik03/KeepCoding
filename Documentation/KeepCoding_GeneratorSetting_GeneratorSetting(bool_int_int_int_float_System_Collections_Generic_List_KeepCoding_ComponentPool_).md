#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[GeneratorSetting](KeepCoding_GeneratorSetting.md 'KeepCoding.GeneratorSetting')
## GeneratorSetting.GeneratorSetting(bool, int, int, int, float, List&lt;ComponentPool&gt;) Constructor
Creates a generator setting based on the provided parameters.  
```csharp
public GeneratorSetting(bool frontFaceOnly, int optionalWidgetCount, int numStrikes, int timeBeforeNeedyActivation, float timeLimit, System.Collections.Generic.List<KeepCoding.ComponentPool> componentPools);
```
#### Parameters
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_frontFaceOnly'></a>
`frontFaceOnly` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously.
  
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_optionalWidgetCount'></a>
`optionalWidgetCount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Set how many optional widgets (widgets other than serial number) that should be placed on the bomb.
  
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_numStrikes'></a>
`numStrikes` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3.
  
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_timeBeforeNeedyActivation'></a>
`timeBeforeNeedyActivation` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.
  
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_timeLimit'></a>
`timeLimit` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Initial value for the timer when the bomb is activated, in seconds.
  
<a name='KeepCoding_GeneratorSetting_GeneratorSetting(bool_int_int_int_float_System_Collections_Generic_List_KeepCoding_ComponentPool_)_componentPools'></a>
`componentPools` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ComponentPool](KeepCoding_ComponentPool.md 'KeepCoding.ComponentPool')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The pools of modules that will be used when generating a bomb.
  
