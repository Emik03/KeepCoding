### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;TResult&gt;(Func&lt;TResult&gt;, Func&lt;TResult&gt;[]) Method
Combines actions together, only if these functions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Func<TResult> Combine<TResult>(this System.Func<TResult> self, params System.Func<TResult>[] others);
```
#### Type parameters
<a name='KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_self'></a>
`self` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The function to modify.
  
<a name='KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_others'></a>
`others` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions to combine with [self](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).self').
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
[self](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).self') with [others](KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___).md#KeepCoding_EventHelper_Combine_TResult_(System_Func_TResult__System_Func_TResult___)_others 'KeepCoding.EventHelper.Combine&lt;TResult&gt;(System.Func&lt;TResult&gt;, System.Func&lt;TResult&gt;[]).others') appended.
