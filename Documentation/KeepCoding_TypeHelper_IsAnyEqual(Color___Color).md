### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.IsAnyEqual(Color[], Color) Method
Checks if any elements in the array [colors](KeepCoding_TypeHelper_IsAnyEqual(Color___Color).md#KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_colors 'KeepCoding.TypeHelper.IsAnyEqual(Color[], Color).colors') are equal to [color](KeepCoding_TypeHelper_IsAnyEqual(Color___Color).md#KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_color 'KeepCoding.TypeHelper.IsAnyEqual(Color[], Color).color').  
```csharp
public static bool IsAnyEqual(this Color[] colors, Color color);
```
#### Parameters
<a name='KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_colors'></a>
`colors` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of colors to compare to [color](KeepCoding_TypeHelper_IsAnyEqual(Color___Color).md#KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_color 'KeepCoding.TypeHelper.IsAnyEqual(Color[], Color).color').
  
<a name='KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_color'></a>
`color` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The color to compare it to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Boolean, true only if any color in [colors](KeepCoding_TypeHelper_IsAnyEqual(Color___Color).md#KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_colors 'KeepCoding.TypeHelper.IsAnyEqual(Color[], Color).colors') is the exact same as [color](KeepCoding_TypeHelper_IsAnyEqual(Color___Color).md#KeepCoding_TypeHelper_IsAnyEqual(Color___Color)_color 'KeepCoding.TypeHelper.IsAnyEqual(Color[], Color).color')'s R, G, B, and A values.
#### Exceptions
[NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException')  
