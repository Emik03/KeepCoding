#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T&gt;(Action&lt;T&gt;, Action&lt;T&gt;[]) Method
Combines actions together, only if these actions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Action<T> Combine<T>(this System.Action<T> self, params System.Action<T>[] others);
```
#### Type parameters
<a name='KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_self'></a>
`self` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to modify.
  
<a name='KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_others'></a>
`others` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The actions to combine with [self](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_self 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).self').
  
#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
[self](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_self 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).self') with [others](EventHelper_Combine_iZg6UGb+CeQd_xKhyD6rOw.md#KeepCoding_EventHelper_Combine_T_(System_Action_T__System_Action_T___)_others 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).others') appended.
