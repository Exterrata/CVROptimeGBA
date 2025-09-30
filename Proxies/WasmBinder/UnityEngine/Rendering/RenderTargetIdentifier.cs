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
    public partial struct RenderTargetIdentifier
    {

        #region Implementation

        public RenderTargetIdentifier(global::UnityEngine.Rendering.BuiltinRenderTextureType type)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum(ref this, type);
        }

        public RenderTargetIdentifier(global::UnityEngine.Rendering.BuiltinRenderTextureType type, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, type, mipLevel, cubeFace, depthSlice);
        }

        public RenderTargetIdentifier(string name)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString(ref this, name);
        }

        public RenderTargetIdentifier(string name, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, name, mipLevel, cubeFace, depthSlice);
        }

        public RenderTargetIdentifier(int nameID)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32(ref this, nameID);
        }

        public RenderTargetIdentifier(int nameID, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, nameID, mipLevel, cubeFace, depthSlice);
        }

        public RenderTargetIdentifier(global::UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, renderTargetIdentifier, mipLevel, cubeFace, depthSlice);
        }

        public RenderTargetIdentifier(global::UnityEngine.Texture tex)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture(ref this, tex);
        }

        public RenderTargetIdentifier(global::UnityEngine.Texture tex, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, tex, mipLevel, cubeFace, depthSlice);
        }

        public RenderTargetIdentifier(global::UnityEngine.RenderBuffer buf, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref this, buf, mipLevel, cubeFace, depthSlice);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.BuiltinRenderTextureType m_Type;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_NameID;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_InstanceID;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private global::System.IntPtr m_BufferPointer;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private int m_MipLevel;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.CubemapFace m_CubeFace;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private int m_DepthSlice;

        public string ToString()
        {
            return internal_UnityEngineRenderingRenderTargetIdentifier__func__ToString__SystemString(ref this);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingRenderTargetIdentifier__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(global::UnityEngine.Rendering.RenderTargetIdentifier rhs)
        {
            return internal_UnityEngineRenderingRenderTargetIdentifier__func__Equals__UnityEngineRenderingRenderTargetIdentifier__SystemBoolean(ref this, rhs);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineRenderingRenderTargetIdentifier__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Rendering.BuiltinRenderTextureType type)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum(selfStructPointer, (int) type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Rendering.BuiltinRenderTextureType type, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, (int) type, mipLevel, (int) cubeFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString(selfStructPointer, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, string name, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, namePointer, name.Length * sizeof(char), mipLevel, (int) cubeFace, depthSlice);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, int nameID)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32(selfStructPointer, nameID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, int nameID, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, nameID, mipLevel, (int) cubeFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref renderTargetIdentifier), mipLevel, (int) cubeFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Texture tex)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture(selfStructPointer, tex.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Texture tex, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, tex.WrappedId, mipLevel, (int) cubeFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.RenderBuffer buf, int mipLevel, global::UnityEngine.CubemapFace cubeFace, int depthSlice)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref buf), mipLevel, (int) cubeFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingRenderTargetIdentifier__func__ToString__SystemString(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRenderingRenderTargetIdentifier__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingRenderTargetIdentifier__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingRenderTargetIdentifier__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingRenderTargetIdentifier__func__Equals__UnityEngineRenderingRenderTargetIdentifier__SystemBoolean(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, global::UnityEngine.Rendering.RenderTargetIdentifier rhs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingRenderTargetIdentifier__func__Equals__UnityEngineRenderingRenderTargetIdentifier__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref rhs));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingRenderTargetIdentifier__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.RenderTargetIdentifier selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingRenderTargetIdentifier__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum(void* selfStructPointer, int typeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingBuiltinRenderTextureTypeEnum__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, int typeUnderlyingValue, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__SystemString__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, void* namePointer, int nameWasmLength, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32(void* selfStructPointer, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__SystemInt32__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, int nameID, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, void* renderTargetIdentifierPointer, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture(void* selfStructPointer, long texObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, long texObjectId, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__ctor__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* selfStructPointer, void* bufPointer, int mipLevel, int cubeFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetIdentifier__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingRenderTargetIdentifier__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingRenderTargetIdentifier__func__Equals__UnityEngineRenderingRenderTargetIdentifier__SystemBoolean(void* selfStructPointer, void* rhsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingRenderTargetIdentifier__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        #endregion Imports
    }
}
