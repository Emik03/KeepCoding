#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.Randomize&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;int,int,int&gt;) Method
Shuffles a collection of items using a user-specified algorithm.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Randomize<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<int,int,int> randomizer);
```
#### Type parameters
<a name='KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_T'></a>
`T`  
The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to shuffle.
  
#### Parameters
<a name='KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_).md#KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_T 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to shuffle.
  
<a name='KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_randomizer'></a>
`randomizer` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The method to take the current and maximum indices, and return a new number to swap the current with.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_).md#KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_T 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_).md#KeepCoding_Helper_Randomize_T_(System_Collections_Generic_IEnumerable_T__System_Func_int_int_int_)_source 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).source') in a random order.
