#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.ForEach&lt;T&gt;(T[], Action&lt;T&gt;) Method
Performs the specified action on each element of the specified array.  
```csharp
public static T[] ForEach<T>(this T[] array, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_array'></a>
`array` [T](ArrayHelper_ForEach_JN0Y+RA0o3w_99WjRsalhA.md#KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_T 'KeepCoding.ArrayHelper.ForEach&lt;T&gt;(T[], System.Action&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') on whose elements the action is to be performed.
  
<a name='KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](ArrayHelper_ForEach_JN0Y+RA0o3w_99WjRsalhA.md#KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_T 'KeepCoding.ArrayHelper.ForEach&lt;T&gt;(T[], System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') to perform on each element of [array](ArrayHelper_ForEach_JN0Y+RA0o3w_99WjRsalhA.md#KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_array 'KeepCoding.ArrayHelper.ForEach&lt;T&gt;(T[], System.Action&lt;T&gt;).array').
  
#### Returns
[T](ArrayHelper_ForEach_JN0Y+RA0o3w_99WjRsalhA.md#KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_T 'KeepCoding.ArrayHelper.ForEach&lt;T&gt;(T[], System.Action&lt;T&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[array](ArrayHelper_ForEach_JN0Y+RA0o3w_99WjRsalhA.md#KeepCoding_ArrayHelper_ForEach_T_(T___System_Action_T_)_array 'KeepCoding.ArrayHelper.ForEach&lt;T&gt;(T[], System.Action&lt;T&gt;).array')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-5.0')
