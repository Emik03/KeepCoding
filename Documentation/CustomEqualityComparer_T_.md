#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## CustomEqualityComparer&lt;T&gt; Class
Encapsulates an IEqualityComparer<T> that uses an equality comparison function provided as a delegate.
```csharp
public sealed class CustomEqualityComparer<T> :
System.Collections.Generic.IEqualityComparer<T>
```
#### Type parameters
<a name='KeepCoding_CustomEqualityComparer_T__T'></a>
`T`  
The type of elements to be compared for equality.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomEqualityComparer&lt;T&gt;  

Implements [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](CustomEqualityComparer_T_.md#KeepCoding_CustomEqualityComparer_T__T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  

| Constructors | |
| :--- | :--- |
| [CustomEqualityComparer(Func&lt;T,T,bool&gt;)](CustomEqualityComparer_T___ctor_zRNbCsfQNltM9Kin_3QMNg.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(System.Func&lt;T,T,bool&gt;)') | Constructor which re-uses the default hash function. Use this overload only if using the objects’ original<br/>hash function is appropriate for this equality comparison. |
| [CustomEqualityComparer(Func&lt;T,T,bool&gt;, Func&lt;T,int&gt;)](CustomEqualityComparer_T___ctor_1DeLBnL6MlzHx2hEdcJIsw.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(System.Func&lt;T,T,bool&gt;, System.Func&lt;T,int&gt;)') | Constructor. |

| Methods | |
| :--- | :--- |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IEqualityComparer&lt;TBy&gt;)](CustomEqualityComparer_T__By_BvAhc9LvZ8DD6tupa_e_1w.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a selector function. |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Func&lt;TBy,TBy,bool&gt;, Func&lt;TBy,int&gt;)](CustomEqualityComparer_T__By_NaY_MTgBmizkuXKs0A0duQ.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a selector function. |
| [By(Func&lt;T,string&gt;, bool)](CustomEqualityComparer_T__By_mGGGKKXYFT0qFP1fyl58tA.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By(System.Func&lt;T,string&gt;, bool)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a string selector function. |
| [Equals(T, T)](CustomEqualityComparer_T__Equals_N_IRQTXiCfMCX9rGT+TsEw.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.Equals(T, T)') | Compares two elements for equality. |
| [GetHashCode(T)](CustomEqualityComparer_T__GetHashCode_mi65Yfvamjf2XDKqVTmyxg.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.GetHashCode(T)') | Returns a hash code for an element. |
