#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Stringify&lt;T&gt;(T) Method
Converts [source](Helper.Stringify.lo+lkcxGY4HWoyqROvdnmA.md#KeepCoding.Helper.Stringify.T.(T).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](Helper.Stringify.lo+lkcxGY4HWoyqROvdnmA.md#KeepCoding.Helper.Stringify.T.(T).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source').  
```csharp
public static string Stringify<T>(this T source);
```
#### Type parameters
<a name='KeepCoding.Helper.Stringify.T.(T).T'></a>
`T`  
The format of the string.
  
#### Parameters
<a name='KeepCoding.Helper.Stringify.T.(T).source'></a>
`source` [T](Helper.Stringify.lo+lkcxGY4HWoyqROvdnmA.md#KeepCoding.Helper.Stringify.T.(T).T 'KeepCoding.Helper.Stringify&lt;T&gt;(T).T')  
The item to represent as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](Helper.Stringify.lo+lkcxGY4HWoyqROvdnmA.md#KeepCoding.Helper.Stringify.T.(T).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').
### Remarks
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the individual items inside [source](Helper.Stringify.lo+lkcxGY4HWoyqROvdnmA.md#KeepCoding.Helper.Stringify.T.(T).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T).source') if it is an iterator is deconstructed.  
