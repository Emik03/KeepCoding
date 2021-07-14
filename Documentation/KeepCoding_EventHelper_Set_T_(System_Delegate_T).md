#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Set&lt;T&gt;(Delegate, T) Method
Adds a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') onto the referenced variable.  
```csharp
public static System.Delegate Set<T>(this System.Delegate dele, ref T mutator)
    where T : System.Delegate;
```
#### Type parameters
<a name='KeepCoding_EventHelper_Set_T_(System_Delegate_T)_T'></a>
`T`  
The type of the [mutator](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_mutator 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).mutator') and [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') casting.
  
#### Parameters
<a name='KeepCoding_EventHelper_Set_T_(System_Delegate_T)_dele'></a>
`dele` [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to add.
  
<a name='KeepCoding_EventHelper_Set_T_(System_Delegate_T)_mutator'></a>
`mutator` [T](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_T 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).T')  
The variable that transmutates and adds [dele](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele') onto itself.
  
#### Returns
[System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
[mutator](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_mutator 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).mutator') with the value [dele](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele'), or itself if [dele](KeepCoding_EventHelper_Set_T_(System_Delegate_T).md#KeepCoding_EventHelper_Set_T_(System_Delegate_T)_dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele') is null.
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
