//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine
{

    public partial class GameObject(long id) : Object(id)
    {

        #region Implementation

        public GameObject(string name)
            : this(internal_UnityEngineGameObject__ctor__SystemString(name)) { }

        public GameObject()
            : this(internal_UnityEngineGameObject__ctor()) { }

        public GameObject(string name, global::System.Type[] components)
            : this(internal_UnityEngineGameObject__ctor__SystemString__SystemTypeArray(name, components)) { }

        public global::UnityEngine.Transform transform 
        {
            get => internal_UnityEngineGameObject__get__transform(WrappedId);
        }

        public int layer 
        {
            get => internal_UnityEngineGameObject__get__layer(WrappedId);
            set => internal_UnityEngineGameObject__set__layer(WrappedId, value);
        }

        public bool activeSelf 
        {
            get => internal_UnityEngineGameObject__get__activeSelf(WrappedId);
        }

        public bool activeInHierarchy 
        {
            get => internal_UnityEngineGameObject__get__activeInHierarchy(WrappedId);
        }

        public bool isStatic 
        {
            get => internal_UnityEngineGameObject__get__isStatic(WrappedId);
            set => internal_UnityEngineGameObject__set__isStatic(WrappedId, value);
        }

        public string tag 
        {
            get => internal_UnityEngineGameObject__get__tag(WrappedId);
            set => internal_UnityEngineGameObject__set__tag(WrappedId, value);
        }

        public global::UnityEngine.SceneManagement.Scene scene 
        {
            get => internal_UnityEngineGameObject__get__scene(WrappedId);
        }

        public ulong sceneCullingMask 
        {
            get => internal_UnityEngineGameObject__get__sceneCullingMask(WrappedId);
        }

        public global::UnityEngine.GameObject gameObject 
        {
            get => internal_UnityEngineGameObject__get__gameObject(WrappedId);
        }

        public static global::UnityEngine.GameObject CreatePrimitive(global::UnityEngine.PrimitiveType type)
        {
            return internal_UnityEngineGameObject__func__CreatePrimitive__UnityEnginePrimitiveTypeEnum__UnityEngineGameObject(type);
        }

        public T GetComponent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponent_T__UnityEngineGameObject_T<T>(WrappedId);
        }

        public global::UnityEngine.Component GetComponent(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponent__SystemType__UnityEngineComponent(WrappedId, type);
        }

        public global::UnityEngine.Component GetComponent(string type)
        {
            return internal_UnityEngineGameObject__func__GetComponent__SystemString__UnityEngineComponent(WrappedId, type);
        }

        public global::UnityEngine.Component GetComponentInChildren(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineGameObject__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(WrappedId, type, includeInactive);
        }

        public global::UnityEngine.Component GetComponentInChildren(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponentInChildren__SystemType__UnityEngineComponent(WrappedId, type);
        }

        public T GetComponentInChildren<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentInChildren_T__UnityEngineGameObject_T<T>(WrappedId);
        }

        public T GetComponentInChildren<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentInChildren_T__SystemBoolean__UnityEngineGameObject_T<T>(WrappedId, includeInactive);
        }

        public global::UnityEngine.Component GetComponentInParent(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineGameObject__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(WrappedId, type, includeInactive);
        }

        public global::UnityEngine.Component GetComponentInParent(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponentInParent__SystemType__UnityEngineComponent(WrappedId, type);
        }

        public T GetComponentInParent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentInParent_T__UnityEngineGameObject_T<T>(WrappedId);
        }

        public T GetComponentInParent<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentInParent_T__SystemBoolean__UnityEngineGameObject_T<T>(WrappedId, includeInactive);
        }

        public global::UnityEngine.Component[] GetComponents(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponents__SystemType__UnityEngineComponentArray(WrappedId, type);
        }

        public T[] GetComponents<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponents_T__UnityEngineGameObject_TArray<T>(WrappedId);
        }

        public void GetComponents(global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.Component> results)
        {
            internal_UnityEngineGameObject__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(WrappedId, type, results);
        }

        public global::UnityEngine.Component[] GetComponentsInChildren(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(WrappedId, type);
        }

        public global::UnityEngine.Component[] GetComponentsInChildren(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineGameObject__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(WrappedId, type, includeInactive);
        }

        public T[] GetComponentsInChildren<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineGameObject_TArray<T>(WrappedId, includeInactive);
        }

        public T[] GetComponentsInChildren<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentsInChildren_T__UnityEngineGameObject_TArray<T>(WrappedId);
        }

        public global::UnityEngine.Component[] GetComponentsInParent(global::System.Type type)
        {
            return internal_UnityEngineGameObject__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(WrappedId, type);
        }

        public global::UnityEngine.Component[] GetComponentsInParent(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineGameObject__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(WrappedId, type, includeInactive);
        }

        public T[] GetComponentsInParent<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentsInParent_T__SystemBoolean__UnityEngineGameObject_TArray<T>(WrappedId, includeInactive);
        }

        public T[] GetComponentsInParent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__GetComponentsInParent_T__UnityEngineGameObject_TArray<T>(WrappedId);
        }

        public bool TryGetComponent<T>(out T component) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineGameObject__func__TryGetComponent_T__UnityEngineGameObject_TRef__SystemBoolean<T>(WrappedId, out component);
        }

        public bool TryGetComponent(global::System.Type type, out global::UnityEngine.Component component)
        {
            return internal_UnityEngineGameObject__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(WrappedId, type, out component);
        }

        public static global::UnityEngine.GameObject FindWithTag(string tag)
        {
            return internal_UnityEngineGameObject__func__FindWithTag__SystemString__UnityEngineGameObject(tag);
        }

        public void SendMessageUpwards(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        public void SendMessage(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        public void BroadcastMessage(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        public global::UnityEngine.Component AddComponent(global::System.Type componentType)
        {
            return internal_UnityEngineGameObject__func__AddComponent__SystemType__UnityEngineComponent(WrappedId, componentType);
        }

        public T AddComponent<T>() where T : global::UnityEngine.Component
        {
            return internal_UnityEngineGameObject__func__AddComponent_T__UnityEngineGameObject_T<T>(WrappedId);
        }

        public void SetActive(bool value)
        {
            internal_UnityEngineGameObject__func__SetActive__SystemBoolean__SystemVoid(WrappedId, value);
        }

        public bool CompareTag(string tag)
        {
            return internal_UnityEngineGameObject__func__CompareTag__SystemString__SystemBoolean(WrappedId, tag);
        }

        public static global::UnityEngine.GameObject FindGameObjectWithTag(string tag)
        {
            return internal_UnityEngineGameObject__func__FindGameObjectWithTag__SystemString__UnityEngineGameObject(tag);
        }

        public static global::UnityEngine.GameObject[] FindGameObjectsWithTag(string tag)
        {
            return internal_UnityEngineGameObject__func__FindGameObjectsWithTag__SystemString__UnityEngineGameObjectArray(tag);
        }

        public void SendMessageUpwards(string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, value, options);
        }

        public void SendMessageUpwards(string methodName, object value)
        {
            internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(WrappedId, methodName, value);
        }

        public void SendMessageUpwards(string methodName)
        {
            internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void SendMessage(string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, value, options);
        }

        public void SendMessage(string methodName, object value)
        {
            internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__SystemVoid(WrappedId, methodName, value);
        }

        public void SendMessage(string methodName)
        {
            internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void BroadcastMessage(string methodName, object parameter, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, parameter, options);
        }

        public void BroadcastMessage(string methodName, object parameter)
        {
            internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(WrappedId, methodName, parameter);
        }

        public void BroadcastMessage(string methodName)
        {
            internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemVoid(WrappedId, methodName);
        }

        public static global::UnityEngine.GameObject Find(string name)
        {
            return internal_UnityEngineGameObject__func__Find__SystemString__UnityEngineGameObject(name);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineGameObject__ctor__SystemString(string name)
        {
            fixed (char* namePointer = name)
            {
                return UnityEngineGameObject__ctor__SystemString(namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineGameObject__ctor()
        {
            return UnityEngineGameObject__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineGameObject__ctor__SystemString__SystemTypeArray(string name, global::System.Type[] components)
        {
            int componentsWasmLength = components.Length;
            int[] componentsIds = new int[componentsWasmLength];
            for (int i = 0; i < componentsWasmLength; i++) componentsIds[i] = global::WasmScripting.TypeMap.GetId(components[i]);
            fixed (char* namePointer = name)
            {
                fixed (int* componentsIdsPointer = componentsIds)
                {
                    return UnityEngineGameObject__ctor__SystemString__SystemTypeArray(namePointer, name.Length * sizeof(char), componentsIdsPointer, componentsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineGameObject__get__transform(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__transform(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineGameObject__get__layer(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__layer(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__set__layer(long selfObjectId, int layer)
        {
            UnityEngineGameObject__set__layer(selfObjectId, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__get__activeSelf(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__activeSelf(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__get__activeInHierarchy(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__activeInHierarchy(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__get__isStatic(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__isStatic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__set__isStatic(long selfObjectId, bool isStatic)
        {
            var isStaticConverted = Unsafe.As<bool, int>(ref isStatic);
            UnityEngineGameObject__set__isStatic(selfObjectId, isStaticConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineGameObject__get__tag(long selfObjectId)
        {
            char* tagPointer = default;
            int tagWasmLength = default;
            UnityEngineGameObject__get__tag(selfObjectId, &tagPointer, &tagWasmLength);
            string returnResult = new(tagPointer, 0, tagWasmLength);
            Marshal.FreeHGlobal((IntPtr)tagPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__set__tag(long selfObjectId, string tag)
        {
            fixed (char* tagPointer = tag)
            {
                UnityEngineGameObject__set__tag(selfObjectId, tagPointer, tag.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.SceneManagement.Scene internal_UnityEngineGameObject__get__scene(long selfObjectId)
        {
            global::UnityEngine.SceneManagement.Scene sceneValue = default;
            UnityEngineGameObject__get__scene(selfObjectId, Unsafe.AsPointer(ref sceneValue));
            global::UnityEngine.SceneManagement.Scene returnResult = sceneValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineGameObject__get__sceneCullingMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__sceneCullingMask(selfObjectId);
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineGameObject__get__gameObject(long selfObjectId)
        {
            var methodCallResult = UnityEngineGameObject__get__gameObject(selfObjectId);
            var returnResult = new global::UnityEngine.GameObject(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineGameObject__func__CreatePrimitive__UnityEnginePrimitiveTypeEnum__UnityEngineGameObject(global::UnityEngine.PrimitiveType type)
        {
            var methodCallResult = UnityEngineGameObject__func__CreatePrimitive__UnityEnginePrimitiveTypeEnum__UnityEngineGameObject((int) type);
            var returnResult = new global::UnityEngine.GameObject(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__GetComponent_T__UnityEngineGameObject_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineGameObject__func__GetComponent_T__UnityEngineGameObject_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponent__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type type)
        {
            var methodCallResult = UnityEngineGameObject__func__GetComponent__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponent__SystemString__UnityEngineComponent(long selfObjectId, string type)
        {
            fixed (char* typePointer = type)
            {
                var methodCallResult = UnityEngineGameObject__func__GetComponent__SystemString__UnityEngineComponent(selfObjectId, typePointer, type.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Component(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineGameObject__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponentInChildren__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type type)
        {
            var methodCallResult = UnityEngineGameObject__func__GetComponentInChildren__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__GetComponentInChildren_T__UnityEngineGameObject_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineGameObject__func__GetComponentInChildren_T__UnityEngineGameObject_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__GetComponentInChildren_T__SystemBoolean__UnityEngineGameObject_T<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineGameObject__func__GetComponentInChildren_T__SystemBoolean__UnityEngineGameObject_T(selfObjectId, templateTId, includeInactiveConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineGameObject__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__GetComponentInParent__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type type)
        {
            var methodCallResult = UnityEngineGameObject__func__GetComponentInParent__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__GetComponentInParent_T__UnityEngineGameObject_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineGameObject__func__GetComponentInParent_T__UnityEngineGameObject_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__GetComponentInParent_T__SystemBoolean__UnityEngineGameObject_T<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineGameObject__func__GetComponentInParent_T__SystemBoolean__UnityEngineGameObject_T(selfObjectId, templateTId, includeInactiveConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineGameObject__func__GetComponents__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type type)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponents__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineGameObject__func__GetComponents_T__UnityEngineGameObject_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponents_T__UnityEngineGameObject_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
            T[] returnResult = new T[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                var returnResultUninitializedEntry = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
                ((IProxyObject)returnResultUninitializedEntry)!.WrappedId = returnResultIdsPointer![i];
                returnResult[i] = returnResultUninitializedEntry;
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(long selfObjectId, global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.Component> resultsList)
        {
            Span<global::UnityEngine.Component> results = CollectionsMarshal.AsSpan(resultsList);
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                UnityEngineGameObject__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(selfObjectId, global::WasmScripting.TypeMap.GetId(type), resultsIdsPointer, resultsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineGameObject__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type type)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineGameObject__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineGameObject__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineGameObject_TArray<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineGameObject_TArray(selfObjectId, templateTId, includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            T[] returnResult = new T[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                var returnResultUninitializedEntry = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
                ((IProxyObject)returnResultUninitializedEntry)!.WrappedId = returnResultIdsPointer![i];
                returnResult[i] = returnResultUninitializedEntry;
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineGameObject__func__GetComponentsInChildren_T__UnityEngineGameObject_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInChildren_T__UnityEngineGameObject_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
            T[] returnResult = new T[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                var returnResultUninitializedEntry = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
                ((IProxyObject)returnResultUninitializedEntry)!.WrappedId = returnResultIdsPointer![i];
                returnResult[i] = returnResultUninitializedEntry;
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineGameObject__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type type)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineGameObject__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineGameObject__func__GetComponentsInParent_T__SystemBoolean__UnityEngineGameObject_TArray<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInParent_T__SystemBoolean__UnityEngineGameObject_TArray(selfObjectId, templateTId, includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            T[] returnResult = new T[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                var returnResultUninitializedEntry = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
                ((IProxyObject)returnResultUninitializedEntry)!.WrappedId = returnResultIdsPointer![i];
                returnResult[i] = returnResultUninitializedEntry;
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineGameObject__func__GetComponentsInParent_T__UnityEngineGameObject_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineGameObject__func__GetComponentsInParent_T__UnityEngineGameObject_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
            T[] returnResult = new T[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                var returnResultUninitializedEntry = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
                ((IProxyObject)returnResultUninitializedEntry)!.WrappedId = returnResultIdsPointer![i];
                returnResult[i] = returnResultUninitializedEntry;
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__func__TryGetComponent_T__UnityEngineGameObject_TRef__SystemBoolean<T>(long selfObjectId, out T component) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long componentObjectId = default;
            int componentType = default;
            var methodCallResult = UnityEngineGameObject__func__TryGetComponent_T__UnityEngineGameObject_TRef__SystemBoolean(selfObjectId, templateTId, &componentObjectId, &componentType);
            component = RuntimeHelpers.GetUninitializedObject(global::WasmScripting.TypeMap.GetType(componentType)) as T;
            ((IProxyObject)component)!.WrappedId = componentObjectId;
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(long selfObjectId, global::System.Type type, out global::UnityEngine.Component component)
        {
            long componentObjectId = default;
            int componentType = default;
            var methodCallResult = UnityEngineGameObject__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &componentObjectId, &componentType);
            component = RuntimeHelpers.GetUninitializedObject(global::WasmScripting.TypeMap.GetType(componentType)) as global::UnityEngine.Component;
            component!.WrappedId = componentObjectId;
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineGameObject__func__FindWithTag__SystemString__UnityEngineGameObject(string tag)
        {
            fixed (char* tagPointer = tag)
            {
                var methodCallResult = UnityEngineGameObject__func__FindWithTag__SystemString__UnityEngineGameObject(tagPointer, tag.Length * sizeof(char));
                var returnResult = new global::UnityEngine.GameObject(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineGameObject__func__AddComponent__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type componentType)
        {
            var methodCallResult = UnityEngineGameObject__func__AddComponent__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(componentType));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineGameObject__func__AddComponent_T__UnityEngineGameObject_T<T>(long selfObjectId) where T : global::UnityEngine.Component
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineGameObject__func__AddComponent_T__UnityEngineGameObject_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SetActive__SystemBoolean__SystemVoid(long selfObjectId, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineGameObject__func__SetActive__SystemBoolean__SystemVoid(selfObjectId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGameObject__func__CompareTag__SystemString__SystemBoolean(long selfObjectId, string tag)
        {
            fixed (char* tagPointer = tag)
            {
                var methodCallResult = UnityEngineGameObject__func__CompareTag__SystemString__SystemBoolean(selfObjectId, tagPointer, tag.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineGameObject__func__FindGameObjectWithTag__SystemString__UnityEngineGameObject(string tag)
        {
            fixed (char* tagPointer = tag)
            {
                var methodCallResult = UnityEngineGameObject__func__FindGameObjectWithTag__SystemString__UnityEngineGameObject(tagPointer, tag.Length * sizeof(char));
                var returnResult = new global::UnityEngine.GameObject(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject[] internal_UnityEngineGameObject__func__FindGameObjectsWithTag__SystemString__UnityEngineGameObjectArray(string tag)
        {
            fixed (char* tagPointer = tag)
            {
                long* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineGameObject__func__FindGameObjectsWithTag__SystemString__UnityEngineGameObjectArray(tagPointer, tag.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.GameObject[] returnResult = new global::UnityEngine.GameObject[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = new global::UnityEngine.GameObject(returnResultIdsPointer![i]);
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object value)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object value)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__SendMessage__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__SendMessage__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object parameter, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (parameter as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object parameter)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (parameter as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineGameObject__func__Find__SystemString__UnityEngineGameObject(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineGameObject__func__Find__SystemString__UnityEngineGameObject(namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.GameObject(methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__ctor__SystemString(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__ctor__SystemString__SystemTypeArray(void* namePointer, int nameWasmLength, void* componentsIdsPointer, int componentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__get__transform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGameObject__get__layer(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGameObject__set__layer(long selfObjectId, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGameObject__get__activeSelf(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGameObject__get__activeInHierarchy(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGameObject__get__isStatic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGameObject__set__isStatic(long selfObjectId, int isStaticConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__get__tag(long selfObjectId, void* tagPointer, void* tagWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__set__tag(long selfObjectId, void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__get__scene(long selfObjectId, void* scenePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__get__sceneCullingMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__get__gameObject(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__CreatePrimitive__UnityEnginePrimitiveTypeEnum__UnityEngineGameObject(int typeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponent_T__UnityEngineGameObject_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponent__SystemType__UnityEngineComponent(long selfObjectId, int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__func__GetComponent__SystemString__UnityEngineComponent(long selfObjectId, void* typePointer, int typeWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, int typeId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInChildren__SystemType__UnityEngineComponent(long selfObjectId, int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInChildren_T__UnityEngineGameObject_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInChildren_T__SystemBoolean__UnityEngineGameObject_T(long selfObjectId, int templateTId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, int typeId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInParent__SystemType__UnityEngineComponent(long selfObjectId, int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInParent_T__UnityEngineGameObject_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__GetComponentInParent_T__SystemBoolean__UnityEngineGameObject_T(long selfObjectId, int templateTId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponents__SystemType__UnityEngineComponentArray(long selfObjectId, int typeId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponents_T__UnityEngineGameObject_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(long selfObjectId, int typeId, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(long selfObjectId, int typeId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, int typeId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineGameObject_TArray(long selfObjectId, int templateTId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInChildren_T__UnityEngineGameObject_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(long selfObjectId, int typeId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, int typeId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInParent_T__SystemBoolean__UnityEngineGameObject_TArray(long selfObjectId, int templateTId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__GetComponentsInParent_T__UnityEngineGameObject_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineGameObject__func__TryGetComponent_T__UnityEngineGameObject_TRef__SystemBoolean(long selfObjectId, int templateTId, void* componentObjectIdPointer, void* componentTypePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineGameObject__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(long selfObjectId, int typeId, void* componentObjectIdPointer, void* componentTypePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__func__FindWithTag__SystemString__UnityEngineGameObject(void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__AddComponent__SystemType__UnityEngineComponent(long selfObjectId, int componentTypeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGameObject__func__AddComponent_T__UnityEngineGameObject_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGameObject__func__SetActive__SystemBoolean__SystemVoid(long selfObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineGameObject__func__CompareTag__SystemString__SystemBoolean(long selfObjectId, void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__func__FindGameObjectWithTag__SystemString__UnityEngineGameObject(void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__FindGameObjectsWithTag__SystemString__UnityEngineGameObjectArray(void* tagPointer, int tagWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessageUpwards__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__SendMessage__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long parameterObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long parameterObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGameObject__func__BroadcastMessage__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineGameObject__func__Find__SystemString__UnityEngineGameObject(void* namePointer, int nameWasmLength);

        #endregion Imports
    }
}
