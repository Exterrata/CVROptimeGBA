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

    public partial class NavMeshData(long id) : Object(id)
    {

        #region Implementation

        public NavMeshData()
            : this(internal_UnityEngineAINavMeshData__ctor()) { }

        public NavMeshData(int agentTypeID)
            : this(internal_UnityEngineAINavMeshData__ctor__SystemInt32(agentTypeID)) { }

        public global::UnityEngine.Bounds sourceBounds 
        {
            get => internal_UnityEngineAINavMeshData__get__sourceBounds(WrappedId);
        }

        public global::UnityEngine.Vector3 position 
        {
            get => internal_UnityEngineAINavMeshData__get__position(WrappedId);
            set => internal_UnityEngineAINavMeshData__set__position(WrappedId, value);
        }

        public global::UnityEngine.Quaternion rotation 
        {
            get => internal_UnityEngineAINavMeshData__get__rotation(WrappedId);
            set => internal_UnityEngineAINavMeshData__set__rotation(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAINavMeshData__ctor()
        {
            return UnityEngineAINavMeshData__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAINavMeshData__ctor__SystemInt32(int agentTypeID)
        {
            return UnityEngineAINavMeshData__ctor__SystemInt32(agentTypeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineAINavMeshData__get__sourceBounds(long selfObjectId)
        {
            global::UnityEngine.Bounds sourceBoundsValue = default;
            UnityEngineAINavMeshData__get__sourceBounds(selfObjectId, Unsafe.AsPointer(ref sourceBoundsValue));
            global::UnityEngine.Bounds returnResult = sourceBoundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshData__get__position(long selfObjectId)
        {
            global::UnityEngine.Vector3 positionValue = default;
            UnityEngineAINavMeshData__get__position(selfObjectId, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector3 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshData__set__position(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            UnityEngineAINavMeshData__set__position(selfObjectId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAINavMeshData__get__rotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion rotationValue = default;
            UnityEngineAINavMeshData__get__rotation(selfObjectId, Unsafe.AsPointer(ref rotationValue));
            global::UnityEngine.Quaternion returnResult = rotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshData__set__rotation(long selfObjectId, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineAINavMeshData__set__rotation(selfObjectId, Unsafe.AsPointer(ref rotation));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMeshData__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMeshData__ctor__SystemInt32(int agentTypeID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshData__get__sourceBounds(long selfObjectId, void* sourceBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshData__get__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshData__set__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshData__get__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshData__set__rotation(long selfObjectId, void* rotationPointer);

        #endregion Imports
    }
}
