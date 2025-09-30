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
    public partial struct NavMeshLinkInstance
    {

        #region Implementation

        // [FieldOffset(0)] (the backing field offset)
        internal int id { get; set; }

        public bool valid 
        {
            get => internal_UnityEngineAINavMeshLinkInstance__get__valid(ref this);
        }

        public global::UnityEngine.Object owner 
        {
            get => internal_UnityEngineAINavMeshLinkInstance__get__owner(ref this);
            set => internal_UnityEngineAINavMeshLinkInstance__set__owner(ref this, value);
        }

        public void Remove()
        {
            internal_UnityEngineAINavMeshLinkInstance__func__Remove__SystemVoid(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshLinkInstance__get__valid(ref global::UnityEngine.AI.NavMeshLinkInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkInstance__get__valid(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineAINavMeshLinkInstance__get__owner(ref global::UnityEngine.AI.NavMeshLinkInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkInstance__get__owner(selfStructPointer);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkInstance__set__owner(ref global::UnityEngine.AI.NavMeshLinkInstance selfStruct, global::UnityEngine.Object owner)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkInstance__set__owner(selfStructPointer, owner.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkInstance__func__Remove__SystemVoid(ref global::UnityEngine.AI.NavMeshLinkInstance selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkInstance__func__Remove__SystemVoid(selfStructPointer);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshLinkInstance__get__valid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAINavMeshLinkInstance__get__owner(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkInstance__set__owner(void* selfStructPointer, long ownerObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkInstance__func__Remove__SystemVoid(void* selfStructPointer);

        #endregion Imports
    }
}
