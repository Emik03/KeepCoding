#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.IntertwineColor(Color32, Color32, float) Method
Creates an in-between color between 2 different colors.  
```csharp
public static Color32 IntertwineColor(this Color32 colorA, Color32 colorB, float concentrationOfB=0.5f);
```
#### Parameters
<a name='KeepCoding_TypeHelper_IntertwineColor(Color32_Color32_float)_colorA'></a>
`colorA` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
The first color, with 0 [concentrationOfB](TypeHelper_IntertwineColor_0bFaDJYlhcWbOv8_PXUW9Q.md#KeepCoding_TypeHelper_IntertwineColor(Color32_Color32_float)_concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(Color32, Color32, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding_TypeHelper_IntertwineColor(Color32_Color32_float)_colorB'></a>
`colorB` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
The second color, with 1 [concentrationOfB](TypeHelper_IntertwineColor_0bFaDJYlhcWbOv8_PXUW9Q.md#KeepCoding_TypeHelper_IntertwineColor(Color32_Color32_float)_concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(Color32, Color32, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding_TypeHelper_IntertwineColor(Color32_Color32_float)_concentrationOfB'></a>
`concentrationOfB` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The bias towards either color, between 0-1. 0.5 blends both colors equally.
  
#### Returns
[UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
A blended color of the 2 provided.
