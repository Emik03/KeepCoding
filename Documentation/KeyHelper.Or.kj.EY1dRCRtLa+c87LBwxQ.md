#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Or&lt;T&gt;(Func&lt;T&gt;, T) Method
The null-coalescing operator `??=` returns the value of its right-hand operand if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'); otherwise, it evaluates the left-hand operand, sets it to the right-hand operand, and returns its result. The `??=` operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.  
```csharp
public static T Or<T>(this System.Func<T> alternative, ref T item);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Or.T.(System.Func.T..T).T'></a>
`T`  
The type of the item and return.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Or.T.(System.Func.T..T).alternative'></a>
`alternative` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](KeyHelper.Or.kj.EY1dRCRtLa+c87LBwxQ.md#KeepCoding.KeyHelper.Or.T.(System.Func.T..T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(System.Func&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The variable to set and [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') if [alternative](KeyHelper.Or.kj.EY1dRCRtLa+c87LBwxQ.md#KeepCoding.KeyHelper.Or.T.(System.Func.T..T).alternative 'KeepCoding.KeyHelper.Or&lt;T&gt;(System.Func&lt;T&gt;, T).alternative') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
  
<a name='KeepCoding.KeyHelper.Or.T.(System.Func.T..T).item'></a>
`item` [T](KeyHelper.Or.kj.EY1dRCRtLa+c87LBwxQ.md#KeepCoding.KeyHelper.Or.T.(System.Func.T..T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(System.Func&lt;T&gt;, T).T')  
The item to check [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') for.
  
#### Returns
[T](KeyHelper.Or.kj.EY1dRCRtLa+c87LBwxQ.md#KeepCoding.KeyHelper.Or.T.(System.Func.T..T).T 'KeepCoding.KeyHelper.Or&lt;T&gt;(System.Func&lt;T&gt;, T).T')  
` ??= `
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator')
