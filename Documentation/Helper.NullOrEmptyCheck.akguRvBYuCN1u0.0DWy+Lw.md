#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullOrEmptyCheck&lt;T&gt;(IEnumerable&lt;T&gt;, string) Method
Throws an exception if the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') is null or empty.  
```csharp
public static System.Collections.Generic.IEnumerable<T> NullOrEmptyCheck<T>(this System.Collections.Generic.IEnumerable<T> source, string message=null);
```
#### Type parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerable.T..string).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerable.T..string).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.NullOrEmptyCheck.akguRvBYuCN1u0.0DWy+Lw.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerable.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to check for null and empty.
  
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerable.T..string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null or empty. Leaving it default will throw a default message.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.NullOrEmptyCheck.akguRvBYuCN1u0.0DWy+Lw.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Collections.Generic.IEnumerable.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
