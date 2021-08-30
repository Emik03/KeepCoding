#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullOrEmptyCheck&lt;T&gt;(T, string) Method
Throws an exception if the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') is null or empty.  
```csharp
public static T NullOrEmptyCheck<T>(this T source, string message=null)
    where T : System.Collections.IEnumerable;
```
#### Type parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(T.string).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(T.string).source'></a>
`source` [T](Helper.NullOrEmptyCheck.xDH6mzizch.P3V3r6GQujA.md#KeepCoding.Helper.NullOrEmptyCheck.T.(T.string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(T, string).T')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to check for null and empty.
  
<a name='KeepCoding.Helper.NullOrEmptyCheck.T.(T.string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null or empty. Leaving it default will throw a default message.
  
#### Returns
[T](Helper.NullOrEmptyCheck.xDH6mzizch.P3V3r6GQujA.md#KeepCoding.Helper.NullOrEmptyCheck.T.(T.string).T 'KeepCoding.Helper.NullOrEmptyCheck&lt;T&gt;(T, string).T')  
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[EmptyIteratorException](EmptyIteratorException.md 'KeepCoding.Internal.EmptyIteratorException')  
