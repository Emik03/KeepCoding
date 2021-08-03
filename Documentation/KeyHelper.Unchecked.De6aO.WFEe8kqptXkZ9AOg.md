#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Unchecked&lt;T&gt;(Func&lt;T&gt;) Method
The [unchecked](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked') keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.  
```csharp
public static T Unchecked<T>(this System.Func<T> func);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Unchecked.T.(System.Func.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.KeyHelper.Unchecked.T.(System.Func.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Unchecked.De6aO.WFEe8kqptXkZ9AOg.md#KeepCoding.KeyHelper.Unchecked.T.(System.Func.T.).T 'KeepCoding.KeyHelper.Unchecked&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to ignore overflow-checking.
  
#### Returns
[T](KeyHelper.Unchecked.De6aO.WFEe8kqptXkZ9AOg.md#KeepCoding.KeyHelper.Unchecked.T.(System.Func.T.).T 'KeepCoding.KeyHelper.Unchecked&lt;T&gt;(System.Func&lt;T&gt;).T')  
The output of [func](KeyHelper.Unchecked.De6aO.WFEe8kqptXkZ9AOg.md#KeepCoding.KeyHelper.Unchecked.T.(System.Func.T.).func 'KeepCoding.KeyHelper.Unchecked&lt;T&gt;(System.Func&lt;T&gt;).func').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unchecked')
