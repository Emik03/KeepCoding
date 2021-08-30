#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Lock&lt;T&gt;(T, Func&lt;T,T&gt;) Method
The [lock](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock') statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.  
```csharp
public static T Lock<T>(this T item, System.Func<T,T> func)
    where T : notnull;
```
#### Type parameters
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).T'></a>
`T`  
The type of item to lock.
  
#### Parameters
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).item'></a>
`item` [T](KeyHelper.Lock.eGoSquH0U8WjGVDb9hjSnw.md#KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
The item to lock.
  
<a name='KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Lock.eGoSquH0U8WjGVDb9hjSnw.md#KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeyHelper.Lock.eGoSquH0U8WjGVDb9hjSnw.md#KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to run while the item is locked.
  
#### Returns
[T](KeyHelper.Lock.eGoSquH0U8WjGVDb9hjSnw.md#KeepCoding.KeyHelper.Lock.T.(T.System.Func.T.T.).T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
` () ()`
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement')
