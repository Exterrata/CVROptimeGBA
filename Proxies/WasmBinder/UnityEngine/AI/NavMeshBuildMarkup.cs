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
    public partial struct NavMeshBuildMarkup
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_OverrideArea;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_Area;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_IgnoreFromBuild;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private int m_InstanceID;

        public bool overrideArea 
        {
            get => internal_UnityEngineAINavMeshBuildMarkup__get__overrideArea(ref this);
            set => internal_UnityEngineAINavMeshBuildMarkup__set__overrideArea(ref this, value);
        }

        public int area 
        {
            get => internal_UnityEngineAINavMeshBuildMarkup__get__area(ref this);
            set => internal_UnityEngineAINavMeshBuildMarkup__set__area(ref this, value);
        }

        public bool ignoreFromBuild 
        {
            get => internal_UnityEngineAINavMeshBuildMarkup__get__ignoreFromBuild(ref this);
            set => internal_UnityEngineAINavMeshBuildMarkup__set__ignoreFromBuild(ref this, value);
        }

        public global::UnityEngine.Transform root 
        {
            get => internal_UnityEngineAINavMeshBuildMarkup__get__root(ref this);
            set => internal_UnityEngineAINavMeshBuildMarkup__set__root(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildMarkup__get__overrideArea(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildMarkup__get__overrideArea(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildMarkup__set__overrideArea(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct, bool overrideArea)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var overrideAreaConverted = Unsafe.As<bool, int>(ref overrideArea);
            UnityEngineAINavMeshBuildMarkup__set__overrideArea(selfStructPointer, overrideAreaConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshBuildMarkup__get__area(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildMarkup__get__area(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildMarkup__set__area(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct, int area)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildMarkup__set__area(selfStructPointer, area);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshBuildMarkup__get__ignoreFromBuild(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildMarkup__get__ignoreFromBuild(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildMarkup__set__ignoreFromBuild(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct, bool ignoreFromBuild)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var ignoreFromBuildConverted = Unsafe.As<bool, int>(ref ignoreFromBuild);
            UnityEngineAINavMeshBuildMarkup__set__ignoreFromBuild(selfStructPointer, ignoreFromBuildConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineAINavMeshBuildMarkup__get__root(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildMarkup__get__root(selfStructPointer);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildMarkup__set__root(ref global::UnityEngine.AI.NavMeshBuildMarkup selfStruct, global::UnityEngine.Transform root)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildMarkup__set__root(selfStructPointer, root.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildMarkup__get__overrideArea(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildMarkup__set__overrideArea(void* selfStructPointer, int overrideAreaConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildMarkup__get__area(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildMarkup__set__area(void* selfStructPointer, int area);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildMarkup__get__ignoreFromBuild(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildMarkup__set__ignoreFromBuild(void* selfStructPointer, int ignoreFromBuildConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAINavMeshBuildMarkup__get__root(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildMarkup__set__root(void* selfStructPointer, long rootObjectId);

        #endregion Imports
    }
}
