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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct CombineInstance
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_MeshInstanceID;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_SubMeshIndex;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 m_Transform;

        // [FieldOffset(72)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector4 m_LightmapScaleOffset;

        // [FieldOffset(88)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;

        public global::UnityEngine.Mesh mesh 
        {
            get => internal_UnityEngineCombineInstance__get__mesh(ref this);
            set => internal_UnityEngineCombineInstance__set__mesh(ref this, value);
        }

        public int subMeshIndex 
        {
            get => internal_UnityEngineCombineInstance__get__subMeshIndex(ref this);
            set => internal_UnityEngineCombineInstance__set__subMeshIndex(ref this, value);
        }

        public global::UnityEngine.Matrix4x4 transform 
        {
            get => internal_UnityEngineCombineInstance__get__transform(ref this);
            set => internal_UnityEngineCombineInstance__set__transform(ref this, value);
        }

        public global::UnityEngine.Vector4 lightmapScaleOffset 
        {
            get => internal_UnityEngineCombineInstance__get__lightmapScaleOffset(ref this);
            set => internal_UnityEngineCombineInstance__set__lightmapScaleOffset(ref this, value);
        }

        public global::UnityEngine.Vector4 realtimeLightmapScaleOffset 
        {
            get => internal_UnityEngineCombineInstance__get__realtimeLightmapScaleOffset(ref this);
            set => internal_UnityEngineCombineInstance__set__realtimeLightmapScaleOffset(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineCombineInstance__get__mesh(ref global::UnityEngine.CombineInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineCombineInstance__get__mesh(selfStructPointer);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCombineInstance__set__mesh(ref global::UnityEngine.CombineInstance selfStruct, global::UnityEngine.Mesh mesh)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineCombineInstance__set__mesh(selfStructPointer, mesh.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCombineInstance__get__subMeshIndex(ref global::UnityEngine.CombineInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineCombineInstance__get__subMeshIndex(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCombineInstance__set__subMeshIndex(ref global::UnityEngine.CombineInstance selfStruct, int subMeshIndex)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineCombineInstance__set__subMeshIndex(selfStructPointer, subMeshIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCombineInstance__get__transform(ref global::UnityEngine.CombineInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 transformValue = default;
            UnityEngineCombineInstance__get__transform(selfStructPointer, Unsafe.AsPointer(ref transformValue));
            global::UnityEngine.Matrix4x4 returnResult = transformValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCombineInstance__set__transform(ref global::UnityEngine.CombineInstance selfStruct, global::UnityEngine.Matrix4x4 transform)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineCombineInstance__set__transform(selfStructPointer, Unsafe.AsPointer(ref transform));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineCombineInstance__get__lightmapScaleOffset(ref global::UnityEngine.CombineInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector4 lightmapScaleOffsetValue = default;
            UnityEngineCombineInstance__get__lightmapScaleOffset(selfStructPointer, Unsafe.AsPointer(ref lightmapScaleOffsetValue));
            global::UnityEngine.Vector4 returnResult = lightmapScaleOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCombineInstance__set__lightmapScaleOffset(ref global::UnityEngine.CombineInstance selfStruct, global::UnityEngine.Vector4 lightmapScaleOffset)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineCombineInstance__set__lightmapScaleOffset(selfStructPointer, Unsafe.AsPointer(ref lightmapScaleOffset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineCombineInstance__get__realtimeLightmapScaleOffset(ref global::UnityEngine.CombineInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector4 realtimeLightmapScaleOffsetValue = default;
            UnityEngineCombineInstance__get__realtimeLightmapScaleOffset(selfStructPointer, Unsafe.AsPointer(ref realtimeLightmapScaleOffsetValue));
            global::UnityEngine.Vector4 returnResult = realtimeLightmapScaleOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCombineInstance__set__realtimeLightmapScaleOffset(ref global::UnityEngine.CombineInstance selfStruct, global::UnityEngine.Vector4 realtimeLightmapScaleOffset)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineCombineInstance__set__realtimeLightmapScaleOffset(selfStructPointer, Unsafe.AsPointer(ref realtimeLightmapScaleOffset));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineCombineInstance__get__mesh(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__set__mesh(void* selfStructPointer, long meshObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCombineInstance__get__subMeshIndex(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__set__subMeshIndex(void* selfStructPointer, int subMeshIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__get__transform(void* selfStructPointer, void* transformPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__set__transform(void* selfStructPointer, void* transformPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__get__lightmapScaleOffset(void* selfStructPointer, void* lightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__set__lightmapScaleOffset(void* selfStructPointer, void* lightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__get__realtimeLightmapScaleOffset(void* selfStructPointer, void* realtimeLightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCombineInstance__set__realtimeLightmapScaleOffset(void* selfStructPointer, void* realtimeLightmapScaleOffsetPointer);

        #endregion Imports
    }
}
