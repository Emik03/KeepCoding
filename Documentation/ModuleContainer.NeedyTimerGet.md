#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.NeedyTimerGet Property
Needy Only: An encapsulated [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the time remaining. This value is immutable for vanilla modules, and an exception will be thrown when attempted.  
```csharp
public KeepCoding.Internal.ModuleEvent<System.Func<float>> NeedyTimerGet { get; }
```
#### Property Value
[KeepCoding.Internal.ModuleEvent&lt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')
#### Exceptions
[System.MissingMethodException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMethodException 'System.MissingMethodException')  
[UnityEngine.MissingReferenceException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingReferenceException 'UnityEngine.MissingReferenceException')  
[ImmutableException](ImmutableException.md 'KeepCoding.Internal.ImmutableException')  
