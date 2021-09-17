#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.NeedyTimerGet Property
Modded Needy Only: An encapsulated [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the time remaining. This value is immutable for vanilla modules, and an exception will be thrown when attempted.  
```csharp
public System.Func<float> NeedyTimerGet { get; set; }
```
#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')
#### Exceptions
[System.MissingMethodException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMethodException 'System.MissingMethodException')  
[UnityEngine.MissingReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingReferenceException 'UnityEngine.MissingReferenceException')  
[System.Data.ReadOnlyException](https://docs.microsoft.com/en-us/dotnet/api/System.Data.ReadOnlyException 'System.Data.ReadOnlyException')  
