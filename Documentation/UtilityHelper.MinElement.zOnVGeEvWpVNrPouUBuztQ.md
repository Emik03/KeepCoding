#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MinElement&lt;T,TValue&gt;(IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;) Method
Returns the first element from the input sequence for which the value selector returns the smallest value.
```csharp
public static T MinElement<T,TValue>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,TValue> valueSelector)
    where TValue : System.IComparable<TValue>;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T'></a>
`T`  
  
<a name='KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.MinElement.zOnVGeEvWpVNrPouUBuztQ.md#KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T 'KeepCoding.UtilityHelper.MinElement&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).valueSelector'></a>
`valueSelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityHelper.MinElement.zOnVGeEvWpVNrPouUBuztQ.md#KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T 'KeepCoding.UtilityHelper.MinElement&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](UtilityHelper.MinElement.zOnVGeEvWpVNrPouUBuztQ.md#KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).TValue 'KeepCoding.UtilityHelper.MinElement&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[T](UtilityHelper.MinElement.zOnVGeEvWpVNrPouUBuztQ.md#KeepCoding.UtilityHelper.MinElement.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T 'KeepCoding.UtilityHelper.MinElement&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).T')  
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The input collection is empty.
