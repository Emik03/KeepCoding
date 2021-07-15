#### [KeepCoding](index.md 'index')
## KeepCoding Namespace

| Classes | |
| :--- | :--- |
| [ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper') | Extension methods surrounding [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') static methods to make code a bit shorter.<br/> |
| [BigInteger](KeepCoding_BigInteger.md 'KeepCoding.BigInteger') | Stores an arbitrarily large number.<br/> |
| [CacheableBehaviour](KeepCoding_CacheableBehaviour.md 'KeepCoding.CacheableBehaviour') | A [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') with additional caching capabilities. <br/> |
| [ColorblindInfo](KeepCoding_ColorblindInfo.md 'KeepCoding.ColorblindInfo') | Contains information about the colorblind mod's info, this class can be used to deserialize every mod's "modInfo.json".<br/> |
| [ComponentPool](KeepCoding_ComponentPool.md 'KeepCoding.ComponentPool') | A ComponentPool is a collection of Module Types. The generator will pick Count times from this list and instantiate a component of the chosen type.<br/> |
| [ConstructorArgumentException](KeepCoding_ConstructorArgumentException.md 'KeepCoding.ConstructorArgumentException') | An exception thrown when the constructor throws an exception due to a bad argument.<br/> |
| [EmptyIteratorException](KeepCoding_EmptyIteratorException.md 'KeepCoding.EmptyIteratorException') | An exception thrown when the iterator is empty.<br/> |
| [EventHelper](KeepCoding_EventHelper.md 'KeepCoding.EventHelper') | KMFramework extension methods that makes it easier to assign multiple events to a variable in one statement.<br/> |
| [Game](KeepCoding_Game.md 'KeepCoding.Game') | Allows access into the game's internal code. <br/> |
| [Game.KTInputManager](KeepCoding_Game_KTInputManager.md 'KeepCoding.Game.KTInputManager') | Allows access relating to how the game is being interacted with.<br/> |
| [Game.MasterAudio](KeepCoding_Game_MasterAudio.md 'KeepCoding.Game.MasterAudio') | Allows access relating to the game's main master channel for audio.<br/> |
| [Game.Mission](KeepCoding_Game_Mission.md 'KeepCoding.Game.Mission') | Allows access relating to the current mission.<br/> |
| [Game.ModManager](KeepCoding_Game_ModManager.md 'KeepCoding.Game.ModManager') | Allows access to methods relating mod paths.<br/> |
| [Game.PlayerSettings](KeepCoding_Game_PlayerSettings.md 'KeepCoding.Game.PlayerSettings') | Allows access into the player settings from the game. Do not use this class in the unity editor. <br/> |
| [GeneratorSetting](KeepCoding_GeneratorSetting.md 'KeepCoding.GeneratorSetting') | Everything needed to generate a single bomb.<br/> |
| [Helper](KeepCoding_Helper.md 'KeepCoding.Helper') | General extension class covering both KMFramework and native datatypes.<br/> |
| [KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper') | Inline methods for when typically key words are used.<br/> |
| [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') | A class to allow logging with a specific format.<br/> |
| [ModInfo](KeepCoding_ModInfo.md 'KeepCoding.ModInfo') | Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".<br/> |
| [ModuleContainer](KeepCoding_ModuleContainer.md 'KeepCoding.ModuleContainer') | Container for both solvable and needy modules.<br/> |
| [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript') | Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes. <br/> |
| [NegativeNumberException](KeepCoding_NegativeNumberException.md 'KeepCoding.NegativeNumberException') | An exception thrown when the number is unexpectedly negative.<br/> |
| [NullIteratorException](KeepCoding_NullIteratorException.md 'KeepCoding.NullIteratorException') | An exception thrown when the iterator is null.<br/> |
| [Number](KeepCoding_Number.md 'KeepCoding.Number') | Class meant to encapsulate a primitive numeric value.<br/> |
| [PathManager](KeepCoding_PathManager.md 'KeepCoding.PathManager') | Allows loading external information stored on the module. <br/> |
| [ReflectionScript](KeepCoding_ReflectionScript.md 'KeepCoding.ReflectionScript') | Editor-only behaviour that gets values from [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')s in real-time.<br/> |
| [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') | Advanced coroutine handler.<br/> |
| [Routine&lt;T&gt;](KeepCoding_Routine_T_.md 'KeepCoding.Routine&lt;T&gt;') | Advanced coroutine handler. <br/> |
| [Routine&lt;T1,T2&gt;](KeepCoding_Routine_T1_T2_.md 'KeepCoding.Routine&lt;T1,T2&gt;') | Advanced coroutine handler. <br/> |
| [Routine&lt;T1,T2,T3&gt;](KeepCoding_Routine_T1_T2_T3_.md 'KeepCoding.Routine&lt;T1,T2,T3&gt;') | Advanced coroutine handler. <br/> |
| [Routine&lt;T1,T2,T3,T4&gt;](KeepCoding_Routine_T1_T2_T3_T4_.md 'KeepCoding.Routine&lt;T1,T2,T3,T4&gt;') | Advanced coroutine handler. <br/> |
| [RoutineBase](KeepCoding_RoutineBase.md 'KeepCoding.RoutineBase') | Abstract class for the [Routine](KeepCoding_Routine.md 'KeepCoding.Routine') datatype, since the different overloads are similar to each other.<br/> |
| [Sound](KeepCoding_Sound.md 'KeepCoding.Sound') | Class meant to encapsulate all types of sound effects [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') uses. Currently used in [ModuleScript](KeepCoding_ModuleScript.md 'KeepCoding.ModuleScript').<br/> |
| [TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;') | Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes. <br/> |
| [TPScriptEditor](KeepCoding_TPScriptEditor.md 'KeepCoding.TPScriptEditor') | Custom inspector for [TPScript&lt;TModule&gt;](KeepCoding_TPScript_TModule_.md 'KeepCoding.TPScript&lt;TModule&gt;'). <br/> |
| [Tuple&lt;T&gt;](KeepCoding_Tuple_T_.md 'KeepCoding.Tuple&lt;T&gt;') | A basic tuple data type for C# 4.<br/> |
| [Tuple&lt;T1,T2&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;') | A basic tuple data type for C# 4. <br/> |
| [Tuple&lt;T1,T2,T3&gt;](KeepCoding_Tuple_T1_T2_T3_.md 'KeepCoding.Tuple&lt;T1,T2,T3&gt;') | A basic tuple data type for C# 4. <br/> |
| [Tuple&lt;T1,T2,T3,T4&gt;](KeepCoding_Tuple_T1_T2_T3_T4_.md 'KeepCoding.Tuple&lt;T1,T2,T3,T4&gt;') | A basic tuple data type for C# 4. <br/> |
| [TupleBase](KeepCoding_TupleBase.md 'KeepCoding.TupleBase') | An abstract type meant for the tuple data type for C# 4.<br/> |
| [TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper') | Extension methods to help you create data types easier.<br/> |
| [UnrecognizedTypeException](KeepCoding_UnrecognizedTypeException.md 'KeepCoding.UnrecognizedTypeException') | An exception thrown for when the type isn't handled.<br/> |
| [UnrecognizedValueException](KeepCoding_UnrecognizedValueException.md 'KeepCoding.UnrecognizedValueException') | An exception thrown for when the value isn't handled.<br/> |
| [Work](KeepCoding_Work.md 'KeepCoding.Work') | Advanced multi-threading handler.<br/> |
| [Work&lt;T&gt;](KeepCoding_Work_T_.md 'KeepCoding.Work&lt;T&gt;') | Advanced multi-threading handler.<br/> |
| [Work&lt;T,TResult&gt;](KeepCoding_Work_T_TResult_.md 'KeepCoding.Work&lt;T,TResult&gt;') | Advanced multi-threading handler.<br/> |
| [Work&lt;T1,T2,T3,T4,TResult&gt;](KeepCoding_Work_T1_T2_T3_T4_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,T4,TResult&gt;') | Advanced multi-threading handler.<br/> |
| [Work&lt;T1,T2,T3,TResult&gt;](KeepCoding_Work_T1_T2_T3_TResult_.md 'KeepCoding.Work&lt;T1,T2,T3,TResult&gt;') | Advanced multi-threading handler.<br/> |
| [Work&lt;T1,T2,TResult&gt;](KeepCoding_Work_T1_T2_TResult_.md 'KeepCoding.Work&lt;T1,T2,TResult&gt;') | Advanced multi-threading handler.<br/> |
| [WorkBase](KeepCoding_WorkBase.md 'KeepCoding.WorkBase') | Abstract class for the [Work](KeepCoding_Work.md 'KeepCoding.Work') datatype, since the different overloads are similar to each other.<br/> |

| Interfaces | |
| :--- | :--- |
| [IDump](KeepCoding_IDump.md 'KeepCoding.IDump') | An interface to implement dump methods. Make each method return the same method in your [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') instance. <br/> |
| [ILog](KeepCoding_ILog.md 'KeepCoding.ILog') | An interface to implement log methods. Make each method return the same method in your [Logger](KeepCoding_Logger.md 'KeepCoding.Logger') instance.  <br/> |
| [ITP](KeepCoding_ITP.md 'KeepCoding.ITP') | Interface for Twitch Plays support. <br/> |
| [ITuple](KeepCoding_ITuple.md 'KeepCoding.ITuple') | Interface for tuple type. <br/> |

| Enums | |
| :--- | :--- |
| [ComponentPool.ComponentSource](KeepCoding_ComponentPool_ComponentSource.md 'KeepCoding.ComponentPool.ComponentSource') | Controls where this pool will draw from (e.g. the base game modules, modules from mods, or both).<br/> |
| [ComponentPool.ComponentTypeEnum](KeepCoding_ComponentPool_ComponentTypeEnum.md 'KeepCoding.ComponentPool.ComponentTypeEnum') | The module types in the base game.<br/> |
| [ComponentPool.SpecialComponentTypeEnum](KeepCoding_ComponentPool_SpecialComponentTypeEnum.md 'KeepCoding.ComponentPool.SpecialComponentTypeEnum') | Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). Set to "None" to select specific module types.<br/> |
| [Game.ControlType](KeepCoding_Game_ControlType.md 'KeepCoding.Game.ControlType') | Determines how the game is controlled.<br/> |
| [Game.ModSourceEnum](KeepCoding_Game_ModSourceEnum.md 'KeepCoding.Game.ModSourceEnum') | Determines how the mod is stored.<br/> |
