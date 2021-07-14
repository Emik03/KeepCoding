#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ITP](KeepCoding_ITP.md 'KeepCoding.ITP')
## ITP.ForceSolve() Method
When the module runs into an exception or the module is forced to be solved, it calls this method.  
```csharp
System.Collections.IEnumerator ForceSolve();
```
#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.
### Remarks
Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.  
