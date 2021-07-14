#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer')
## ModuleContainer.RequiresTimerVisibility Property
```csharp
public bool RequiresTimerVisibility { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.  
#### Exceptions
[UnrecognizedTypeException](KeepCoding_UnrecognizedTypeException.md 'KeepCoding.UnrecognizedTypeException')  