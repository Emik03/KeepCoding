#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleContainer Class
Container for both solvable and needy modules.  
```csharp
public sealed class ModuleContainer :
System.IEquatable<KeepCoding.ModuleContainer>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModuleContainer  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [ModuleContainer(Component)](ModuleContainer__ctor__Cs02hEnCdQzEJgKilVrCw.md 'KeepCoding.ModuleContainer.ModuleContainer(Component)') | Encapsulates either a solvable or needy module. Uses [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').<br/> |
| [ModuleContainer(CacheableBehaviour)](ModuleContainer__ctor_JCblanSidmYIrRxqclMaQA.md 'KeepCoding.ModuleContainer.ModuleContainer(KeepCoding.CacheableBehaviour)') | Encapsulates either a solvable or needy module. Uses [Get&lt;T&gt;(bool)](CacheableBehaviour_Get_BCvpnMdzS10TWkqsNXOG8g.md 'KeepCoding.CacheableBehaviour.Get&lt;T&gt;(bool)').<br/> |
| [ModuleContainer(KMBombModule)](ModuleContainer__ctor_oSkW9iuREXZkl2mmHzyCLg.md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule)') | Encapsulates either a solvable module.<br/> |
| [ModuleContainer(KMBombModule, KMNeedyModule)](ModuleContainer__ctor_Xic0FPVl4Jq6gQzr0Fz66A.md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule, KMNeedyModule)') | Encapsulates either a solvable or needy module.<br/> |
| [ModuleContainer(KMNeedyModule)](ModuleContainer__ctor_7Z9tdLztI4cePCb33dLsgA.md 'KeepCoding.ModuleContainer.ModuleContainer(KMNeedyModule)') | Encapsulates either a solvable module.<br/> |

| Properties | |
| :--- | :--- |
| [Id](ModuleContainer_Id.md 'KeepCoding.ModuleContainer.Id') | The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".<br/> |
| [Module](ModuleContainer_Module.md 'KeepCoding.ModuleContainer.Module') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule').<br/> |
| [Name](ModuleContainer_Name.md 'KeepCoding.ModuleContainer.Name') | The nice display name shown to players. e.g. "The Button"<br/> |
| [Needy](ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy') | Returns [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [RequiresTimerVisibility](ModuleContainer_RequiresTimerVisibility.md 'KeepCoding.ModuleContainer.RequiresTimerVisibility') | Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.<br/> |
| [RuleGeneration](ModuleContainer_RuleGeneration.md 'KeepCoding.ModuleContainer.RuleGeneration') | Returns the random seed used to generate the rules for this game. Not currently used.<br/> |
| [Solvable](ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [Solve](ModuleContainer_Solve.md 'KeepCoding.ModuleContainer.Solve') | Call this when the entire module has been solved.<br/> |
| [Strike](ModuleContainer_Strike.md 'KeepCoding.ModuleContainer.Strike') | Call this on any mistake that you want to cause a bomb strike.<br/> |

| Methods | |
| :--- | :--- |
| [Assign(Action, Action, Action, Action, Action, Action)](ModuleContainer_Assign_0rTVRq0bU3pohaS2J6QIJw.md 'KeepCoding.ModuleContainer.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Assigns events to a module container, replacing their values.<br/> |
| [Equals(ModuleContainer)](ModuleContainer_Equals_uoK13ULV+B6co9A9YoXBPA.md 'KeepCoding.ModuleContainer.Equals(KeepCoding.ModuleContainer)') | Determines if both [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [Equals(object)](ModuleContainer_Equals_RWqyWwX38KKIOcvgyLTWIQ.md 'KeepCoding.ModuleContainer.Equals(object)') | Determines if both [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [GetHashCode()](ModuleContainer_GetHashCode().md 'KeepCoding.ModuleContainer.GetHashCode()') | Gets the current hash code.<br/> |
| [OnActivate(Action)](ModuleContainer_OnActivate_YKBy8TandpzPAG6QyBvXVg.md 'KeepCoding.ModuleContainer.OnActivate(System.Action)') | Sets the action of OnActivate.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator KMBombModule(ModuleContainer)](ModuleContainer_op_Explicit_RqsLkSj89CBEHBxR1R2p0w.md 'KeepCoding.ModuleContainer.op_Explicit KMBombModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') from [Solvable](ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable').<br/> |
| [explicit operator KMNeedyModule(ModuleContainer)](ModuleContainer_op_Explicit_5gvxB8cti+pMN0_BW9OpYQ.md 'KeepCoding.ModuleContainer.op_Explicit KMNeedyModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') from [Needy](ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy').<br/> |
| [implicit operator ModuleContainer(KMBombModule)](ModuleContainer_op_Implicit_mTnH5TWPaSROcIynPZoU5A.md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMBombModule)') | Creates a new instance of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') where [Solvable](ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable') is defined.<br/> |
| [implicit operator ModuleContainer(KMNeedyModule)](ModuleContainer_op_Implicit_WSG265tJxI41JmP0_rn8Tw.md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMNeedyModule)') | Creates a new instance of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') where [Needy](ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy') is defined.<br/> |
