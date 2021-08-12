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
| [ModuleContainer(Component)](ModuleContainer..ctor..Cs02hEnCdQzEJgKilVrCw.md 'KeepCoding.ModuleContainer.ModuleContainer(Component)') | Encapsulates either a solvable or needy module. Uses [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').<br/> |
| [ModuleContainer(CacheableBehaviour)](ModuleContainer..ctor.JCblanSidmYIrRxqclMaQA.md 'KeepCoding.ModuleContainer.ModuleContainer(KeepCoding.CacheableBehaviour)') | Encapsulates either a solvable or needy module. Uses [Get&lt;T&gt;(bool)](CacheableBehaviour.Get.BCvpnMdzS10TWkqsNXOG8g.md 'KeepCoding.CacheableBehaviour.Get&lt;T&gt;(bool)').<br/> |
| [ModuleContainer(KMBombModule)](ModuleContainer..ctor.oSkW9iuREXZkl2mmHzyCLg.md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule)') | Encapsulates a solvable module.<br/> |
| [ModuleContainer(KMBombModule, KMNeedyModule)](ModuleContainer..ctor.Xic0FPVl4Jq6gQzr0Fz66A.md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule, KMNeedyModule)') | Encapsulates either a solvable or needy module.<br/> |
| [ModuleContainer(KMNeedyModule)](ModuleContainer..ctor.7Z9tdLztI4cePCb33dLsgA.md 'KeepCoding.ModuleContainer.ModuleContainer(KMNeedyModule)') | Encapsulates a needy module.<br/> |

| Properties | |
| :--- | :--- |
| [Id](ModuleContainer.Id.md 'KeepCoding.ModuleContainer.Id') | The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".<br/> |
| [IsNeedy](ModuleContainer.IsNeedy.md 'KeepCoding.ModuleContainer.IsNeedy') | Determines whether this instance contains a [Needy](ModuleContainer.Needy.md 'KeepCoding.ModuleContainer.Needy').<br/> |
| [Module](ModuleContainer.Module.md 'KeepCoding.ModuleContainer.Module') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule').<br/> |
| [Name](ModuleContainer.Name.md 'KeepCoding.ModuleContainer.Name') | The nice display name shown to players. e.g. "The Button"<br/> |
| [Needy](ModuleContainer.Needy.md 'KeepCoding.ModuleContainer.Needy') | Returns [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [RequiresTimerVisibility](ModuleContainer.RequiresTimerVisibility.md 'KeepCoding.ModuleContainer.RequiresTimerVisibility') | Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.<br/> |
| [RuleGeneration](ModuleContainer.RuleGeneration.md 'KeepCoding.ModuleContainer.RuleGeneration') | Returns the random seed used to generate the rules for this game. Not currently used.<br/> |
| [Solvable](ModuleContainer.Solvable.md 'KeepCoding.ModuleContainer.Solvable') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [Solve](ModuleContainer.Solve.md 'KeepCoding.ModuleContainer.Solve') | Call this when the entire module has been solved.<br/> |
| [Strike](ModuleContainer.Strike.md 'KeepCoding.ModuleContainer.Strike') | Call this on any mistake that you want to cause a bomb strike.<br/> |

| Methods | |
| :--- | :--- |
| [Assign(Action, Action, Action, Action, Action, Action)](ModuleContainer.Assign.0rTVRq0bU3pohaS2J6QIJw.md 'KeepCoding.ModuleContainer.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Assigns events to a module container, replacing their values.<br/> |
| [Equals(ModuleContainer)](ModuleContainer.Equals.uoK13ULV+B6co9A9YoXBPA.md 'KeepCoding.ModuleContainer.Equals(KeepCoding.ModuleContainer)') | Determines if both [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [Equals(object)](ModuleContainer.Equals.RWqyWwX38KKIOcvgyLTWIQ.md 'KeepCoding.ModuleContainer.Equals(object)') | Determines if both [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [GetHashCode()](ModuleContainer.GetHashCode().md 'KeepCoding.ModuleContainer.GetHashCode()') | Gets the current hash code.<br/> |
| [ToString()](ModuleContainer.ToString().md 'KeepCoding.ModuleContainer.ToString()') | Gets the [Name](ModuleContainer.Name.md 'KeepCoding.ModuleContainer.Name') and [Id](ModuleContainer.Id.md 'KeepCoding.ModuleContainer.Id') of the module.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator KMBombModule(ModuleContainer)](ModuleContainer.op_Explicit.RqsLkSj89CBEHBxR1R2p0w.md 'KeepCoding.ModuleContainer.op_Explicit KMBombModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') from [Solvable](ModuleContainer.Solvable.md 'KeepCoding.ModuleContainer.Solvable').<br/> |
| [explicit operator KMNeedyModule(ModuleContainer)](ModuleContainer.op_Explicit.5gvxB8cti+pMN0.BW9OpYQ.md 'KeepCoding.ModuleContainer.op_Explicit KMNeedyModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') from [Needy](ModuleContainer.Needy.md 'KeepCoding.ModuleContainer.Needy').<br/> |
| [implicit operator ModuleContainer(KMBombModule)](ModuleContainer.op_Implicit.mTnH5TWPaSROcIynPZoU5A.md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMBombModule)') | Creates a new instance of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') where [Solvable](ModuleContainer.Solvable.md 'KeepCoding.ModuleContainer.Solvable') is defined.<br/> |
| [implicit operator ModuleContainer(KMNeedyModule)](ModuleContainer.op_Implicit.WSG265tJxI41JmP0.rn8Tw.md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMNeedyModule)') | Creates a new instance of [ModuleContainer](ModuleContainer.md 'KeepCoding.ModuleContainer') where [Needy](ModuleContainer.Needy.md 'KeepCoding.ModuleContainer.Needy') is defined.<br/> |
