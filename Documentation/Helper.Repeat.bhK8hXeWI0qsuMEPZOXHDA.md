#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Repeat&lt;T&gt;(int, Func&lt;int,T&gt;) Method
Creates an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') where each element gets passed in an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') in [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') and returns [T](Helper.Repeat.bhK8hXeWI0qsuMEPZOXHDA.md#KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).T 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;int,T&gt;).T').  
```csharp
public static System.Collections.Generic.IEnumerable<T> Repeat<T>(this int times, System.Func<int,T> func);
```
#### Type parameters
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).T'></a>
`T`  
The type of the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') as well as the return.
  
#### Parameters
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).times'></a>
`times` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of times to run the method.
  
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Helper.Repeat.bhK8hXeWI0qsuMEPZOXHDA.md#KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).T 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The encapsulated method to return for each value, passing in the index of the for-loop.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Repeat.bhK8hXeWI0qsuMEPZOXHDA.md#KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).T 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of length [times](Helper.Repeat.bhK8hXeWI0qsuMEPZOXHDA.md#KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).times 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;int,T&gt;).times') where each element is the return of [func](Helper.Repeat.bhK8hXeWI0qsuMEPZOXHDA.md#KeepCoding.Helper.Repeat.T.(int.System.Func.int.T.).func 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;int,T&gt;).func') after the index is passed in.
#### Exceptions
[NegativeNumberException](NegativeNumberException.md 'KeepCoding.Internal.NegativeNumberException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
