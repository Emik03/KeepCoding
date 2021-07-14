#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.CreateDelegate&lt;T&gt;(Delegate) Method
Creates a delegate of the specified type.  
```csharp
public static T CreateDelegate<T>(this System.Delegate dele)
    where T : System.Delegate;
```
#### Type parameters
<a name='KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate)_T'></a>
`T`  
The type of delegate to create.
  
#### Parameters
<a name='KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate)_dele'></a>
`dele` [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
The delegate to reference from.
  
#### Returns
[T](KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate).md#KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate)_T 'KeepCoding.EventHelper.CreateDelegate&lt;T&gt;(System.Delegate).T')  
A delegate of type [T](KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate).md#KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate)_T 'KeepCoding.EventHelper.CreateDelegate&lt;T&gt;(System.Delegate).T') using [dele](KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate).md#KeepCoding_EventHelper_CreateDelegate_T_(System_Delegate)_dele 'KeepCoding.EventHelper.CreateDelegate&lt;T&gt;(System.Delegate).dele')'s target and method.
