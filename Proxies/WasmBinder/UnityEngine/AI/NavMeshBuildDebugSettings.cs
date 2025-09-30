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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct NavMeshBuildDebugSettings
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private byte m_Flags;

        public global::UnityEngine.AI.NavMeshBuildDebugFlags flags 
        {
            get => internal_UnityEngineAINavMeshBuildDebugSettings__get__flags(ref this);
            set => internal_UnityEngineAINavMeshBuildDebugSettings__set__flags(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildDebugFlags internal_UnityEngineAINavMeshBuildDebugSettings__get__flags(ref global::UnityEngine.AI.NavMeshBuildDebugSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildDebugSettings__get__flags(selfStructPointer);
            var returnResult = (global::UnityEngine.AI.NavMeshBuildDebugFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildDebugSettings__set__flags(ref global::UnityEngine.AI.NavMeshBuildDebugSettings selfStruct, global::UnityEngine.AI.NavMeshBuildDebugFlags flags)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildDebugSettings__set__flags(selfStructPointer, (int) flags);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildDebugSettings__get__flags(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildDebugSettings__set__flags(void* selfStructPointer, int flagsUnderlyingValue);

        #endregion Imports
    }
}
