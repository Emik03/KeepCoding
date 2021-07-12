### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.ForceSolve() Method
When the module runs into an exception or the module is forced to be solved, it calls this method.  
```csharp
public abstract System.Collections.IEnumerator ForceSolve();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.

Implements [ForceSolve()](KeepCoding_ITP_ForceSolve().md 'KeepCoding.ITP.ForceSolve()')  
### Remarks
Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.  
