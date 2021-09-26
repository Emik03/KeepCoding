#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.NullCheck&lt;T&gt;(Nullable&lt;T&gt;, string) Method
Throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException') or [NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException') if the parameter provided is null.  
```csharp
public static T NullCheck<T>(this System.Nullable<T> item, string message="While asserting for null, the variable ended up null.")
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).item'></a>
`item` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Helper.NullCheck.WPW2k033MuNu2pHfCX+HxA.md#KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).T 'KeepCoding.Helper.NullCheck&lt;T&gt;(System.Nullable&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The parameter to check null for.
  
<a name='KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional message to throw if null.
  
#### Returns
[T](Helper.NullCheck.WPW2k033MuNu2pHfCX+HxA.md#KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).T 'KeepCoding.Helper.NullCheck&lt;T&gt;(System.Nullable&lt;T&gt;, string).T')  
[item](Helper.NullCheck.WPW2k033MuNu2pHfCX+HxA.md#KeepCoding.Helper.NullCheck.T.(System.Nullable.T..string).item 'KeepCoding.Helper.NullCheck&lt;T&gt;(System.Nullable&lt;T&gt;, string).item')
#### Exceptions
[NullIteratorException](NullIteratorException.md 'KeepCoding.Internal.NullIteratorException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
