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

    public partial class MeshRenderer(long id) : Renderer(id)
    {

        #region Implementation

        public global::UnityEngine.Mesh additionalVertexStreams 
        {
            get => internal_UnityEngineMeshRenderer__get__additionalVertexStreams(WrappedId);
            set => internal_UnityEngineMeshRenderer__set__additionalVertexStreams(WrappedId, value);
        }

        public global::UnityEngine.Mesh enlightenVertexStream 
        {
            get => internal_UnityEngineMeshRenderer__get__enlightenVertexStream(WrappedId);
            set => internal_UnityEngineMeshRenderer__set__enlightenVertexStream(WrappedId, value);
        }

        public int subMeshStartIndex 
        {
            get => internal_UnityEngineMeshRenderer__get__subMeshStartIndex(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineMeshRenderer__get__additionalVertexStreams(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshRenderer__get__additionalVertexStreams(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshRenderer__set__additionalVertexStreams(long selfObjectId, global::UnityEngine.Mesh additionalVertexStreams)
        {
            UnityEngineMeshRenderer__set__additionalVertexStreams(selfObjectId, additionalVertexStreams.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineMeshRenderer__get__enlightenVertexStream(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshRenderer__get__enlightenVertexStream(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshRenderer__set__enlightenVertexStream(long selfObjectId, global::UnityEngine.Mesh enlightenVertexStream)
        {
            UnityEngineMeshRenderer__set__enlightenVertexStream(selfObjectId, enlightenVertexStream.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMeshRenderer__get__subMeshStartIndex(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshRenderer__get__subMeshStartIndex(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMeshRenderer__get__additionalVertexStreams(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshRenderer__set__additionalVertexStreams(long selfObjectId, long additionalVertexStreamsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMeshRenderer__get__enlightenVertexStream(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshRenderer__set__enlightenVertexStream(long selfObjectId, long enlightenVertexStreamObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMeshRenderer__get__subMeshStartIndex(long selfObjectId);

        #endregion Imports
    }
}
