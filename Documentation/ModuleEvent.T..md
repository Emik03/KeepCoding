#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal')
## ModuleEvent&lt;T&gt; Class
A class that encapsulates an adder, getter, remover, and setter, similar to a property.  
```csharp
public sealed class ModuleEvent<T>
    where T : System.Delegate
```
#### Type parameters
<a name='KeepCoding.Internal.ModuleEvent.T..T'></a>
`T`  
The type of the inner variable on the getter.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModuleEvent&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [ModuleEvent(Adder, Getter, Remover, Setter, Signature, Converter)](ModuleEvent.T...ctor.C59AcEbVsTDDWX6NrG0qpg.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.ModuleEvent(KeepCoding.Internal.ModuleEvent&lt;T&gt;.Adder, KeepCoding.Internal.ModuleEvent&lt;T&gt;.Getter, KeepCoding.Internal.ModuleEvent&lt;T&gt;.Remover, KeepCoding.Internal.ModuleEvent&lt;T&gt;.Setter, KeepCoding.Internal.ModuleEvent&lt;T&gt;.Signature, KeepCoding.Internal.ModuleEvent&lt;T&gt;.Converter)') | Creates a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance of [ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;') with the underlying type passed in.<br/> |

| Methods | |
| :--- | :--- |
| [Add(T)](ModuleEvent.T..Add.uk2N8iM3TKttvRJOzi42hw.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Add(T)') | Subscribes an event to the inner value.<br/> |
| [Get()](ModuleEvent.T..Get().md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Get()') | Gets the value of the inner value.<br/> |
| [Remove(T)](ModuleEvent.T..Remove.60cEGy0YEat8+mYNloHT0g.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Remove(T)') | The remover operator.<br/> |
| [Set(T)](ModuleEvent.T..Set.XNwcyvf4Zc1m26mDIrAMQw.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Set(T)') | Sets the event to the inner value.<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator T(ModuleEvent&lt;T&gt;)](ModuleEvent.T..op_Implicit.8kj.jhDTnFuIHd1G0zhiWw.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.op_Implicit T(KeepCoding.Internal.ModuleEvent&lt;T&gt;)') | Implicitly uses the getter.<br/> |
