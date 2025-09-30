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

    public partial class MeshFilter(long id) : Component(id)
    {

        #region Implementation

        public global::UnityEngine.Mesh sharedMesh 
        {
            get => internal_UnityEngineMeshFilter__get__sharedMesh(WrappedId);
            set => internal_UnityEngineMeshFilter__set__sharedMesh(WrappedId, value);
        }

        public global::UnityEngine.Mesh mesh 
        {
            get => internal_UnityEngineMeshFilter__get__mesh(WrappedId);
            set => internal_UnityEngineMeshFilter__set__mesh(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineMeshFilter__get__sharedMesh(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshFilter__get__sharedMesh(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshFilter__set__sharedMesh(long selfObjectId, global::UnityEngine.Mesh sharedMesh)
        {
            UnityEngineMeshFilter__set__sharedMesh(selfObjectId, sharedMesh.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineMeshFilter__get__mesh(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshFilter__get__mesh(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshFilter__set__mesh(long selfObjectId, global::UnityEngine.Mesh mesh)
        {
            UnityEngineMeshFilter__set__mesh(selfObjectId, mesh.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMeshFilter__get__sharedMesh(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshFilter__set__sharedMesh(long selfObjectId, long sharedMeshObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMeshFilter__get__mesh(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshFilter__set__mesh(long selfObjectId, long meshObjectId);

        #endregion Imports
    }
}
