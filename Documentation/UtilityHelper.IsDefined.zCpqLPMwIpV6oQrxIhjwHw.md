#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[UtilityHelper](UtilityHelper.md 'KeepCoding.UtilityHelper')
## UtilityHelper.IsDefined&lt;T&gt;(MemberInfo, bool) Method
Indicates whether one or more instance of the specified attribute type is applied to this member.
```csharp
public static bool IsDefined<T>(this System.Reflection.MemberInfo member, bool inherit=false);
```
#### Type parameters
<a name='KeepCoding.UtilityHelper.IsDefined.T.(System.Reflection.MemberInfo.bool).T'></a>
`T`  
The type of attribute to search for.
  
#### Parameters
<a name='KeepCoding.UtilityHelper.IsDefined.T.(System.Reflection.MemberInfo.bool).member'></a>
`member` [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')  
Member whose custom attributes to search.
  
<a name='KeepCoding.UtilityHelper.IsDefined.T.(System.Reflection.MemberInfo.bool).inherit'></a>
`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Specifies whether to search this member's inheritance chain to find the attributes.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
