#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.MaxIndexOrNull&lt;T,TValue&gt;(IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;) Method
Returns the index of the first element from the input sequence for which the value selector returns the  
largest value, or a default value if the collection is empty.
```csharp
public static System.Nullable<int> MaxIndexOrNull<T,TValue>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,TValue> valueSelector)
    where TValue : System.IComparable<TValue>;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T'></a>
`T`  
  
<a name='KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).TValue'></a>
`TValue`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.MaxIndexOrNull.HkZLj7Cv9lu.QXiRXgdw5w.md#KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T 'KeepCoding.UtilityHelper.MaxIndexOrNull&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).valueSelector'></a>
`valueSelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](UtilityHelper.MaxIndexOrNull.HkZLj7Cv9lu.QXiRXgdw5w.md#KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).T 'KeepCoding.UtilityHelper.MaxIndexOrNull&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](UtilityHelper.MaxIndexOrNull.HkZLj7Cv9lu.QXiRXgdw5w.md#KeepCoding.UtilityHelper.MaxIndexOrNull.T.TValue.(System.Collections.Generic.IEnumerable.T..System.Func.T.TValue.).TValue 'KeepCoding.UtilityHelper.MaxIndexOrNull&lt;T,TValue&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
