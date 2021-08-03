#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.Get&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Nullable&lt;TValue&gt;) Method
Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is  
returned instead.
```csharp
public static System.Nullable<TValue> Get<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dict, TKey key, System.Nullable<TValue> defaultVal=null)
    where TValue : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey'></a>
`TKey`  
  
<a name='KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).key'></a>
`key` [TKey](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TKey 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TKey')  
Key to look up.
  
<a name='KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).defaultVal'></a>
`defaultVal` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
Value to return if [key](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).key 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).key') is not contained in the dictionary.
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TValue](UtilityExtensions.Get.ZzwAg6Gp3+BCfkvvK47eMQ.md#KeepCoding.UtilityExtensions.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.System.Nullable.TValue.).TValue 'KeepCoding.UtilityExtensions.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Nullable&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
