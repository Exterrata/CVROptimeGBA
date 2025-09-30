//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.SceneManagement
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct Scene
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_Handle;

        public int handle 
        {
            get => internal_UnityEngineSceneManagementScene__get__handle(ref this);
        }

        public string path 
        {
            get => internal_UnityEngineSceneManagementScene__get__path(ref this);
        }

        public string name 
        {
            get => internal_UnityEngineSceneManagementScene__get__name(ref this);
            set => internal_UnityEngineSceneManagementScene__set__name(ref this, value);
        }

        public bool isLoaded 
        {
            get => internal_UnityEngineSceneManagementScene__get__isLoaded(ref this);
        }

        public int buildIndex 
        {
            get => internal_UnityEngineSceneManagementScene__get__buildIndex(ref this);
        }

        public bool isDirty 
        {
            get => internal_UnityEngineSceneManagementScene__get__isDirty(ref this);
        }

        public int rootCount 
        {
            get => internal_UnityEngineSceneManagementScene__get__rootCount(ref this);
        }

        public bool isSubScene 
        {
            get => internal_UnityEngineSceneManagementScene__get__isSubScene(ref this);
            set => internal_UnityEngineSceneManagementScene__set__isSubScene(ref this, value);
        }

        public bool IsValid()
        {
            return internal_UnityEngineSceneManagementScene__func__IsValid__SystemBoolean(ref this);
        }

        public global::UnityEngine.GameObject[] GetRootGameObjects()
        {
            return internal_UnityEngineSceneManagementScene__func__GetRootGameObjects__UnityEngineGameObjectArray(ref this);
        }

        public void GetRootGameObjects(global::System.Collections.Generic.List<global::UnityEngine.GameObject> rootGameObjects)
        {
            internal_UnityEngineSceneManagementScene__func__GetRootGameObjects__SystemCollectionsGeneric_List_UnityEngineGameObject__SystemVoid(ref this, rootGameObjects);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineSceneManagementScene__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineSceneManagementScene__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineSceneManagementScene__get__handle(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__handle(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineSceneManagementScene__get__path(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* pathPointer = default;
            int pathWasmLength = default;
            UnityEngineSceneManagementScene__get__path(selfStructPointer, &pathPointer, &pathWasmLength);
            string returnResult = new(pathPointer, 0, pathWasmLength);
            Marshal.FreeHGlobal((IntPtr)pathPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineSceneManagementScene__get__name(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineSceneManagementScene__get__name(selfStructPointer, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSceneManagementScene__set__name(ref global::UnityEngine.SceneManagement.Scene selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineSceneManagementScene__set__name(selfStructPointer, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSceneManagementScene__get__isLoaded(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__isLoaded(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineSceneManagementScene__get__buildIndex(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__buildIndex(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSceneManagementScene__get__isDirty(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__isDirty(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineSceneManagementScene__get__rootCount(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__rootCount(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSceneManagementScene__get__isSubScene(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__get__isSubScene(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSceneManagementScene__set__isSubScene(ref global::UnityEngine.SceneManagement.Scene selfStruct, bool isSubScene)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var isSubSceneConverted = Unsafe.As<bool, int>(ref isSubScene);
            UnityEngineSceneManagementScene__set__isSubScene(selfStructPointer, isSubSceneConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSceneManagementScene__func__IsValid__SystemBoolean(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__func__IsValid__SystemBoolean(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject[] internal_UnityEngineSceneManagementScene__func__GetRootGameObjects__UnityEngineGameObjectArray(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineSceneManagementScene__func__GetRootGameObjects__UnityEngineGameObjectArray(selfStructPointer, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.GameObject[] returnResult = new global::UnityEngine.GameObject[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.GameObject(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSceneManagementScene__func__GetRootGameObjects__SystemCollectionsGeneric_List_UnityEngineGameObject__SystemVoid(ref global::UnityEngine.SceneManagement.Scene selfStruct, global::System.Collections.Generic.List<global::UnityEngine.GameObject> rootGameObjectsList)
        {
            Span<global::UnityEngine.GameObject> rootGameObjects = CollectionsMarshal.AsSpan(rootGameObjectsList);
            int rootGameObjectsWasmLength = rootGameObjects.Length;
            long[] rootGameObjectsIds = new long[rootGameObjectsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < rootGameObjectsWasmLength; i++) rootGameObjectsIds[i] = (rootGameObjects[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* rootGameObjectsIdsPointer = rootGameObjectsIds)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineSceneManagementScene__func__GetRootGameObjects__SystemCollectionsGeneric_List_UnityEngineGameObject__SystemVoid(selfStructPointer, rootGameObjectsIdsPointer, rootGameObjectsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineSceneManagementScene__func__GetHashCode__SystemInt32(ref global::UnityEngine.SceneManagement.Scene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineSceneManagementScene__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSceneManagementScene__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.SceneManagement.Scene selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineSceneManagementScene__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__handle(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__get__path(void* selfStructPointer, void* pathPointer, void* pathWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__get__name(void* selfStructPointer, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__set__name(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__isLoaded(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__buildIndex(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__isDirty(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__rootCount(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__get__isSubScene(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__set__isSubScene(void* selfStructPointer, int isSubSceneConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__func__IsValid__SystemBoolean(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__func__GetRootGameObjects__UnityEngineGameObjectArray(void* selfStructPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSceneManagementScene__func__GetRootGameObjects__SystemCollectionsGeneric_List_UnityEngineGameObject__SystemVoid(void* selfStructPointer, void* rootGameObjectsIdsPointer, int rootGameObjectsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineSceneManagementScene__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        #endregion Imports
    }
}
