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
    public partial struct NavMeshLinkData
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_StartPosition;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_EndPosition;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float m_CostModifier;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private int m_Bidirectional;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private float m_Width;

        // [FieldOffset(36)] (implicit field offset from sequential layout kind)
        private int m_Area;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        private int m_AgentTypeID;

        public global::UnityEngine.Vector3 startPosition 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__startPosition(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__startPosition(ref this, value);
        }

        public global::UnityEngine.Vector3 endPosition 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__endPosition(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__endPosition(ref this, value);
        }

        public float costModifier 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__costModifier(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__costModifier(ref this, value);
        }

        public bool bidirectional 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__bidirectional(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__bidirectional(ref this, value);
        }

        public float width 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__width(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__width(ref this, value);
        }

        public int area 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__area(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__area(ref this, value);
        }

        public int agentTypeID 
        {
            get => internal_UnityEngineAINavMeshLinkData__get__agentTypeID(ref this);
            set => internal_UnityEngineAINavMeshLinkData__set__agentTypeID(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshLinkData__get__startPosition(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 startPositionValue = default;
            UnityEngineAINavMeshLinkData__get__startPosition(selfStructPointer, Unsafe.AsPointer(ref startPositionValue));
            global::UnityEngine.Vector3 returnResult = startPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__startPosition(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, global::UnityEngine.Vector3 startPosition)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__startPosition(selfStructPointer, Unsafe.AsPointer(ref startPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshLinkData__get__endPosition(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 endPositionValue = default;
            UnityEngineAINavMeshLinkData__get__endPosition(selfStructPointer, Unsafe.AsPointer(ref endPositionValue));
            global::UnityEngine.Vector3 returnResult = endPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__endPosition(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, global::UnityEngine.Vector3 endPosition)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__endPosition(selfStructPointer, Unsafe.AsPointer(ref endPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshLinkData__get__costModifier(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkData__get__costModifier(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__costModifier(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, float costModifier)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__costModifier(selfStructPointer, costModifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshLinkData__get__bidirectional(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkData__get__bidirectional(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__bidirectional(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, bool bidirectional)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var bidirectionalConverted = Unsafe.As<bool, int>(ref bidirectional);
            UnityEngineAINavMeshLinkData__set__bidirectional(selfStructPointer, bidirectionalConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshLinkData__get__width(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkData__get__width(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__width(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, float width)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__width(selfStructPointer, width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshLinkData__get__area(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkData__get__area(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__area(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, int area)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__area(selfStructPointer, area);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshLinkData__get__agentTypeID(ref global::UnityEngine.AI.NavMeshLinkData selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshLinkData__get__agentTypeID(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshLinkData__set__agentTypeID(ref global::UnityEngine.AI.NavMeshLinkData selfStruct, int agentTypeID)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshLinkData__set__agentTypeID(selfStructPointer, agentTypeID);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__get__startPosition(void* selfStructPointer, void* startPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__startPosition(void* selfStructPointer, void* startPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__get__endPosition(void* selfStructPointer, void* endPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__endPosition(void* selfStructPointer, void* endPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshLinkData__get__costModifier(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__costModifier(void* selfStructPointer, float costModifier);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshLinkData__get__bidirectional(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__bidirectional(void* selfStructPointer, int bidirectionalConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshLinkData__get__width(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__width(void* selfStructPointer, float width);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshLinkData__get__area(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__area(void* selfStructPointer, int area);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshLinkData__get__agentTypeID(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshLinkData__set__agentTypeID(void* selfStructPointer, int agentTypeID);

        #endregion Imports
    }
}
