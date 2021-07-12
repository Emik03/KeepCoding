### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Lock&lt;T&gt;(T, Func&lt;T,T&gt;) Method
The [lock](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock') statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.  
```csharp
public static T Lock<T>(this T item, System.Func<T,T> func);
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_T'></a>
`T`  
The type of item to lock.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_item'></a>
`item` [T](KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
The item to lock.
  
<a name='KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to run while the item is locked.
  
#### Returns
[T](KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_T 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).T')  
The output of [func](KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_).md#KeepCoding_KeyHelper_Lock_T_(T_System_Func_T_T_)_func 'KeepCoding.KeyHelper.Lock&lt;T&gt;(T, System.Func&lt;T,T&gt;).func').
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement')
