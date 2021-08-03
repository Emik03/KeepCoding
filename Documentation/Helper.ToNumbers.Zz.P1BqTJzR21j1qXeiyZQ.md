#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.ToNumbers&lt;T&gt;(T[], Nullable&lt;int&gt;, Nullable&lt;int&gt;, Nullable&lt;int&gt;, Nullable&lt;int&gt;) Method
Parses each element of an array into a number. If it succeeds it returns the integer array, if it fails then it returns null.  
```csharp
public static int[] ToNumbers<T>(this T[] ts, System.Nullable<int> min=null, System.Nullable<int> max=null, System.Nullable<int> minLength=null, System.Nullable<int> maxLength=null);
```
#### Type parameters
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).ts'></a>
`ts` [T](Helper.ToNumbers.Zz.P1BqTJzR21j1qXeiyZQ.md#KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).T 'KeepCoding.Helper.ToNumbers&lt;T&gt;(T[], System.Nullable&lt;int&gt;, System.Nullable&lt;int&gt;, System.Nullable&lt;int&gt;, System.Nullable&lt;int&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array to convert to an integer.
  
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).min'></a>
`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum acceptable value of any given index. (inclusive)
  
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).max'></a>
`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum acceptable value of any given index. (inclusive)
  
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).minLength'></a>
`minLength` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum acceptable length of the array. (inclusive)
  
<a name='KeepCoding.Helper.ToNumbers.T.(T...System.Nullable.int..System.Nullable.int..System.Nullable.int..System.Nullable.int.).maxLength'></a>
`maxLength` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum acceptable length of the array. (inclusive)
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array as integers, or null if it fails.
