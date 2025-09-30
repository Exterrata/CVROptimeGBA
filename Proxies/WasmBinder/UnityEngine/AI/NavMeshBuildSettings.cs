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
    public partial struct NavMeshBuildSettings
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_AgentTypeID;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float m_AgentRadius;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private float m_AgentHeight;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_AgentSlope;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private float m_AgentClimb;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private float m_LedgeDropHeight;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float m_MaxJumpAcrossDistance;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private float m_MinRegionArea;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private int m_OverrideVoxelSize;

        // [FieldOffset(36)] (implicit field offset from sequential layout kind)
        private float m_VoxelSize;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        private int m_OverrideTileSize;

        // [FieldOffset(44)] (implicit field offset from sequential layout kind)
        private int m_TileSize;

        // [FieldOffset(48)] (implicit field offset from sequential layout kind)
        private int m_BuildHeightMesh;

        // [FieldOffset(52)] (implicit field offset from sequential layout kind)
        private uint m_MaxJobWorkers;

        // [FieldOffset(56)] (implicit field offset from sequential layout kind)
        private int m_PreserveTilesOutsideBounds;

        // [FieldOffset(60)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.AI.NavMeshBuildDebugSettings m_Debug;

        public int agentTypeID 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__agentTypeID(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__agentTypeID(ref this, value);
        }

        public float agentRadius 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__agentRadius(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__agentRadius(ref this, value);
        }

        public float agentHeight 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__agentHeight(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__agentHeight(ref this, value);
        }

        public float agentSlope 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__agentSlope(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__agentSlope(ref this, value);
        }

        public float agentClimb 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__agentClimb(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__agentClimb(ref this, value);
        }

        public float ledgeDropHeight 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__ledgeDropHeight(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__ledgeDropHeight(ref this, value);
        }

        public float maxJumpAcrossDistance 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__maxJumpAcrossDistance(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__maxJumpAcrossDistance(ref this, value);
        }

        public float minRegionArea 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__minRegionArea(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__minRegionArea(ref this, value);
        }

        public bool overrideVoxelSize 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__overrideVoxelSize(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__overrideVoxelSize(ref this, value);
        }

        public float voxelSize 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__voxelSize(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__voxelSize(ref this, value);
        }

        public bool overrideTileSize 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__overrideTileSize(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__overrideTileSize(ref this, value);
        }

        public int tileSize 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__tileSize(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__tileSize(ref this, value);
        }

        public uint maxJobWorkers 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__maxJobWorkers(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__maxJobWorkers(ref this, value);
        }

        public bool preserveTilesOutsideBounds 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__preserveTilesOutsideBounds(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__preserveTilesOutsideBounds(ref this, value);
        }

        public bool buildHeightMesh 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__buildHeightMesh(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__buildHeightMesh(ref this, value);
        }

        public global::UnityEngine.AI.NavMeshBuildDebugSettings debug 
        {
            get => internal_UnityEngineAINavMeshBuildSettings__get__debug(ref this);
            set => internal_UnityEngineAINavMeshBuildSettings__set__debug(ref this, value);
        }

        public global::System.String[] ValidationReport(global::UnityEngine.Bounds buildBounds)
        {
            return internal_UnityEngineAINavMeshBuildSettings__func__ValidationReport__UnityEngineBounds__SystemStringArray(ref this, buildBounds);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshBuildSettings__get__agentTypeID(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__agentTypeID(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__agentTypeID(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, int agentTypeID)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__agentTypeID(selfStructPointer, agentTypeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__agentRadius(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__agentRadius(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__agentRadius(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float agentRadius)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__agentRadius(selfStructPointer, agentRadius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__agentHeight(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__agentHeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__agentHeight(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float agentHeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__agentHeight(selfStructPointer, agentHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__agentSlope(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__agentSlope(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__agentSlope(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float agentSlope)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__agentSlope(selfStructPointer, agentSlope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__agentClimb(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__agentClimb(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__agentClimb(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float agentClimb)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__agentClimb(selfStructPointer, agentClimb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__ledgeDropHeight(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__ledgeDropHeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__ledgeDropHeight(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float ledgeDropHeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__ledgeDropHeight(selfStructPointer, ledgeDropHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__maxJumpAcrossDistance(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__maxJumpAcrossDistance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__maxJumpAcrossDistance(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float maxJumpAcrossDistance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__maxJumpAcrossDistance(selfStructPointer, maxJumpAcrossDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__minRegionArea(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__minRegionArea(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__minRegionArea(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float minRegionArea)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__minRegionArea(selfStructPointer, minRegionArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildSettings__get__overrideVoxelSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__overrideVoxelSize(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__overrideVoxelSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, bool overrideVoxelSize)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var overrideVoxelSizeConverted = Unsafe.As<bool, int>(ref overrideVoxelSize);
            UnityEngineAINavMeshBuildSettings__set__overrideVoxelSize(selfStructPointer, overrideVoxelSizeConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshBuildSettings__get__voxelSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__voxelSize(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__voxelSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, float voxelSize)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__voxelSize(selfStructPointer, voxelSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildSettings__get__overrideTileSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__overrideTileSize(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__overrideTileSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, bool overrideTileSize)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var overrideTileSizeConverted = Unsafe.As<bool, int>(ref overrideTileSize);
            UnityEngineAINavMeshBuildSettings__set__overrideTileSize(selfStructPointer, overrideTileSizeConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshBuildSettings__get__tileSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__tileSize(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__tileSize(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, int tileSize)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__tileSize(selfStructPointer, tileSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineAINavMeshBuildSettings__get__maxJobWorkers(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__maxJobWorkers(selfStructPointer);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__maxJobWorkers(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, uint maxJobWorkers)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var maxJobWorkersConverted = Unsafe.As<uint, int>(ref maxJobWorkers);
            UnityEngineAINavMeshBuildSettings__set__maxJobWorkers(selfStructPointer, maxJobWorkersConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildSettings__get__preserveTilesOutsideBounds(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__preserveTilesOutsideBounds(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__preserveTilesOutsideBounds(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, bool preserveTilesOutsideBounds)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var preserveTilesOutsideBoundsConverted = Unsafe.As<bool, int>(ref preserveTilesOutsideBounds);
            UnityEngineAINavMeshBuildSettings__set__preserveTilesOutsideBounds(selfStructPointer, preserveTilesOutsideBoundsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildSettings__get__buildHeightMesh(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSettings__get__buildHeightMesh(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__buildHeightMesh(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, bool buildHeightMesh)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var buildHeightMeshConverted = Unsafe.As<bool, int>(ref buildHeightMesh);
            UnityEngineAINavMeshBuildSettings__set__buildHeightMesh(selfStructPointer, buildHeightMeshConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildDebugSettings internal_UnityEngineAINavMeshBuildSettings__get__debug(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.AI.NavMeshBuildDebugSettings debugValue = default;
            UnityEngineAINavMeshBuildSettings__get__debug(selfStructPointer, Unsafe.AsPointer(ref debugValue));
            global::UnityEngine.AI.NavMeshBuildDebugSettings returnResult = debugValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSettings__set__debug(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, global::UnityEngine.AI.NavMeshBuildDebugSettings debug)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSettings__set__debug(selfStructPointer, Unsafe.AsPointer(ref debug));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineAINavMeshBuildSettings__func__ValidationReport__UnityEngineBounds__SystemStringArray(ref global::UnityEngine.AI.NavMeshBuildSettings selfStruct, global::UnityEngine.Bounds buildBounds)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Exterrata: I would really like to put returnResultPointer first instead of returnResultWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* returnResultWasmLengthsPointer = default;
            char** returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineAINavMeshBuildSettings__func__ValidationReport__UnityEngineBounds__SystemStringArray(selfStructPointer, Unsafe.AsPointer(ref buildBounds), &returnResultWasmLengthsPointer, &returnResultPointer, &returnResultWasmLength);

            // The changes were written to the pointers directly, we need to write to the array and free allocations
            var returnResultAux = new string[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResultAux[i] = new string(returnResultPointer![i], 0, returnResultWasmLengthsPointer![i]);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            Marshal.FreeHGlobal((IntPtr)returnResultWasmLengthsPointer);
            var returnResult = returnResultAux;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__agentTypeID(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__agentTypeID(void* selfStructPointer, int agentTypeID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__agentRadius(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__agentRadius(void* selfStructPointer, float agentRadius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__agentHeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__agentHeight(void* selfStructPointer, float agentHeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__agentSlope(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__agentSlope(void* selfStructPointer, float agentSlope);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__agentClimb(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__agentClimb(void* selfStructPointer, float agentClimb);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__ledgeDropHeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__ledgeDropHeight(void* selfStructPointer, float ledgeDropHeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__maxJumpAcrossDistance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__maxJumpAcrossDistance(void* selfStructPointer, float maxJumpAcrossDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__minRegionArea(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__minRegionArea(void* selfStructPointer, float minRegionArea);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__overrideVoxelSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__overrideVoxelSize(void* selfStructPointer, int overrideVoxelSizeConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshBuildSettings__get__voxelSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__voxelSize(void* selfStructPointer, float voxelSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__overrideTileSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__overrideTileSize(void* selfStructPointer, int overrideTileSizeConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__tileSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__tileSize(void* selfStructPointer, int tileSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__maxJobWorkers(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__maxJobWorkers(void* selfStructPointer, int maxJobWorkersConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__preserveTilesOutsideBounds(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__preserveTilesOutsideBounds(void* selfStructPointer, int preserveTilesOutsideBoundsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSettings__get__buildHeightMesh(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__buildHeightMesh(void* selfStructPointer, int buildHeightMeshConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__get__debug(void* selfStructPointer, void* debugPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__set__debug(void* selfStructPointer, void* debugPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSettings__func__ValidationReport__UnityEngineBounds__SystemStringArray(void* selfStructPointer, void* buildBoundsPointer, void* returnResultWasmLengthsPointer, void* returnResultPointer, void* returnResultWasmLengthPointer);

        #endregion Imports
    }
}
