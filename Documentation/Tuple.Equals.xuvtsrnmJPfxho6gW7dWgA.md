#### [KeepCoding](index.md 'index')
### [KeepCoding.Internal](KeepCoding.Internal.md 'KeepCoding.Internal').[Tuple](Tuple.md 'KeepCoding.Internal.Tuple')
## Tuple.Equals(Tuple) Method
Compares itself and another [Tuple](Tuple.md 'KeepCoding.Internal.Tuple') to determine if they contain the same values.  
```csharp
public bool Equals(KeepCoding.Internal.Tuple other);
```
#### Parameters
<a name='KeepCoding.Internal.Tuple.Equals(KeepCoding.Internal.Tuple).other'></a>
`other` [Tuple](Tuple.md 'KeepCoding.Internal.Tuple')  
The [Tuple](Tuple.md 'KeepCoding.Internal.Tuple') to compare itself to.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if both of them have the same items, or are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
### Example
The following example illustrates the different ways this method can return true or false.  
```csharp
using KeepCoding;  
  
public sealed class FooModule : ModuleScript  
{  
    private void Start()  
    {  
        Tuple<int> first = 2.ToTuple(),  
            second = first,  
            third = 2.ToTuple(),  
            fourth = 4.ToTuple();  
              
        Tuple<int, int> fifth = 2.ToTuple(2);  
          
        Log(first.Equals(second));  
        Log(first.Equals(third));  
        Log(first.Equals(fourth));  
        Log(first.Equals(fifth));  
    }  
}  
```
  
This is the output from the console.  
```csharp
[Foo #1] True  
[Foo #1] True  
[Foo #1] False  
[Foo #1] False  
```
### Remarks
The comparison is done by taking both of their [Items](Tuple.Items.md 'KeepCoding.Internal.Tuple.Items') values and comparing them with [System.Linq.Enumerable.SequenceEqual&lt;&gt;.Collections.Generic.IEnumerable{&lt;&gt;.Collections.Generic.IEnumerable{&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Enumerable.SequenceEqual--1#System_Linq_Enumerable_SequenceEqual__1_System_Collections_Generic_IEnumerable{__0},System_Collections_Generic_IEnumerable{__0}_ 'System.Linq.Enumerable.SequenceEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})'). Note that if the tuples are different sizes, this will automatically return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). For more information, [System.Object.Equals(System.Object)](https://docs.microsoft.com/en-us/dotnet/api/System.Object.Equals#System_Object_Equals_System_Object_ 'System.Object.Equals(System.Object)').  
