#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.AttributesI(XElement, string) Method
Returns a filtered collection of attributes of this element. Only elements that have the specified local name  
(ignoring the namespace) are included in the collection.
```csharp
public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> AttributesI(this System.Xml.Linq.XElement element, string name);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_AttributesI(System_Xml_Linq_XElement_string)_element'></a>
`element` [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')  
XML element to search.
  
<a name='KeepCoding_UtilityExtensions_AttributesI(System_Xml_Linq_XElement_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name to match.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Xml.Linq.XAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The filtered collection of attributes..