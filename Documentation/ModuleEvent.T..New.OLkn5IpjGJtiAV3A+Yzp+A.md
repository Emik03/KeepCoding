#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')
## ModuleEvent&lt;T&gt;.New(Adder, Getter, Setter, Signature, Remover, Converter) Method
Creates a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance of [ModuleEvent&lt;T&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;') with the underlying type passed in.  
```csharp
public static KeepCoding.Internal.ModuleEvent<T> New(KeepCoding.Internal.ModuleEvent<T>.Adder adder, KeepCoding.Internal.ModuleEvent<T>.Getter getter, KeepCoding.Internal.ModuleEvent<T>.Setter setter, KeepCoding.Internal.ModuleEvent<T>.Signature signature, KeepCoding.Internal.ModuleEvent<T>.Remover remover, KeepCoding.Internal.ModuleEvent<T>.Converter converter=null);
```
#### Parameters
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).adder'></a>
`adder` [KeepCoding.Internal.ModuleEvent.Adder&lt;](ModuleEvent.T..Adder.vkOzq+W2jofpeT9w9RtuQg.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Adder(object)')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Adder.vkOzq+W2jofpeT9w9RtuQg.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Adder(object)')  
The encapsulated method that will add an event.
  
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).getter'></a>
`getter` [KeepCoding.Internal.ModuleEvent.Getter&lt;](ModuleEvent.T..Getter().md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Getter()')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Getter().md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Getter()')  
The encapsulated method that will get the value.
  
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).setter'></a>
`setter` [KeepCoding.Internal.ModuleEvent.Setter&lt;](ModuleEvent.T..Setter.aRQHVXGTs9kXhDv0uQ4JUw.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Setter(object)')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Setter.aRQHVXGTs9kXhDv0uQ4JUw.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Setter(object)')  
The encapsulated method that will set the value.
  
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).signature'></a>
`signature` [KeepCoding.Internal.ModuleEvent.Signature&lt;](ModuleEvent.T..Signature().md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Signature()')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Signature().md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Signature()')  
The encapsulated method that will get the [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the target.
  
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).remover'></a>
`remover` [KeepCoding.Internal.ModuleEvent.Remover&lt;](ModuleEvent.T..Remover.RGxbGbh.wwtwm7jCHxzRgA.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Remover(object)')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Remover.RGxbGbh.wwtwm7jCHxzRgA.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Remover(object)')  
The encapsulated method that will remove the value.
  
<a name='KeepCoding.Internal.ModuleEvent.T..New(KeepCoding.Internal.ModuleEvent.T..Adder.KeepCoding.Internal.ModuleEvent.T..Getter.KeepCoding.Internal.ModuleEvent.T..Setter.KeepCoding.Internal.ModuleEvent.T..Signature.KeepCoding.Internal.ModuleEvent.T..Remover.KeepCoding.Internal.ModuleEvent.T..Converter).converter'></a>
`converter` [KeepCoding.Internal.ModuleEvent.Converter&lt;](ModuleEvent.T..Converter.C2YZyBHUlR9hU3rmH1dRog.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Converter(T)')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..Converter.C2YZyBHUlR9hU3rmH1dRog.md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.Converter(T)')  
The encapsulated method that changes the value before used in converting types.
  
#### Returns
[KeepCoding.Internal.ModuleEvent&lt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')[T](ModuleEvent.T..md#KeepCoding.Internal.ModuleEvent.T..T 'KeepCoding.Internal.ModuleEvent&lt;T&gt;.T')[&gt;](ModuleEvent.T..md 'KeepCoding.Internal.ModuleEvent&lt;T&gt;')  
A [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance of this type, with the inner value based on the parameters passed in.
