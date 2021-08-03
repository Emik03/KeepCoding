#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork&lt;T&gt;(Func&lt;T&gt;) Method
Converts argument to a new [Work](Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work<T> ToWork<T>(this System.Func<T> func);
```
#### Type parameters
<a name='KeepCoding.TypeHelper.ToWork.T.(System.Func.T.).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.TypeHelper.ToWork.T.(System.Func.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](TypeHelper.ToWork.bd.qMU5RilhKYmZIGzGcGA.md#KeepCoding.TypeHelper.ToWork.T.(System.Func.T.).T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The action to run when the thread is active.
  
#### Returns
[KeepCoding.Work&lt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')[T](TypeHelper.ToWork.bd.qMU5RilhKYmZIGzGcGA.md#KeepCoding.TypeHelper.ToWork.T.(System.Func.T.).T 'KeepCoding.TypeHelper.ToWork&lt;T&gt;(System.Func&lt;T&gt;).T')[&gt;](Work.T..md 'KeepCoding.Work&lt;T&gt;')  
A new [Work](Work.md 'KeepCoding.Work') consisting of the arguments provided.
