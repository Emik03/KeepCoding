#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullOrEmptyCheck&lt;T&gt;(Nullable&lt;T&gt;, string) Method
Throws an exception if the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') is null or empty.  
```csharp
public static T NullOrEmptyCheck<T>(this System.Nullable<T> source, string message=null)
    where T : struct, System.Collections.IEnumerable;
```
#### Type parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Nullable.T..string).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Nullable.T..string).source'></a>
`source` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Helper.NullOrEmptyCheck.zHO1WbUJdCwTLje3xx8xxg.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Nullable.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Nullable&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to check for null and empty.
  
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(System.Nullable.T..string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null or empty. Leaving it default will throw a default message.
  
#### Returns
[T](Helper.NullOrEmptyCheck.zHO1WbUJdCwTLje3xx8xxg.md#KeepCoding.Helper.NullOrEmptyCheck.T.(System.Nullable.T..string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(System.Nullable&lt;T&gt;, string).T')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
