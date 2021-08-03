#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Randomize&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;int,int,int&gt;) Method
Shuffles a collection of items using a user-specified algorithm.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Randomize<T>(this System.Collections.Generic.IEnumerable<T> source, System.Func<int,int,int> randomizer);
```
#### Type parameters
<a name='KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).T'></a>
`T`  
The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to shuffle.
  
#### Parameters
<a name='KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Randomize.xC98EzUYAYqNzmxZFIQhkQ.md#KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).T 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to shuffle.
  
<a name='KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).randomizer'></a>
`randomizer` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The method to take the current and maximum indices, and return a new number to swap the current with.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Randomize.xC98EzUYAYqNzmxZFIQhkQ.md#KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).T 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[source](Helper.Randomize.xC98EzUYAYqNzmxZFIQhkQ.md#KeepCoding.Helper.Randomize.T.(System.Collections.Generic.IEnumerable.T..System.Func.int.int.int.).source 'KeepCoding.Helper.Randomize&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;int,int,int&gt;).source') in a random order.
