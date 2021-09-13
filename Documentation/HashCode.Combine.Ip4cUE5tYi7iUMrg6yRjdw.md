#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[HashCode](HashCode.md 'KeepCoding.HashCode')
## HashCode.Combine&lt;T1&gt;(T1) Method
Diffuses the hash code returned by the specified value.  
```csharp
public static int Combine<T1>(T1 value1);
```
#### Type parameters
<a name='KeepCoding.HashCode.Combine.T1.(T1).T1'></a>
`T1`  
The type of the value to add the hash code.
  
#### Parameters
<a name='KeepCoding.HashCode.Combine.T1.(T1).value1'></a>
`value1` [T1](HashCode.Combine.Ip4cUE5tYi7iUMrg6yRjdw.md#KeepCoding.HashCode.Combine.T1.(T1).T1 'KeepCoding.HashCode.Combine&lt;T1&gt;(T1).T1')  
The value to add to the hash code.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The hash code that represents the single value.
### Remarks
Some data structures assume that hash codes are diffused across a large range. This method improves the quality of the hash code returned by the value and is useful when the underlying data type is simple, for example, an integer value.  
