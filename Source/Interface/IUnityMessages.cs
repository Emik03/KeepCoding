#if !LITE
using System.Collections;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// <see cref="Awake"/> is called when the script instance is being loaded.
    /// </summary>
    /// <remarks>
    /// <see cref="Awake"/> is used to initialize any variables or game state before the game starts. <see cref="Awake"/> is called only once during the lifetime of the script instance. <see cref="Awake"/> is called after all objects are initialized so you can safely speak to other objects or query them using for example <see cref="GameObject.FindWithTag(string)"/>. Each GameObject's <see cref="Awake"/> is called in a random order between objects. Because of this, you should use <see cref="Awake"/> to set up references between scripts, and use <see cref="IStart.Start"/> to pass any information back and forth. <see cref="Awake"/> is always called before any <see cref="IStart.Start"/> functions. This allows you to order initialization of scripts. <see cref="Awake"/> can not act as a coroutine. Note: Use <see cref="Awake"/> instead of the constructor for initialization, as the serialized state of the <see cref="Component"/> is undefined at construction time. <see cref="Awake"/> is called once, just like the constructor.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Awake.html"/>
    public interface IAwake
    {
        /// <summary>
        /// <see cref="Awake"/> is called when the script instance is being loaded.
        /// </summary>
        /// <remarks>
        /// <see cref="Awake"/> is used to initialize any variables or game state before the game starts. <see cref="Awake"/> is called only once during the lifetime of the script instance. <see cref="Awake"/> is called after all objects are initialized so you can safely speak to other objects or query them using for example <see cref="GameObject.FindWithTag(string)"/>. Each GameObject's <see cref="Awake"/> is called in a random order between objects. Because of this, you should use <see cref="Awake"/> to set up references between scripts, and use <see cref="IStart.Start"/> to pass any information back and forth. <see cref="Awake"/> is always called before any <see cref="IStart.Start"/> functions. This allows you to order initialization of scripts. <see cref="Awake"/> can not act as a coroutine. Note: Use <see cref="Awake"/> instead of the constructor for initialization, as the serialized state of the <see cref="Component"/> is undefined at construction time. <see cref="Awake"/> is called once, just like the constructor.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Awake.html"/>
        public void Awake();
    }

    /// <summary>
    /// Frame-rate independent <see cref="FixedUpdate"/> message for physics calculations.
    /// </summary>
    /// <remarks>
    /// <see cref="FixedUpdate"/> has the frequency of the physics system; it is called every fixed frame-rate frame. Compute <see cref="Physics"/> system calculations after <see cref="FixedUpdate"/>. 0.02 seconds (50 calls per second) is the default time between calls. Use <see cref="Time.fixedDeltaTime"/> to access this value. Alter it by setting it to your preferred value within a script, or, navigate to <c>Edit > Settings > Time > Fixed Timestep</c> and set it there. The <see cref="FixedUpdate"/> frequency is more or less than <see cref="IUpdate.Update"/>. If the application runs at 25 frames per second (fps), Unity calls it approximately twice per frame, Alternatively, 100 fps causes approximately two rendering frames with one <see cref="FixedUpdate"/>. Control the required frame rate and <c>Fixed Timestep</c> rate from <c>Time</c> settings. Use <see cref="Application.targetFrameRate"/> to set the frame rate. Use <see cref="FixedUpdate"/> when using <see cref="Rigidbody"/>. Set a force to a <see cref="Rigidbody"/> and it applies each fixed frame. <see cref="FixedUpdate"/> occurs at a measured time step that typically does not coincide with <see cref="IUpdate.Update"/>. In order to get the elapsed time since last call to <see cref="IUpdate.Update"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.FixedUpdate.html"/>
    public interface IFixedUpdate
    {
        /// <summary>
        /// Frame-rate independent <see cref="FixedUpdate"/> message for physics calculations.
        /// </summary>
        /// <remarks>
        /// <see cref="FixedUpdate"/> has the frequency of the physics system; it is called every fixed frame-rate frame. Compute <see cref="Physics"/> system calculations after <see cref="FixedUpdate"/>. 0.02 seconds (50 calls per second) is the default time between calls. Use <see cref="Time.fixedDeltaTime"/> to access this value. Alter it by setting it to your preferred value within a script, or, navigate to <c>Edit > Settings > Time > Fixed Timestep</c> and set it there. The <see cref="FixedUpdate"/> frequency is more or less than <see cref="IUpdate.Update"/>. If the application runs at 25 frames per second (fps), Unity calls it approximately twice per frame, Alternatively, 100 fps causes approximately two rendering frames with one <see cref="FixedUpdate"/>. Control the required frame rate and <c>Fixed Timestep</c> rate from <c>Time</c> settings. Use <see cref="Application.targetFrameRate"/> to set the frame rate. Use <see cref="FixedUpdate"/> when using <see cref="Rigidbody"/>. Set a force to a <see cref="Rigidbody"/> and it applies each fixed frame. <see cref="FixedUpdate"/> occurs at a measured time step that typically does not coincide with <see cref="IUpdate.Update"/>. In order to get the elapsed time since last call to <see cref="IUpdate.Update"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.FixedUpdate.html"/>
        public void FixedUpdate();
    }

    /// <summary>
    /// <see cref="LateUpdate"/> is called every frame, if the <see cref="Behaviour"/> is enabled.
    /// </summary>
    /// <remarks>
    /// <see cref="LateUpdate"/> is called after all <see cref="IUpdate.Update"/> functions have been called. This is useful to order script execution. For example a follow <see cref="Camera"/> should always be implemented in <see cref="LateUpdate"/> because it tracks objects that might have moved inside <see cref="IUpdate.Update"/>. In order to get the elapsed time since last call to <see cref="LateUpdate"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.LateUpdate.html"/>
    public interface ILateUpdate
    {
        /// <summary>
        /// <see cref="LateUpdate"/> is called every frame, if the <see cref="Behaviour"/> is enabled.
        /// </summary>
        /// <remarks>
        /// <see cref="LateUpdate"/> is called after all <see cref="IUpdate.Update"/> functions have been called. This is useful to order script execution. For example a follow <see cref="Camera"/> should always be implemented in <see cref="LateUpdate"/> because it tracks objects that might have moved inside <see cref="IUpdate.Update"/>. In order to get the elapsed time since last call to <see cref="LateUpdate"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.LateUpdate.html"/>
        public void LateUpdate();
    }

    /// <summary>
    /// Reset to default values.
    /// </summary>
    /// <remarks>
    /// <see cref="Reset"/> is called when the user hits the Reset button in the Inspector's context menu or when adding the <see cref="Component"/> the first time. This function is only called in editor mode. <see cref="Reset"/> is most commonly used to give good default values in the inspector.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Reset.html"/>
    public interface IReset
    {
        /// <summary>
        /// Reset to default values.
        /// </summary>
        /// <remarks>
        /// <see cref="Reset"/> is called when the user hits the Reset button in the Inspector's context menu or when adding the <see cref="Component"/> the first time. This function is only called in editor mode. <see cref="Reset"/> is most commonly used to give good default values in the inspector.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/2017.4/Documentation/ScriptReference/MonoBehaviour.Reset.html"/>
        public void Reset();
    }

    /// <summary>
    /// <see cref="Start"/> is called on the frame when a script is enabled just before any of the <see cref="IUpdate.Update"/> methods is called the first time.
    /// </summary>
    /// <remarks>
    /// Like the <see cref="IAwake.Awake"/> function, <see cref="Start"/> is called exactly once in the lifetime of the script. However, <see cref="IAwake.Awake"/> is called when the script object is initialised, regardless of whether or not the script is enabled. <see cref="Start"/> may not be called on the same frame as <see cref="IAwake.Awake"/> if the script is not enabled at initialisation time. The <see cref="IAwake.Awake"/> function is called on all objects in the scene before any object's <see cref="Start"/> function is called. This fact is useful in cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be done in <see cref="IAwake.Awake"/> while A's should be done in <see cref="Start"/>. Where objects are instantiated during gameplay, their <see cref="IAwake.Awake"/> function will naturally be called after the <see cref="Start"/> functions of scene objects have already completed.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html"/>
    public interface IStart
    {
        /// <summary>
        /// <see cref="Start"/> is called on the frame when a script is enabled just before any of the <see cref="IUpdate.Update"/> methods is called the first time.
        /// </summary>
        /// <remarks>
        /// Like the <see cref="IAwake.Awake"/> function, <see cref="Start"/> is called exactly once in the lifetime of the script. However, <see cref="IAwake.Awake"/> is called when the script object is initialised, regardless of whether or not the script is enabled. <see cref="Start"/> may not be called on the same frame as <see cref="IAwake.Awake"/> if the script is not enabled at initialisation time. The <see cref="IAwake.Awake"/> function is called on all objects in the scene before any object's <see cref="Start"/> function is called. This fact is useful in cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be done in <see cref="IAwake.Awake"/> while A's should be done in <see cref="Start"/>. Where objects are instantiated during gameplay, their <see cref="IAwake.Awake"/> function will naturally be called after the <see cref="Start"/> functions of scene objects have already completed.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html"/>
        public void Start();
    }

    /// <summary>
    /// <see cref="Start"/> is called on the frame when a script is enabled just before any of the <see cref="IUpdate.Update"/> methods is called the first time.
    /// </summary>
    /// <remarks>
    /// Like the <see cref="IAwake.Awake"/> function, <see cref="Start"/> is called exactly once in the lifetime of the script. However, <see cref="IAwake.Awake"/> is called when the script object is initialised, regardless of whether or not the script is enabled. <see cref="Start"/> may not be called on the same frame as <see cref="IAwake.Awake"/> if the script is not enabled at initialisation time. The <see cref="IAwake.Awake"/> function is called on all objects in the scene before any object's <see cref="Start"/> function is called. This fact is useful in cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be done in <see cref="IAwake.Awake"/> while A's should be done in <see cref="Start"/>. Where objects are instantiated during gameplay, their <see cref="IAwake.Awake"/> function will naturally be called after the <see cref="Start"/> functions of scene objects have already completed.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html"/>
    public interface IStartCoroutine
    {
        /// <summary>
        /// <see cref="Start"/> is called on the frame when a script is enabled just before any of the <see cref="IUpdate.Update"/> methods is called the first time.
        /// </summary>
        /// <remarks>
        /// Like the <see cref="IAwake.Awake"/> function, <see cref="Start"/> is called exactly once in the lifetime of the script. However, <see cref="IAwake.Awake"/> is called when the script object is initialised, regardless of whether or not the script is enabled. <see cref="Start"/> may not be called on the same frame as <see cref="IAwake.Awake"/> if the script is not enabled at initialisation time. The <see cref="IAwake.Awake"/> function is called on all objects in the scene before any object's <see cref="Start"/> function is called. This fact is useful in cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be done in <see cref="IAwake.Awake"/> while A's should be done in <see cref="Start"/>. Where objects are instantiated during gameplay, their <see cref="IAwake.Awake"/> function will naturally be called after the <see cref="Start"/> functions of scene objects have already completed.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html"/>
        public IEnumerator Start();
    }

    /// <summary>
    /// <see cref="Update"/> is called every frame, if the <see cref="MonoBehaviour"/> is enabled.
    /// </summary>
    /// <remarks>
    /// <see cref="Update"/> is the most commonly used function to implement any kind of game script. Not every <see cref="MonoBehaviour"/> script needs <see cref="Update"/>. In order to get the elapsed time since last call to <see cref="Update"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
    /// </remarks>
    /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html"/>
    public interface IUpdate
    {
        /// <summary>
        /// <see cref="Update"/> is called every frame, if the <see cref="MonoBehaviour"/> is enabled.
        /// </summary>
        /// <remarks>
        /// <see cref="Update"/> is the most commonly used function to implement any kind of game script. Not every <see cref="MonoBehaviour"/> script needs <see cref="Update"/>. In order to get the elapsed time since last call to <see cref="Update"/>, use <see cref="Time.deltaTime"/>. This function is only called if the <see cref="Behaviour"/> is enabled. Override this function in order to provide your <see cref="Component"/>'s functionality.
        /// </remarks>
        /// <seealso href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html"/>
        public void Update();
    }
}
#endif
