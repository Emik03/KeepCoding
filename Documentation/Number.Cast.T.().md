#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Number](Number.md 'KeepCoding.Number')
## Number.Cast&lt;T&gt;() Method
Casts the [Number](Number.md 'KeepCoding.Number') into the numeric type. Unlike implicit casting, the value will trim the bytes that cannot occupy the new datatype, such as a number being too large or decimals.  
```csharp
public T Cast<T>()
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.Number.Cast.T.().T'></a>
`T`  
  
#### Returns
[T](Number.Cast.T.().md#KeepCoding.Number.Cast.T.().T 'KeepCoding.Number.Cast&lt;T&gt;().T')  
Itself as [T](Number.Cast.T.().md#KeepCoding.Number.Cast.T.().T 'KeepCoding.Number.Cast&lt;T&gt;().T').
