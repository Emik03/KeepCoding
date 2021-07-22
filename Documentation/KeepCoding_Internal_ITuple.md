#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding_Internal.md 'KeepCoding.Internal')
## ITuple Interface
Interface for tuple type.   
```csharp
public interface ITuple :
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.Internal.ITuple>
```

Derived  
&#8627; [TupleBase](KeepCoding_Internal_TupleBase.md 'KeepCoding.Internal.TupleBase')  

Implements [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ITuple](KeepCoding_Internal_ITuple.md 'KeepCoding.Internal.ITuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Properties | |
| :--- | :--- |
| [Length](KeepCoding_Internal_ITuple_Length.md 'KeepCoding.Internal.ITuple.Length') | Gets the length of the tuple, describing the amount of elements there are.<br/> |
| [this[byte]](KeepCoding_Internal_ITuple_this_byte_.md 'KeepCoding.Internal.ITuple.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](KeepCoding_Internal_ITuple_ToArray.md 'KeepCoding.Internal.ITuple.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |
| [UpperBound](KeepCoding_Internal_ITuple_UpperBound.md 'KeepCoding.Internal.ITuple.UpperBound') | Gets the upper bound of the tuple, which is the last index.<br/> |
