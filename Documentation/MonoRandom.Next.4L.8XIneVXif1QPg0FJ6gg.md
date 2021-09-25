#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')
## MonoRandom.Next(int, int, bool) Method
Returns a random number within a specified range.  
```csharp
public virtual int Next(int minValue, int maxValue, bool isLogging=false);
```
#### Parameters
<a name='KeepCoding.MonoRandom.Next(int.int.bool).minValue'></a>
`minValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The inclusive lower bound of the random number returned.
  
<a name='KeepCoding.MonoRandom.Next(int.int.bool).maxValue'></a>
`maxValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The exclusive upper bound of the random number returned. [maxValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, int, bool).maxValue') must be greater than or equal to [minValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).minValue 'KeepCoding.MonoRandom.Next(int, int, bool).minValue').
  
<a name='KeepCoding.MonoRandom.Next(int.int.bool).isLogging'></a>
`isLogging` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should log the result.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit signed integer greater than or equal to [minValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).minValue 'KeepCoding.MonoRandom.Next(int, int, bool).minValue') and less than [maxValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, int, bool).maxValue'); that is, the range of return values includes [minValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).minValue 'KeepCoding.MonoRandom.Next(int, int, bool).minValue') but not [maxValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, int, bool).maxValue'). If [minValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).minValue 'KeepCoding.MonoRandom.Next(int, int, bool).minValue') equals [maxValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, int, bool).maxValue'), [minValue](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md#KeepCoding.MonoRandom.Next(int.int.bool).minValue 'KeepCoding.MonoRandom.Next(int, int, bool).minValue') is returned.
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
