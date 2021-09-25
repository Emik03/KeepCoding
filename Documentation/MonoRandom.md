#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## MonoRandom Class
A pseudo-random number generator that is primarily used to get multiple platforms to share the same random number generator.  
```csharp
public class MonoRandom :
KeepCoding.ILog
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MonoRandom  

Implements [ILog](ILog.md 'KeepCoding.ILog')  

| Constructors | |
| :--- | :--- |
| [MonoRandom()](MonoRandom.MonoRandom().md 'KeepCoding.MonoRandom.MonoRandom()') | Initializes a new instance of the [MonoRandom](MonoRandom.md 'KeepCoding.MonoRandom') class, using a time-dependent default seed value.<br/> |
| [MonoRandom(int)](MonoRandom..ctor.KlChetAwbrR6gp+jJJ4OGg.md 'KeepCoding.MonoRandom.MonoRandom(int)') | Initializes a new instance of the [System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random') class, using the specified seed value.<br/> |

| Properties | |
| :--- | :--- |
| [Seed](MonoRandom.Seed.md 'KeepCoding.MonoRandom.Seed') | The seed used for the randomization.<br/> |

| Methods | |
| :--- | :--- |
| [Log&lt;T&gt;(T, LogType)](MonoRandom.Log.jzR5EDzrgzuvg62Q6gTRbQ.md 'KeepCoding.MonoRandom.Log&lt;T&gt;(T, LogType)') | Logs message, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [Log&lt;T&gt;(T, object[])](MonoRandom.Log.Z6bQPx7eQGPtbQ7Dp0.PkQ.md 'KeepCoding.MonoRandom.Log&lt;T&gt;(T, object[])') | Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.<br/> |
| [LogMultiple(string[])](MonoRandom.LogMultiple.MvM6eW25vCMARshRVaR03w.md 'KeepCoding.MonoRandom.LogMultiple(string[])') | Logs multiple entries to the console.<br/> |
| [Next(bool)](MonoRandom.Next.8hbs3ZrSlWwMg08lnW1ElA.md 'KeepCoding.MonoRandom.Next(bool)') | Returns a nonnegative random number.<br/> |
| [Next(int, bool)](MonoRandom.Next.QqrtxhUZrMW4HCSDApmpxA.md 'KeepCoding.MonoRandom.Next(int, bool)') | Returns a nonnegative random number less than the specified maximum.<br/> |
| [Next(int, int, bool)](MonoRandom.Next.4L.8XIneVXif1QPg0FJ6gg.md 'KeepCoding.MonoRandom.Next(int, int, bool)') | Returns a random number within a specified range.<br/> |
| [NextBytes(byte[], bool)](MonoRandom.NextBytes.diZt6vNkPrPpOremHfJuOg.md 'KeepCoding.MonoRandom.NextBytes(byte[], bool)') | Fills the elements of a specified array of bytes with random numbers.<br/> |
| [NextDouble(bool)](MonoRandom.NextDouble.EJFbv6ROD4vE0mTzHcEGbw.md 'KeepCoding.MonoRandom.NextDouble(bool)') | Returns a random number between 0.0 and 1.0.<br/> |
| [Sample(bool)](MonoRandom.Sample.DvkUkzIZHgJdqRBAWPpQLg.md 'KeepCoding.MonoRandom.Sample(bool)') | Returns a random number between 0.0 and 1.0.<br/> |
| [Shuffle&lt;T&gt;(T, bool)](MonoRandom.Shuffle.LhQwPIlVk4SxjAclm9nODQ.md 'KeepCoding.MonoRandom.Shuffle&lt;T&gt;(T, bool)') | Shuffles a list using an in-place algorithm; the original list is modified.<br/> |
