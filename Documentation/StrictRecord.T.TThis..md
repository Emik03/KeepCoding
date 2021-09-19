#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## StrictRecord&lt;T,TThis&gt; Class
Defines a reference type that provides built-in functionality for encapsulating data.  
```csharp
public abstract class StrictRecord<T,TThis>
    where TThis : KeepCoding.StrictRecord<T, TThis>, new()
```
#### Type parameters
<a name='KeepCoding.StrictRecord.T.TThis..T'></a>
`T`  
The type of data to encapsulate.
  
<a name='KeepCoding.StrictRecord.T.TThis..TThis'></a>
`TThis`  
The type that is encapsulating [T](StrictRecord.T.TThis..md#KeepCoding.StrictRecord.T.TThis..T 'KeepCoding.StrictRecord&lt;T,TThis&gt;.T').
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StrictRecord&lt;T,TThis&gt;  

Derived  
&#8627; [ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')  
&#8627; [ModuleEventDictionary](ModuleEvent.T..ModuleEventDictionary.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.ModuleEventDictionary')  
### Remarks
This class has been mostly taken from mcintyre321's ValueOf type. [https://github.com/mcintyre321/ValueOf](https://github.com/mcintyre321/ValueOf 'https://github.com/mcintyre321/ValueOf')

| Properties | |
| :--- | :--- |
| [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value') | The value to store.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(StrictRecord&lt;T,TThis&gt;)](StrictRecord.T.TThis..Equals.kdHJZ4Gm8.vWzKDZGbPNPA.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Equals(KeepCoding.StrictRecord&lt;T,TThis&gt;)') | Determines whether two records don't contain the same [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value').<br/> |
| [Equals(object)](StrictRecord.T.TThis..Equals.MsK5gctLXOI8KTo7GmmluQ.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Equals(object)') | Determines whether two records don't contain the same [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value').<br/> |
| [From(T)](StrictRecord.T.TThis..From.QbRwPjvPkDVG0GgsicVbtA.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.From(T)') | Creates a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance of [StrictRecord&lt;T,TThis&gt;](StrictRecord.T.TThis..md 'KeepCoding.StrictRecord&lt;T,TThis&gt;') from the specified [TThis](StrictRecord.T.TThis..md#KeepCoding.StrictRecord.T.TThis..TThis 'KeepCoding.StrictRecord&lt;T,TThis&gt;.TThis').<br/> |
| [GetHashCode()](StrictRecord.T.TThis..GetHashCode().md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.GetHashCode()') | Gets the hash code.<br/> |
| [ToString()](StrictRecord.T.TThis..ToString().md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.ToString()') | Uses [Stringify&lt;T&gt;(T, StringifyFormat)](Helper.Stringify.MMjDPqfcLXL+EYRaH4glrw.md 'KeepCoding.Helper.Stringify&lt;T&gt;(T, KeepCoding.StringifyFormat)') for the inner [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value').<br/> |
| [Validate()](StrictRecord.T.TThis..Validate().md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Validate()') | Called whenever [From(T)](StrictRecord.T.TThis..From.QbRwPjvPkDVG0GgsicVbtA.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.From(T)') is used. This method can be used to [throw](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw') invalid values.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(StrictRecord&lt;T,TThis&gt;, StrictRecord&lt;T,TThis&gt;)](StrictRecord.T.TThis..op_Equality.2gNCUbCeVzPXUBrRenqLEg.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.op_Equality(KeepCoding.StrictRecord&lt;T,TThis&gt;, KeepCoding.StrictRecord&lt;T,TThis&gt;)') | Determines whether two records contain the same [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value').<br/> |
| [implicit operator StrictRecord&lt;T,TThis&gt;(T)](StrictRecord.T.TThis..op_Implicit.fyavNvZPVPZo2HhC.r72IA.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.op_Implicit KeepCoding.StrictRecord&lt;T,TThis&gt;(T)') | Encapsulates [a](StrictRecord.T.TThis..op_Implicit.fyavNvZPVPZo2HhC.r72IA.md#KeepCoding.StrictRecord.T.TThis..op_ImplicitKeepCoding.StrictRecord.T.TThis.(T).a 'KeepCoding.StrictRecord&lt;T,TThis&gt;.op_Implicit KeepCoding.StrictRecord&lt;T,TThis&gt;(T).a') into a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance of [StrictRecord&lt;T,TThis&gt;](StrictRecord.T.TThis..md 'KeepCoding.StrictRecord&lt;T,TThis&gt;').<br/> |
| [operator !=(StrictRecord&lt;T,TThis&gt;, StrictRecord&lt;T,TThis&gt;)](StrictRecord.T.TThis..op_Inequality.87vCugQEZf.y6SAWCzryuQ.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.op_Inequality(KeepCoding.StrictRecord&lt;T,TThis&gt;, KeepCoding.StrictRecord&lt;T,TThis&gt;)') | Determines whether two records don't contain the same [Value](StrictRecord.T.TThis..Value.md 'KeepCoding.StrictRecord&lt;T,TThis&gt;.Value').<br/> |
