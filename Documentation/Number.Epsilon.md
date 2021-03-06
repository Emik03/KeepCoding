#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.Epsilon Property
Returns the epsilon constant with precision based on the current type of the value.  
```csharp
public KeepCoding.Number Epsilon { get; }
```
#### Property Value
[Number](Number.md 'KeepCoding.Number')
### Remarks
Calling this will assume that the value is either [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), or [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal'). An exception is thrown otherwise.  
