#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Unwrap(IEnumerable, bool) Method
Unwraps any [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') of type [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), which ends up flattening it as a [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of type [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object').  
```csharp
public static System.Collections.Generic.IEnumerable<object> Unwrap(this System.Collections.IEnumerable source, bool isRecursive=false);
```
#### Parameters
<a name='KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool)_source'></a>
`source` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The object to unwrap.
  
<a name='KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool)_isRecursive'></a>
`isRecursive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should search inside the variable and yield return the elements inside [source](KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool).md#KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool)_source 'KeepCoding.Helper.Unwrap(System.Collections.IEnumerable, bool).source').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of all elements within [source](KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool).md#KeepCoding_Helper_Unwrap(System_Collections_IEnumerable_bool)_source 'KeepCoding.Helper.Unwrap(System.Collections.IEnumerable, bool).source').
