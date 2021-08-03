#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.Add(Color, byte, byte, byte, byte) Method
Duplicates the color, and adds the RGBA components only if they are specified.  
```csharp
public static Color Add(this Color color, byte r=0, byte g=0, byte b=0, byte a=0);
```
#### Parameters
<a name='KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).color'></a>
`color` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color') to duplicate and modify.
  
<a name='KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).r'></a>
`r` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The red component.
  
<a name='KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).g'></a>
`g` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The blue component.
  
<a name='KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).b'></a>
`b` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The green component.
  
<a name='KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).a'></a>
`a` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The alpha component; opacity.
  
#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
A new instance of the [color](TypeHelper.Add.TM0V2.i603FiH0EJj6MjiQ.md#KeepCoding.TypeHelper.Add(Color.byte.byte.byte.byte).color 'KeepCoding.TypeHelper.Add(Color, byte, byte, byte, byte).color'), with the arguments replacing the values.
### Remarks
You can also use negative numbers to subtract.  
