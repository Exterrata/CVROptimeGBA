//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct LODParameters
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_IsOrthographic;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_CameraPosition;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private float m_FieldOfView;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private float m_OrthoSize;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private int m_CameraPixelHeight;

        public bool isOrthographic 
        {
            get => internal_UnityEngineRenderingLODParameters__get__isOrthographic(ref this);
            set => internal_UnityEngineRenderingLODParameters__set__isOrthographic(ref this, value);
        }

        public global::UnityEngine.Vector3 cameraPosition 
        {
            get => internal_UnityEngineRenderingLODParameters__get__cameraPosition(ref this);
            set => internal_UnityEngineRenderingLODParameters__set__cameraPosition(ref this, value);
        }

        public float fieldOfView 
        {
            get => internal_UnityEngineRenderingLODParameters__get__fieldOfView(ref this);
            set => internal_UnityEngineRenderingLODParameters__set__fieldOfView(ref this, value);
        }

        public float orthoSize 
        {
            get => internal_UnityEngineRenderingLODParameters__get__orthoSize(ref this);
            set => internal_UnityEngineRenderingLODParameters__set__orthoSize(ref this, value);
        }

        public int cameraPixelHeight 
        {
            get => internal_UnityEngineRenderingLODParameters__get__cameraPixelHeight(ref this);
            set => internal_UnityEngineRenderingLODParameters__set__cameraPixelHeight(ref this, value);
        }

        public bool Equals(global::UnityEngine.Rendering.LODParameters other)
        {
            return internal_UnityEngineRenderingLODParameters__func__Equals__UnityEngineRenderingLODParameters__SystemBoolean(ref this, other);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineRenderingLODParameters__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingLODParameters__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLODParameters__get__isOrthographic(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__get__isOrthographic(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingLODParameters__set__isOrthographic(ref global::UnityEngine.Rendering.LODParameters selfStruct, bool isOrthographic)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var isOrthographicConverted = Unsafe.As<bool, int>(ref isOrthographic);
            UnityEngineRenderingLODParameters__set__isOrthographic(selfStructPointer, isOrthographicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRenderingLODParameters__get__cameraPosition(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 cameraPositionValue = default;
            UnityEngineRenderingLODParameters__get__cameraPosition(selfStructPointer, Unsafe.AsPointer(ref cameraPositionValue));
            global::UnityEngine.Vector3 returnResult = cameraPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingLODParameters__set__cameraPosition(ref global::UnityEngine.Rendering.LODParameters selfStruct, global::UnityEngine.Vector3 cameraPosition)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingLODParameters__set__cameraPosition(selfStructPointer, Unsafe.AsPointer(ref cameraPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingLODParameters__get__fieldOfView(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__get__fieldOfView(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingLODParameters__set__fieldOfView(ref global::UnityEngine.Rendering.LODParameters selfStruct, float fieldOfView)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingLODParameters__set__fieldOfView(selfStructPointer, fieldOfView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingLODParameters__get__orthoSize(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__get__orthoSize(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingLODParameters__set__orthoSize(ref global::UnityEngine.Rendering.LODParameters selfStruct, float orthoSize)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingLODParameters__set__orthoSize(selfStructPointer, orthoSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingLODParameters__get__cameraPixelHeight(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__get__cameraPixelHeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingLODParameters__set__cameraPixelHeight(ref global::UnityEngine.Rendering.LODParameters selfStruct, int cameraPixelHeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingLODParameters__set__cameraPixelHeight(selfStructPointer, cameraPixelHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLODParameters__func__Equals__UnityEngineRenderingLODParameters__SystemBoolean(ref global::UnityEngine.Rendering.LODParameters selfStruct, global::UnityEngine.Rendering.LODParameters other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__func__Equals__UnityEngineRenderingLODParameters__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLODParameters__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.LODParameters selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingLODParameters__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingLODParameters__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.LODParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLODParameters__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLODParameters__get__isOrthographic(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__set__isOrthographic(void* selfStructPointer, int isOrthographicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__get__cameraPosition(void* selfStructPointer, void* cameraPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__set__cameraPosition(void* selfStructPointer, void* cameraPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingLODParameters__get__fieldOfView(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__set__fieldOfView(void* selfStructPointer, float fieldOfView);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingLODParameters__get__orthoSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__set__orthoSize(void* selfStructPointer, float orthoSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLODParameters__get__cameraPixelHeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLODParameters__set__cameraPixelHeight(void* selfStructPointer, int cameraPixelHeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLODParameters__func__Equals__UnityEngineRenderingLODParameters__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLODParameters__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLODParameters__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
