#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.BinarySearch&lt;TK,TV&gt;(SortedList&lt;TK,TV&gt;, TK, int, int) Method
Performs a binary search for the specified key on a [System.Collections.Generic.SortedList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedList-2 'System.Collections.Generic.SortedList`2'). When no match  
exists, returns the nearest indices for interpolation/extrapolation purposes.
```csharp
public static void BinarySearch<TK,TV>(this System.Collections.Generic.SortedList<TK,TV> list, TK key, out int index1, out int index2);
```
#### Type parameters
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_TK'></a>
`TK`  
  
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_TV'></a>
`TV`  
  
#### Parameters
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_list'></a>
`list` [System.Collections.Generic.SortedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedList-2 'System.Collections.Generic.SortedList`2')[TK](UtilityExtensions_BinarySearch_L_9N5cBW4QbvXp9q8CGMfg.md#KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_TK 'KeepCoding.UtilityExtensions.BinarySearch&lt;TK,TV&gt;(System.Collections.Generic.SortedList&lt;TK,TV&gt;, TK, int, int).TK')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedList-2 'System.Collections.Generic.SortedList`2')[TV](UtilityExtensions_BinarySearch_L_9N5cBW4QbvXp9q8CGMfg.md#KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_TV 'KeepCoding.UtilityExtensions.BinarySearch&lt;TK,TV&gt;(System.Collections.Generic.SortedList&lt;TK,TV&gt;, TK, int, int).TV')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedList-2 'System.Collections.Generic.SortedList`2')  
List to operate on.
  
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_key'></a>
`key` [TK](UtilityExtensions_BinarySearch_L_9N5cBW4QbvXp9q8CGMfg.md#KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_TK 'KeepCoding.UtilityExtensions.BinarySearch&lt;TK,TV&gt;(System.Collections.Generic.SortedList&lt;TK,TV&gt;, TK, int, int).TK')  
The key to look for.
  
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_index1'></a>
`index1` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Receives the value of the first index (see remarks).
  
<a name='KeepCoding_UtilityExtensions_BinarySearch_TK_TV_(System_Collections_Generic_SortedList_TK_TV__TK_int_int)_index2'></a>
`index2` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Receives the value of the second index (see remarks).
  
### Remarks
If an exact match exists, index1 == index2 == the index of the match. If an exact match is not found, index1  
< index2. If the key is less than every key in the list, index1 is int.MinValue and index2 is 0. If it's  
greater than every key, index1 = last item index and index2 = int.MaxValue. Otherwise index1 and index2 are  
the indices of the items that would surround the key were it present in the list.