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

    public partial class NavMeshPath(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public NavMeshPath()
            : this(internal_UnityEngineAINavMeshPath__ctor()) { }

        public global::UnityEngine.Vector3[] corners 
        {
            get => internal_UnityEngineAINavMeshPath__get__corners(WrappedId);
        }

        public global::UnityEngine.AI.NavMeshPathStatus status 
        {
            get => internal_UnityEngineAINavMeshPath__get__status(WrappedId);
        }

        public void ClearCorners()
        {
            internal_UnityEngineAINavMeshPath__func__ClearCorners__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAINavMeshPath__ctor()
        {
            return UnityEngineAINavMeshPath__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3[] internal_UnityEngineAINavMeshPath__get__corners(long selfObjectId)
        {
            global::UnityEngine.Vector3* cornersIdsPointer = default;
            int cornersWasmLength = default;
            UnityEngineAINavMeshPath__get__corners(selfObjectId, &cornersIdsPointer, &cornersWasmLength);
            global::UnityEngine.Vector3[] returnResult = new global::UnityEngine.Vector3[cornersWasmLength];
            for (int i = 0; i < cornersWasmLength; i++)
            {
                returnResult[i] = cornersIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)cornersIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshPathStatus internal_UnityEngineAINavMeshPath__get__status(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshPath__get__status(selfObjectId);
            var returnResult = (global::UnityEngine.AI.NavMeshPathStatus)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshPath__func__ClearCorners__SystemVoid(long selfObjectId)
        {
            UnityEngineAINavMeshPath__func__ClearCorners__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMeshPath__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshPath__get__corners(long selfObjectId, void* cornersIdsPointer, void* cornersWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshPath__get__status(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshPath__func__ClearCorners__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
