#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Checked&lt;T&gt;(Func&lt;T&gt;) Method
The [checked](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked') keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.  
```csharp
public static T Checked<T>(this System.Func<T> func);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Checked.T.(System.Func.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.KeyHelper.Checked.T.(System.Func.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Checked.ZTyCDRUfGdF1zDNl4Q+hYw.md#KeepCoding.KeyHelper.Checked.T.(System.Func.T.).T 'KeepCoding.KeyHelper.Checked&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to run inside a [checked](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked') block.
  
#### Returns
[T](KeyHelper.Checked.ZTyCDRUfGdF1zDNl4Q+hYw.md#KeepCoding.KeyHelper.Checked.T.(System.Func.T.).T 'KeepCoding.KeyHelper.Checked&lt;T&gt;(System.Func&lt;T&gt;).T')  
The output of [func](KeyHelper.Checked.ZTyCDRUfGdF1zDNl4Q+hYw.md#KeepCoding.KeyHelper.Checked.T.(System.Func.T.).func 'KeepCoding.KeyHelper.Checked&lt;T&gt;(System.Func&lt;T&gt;).func').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked')
