#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.Get&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, TValue) Method
Gets a value from a dictionary by key. If the key does not exist in the dictionary, the default value is  
returned instead.
```csharp
public static TValue Get<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dict, TKey key, TValue defaultVal);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TKey'></a>
`TKey`  
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).dict'></a>
`dict` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TKey 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to operate on.
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).key'></a>
`key` [TKey](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TKey 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')  
Key to look up.
  
<a name='KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).defaultVal'></a>
`defaultVal` [TValue](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
Value to return if [key](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).key 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).key') is not contained in the dictionary.
  
#### Returns
[TValue](UtilityHelper.Get.+3kGLVqBsCPUkXnbduzGtQ.md#KeepCoding.UtilityHelper.Get.TKey.TValue.(System.Collections.Generic.IDictionary.TKey.TValue..TKey.TValue).TValue 'KeepCoding.UtilityHelper.Get&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
