### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.GetMethodInfo&lt;T&gt;(Expression&lt;Action&lt;T&gt;&gt;) Method
Gets the method info from an expression.  
```csharp
public static System.Reflection.MethodInfo GetMethodInfo<T>(this System.Linq.Expressions.Expression<System.Action<T>> expression);
```
#### Type parameters
<a name='KeepCoding_Helper_GetMethodInfo_T_(System_Linq_Expressions_Expression_System_Action_T__)_T'></a>
`T`  
The type of the action.
  
#### Parameters
<a name='KeepCoding_Helper_GetMethodInfo_T_(System_Linq_Expressions_Expression_System_Action_T__)_expression'></a>
`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](KeepCoding_Helper_GetMethodInfo_T_(System_Linq_Expressions_Expression_System_Action_T__).md#KeepCoding_Helper_GetMethodInfo_T_(System_Linq_Expressions_Expression_System_Action_T__)_T 'KeepCoding.Helper.GetMethodInfo&lt;T&gt;(System.Linq.Expressions.Expression&lt;System.Action&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')  
The expression that retrieves the method.
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')  
The method info of the function.
