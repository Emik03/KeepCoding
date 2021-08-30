#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## MonoRandom Class
A pseudo-random number generator that is primarily used to get multiple platforms to share the same random number generator.  
```csharp
public class MonoRandom
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MonoRandom  

| Constructors | |
| :--- | :--- |
| [MonoRandom()](MonoRandom.MonoRandom().md 'KeepCoding.MonoRandom.MonoRandom()') | Initializes a new instance of the [MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom') class, using a time-dependent default seed value.<br/> |
| [MonoRandom(int)](MonoRandom..ctor.KlChetAwbrR6gp+jJJ4OGg.md 'KeepCoding.MonoRandom.MonoRandom(int)') | Initializes a new instance of the [System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random') class, using the specified seed value.<br/> |

| Properties | |
| :--- | :--- |
| [Seed](MonoRandom.Seed.md 'KeepCoding.MonoRandom.Seed') | The seed used for the randomization.<br/> |

| Methods | |
| :--- | :--- |
| [Next()](MonoRandom.Next().md 'KeepCoding.MonoRandom.Next()') | Returns a nonnegative random number.<br/> |
| [Next(int)](MonoRandom.Next.VHA+leEGvLe8GM16JiFp.g.md 'KeepCoding.MonoRandom.Next(int)') | Returns a nonnegative random number less than the specified maximum.<br/> |
| [Next(int, int)](MonoRandom.Next.0E36OfIPdQ3n44yRv2pAWg.md 'KeepCoding.MonoRandom.Next(int, int)') | Returns a random number within a specified range.<br/> |
| [NextBytes(byte[])](MonoRandom.NextBytes.f7ucoBIuQt0B3ppE67k+AA.md 'KeepCoding.MonoRandom.NextBytes(byte[])') | Fills the elements of a specified array of bytes with random numbers.<br/> |
| [NextDouble()](MonoRandom.NextDouble().md 'KeepCoding.MonoRandom.NextDouble()') | Returns a random number between 0.0 and 1.0.<br/> |
| [Sample()](MonoRandom.Sample().md 'KeepCoding.MonoRandom.Sample()') | Returns a random number between 0.0 and 1.0.<br/> |
| [Shuffle&lt;T&gt;(T)](MonoRandom.Shuffle.5O.igPeRkXTv0BjFt+Dl5w.md 'KeepCoding.MonoRandom.Shuffle&lt;T&gt;(T)') | Shuffles a list using an in-place algorithm; the original list is modified.<br/> |
