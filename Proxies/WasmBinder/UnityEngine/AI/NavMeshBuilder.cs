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

    public static class NavMeshBuilder
    {

        #region Implementation

        public static void CollectSources(global::UnityEngine.Bounds includedWorldBounds, int includedLayerMask, global::UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildMarkup> markups, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> results)
        {
            internal_UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineBounds__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(includedWorldBounds, includedLayerMask, geometry, defaultArea, markups, results);
        }

        public static void CollectSources(global::UnityEngine.Transform root, int includedLayerMask, global::UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildMarkup> markups, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> results)
        {
            internal_UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineTransform__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(root, includedLayerMask, geometry, defaultArea, markups, results);
        }

        public static global::UnityEngine.AI.NavMeshData BuildNavMeshData(global::UnityEngine.AI.NavMeshBuildSettings buildSettings, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> sources, global::UnityEngine.Bounds localBounds, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEngineAINavMeshBuilder__func__BuildNavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshData(buildSettings, sources, localBounds, position, rotation);
        }

        public static bool UpdateNavMeshData(global::UnityEngine.AI.NavMeshData data, global::UnityEngine.AI.NavMeshBuildSettings buildSettings, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> sources, global::UnityEngine.Bounds localBounds)
        {
            return internal_UnityEngineAINavMeshBuilder__func__UpdateNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__SystemBoolean(data, buildSettings, sources, localBounds);
        }

        public static void Cancel(global::UnityEngine.AI.NavMeshData data)
        {
            internal_UnityEngineAINavMeshBuilder__func__Cancel__UnityEngineAINavMeshData__SystemVoid(data);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineBounds__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(global::UnityEngine.Bounds includedWorldBounds, int includedLayerMask, global::UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildMarkup> markupsList, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> resultsList)
        {
            Span<global::UnityEngine.AI.NavMeshBuildMarkup> markups = CollectionsMarshal.AsSpan(markupsList);
            Span<global::UnityEngine.AI.NavMeshBuildSource> results = CollectionsMarshal.AsSpan(resultsList);
            fixed (global::UnityEngine.AI.NavMeshBuildMarkup* markupsPointer = markups)
            {
                fixed (global::UnityEngine.AI.NavMeshBuildSource* resultsPointer = results)
                {
                    UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineBounds__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(Unsafe.AsPointer(ref includedWorldBounds), includedLayerMask, (int) geometry, defaultArea, markupsPointer, markups.Length, resultsPointer, results.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineTransform__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(global::UnityEngine.Transform root, int includedLayerMask, global::UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildMarkup> markupsList, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> resultsList)
        {
            Span<global::UnityEngine.AI.NavMeshBuildMarkup> markups = CollectionsMarshal.AsSpan(markupsList);
            Span<global::UnityEngine.AI.NavMeshBuildSource> results = CollectionsMarshal.AsSpan(resultsList);
            fixed (global::UnityEngine.AI.NavMeshBuildMarkup* markupsPointer = markups)
            {
                fixed (global::UnityEngine.AI.NavMeshBuildSource* resultsPointer = results)
                {
                    UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineTransform__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(root.WrappedId, includedLayerMask, (int) geometry, defaultArea, markupsPointer, markups.Length, resultsPointer, results.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshData internal_UnityEngineAINavMeshBuilder__func__BuildNavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshData(global::UnityEngine.AI.NavMeshBuildSettings buildSettings, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> sourcesList, global::UnityEngine.Bounds localBounds, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            Span<global::UnityEngine.AI.NavMeshBuildSource> sources = CollectionsMarshal.AsSpan(sourcesList);
            fixed (global::UnityEngine.AI.NavMeshBuildSource* sourcesPointer = sources)
            {
                var methodCallResult = UnityEngineAINavMeshBuilder__func__BuildNavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshData(Unsafe.AsPointer(ref buildSettings), sourcesPointer, sources.Length, Unsafe.AsPointer(ref localBounds), Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
                var returnResult = new global::UnityEngine.AI.NavMeshData(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuilder__func__UpdateNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__SystemBoolean(global::UnityEngine.AI.NavMeshData data, global::UnityEngine.AI.NavMeshBuildSettings buildSettings, global::System.Collections.Generic.List<global::UnityEngine.AI.NavMeshBuildSource> sourcesList, global::UnityEngine.Bounds localBounds)
        {
            Span<global::UnityEngine.AI.NavMeshBuildSource> sources = CollectionsMarshal.AsSpan(sourcesList);
            fixed (global::UnityEngine.AI.NavMeshBuildSource* sourcesPointer = sources)
            {
                var methodCallResult = UnityEngineAINavMeshBuilder__func__UpdateNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__SystemBoolean(data.WrappedId, Unsafe.AsPointer(ref buildSettings), sourcesPointer, sources.Length, Unsafe.AsPointer(ref localBounds));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuilder__func__Cancel__UnityEngineAINavMeshData__SystemVoid(global::UnityEngine.AI.NavMeshData data)
        {
            UnityEngineAINavMeshBuilder__func__Cancel__UnityEngineAINavMeshData__SystemVoid(data.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineBounds__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(void* includedWorldBoundsPointer, int includedLayerMask, int geometryUnderlyingValue, int defaultArea, void* markupsPointer, int markupsWasmLength, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuilder__func__CollectSources__UnityEngineTransform__SystemInt32__UnityEngineAINavMeshCollectGeometryEnum__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildMarkup__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__SystemVoid(long rootObjectId, int includedLayerMask, int geometryUnderlyingValue, int defaultArea, void* markupsPointer, int markupsWasmLength, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAINavMeshBuilder__func__BuildNavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAINavMeshData(void* buildSettingsPointer, void* sourcesPointer, int sourcesWasmLength, void* localBoundsPointer, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuilder__func__UpdateNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshBuildSettings__SystemCollectionsGeneric_List_UnityEngineAINavMeshBuildSource__UnityEngineBounds__SystemBoolean(long dataObjectId, void* buildSettingsPointer, void* sourcesPointer, int sourcesWasmLength, void* localBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshBuilder__func__Cancel__UnityEngineAINavMeshData__SystemVoid(long dataObjectId);

        #endregion Imports
    }
}
