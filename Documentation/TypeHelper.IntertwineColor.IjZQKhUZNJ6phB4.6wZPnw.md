#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.IntertwineColor(Color, Color, float) Method
Creates an in-between color between 2 different colors.  
```csharp
public static Color IntertwineColor(this Color colorA, Color colorB, float concentrationOfB=0.5f);
```
#### Parameters
<a name='KeepCoding.TypeHelper.IntertwineColor(Color.Color.float).colorA'></a>
`colorA` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The first color, with 0 [concentrationOfB](TypeHelper.IntertwineColor.IjZQKhUZNJ6phB4.6wZPnw.md#KeepCoding.TypeHelper.IntertwineColor(Color.Color.float).concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(Color, Color, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding.TypeHelper.IntertwineColor(Color.Color.float).colorB'></a>
`colorB` [UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
The second color, with 1 [concentrationOfB](TypeHelper.IntertwineColor.IjZQKhUZNJ6phB4.6wZPnw.md#KeepCoding.TypeHelper.IntertwineColor(Color.Color.float).concentrationOfB 'KeepCoding.TypeHelper.IntertwineColor(Color, Color, float).concentrationOfB') being biased towards this color.
  
<a name='KeepCoding.TypeHelper.IntertwineColor(Color.Color.float).concentrationOfB'></a>
`concentrationOfB` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The bias towards either color, between 0-1. 0.5 blends both colors equally.
  
#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')  
A blended color of the 2 provided.
