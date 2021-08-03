#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Clip(decimal, decimal, decimal) Method
Clips this value to the range defined by [minimumValue](UtilityExtensions.Clip.5v0V7fv2Hv00zkJwDO5y6A.md#KeepCoding.UtilityExtensions.Clip(decimal.decimal.decimal).minimumValue 'KeepCoding.UtilityExtensions.Clip(decimal, decimal, decimal).minimumValue') and [maximumValue](UtilityExtensions.Clip.5v0V7fv2Hv00zkJwDO5y6A.md#KeepCoding.UtilityExtensions.Clip(decimal.decimal.decimal).maximumValue 'KeepCoding.UtilityExtensions.Clip(decimal, decimal, decimal).maximumValue').  
The returned number will be no less than the minimum value and no greater than the maximum value. Throws an  
exception if min value is greater than the max value.
```csharp
public static decimal Clip(this decimal value, decimal minimumValue, decimal maximumValue);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.Clip(decimal.decimal.decimal).value'></a>
`value` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
  
<a name='KeepCoding.UtilityExtensions.Clip(decimal.decimal.decimal).minimumValue'></a>
`minimumValue` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
  
<a name='KeepCoding.UtilityExtensions.Clip(decimal.decimal.decimal).maximumValue'></a>
`maximumValue` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
  
#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
