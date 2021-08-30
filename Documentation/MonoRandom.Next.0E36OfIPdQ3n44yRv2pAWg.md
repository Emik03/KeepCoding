#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')
## MonoRandom.Next(int, int) Method
Returns a random number within a specified range.  
```csharp
public virtual int Next(int minValue, int maxValue);
```
#### Parameters
<a name='KeepCoding.MonoRandom.Next(int.int).minValue'></a>
`minValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The inclusive lower bound of the random number returned.
  
<a name='KeepCoding.MonoRandom.Next(int.int).maxValue'></a>
`maxValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The exclusive upper bound of the random number returned. [maxValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).maxValue 'KeepCoding.MonoRandom.Next(int, int).maxValue') must be greater than or equal to [minValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).minValue 'KeepCoding.MonoRandom.Next(int, int).minValue').
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit signed integer greater than or equal to [minValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).minValue 'KeepCoding.MonoRandom.Next(int, int).minValue') and less than [maxValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).maxValue 'KeepCoding.MonoRandom.Next(int, int).maxValue'); that is, the range of return values includes [minValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).minValue 'KeepCoding.MonoRandom.Next(int, int).minValue') but not [maxValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).maxValue 'KeepCoding.MonoRandom.Next(int, int).maxValue'). If [minValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).minValue 'KeepCoding.MonoRandom.Next(int, int).minValue') equals [maxValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).maxValue 'KeepCoding.MonoRandom.Next(int, int).maxValue'), [minValue](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md#KeepCoding.MonoRandom.Next(int.int).minValue 'KeepCoding.MonoRandom.Next(int, int).minValue') is returned.
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
