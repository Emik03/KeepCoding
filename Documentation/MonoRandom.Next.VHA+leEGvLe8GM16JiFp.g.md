#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom')
## MonoRandom.Next(int) Method
Returns a nonnegative random number less than the specified maximum.  
```csharp
public virtual int Next(int maxValue);
```
#### Parameters
<a name='KeepCoding.MonoRandom.Next(int).maxValue'></a>
`maxValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The exclusive upper bound of the random number to be generated. [maxValue](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md#KeepCoding.MonoRandom.Next(int).maxValue 'KeepCoding.MonoRandom.Next(int).maxValue') must be greater than or equal to zero.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit signed integer greater than or equal to zero, and less than [maxValue](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md#KeepCoding.MonoRandom.Next(int).maxValue 'KeepCoding.MonoRandom.Next(int).maxValue'); that is, the range of return values ordinarily includes zero but not [maxValue](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md#KeepCoding.MonoRandom.Next(int).maxValue 'KeepCoding.MonoRandom.Next(int).maxValue'). However, if [maxValue](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md#KeepCoding.MonoRandom.Next(int).maxValue 'KeepCoding.MonoRandom.Next(int).maxValue') equals zero, [maxValue](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md#KeepCoding.MonoRandom.Next(int).maxValue 'KeepCoding.MonoRandom.Next(int).maxValue') is returned.
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
