#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## HashCode Struct
Combines the hash code for multiple values into a single hash code. xxHash32 is used for the hash code. [https://github.com/Cyan4973/xxHash](https://github.com/Cyan4973/xxHash 'https://github.com/Cyan4973/xxHash')
```csharp
public struct HashCode
```
### Remarks
You can use HashCode to combine multiple values (for example, fields on a structure or class) into a single hash code. This structure operates in one of two ways, static methods that accept a set of up to eight values to combine, and two instance methods that operate in a streaming fashion, accepting values one at a time.  

| Methods | |
| :--- | :--- |
| [Add&lt;T&gt;(T)](HashCode.Add.yf+k1MfqiUfUrmQ17.OyhQ.md 'KeepCoding.HashCode.Add&lt;T&gt;(T)') | Adds a single value to the hash code.<br/> |
| [Add&lt;T&gt;(T, IEqualityComparer&lt;T&gt;)](HashCode.Add.DDEUFIPbOWBcLEW1DDyscA.md 'KeepCoding.HashCode.Add&lt;T&gt;(T, System.Collections.Generic.IEqualityComparer&lt;T&gt;)') | Adds a single value to the hash code, specifying the type that provides the hash code function.<br/> |
| [Combine&lt;T1&gt;(T1)](HashCode.Combine.Ip4cUE5tYi7iUMrg6yRjdw.md 'KeepCoding.HashCode.Combine&lt;T1&gt;(T1)') | Diffuses the hash code returned by the specified value.<br/> |
| [Combine&lt;T1,T2&gt;(T1, T2)](HashCode.Combine.W2t.u2Jc5WusNdHT1IhsmQ.md 'KeepCoding.HashCode.Combine&lt;T1,T2&gt;(T1, T2)') | Combines two values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3&gt;(T1, T2, T3)](HashCode.Combine.hnj18Q9w7qWVsCoGxHWCpQ.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3&gt;(T1, T2, T3)') | Combines three values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3,T4&gt;(T1, T2, T3, T4)](HashCode.Combine.fghB4niBG7mTSN3zMwiD6Q.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3,T4&gt;(T1, T2, T3, T4)') | Combines four values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3,T4,T5&gt;(T1, T2, T3, T4, T5)](HashCode.Combine.TuTmYpga4s8xc+m8SgHlJA.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3,T4,T5&gt;(T1, T2, T3, T4, T5)') | Combines five values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3,T4,T5,T6&gt;(T1, T2, T3, T4, T5, T6)](HashCode.Combine.vqylN8dlwfYpuqcUSSZWKg.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3,T4,T5,T6&gt;(T1, T2, T3, T4, T5, T6)') | Combines six values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3,T4,T5,T6,T7&gt;(T1, T2, T3, T4, T5, T6, T7)](HashCode.Combine.sJGBvBPmSM+oleb94Gf1fQ.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3,T4,T5,T6,T7&gt;(T1, T2, T3, T4, T5, T6, T7)') | Combines seven values into a hash code.<br/> |
| [Combine&lt;T1,T2,T3,T4,T5,T6,T7,T8&gt;(T1, T2, T3, T4, T5, T6, T7, T8)](HashCode.Combine.G8EgAs2B1jAj301G2EoR2g.md 'KeepCoding.HashCode.Combine&lt;T1,T2,T3,T4,T5,T6,T7,T8&gt;(T1, T2, T3, T4, T5, T6, T7, T8)') | Combines eight values into a hash code.<br/> |
| [ToHashCode()](HashCode.ToHashCode().md 'KeepCoding.HashCode.ToHashCode()') | Calculates the final hash code after consecutive [KeepCoding.HashCode.Add(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.HashCode.Add#KeepCoding_HashCode_Add_System_Int32_ 'KeepCoding.HashCode.Add(System.Int32)')/[KeepCoding.HashCode.Add(System.UInt32,System.UInt32)](https://docs.microsoft.com/en-us/dotnet/api/KeepCoding.HashCode.Add#KeepCoding_HashCode_Add_System_UInt32,System_UInt32_ 'KeepCoding.HashCode.Add(System.UInt32,System.UInt32)') invocations.<br/> |
