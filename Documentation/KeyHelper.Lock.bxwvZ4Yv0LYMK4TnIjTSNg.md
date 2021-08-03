#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Lock&lt;T&gt;(T, Action&lt;T&gt;) Method
The [lock](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock') statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.  
```csharp
public static T Lock<T>(this T item, System.Action<T> action);
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).T'></a>
`T`  
The type of item to lock.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).item'></a>
`item` [T](KeyHelper.Lock.bxwvZ4Yv0LYMK4TnIjTSNg.md#KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
The item to lock.
  
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeyHelper.Lock.bxwvZ4Yv0LYMK4TnIjTSNg.md#KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run while the item is locked.
  
#### Returns
[T](KeyHelper.Lock.bxwvZ4Yv0LYMK4TnIjTSNg.md#KeepCoding.KeyHelper.Lock.T.(T.System.Action.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Action&lt;T&gt;).T')  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement')
