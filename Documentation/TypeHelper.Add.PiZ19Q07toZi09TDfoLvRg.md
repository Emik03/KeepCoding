#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.Add(Color, float, float, float, float) Method
Duplicates the color, and adds the RGBA components only if they are specified.  
```csharp
public static Color Add(this Color color, float r=0f, float g=0f, float b=0f, float a=0f);
```
#### Parameters
<a name='KeepCoding.TypeHelper.Add(Color.float.float.float.float).color'></a>
`color` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The color to duplicate and modify.
  
<a name='KeepCoding.TypeHelper.Add(Color.float.float.float.float).r'></a>
`r` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The red component.
  
<a name='KeepCoding.TypeHelper.Add(Color.float.float.float.float).g'></a>
`g` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The blue component.
  
<a name='KeepCoding.TypeHelper.Add(Color.float.float.float.float).b'></a>
`b` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The green component.
  
<a name='KeepCoding.TypeHelper.Add(Color.float.float.float.float).a'></a>
`a` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The alpha component; opacity.
  
#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
A new instance of the [color](TypeHelper.Add.PiZ19Q07toZi09TDfoLvRg.md#KeepCoding.TypeHelper.Add(Color.float.float.float.float).color 'KeepCoding.TypeHelper.Add(Color, float, float, float, float).color'), with the arguments replacing the values.
### Remarks
You can also use negative numbers to subtract.  
