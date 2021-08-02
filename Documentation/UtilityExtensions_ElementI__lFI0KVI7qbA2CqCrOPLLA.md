#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ElementI(XElement, string) Method
Gets the first (in document order) child element with the specified local name (ignoring the namespace).
```csharp
public static System.Xml.Linq.XElement ElementI(this System.Xml.Linq.XElement element, string name);
```
#### Parameters
<a name='KeepCoding_UtilityExtensions_ElementI(System_Xml_Linq_XElement_string)_element'></a>
`element` [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')  
XML element to search.
  
<a name='KeepCoding_UtilityExtensions_ElementI(System_Xml_Linq_XElement_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name to match.
  
#### Returns
[System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')  
The first element found or `null` if no such element exists.
