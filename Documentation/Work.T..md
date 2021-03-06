#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## Work&lt;T&gt; Class
Advanced multi-threading handler.  
```csharp
public sealed class Work<T> : KeepCoding.Internal.WorkBase
```
#### Type parameters
<a name='KeepCoding.Work.T..T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [WorkBase](WorkBase.md 'KeepCoding.Internal.WorkBase') &#129106; Work&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [Work(Func&lt;T&gt;)](Work.T...ctor.gHsYqRUIGrPKtEiVcqmAiQ.md 'KeepCoding.Work&lt;T&gt;.Work(System.Func&lt;T&gt;)') | Stores the method so that it can later be called when a new thread starts. Multiple simultaneous threads are allowed, but are queued and limited to one at-a-time.<br/> |
| [Work(Func&lt;T&gt;, bool, int)](Work.T...ctor.k62FOhEM5trOzkqeYz3LVw.md 'KeepCoding.Work&lt;T&gt;.Work(System.Func&lt;T&gt;, bool, int)') | Stores the method so that it can later be called when a new thread starts.<br/> |

| Properties | |
| :--- | :--- |
| [Result](Work.T..Result.md 'KeepCoding.Work&lt;T&gt;.Result') | The returned value of the thread.<br/> |

| Methods | |
| :--- | :--- |
| [Start()](Work.T..Start().md 'KeepCoding.Work&lt;T&gt;.Start()') | Starts a new thread, and waits until it is finished before halting.<br/> |
