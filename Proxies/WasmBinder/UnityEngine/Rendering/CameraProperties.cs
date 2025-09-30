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
    public partial struct CameraProperties
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rect screenRect;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 viewDir;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private float projectionNear;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private float projectionFar;

        // [FieldOffset(36)] (implicit field offset from sequential layout kind)
        private float cameraNear;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        private float cameraFar;

        // [FieldOffset(44)] (implicit field offset from sequential layout kind)
        private float cameraAspect;

        // [FieldOffset(48)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 cameraToWorld;

        // [FieldOffset(112)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 actualWorldToClip;

        // [FieldOffset(176)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 cameraClipToWorld;

        // [FieldOffset(240)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 cameraWorldToClip;

        // [FieldOffset(304)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 implicitProjection;

        // [FieldOffset(368)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 stereoWorldToClipLeft;

        // [FieldOffset(432)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 stereoWorldToClipRight;

        // [FieldOffset(496)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 worldToCamera;

        // [FieldOffset(560)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 up;

        // [FieldOffset(572)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 right;

        // [FieldOffset(584)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 transformDirection;

        // [FieldOffset(596)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 cameraEuler;

        // [FieldOffset(608)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 velocity;

        // [FieldOffset(620)] (implicit field offset from sequential layout kind)
        private float farPlaneWorldSpaceLength;

        // [FieldOffset(624)] (implicit field offset from sequential layout kind)
        private uint rendererCount;

        // [FieldOffset(628)] (implicit field offset from sequential layout kind)
        internal unsafe fixed byte m_ShadowCullPlanes[96];

        // [FieldOffset(724)] (implicit field offset from sequential layout kind)
        internal unsafe fixed byte m_CameraCullPlanes[96];

        // [FieldOffset(820)] (implicit field offset from sequential layout kind)
        private float baseFarDistance;

        // [FieldOffset(824)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 shadowCullCenter;

        // [FieldOffset(836)] (implicit field offset from sequential layout kind)
        internal unsafe fixed float layerCullDistances[32];

        // [FieldOffset(964)] (implicit field offset from sequential layout kind)
        private int layerCullSpherical;

        // [FieldOffset(968)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.CoreCameraValues coreCameraValues;

        // [FieldOffset(980)] (implicit field offset from sequential layout kind)
        private uint cameraType;

        // [FieldOffset(984)] (implicit field offset from sequential layout kind)
        private int projectionIsOblique;

        // [FieldOffset(988)] (implicit field offset from sequential layout kind)
        private int isImplicitProjectionMatrix;

        public global::UnityEngine.Plane GetShadowCullingPlane(int index)
        {
            return internal_UnityEngineRenderingCameraProperties__func__GetShadowCullingPlane__SystemInt32__UnityEnginePlane(ref this, index);
        }

        public void SetShadowCullingPlane(int index, global::UnityEngine.Plane plane)
        {
            internal_UnityEngineRenderingCameraProperties__func__SetShadowCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref this, index, plane);
        }

        public global::UnityEngine.Plane GetCameraCullingPlane(int index)
        {
            return internal_UnityEngineRenderingCameraProperties__func__GetCameraCullingPlane__SystemInt32__UnityEnginePlane(ref this, index);
        }

        public void SetCameraCullingPlane(int index, global::UnityEngine.Plane plane)
        {
            internal_UnityEngineRenderingCameraProperties__func__SetCameraCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref this, index, plane);
        }

        public bool Equals(global::UnityEngine.Rendering.CameraProperties other)
        {
            return internal_UnityEngineRenderingCameraProperties__func__Equals__UnityEngineRenderingCameraProperties__SystemBoolean(ref this, other);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineRenderingCameraProperties__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingCameraProperties__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Plane internal_UnityEngineRenderingCameraProperties__func__GetShadowCullingPlane__SystemInt32__UnityEnginePlane(ref global::UnityEngine.Rendering.CameraProperties selfStruct, int index)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Plane returnResultValue = default;
            UnityEngineRenderingCameraProperties__func__GetShadowCullingPlane__SystemInt32__UnityEnginePlane(selfStructPointer, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Plane returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCameraProperties__func__SetShadowCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref global::UnityEngine.Rendering.CameraProperties selfStruct, int index, global::UnityEngine.Plane plane)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingCameraProperties__func__SetShadowCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(selfStructPointer, index, Unsafe.AsPointer(ref plane));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Plane internal_UnityEngineRenderingCameraProperties__func__GetCameraCullingPlane__SystemInt32__UnityEnginePlane(ref global::UnityEngine.Rendering.CameraProperties selfStruct, int index)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Plane returnResultValue = default;
            UnityEngineRenderingCameraProperties__func__GetCameraCullingPlane__SystemInt32__UnityEnginePlane(selfStructPointer, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Plane returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCameraProperties__func__SetCameraCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref global::UnityEngine.Rendering.CameraProperties selfStruct, int index, global::UnityEngine.Plane plane)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingCameraProperties__func__SetCameraCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(selfStructPointer, index, Unsafe.AsPointer(ref plane));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingCameraProperties__func__Equals__UnityEngineRenderingCameraProperties__SystemBoolean(ref global::UnityEngine.Rendering.CameraProperties selfStruct, global::UnityEngine.Rendering.CameraProperties other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingCameraProperties__func__Equals__UnityEngineRenderingCameraProperties__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingCameraProperties__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.CameraProperties selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingCameraProperties__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingCameraProperties__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.CameraProperties selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingCameraProperties__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCameraProperties__func__GetShadowCullingPlane__SystemInt32__UnityEnginePlane(void* selfStructPointer, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCameraProperties__func__SetShadowCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(void* selfStructPointer, int index, void* planePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCameraProperties__func__GetCameraCullingPlane__SystemInt32__UnityEnginePlane(void* selfStructPointer, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCameraProperties__func__SetCameraCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(void* selfStructPointer, int index, void* planePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingCameraProperties__func__Equals__UnityEngineRenderingCameraProperties__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingCameraProperties__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingCameraProperties__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
