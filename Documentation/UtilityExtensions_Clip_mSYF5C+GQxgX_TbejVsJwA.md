#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Clip(double, double, double) Method
Clips this value to the range defined by [minimumValue](UtilityExtensions_Clip_mSYF5C+GQxgX_TbejVsJwA.md#KeepCoding_UtilityExtensions_Clip(double_double_double)_minimumValue 'KeepCoding.UtilityExtensions.Clip(double, double, double).minimumValue') and [maximumValue](UtilityExtensions_Clip_mSYF5C+GQxgX_TbejVsJwA.md#KeepCoding_UtilityExtensions_Clip(double_double_double)_maximumValue 'KeepCoding.UtilityExtensions.Clip(double, double, double).maximumValue').  
The returned number will be no less than the minimum value and no greater than the maximum value. Throws an  
exception if min value is greater than the max value.
```csharp
public static double Clip(this double value, double minimumValue, double maximumValue);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_Clip(double_double_double)_value'></a>
`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
  
<a name='KeepCoding_UtilityExtensions_Clip(double_double_double)_minimumValue'></a>
`minimumValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
  
<a name='KeepCoding_UtilityExtensions_Clip(double_double_double)_maximumValue'></a>
`maximumValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
  
#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
