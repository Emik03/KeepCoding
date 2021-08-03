#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.For&lt;T&gt;(int, Func&lt;int,T&gt;) Method
The [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for') statement executes a statement or a block of statements while a specified Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static System.Collections.Generic.IEnumerable<T> For<T>(this int length, System.Func<int,T> func);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length to reach to in the for loop.
  
<a name='KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.For.gMzckwtRGk4eBiuOkhVsPg.md#KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(int, System.Func&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function for each loop.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper.For.gMzckwtRGk4eBiuOkhVsPg.md#KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).T 'KeepCoding.KeyHelper.For&lt;T&gt;(int, System.Func&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
All instances that [func](KeyHelper.For.gMzckwtRGk4eBiuOkhVsPg.md#KeepCoding.KeyHelper.For.T.(int.System.Func.int.T.).func 'KeepCoding.KeyHelper.For&lt;T&gt;(int, System.Func&lt;int,T&gt;).func') used in an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement')
