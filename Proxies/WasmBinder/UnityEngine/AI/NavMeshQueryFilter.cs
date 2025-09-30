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

    public partial struct NavMeshQueryFilter(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public int areaMask 
        {
            get => internal_UnityEngineAINavMeshQueryFilter__get__areaMask(WrappedId);
            set => internal_UnityEngineAINavMeshQueryFilter__set__areaMask(WrappedId, value);
        }

        public int agentTypeID 
        {
            get => internal_UnityEngineAINavMeshQueryFilter__get__agentTypeID(WrappedId);
            set => internal_UnityEngineAINavMeshQueryFilter__set__agentTypeID(WrappedId, value);
        }

        public float GetAreaCost(int areaIndex)
        {
            return internal_UnityEngineAINavMeshQueryFilter__func__GetAreaCost__SystemInt32__SystemSingle(WrappedId, areaIndex);
        }

        public void SetAreaCost(int areaIndex, float cost)
        {
            internal_UnityEngineAINavMeshQueryFilter__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(WrappedId, areaIndex, cost);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshQueryFilter__get__areaMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshQueryFilter__get__areaMask(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshQueryFilter__set__areaMask(long selfObjectId, int areaMask)
        {
            UnityEngineAINavMeshQueryFilter__set__areaMask(selfObjectId, areaMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshQueryFilter__get__agentTypeID(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshQueryFilter__get__agentTypeID(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshQueryFilter__set__agentTypeID(long selfObjectId, int agentTypeID)
        {
            UnityEngineAINavMeshQueryFilter__set__agentTypeID(selfObjectId, agentTypeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshQueryFilter__func__GetAreaCost__SystemInt32__SystemSingle(long selfObjectId, int areaIndex)
        {
            var methodCallResult = UnityEngineAINavMeshQueryFilter__func__GetAreaCost__SystemInt32__SystemSingle(selfObjectId, areaIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshQueryFilter__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int areaIndex, float cost)
        {
            UnityEngineAINavMeshQueryFilter__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(selfObjectId, areaIndex, cost);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshQueryFilter__get__areaMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshQueryFilter__set__areaMask(long selfObjectId, int areaMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshQueryFilter__get__agentTypeID(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshQueryFilter__set__agentTypeID(long selfObjectId, int agentTypeID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshQueryFilter__func__GetAreaCost__SystemInt32__SystemSingle(long selfObjectId, int areaIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshQueryFilter__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int areaIndex, float cost);

        #endregion Imports
    }
}
