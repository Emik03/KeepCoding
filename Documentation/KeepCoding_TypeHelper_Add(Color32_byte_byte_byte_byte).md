#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.Add(Color32, byte, byte, byte, byte) Method
Duplicates the color, and adds the RGBA components only if they are specified.  
```csharp
public static Color32 Add(this Color32 color, byte r=0, byte g=0, byte b=0, byte a=0);
```
#### Parameters
<a name='KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_color'></a>
`color` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
The [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32') to duplicate and modify.
  
<a name='KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_r'></a>
`r` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The red component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_g'></a>
`g` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The blue component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_b'></a>
`b` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The green component.
  
<a name='KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_a'></a>
`a` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The alpha component; opacity.
  
#### Returns
[UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
A new instance of the [color](KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte).md#KeepCoding_TypeHelper_Add(Color32_byte_byte_byte_byte)_color 'KeepCoding.TypeHelper.Add(Color32, byte, byte, byte, byte).color'), with the arguments replacing the values.
### Remarks
You can also use negative numbers to subtract. As this is [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32'), be careful of byte underflows/overflows.  
