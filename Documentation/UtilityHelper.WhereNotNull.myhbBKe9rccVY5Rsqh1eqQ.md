#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.WhereNotNull&lt;T&gt;(IEnumerable&lt;Nullable&lt;T&gt;&gt;) Method
Returns only the non-`null` elements from the specified collection of nullable values as non-nullable  
values.
```csharp
public static System.Collections.Generic.IEnumerable<T> WhereNotNull<T>(this System.Collections.Generic.IEnumerable<System.Nullable<T>> src)
    where T : struct;
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T'></a>
`T`  
The inner value type.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).src'></a>
`src` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](UtilityHelper.WhereNotNull.myhbBKe9rccVY5Rsqh1eqQ.md#KeepCoding.UtilityHelper.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T 'KeepCoding.UtilityHelper.WhereNotNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Nullable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of nullable values.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.WhereNotNull.myhbBKe9rccVY5Rsqh1eqQ.md#KeepCoding.UtilityHelper.WhereNotNull.T.(System.Collections.Generic.IEnumerable.System.Nullable.T..).T 'KeepCoding.UtilityHelper.WhereNotNull&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Nullable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing only those values that aren’t `null`.
