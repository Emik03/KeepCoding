#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## CustomEqualityComparer&lt;T&gt; Class
Encapsulates an [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') that uses an equality comparison function provided as a delegate.  
```csharp
public sealed class CustomEqualityComparer<T> :
System.Collections.Generic.IEqualityComparer<T>
    where T : notnull
```
#### Type parameters
<a name='KeepCoding.CustomEqualityComparer.T..T'></a>
`T`  
The type of elements to be compared for equality.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomEqualityComparer&lt;T&gt;  

Implements [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](CustomEqualityComparer.T..md#KeepCoding.CustomEqualityComparer.T..T 'KeepCoding.CustomEqualityComparer&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  

| Constructors | |
| :--- | :--- |
| [CustomEqualityComparer(Func&lt;T,T,bool&gt;)](CustomEqualityComparer.T...ctor.zRNbCsfQNltM9Kin.3QMNg.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(System.Func&lt;T,T,bool&gt;)') | Constructor which re-uses the default hash function. Use this overload only if using the objects’ original hash function is appropriate for this equality comparison. |
| [CustomEqualityComparer(Func&lt;T,T,bool&gt;, Func&lt;T,int&gt;)](CustomEqualityComparer.T...ctor.1DeLBnL6MlzHx2hEdcJIsw.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.CustomEqualityComparer(System.Func&lt;T,T,bool&gt;, System.Func&lt;T,int&gt;)') | Constructor.<br/> |

| Methods | |
| :--- | :--- |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, IEqualityComparer&lt;TBy&gt;)](CustomEqualityComparer.T..By.BvAhc9LvZ8DD6tupa.e.1w.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Collections.Generic.IEqualityComparer&lt;TBy&gt;)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a selector function. |
| [By&lt;TBy&gt;(Func&lt;T,TBy&gt;, Func&lt;TBy,TBy,bool&gt;, Func&lt;TBy,int&gt;)](CustomEqualityComparer.T..By.NaY.MTgBmizkuXKs0A0duQ.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By&lt;TBy&gt;(System.Func&lt;T,TBy&gt;, System.Func&lt;TBy,TBy,bool&gt;, System.Func&lt;TBy,int&gt;)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a selector function.<br/> |
| [By(Func&lt;T,string&gt;, bool)](CustomEqualityComparer.T..By.mGGGKKXYFT0qFP1fyl58tA.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.By(System.Func&lt;T,string&gt;, bool)') | Creates and returns an equality comparer that compares the equality of objects by comparing the equality of<br/>the result of a string selector function.<br/> |
| [Equals(T, T)](CustomEqualityComparer.T..Equals.N.IRQTXiCfMCX9rGT+TsEw.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.Equals(T, T)') | Compares two elements for equality.<br/> |
| [GetHashCode(T)](CustomEqualityComparer.T..GetHashCode.mi65Yfvamjf2XDKqVTmyxg.md 'KeepCoding.CustomEqualityComparer&lt;T&gt;.GetHashCode(T)') | Returns a hash code for an element.<br/> |
