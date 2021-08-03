#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Call&lt;T&gt;(T, Action&lt;T&gt;) Method
Invokes a method of [T](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T') and then returns the argument provided.  
```csharp
public static T Call<T>(this T item, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding.Helper.Call.T.(T.System.Action.T.).T'></a>
`T`  
The type of [item](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item') and [action](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).action 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).action').
  
#### Parameters
<a name='KeepCoding.Helper.Call.T.(T.System.Action.T.).item'></a>
`item` [T](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item to use as reference and modify.
  
<a name='KeepCoding.Helper.Call.T.(T.System.Action.T.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to apply [item](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item') to.
  
#### Returns
[T](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).T 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item [item](Helper.Call.L0hPRBNo.FAPTdZBQbG.uw.md#KeepCoding.Helper.Call.T.(T.System.Action.T.).item 'KeepCoding.Helper.Call&lt;T&gt;(T, System.Action&lt;T&gt;).item').
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
