### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](KeepCoding_Number.md 'KeepCoding.Number')
## Number.Epsilon Property
```csharp
public KeepCoding.Number Epsilon { get; }
```
#### Property Value
[Number](KeepCoding_Number.md 'KeepCoding.Number')
Returns the epsilon constant with precision based on the current type of the value.  
### Remarks
Calling this will assume that the value is either [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), or [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal'). An exception is thrown otherwise.  
