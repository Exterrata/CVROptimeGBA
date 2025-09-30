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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct ShaderTagId
    {

        #region Implementation

        public ShaderTagId(string name)
        {
            internal_UnityEngineRenderingShaderTagId__ctor__SystemString(ref this, name);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_Id;

        public string name 
        {
            get => internal_UnityEngineRenderingShaderTagId__get__name(ref this);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineRenderingShaderTagId__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public bool Equals(global::UnityEngine.Rendering.ShaderTagId other)
        {
            return internal_UnityEngineRenderingShaderTagId__func__Equals__UnityEngineRenderingShaderTagId__SystemBoolean(ref this, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingShaderTagId__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingShaderTagId__ctor__SystemString(ref global::UnityEngine.Rendering.ShaderTagId selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineRenderingShaderTagId__ctor__SystemString(selfStructPointer, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingShaderTagId__get__name(ref global::UnityEngine.Rendering.ShaderTagId selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineRenderingShaderTagId__get__name(selfStructPointer, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingShaderTagId__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.ShaderTagId selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingShaderTagId__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingShaderTagId__func__Equals__UnityEngineRenderingShaderTagId__SystemBoolean(ref global::UnityEngine.Rendering.ShaderTagId selfStruct, global::UnityEngine.Rendering.ShaderTagId other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingShaderTagId__func__Equals__UnityEngineRenderingShaderTagId__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingShaderTagId__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.ShaderTagId selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingShaderTagId__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingShaderTagId__ctor__SystemString(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingShaderTagId__get__name(void* selfStructPointer, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingShaderTagId__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingShaderTagId__func__Equals__UnityEngineRenderingShaderTagId__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingShaderTagId__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
