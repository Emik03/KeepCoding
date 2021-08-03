#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ElementsI(XContainer, string) Method
Returns a filtered collection of the child elements of this element or document, in document order. Only  
elements that have the specified local name (ignoring the namespace) are included in the collection.
```csharp
public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsI(this System.Xml.Linq.XContainer element, string name);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.ElementsI(System.Xml.Linq.XContainer.string).element'></a>
`element` [System.Xml.Linq.XContainer](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XContainer 'System.Xml.Linq.XContainer')  
XML element to search.
  
<a name='KeepCoding.UtilityExtensions.ElementsI(System.Xml.Linq.XContainer.string).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name to match.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The first element found or `null` if no such element exists.
