#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleEvent&lt;T&gt; Class
A class that encapsulates an adder, getter, and setter, similar to a property.  
```csharp
public sealed class ModuleEvent<T> : KeepCoding.StrictRecord<KeepCoding.Tuple<KeepCoding.ModuleEvent<T>.Adder, KeepCoding.ModuleEvent<T>.Getter, KeepCoding.ModuleEvent<T>.Setter>, KeepCoding.ModuleEvent<T>>
```
#### Type parameters
<a name='KeepCoding.ModuleEvent.T..T'></a>
`T`  
The type of the inner variable on the getter.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [KeepCoding.StrictRecord&lt;](StrictRecord.T.TThis..md 'KeepCoding.StrictRecord&lt;T,TThis&gt;')[KeepCoding.Tuple&lt;](Tuple.T1.T2.T3..md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;')[KeepCoding.ModuleEvent.Adder&lt;](ModuleEvent.T..Adder.mC87pGoW7OVK88yenfaDIg.md 'KeepCoding.ModuleEvent&lt;T&gt;.Adder(T)')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Adder.mC87pGoW7OVK88yenfaDIg.md 'KeepCoding.ModuleEvent&lt;T&gt;.Adder(T)')[,](Tuple.T1.T2.T3..md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;')[KeepCoding.ModuleEvent.Getter&lt;](ModuleEvent.T..Getter().md 'KeepCoding.ModuleEvent&lt;T&gt;.Getter()')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Getter().md 'KeepCoding.ModuleEvent&lt;T&gt;.Getter()')[,](Tuple.T1.T2.T3..md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;')[KeepCoding.ModuleEvent.Setter&lt;](ModuleEvent.T..Setter.UlnkLh8H+Jmatb0VSAcVdQ.md 'KeepCoding.ModuleEvent&lt;T&gt;.Setter(T)')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Setter.UlnkLh8H+Jmatb0VSAcVdQ.md 'KeepCoding.ModuleEvent&lt;T&gt;.Setter(T)')[&gt;](Tuple.T1.T2.T3..md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;')[,](StrictRecord.T.TThis..md 'KeepCoding.StrictRecord&lt;T,TThis&gt;')[KeepCoding.ModuleEvent&lt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;')[&gt;](StrictRecord.T.TThis..md 'KeepCoding.StrictRecord&lt;T,TThis&gt;') &#129106; ModuleEvent&lt;T&gt;  

| Methods | |
| :--- | :--- |
| [Add(T)](ModuleEvent.T..Add.AQbeUSlPYiJFEQGoUQjXCQ.md 'KeepCoding.ModuleEvent&lt;T&gt;.Add(T)') | Subscribes an event to the inner [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate').<br/> |
| [Get()](ModuleEvent.T..Get().md 'KeepCoding.ModuleEvent&lt;T&gt;.Get()') | Gets the value of the inner [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate').<br/> |
| [New(Adder, Getter, Setter)](ModuleEvent.T..New.KCoNOVrAz9GU8Y9Ov3w8Jw.md 'KeepCoding.ModuleEvent&lt;T&gt;.New(KeepCoding.ModuleEvent&lt;T&gt;.Adder, KeepCoding.ModuleEvent&lt;T&gt;.Getter, KeepCoding.ModuleEvent&lt;T&gt;.Setter)') | Creates a new instance of [ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;') with the underlying type passed in.<br/> |
| [Set(T)](ModuleEvent.T..Set.MOpj2eoNtuqr7n3NuyLmRA.md 'KeepCoding.ModuleEvent&lt;T&gt;.Set(T)') | Sets the event to the inner [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate').<br/> |
| [Validate()](ModuleEvent.T..Validate().md 'KeepCoding.ModuleEvent&lt;T&gt;.Validate()') | Performs a null check on each entry in the tuple.<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator ModuleEvent&lt;T&gt;(Tuple&lt;Adder,Getter,Setter&gt;)](ModuleEvent.T..op_Implicit.kqGm5KRaj9HMRXfhhMs7Iw.md 'KeepCoding.ModuleEvent&lt;T&gt;.op_Implicit KeepCoding.ModuleEvent&lt;T&gt;(KeepCoding.Tuple&lt;KeepCoding.ModuleEvent&lt;T&gt;.Adder,KeepCoding.ModuleEvent&lt;T&gt;.Getter,KeepCoding.ModuleEvent&lt;T&gt;.Setter&gt;)') | Implicitly uses the constructor.<br/> |
| [implicit operator T(ModuleEvent&lt;T&gt;)](ModuleEvent.T..op_Implicit.IyS1yc1w7xgT3L6.uz1IOg.md 'KeepCoding.ModuleEvent&lt;T&gt;.op_Implicit T(KeepCoding.ModuleEvent&lt;T&gt;)') | Implicitly uses the getter.<br/> |
