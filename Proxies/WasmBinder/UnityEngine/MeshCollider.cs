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

    public partial class MeshCollider(long id) : Collider(id)
    {

        #region Implementation

        public global::UnityEngine.Mesh sharedMesh 
        {
            get => internal_UnityEngineMeshCollider__get__sharedMesh(WrappedId);
            set => internal_UnityEngineMeshCollider__set__sharedMesh(WrappedId, value);
        }

        public bool convex 
        {
            get => internal_UnityEngineMeshCollider__get__convex(WrappedId);
            set => internal_UnityEngineMeshCollider__set__convex(WrappedId, value);
        }

        public global::UnityEngine.MeshColliderCookingOptions cookingOptions 
        {
            get => internal_UnityEngineMeshCollider__get__cookingOptions(WrappedId);
            set => internal_UnityEngineMeshCollider__set__cookingOptions(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineMeshCollider__get__sharedMesh(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshCollider__get__sharedMesh(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshCollider__set__sharedMesh(long selfObjectId, global::UnityEngine.Mesh sharedMesh)
        {
            UnityEngineMeshCollider__set__sharedMesh(selfObjectId, sharedMesh.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMeshCollider__get__convex(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshCollider__get__convex(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshCollider__set__convex(long selfObjectId, bool convex)
        {
            var convexConverted = Unsafe.As<bool, int>(ref convex);
            UnityEngineMeshCollider__set__convex(selfObjectId, convexConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MeshColliderCookingOptions internal_UnityEngineMeshCollider__get__cookingOptions(long selfObjectId)
        {
            var methodCallResult = UnityEngineMeshCollider__get__cookingOptions(selfObjectId);
            var returnResult = (global::UnityEngine.MeshColliderCookingOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMeshCollider__set__cookingOptions(long selfObjectId, global::UnityEngine.MeshColliderCookingOptions cookingOptions)
        {
            UnityEngineMeshCollider__set__cookingOptions(selfObjectId, (int) cookingOptions);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMeshCollider__get__sharedMesh(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshCollider__set__sharedMesh(long selfObjectId, long sharedMeshObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMeshCollider__get__convex(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshCollider__set__convex(long selfObjectId, int convexConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMeshCollider__get__cookingOptions(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMeshCollider__set__cookingOptions(long selfObjectId, int cookingOptionsUnderlyingValue);

        #endregion Imports
    }
}
