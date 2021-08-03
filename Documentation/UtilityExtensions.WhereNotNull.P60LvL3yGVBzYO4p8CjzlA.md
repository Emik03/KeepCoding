#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.WhereNotNull&lt;T&gt;(IEnumerable&lt;Nullable&lt;T&gt;&gt;) Method
Returns only the non-`null` elements from the specified collection of nullable values as non-nullable  
values.
```csharp
public static System.Collections.Generic.IEnumerable<T> WhereNotNull<T>(this System.Collections.Generic.IEnumerable<System.Nullable<T>> src)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityExtensions.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T'></a>
`T`  
The inner value type.
  
#### Parameters
<a name='KeepCoding.UtilityExtensions.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).src'></a>
`src` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](UtilityExtensions.WhereNotNull.P60LvL3yGVBzYO4p8CjzlA.md#KeepCoding.UtilityExtensions.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T 'KeepCoding.UtilityExtensions.WhereNotNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Nullable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of nullable values.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityExtensions.WhereNotNull.P60LvL3yGVBzYO4p8CjzlA.md#KeepCoding.UtilityExtensions.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T 'KeepCoding.UtilityExtensions.WhereNotNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Nullable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing only those values that aren’t `null`.
