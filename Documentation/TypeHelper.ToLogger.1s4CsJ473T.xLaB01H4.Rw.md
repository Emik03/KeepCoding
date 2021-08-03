#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToLogger&lt;T&gt;(T, string, bool) Method
Converts arguments to a new [Logger](Logger.md 'KeepCoding.Logger').  
```csharp
public static KeepCoding.Logger ToLogger<T>(this T _, string name=null, bool showId=false);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool).T'></a>
`T`  
The type of the argument, which is used as the name if [name](TypeHelper.ToLogger.1s4CsJ473T.xLaB01H4.Rw.md#KeepCoding.TypeHelper.ToLogger.T.(T.string.bool).name 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool).name') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool)._'></a>
`_` [T](TypeHelper.ToLogger.1s4CsJ473T.xLaB01H4.Rw.md#KeepCoding.TypeHelper.ToLogger.T.(T.string.bool).T 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool).T')  
The discard which is only needed for the type.
  
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the value.
  
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool).showId'></a>
`showId` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to show the unique identifier when logging.
  
#### Returns
[Logger](Logger.md 'KeepCoding.Logger')  
A new [Logger](Logger.md 'KeepCoding.Logger') containing the arguments specified.
