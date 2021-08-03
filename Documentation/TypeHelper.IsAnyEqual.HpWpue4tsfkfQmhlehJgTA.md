#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.IsAnyEqual(Color32[], Color32) Method
Checks if any elements in the array [colors](TypeHelper.IsAnyEqual.HpWpue4tsfkfQmhlehJgTA.md#KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).colors 'KeepCoding.TypeHelper.IsAnyEqual(Color32[], Color32).colors') are equal to [color](TypeHelper.IsAnyEqual.HpWpue4tsfkfQmhlehJgTA.md#KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).color 'KeepCoding.TypeHelper.IsAnyEqual(Color32[], Color32).color').  
```csharp
public static bool IsAnyEqual(this Color32[] colors, Color32 color);
```
#### Parameters
<a name='KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).colors'></a>
`colors` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array of colors to compare to [color](TypeHelper.IsAnyEqual.HpWpue4tsfkfQmhlehJgTA.md#KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).color 'KeepCoding.TypeHelper.IsAnyEqual(Color32[], Color32).color').
  
<a name='KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).color'></a>
`color` [UnityEngine.Color32](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color32 'UnityEngine.Color32')  
The color to compare it to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Boolean, true only if any color in [colors](TypeHelper.IsAnyEqual.HpWpue4tsfkfQmhlehJgTA.md#KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).colors 'KeepCoding.TypeHelper.IsAnyEqual(Color32[], Color32).colors') is the exact same as [color](TypeHelper.IsAnyEqual.HpWpue4tsfkfQmhlehJgTA.md#KeepCoding.TypeHelper.IsAnyEqual(Color32...Color32).color 'KeepCoding.TypeHelper.IsAnyEqual(Color32[], Color32).color')'s R, G, B, and A values.
