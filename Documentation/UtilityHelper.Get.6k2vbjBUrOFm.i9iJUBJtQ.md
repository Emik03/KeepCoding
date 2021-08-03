#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Get&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Nullable&lt;TValue&gt;) Method
Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is  
returned instead.
```csharp
public static System.Nullable<TValue> Get<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dict, TKey key, System.Nullable<TValue> defaultVal=null)
    where TValue : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey'></a>
`TKey`  
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).key'></a>
`key` [TKey](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')  
Key to look up.
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).defaultVal'></a>
`defaultVal` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
Value to return if [key](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).key 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).key') is not contained in the dictionary.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityHelper.Get.6k2vbjBUrOFm.i9iJUBJtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
