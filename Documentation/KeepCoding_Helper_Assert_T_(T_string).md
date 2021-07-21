#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Assert&lt;T&gt;(T, string) Method
Throws a [UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException') if the [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') given is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then returning the [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object')[obj](KeepCoding_Helper_Assert_T_(T_string).md#KeepCoding_Helper_Assert_T_(T_string)_obj 'KeepCoding.Helper.Assert&lt;T&gt;(T, string).obj').  
```csharp
public static T Assert<T>(this T obj, string message="While asserting for null, the variable ended up null.")
    where T : UnityEngine.Object;
```
#### Type parameters
<a name='KeepCoding_Helper_Assert_T_(T_string)_T'></a>
`T`  
The type of [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object').
  
#### Parameters
<a name='KeepCoding_Helper_Assert_T_(T_string)_obj'></a>
`obj` [T](KeepCoding_Helper_Assert_T_(T_string).md#KeepCoding_Helper_Assert_T_(T_string)_T 'KeepCoding.Helper.Assert&lt;T&gt;(T, string).T')  
The [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') to do a null check on.
  
<a name='KeepCoding_Helper_Assert_T_(T_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message of the exception.
  
#### Returns
[T](KeepCoding_Helper_Assert_T_(T_string).md#KeepCoding_Helper_Assert_T_(T_string)_T 'KeepCoding.Helper.Assert&lt;T&gt;(T, string).T')  
The component [obj](KeepCoding_Helper_Assert_T_(T_string).md#KeepCoding_Helper_Assert_T_(T_string)_obj 'KeepCoding.Helper.Assert&lt;T&gt;(T, string).obj').
