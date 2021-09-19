#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.NeedyTimerSet Property
Needy Only: An encapsulated [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') that when called, sets the time remaining to the parameter passed in. This value is immutable for vanilla modules, and an exception will be thrown when attempted.  
```csharp
public KeepCoding.Internal.ModuleEvent<System.Action<float>> NeedyTimerSet { get; }
```
#### Property Value
[KeepCoding.Internal.ModuleEvent&lt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')
#### Exceptions
[System.MissingMethodException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMethodException 'System.MissingMethodException')  
[UnityEngine.MissingReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingReferenceException 'UnityEngine.MissingReferenceException')  
[ImmutableException](ImmutableException.md 'KeepCoding.Internal.ImmutableException')  
