#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.FirstOrDefault&lt;T&gt;(IEnumerable&lt;T&gt;, T) Method
Returns the first element of a sequence, or a default value if the sequence contains no elements.
```csharp
public static T FirstOrDefault<T>(this System.Collections.Generic.IEnumerable<T> source, T @default);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_T'></a>
`T`  
The type of the elements of [source](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source').
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to return the first element of.
  
<a name='KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_default'></a>
`default` [T](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
The default value to return if the sequence contains no elements.
  
#### Returns
[T](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_T 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).T')  
[default](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_default 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).default') if [source](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source') is empty; otherwise, the first element in [source](UtilityExtensions_FirstOrDefault_oY6agyAUg+acbOIViOox3A.md#KeepCoding_UtilityExtensions_FirstOrDefault_T_(System_Collections_Generic_IEnumerable_T__T)_source 'KeepCoding.UtilityExtensions.FirstOrDefault&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T).source').
