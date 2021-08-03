#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Indistinct&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Filters an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), only allowing duplicated items.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Indistinct<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters
<a name='KeepCoding.Helper.Indistinct.T.(System.Collections.Generic.IEnumerable.T.).T'></a>
`T`  
The type of the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').
  
#### Parameters
<a name='KeepCoding.Helper.Indistinct.T.(System.Collections.Generic.IEnumerable.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Indistinct.2oUqu.RHKtMVhlNG8dtySQ.md#KeepCoding.Helper.Indistinct.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to filter through.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Indistinct.2oUqu.RHKtMVhlNG8dtySQ.md#KeepCoding.Helper.Indistinct.T.(System.Collections.Generic.IEnumerable.T.).T 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A new instance of [source](Helper.Indistinct.2oUqu.RHKtMVhlNG8dtySQ.md#KeepCoding.Helper.Indistinct.T.(System.Collections.Generic.IEnumerable.T.).source 'KeepCoding.Helper.Indistinct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).source') that only includes elements which are repeated in the array.
