#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T,TResult&gt;(Func&lt;T,TResult&gt;, Func&lt;T,TResult&gt;[]) Method
Combines actions together, only if these functions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Func<T,TResult> Combine<T,TResult>(this System.Func<T,TResult> self, params System.Func<T,TResult>[] others);
```
#### Type parameters
<a name='KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_T'></a>
`T`  
  
<a name='KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_self'></a>
`self` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to modify.
  
<a name='KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_others'></a>
`others` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions to combine with [self](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).self').
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_T 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
[self](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).self') with [others](KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___).md#KeepCoding_EventHelper_Combine_T_TResult_(System_Func_T_TResult__System_Func_T_TResult___)_others 'KeepCoding.EventHelper.Combine&lt;T,TResult&gt;(System.Func&lt;T,TResult&gt;, System.Func&lt;T,TResult&gt;[]).others') appended.
