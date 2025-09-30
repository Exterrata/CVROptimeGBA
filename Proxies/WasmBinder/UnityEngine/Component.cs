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

    public partial class Component(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.Transform transform 
        {
            get => internal_UnityEngineComponent__get__transform(WrappedId);
        }

        public global::UnityEngine.GameObject gameObject 
        {
            get => internal_UnityEngineComponent__get__gameObject(WrappedId);
        }

        public string tag 
        {
            get => internal_UnityEngineComponent__get__tag(WrappedId);
            set => internal_UnityEngineComponent__set__tag(WrappedId, value);
        }

        public global::UnityEngine.Component GetComponent(global::System.Type type)
        {
            return internal_UnityEngineComponent__func__GetComponent__SystemType__UnityEngineComponent(WrappedId, type);
        }

        public T GetComponent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponent_T__UnityEngineComponent_T<T>(WrappedId);
        }

        public bool TryGetComponent(global::System.Type type, out global::UnityEngine.Component component)
        {
            return internal_UnityEngineComponent__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(WrappedId, type, out component);
        }

        public bool TryGetComponent<T>(out T component) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__TryGetComponent_T__UnityEngineComponent_TRef__SystemBoolean<T>(WrappedId, out component);
        }

        public global::UnityEngine.Component GetComponent(string type)
        {
            return internal_UnityEngineComponent__func__GetComponent__SystemString__UnityEngineComponent(WrappedId, type);
        }

        public global::UnityEngine.Component GetComponentInChildren(global::System.Type t, bool includeInactive)
        {
            return internal_UnityEngineComponent__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(WrappedId, t, includeInactive);
        }

        public global::UnityEngine.Component GetComponentInChildren(global::System.Type t)
        {
            return internal_UnityEngineComponent__func__GetComponentInChildren__SystemType__UnityEngineComponent(WrappedId, t);
        }

        public T GetComponentInChildren<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentInChildren_T__SystemBoolean__UnityEngineComponent_T<T>(WrappedId, includeInactive);
        }

        public T GetComponentInChildren<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentInChildren_T__UnityEngineComponent_T<T>(WrappedId);
        }

        public global::UnityEngine.Component[] GetComponentsInChildren(global::System.Type t, bool includeInactive)
        {
            return internal_UnityEngineComponent__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(WrappedId, t, includeInactive);
        }

        public global::UnityEngine.Component[] GetComponentsInChildren(global::System.Type t)
        {
            return internal_UnityEngineComponent__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(WrappedId, t);
        }

        public T[] GetComponentsInChildren<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineComponent_TArray<T>(WrappedId, includeInactive);
        }

        public T[] GetComponentsInChildren<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentsInChildren_T__UnityEngineComponent_TArray<T>(WrappedId);
        }

        public global::UnityEngine.Component GetComponentInParent(global::System.Type t, bool includeInactive)
        {
            return internal_UnityEngineComponent__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(WrappedId, t, includeInactive);
        }

        public global::UnityEngine.Component GetComponentInParent(global::System.Type t)
        {
            return internal_UnityEngineComponent__func__GetComponentInParent__SystemType__UnityEngineComponent(WrappedId, t);
        }

        public T GetComponentInParent<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentInParent_T__SystemBoolean__UnityEngineComponent_T<T>(WrappedId, includeInactive);
        }

        public T GetComponentInParent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentInParent_T__UnityEngineComponent_T<T>(WrappedId);
        }

        public global::UnityEngine.Component[] GetComponentsInParent(global::System.Type t, bool includeInactive)
        {
            return internal_UnityEngineComponent__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(WrappedId, t, includeInactive);
        }

        public global::UnityEngine.Component[] GetComponentsInParent(global::System.Type t)
        {
            return internal_UnityEngineComponent__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(WrappedId, t);
        }

        public T[] GetComponentsInParent<T>(bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentsInParent_T__SystemBoolean__UnityEngineComponent_TArray<T>(WrappedId, includeInactive);
        }

        public T[] GetComponentsInParent<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponentsInParent_T__UnityEngineComponent_TArray<T>(WrappedId);
        }

        public global::UnityEngine.Component[] GetComponents(global::System.Type type)
        {
            return internal_UnityEngineComponent__func__GetComponents__SystemType__UnityEngineComponentArray(WrappedId, type);
        }

        public void GetComponents(global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.Component> results)
        {
            internal_UnityEngineComponent__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(WrappedId, type, results);
        }

        public T[] GetComponents<T>() where T : class /* Added as fallback (allows as T cast) */
        {
            return internal_UnityEngineComponent__func__GetComponents_T__UnityEngineComponent_TArray<T>(WrappedId);
        }

        public bool CompareTag(string tag)
        {
            return internal_UnityEngineComponent__func__CompareTag__SystemString__SystemBoolean(WrappedId, tag);
        }

        public void SendMessageUpwards(string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, value, options);
        }

        public void SendMessageUpwards(string methodName, object value)
        {
            internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(WrappedId, methodName, value);
        }

        public void SendMessageUpwards(string methodName)
        {
            internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void SendMessageUpwards(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        public void SendMessage(string methodName, object value)
        {
            internal_UnityEngineComponent__func__SendMessage__SystemString__SystemObject__SystemVoid(WrappedId, methodName, value);
        }

        public void SendMessage(string methodName)
        {
            internal_UnityEngineComponent__func__SendMessage__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void SendMessage(string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, value, options);
        }

        public void SendMessage(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        public void BroadcastMessage(string methodName, object parameter, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, parameter, options);
        }

        public void BroadcastMessage(string methodName, object parameter)
        {
            internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(WrappedId, methodName, parameter);
        }

        public void BroadcastMessage(string methodName)
        {
            internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void BroadcastMessage(string methodName, global::UnityEngine.SendMessageOptions options)
        {
            internal_UnityEngineComponent__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(WrappedId, methodName, options);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineComponent__get__transform(long selfObjectId)
        {
            var methodCallResult = UnityEngineComponent__get__transform(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineComponent__get__gameObject(long selfObjectId)
        {
            var methodCallResult = UnityEngineComponent__get__gameObject(selfObjectId);
            var returnResult = new global::UnityEngine.GameObject(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineComponent__get__tag(long selfObjectId)
        {
            char* tagPointer = default;
            int tagWasmLength = default;
            UnityEngineComponent__get__tag(selfObjectId, &tagPointer, &tagWasmLength);
            string returnResult = new(tagPointer, 0, tagWasmLength);
            Marshal.FreeHGlobal((IntPtr)tagPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__set__tag(long selfObjectId, string tag)
        {
            fixed (char* tagPointer = tag)
            {
                UnityEngineComponent__set__tag(selfObjectId, tagPointer, tag.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponent__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type type)
        {
            var methodCallResult = UnityEngineComponent__func__GetComponent__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(type));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineComponent__func__GetComponent_T__UnityEngineComponent_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineComponent__func__GetComponent_T__UnityEngineComponent_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComponent__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(long selfObjectId, global::System.Type type, out global::UnityEngine.Component component)
        {
            long componentObjectId = default;
            int componentType = default;
            var methodCallResult = UnityEngineComponent__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &componentObjectId, &componentType);
            component = RuntimeHelpers.GetUninitializedObject(global::WasmScripting.TypeMap.GetType(componentType)) as global::UnityEngine.Component;
            component!.WrappedId = componentObjectId;
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComponent__func__TryGetComponent_T__UnityEngineComponent_TRef__SystemBoolean<T>(long selfObjectId, out T component) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long componentObjectId = default;
            int componentType = default;
            var methodCallResult = UnityEngineComponent__func__TryGetComponent_T__UnityEngineComponent_TRef__SystemBoolean(selfObjectId, templateTId, &componentObjectId, &componentType);
            component = RuntimeHelpers.GetUninitializedObject(global::WasmScripting.TypeMap.GetType(componentType)) as T;
            ((IProxyObject)component)!.WrappedId = componentObjectId;
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponent__SystemString__UnityEngineComponent(long selfObjectId, string type)
        {
            fixed (char* typePointer = type)
            {
                var methodCallResult = UnityEngineComponent__func__GetComponent__SystemString__UnityEngineComponent(selfObjectId, typePointer, type.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Component(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, global::System.Type t, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineComponent__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(t), includeInactiveConverted);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponentInChildren__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type t)
        {
            var methodCallResult = UnityEngineComponent__func__GetComponentInChildren__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(t));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineComponent__func__GetComponentInChildren_T__SystemBoolean__UnityEngineComponent_T<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineComponent__func__GetComponentInChildren_T__SystemBoolean__UnityEngineComponent_T(selfObjectId, templateTId, includeInactiveConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineComponent__func__GetComponentInChildren_T__UnityEngineComponent_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineComponent__func__GetComponentInChildren_T__UnityEngineComponent_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineComponent__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, global::System.Type t, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(t), includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineComponent__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type t)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(t), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineComponent__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineComponent_TArray<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineComponent_TArray(selfObjectId, templateTId, includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T[] internal_UnityEngineComponent__func__GetComponentsInChildren_T__UnityEngineComponent_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInChildren_T__UnityEngineComponent_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, global::System.Type t, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineComponent__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(t), includeInactiveConverted);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineComponent__func__GetComponentInParent__SystemType__UnityEngineComponent(long selfObjectId, global::System.Type t)
        {
            var methodCallResult = UnityEngineComponent__func__GetComponentInParent__SystemType__UnityEngineComponent(selfObjectId, global::WasmScripting.TypeMap.GetId(t));
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineComponent__func__GetComponentInParent_T__SystemBoolean__UnityEngineComponent_T<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            var methodCallResult = UnityEngineComponent__func__GetComponentInParent_T__SystemBoolean__UnityEngineComponent_T(selfObjectId, templateTId, includeInactiveConverted);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T internal_UnityEngineComponent__func__GetComponentInParent_T__UnityEngineComponent_T<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var methodCallResult = UnityEngineComponent__func__GetComponentInParent_T__UnityEngineComponent_T(selfObjectId, templateTId);
            var returnResult = RuntimeHelpers.GetUninitializedObject(typeof(T)) as T;
            ((IProxyObject)returnResult)!.WrappedId = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineComponent__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, global::System.Type t, bool includeInactive)
        {
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(t), includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineComponent__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type t)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(t), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineComponent__func__GetComponentsInParent_T__SystemBoolean__UnityEngineComponent_TArray<T>(long selfObjectId, bool includeInactive) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            var includeInactiveConverted = Unsafe.As<bool, int>(ref includeInactive);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInParent_T__SystemBoolean__UnityEngineComponent_TArray(selfObjectId, templateTId, includeInactiveConverted, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe T[] internal_UnityEngineComponent__func__GetComponentsInParent_T__UnityEngineComponent_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponentsInParent_T__UnityEngineComponent_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Component[] internal_UnityEngineComponent__func__GetComponents__SystemType__UnityEngineComponentArray(long selfObjectId, global::System.Type type)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponents__SystemType__UnityEngineComponentArray(selfObjectId, global::WasmScripting.TypeMap.GetId(type), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Component[] returnResult = new global::UnityEngine.Component[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Component(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(long selfObjectId, global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.Component> resultsList)
        {
            Span<global::UnityEngine.Component> results = CollectionsMarshal.AsSpan(resultsList);
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                UnityEngineComponent__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(selfObjectId, global::WasmScripting.TypeMap.GetId(type), resultsIdsPointer, resultsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe T[] internal_UnityEngineComponent__func__GetComponents_T__UnityEngineComponent_TArray<T>(long selfObjectId) where T : class /* Added as fallback (allows as T cast) */
        {
            int templateTId = global::WasmScripting.TypeMap.GetId(typeof(T));
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineComponent__func__GetComponents_T__UnityEngineComponent_TArray(selfObjectId, templateTId, &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe bool internal_UnityEngineComponent__func__CompareTag__SystemString__SystemBoolean(long selfObjectId, string tag)
        {
            fixed (char* tagPointer = tag)
            {
                var methodCallResult = UnityEngineComponent__func__CompareTag__SystemString__SystemBoolean(selfObjectId, tagPointer, tag.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object value)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object value)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__SendMessage__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessage__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__SendMessage__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object value, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, object parameter, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (parameter as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, (int) options);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, string methodName, object parameter)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (parameter as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__BroadcastMessage__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__BroadcastMessage__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComponent__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, string methodName, global::UnityEngine.SendMessageOptions options)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineComponent__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (int) options);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__get__transform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__get__gameObject(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__get__tag(long selfObjectId, void* tagPointer, void* tagWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__set__tag(long selfObjectId, void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponent__SystemType__UnityEngineComponent(long selfObjectId, int typeId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponent_T__UnityEngineComponent_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComponent__func__TryGetComponent__SystemType__UnityEngineComponentRef__SystemBoolean(long selfObjectId, int typeId, void* componentObjectIdPointer, void* componentTypePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComponent__func__TryGetComponent_T__UnityEngineComponent_TRef__SystemBoolean(long selfObjectId, int templateTId, void* componentObjectIdPointer, void* componentTypePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineComponent__func__GetComponent__SystemString__UnityEngineComponent(long selfObjectId, void* typePointer, int typeWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInChildren__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, int tId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInChildren__SystemType__UnityEngineComponent(long selfObjectId, int tId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInChildren_T__SystemBoolean__UnityEngineComponent_T(long selfObjectId, int templateTId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInChildren_T__UnityEngineComponent_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInChildren__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, int tId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInChildren__SystemType__UnityEngineComponentArray(long selfObjectId, int tId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInChildren_T__SystemBoolean__UnityEngineComponent_TArray(long selfObjectId, int templateTId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInChildren_T__UnityEngineComponent_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInParent__SystemType__SystemBoolean__UnityEngineComponent(long selfObjectId, int tId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInParent__SystemType__UnityEngineComponent(long selfObjectId, int tId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInParent_T__SystemBoolean__UnityEngineComponent_T(long selfObjectId, int templateTId, int includeInactiveConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComponent__func__GetComponentInParent_T__UnityEngineComponent_T(long selfObjectId, int templateTId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInParent__SystemType__SystemBoolean__UnityEngineComponentArray(long selfObjectId, int tId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInParent__SystemType__UnityEngineComponentArray(long selfObjectId, int tId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInParent_T__SystemBoolean__UnityEngineComponent_TArray(long selfObjectId, int templateTId, int includeInactiveConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponentsInParent_T__UnityEngineComponent_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponents__SystemType__UnityEngineComponentArray(long selfObjectId, int typeId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponents__SystemType__SystemCollectionsGeneric_List_UnityEngineComponent__SystemVoid(long selfObjectId, int typeId, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__GetComponents_T__UnityEngineComponent_TArray(long selfObjectId, int templateTId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComponent__func__CompareTag__SystemString__SystemBoolean(long selfObjectId, void* tagPointer, int tagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessageUpwards__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessageUpwards__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessage__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__SendMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long parameterObjectId, int optionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__BroadcastMessage__SystemString__SystemObject__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long parameterObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__BroadcastMessage__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComponent__func__BroadcastMessage__SystemString__UnityEngineSendMessageOptionsEnum__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, int optionsUnderlyingValue);

        #endregion Imports
    }
}
