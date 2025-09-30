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
    public partial struct ScriptableCullingParameters
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_IsOrthographic;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.LODParameters m_LODParameters;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        internal unsafe fixed byte m_CullingPlanes[160];

        // [FieldOffset(192)] (implicit field offset from sequential layout kind)
        private int m_CullingPlaneCount;

        // [FieldOffset(196)] (implicit field offset from sequential layout kind)
        private uint m_CullingMask;

        // [FieldOffset(200)] (implicit field offset from sequential layout kind)
        private ulong m_SceneMask;

        // [FieldOffset(208)] (implicit field offset from sequential layout kind)
        internal unsafe fixed float m_LayerFarCullDistances[32];

        // [FieldOffset(336)] (implicit field offset from sequential layout kind)
        private int m_LayerCull;

        // [FieldOffset(340)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 m_CullingMatrix;

        // [FieldOffset(404)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Origin;

        // [FieldOffset(416)] (implicit field offset from sequential layout kind)
        private float m_ShadowDistance;

        // [FieldOffset(420)] (implicit field offset from sequential layout kind)
        private float m_ShadowNearPlaneOffset;

        // [FieldOffset(424)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.CullingOptions m_CullingOptions;

        // [FieldOffset(428)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;

        // [FieldOffset(432)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Rendering.CameraProperties m_CameraProperties;

        // [FieldOffset(1424)] (implicit field offset from sequential layout kind)
        private float m_AccurateOcclusionThreshold;

        // [FieldOffset(1428)] (implicit field offset from sequential layout kind)
        private int m_MaximumPortalCullingJobs;

        // [FieldOffset(1432)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 m_StereoViewMatrix;

        // [FieldOffset(1496)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Matrix4x4 m_StereoProjectionMatrix;

        // [FieldOffset(1560)] (implicit field offset from sequential layout kind)
        private float m_StereoSeparationDistance;

        // [FieldOffset(1564)] (implicit field offset from sequential layout kind)
        private int m_maximumVisibleLights;

        // [FieldOffset(1568)] (implicit field offset from sequential layout kind)
        private bool m_ConservativeEnclosingSphere;

        // [FieldOffset(1572)] (implicit field offset from sequential layout kind)
        private int m_NumIterationsEnclosingSphere;

        public int maximumVisibleLights 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__maximumVisibleLights(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__maximumVisibleLights(ref this, value);
        }

        public bool conservativeEnclosingSphere 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__conservativeEnclosingSphere(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__conservativeEnclosingSphere(ref this, value);
        }

        public int numIterationsEnclosingSphere 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__numIterationsEnclosingSphere(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__numIterationsEnclosingSphere(ref this, value);
        }

        public int cullingPlaneCount 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingPlaneCount(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__cullingPlaneCount(ref this, value);
        }

        public bool isOrthographic 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__isOrthographic(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__isOrthographic(ref this, value);
        }

        public global::UnityEngine.Rendering.LODParameters lodParameters 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__lodParameters(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__lodParameters(ref this, value);
        }

        public uint cullingMask 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingMask(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__cullingMask(ref this, value);
        }

        public global::UnityEngine.Matrix4x4 cullingMatrix 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingMatrix(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__cullingMatrix(ref this, value);
        }

        public global::UnityEngine.Vector3 origin 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__origin(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__origin(ref this, value);
        }

        public float shadowDistance 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__shadowDistance(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__shadowDistance(ref this, value);
        }

        public float shadowNearPlaneOffset 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__shadowNearPlaneOffset(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__shadowNearPlaneOffset(ref this, value);
        }

        public global::UnityEngine.Rendering.CullingOptions cullingOptions 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingOptions(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__cullingOptions(ref this, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeSortingCriteria reflectionProbeSortingCriteria 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__reflectionProbeSortingCriteria(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__reflectionProbeSortingCriteria(ref this, value);
        }

        public global::UnityEngine.Rendering.CameraProperties cameraProperties 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cameraProperties(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__cameraProperties(ref this, value);
        }

        public global::UnityEngine.Matrix4x4 stereoViewMatrix 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__stereoViewMatrix(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__stereoViewMatrix(ref this, value);
        }

        public global::UnityEngine.Matrix4x4 stereoProjectionMatrix 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__stereoProjectionMatrix(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__stereoProjectionMatrix(ref this, value);
        }

        public float stereoSeparationDistance 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__stereoSeparationDistance(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__stereoSeparationDistance(ref this, value);
        }

        public float accurateOcclusionThreshold 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__accurateOcclusionThreshold(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__accurateOcclusionThreshold(ref this, value);
        }

        public int maximumPortalCullingJobs 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__maximumPortalCullingJobs(ref this);
            set => internal_UnityEngineRenderingScriptableCullingParameters__set__maximumPortalCullingJobs(ref this, value);
        }

        public static int cullingJobsLowerLimit 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingJobsLowerLimit();
        }

        public static int cullingJobsUpperLimit 
        {
            get => internal_UnityEngineRenderingScriptableCullingParameters__get__cullingJobsUpperLimit();
        }

        public float GetLayerCullingDistance(int layerIndex)
        {
            return internal_UnityEngineRenderingScriptableCullingParameters__func__GetLayerCullingDistance__SystemInt32__SystemSingle(ref this, layerIndex);
        }

        public void SetLayerCullingDistance(int layerIndex, float distance)
        {
            internal_UnityEngineRenderingScriptableCullingParameters__func__SetLayerCullingDistance__SystemInt32__SystemSingle__SystemVoid(ref this, layerIndex, distance);
        }

        public global::UnityEngine.Plane GetCullingPlane(int index)
        {
            return internal_UnityEngineRenderingScriptableCullingParameters__func__GetCullingPlane__SystemInt32__UnityEnginePlane(ref this, index);
        }

        public void SetCullingPlane(int index, global::UnityEngine.Plane plane)
        {
            internal_UnityEngineRenderingScriptableCullingParameters__func__SetCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref this, index, plane);
        }

        public bool Equals(global::UnityEngine.Rendering.ScriptableCullingParameters other)
        {
            return internal_UnityEngineRenderingScriptableCullingParameters__func__Equals__UnityEngineRenderingScriptableCullingParameters__SystemBoolean(ref this, other);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineRenderingScriptableCullingParameters__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingScriptableCullingParameters__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__maximumVisibleLights(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__maximumVisibleLights(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__maximumVisibleLights(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int maximumVisibleLights)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__maximumVisibleLights(selfStructPointer, maximumVisibleLights);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingScriptableCullingParameters__get__conservativeEnclosingSphere(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__conservativeEnclosingSphere(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__conservativeEnclosingSphere(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, bool conservativeEnclosingSphere)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var conservativeEnclosingSphereConverted = Unsafe.As<bool, int>(ref conservativeEnclosingSphere);
            UnityEngineRenderingScriptableCullingParameters__set__conservativeEnclosingSphere(selfStructPointer, conservativeEnclosingSphereConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__numIterationsEnclosingSphere(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__numIterationsEnclosingSphere(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__numIterationsEnclosingSphere(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int numIterationsEnclosingSphere)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__numIterationsEnclosingSphere(selfStructPointer, numIterationsEnclosingSphere);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__cullingPlaneCount(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__cullingPlaneCount(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__cullingPlaneCount(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int cullingPlaneCount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__cullingPlaneCount(selfStructPointer, cullingPlaneCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingScriptableCullingParameters__get__isOrthographic(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__isOrthographic(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__isOrthographic(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, bool isOrthographic)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var isOrthographicConverted = Unsafe.As<bool, int>(ref isOrthographic);
            UnityEngineRenderingScriptableCullingParameters__set__isOrthographic(selfStructPointer, isOrthographicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LODParameters internal_UnityEngineRenderingScriptableCullingParameters__get__lodParameters(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Rendering.LODParameters lodParametersValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__lodParameters(selfStructPointer, Unsafe.AsPointer(ref lodParametersValue));
            global::UnityEngine.Rendering.LODParameters returnResult = lodParametersValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__lodParameters(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Rendering.LODParameters lodParameters)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__lodParameters(selfStructPointer, Unsafe.AsPointer(ref lodParameters));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineRenderingScriptableCullingParameters__get__cullingMask(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__cullingMask(selfStructPointer);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__cullingMask(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, uint cullingMask)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var cullingMaskConverted = Unsafe.As<uint, int>(ref cullingMask);
            UnityEngineRenderingScriptableCullingParameters__set__cullingMask(selfStructPointer, cullingMaskConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineRenderingScriptableCullingParameters__get__cullingMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 cullingMatrixValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__cullingMatrix(selfStructPointer, Unsafe.AsPointer(ref cullingMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = cullingMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__cullingMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Matrix4x4 cullingMatrix)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__cullingMatrix(selfStructPointer, Unsafe.AsPointer(ref cullingMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRenderingScriptableCullingParameters__get__origin(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 originValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__origin(selfStructPointer, Unsafe.AsPointer(ref originValue));
            global::UnityEngine.Vector3 returnResult = originValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__origin(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Vector3 origin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__origin(selfStructPointer, Unsafe.AsPointer(ref origin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingScriptableCullingParameters__get__shadowDistance(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__shadowDistance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__shadowDistance(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, float shadowDistance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__shadowDistance(selfStructPointer, shadowDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingScriptableCullingParameters__get__shadowNearPlaneOffset(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__shadowNearPlaneOffset(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__shadowNearPlaneOffset(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, float shadowNearPlaneOffset)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__shadowNearPlaneOffset(selfStructPointer, shadowNearPlaneOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.CullingOptions internal_UnityEngineRenderingScriptableCullingParameters__get__cullingOptions(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__cullingOptions(selfStructPointer);
            var returnResult = (global::UnityEngine.Rendering.CullingOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__cullingOptions(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Rendering.CullingOptions cullingOptions)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__cullingOptions(selfStructPointer, (int) cullingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeSortingCriteria internal_UnityEngineRenderingScriptableCullingParameters__get__reflectionProbeSortingCriteria(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__reflectionProbeSortingCriteria(selfStructPointer);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeSortingCriteria)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__reflectionProbeSortingCriteria(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Rendering.ReflectionProbeSortingCriteria reflectionProbeSortingCriteria)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__reflectionProbeSortingCriteria(selfStructPointer, (int) reflectionProbeSortingCriteria);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.CameraProperties internal_UnityEngineRenderingScriptableCullingParameters__get__cameraProperties(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Rendering.CameraProperties cameraPropertiesValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__cameraProperties(selfStructPointer, Unsafe.AsPointer(ref cameraPropertiesValue));
            global::UnityEngine.Rendering.CameraProperties returnResult = cameraPropertiesValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__cameraProperties(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Rendering.CameraProperties cameraProperties)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__cameraProperties(selfStructPointer, Unsafe.AsPointer(ref cameraProperties));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineRenderingScriptableCullingParameters__get__stereoViewMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 stereoViewMatrixValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__stereoViewMatrix(selfStructPointer, Unsafe.AsPointer(ref stereoViewMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = stereoViewMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__stereoViewMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Matrix4x4 stereoViewMatrix)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__stereoViewMatrix(selfStructPointer, Unsafe.AsPointer(ref stereoViewMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineRenderingScriptableCullingParameters__get__stereoProjectionMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 stereoProjectionMatrixValue = default;
            UnityEngineRenderingScriptableCullingParameters__get__stereoProjectionMatrix(selfStructPointer, Unsafe.AsPointer(ref stereoProjectionMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = stereoProjectionMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__stereoProjectionMatrix(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Matrix4x4 stereoProjectionMatrix)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__stereoProjectionMatrix(selfStructPointer, Unsafe.AsPointer(ref stereoProjectionMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingScriptableCullingParameters__get__stereoSeparationDistance(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__stereoSeparationDistance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__stereoSeparationDistance(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, float stereoSeparationDistance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__stereoSeparationDistance(selfStructPointer, stereoSeparationDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingScriptableCullingParameters__get__accurateOcclusionThreshold(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__accurateOcclusionThreshold(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__accurateOcclusionThreshold(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, float accurateOcclusionThreshold)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__accurateOcclusionThreshold(selfStructPointer, accurateOcclusionThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__maximumPortalCullingJobs(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__maximumPortalCullingJobs(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__set__maximumPortalCullingJobs(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int maximumPortalCullingJobs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__set__maximumPortalCullingJobs(selfStructPointer, maximumPortalCullingJobs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__cullingJobsLowerLimit()
        {
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__cullingJobsLowerLimit();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__get__cullingJobsUpperLimit()
        {
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__get__cullingJobsUpperLimit();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingScriptableCullingParameters__func__GetLayerCullingDistance__SystemInt32__SystemSingle(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int layerIndex)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__func__GetLayerCullingDistance__SystemInt32__SystemSingle(selfStructPointer, layerIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__func__SetLayerCullingDistance__SystemInt32__SystemSingle__SystemVoid(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int layerIndex, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__func__SetLayerCullingDistance__SystemInt32__SystemSingle__SystemVoid(selfStructPointer, layerIndex, distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Plane internal_UnityEngineRenderingScriptableCullingParameters__func__GetCullingPlane__SystemInt32__UnityEnginePlane(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int index)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Plane returnResultValue = default;
            UnityEngineRenderingScriptableCullingParameters__func__GetCullingPlane__SystemInt32__UnityEnginePlane(selfStructPointer, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Plane returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingScriptableCullingParameters__func__SetCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, int index, global::UnityEngine.Plane plane)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingScriptableCullingParameters__func__SetCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(selfStructPointer, index, Unsafe.AsPointer(ref plane));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingScriptableCullingParameters__func__Equals__UnityEngineRenderingScriptableCullingParameters__SystemBoolean(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, global::UnityEngine.Rendering.ScriptableCullingParameters other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__func__Equals__UnityEngineRenderingScriptableCullingParameters__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingScriptableCullingParameters__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingScriptableCullingParameters__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.ScriptableCullingParameters selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingScriptableCullingParameters__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__maximumVisibleLights(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__maximumVisibleLights(void* selfStructPointer, int maximumVisibleLights);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__conservativeEnclosingSphere(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__conservativeEnclosingSphere(void* selfStructPointer, int conservativeEnclosingSphereConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__numIterationsEnclosingSphere(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__numIterationsEnclosingSphere(void* selfStructPointer, int numIterationsEnclosingSphere);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__cullingPlaneCount(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__cullingPlaneCount(void* selfStructPointer, int cullingPlaneCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__isOrthographic(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__isOrthographic(void* selfStructPointer, int isOrthographicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__lodParameters(void* selfStructPointer, void* lodParametersPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__lodParameters(void* selfStructPointer, void* lodParametersPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__cullingMask(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__cullingMask(void* selfStructPointer, int cullingMaskConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__cullingMatrix(void* selfStructPointer, void* cullingMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__cullingMatrix(void* selfStructPointer, void* cullingMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingScriptableCullingParameters__get__shadowDistance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__shadowDistance(void* selfStructPointer, float shadowDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingScriptableCullingParameters__get__shadowNearPlaneOffset(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__shadowNearPlaneOffset(void* selfStructPointer, float shadowNearPlaneOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__cullingOptions(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__cullingOptions(void* selfStructPointer, int cullingOptionsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__reflectionProbeSortingCriteria(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__reflectionProbeSortingCriteria(void* selfStructPointer, int reflectionProbeSortingCriteriaUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__cameraProperties(void* selfStructPointer, void* cameraPropertiesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__cameraProperties(void* selfStructPointer, void* cameraPropertiesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__stereoViewMatrix(void* selfStructPointer, void* stereoViewMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__stereoViewMatrix(void* selfStructPointer, void* stereoViewMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__get__stereoProjectionMatrix(void* selfStructPointer, void* stereoProjectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__stereoProjectionMatrix(void* selfStructPointer, void* stereoProjectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingScriptableCullingParameters__get__stereoSeparationDistance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__stereoSeparationDistance(void* selfStructPointer, float stereoSeparationDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingScriptableCullingParameters__get__accurateOcclusionThreshold(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__accurateOcclusionThreshold(void* selfStructPointer, float accurateOcclusionThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__get__maximumPortalCullingJobs(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__set__maximumPortalCullingJobs(void* selfStructPointer, int maximumPortalCullingJobs);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingScriptableCullingParameters__get__cullingJobsLowerLimit();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingScriptableCullingParameters__get__cullingJobsUpperLimit();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRenderingScriptableCullingParameters__func__GetLayerCullingDistance__SystemInt32__SystemSingle(void* selfStructPointer, int layerIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__func__SetLayerCullingDistance__SystemInt32__SystemSingle__SystemVoid(void* selfStructPointer, int layerIndex, float distance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__func__GetCullingPlane__SystemInt32__UnityEnginePlane(void* selfStructPointer, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingScriptableCullingParameters__func__SetCullingPlane__SystemInt32__UnityEnginePlane__SystemVoid(void* selfStructPointer, int index, void* planePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__func__Equals__UnityEngineRenderingScriptableCullingParameters__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingScriptableCullingParameters__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
