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

    public partial class AnimatorControllerParameter(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public AnimatorControllerParameter()
            : this(internal_UnityEngineAnimatorControllerParameter__ctor()) { }

        public string name 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__name(WrappedId);
        }

        public int nameHash 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__nameHash(WrappedId);
        }

        public global::UnityEngine.AnimatorControllerParameterType type 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__type(WrappedId);
            set => internal_UnityEngineAnimatorControllerParameter__set__type(WrappedId, value);
        }

        public float defaultFloat 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__defaultFloat(WrappedId);
            set => internal_UnityEngineAnimatorControllerParameter__set__defaultFloat(WrappedId, value);
        }

        public int defaultInt 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__defaultInt(WrappedId);
            set => internal_UnityEngineAnimatorControllerParameter__set__defaultInt(WrappedId, value);
        }

        public bool defaultBool 
        {
            get => internal_UnityEngineAnimatorControllerParameter__get__defaultBool(WrappedId);
            set => internal_UnityEngineAnimatorControllerParameter__set__defaultBool(WrappedId, value);
        }

        public bool Equals(object o)
        {
            return internal_UnityEngineAnimatorControllerParameter__func__Equals__SystemObject__SystemBoolean(WrappedId, o);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineAnimatorControllerParameter__func__GetHashCode__SystemInt32(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAnimatorControllerParameter__ctor()
        {
            return UnityEngineAnimatorControllerParameter__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineAnimatorControllerParameter__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineAnimatorControllerParameter__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorControllerParameter__get__nameHash(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__get__nameHash(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorControllerParameterType internal_UnityEngineAnimatorControllerParameter__get__type(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__get__type(selfObjectId);
            var returnResult = (global::UnityEngine.AnimatorControllerParameterType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimatorControllerParameter__set__type(long selfObjectId, global::UnityEngine.AnimatorControllerParameterType type)
        {
            UnityEngineAnimatorControllerParameter__set__type(selfObjectId, (int) type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorControllerParameter__get__defaultFloat(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__get__defaultFloat(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimatorControllerParameter__set__defaultFloat(long selfObjectId, float defaultFloat)
        {
            UnityEngineAnimatorControllerParameter__set__defaultFloat(selfObjectId, defaultFloat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorControllerParameter__get__defaultInt(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__get__defaultInt(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimatorControllerParameter__set__defaultInt(long selfObjectId, int defaultInt)
        {
            UnityEngineAnimatorControllerParameter__set__defaultInt(selfObjectId, defaultInt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorControllerParameter__get__defaultBool(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__get__defaultBool(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimatorControllerParameter__set__defaultBool(long selfObjectId, bool defaultBool)
        {
            var defaultBoolConverted = Unsafe.As<bool, int>(ref defaultBool);
            UnityEngineAnimatorControllerParameter__set__defaultBool(selfObjectId, defaultBoolConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorControllerParameter__func__Equals__SystemObject__SystemBoolean(long selfObjectId, object o)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineAnimatorControllerParameter__func__Equals__SystemObject__SystemBoolean(selfObjectId, (o as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorControllerParameter__func__GetHashCode__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimatorControllerParameter__func__GetHashCode__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimatorControllerParameter__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimatorControllerParameter__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__get__nameHash(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__get__type(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimatorControllerParameter__set__type(long selfObjectId, int typeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimatorControllerParameter__get__defaultFloat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimatorControllerParameter__set__defaultFloat(long selfObjectId, float defaultFloat);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__get__defaultInt(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimatorControllerParameter__set__defaultInt(long selfObjectId, int defaultInt);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__get__defaultBool(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimatorControllerParameter__set__defaultBool(long selfObjectId, int defaultBoolConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__func__Equals__SystemObject__SystemBoolean(long selfObjectId, long oObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimatorControllerParameter__func__GetHashCode__SystemInt32(long selfObjectId);

        #endregion Imports
    }
}
