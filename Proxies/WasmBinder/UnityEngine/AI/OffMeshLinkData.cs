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
    public partial struct OffMeshLinkData
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal int m_Valid;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        internal int m_Activated;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        internal int m_InstanceID;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.AI.OffMeshLinkType m_LinkType;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_StartPos;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_EndPos;

        public bool valid 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__valid(ref this);
        }

        public bool activated 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__activated(ref this);
        }

        public global::UnityEngine.AI.OffMeshLinkType linkType 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__linkType(ref this);
        }

        public global::UnityEngine.Vector3 startPos 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__startPos(ref this);
        }

        public global::UnityEngine.Vector3 endPos 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__endPos(ref this);
        }

        public global::UnityEngine.AI.OffMeshLink offMeshLink 
        {
            get => internal_UnityEngineAIOffMeshLinkData__get__offMeshLink(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLinkData__get__valid(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAIOffMeshLinkData__get__valid(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLinkData__get__activated(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAIOffMeshLinkData__get__activated(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.OffMeshLinkType internal_UnityEngineAIOffMeshLinkData__get__linkType(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAIOffMeshLinkData__get__linkType(selfStructPointer);
            var returnResult = (global::UnityEngine.AI.OffMeshLinkType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAIOffMeshLinkData__get__startPos(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 startPosValue = default;
            UnityEngineAIOffMeshLinkData__get__startPos(selfStructPointer, Unsafe.AsPointer(ref startPosValue));
            global::UnityEngine.Vector3 returnResult = startPosValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAIOffMeshLinkData__get__endPos(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 endPosValue = default;
            UnityEngineAIOffMeshLinkData__get__endPos(selfStructPointer, Unsafe.AsPointer(ref endPosValue));
            global::UnityEngine.Vector3 returnResult = endPosValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.OffMeshLink internal_UnityEngineAIOffMeshLinkData__get__offMeshLink(ref global::UnityEngine.AI.OffMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAIOffMeshLinkData__get__offMeshLink(selfStructPointer);
            var returnResult = new global::UnityEngine.AI.OffMeshLink(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAIOffMeshLinkData__get__valid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAIOffMeshLinkData__get__activated(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAIOffMeshLinkData__get__linkType(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAIOffMeshLinkData__get__startPos(void* selfStructPointer, void* startPosPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAIOffMeshLinkData__get__endPos(void* selfStructPointer, void* endPosPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAIOffMeshLinkData__get__offMeshLink(void* selfStructPointer);

        #endregion Imports
    }
}
