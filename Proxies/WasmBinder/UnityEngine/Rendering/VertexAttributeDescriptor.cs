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
    public partial struct VertexAttributeDescriptor
    {

        #region Implementation

        public VertexAttributeDescriptor(global::UnityEngine.Rendering.VertexAttribute attribute, global::UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream)
        {
            internal_UnityEngineRenderingVertexAttributeDescriptor__ctor__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum__SystemInt32__SystemInt32(ref this, attribute, format, dimension, stream);
        }

        // [FieldOffset(0)] (the backing field offset)
        public global::UnityEngine.Rendering.VertexAttribute attribute { get; set; }

        // [FieldOffset(4)] (the backing field offset)
        public global::UnityEngine.Rendering.VertexAttributeFormat format { get; set; }

        // [FieldOffset(8)] (the backing field offset)
        public int dimension { get; set; }

        // [FieldOffset(12)] (the backing field offset)
        public int stream { get; set; }

        public string ToString()
        {
            return internal_UnityEngineRenderingVertexAttributeDescriptor__func__ToString__SystemString(ref this);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingVertexAttributeDescriptor__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineRenderingVertexAttributeDescriptor__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Rendering.VertexAttributeDescriptor other)
        {
            return internal_UnityEngineRenderingVertexAttributeDescriptor__func__Equals__UnityEngineRenderingVertexAttributeDescriptor__SystemBoolean(ref this, other);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingVertexAttributeDescriptor__ctor__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum__SystemInt32__SystemInt32(ref global::UnityEngine.Rendering.VertexAttributeDescriptor selfStruct, global::UnityEngine.Rendering.VertexAttribute attribute, global::UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingVertexAttributeDescriptor__ctor__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum__SystemInt32__SystemInt32(selfStructPointer, (int) attribute, (int) format, dimension, stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingVertexAttributeDescriptor__func__ToString__SystemString(ref global::UnityEngine.Rendering.VertexAttributeDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRenderingVertexAttributeDescriptor__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingVertexAttributeDescriptor__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.VertexAttributeDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingVertexAttributeDescriptor__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingVertexAttributeDescriptor__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.VertexAttributeDescriptor selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingVertexAttributeDescriptor__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingVertexAttributeDescriptor__func__Equals__UnityEngineRenderingVertexAttributeDescriptor__SystemBoolean(ref global::UnityEngine.Rendering.VertexAttributeDescriptor selfStruct, global::UnityEngine.Rendering.VertexAttributeDescriptor other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingVertexAttributeDescriptor__func__Equals__UnityEngineRenderingVertexAttributeDescriptor__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingVertexAttributeDescriptor__ctor__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum__SystemInt32__SystemInt32(void* selfStructPointer, int attributeUnderlyingValue, int formatUnderlyingValue, int dimension, int stream);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingVertexAttributeDescriptor__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingVertexAttributeDescriptor__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingVertexAttributeDescriptor__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingVertexAttributeDescriptor__func__Equals__UnityEngineRenderingVertexAttributeDescriptor__SystemBoolean(void* selfStructPointer, void* otherPointer);

        #endregion Imports
    }
}
