#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ITuple Interface
Interface for tuple type.   
```csharp
public interface ITuple :
System.Collections.IEnumerable,
System.IEquatable<KeepCoding.ITuple>
```

Derived  
&#8627; [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase')  

Implements [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ITuple](KeepCoding_ITuple.md 'KeepCoding.ITuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Properties | |
| :--- | :--- |
| [Length](KeepCoding_ITuple_Length.md 'KeepCoding.ITuple.Length') | Gets the length of the tuple, describing the amount of elements there are.<br/> |
| [this[byte]](KeepCoding_ITuple_this_byte_.md 'KeepCoding.ITuple.this[byte]') | Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.<br/> |
| [ToArray](KeepCoding_ITuple_ToArray.md 'KeepCoding.ITuple.ToArray') | All of the tuple's items as an array, ordered by item number.<br/> |
| [UpperBound](KeepCoding_ITuple_UpperBound.md 'KeepCoding.ITuple.UpperBound') | Gets the upper bound of the tuple, which is the last index.<br/> |
