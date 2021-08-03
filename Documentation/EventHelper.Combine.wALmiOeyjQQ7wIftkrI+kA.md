#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;TResult&gt;(Func&lt;TResult&gt;, Func&lt;TResult&gt;[]) Method
Combines actions together, only if these functions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Func<TResult> Combine<TResult>(this System.Func<TResult> self, params System.Func<TResult>[] others);
```
#### Type parameters
<a name='KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).self'></a>
`self` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to modify.
  
<a name='KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).others'></a>
`others` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions to combine with [self](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).self 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).self').
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
[self](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).self 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).self') with [others](EventHelper.Combine.wALmiOeyjQQ7wIftkrI+kA.md#KeepCoding.EventHelper.Combine.TResult.(System.Func.TResult..System.Func.TResult...).others 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).others') appended.
