#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Clip(int, int, int) Method
Clips this value to the range defined by [minimumValue](UtilityExtensions_Clip_8sM94CuteOK_ff4uf3rD9g.md#KeepCoding_UtilityExtensions_Clip(int_int_int)_minimumValue 'KeepCoding.UtilityExtensions.Clip(int, int, int).minimumValue') and [maximumValue](UtilityExtensions_Clip_8sM94CuteOK_ff4uf3rD9g.md#KeepCoding_UtilityExtensions_Clip(int_int_int)_maximumValue 'KeepCoding.UtilityExtensions.Clip(int, int, int).maximumValue').  
The returned number will be no less than the minimum value and no greater than the maximum value. Throws an  
exception if min value is greater than the max value.
```csharp
public static int Clip(this int value, int minimumValue, int maximumValue);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_Clip(int_int_int)_value'></a>
`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding_UtilityExtensions_Clip(int_int_int)_minimumValue'></a>
`minimumValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='KeepCoding_UtilityExtensions_Clip(int_int_int)_maximumValue'></a>
`maximumValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
