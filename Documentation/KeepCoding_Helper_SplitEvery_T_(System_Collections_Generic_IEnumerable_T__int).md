### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.SplitEvery&lt;T&gt;(IEnumerable&lt;T&gt;, int) Method
Chops the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') into multiple [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')s, based on the length provided.  
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> SplitEvery<T>(this System.Collections.Generic.IEnumerable<T> source, int length);
```
#### Type parameters
<a name='KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_T'></a>
`T`  
The type of [source](KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_source 'KeepCoding.Helper.SplitEvery&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).source').
  
#### Parameters
<a name='KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.Helper.SplitEvery&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to split.
  
<a name='KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of each [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') within the containing [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_T 'KeepCoding.Helper.SplitEvery&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')s, where each [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') is as long as [length](KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int).md#KeepCoding_Helper_SplitEvery_T_(System_Collections_Generic_IEnumerable_T__int)_length 'KeepCoding.Helper.SplitEvery&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).length').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
