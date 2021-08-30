#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T,TResult&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T,TResult> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding.Work.T.TResult..T'></a>
`T`  
  
<a name='KeepCoding.Work.T.TResult..TResult'></a>
`TResult`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T,TResult&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T,TResult&gt;)](Work.T.TResult...ctor.IhM9Nka2uNFv+mqgLKHytA.md 'KeepCoding.Work&lt;T,TResult&gt;.Work(System.Func&lt;T,TResult&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T,TResult&gt;, bool, int)](Work.T.TResult...ctor.d7j9Zs9ZUIcJzTmt5UREIQ.md 'KeepCoding.Work&lt;T,TResult&gt;.Work(System.Func&lt;T,TResult&gt;, bool, int)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](Work.T.TResult..Result.md 'KeepCoding.Work&lt;T,TResult&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start(T)](Work.T.TResult..Start.tK5OLTPYXaKL4NEh+W+ZrQ.md 'KeepCoding.Work&lt;T,TResult&gt;.Start(T)') | Starts a new thread, and waits until it is finished before halting.<br/> |
