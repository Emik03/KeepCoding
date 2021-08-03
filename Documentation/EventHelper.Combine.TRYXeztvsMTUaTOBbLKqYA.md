#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T,TResult&gt;(Func&lt;T,TResult&gt;, Func&lt;T,TResult&gt;[]) Method
Combines actions together, only if these functions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Func<T,TResult> Combine<T,TResult>(this System.Func<T,TResult> self, params System.Func<T,TResult>[] others);
```
#### Type parameters
<a name='KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).T'></a>
`T`  
  
<a name='KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).self'></a>
`self` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to modify.
  
<a name='KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).others'></a>
`others` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions to combine with [self](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).self 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).self').
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
[self](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).self 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).self') with [others](EventHelper.Combine.TRYXeztvsMTUaTOBbLKqYA.md#KeepCoding.EventHelper.Combine.T.TResult.(System.Func.T.TResult..System.Func.T.TResult...).others 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).others') appended.
