#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;')
## ModuleEvent&lt;T&gt;.New(Adder, Getter, Setter) Method
Creates a new instance of [ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;') with the underlying type passed in.  
```csharp
public static KeepCoding.ModuleEvent<T> New(KeepCoding.ModuleEvent<T>.Adder adder, KeepCoding.ModuleEvent<T>.Getter getter, KeepCoding.ModuleEvent<T>.Setter setter);
```
#### Parameters
<a name='KeepCoding.ModuleEvent.T..New(KeepCoding.ModuleEvent.T..Adder.KeepCoding.ModuleEvent.T..Getter.KeepCoding.ModuleEvent.T..Setter).adder'></a>
`adder` [KeepCoding.ModuleEvent.Adder&lt;](ModuleEvent.T..Adder.mC87pGoW7OVK88yenfaDIg.md 'KeepCoding.ModuleEvent&lt;T&gt;.Adder(T)')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Adder.mC87pGoW7OVK88yenfaDIg.md 'KeepCoding.ModuleEvent&lt;T&gt;.Adder(T)')  
The encapsulated method that will add an event.
  
<a name='KeepCoding.ModuleEvent.T..New(KeepCoding.ModuleEvent.T..Adder.KeepCoding.ModuleEvent.T..Getter.KeepCoding.ModuleEvent.T..Setter).getter'></a>
`getter` [KeepCoding.ModuleEvent.Getter&lt;](ModuleEvent.T..Getter().md 'KeepCoding.ModuleEvent&lt;T&gt;.Getter()')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Getter().md 'KeepCoding.ModuleEvent&lt;T&gt;.Getter()')  
The encapsulated method that will get the value.
  
<a name='KeepCoding.ModuleEvent.T..New(KeepCoding.ModuleEvent.T..Adder.KeepCoding.ModuleEvent.T..Getter.KeepCoding.ModuleEvent.T..Setter).setter'></a>
`setter` [KeepCoding.ModuleEvent.Setter&lt;](ModuleEvent.T..Setter.UlnkLh8H+Jmatb0VSAcVdQ.md 'KeepCoding.ModuleEvent&lt;T&gt;.Setter(T)')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Setter.UlnkLh8H+Jmatb0VSAcVdQ.md 'KeepCoding.ModuleEvent&lt;T&gt;.Setter(T)')  
The encapsulated method that will set the value.
  
#### Returns
[KeepCoding.ModuleEvent&lt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;')[T](ModuleEvent.T..md#KeepCoding.ModuleEvent.T..T 'KeepCoding.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..md 'KeepCoding.ModuleEvent&lt;T&gt;')  
A new instance of this type, with the inner value based on the parameters passed in.
