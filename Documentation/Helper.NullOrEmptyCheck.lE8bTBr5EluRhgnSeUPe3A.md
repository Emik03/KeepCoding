#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullOrEmptyCheck&lt;T&gt;(IEnumerator&lt;T&gt;, string) Method
Throws an exception if the [System.Collections.Generic.IEnumerator&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1') is null or empty.  
```csharp
public static System.Collections.Generic.IEnumerator<T> NullOrEmptyCheck<T>(this System.Collections.Generic.IEnumerator<T> source, string message=null);
```
#### Type parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerator.T..string).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerator.T..string).source'></a>
`source` [System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](Helper.NullOrEmptyCheck.lE8bTBr5EluRhgnSeUPe3A.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerator.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
The string to check for null and empty.
  
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerator.T..string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null or empty. Leaving it default will throw a default message.
  
#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](Helper.NullOrEmptyCheck.lE8bTBr5EluRhgnSeUPe3A.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerator.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Collections.Generic.IEnumerator&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  