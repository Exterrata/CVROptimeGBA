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

    public static class NavMesh
    {

        #region Fields Constants

        public const int AllAreas = -1;

        #endregion Fields Constants

        #region Implementation

        public static float avoidancePredictionTime 
        {
            get => internal_UnityEngineAINavMesh__get__avoidancePredictionTime();
            set => internal_UnityEngineAINavMesh__set__avoidancePredictionTime(value);
        }

        public static int pathfindingIterationsPerFrame 
        {
            get => internal_UnityEngineAINavMesh__get__pathfindingIterationsPerFrame();
            set => internal_UnityEngineAINavMesh__set__pathfindingIterationsPerFrame(value);
        }

        public static bool Raycast(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit, int areaMask)
        {
            return internal_UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(sourcePosition, targetPosition, out hit, areaMask);
        }

        public static bool CalculatePath(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, int areaMask, global::UnityEngine.AI.NavMeshPath path)
        {
            return internal_UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineAINavMeshPath__SystemBoolean(sourcePosition, targetPosition, areaMask, path);
        }

        public static bool FindClosestEdge(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, int areaMask)
        {
            return internal_UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(sourcePosition, out hit, areaMask);
        }

        public static bool SamplePosition(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, float maxDistance, int areaMask)
        {
            return internal_UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__SystemInt32__SystemBoolean(sourcePosition, out hit, maxDistance, areaMask);
        }

        public static void SetAreaCost(int areaIndex, float cost)
        {
            internal_UnityEngineAINavMesh__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(areaIndex, cost);
        }

        public static float GetAreaCost(int areaIndex)
        {
            return internal_UnityEngineAINavMesh__func__GetAreaCost__SystemInt32__SystemSingle(areaIndex);
        }

        public static int GetAreaFromName(string areaName)
        {
            return internal_UnityEngineAINavMesh__func__GetAreaFromName__SystemString__SystemInt32(areaName);
        }

        public static global::UnityEngine.AI.NavMeshTriangulation CalculateTriangulation()
        {
            return internal_UnityEngineAINavMesh__func__CalculateTriangulation__UnityEngineAINavMeshTriangulation();
        }

        public static global::UnityEngine.AI.NavMeshDataInstance AddNavMeshData(global::UnityEngine.AI.NavMeshData navMeshData)
        {
            return internal_UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshDataInstance(navMeshData);
        }

        public static global::UnityEngine.AI.NavMeshDataInstance AddNavMeshData(global::UnityEngine.AI.NavMeshData navMeshData, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshDataInstance(navMeshData, position, rotation);
        }

        public static void RemoveNavMeshData(global::UnityEngine.AI.NavMeshDataInstance handle)
        {
            internal_UnityEngineAINavMesh__func__RemoveNavMeshData__UnityEngineAINavMeshDataInstance__SystemVoid(handle);
        }

        public static global::UnityEngine.AI.NavMeshLinkInstance AddLink(global::UnityEngine.AI.NavMeshLinkData link)
        {
            return internal_UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineAINavMeshLinkInstance(link);
        }

        public static global::UnityEngine.AI.NavMeshLinkInstance AddLink(global::UnityEngine.AI.NavMeshLinkData link, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshLinkInstance(link, position, rotation);
        }

        public static void RemoveLink(global::UnityEngine.AI.NavMeshLinkInstance handle)
        {
            internal_UnityEngineAINavMesh__func__RemoveLink__UnityEngineAINavMeshLinkInstance__SystemVoid(handle);
        }

        public static bool SamplePosition(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, float maxDistance, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            return internal_UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__UnityEngineAINavMeshQueryFilter__SystemBoolean(sourcePosition, out hit, maxDistance, filter);
        }

        public static bool FindClosestEdge(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            return internal_UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(sourcePosition, out hit, filter);
        }

        public static bool Raycast(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            return internal_UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(sourcePosition, targetPosition, out hit, filter);
        }

        public static bool CalculatePath(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, global::UnityEngine.AI.NavMeshQueryFilter filter, global::UnityEngine.AI.NavMeshPath path)
        {
            return internal_UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshQueryFilter__UnityEngineAINavMeshPath__SystemBoolean(sourcePosition, targetPosition, filter, path);
        }

        public static global::UnityEngine.AI.NavMeshBuildSettings CreateSettings()
        {
            return internal_UnityEngineAINavMesh__func__CreateSettings__UnityEngineAINavMeshBuildSettings();
        }

        public static void RemoveSettings(int agentTypeID)
        {
            internal_UnityEngineAINavMesh__func__RemoveSettings__SystemInt32__SystemVoid(agentTypeID);
        }

        public static global::UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(int agentTypeID)
        {
            return internal_UnityEngineAINavMesh__func__GetSettingsByID__SystemInt32__UnityEngineAINavMeshBuildSettings(agentTypeID);
        }

        public static int GetSettingsCount()
        {
            return internal_UnityEngineAINavMesh__func__GetSettingsCount__SystemInt32();
        }

        public static global::UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(int index)
        {
            return internal_UnityEngineAINavMesh__func__GetSettingsByIndex__SystemInt32__UnityEngineAINavMeshBuildSettings(index);
        }

        public static string GetSettingsNameFromID(int agentTypeID)
        {
            return internal_UnityEngineAINavMesh__func__GetSettingsNameFromID__SystemInt32__SystemString(agentTypeID);
        }

        public static void RemoveAllNavMeshData()
        {
            internal_UnityEngineAINavMesh__func__RemoveAllNavMeshData__SystemVoid();
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMesh__get__avoidancePredictionTime()
        {
            var methodCallResult = UnityEngineAINavMesh__get__avoidancePredictionTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__set__avoidancePredictionTime(float avoidancePredictionTime)
        {
            UnityEngineAINavMesh__set__avoidancePredictionTime(avoidancePredictionTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMesh__get__pathfindingIterationsPerFrame()
        {
            var methodCallResult = UnityEngineAINavMesh__get__pathfindingIterationsPerFrame();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__set__pathfindingIterationsPerFrame(int pathfindingIterationsPerFrame)
        {
            UnityEngineAINavMesh__set__pathfindingIterationsPerFrame(pathfindingIterationsPerFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit, int areaMask)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref targetPosition), Unsafe.AsPointer(ref hit), areaMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineAINavMeshPath__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, int areaMask, global::UnityEngine.AI.NavMeshPath path)
        {
            var methodCallResult = UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineAINavMeshPath__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref targetPosition), areaMask, path.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, int areaMask)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref hit), areaMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, float maxDistance, int areaMask)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref hit), maxDistance, areaMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(int areaIndex, float cost)
        {
            UnityEngineAINavMesh__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(areaIndex, cost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMesh__func__GetAreaCost__SystemInt32__SystemSingle(int areaIndex)
        {
            var methodCallResult = UnityEngineAINavMesh__func__GetAreaCost__SystemInt32__SystemSingle(areaIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMesh__func__GetAreaFromName__SystemString__SystemInt32(string areaName)
        {
            fixed (char* areaNamePointer = areaName)
            {
                var methodCallResult = UnityEngineAINavMesh__func__GetAreaFromName__SystemString__SystemInt32(areaNamePointer, areaName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshTriangulation internal_UnityEngineAINavMesh__func__CalculateTriangulation__UnityEngineAINavMeshTriangulation()
        {
            var methodCallResult = UnityEngineAINavMesh__func__CalculateTriangulation__UnityEngineAINavMeshTriangulation();
            var returnResult = new global::UnityEngine.AI.NavMeshTriangulation(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshDataInstance internal_UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshDataInstance(global::UnityEngine.AI.NavMeshData navMeshData)
        {
            global::UnityEngine.AI.NavMeshDataInstance returnResultValue = default;
            UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshDataInstance(navMeshData.WrappedId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshDataInstance returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshDataInstance internal_UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshDataInstance(global::UnityEngine.AI.NavMeshData navMeshData, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            global::UnityEngine.AI.NavMeshDataInstance returnResultValue = default;
            UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshDataInstance(navMeshData.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshDataInstance returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__func__RemoveNavMeshData__UnityEngineAINavMeshDataInstance__SystemVoid(global::UnityEngine.AI.NavMeshDataInstance handle)
        {
            UnityEngineAINavMesh__func__RemoveNavMeshData__UnityEngineAINavMeshDataInstance__SystemVoid(Unsafe.AsPointer(ref handle));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshLinkInstance internal_UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineAINavMeshLinkInstance(global::UnityEngine.AI.NavMeshLinkData link)
        {
            global::UnityEngine.AI.NavMeshLinkInstance returnResultValue = default;
            UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineAINavMeshLinkInstance(Unsafe.AsPointer(ref link), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshLinkInstance returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshLinkInstance internal_UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshLinkInstance(global::UnityEngine.AI.NavMeshLinkData link, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            global::UnityEngine.AI.NavMeshLinkInstance returnResultValue = default;
            UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshLinkInstance(Unsafe.AsPointer(ref link), Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshLinkInstance returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__func__RemoveLink__UnityEngineAINavMeshLinkInstance__SystemVoid(global::UnityEngine.AI.NavMeshLinkInstance handle)
        {
            UnityEngineAINavMesh__func__RemoveLink__UnityEngineAINavMeshLinkInstance__SystemVoid(Unsafe.AsPointer(ref handle));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__UnityEngineAINavMeshQueryFilter__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, float maxDistance, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__UnityEngineAINavMeshQueryFilter__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref hit), maxDistance, filter.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref hit), filter.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit, global::UnityEngine.AI.NavMeshQueryFilter filter)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref targetPosition), Unsafe.AsPointer(ref hit), filter.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshQueryFilter__UnityEngineAINavMeshPath__SystemBoolean(global::UnityEngine.Vector3 sourcePosition, global::UnityEngine.Vector3 targetPosition, global::UnityEngine.AI.NavMeshQueryFilter filter, global::UnityEngine.AI.NavMeshPath path)
        {
            var methodCallResult = UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshQueryFilter__UnityEngineAINavMeshPath__SystemBoolean(Unsafe.AsPointer(ref sourcePosition), Unsafe.AsPointer(ref targetPosition), filter.WrappedId, path.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildSettings internal_UnityEngineAINavMesh__func__CreateSettings__UnityEngineAINavMeshBuildSettings()
        {
            global::UnityEngine.AI.NavMeshBuildSettings returnResultValue = default;
            UnityEngineAINavMesh__func__CreateSettings__UnityEngineAINavMeshBuildSettings(Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshBuildSettings returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__func__RemoveSettings__SystemInt32__SystemVoid(int agentTypeID)
        {
            UnityEngineAINavMesh__func__RemoveSettings__SystemInt32__SystemVoid(agentTypeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildSettings internal_UnityEngineAINavMesh__func__GetSettingsByID__SystemInt32__UnityEngineAINavMeshBuildSettings(int agentTypeID)
        {
            global::UnityEngine.AI.NavMeshBuildSettings returnResultValue = default;
            UnityEngineAINavMesh__func__GetSettingsByID__SystemInt32__UnityEngineAINavMeshBuildSettings(agentTypeID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshBuildSettings returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMesh__func__GetSettingsCount__SystemInt32()
        {
            var methodCallResult = UnityEngineAINavMesh__func__GetSettingsCount__SystemInt32();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildSettings internal_UnityEngineAINavMesh__func__GetSettingsByIndex__SystemInt32__UnityEngineAINavMeshBuildSettings(int index)
        {
            global::UnityEngine.AI.NavMeshBuildSettings returnResultValue = default;
            UnityEngineAINavMesh__func__GetSettingsByIndex__SystemInt32__UnityEngineAINavMeshBuildSettings(index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AI.NavMeshBuildSettings returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineAINavMesh__func__GetSettingsNameFromID__SystemInt32__SystemString(int agentTypeID)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineAINavMesh__func__GetSettingsNameFromID__SystemInt32__SystemString(agentTypeID, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMesh__func__RemoveAllNavMeshData__SystemVoid()
        {
            UnityEngineAINavMesh__func__RemoveAllNavMeshData__SystemVoid();
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMesh__get__avoidancePredictionTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMesh__set__avoidancePredictionTime(float avoidancePredictionTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMesh__get__pathfindingIterationsPerFrame();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMesh__set__pathfindingIterationsPerFrame(int pathfindingIterationsPerFrame);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(void* sourcePositionPointer, void* targetPositionPointer, void* hitPointer, int areaMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineAINavMeshPath__SystemBoolean(void* sourcePositionPointer, void* targetPositionPointer, int areaMask, long pathObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemInt32__SystemBoolean(void* sourcePositionPointer, void* hitPointer, int areaMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__SystemInt32__SystemBoolean(void* sourcePositionPointer, void* hitPointer, float maxDistance, int areaMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMesh__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(int areaIndex, float cost);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMesh__func__GetAreaCost__SystemInt32__SystemSingle(int areaIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__GetAreaFromName__SystemString__SystemInt32(void* areaNamePointer, int areaNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMesh__func__CalculateTriangulation__UnityEngineAINavMeshTriangulation();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshDataInstance(long navMeshDataObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__AddNavMeshData__UnityEngineAINavMeshData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshDataInstance(long navMeshDataObjectId, void* positionPointer, void* rotationPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__RemoveNavMeshData__UnityEngineAINavMeshDataInstance__SystemVoid(void* handlePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineAINavMeshLinkInstance(void* linkPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__AddLink__UnityEngineAINavMeshLinkData__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshLinkInstance(void* linkPointer, void* positionPointer, void* rotationPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__RemoveLink__UnityEngineAINavMeshLinkInstance__SystemVoid(void* handlePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__SamplePosition__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemSingle__UnityEngineAINavMeshQueryFilter__SystemBoolean(void* sourcePositionPointer, void* hitPointer, float maxDistance, long filterObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__FindClosestEdge__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(void* sourcePositionPointer, void* hitPointer, long filterObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshHitRef__UnityEngineAINavMeshQueryFilter__SystemBoolean(void* sourcePositionPointer, void* targetPositionPointer, void* hitPointer, long filterObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMesh__func__CalculatePath__UnityEngineVector3__UnityEngineVector3__UnityEngineAINavMeshQueryFilter__UnityEngineAINavMeshPath__SystemBoolean(void* sourcePositionPointer, void* targetPositionPointer, long filterObjectId, long pathObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__CreateSettings__UnityEngineAINavMeshBuildSettings(void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMesh__func__RemoveSettings__SystemInt32__SystemVoid(int agentTypeID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__GetSettingsByID__SystemInt32__UnityEngineAINavMeshBuildSettings(int agentTypeID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMesh__func__GetSettingsCount__SystemInt32();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__GetSettingsByIndex__SystemInt32__UnityEngineAINavMeshBuildSettings(int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMesh__func__GetSettingsNameFromID__SystemInt32__SystemString(int agentTypeID, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMesh__func__RemoveAllNavMeshData__SystemVoid();

        #endregion Imports
    }
}
