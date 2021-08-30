#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToLogger&lt;T&gt;(T, string, bool, bool) Method
Converts arguments to a new [Logger](Logger.md 'KeepCoding.Logger').  
```csharp
public static KeepCoding.Logger ToLogger<T>(this T _, string name=null, bool showId=false, bool showInLfa=true);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).T'></a>
`T`  
The type of the argument, which is used as the name if [name](TypeHelper.ToLogger.i3PUkdWm4YtN+OKX+LHmSw.md#KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).name 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool, bool).name') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool)._'></a>
`_` [T](TypeHelper.ToLogger.i3PUkdWm4YtN+OKX+LHmSw.md#KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).T 'KeepCoding.TypeHelper.ToLogger&lt;T&gt;(T, string, bool, bool).T')  
The discard which is only needed for the type.
  
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the value.
  
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).showId'></a>
`showId` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to show the unique identifier when logging.
  
<a name='KeepCoding.TypeHelper.ToLogger.T.(T.string.bool.bool).showInLfa'></a>
`showInLfa` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether the formatting should be compliant with the Logfile Analyzer.
  
#### Returns
[Logger](Logger.md 'KeepCoding.Logger')  
A new [Logger](Logger.md 'KeepCoding.Logger') containing the arguments specified.
