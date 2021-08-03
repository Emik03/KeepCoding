#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[EventHelper](EventHelper.md 'KeepCoding.EventHelper')
## EventHelper.Set&lt;T&gt;(Delegate, T) Method
Adds a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') onto the referenced variable.  
```csharp
public static System.Delegate Set<T>(this System.Delegate dele, ref T mutator)
    where T : System.Delegate;
```
#### Type parameters
<a name='KeepCoding.EventHelper.Set.T.(System.Delegate.T).T'></a>
`T`  
The type of the [mutator](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).mutator 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).mutator') and [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') casting.
  
#### Parameters
<a name='KeepCoding.EventHelper.Set.T.(System.Delegate.T).dele'></a>
`dele` [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to add.
  
<a name='KeepCoding.EventHelper.Set.T.(System.Delegate.T).mutator'></a>
`mutator` [T](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).T 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).T')  
The variable that transmutates and adds [dele](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele') onto itself.
  
#### Returns
[System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate')  
[mutator](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).mutator 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).mutator') with the value [dele](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele'), or itself if [dele](EventHelper.Set.gzJWq5LaZNo3iVcLAujwaA.md#KeepCoding.EventHelper.Set.T.(System.Delegate.T).dele 'KeepCoding.EventHelper.Set&lt;T&gt;(System.Delegate, T).dele') is null.
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
