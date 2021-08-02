#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.ForEach&lt;T&gt;(IEnumerator&lt;T&gt;, Action&lt;T&gt;) Method
The [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach') statement executes a statement or a block of statements for each element in an instance of the type that implements the [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') or [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') interface.  
```csharp
public static System.Collections.Generic.IEnumerable<T> ForEach<T>(this System.Collections.Generic.IEnumerator<T> iterator, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_T'></a>
`T`  
The type of iterator.
  
#### Parameters
<a name='KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_iterator'></a>
`iterator` [System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](KeyHelper_ForEach_A2+no700eDM_a04HmsE0hQ.md#KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
The collection of items to go through one-by-one.
  
<a name='KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper_ForEach_A2+no700eDM_a04HmsE0hQ.md#KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to do on each item in [iterator](KeyHelper_ForEach_A2+no700eDM_a04HmsE0hQ.md#KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_iterator 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, System.Action&lt;T&gt;).iterator').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeyHelper_ForEach_A2+no700eDM_a04HmsE0hQ.md#KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_T 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[iterator](KeyHelper_ForEach_A2+no700eDM_a04HmsE0hQ.md#KeepCoding_KeyHelper_ForEach_T_(System_Collections_Generic_IEnumerator_T__System_Action_T_)_iterator 'KeepCoding.KeyHelper.ForEach&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, System.Action&lt;T&gt;).iterator')
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement')
