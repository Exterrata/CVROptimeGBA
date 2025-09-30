//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.AI
{

    public partial struct NavMeshTriangulation(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public global::UnityEngine.Vector3[] vertices
        {
            get => internal_UnityEngineAINavMeshTriangulation__get__vertices(WrappedId);
            set => internal_UnityEngineAINavMeshTriangulation__set__vertices(WrappedId, value);
        }

        public global::System.Int32[] indices
        {
            get => internal_UnityEngineAINavMeshTriangulation__get__indices(WrappedId);
            set => internal_UnityEngineAINavMeshTriangulation__set__indices(WrappedId, value);
        }

        public global::System.Int32[] areas
        {
            get => internal_UnityEngineAINavMeshTriangulation__get__areas(WrappedId);
            set => internal_UnityEngineAINavMeshTriangulation__set__areas(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3[] internal_UnityEngineAINavMeshTriangulation__get__vertices(long selfObjectId)
        {
            global::UnityEngine.Vector3* verticesIdsPointer = default;
            int verticesWasmLength = default;
            UnityEngineAINavMeshTriangulation__get__vertices(selfObjectId, &verticesIdsPointer, &verticesWasmLength);
            global::UnityEngine.Vector3[] returnResult = new global::UnityEngine.Vector3[verticesWasmLength];
            for (int i = 0; i < verticesWasmLength; i++)
            {
                returnResult[i] = verticesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)verticesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshTriangulation__set__vertices(long selfObjectId, global::UnityEngine.Vector3[] vertices)
        {
            fixed (global::UnityEngine.Vector3* verticesPointer = vertices)
            {
                UnityEngineAINavMeshTriangulation__set__vertices(selfObjectId, verticesPointer, vertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineAINavMeshTriangulation__get__indices(long selfObjectId)
        {
            int* indicesIdsPointer = default;
            int indicesWasmLength = default;
            UnityEngineAINavMeshTriangulation__get__indices(selfObjectId, &indicesIdsPointer, &indicesWasmLength);
            int[] returnResult = new int[indicesWasmLength];
            for (int i = 0; i < indicesWasmLength; i++)
            {
                returnResult[i] = indicesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)indicesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshTriangulation__set__indices(long selfObjectId, global::System.Int32[] indices)
        {
            fixed (int* indicesPointer = indices)
            {
                UnityEngineAINavMeshTriangulation__set__indices(selfObjectId, indicesPointer, indices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineAINavMeshTriangulation__get__areas(long selfObjectId)
        {
            int* areasIdsPointer = default;
            int areasWasmLength = default;
            UnityEngineAINavMeshTriangulation__get__areas(selfObjectId, &areasIdsPointer, &areasWasmLength);
            int[] returnResult = new int[areasWasmLength];
            for (int i = 0; i < areasWasmLength; i++)
            {
                returnResult[i] = areasIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)areasIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshTriangulation__set__areas(long selfObjectId, global::System.Int32[] areas)
        {
            fixed (int* areasPointer = areas)
            {
                UnityEngineAINavMeshTriangulation__set__areas(selfObjectId, areasPointer, areas.Length);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__get__vertices(long selfObjectId, void* verticesIdsPointer, void* verticesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__set__vertices(long selfObjectId, void* verticesPointer, int verticesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__get__indices(long selfObjectId, void* indicesIdsPointer, void* indicesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__set__indices(long selfObjectId, void* indicesPointer, int indicesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__get__areas(long selfObjectId, void* areasIdsPointer, void* areasWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshTriangulation__set__areas(long selfObjectId, void* areasPointer, int areasWasmLength);

        #endregion Imports
    }
}
