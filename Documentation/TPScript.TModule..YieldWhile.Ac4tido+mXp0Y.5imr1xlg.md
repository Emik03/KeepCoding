#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](TPScript.TModule..md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.YieldWhile&lt;T&gt;(T, Func&lt;bool&gt;) Method
You can yield return this to repeatedly yield return an item until a condition is no longer met.  
```csharp
protected static System.Collections.IEnumerator YieldWhile<T>(T item, System.Func<bool> condition);
```
#### Type parameters
<a name='KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).item'></a>
`item` [T](TPScript.TModule..YieldWhile.Ac4tido+mXp0Y.5imr1xlg.md#KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).T 'KeepCoding.TPScript&lt;TModule&gt;.YieldWhile&lt;T&gt;(T, System.Func&lt;bool&gt;).T')  
The item to yield repeatedly.
  
<a name='KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition to repeatedly check until it returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
  
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
[item](TPScript.TModule..YieldWhile.Ac4tido+mXp0Y.5imr1xlg.md#KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).item 'KeepCoding.TPScript&lt;TModule&gt;.YieldWhile&lt;T&gt;(T, System.Func&lt;bool&gt;).item') continously until [condition](TPScript.TModule..YieldWhile.Ac4tido+mXp0Y.5imr1xlg.md#KeepCoding.TPScript.TModule..YieldWhile.T.(T.System.Func.bool.).condition 'KeepCoding.TPScript&lt;TModule&gt;.YieldWhile&lt;T&gt;(T, System.Func&lt;bool&gt;).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
