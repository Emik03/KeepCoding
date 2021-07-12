### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Cast&lt;T&gt;(Delegate) Method
Casts a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') onto the type [T](KeepCoding_EventHelper_Cast_T_(System_Delegate).md#KeepCoding_EventHelper_Cast_T_(System_Delegate)_T 'KeepCoding.EventHelper.Cast&lt;T&gt;(System.Delegate).T').  
```csharp
public static T Cast<T>(this System.Delegate dele)
    where T : System.Delegate;
```
#### Type parameters
<a name='KeepCoding_EventHelper_Cast_T_(System_Delegate)_T'></a>
`T`  
The type to cast the delegate into.
  
#### Parameters
<a name='KeepCoding_EventHelper_Cast_T_(System_Delegate)_dele'></a>
`dele` [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
The delegate to cast.
  
#### Returns
[T](KeepCoding_EventHelper_Cast_T_(System_Delegate).md#KeepCoding_EventHelper_Cast_T_(System_Delegate)_T 'KeepCoding.EventHelper.Cast&lt;T&gt;(System.Delegate).T')  
[dele](KeepCoding_EventHelper_Cast_T_(System_Delegate).md#KeepCoding_EventHelper_Cast_T_(System_Delegate)_dele 'KeepCoding.EventHelper.Cast&lt;T&gt;(System.Delegate).dele') as [T](KeepCoding_EventHelper_Cast_T_(System_Delegate).md#KeepCoding_EventHelper_Cast_T_(System_Delegate)_T 'KeepCoding.EventHelper.Cast&lt;T&gt;(System.Delegate).T').
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
Both types must have the same parameter and return types, and the [dele](KeepCoding_EventHelper_Cast_T_(System_Delegate).md#KeepCoding_EventHelper_Cast_T_(System_Delegate)_dele 'KeepCoding.EventHelper.Cast&lt;T&gt;(System.Delegate).dele') argument cannot have its [System.Delegate.Target](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate.Target 'System.Delegate.Target') or [System.Delegate.Method](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate.Method 'System.Delegate.Method') be null.  
