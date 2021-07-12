### [KeepCoding](KeepCoding.md 'KeepCoding').[TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;')
## TPScript&lt;TModule&gt;.Detonate(Nullable&lt;float&gt;, string) Method
Yield return this to explode the bomb instantly. [time](KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string).md#KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_time 'KeepCoding.TPScript&lt;TModule&gt;.Detonate(System.Nullable&lt;float&gt;, string).time') is specified in number of seconds before the bomb explodes. (Note, sending another detonate command will auto-cancel the previous one on the same module if it hasn't happened already.). [message](KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string).md#KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_message 'KeepCoding.TPScript&lt;TModule&gt;.Detonate(System.Nullable&lt;float&gt;, string).message') is the message to send to chat upon detonation. Both of the parameters are optional.  
```csharp
protected static string Detonate(System.Nullable<float> time=null, string message=null);
```
#### Parameters
<a name='KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_time'></a>
`time` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The amount of time before the bomb blows up.
  
<a name='KeepCoding_TPScript_TModule__Detonate(System_Nullable_float__string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to send.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A formatted string for Twitch Plays.
