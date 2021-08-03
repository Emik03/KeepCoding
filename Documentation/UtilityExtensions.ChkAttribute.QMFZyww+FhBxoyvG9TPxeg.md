#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityExtensions](UtilityExtensions.md 'KeepCoding.UtilityExtensions')
## UtilityExtensions.ChkAttribute(XElement, XName) Method
Returns the first attribute matching "name", or if none, throws an exception to say which element was missing  
which attribute. This is a counterpart to [System.Xml.Linq.XElement.Attribute(System.Xml.Linq.XName)](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement.Attribute#System_Xml_Linq_XElement_Attribute_System_Xml_Linq_XName_ 'System.Xml.Linq.XElement.Attribute(System.Xml.Linq.XName)').
```csharp
public static System.Xml.Linq.XAttribute ChkAttribute(this System.Xml.Linq.XElement element, System.Xml.Linq.XName name);
```
#### Parameters
<a name='KeepCoding.UtilityExtensions.ChkAttribute(System.Xml.Linq.XElement.System.Xml.Linq.XName).element'></a>
`element` [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')  
  
<a name='KeepCoding.UtilityExtensions.ChkAttribute(System.Xml.Linq.XElement.System.Xml.Linq.XName).name'></a>
`name` [System.Xml.Linq.XName](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XName 'System.Xml.Linq.XName')  
  
#### Returns
[System.Xml.Linq.XAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute')  
