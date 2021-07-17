#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding')
## ModuleContainer Class
Container for both solvable and needy modules.  
```csharp
public sealed class ModuleContainer :
System.IEquatable<KeepCoding.ModuleContainer>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModuleContainer  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  

| Constructors | |
| :--- | :--- |
| [ModuleContainer(Component)](KeepCoding_ModuleContainer_ModuleContainer(Component).md 'KeepCoding.ModuleContainer.ModuleContainer(Component)') | Encapsulates either a solvable or needy module. Uses [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').<br/> |
| [ModuleContainer(CacheableBehaviour)](KeepCoding_ModuleContainer_ModuleContainer(KeepCoding_CacheableBehaviour).md 'KeepCoding.ModuleContainer.ModuleContainer(KeepCoding.CacheableBehaviour)') | Encapsulates either a solvable or needy module. Uses [Get&lt;T&gt;(bool)](KeepCoding_CacheableBehaviour_Get_T_(bool).md 'KeepCoding.CacheableBehaviour.Get&lt;T&gt;(bool)').<br/> |
| [ModuleContainer(KMBombModule)](KeepCoding_ModuleContainer_ModuleContainer(KMBombModule).md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule)') | Encapsulates either a solvable module.<br/> |
| [ModuleContainer(KMBombModule, KMNeedyModule)](KeepCoding_ModuleContainer_ModuleContainer(KMBombModule_KMNeedyModule).md 'KeepCoding.ModuleContainer.ModuleContainer(KMBombModule, KMNeedyModule)') | Encapsulates either a solvable or needy module.<br/> |
| [ModuleContainer(KMNeedyModule)](KeepCoding_ModuleContainer_ModuleContainer(KMNeedyModule).md 'KeepCoding.ModuleContainer.ModuleContainer(KMNeedyModule)') | Encapsulates either a solvable module.<br/> |

| Properties | |
| :--- | :--- |
| [Id](KeepCoding_ModuleContainer_Id.md 'KeepCoding.ModuleContainer.Id') | The identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".<br/> |
| [Module](KeepCoding_ModuleContainer_Module.md 'KeepCoding.ModuleContainer.Module') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule').<br/> |
| [Name](KeepCoding_ModuleContainer_Name.md 'KeepCoding.ModuleContainer.Name') | The nice display name shown to players. e.g. "The Button"<br/> |
| [Needy](KeepCoding_ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy') | Returns [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [RequiresTimerVisibility](KeepCoding_ModuleContainer_RequiresTimerVisibility.md 'KeepCoding.ModuleContainer.RequiresTimerVisibility') | Set to true to only allow this module to be placed on the same face as the timer. Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly as it limits generation possibilities.<br/> |
| [RuleGeneration](KeepCoding_ModuleContainer_RuleGeneration.md 'KeepCoding.ModuleContainer.RuleGeneration') | Returns the random seed used to generate the rules for this game. Not currently used.<br/> |
| [Solvable](KeepCoding_ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable') | Returns [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule'), or if null, throws a [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException').<br/> |
| [Solve](KeepCoding_ModuleContainer_Solve.md 'KeepCoding.ModuleContainer.Solve') | Call this when the entire module has been solved.<br/> |
| [Strike](KeepCoding_ModuleContainer_Strike.md 'KeepCoding.ModuleContainer.Strike') | Call this on any mistake that you want to cause a bomb strike.<br/> |

| Methods | |
| :--- | :--- |
| [Assign(Action, Action, Action, Action, Action, Action)](KeepCoding_ModuleContainer_Assign(System_Action_System_Action_System_Action_System_Action_System_Action_System_Action).md 'KeepCoding.ModuleContainer.Assign(System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Assigns events to a module container, replacing their values.<br/> |
| [Equals(ModuleContainer)](KeepCoding_ModuleContainer_Equals(KeepCoding_ModuleContainer).md 'KeepCoding.ModuleContainer.Equals(KeepCoding.ModuleContainer)') | Determines if both [ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [Equals(object)](KeepCoding_ModuleContainer_Equals(object).md 'KeepCoding.ModuleContainer.Equals(object)') | Determines if both [ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer') variables are equal.<br/> |
| [GetHashCode()](KeepCoding_ModuleContainer_GetHashCode().md 'KeepCoding.ModuleContainer.GetHashCode()') | Gets the current hash code.<br/> |
| [OnActivate(Action)](KeepCoding_ModuleContainer_OnActivate(System_Action).md 'KeepCoding.ModuleContainer.OnActivate(System.Action)') | Sets the action of OnActivate.<br/> |

| Operators | |
| :--- | :--- |
| [explicit operator KMBombModule(ModuleContainer)](KeepCoding_ModuleContainer_op_ExplicitKMBombModule(KeepCoding_ModuleContainer).md 'KeepCoding.ModuleContainer.op_Explicit KMBombModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') from [Solvable](KeepCoding_ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable').<br/> |
| [explicit operator KMNeedyModule(ModuleContainer)](KeepCoding_ModuleContainer_op_ExplicitKMNeedyModule(KeepCoding_ModuleContainer).md 'KeepCoding.ModuleContainer.op_Explicit KMNeedyModule(KeepCoding.ModuleContainer)') | Returns the instance of [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') from [Needy](KeepCoding_ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy').<br/> |
| [implicit operator ModuleContainer(KMBombModule)](KeepCoding_ModuleContainer_op_ImplicitKeepCoding_ModuleContainer(KMBombModule).md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMBombModule)') | Creates a new instance of [ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer') where [Solvable](KeepCoding_ModuleContainer_Solvable.md 'KeepCoding.ModuleContainer.Solvable') is defined.<br/> |
| [implicit operator ModuleContainer(KMNeedyModule)](KeepCoding_ModuleContainer_op_ImplicitKeepCoding_ModuleContainer(KMNeedyModule).md 'KeepCoding.ModuleContainer.op_Implicit KeepCoding.ModuleContainer(KMNeedyModule)') | Creates a new instance of [ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer') where [Needy](KeepCoding_ModuleContainer_Needy.md 'KeepCoding.ModuleContainer.Needy') is defined.<br/> |
