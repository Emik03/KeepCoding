#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Is&lt;T&gt;(object, Action&lt;T&gt;, Action) Method
The [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is') operator checks if the result of an expression is compatible with a given type.  
```csharp
public static bool Is<T>(this object obj, System.Action<T> action, System.Action otherwise=null)
    where T : class;
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_T'></a>
`T`  
The type to cast into.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to cast.
  
<a name='KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action).md#KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when [obj](KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action).md#KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj') is item.
  
<a name='KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_otherwise'></a>
`otherwise` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when [obj](KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action).md#KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj') is not item..
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[obj](KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action).md#KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_obj 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).obj')[is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is')[T](KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action).md#KeepCoding_KeyHelper_Is_T_(object_System_Action_T__System_Action)_T 'KeepCoding.KeyHelper.Is&lt;T&gt;(object, System.Action&lt;T&gt;, System.Action).T')item
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is')
