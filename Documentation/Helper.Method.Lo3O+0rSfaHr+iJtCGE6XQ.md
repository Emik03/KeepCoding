#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Method(LogType) Method
Gets the appropriate log method depending on the type of [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType').  
```csharp
public static System.Action<object> Method(this LogType logType);
```
#### Parameters
<a name='KeepCoding.Helper.Method(LogType).logType'></a>
`logType` [UnityEngine.LogType](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.LogType 'UnityEngine.LogType')  
The type of method to get.
  
#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The log method representing the enum [logType](Helper.Method.Lo3O+0rSfaHr+iJtCGE6XQ.md#KeepCoding.Helper.Method(LogType).logType 'KeepCoding.Helper.Method(LogType).logType').
