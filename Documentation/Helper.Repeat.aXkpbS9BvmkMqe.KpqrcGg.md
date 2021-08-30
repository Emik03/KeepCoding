#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Repeat&lt;T&gt;(int, Func&lt;T&gt;) Method
Creates an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') where each element is the return of a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1').  
```csharp
public static System.Collections.Generic.IEnumerable<T> Repeat<T>(this int times, System.Func<T> func);
```
#### Type parameters
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.T.).T'></a>
`T`  
The type of the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') as well as the return.
  
#### Parameters
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.T.).times'></a>
`times` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The amount of times to run the method.
  
<a name='KeepCoding.Helper.Repeat.T.(int.System.Func.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](Helper.Repeat.aXkpbS9BvmkMqe.KpqrcGg.md#KeepCoding.Helper.Repeat.T.(int.System.Func.T.).T 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The encapsulated method to return for each value.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Helper.Repeat.aXkpbS9BvmkMqe.KpqrcGg.md#KeepCoding.Helper.Repeat.T.(int.System.Func.T.).T 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of length [times](Helper.Repeat.aXkpbS9BvmkMqe.KpqrcGg.md#KeepCoding.Helper.Repeat.T.(int.System.Func.T.).times 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;T&gt;).times') where each element is the return of [func](Helper.Repeat.aXkpbS9BvmkMqe.KpqrcGg.md#KeepCoding.Helper.Repeat.T.(int.System.Func.T.).func 'KeepCoding.Helper.Repeat&lt;T&gt;(int, System.Func&lt;T&gt;).func').
#### Exceptions
[NegativeNumberException](NegativeNumberException.md 'KeepCoding.Internal.NegativeNumberException')  
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
