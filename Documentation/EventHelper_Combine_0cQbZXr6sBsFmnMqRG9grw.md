#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(Func&lt;T1,T2,T3,T4,TResult&gt;, Func&lt;T1,T2,T3,T4,TResult&gt;[]) Method
Combines actions together, only if these functions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Func<T1,T2,T3,T4,TResult> Combine<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult> self, params System.Func<T1,T2,T3,T4,TResult>[] others);
```
#### Type parameters
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T1'></a>
`T1`  
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T2'></a>
`T2`  
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T3'></a>
`T3`  
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T4'></a>
`T4`  
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_TResult'></a>
`TResult`  
  
#### Parameters
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_self'></a>
`self` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T3 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T4 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The function to modify.
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_others'></a>
`others` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T3 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T4 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions to combine with [self](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).self').
  
#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T3 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_T4 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_TResult 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
[self](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_self 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).self') with [others](EventHelper_Combine_0cQbZXr6sBsFmnMqRG9grw.md#KeepCoding_EventHelper_Combine_T1_T2_T3_T4_TResult_(System_Func_T1_T2_T3_T4_TResult__System_Func_T1_T2_T3_T4_TResult___)_others 'KeepCoding.EventHelper.Combine&lt;T1,T2,T3,T4,TResult&gt;(System.Func&lt;T1,T2,T3,T4,TResult&gt;, System.Func&lt;T1,T2,T3,T4,TResult&gt;[]).others') appended.