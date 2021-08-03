#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;, T) Method
Returns the first element from the input sequence for which the value selector returns the largest value, or a  
default value if the collection is empty.
```csharp
public static T MaxElementOrDefault<T,TValue>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,TValue> valueSelector, T defaultValue=default(T))
    where TValue : System.IComparable<TValue>;
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).T'></a>
`T`  
  
<a name='KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions.MaxElementOrDefault.b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).valueSelector'></a>
`valueSelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityExtensions.MaxElementOrDefault.b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](UtilityExtensions.MaxElementOrDefault.b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).TValue 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).defaultValue'></a>
`defaultValue` [T](UtilityExtensions.MaxElementOrDefault.b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')  
  
#### Returns
[T](UtilityExtensions.MaxElementOrDefault.b4MhBy8bOT0gJOP9nFtbrA.md#KeepCoding.UtilityExtensions.MaxElementOrDefault.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue..T).T 'KeepCoding.UtilityExtensions.MaxElementOrDefault&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;, T).T')  
