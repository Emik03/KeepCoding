#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.Add(Color, float, float, float, float) Method
Duplicates the color, and adds the RGBA components only if they are specified.  
```csharp
public static UnityEngine.Color Add(this UnityEngine.Color color, float r=0f, float g=0f, float b=0f, float a=0f);
```
#### Parameters
<a name='KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_color'></a>
`color` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The color to duplicate and modify.
  
<a name='KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_r'></a>
`r` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The red component.
  
<a name='KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_g'></a>
`g` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The blue component.
  
<a name='KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_b'></a>
`b` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The green component.
  
<a name='KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_a'></a>
`a` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The alpha component; opacity.
  
#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
A new instance of the [color](KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float).md#KeepCoding_TypeHelper_Add(UnityEngine_Color_float_float_float_float)_color 'KeepCoding.TypeHelper.Add(UnityEngine.Color, float, float, float, float).color'), with the arguments replacing the values.
### Remarks
You can also use negative numbers to subtract.  
