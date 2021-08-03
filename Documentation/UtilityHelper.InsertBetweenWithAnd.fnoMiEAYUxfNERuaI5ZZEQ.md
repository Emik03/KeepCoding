#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(IEnumerable&lt;T&gt;, T, T) Method
Inserts the [comma](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).comma 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).comma') item in between each element in the input collection except between the  
second-last and last, where it inserts [and](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).and 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).and') instead.
```csharp
public static System.Collections.Generic.IEnumerable<T> InsertBetweenWithAnd<T>(this System.Collections.Generic.IEnumerable<T> source, T comma, T and);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).T'></a>
`T`  
  
#### Parameters
<a name='KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).T 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The input collection.
  
<a name='KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).comma'></a>
`comma` [T](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).T 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')  
The element to insert between each consecutive pair of elements in the input collection except between the  
second-last and last.
  
<a name='KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).and'></a>
`and` [T](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).T 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')  
The element to insert between the second-last and last element of the input collection.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](UtilityHelper.InsertBetweenWithAnd.fnoMiEAYUxfNERuaI5ZZEQ.md#KeepCoding.UtilityHelper.InsertBetweenWithAnd.T.(System.Collections.Generic.IEnumerable.T..T.T).T 'KeepCoding.UtilityHelper.InsertBetweenWithAnd&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection containing the original collection with the extra element inserted. For example, new[] { "a",  
"b", "c" }.InsertBetweenWithAnd(", ", " and ") returns { "a", ", ", "b", " and ", "c" }.
