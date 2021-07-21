#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.IntertwineColor(Renderer, Color, Color, float) Method
Sets the [UnityEngine.Renderer.material](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Renderer.material 'UnityEngine.Renderer.material')'s color to be a mix of 2 colors.  
```csharp
public static UnityEngine.Color IntertwineColor(this UnityEngine.Renderer renderer, UnityEngine.Color colorA, UnityEngine.Color colorB, float concentrationOfB=0.5f);
```
#### Parameters
<a name='KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_renderer'></a>
`renderer` [UnityEngine.Renderer](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Renderer 'UnityEngine.Renderer')  
The renderer to change the color of.
  
<a name='KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_colorA'></a>
`colorA` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The first color, with 0 [concentrationOfB](KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float).md#KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Renderer, UnityEngine.Color, UnityEngine.Color, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_colorB'></a>
`colorB` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The second color, with 1 [concentrationOfB](KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float).md#KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Renderer, UnityEngine.Color, UnityEngine.Color, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_concentrationOfB'></a>
`concentrationOfB` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The bias towards either color, between 0-1. 0.5 blends both colors equally.
  
#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The resulting color that the [renderer](KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float).md#KeepCoding_TypeHelper_IntertwineColor(UnityEngine_Renderer_UnityEngine_Color_UnityEngine_Color_float)_renderer 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Renderer, UnityEngine.Color, UnityEngine.Color, float).renderer') becomes.
