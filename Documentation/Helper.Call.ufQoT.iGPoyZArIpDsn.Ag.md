#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Call&lt;T&gt;(T[], Action&lt;T,int&gt;) Method
Invokes a method of [T](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T') and then returns the argument provided.  
```csharp
public static T[] Call<T>(this T[] source, System.Action<T,int> action);
```
#### Type parameters
<a name='KeepCoding.Helper.Call.T.(T...System.Action.T.int.).T'></a>
`T`  
The type of [source](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source') and [action](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).action 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).action').
  
#### Parameters
<a name='KeepCoding.Helper.Call.T.(T...System.Action.T.int.).source'></a>
`source` [T](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item to use as reference and modify.
  
<a name='KeepCoding.Helper.Call.T.(T...System.Action.T.int.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to apply [source](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source') to.
  
#### Returns
[T](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).T 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The item [source](Helper.Call.ufQoT.iGPoyZArIpDsn.Ag.md#KeepCoding.Helper.Call.T.(T...System.Action.T.int.).source 'KeepCoding.Helper.Call&lt;T&gt;(T[], System.Action&lt;T,int&gt;).source').
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
### Remarks
This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.  
