#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')
## MonoRandom.Next(int, bool) Method
Returns a nonnegative random number less than the specified maximum.  
```csharp
public virtual int Next(int maxValue, bool isLogging=false);
```
#### Parameters
<a name='KeepCoding.MonoRandom.Next(int.bool).maxValue'></a>
`maxValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The exclusive upper bound of the random number to be generated. [maxValue](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md#KeepCoding.MonoRandom.Next(int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, bool).maxValue') must be greater than or equal to zero.
  
<a name='KeepCoding.MonoRandom.Next(int.bool).isLogging'></a>
`isLogging` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether it should log the result.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit signed integer greater than or equal to zero, and less than [maxValue](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md#KeepCoding.MonoRandom.Next(int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, bool).maxValue'); that is, the range of return values ordinarily includes zero but not [maxValue](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md#KeepCoding.MonoRandom.Next(int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, bool).maxValue'). However, if [maxValue](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md#KeepCoding.MonoRandom.Next(int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, bool).maxValue') equals zero, [maxValue](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md#KeepCoding.MonoRandom.Next(int.bool).maxValue 'KeepCoding.MonoRandom.Next(int, bool).maxValue') is returned.
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
