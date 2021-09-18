#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.NeedyTimerSet Property
Modded Needy Only: An encapsulated [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') that when called, sets the time remaining to the parameter passed in. This value is immutable for vanilla modules, and an exception will be thrown when attempted.  
```csharp
public System.Action<float> NeedyTimerSet { get; set; }
```
#### Property Value
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')
#### Exceptions
[System.MissingMethodException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMethodException 'System.MissingMethodException')  
[UnityEngine.MissingReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingReferenceException 'UnityEngine.MissingReferenceException')  
[ImmutableException](ImmutableException.md 'KeepCoding.Internal.ImmutableException')  
