### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T1,T2&gt;(Action&lt;T1,T2&gt;, Action&lt;T1,T2&gt;[]) Method
Combines actions together, only if these actions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Action<T1,T2> Combine<T1,T2>(this System.Action<T1,T2> self, params System.Action<T1,T2>[] others);
```
#### Type parameters
<a name='KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T1'></a>
`T1`  
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T2'></a>
`T2`  
  
#### Parameters
<a name='KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_self'></a>
`self` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to modify.
  
<a name='KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_others'></a>
`others` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The actions to combine with [self](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_self 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).self').
  
#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T1 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_T2 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
[self](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_self 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).self') with [others](KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___).md#KeepCoding_EventHelper_Combine_T1_T2_(System_Action_T1_T2__System_Action_T1_T2___)_others 'KeepCoding.EventHelper.Combine&lt;T1,T2&gt;(System.Action&lt;T1,T2&gt;, System.Action&lt;T1,T2&gt;[]).others') appended.
