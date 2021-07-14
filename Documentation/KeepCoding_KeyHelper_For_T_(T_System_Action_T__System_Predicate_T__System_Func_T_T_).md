#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.For&lt;T&gt;(T, Action&lt;T&gt;, Predicate&lt;T&gt;, Func&lt;T,T&gt;) Method
The [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for') statement executes a statement or a block of statements while a specified Boolean expression evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
```csharp
public static T For<T>(this T item, System.Action<T> action, System.Predicate<T> condition=null, System.Func<T,T> loop=null);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T'></a>
`T`  
The type of the declaring variable.
  
#### Parameters
<a name='KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_item'></a>
`item` [T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')  
The item to read and write on.
  
<a name='KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action for each loop.
  
<a name='KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_condition'></a>
`condition` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The condition for whether the loop should continue.
  
<a name='KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_loop'></a>
`loop` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The action to run after [action](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_action 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).action').
  
#### Returns
[T](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_T 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).T')  
[item](KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_).md#KeepCoding_KeyHelper_For_T_(T_System_Action_T__System_Predicate_T__System_Func_T_T_)_item 'KeepCoding.KeyHelper.For&lt;T&gt;(T, System.Action&lt;T&gt;, System.Predicate&lt;T&gt;, System.Func&lt;T,T&gt;).item')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement')
