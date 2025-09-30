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
    public partial struct NavMeshBuildSource
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 m_Transform;

        // [FieldOffset(64)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Size;

        // [FieldOffset(76)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.AI.NavMeshBuildSourceShape m_Shape;

        // [FieldOffset(80)] (implicit field offset from sequential layout kind)
        private int m_Area;

        // [FieldOffset(84)] (implicit field offset from sequential layout kind)
        private int m_InstanceID;

        // [FieldOffset(88)] (implicit field offset from sequential layout kind)
        private int m_ComponentID;

        public global::UnityEngine.Matrix4x4 transform 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__transform(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__transform(ref this, value);
        }

        public global::UnityEngine.Vector3 size 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__size(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__size(ref this, value);
        }

        public global::UnityEngine.AI.NavMeshBuildSourceShape shape 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__shape(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__shape(ref this, value);
        }

        public int area 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__area(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__area(ref this, value);
        }

        public global::UnityEngine.Object sourceObject 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__sourceObject(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__sourceObject(ref this, value);
        }

        public global::UnityEngine.Component component 
        {
            get => internal_UnityEngineAINavMeshBuildSource__get__component(ref this);
            set => internal_UnityEngineAINavMeshBuildSource__set__component(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineAINavMeshBuildSource__get__transform(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 transformValue = default;
            UnityEngineAINavMeshBuildSource__get__transform(selfStructPointer, Unsafe.AsPointer(ref transformValue));
            global::UnityEngine.Matrix4x4 returnResult = transformValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__transform(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, global::UnityEngine.Matrix4x4 transform)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__transform(selfStructPointer, Unsafe.AsPointer(ref transform));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshBuildSource__get__size(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 sizeValue = default;
            UnityEngineAINavMeshBuildSource__get__size(selfStructPointer, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector3 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__size(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, global::UnityEngine.Vector3 size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__size(selfStructPointer, Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshBuildSourceShape internal_UnityEngineAINavMeshBuildSource__get__shape(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSource__get__shape(selfStructPointer);
            var returnResult = (global::UnityEngine.AI.NavMeshBuildSourceShape)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__shape(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, global::UnityEngine.AI.NavMeshBuildSourceShape shape)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__shape(selfStructPointer, (int) shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshBuildSource__get__area(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSource__get__area(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__area(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, int area)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__area(selfStructPointer, area);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineAINavMeshBuildSource__get__sourceObject(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSource__get__sourceObject(selfStructPointer);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__sourceObject(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, global::UnityEngine.Object sourceObject)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__sourceObject(selfStructPointer, sourceObject.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineAINavMeshBuildSource__get__component(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshBuildSource__get__component(selfStructPointer);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshBuildSource__set__component(ref global::UnityEngine.AI.NavMeshBuildSource selfStruct, global::UnityEngine.Component component)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshBuildSource__set__component(selfStructPointer, component.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__get__transform(void* selfStructPointer, void* transformPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__transform(void* selfStructPointer, void* transformPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__get__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSource__get__shape(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__shape(void* selfStructPointer, int shapeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshBuildSource__get__area(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__area(void* selfStructPointer, int area);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAINavMeshBuildSource__get__sourceObject(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__sourceObject(void* selfStructPointer, long sourceObjectObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAINavMeshBuildSource__get__component(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshBuildSource__set__component(void* selfStructPointer, long componentObjectId);

        #endregion Imports
    }
}
