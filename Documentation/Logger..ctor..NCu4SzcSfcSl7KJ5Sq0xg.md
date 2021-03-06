#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Logger](Logger.md 'KeepCoding.Logger')
## Logger.Logger(string, bool, bool) Constructor
The string constructor. The string determines the name.  
```csharp
public Logger(string name, bool showId=false, bool showInLfa=true);
```
#### Parameters
<a name='KeepCoding.Logger.Logger(string.bool.bool).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the value.
  
<a name='KeepCoding.Logger.Logger(string.bool.bool).showId'></a>
`showId` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to show the unique identifier when logging.
  
<a name='KeepCoding.Logger.Logger(string.bool.bool).showInLfa'></a>
`showInLfa` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to format such that the Logfile Analyzer would use.
  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
