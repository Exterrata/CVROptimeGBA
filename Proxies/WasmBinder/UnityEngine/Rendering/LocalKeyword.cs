//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    public partial struct LocalKeyword(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public LocalKeyword(global::UnityEngine.Shader shader, string name)
            : this(internal_UnityEngineRenderingLocalKeyword__ctor__UnityEngineShader__SystemString(shader, name)) { }

        public LocalKeyword(global::UnityEngine.ComputeShader shader, string name)
            : this(internal_UnityEngineRenderingLocalKeyword__ctor__UnityEngineComputeShader__SystemString(shader, name)) { }

        public string name 
        {
            get => internal_UnityEngineRenderingLocalKeyword__get__name(WrappedId);
        }

        public bool isOverridable 
        {
            get => internal_UnityEngineRenderingLocalKeyword__get__isOverridable(WrappedId);
        }

        public bool isValid 
        {
            get => internal_UnityEngineRenderingLocalKeyword__get__isValid(WrappedId);
        }

        public global::UnityEngine.Rendering.ShaderKeywordType type 
        {
            get => internal_UnityEngineRenderingLocalKeyword__get__type(WrappedId);
        }

        public string ToString()
        {
            return internal_UnityEngineRenderingLocalKeyword__func__ToString__SystemString(WrappedId);
        }

        public bool Equals(object o)
        {
            return internal_UnityEngineRenderingLocalKeyword__func__Equals__SystemObject__SystemBoolean(WrappedId, o);
        }

        public bool Equals(global::UnityEngine.Rendering.LocalKeyword rhs)
        {
            return internal_UnityEngineRenderingLocalKeyword__func__Equals__UnityEngineRenderingLocalKeyword__SystemBoolean(WrappedId, rhs);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingLocalKeyword__func__GetHashCode__SystemInt32(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingLocalKeyword__ctor__UnityEngineShader__SystemString(global::UnityEngine.Shader shader, string name)
        {
            fixed (char* namePointer = name)
            {
                return UnityEngineRenderingLocalKeyword__ctor__UnityEngineShader__SystemString(shader.WrappedId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingLocalKeyword__ctor__UnityEngineComputeShader__SystemString(global::UnityEngine.ComputeShader shader, string name)
        {
            fixed (char* namePointer = name)
            {
                return UnityEngineRenderingLocalKeyword__ctor__UnityEngineComputeShader__SystemString(shader.WrappedId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingLocalKeyword__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineRenderingLocalKeyword__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeyword__get__isOverridable(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingLocalKeyword__get__isOverridable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeyword__get__isValid(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingLocalKeyword__get__isValid(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderKeywordType internal_UnityEngineRenderingLocalKeyword__get__type(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingLocalKeyword__get__type(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ShaderKeywordType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingLocalKeyword__func__ToString__SystemString(long selfObjectId)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRenderingLocalKeyword__func__ToString__SystemString(selfObjectId, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeyword__func__Equals__SystemObject__SystemBoolean(long selfObjectId, object o)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingLocalKeyword__func__Equals__SystemObject__SystemBoolean(selfObjectId, (o as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeyword__func__Equals__UnityEngineRenderingLocalKeyword__SystemBoolean(long selfObjectId, global::UnityEngine.Rendering.LocalKeyword rhs)
        {
            var methodCallResult = UnityEngineRenderingLocalKeyword__func__Equals__UnityEngineRenderingLocalKeyword__SystemBoolean(selfObjectId, rhs.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingLocalKeyword__func__GetHashCode__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingLocalKeyword__func__GetHashCode__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingLocalKeyword__ctor__UnityEngineShader__SystemString(long shaderObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingLocalKeyword__ctor__UnityEngineComputeShader__SystemString(long shaderObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLocalKeyword__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__get__isOverridable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__get__isValid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__get__type(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLocalKeyword__func__ToString__SystemString(long selfObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__func__Equals__SystemObject__SystemBoolean(long selfObjectId, long oObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__func__Equals__UnityEngineRenderingLocalKeyword__SystemBoolean(long selfObjectId, long rhsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingLocalKeyword__func__GetHashCode__SystemInt32(long selfObjectId);

        #endregion Imports
    }
}
