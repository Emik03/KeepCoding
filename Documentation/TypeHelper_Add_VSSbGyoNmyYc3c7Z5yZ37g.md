#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.Add(Color32, float, float, float, float) Method
Duplicates the color, and adds the RGBA components only if they are specified.  
```csharp
public static Color32 Add(this Color32 color, float r=0f, float g=0f, float b=0f, float a=0f);
```
#### Parameters
<a name='KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_color'></a>
`color` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
The [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32') to duplicate and modify.
  
<a name='KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_r'></a>
`r` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The red component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_g'></a>
`g` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The blue component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_b'></a>
`b` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The green component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_a'></a>
`a` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The alpha component; opacity.
  
#### Returns
[UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
A new instance of the [color](TypeHelper_Add_VSSbGyoNmyYc3c7Z5yZ37g.md#KeepCoding_TypeHelper_Add(Color32_float_float_float_float)_color 'KeepCoding.TypeHelper.Add(Color32, float, float, float, float).color'), with the arguments replacing the values.
### Remarks
You can also use negative numbers to subtract. As this is [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32'), be careful of byte underflows/overflows.  
