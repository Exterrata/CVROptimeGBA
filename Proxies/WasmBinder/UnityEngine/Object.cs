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

    public partial class Object(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Object()
            : this(internal_UnityEngineObject__ctor()) { }

        public string name 
        {
            get => internal_UnityEngineObject__get__name(WrappedId);
            set => internal_UnityEngineObject__set__name(WrappedId, value);
        }

        public global::UnityEngine.HideFlags hideFlags 
        {
            get => internal_UnityEngineObject__get__hideFlags(WrappedId);
            set => internal_UnityEngineObject__set__hideFlags(WrappedId, value);
        }

        public int GetInstanceID()
        {
            return internal_UnityEngineObject__func__GetInstanceID__SystemInt32(WrappedId);
        }
        
        public static global::UnityEngine.Object Instantiate(global::UnityEngine.Object original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject(original, position, rotation);
        }

        public static global::UnityEngine.Object Instantiate(global::UnityEngine.Object original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Transform parent)
        {
            return internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject(original, position, rotation, parent);
        }

        public static global::UnityEngine.Object Instantiate(global::UnityEngine.Object original)
        {
            return internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineObject(original);
        }

        public static global::UnityEngine.Object Instantiate(global::UnityEngine.Object original, global::UnityEngine.Transform parent)
        {
            return internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__UnityEngineObject(original, parent);
        }

        public static global::UnityEngine.Object Instantiate(global::UnityEngine.Object original, global::UnityEngine.Transform parent, bool instantiateInWorldSpace)
        {
            return internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__SystemBoolean__UnityEngineObject(original, parent, instantiateInWorldSpace);
        }

        public static T Instantiate<T>(T original) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineObject_T<T>(original);
        }

        public static T Instantiate<T>(T original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject_T<T>(original, position, rotation);
        }

        public static T Instantiate<T>(T original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Transform parent) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject_T<T>(original, position, rotation, parent);
        }

        public static T Instantiate<T>(T original, global::UnityEngine.Transform parent) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__UnityEngineObject_T<T>(original, parent);
        }

        public static T Instantiate<T>(T original, global::UnityEngine.Transform parent, bool worldPositionStays) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__SystemBoolean__UnityEngineObject_T<T>(original, parent, worldPositionStays);
        }

        public static void Destroy(global::UnityEngine.Object obj, float t)
        {
            internal_UnityEngineObject__func__Destroy__UnityEngineObject__SystemSingle__SystemVoid(obj, t);
        }

        public static void Destroy(global::UnityEngine.Object obj)
        {
            internal_UnityEngineObject__func__Destroy__UnityEngineObject__SystemVoid(obj);
        }

        public static void DestroyImmediate(global::UnityEngine.Object obj, bool allowDestroyingAssets)
        {
            internal_UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemBoolean__SystemVoid(obj, allowDestroyingAssets);
        }

        public static void DestroyImmediate(global::UnityEngine.Object obj)
        {
            internal_UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemVoid(obj);
        }

        public static global::UnityEngine.Object[] FindObjectsOfType(global::System.Type type)
        {
            return internal_UnityEngineObject__func__FindObjectsOfType__SystemType__UnityEngineObjectArray(type);
        }

        public static global::UnityEngine.Object[] FindObjectsOfType(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineObject__func__FindObjectsOfType__SystemType__SystemBoolean__UnityEngineObjectArray(type, includeInactive);
        }

        public static global::UnityEngine.Object[] FindObjectsByType(global::System.Type type, global::UnityEngine.FindObjectsSortMode sortMode)
        {
            return internal_UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(type, sortMode);
        }

        public static global::UnityEngine.Object[] FindObjectsByType(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive, global::UnityEngine.FindObjectsSortMode sortMode)
        {
            return internal_UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(type, findObjectsInactive, sortMode);
        }

        public static void DontDestroyOnLoad(global::UnityEngine.Object target)
        {
            internal_UnityEngineObject__func__DontDestroyOnLoad__UnityEngineObject__SystemVoid(target);
        }

        public static T[] FindObjectsOfType<T>() where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectsOfType_T__UnityEngineObject_TArray<T>();
        }

        public static T[] FindObjectsByType<T>(global::UnityEngine.FindObjectsSortMode sortMode) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray<T>(sortMode);
        }

        public static T[] FindObjectsOfType<T>(bool includeInactive) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectsOfType_T__SystemBoolean__UnityEngineObject_TArray<T>(includeInactive);
        }

        public static T[] FindObjectsByType<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive, global::UnityEngine.FindObjectsSortMode sortMode) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray<T>(findObjectsInactive, sortMode);
        }

        public static T FindObjectOfType<T>() where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectOfType_T__UnityEngineObject_T<T>();
        }

        public static T FindObjectOfType<T>(bool includeInactive) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindObjectOfType_T__SystemBoolean__UnityEngineObject_T<T>(includeInactive);
        }

        public static T FindFirstObjectByType<T>() where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineObject_T<T>();
        }

        public static T FindAnyObjectByType<T>() where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineObject_T<T>();
        }

        public static T FindFirstObjectByType<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T<T>(findObjectsInactive);
        }

        public static T FindAnyObjectByType<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive) where T : global::UnityEngine.Object
        {
            return internal_UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T<T>(findObjectsInactive);
        }

        public static global::UnityEngine.Object FindObjectOfType(global::System.Type type)
        {
            return internal_UnityEngineObject__func__FindObjectOfType__SystemType__UnityEngineObject(type);
        }

        public static global::UnityEngine.Object FindFirstObjectByType(global::System.Type type)
        {
            return internal_UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineObject(type);
        }

        public static global::UnityEngine.Object FindAnyObjectByType(global::System.Type type)
        {
            return internal_UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineObject(type);
        }

        public static global::UnityEngine.Object FindObjectOfType(global::System.Type type, bool includeInactive)
        {
            return internal_UnityEngineObject__func__FindObjectOfType__SystemType__SystemBoolean__UnityEngineObject(type, includeInactive);
        }

        public static global::UnityEngine.Object FindFirstObjectByType(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive)
        {
            return internal_UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(type, findObjectsInactive);
        }

        public static global::UnityEngine.Object FindAnyObjectByType(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive)
        {
            return internal_UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(type, findObjectsInactive);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineObject__ctor()
        {
            return UnityEngineObject__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineObject__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineObject__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineObject__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.HideFlags internal_UnityEngineObject__get__hideFlags(long selfObjectId)
        {
            var methodCallResult = UnityEngineObject__get__hideFlags(selfObjectId);
            var returnResult = (global::UnityEngine.HideFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__set__hideFlags(long selfObjectId, global::UnityEngine.HideFlags hideFlags)
        {
            UnityEngineObject__set__hideFlags(selfObjectId, (int) hideFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineObject__func__GetInstanceID__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineObject__func__GetInstanceID__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject(global::UnityEngine.Object original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            var methodCallResult = UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject(original.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject(global::UnityEngine.Object original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Transform parent)
        {
            var methodCallResult = UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject(original.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), parent.WrappedId);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineObject(global::UnityEngine.Object original)
        {
            var methodCallResult = UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineObject(original.WrappedId);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__UnityEngineObject(global::UnityEngine.Object original, global::UnityEngine.Transform parent)
        {
            var methodCallResult = UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__UnityEngineObject(original.WrappedId, parent.WrappedId);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__SystemBoolean__UnityEngineObject(global::UnityEngine.Object original, global::UnityEngine.Transform parent, bool instantiateInWorldSpace)
        {
            var instantiateInWorldSpaceConverted = Unsafe.As<bool, int>(ref instantiateInWorldSpace);
            var methodCallResult = UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__SystemBoolean__UnityEngineObject(original.WrappedId, parent.WrappedId, instantiateInWorldSpaceConverted);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineObject_T<T>(T original) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineObject_T(templateTId, original.WrappedId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject_T<T>(T original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject_T(templateTId, original.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject_T<T>(T original, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Transform parent) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject_T(templateTId, original.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), parent.WrappedId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__UnityEngineObject_T<T>(T original, global::UnityEngine.Transform parent) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__UnityEngineObject_T(templateTId, original.WrappedId, parent.WrappedId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__SystemBoolean__UnityEngineObject_T<T>(T original, global::UnityEngine.Transform parent, bool worldPositionStays) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var worldPositionStaysConverted = Unsafe.As<bool, int>(ref worldPositionStays);
            var methodCallResult = UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__SystemBoolean__UnityEngineObject_T(templateTId, original.WrappedId, parent.WrappedId, worldPositionStaysConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__func__Destroy__UnityEngineObject__SystemSingle__SystemVoid(global::UnityEngine.Object obj, float t)
        {
            UnityEngineObject__func__Destroy__UnityEngineObject__SystemSingle__SystemVoid(obj.WrappedId, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__func__Destroy__UnityEngineObject__SystemVoid(global::UnityEngine.Object obj)
        {
            UnityEngineObject__func__Destroy__UnityEngineObject__SystemVoid(obj.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemBoolean__SystemVoid(global::UnityEngine.Object obj, bool allowDestroyingAssets)
        {
            var allowDestroyingAssetsConverted = Unsafe.As<bool, int>(ref allowDestroyingAssets);
            UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemBoolean__SystemVoid(obj.WrappedId, allowDestroyingAssetsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemVoid(global::UnityEngine.Object obj)
        {
            UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemVoid(obj.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object[] internal_UnityEngineObject__func__FindObjectsOfType__SystemType__UnityEngineObjectArray(global::System.Type type)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsOfType__SystemType__UnityEngineObjectArray(global::WasmScripting.TypeMap.GetId(type), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Object[] returnResult = new global::UnityEngine.Object[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Object(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object[] internal_UnityEngineObject__func__FindObjectsOfType__SystemType__SystemBoolean__UnityEngineObjectArray(global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsOfType__SystemType__SystemBoolean__UnityEngineObjectArray(global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Object[] returnResult = new global::UnityEngine.Object[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Object(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object[] internal_UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(global::System.Type type, global::UnityEngine.FindObjectsSortMode sortMode)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(global::WasmScripting.TypeMap.GetId(type), (int) sortMode, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Object[] returnResult = new global::UnityEngine.Object[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Object(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object[] internal_UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive, global::UnityEngine.FindObjectsSortMode sortMode)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(global::WasmScripting.TypeMap.GetId(type), (int) findObjectsInactive, (int) sortMode, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Object[] returnResult = new global::UnityEngine.Object[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Object(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineObject__func__DontDestroyOnLoad__UnityEngineObject__SystemVoid(global::UnityEngine.Object target)
        {
            UnityEngineObject__func__DontDestroyOnLoad__UnityEngineObject__SystemVoid(target.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineObject__func__FindObjectsOfType_T__UnityEngineObject_TArray<T>() where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsOfType_T__UnityEngineObject_TArray(templateTId, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T[] internal_UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray<T>(global::UnityEngine.FindObjectsSortMode sortMode) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray(templateTId, (int) sortMode, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T[] internal_UnityEngineObject__func__FindObjectsOfType_T__SystemBoolean__UnityEngineObject_TArray<T>(bool includeInactive) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsOfType_T__SystemBoolean__UnityEngineObject_TArray(templateTId, includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T[] internal_UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive, global::UnityEngine.FindObjectsSortMode sortMode) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray(templateTId, (int) findObjectsInactive, (int) sortMode, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T internal_UnityEngineObject__func__FindObjectOfType_T__UnityEngineObject_T<T>() where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__FindObjectOfType_T__UnityEngineObject_T(templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__FindObjectOfType_T__SystemBoolean__UnityEngineObject_T<T>(bool includeInactive) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineObject__func__FindObjectOfType_T__SystemBoolean__UnityEngineObject_T(templateTId, includeInactiveConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineObject_T<T>() where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineObject_T(templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineObject_T<T>() where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineObject_T(templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T(templateTId, (int) findObjectsInactive);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T<T>(global::UnityEngine.FindObjectsInactive findObjectsInactive) where T : global::UnityEngine.Object
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T(templateTId, (int) findObjectsInactive);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindObjectOfType__SystemType__UnityEngineObject(global::System.Type type)
        {
            var methodCallResult = UnityEngineObject__func__FindObjectOfType__SystemType__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineObject(global::System.Type type)
        {
            var methodCallResult = UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineObject(global::System.Type type)
        {
            var methodCallResult = UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindObjectOfType__SystemType__SystemBoolean__UnityEngineObject(global::System.Type type, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineObject__func__FindObjectOfType__SystemType__SystemBoolean__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type), includeInactiveConverted);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive)
        {
            var methodCallResult = UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type), (int) findObjectsInactive);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(global::System.Type type, global::UnityEngine.FindObjectsInactive findObjectsInactive)
        {
            var methodCallResult = UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(global::WasmScripting.TypeMap.GetId(type), (int) findObjectsInactive);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineObject__get__hideFlags(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__set__hideFlags(long selfObjectId, int hideFlagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineObject__func__GetInstanceID__SystemInt32(long selfObjectId);
        
        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject(long originalObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject(long originalObjectId, void* positionPointer, void* rotationPointer, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineObject(long originalObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__UnityEngineObject(long originalObjectId, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate__UnityEngineObject__UnityEngineTransform__SystemBoolean__UnityEngineObject(long originalObjectId, long parentObjectId, int instantiateInWorldSpaceConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineObject_T(int templateTId, long originalObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineObject_T(int templateTId, long originalObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineVector3__UnityEngineQuaternion__UnityEngineTransform__UnityEngineObject_T(int templateTId, long originalObjectId, void* positionPointer, void* rotationPointer, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__UnityEngineObject_T(int templateTId, long originalObjectId, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__Instantiate_T__UnityEngineObject_T__UnityEngineTransform__SystemBoolean__UnityEngineObject_T(int templateTId, long originalObjectId, long parentObjectId, int worldPositionStaysConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__func__Destroy__UnityEngineObject__SystemSingle__SystemVoid(long objObjectId, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__func__Destroy__UnityEngineObject__SystemVoid(long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemBoolean__SystemVoid(long objObjectId, int allowDestroyingAssetsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__func__DestroyImmediate__UnityEngineObject__SystemVoid(long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsOfType__SystemType__UnityEngineObjectArray(int typeId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsOfType__SystemType__SystemBoolean__UnityEngineObjectArray(int typeId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(int typeId, int sortModeUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObjectArray(int typeId, int findObjectsInactiveUnderlyingValue, int sortModeUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineObject__func__DontDestroyOnLoad__UnityEngineObject__SystemVoid(long targetObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsOfType_T__UnityEngineObject_TArray(int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray(int templateTId, int sortModeUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsOfType_T__SystemBoolean__UnityEngineObject_TArray(int templateTId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineObject__func__FindObjectsByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineFindObjectsSortModeEnum__UnityEngineObject_TArray(int templateTId, int findObjectsInactiveUnderlyingValue, int sortModeUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindObjectOfType_T__UnityEngineObject_T(int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindObjectOfType_T__SystemBoolean__UnityEngineObject_T(int templateTId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineObject_T(int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineObject_T(int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindFirstObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T(int templateTId, int findObjectsInactiveUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindAnyObjectByType_T__UnityEngineFindObjectsInactiveEnum__UnityEngineObject_T(int templateTId, int findObjectsInactiveUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindObjectOfType__SystemType__UnityEngineObject(int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineObject(int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineObject(int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindObjectOfType__SystemType__SystemBoolean__UnityEngineObject(int typeId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindFirstObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(int typeId, int findObjectsInactiveUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineObject__func__FindAnyObjectByType__SystemType__UnityEngineFindObjectsInactiveEnum__UnityEngineObject(int typeId, int findObjectsInactiveUnderlyingValue);
        
        #endregion Imports
    }
}
