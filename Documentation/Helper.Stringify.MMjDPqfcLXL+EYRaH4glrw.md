#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](Helper.md 'KeepCoding.Helper')
## Helper.Stringify&lt;T&gt;(T, StringifyFormat) Method
Converts [source](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md#KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md#KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat).source').  
```csharp
public static string Stringify<T>(this T source, KeepCoding.StringifyFormat format=null);
```
#### Type parameters
<a name='KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).T'></a>
`T`  
The format of the string.
  
#### Parameters
<a name='KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).source'></a>
`source` [T](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md#KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).T 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat).T')  
The item to represent as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).format'></a>
`format` [StringifyFormat](StringifyFormat.md 'KeepCoding.StringifyFormat')  
Determines how it is formatted.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md#KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat).source') as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').
### Remarks
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the individual items inside [source](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md#KeepCoding.Helper.Stringify.T.(T.KeepCoding.StringifyFormat).source 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat).source') if it is an iterator is deconstructed.  
