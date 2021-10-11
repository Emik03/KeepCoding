#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.JoinString&lt;T&gt;(IEnumerable&lt;T&gt;, string, string, string, string) Method
Turns all elements in the enumerable to strings and joins them using the specified [separator](UtilityHelper.JoinString.yVMDP77eaow4exlTI16IEg.md#KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).separator 'KeepCoding.UtilityHelper.JoinString&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string, string, string).separator') and the specified [prefix](UtilityHelper.JoinString.yVMDP77eaow4exlTI16IEg.md#KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).prefix 'KeepCoding.UtilityHelper.JoinString&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string, string, string).prefix') and [suffix](UtilityHelper.JoinString.yVMDP77eaow4exlTI16IEg.md#KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).suffix 'KeepCoding.UtilityHelper.JoinString&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string, string, string).suffix') for each string.
```csharp
public static string JoinString<T>(this System.Collections.Generic.IEnumerable<T> values, string separator=null, string prefix=null, string suffix=null, string lastSeparator=null);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).values'></a>
`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.JoinString.yVMDP77eaow4exlTI16IEg.md#KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).T 'KeepCoding.UtilityHelper.JoinString&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string, string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequence of elements to join into a string.
  
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).separator'></a>
`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Optionally, a separator to insert between each element and the next.
  
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).prefix'></a>
`prefix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Optionally, a string to insert in front of each element.
  
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).suffix'></a>
`suffix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Optionally, a string to insert after each element.
  
<a name='KeepCoding.UtilityHelper.JoinString.T.(System.Collections.Generic.IEnumerable.T..string.string.string.string).lastSeparator'></a>
`lastSeparator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Optionally, a separator to use between the second-to-last and the last element.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
### Example
```csharp
// Returns "[Paris], [London], [Tokyo]"
(new[] { "Paris", "London", "Tokyo" }).JoinString(", ", "[", "]")

// Returns "[Paris], [London] and [Tokyo]"
(new[] { "Paris", "London", "Tokyo" }).JoinString(", ", "[", "]", " and ");```
