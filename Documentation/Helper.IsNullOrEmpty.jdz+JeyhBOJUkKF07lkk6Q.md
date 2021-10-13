#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.IsNullOrEmpty&lt;T&gt;(T) Method
Determines if the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') is null or empty.  
```csharp
public static bool IsNullOrEmpty<T>(this T source)
    where T : System.Collections.IEnumerable;
```
#### Type parameters
<a name='KeepCoding.Helper.IsNullOrEmpty.T.(T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.IsNullOrEmpty.T.(T).source'></a>
`source` [T](Helper.IsNullOrEmpty.jdz+JeyhBOJUkKF07lkk6Q.md#KeepCoding.Helper.IsNullOrEmpty.T.(T).T 'KeepCoding.Helper.IsNullOrEmpty&lt;T&gt;(T).T')  
The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to check for.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [source](Helper.IsNullOrEmpty.jdz+JeyhBOJUkKF07lkk6Q.md#KeepCoding.Helper.IsNullOrEmpty.T.(T).source 'KeepCoding.Helper.IsNullOrEmpty&lt;T&gt;(T).source') is equal to null, or empty.
