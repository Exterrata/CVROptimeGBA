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

    public partial class MonoBehaviour(long id) : Behaviour(id)
    {

        #region Implementation

// Todo: Clean this up
public MonoBehaviour() : this(0) { }
        public bool useGUILayout 
        {
            get => internal_UnityEngineMonoBehaviour__get__useGUILayout(WrappedId);
            set => internal_UnityEngineMonoBehaviour__set__useGUILayout(WrappedId, value);
        }

        public bool IsInvoking()
        {
            return internal_UnityEngineMonoBehaviour__func__IsInvoking__SystemBoolean(WrappedId);
        }

        public void CancelInvoke()
        {
            internal_UnityEngineMonoBehaviour__func__CancelInvoke__SystemVoid(WrappedId);
        }

        public void Invoke(string methodName, float time)
        {
            internal_UnityEngineMonoBehaviour__func__Invoke__SystemString__SystemSingle__SystemVoid(WrappedId, methodName, time);
        }

        public void InvokeRepeating(string methodName, float time, float repeatRate)
        {
            internal_UnityEngineMonoBehaviour__func__InvokeRepeating__SystemString__SystemSingle__SystemSingle__SystemVoid(WrappedId, methodName, time, repeatRate);
        }

        public void CancelInvoke(string methodName)
        {
            internal_UnityEngineMonoBehaviour__func__CancelInvoke__SystemString__SystemVoid(WrappedId, methodName);
        }

        public bool IsInvoking(string methodName)
        {
            return internal_UnityEngineMonoBehaviour__func__IsInvoking__SystemString__SystemBoolean(WrappedId, methodName);
        }

        public global::UnityEngine.Coroutine StartCoroutine(string methodName)
        {
            return internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__UnityEngineCoroutine(WrappedId, methodName);
        }

        public global::UnityEngine.Coroutine StartCoroutine(string methodName, object value)
        {
            return internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__SystemObject__UnityEngineCoroutine(WrappedId, methodName, value);
        }

        public global::UnityEngine.Coroutine StartCoroutine(global::System.Collections.IEnumerator routine)
        {
            return internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemCollectionsIEnumerator__UnityEngineCoroutine(WrappedId, routine);
        }

        public void StopCoroutine(global::System.Collections.IEnumerator routine)
        {
            internal_UnityEngineMonoBehaviour__func__StopCoroutine__SystemCollectionsIEnumerator__SystemVoid(WrappedId, routine);
        }

        public void StopCoroutine(global::UnityEngine.Coroutine routine)
        {
            internal_UnityEngineMonoBehaviour__func__StopCoroutine__UnityEngineCoroutine__SystemVoid(WrappedId, routine);
        }

        public void StopCoroutine(string methodName)
        {
            internal_UnityEngineMonoBehaviour__func__StopCoroutine__SystemString__SystemVoid(WrappedId, methodName);
        }

        public void StopAllCoroutines()
        {
            internal_UnityEngineMonoBehaviour__func__StopAllCoroutines__SystemVoid(WrappedId);
        }

        public static void print(object message)
        {
            internal_UnityEngineMonoBehaviour__func__print__SystemObject__SystemVoid(message);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMonoBehaviour__get__useGUILayout(long selfObjectId)
        {
            var methodCallResult = UnityEngineMonoBehaviour__get__useGUILayout(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__set__useGUILayout(long selfObjectId, bool useGUILayout)
        {
            var useGUILayoutConverted = Unsafe.As<bool, int>(ref useGUILayout);
            UnityEngineMonoBehaviour__set__useGUILayout(selfObjectId, useGUILayoutConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMonoBehaviour__func__IsInvoking__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineMonoBehaviour__func__IsInvoking__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__CancelInvoke__SystemVoid(long selfObjectId)
        {
            UnityEngineMonoBehaviour__func__CancelInvoke__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__Invoke__SystemString__SystemSingle__SystemVoid(long selfObjectId, string methodName, float time)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineMonoBehaviour__func__Invoke__SystemString__SystemSingle__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), time);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__InvokeRepeating__SystemString__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string methodName, float time, float repeatRate)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineMonoBehaviour__func__InvokeRepeating__SystemString__SystemSingle__SystemSingle__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), time, repeatRate);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__CancelInvoke__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineMonoBehaviour__func__CancelInvoke__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMonoBehaviour__func__IsInvoking__SystemString__SystemBoolean(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                var methodCallResult = UnityEngineMonoBehaviour__func__IsInvoking__SystemString__SystemBoolean(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Coroutine internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__UnityEngineCoroutine(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                var methodCallResult = UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__UnityEngineCoroutine(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Coroutine(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Coroutine internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__SystemObject__UnityEngineCoroutine(long selfObjectId, string methodName, object value)
        {
            fixed (char* methodNamePointer = methodName)
            {
                // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
                var methodCallResult = UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__SystemObject__UnityEngineCoroutine(selfObjectId, methodNamePointer, methodName.Length * sizeof(char), (value as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
                var returnResult = new global::UnityEngine.Coroutine(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Coroutine internal_UnityEngineMonoBehaviour__func__StartCoroutine__SystemCollectionsIEnumerator__UnityEngineCoroutine(long selfObjectId, global::System.Collections.IEnumerator routine)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Collections.IEnumerator is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineMonoBehaviour__func__StartCoroutine__SystemCollectionsIEnumerator__UnityEngineCoroutine(selfObjectId, 0 /* Todo: Fix this */);
            var returnResult = new global::UnityEngine.Coroutine(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__StopCoroutine__SystemCollectionsIEnumerator__SystemVoid(long selfObjectId, global::System.Collections.IEnumerator routine)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Collections.IEnumerator is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineMonoBehaviour__func__StopCoroutine__SystemCollectionsIEnumerator__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__StopCoroutine__UnityEngineCoroutine__SystemVoid(long selfObjectId, global::UnityEngine.Coroutine routine)
        {
            UnityEngineMonoBehaviour__func__StopCoroutine__UnityEngineCoroutine__SystemVoid(selfObjectId, routine.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__StopCoroutine__SystemString__SystemVoid(long selfObjectId, string methodName)
        {
            fixed (char* methodNamePointer = methodName)
            {
                UnityEngineMonoBehaviour__func__StopCoroutine__SystemString__SystemVoid(selfObjectId, methodNamePointer, methodName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__StopAllCoroutines__SystemVoid(long selfObjectId)
        {
            UnityEngineMonoBehaviour__func__StopAllCoroutines__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMonoBehaviour__func__print__SystemObject__SystemVoid(object message)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineMonoBehaviour__func__print__SystemObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMonoBehaviour__get__useGUILayout(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__set__useGUILayout(long selfObjectId, int useGUILayoutConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMonoBehaviour__func__IsInvoking__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__func__CancelInvoke__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMonoBehaviour__func__Invoke__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, float time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMonoBehaviour__func__InvokeRepeating__SystemString__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, float time, float repeatRate);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMonoBehaviour__func__CancelInvoke__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMonoBehaviour__func__IsInvoking__SystemString__SystemBoolean(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__UnityEngineCoroutine(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineMonoBehaviour__func__StartCoroutine__SystemString__SystemObject__UnityEngineCoroutine(long selfObjectId, void* methodNamePointer, int methodNameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMonoBehaviour__func__StartCoroutine__SystemCollectionsIEnumerator__UnityEngineCoroutine(long selfObjectId, long routineObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__func__StopCoroutine__SystemCollectionsIEnumerator__SystemVoid(long selfObjectId, long routineObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__func__StopCoroutine__UnityEngineCoroutine__SystemVoid(long selfObjectId, long routineObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMonoBehaviour__func__StopCoroutine__SystemString__SystemVoid(long selfObjectId, void* methodNamePointer, int methodNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__func__StopAllCoroutines__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMonoBehaviour__func__print__SystemObject__SystemVoid(long messageObjectId);

        #endregion Imports
    }
}
