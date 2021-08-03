#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.AttributeI(XElement, string) Method
Returns the first attribute of this element that has the specified local name (ignoring the namespace).
```csharp
public static System.Xml.Linq.XAttribute AttributeI(this System.Xml.Linq.XElement element, string name);
```
#### Parameters
<a name='KeepCoding.UtilityHelper.AttributeI(System.Xml.Linq.XElement.string).element'></a>
`element` [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')  
XML element to search.
  
<a name='KeepCoding.UtilityHelper.AttributeI(System.Xml.Linq.XElement.string).name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name to match.
  
#### Returns
[System.Xml.Linq.XAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute')  
The first attribute if found or `null` if no such attribute exists.
