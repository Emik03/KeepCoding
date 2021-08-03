#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Combine&lt;T&gt;(Action&lt;T&gt;, Action&lt;T&gt;[]) Method
Combines actions together, only if these actions are not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
public static System.Action<T> Combine<T>(this System.Action<T> self, params System.Action<T>[] others);
```
#### Type parameters
<a name='KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).self'></a>
`self` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to modify.
  
<a name='KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).others'></a>
`others` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The actions to combine with [self](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).self 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).self').
  
#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).T 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
[self](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).self 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).self') with [others](EventHelper.Combine.iZg6UGb+CeQd.xKhyD6rOw.md#KeepCoding.EventHelper.Combine.T.(System.Action.T..System.Action.T...).others 'KeepCoding.EventHelper.Combine&lt;T&gt;(System.Action&lt;T&gt;, System.Action&lt;T&gt;[]).others') appended.
