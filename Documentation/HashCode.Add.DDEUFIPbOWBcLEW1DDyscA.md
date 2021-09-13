#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[HashCode](HashCode.md 'KeepCoding.HashCode')
## HashCode.Add&lt;T&gt;(T, IEqualityComparer&lt;T&gt;) Method
Adds a single value to the hash code, specifying the type that provides the hash code function.  
```csharp
public void Add<T>(T value, System.Collections.Generic.IEqualityComparer<T> comparer);
```
#### Type parameters
<a name='KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).T'></a>
`T`  
The type of the value to add to the hash code.
  
#### Parameters
<a name='KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).value'></a>
`value` [T](HashCode.Add.DDEUFIPbOWBcLEW1DDyscA.md#KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.HashCode.Add&lt;T&gt;(T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')  
The value to add to the hash code.
  
<a name='KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](HashCode.Add.DDEUFIPbOWBcLEW1DDyscA.md#KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.HashCode.Add&lt;T&gt;(T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
The [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') to use to calculate the hash code. This value can be a null reference (Nothing in Visual Basic), which will use the default equality comparer for [T](HashCode.Add.DDEUFIPbOWBcLEW1DDyscA.md#KeepCoding.HashCode.Add.T.(T.System.Collections.Generic.IEqualityComparer.T.).T 'KeepCoding.HashCode.Add&lt;T&gt;(T, System.Collections.Generic.IEqualityComparer&lt;T&gt;).T').
  
