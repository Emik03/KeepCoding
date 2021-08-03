#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.SplitBy&lt;T&gt;(IEnumerable&lt;T&gt;, Predicate&lt;T&gt;) Method
Splits an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') in two based on a method provided.  
```csharp
public static KeepCoding.Tuple<System.Collections.Generic.IEnumerable<T>,System.Collections.Generic.IEnumerable<T>> SplitBy<T>(this System.Collections.Generic.IEnumerable<T> source, System.Predicate<T> predicate);
```
#### Type parameters
<a name='KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).T'></a>
`T`  
The type of the collection.
  
#### Parameters
<a name='KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection to split.
  
<a name='KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).predicate'></a>
`predicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The method that decides where the item ends up.
  
#### Returns
[KeepCoding.Tuple&lt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[,](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
A [Tuple&lt;T1,T2&gt;](Tuple.T1.T2..md 'KeepCoding.Tuple&lt;T1,T2&gt;') consisting of items from [source](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).source 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).source') where [Item1](Tuple.T..Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') contains items that returned true in [predicate](Helper.SplitBy.uwIOs+NPg6ZZ0tUJ82KnNw.md#KeepCoding.Helper.SplitBy.T.(System.Collections.Generic.IEnumerable.T..System.Predicate.T.).predicate 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).predicate'), and [Item2](Tuple.T1.T2..Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') otherwise.
