#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Apply&lt;T,TResult&gt;(T, Func&lt;T,TResult&gt;) Method
Invokes a method of [T](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T') to [TResult](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult') and then returns the argument provided.  
```csharp
public static TResult Apply<T,TResult>(this T item, System.Func<T,TResult> func);
```
#### Type parameters
<a name='KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).T'></a>
`T`  
The type of [item](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item').
  
<a name='KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).TResult'></a>
`TResult`  
The type to return.
  
#### Parameters
<a name='KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).item'></a>
`item` [T](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')  
The item to use as reference and modify.
  
<a name='KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).T 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to apply [item](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item') to.
  
#### Returns
[TResult](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).TResult 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).TResult')  
The item [item](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).item 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).item') after [func](Helper.Apply.YDzGFHzicZrAftsGieknnw.md#KeepCoding.Helper.Apply.T.TResult.(T.System.Func.T.TResult.).func 'KeepCoding.Helper.Apply&lt;T,TResult&gt;(T, System.Func&lt;T,TResult&gt;).func').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
