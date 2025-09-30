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
    public partial struct SubMeshDescriptor
    {

        #region Implementation

        public SubMeshDescriptor(int indexStart, int indexCount, global::UnityEngine.MeshTopology topology)
        {
            internal_UnityEngineRenderingSubMeshDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum(ref this, indexStart, indexCount, topology);
        }

        // [FieldOffset(0)] (the backing field offset)
        public global::UnityEngine.Bounds bounds { get; set; }

        // [FieldOffset(24)] (the backing field offset)
        public global::UnityEngine.MeshTopology topology { get; set; }

        // [FieldOffset(28)] (the backing field offset)
        public int indexStart { get; set; }

        // [FieldOffset(32)] (the backing field offset)
        public int indexCount { get; set; }

        // [FieldOffset(36)] (the backing field offset)
        public int baseVertex { get; set; }

        // [FieldOffset(40)] (the backing field offset)
        public int firstVertex { get; set; }

        // [FieldOffset(44)] (the backing field offset)
        public int vertexCount { get; set; }

        public string ToString()
        {
            return internal_UnityEngineRenderingSubMeshDescriptor__func__ToString__SystemString(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingSubMeshDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum(ref global::UnityEngine.Rendering.SubMeshDescriptor selfStruct, int indexStart, int indexCount, global::UnityEngine.MeshTopology topology)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingSubMeshDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum(selfStructPointer, indexStart, indexCount, (int) topology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingSubMeshDescriptor__func__ToString__SystemString(ref global::UnityEngine.Rendering.SubMeshDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRenderingSubMeshDescriptor__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSubMeshDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum(void* selfStructPointer, int indexStart, int indexCount, int topologyUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSubMeshDescriptor__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
