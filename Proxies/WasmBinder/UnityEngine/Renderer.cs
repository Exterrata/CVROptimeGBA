//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine
{

    public partial class Renderer(long id) : Component(id)
    {

        #region Implementation

        public global::UnityEngine.Bounds bounds 
        {
            get => internal_UnityEngineRenderer__get__bounds(WrappedId);
            set => internal_UnityEngineRenderer__set__bounds(WrappedId, value);
        }

        public global::UnityEngine.Bounds localBounds 
        {
            get => internal_UnityEngineRenderer__get__localBounds(WrappedId);
            set => internal_UnityEngineRenderer__set__localBounds(WrappedId, value);
        }

        public bool enabled 
        {
            get => internal_UnityEngineRenderer__get__enabled(WrappedId);
            set => internal_UnityEngineRenderer__set__enabled(WrappedId, value);
        }

        public bool isVisible 
        {
            get => internal_UnityEngineRenderer__get__isVisible(WrappedId);
        }

        public global::UnityEngine.Rendering.ShadowCastingMode shadowCastingMode 
        {
            get => internal_UnityEngineRenderer__get__shadowCastingMode(WrappedId);
            set => internal_UnityEngineRenderer__set__shadowCastingMode(WrappedId, value);
        }

        public bool receiveShadows 
        {
            get => internal_UnityEngineRenderer__get__receiveShadows(WrappedId);
            set => internal_UnityEngineRenderer__set__receiveShadows(WrappedId, value);
        }

        public bool forceRenderingOff 
        {
            get => internal_UnityEngineRenderer__get__forceRenderingOff(WrappedId);
            set => internal_UnityEngineRenderer__set__forceRenderingOff(WrappedId, value);
        }

        public bool staticShadowCaster 
        {
            get => internal_UnityEngineRenderer__get__staticShadowCaster(WrappedId);
            set => internal_UnityEngineRenderer__set__staticShadowCaster(WrappedId, value);
        }

        public global::UnityEngine.MotionVectorGenerationMode motionVectorGenerationMode 
        {
            get => internal_UnityEngineRenderer__get__motionVectorGenerationMode(WrappedId);
            set => internal_UnityEngineRenderer__set__motionVectorGenerationMode(WrappedId, value);
        }

        public global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage 
        {
            get => internal_UnityEngineRenderer__get__lightProbeUsage(WrappedId);
            set => internal_UnityEngineRenderer__set__lightProbeUsage(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage 
        {
            get => internal_UnityEngineRenderer__get__reflectionProbeUsage(WrappedId);
            set => internal_UnityEngineRenderer__set__reflectionProbeUsage(WrappedId, value);
        }

        public uint renderingLayerMask 
        {
            get => internal_UnityEngineRenderer__get__renderingLayerMask(WrappedId);
            set => internal_UnityEngineRenderer__set__renderingLayerMask(WrappedId, value);
        }

        public int rendererPriority 
        {
            get => internal_UnityEngineRenderer__get__rendererPriority(WrappedId);
            set => internal_UnityEngineRenderer__set__rendererPriority(WrappedId, value);
        }

        public global::UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode 
        {
            get => internal_UnityEngineRenderer__get__rayTracingMode(WrappedId);
            set => internal_UnityEngineRenderer__set__rayTracingMode(WrappedId, value);
        }

        public string sortingLayerName 
        {
            get => internal_UnityEngineRenderer__get__sortingLayerName(WrappedId);
            set => internal_UnityEngineRenderer__set__sortingLayerName(WrappedId, value);
        }

        public int sortingLayerID 
        {
            get => internal_UnityEngineRenderer__get__sortingLayerID(WrappedId);
            set => internal_UnityEngineRenderer__set__sortingLayerID(WrappedId, value);
        }

        public int sortingOrder 
        {
            get => internal_UnityEngineRenderer__get__sortingOrder(WrappedId);
            set => internal_UnityEngineRenderer__set__sortingOrder(WrappedId, value);
        }

        public bool allowOcclusionWhenDynamic 
        {
            get => internal_UnityEngineRenderer__get__allowOcclusionWhenDynamic(WrappedId);
            set => internal_UnityEngineRenderer__set__allowOcclusionWhenDynamic(WrappedId, value);
        }

        public bool isPartOfStaticBatch 
        {
            get => internal_UnityEngineRenderer__get__isPartOfStaticBatch(WrappedId);
        }

        public global::UnityEngine.Matrix4x4 worldToLocalMatrix 
        {
            get => internal_UnityEngineRenderer__get__worldToLocalMatrix(WrappedId);
        }

        public global::UnityEngine.Matrix4x4 localToWorldMatrix 
        {
            get => internal_UnityEngineRenderer__get__localToWorldMatrix(WrappedId);
        }

        public global::UnityEngine.GameObject lightProbeProxyVolumeOverride 
        {
            get => internal_UnityEngineRenderer__get__lightProbeProxyVolumeOverride(WrappedId);
            set => internal_UnityEngineRenderer__set__lightProbeProxyVolumeOverride(WrappedId, value);
        }

        public global::UnityEngine.Transform probeAnchor 
        {
            get => internal_UnityEngineRenderer__get__probeAnchor(WrappedId);
            set => internal_UnityEngineRenderer__set__probeAnchor(WrappedId, value);
        }

        public int lightmapIndex 
        {
            get => internal_UnityEngineRenderer__get__lightmapIndex(WrappedId);
            set => internal_UnityEngineRenderer__set__lightmapIndex(WrappedId, value);
        }

        public int realtimeLightmapIndex 
        {
            get => internal_UnityEngineRenderer__get__realtimeLightmapIndex(WrappedId);
            set => internal_UnityEngineRenderer__set__realtimeLightmapIndex(WrappedId, value);
        }

        public global::UnityEngine.Vector4 lightmapScaleOffset 
        {
            get => internal_UnityEngineRenderer__get__lightmapScaleOffset(WrappedId);
            set => internal_UnityEngineRenderer__set__lightmapScaleOffset(WrappedId, value);
        }

        public global::UnityEngine.Vector4 realtimeLightmapScaleOffset 
        {
            get => internal_UnityEngineRenderer__get__realtimeLightmapScaleOffset(WrappedId);
            set => internal_UnityEngineRenderer__set__realtimeLightmapScaleOffset(WrappedId, value);
        }

        public global::UnityEngine.Material[] materials 
        {
            get => internal_UnityEngineRenderer__get__materials(WrappedId);
            set => internal_UnityEngineRenderer__set__materials(WrappedId, value);
        }

        public global::UnityEngine.Material material 
        {
            get => internal_UnityEngineRenderer__get__material(WrappedId);
            set => internal_UnityEngineRenderer__set__material(WrappedId, value);
        }

        public global::UnityEngine.Material sharedMaterial 
        {
            get => internal_UnityEngineRenderer__get__sharedMaterial(WrappedId);
            set => internal_UnityEngineRenderer__set__sharedMaterial(WrappedId, value);
        }

        public global::UnityEngine.Material[] sharedMaterials 
        {
            get => internal_UnityEngineRenderer__get__sharedMaterials(WrappedId);
            set => internal_UnityEngineRenderer__set__sharedMaterials(WrappedId, value);
        }

        public void ResetBounds()
        {
            internal_UnityEngineRenderer__func__ResetBounds__SystemVoid(WrappedId);
        }

        public void ResetLocalBounds()
        {
            internal_UnityEngineRenderer__func__ResetLocalBounds__SystemVoid(WrappedId);
        }

        public bool HasPropertyBlock()
        {
            return internal_UnityEngineRenderer__func__HasPropertyBlock__SystemBoolean(WrappedId);
        }

        public void SetPropertyBlock(global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, properties);
        }

        public void SetPropertyBlock(global::UnityEngine.MaterialPropertyBlock properties, int materialIndex)
        {
            internal_UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(WrappedId, properties, materialIndex);
        }

        public void GetPropertyBlock(global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, properties);
        }

        public void GetPropertyBlock(global::UnityEngine.MaterialPropertyBlock properties, int materialIndex)
        {
            internal_UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(WrappedId, properties, materialIndex);
        }

        public void GetMaterials(global::System.Collections.Generic.List<global::UnityEngine.Material> m)
        {
            internal_UnityEngineRenderer__func__GetMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(WrappedId, m);
        }

        public void GetSharedMaterials(global::System.Collections.Generic.List<global::UnityEngine.Material> m)
        {
            internal_UnityEngineRenderer__func__GetSharedMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(WrappedId, m);
        }

        public void GetClosestReflectionProbes(global::System.Collections.Generic.List<global::UnityEngine.Rendering.ReflectionProbeBlendInfo> result)
        {
            internal_UnityEngineRenderer__func__GetClosestReflectionProbes__SystemCollectionsGeneric_List_UnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(WrappedId, result);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineRenderer__get__bounds(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsValue = default;
            UnityEngineRenderer__get__bounds(selfObjectId, Unsafe.AsPointer(ref boundsValue));
            global::UnityEngine.Bounds returnResult = boundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__bounds(long selfObjectId, global::UnityEngine.Bounds bounds)
        {
            UnityEngineRenderer__set__bounds(selfObjectId, Unsafe.AsPointer(ref bounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineRenderer__get__localBounds(long selfObjectId)
        {
            global::UnityEngine.Bounds localBoundsValue = default;
            UnityEngineRenderer__get__localBounds(selfObjectId, Unsafe.AsPointer(ref localBoundsValue));
            global::UnityEngine.Bounds returnResult = localBoundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__localBounds(long selfObjectId, global::UnityEngine.Bounds localBounds)
        {
            UnityEngineRenderer__set__localBounds(selfObjectId, Unsafe.AsPointer(ref localBounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__enabled(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__enabled(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__enabled(long selfObjectId, bool enabled)
        {
            var enabledConverted = Unsafe.As<bool, int>(ref enabled);
            UnityEngineRenderer__set__enabled(selfObjectId, enabledConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__isVisible(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__isVisible(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShadowCastingMode internal_UnityEngineRenderer__get__shadowCastingMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__shadowCastingMode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ShadowCastingMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__shadowCastingMode(long selfObjectId, global::UnityEngine.Rendering.ShadowCastingMode shadowCastingMode)
        {
            UnityEngineRenderer__set__shadowCastingMode(selfObjectId, (int) shadowCastingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__receiveShadows(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__receiveShadows(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__receiveShadows(long selfObjectId, bool receiveShadows)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineRenderer__set__receiveShadows(selfObjectId, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__forceRenderingOff(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__forceRenderingOff(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__forceRenderingOff(long selfObjectId, bool forceRenderingOff)
        {
            var forceRenderingOffConverted = Unsafe.As<bool, int>(ref forceRenderingOff);
            UnityEngineRenderer__set__forceRenderingOff(selfObjectId, forceRenderingOffConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__staticShadowCaster(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__staticShadowCaster(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__staticShadowCaster(long selfObjectId, bool staticShadowCaster)
        {
            var staticShadowCasterConverted = Unsafe.As<bool, int>(ref staticShadowCaster);
            UnityEngineRenderer__set__staticShadowCaster(selfObjectId, staticShadowCasterConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MotionVectorGenerationMode internal_UnityEngineRenderer__get__motionVectorGenerationMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__motionVectorGenerationMode(selfObjectId);
            var returnResult = (global::UnityEngine.MotionVectorGenerationMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__motionVectorGenerationMode(long selfObjectId, global::UnityEngine.MotionVectorGenerationMode motionVectorGenerationMode)
        {
            UnityEngineRenderer__set__motionVectorGenerationMode(selfObjectId, (int) motionVectorGenerationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LightProbeUsage internal_UnityEngineRenderer__get__lightProbeUsage(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__lightProbeUsage(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.LightProbeUsage)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__lightProbeUsage(long selfObjectId, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            UnityEngineRenderer__set__lightProbeUsage(selfObjectId, (int) lightProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeUsage internal_UnityEngineRenderer__get__reflectionProbeUsage(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__reflectionProbeUsage(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeUsage)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__reflectionProbeUsage(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage)
        {
            UnityEngineRenderer__set__reflectionProbeUsage(selfObjectId, (int) reflectionProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineRenderer__get__renderingLayerMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__renderingLayerMask(selfObjectId);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__renderingLayerMask(long selfObjectId, uint renderingLayerMask)
        {
            var renderingLayerMaskConverted = Unsafe.As<uint, int>(ref renderingLayerMask);
            UnityEngineRenderer__set__renderingLayerMask(selfObjectId, renderingLayerMaskConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderer__get__rendererPriority(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__rendererPriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__rendererPriority(long selfObjectId, int rendererPriority)
        {
            UnityEngineRenderer__set__rendererPriority(selfObjectId, rendererPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.RayTracingMode internal_UnityEngineRenderer__get__rayTracingMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__rayTracingMode(selfObjectId);
            var returnResult = (global::UnityEngine.Experimental.Rendering.RayTracingMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__rayTracingMode(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode)
        {
            UnityEngineRenderer__set__rayTracingMode(selfObjectId, (int) rayTracingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderer__get__sortingLayerName(long selfObjectId)
        {
            char* sortingLayerNamePointer = default;
            int sortingLayerNameWasmLength = default;
            UnityEngineRenderer__get__sortingLayerName(selfObjectId, &sortingLayerNamePointer, &sortingLayerNameWasmLength);
            string returnResult = new(sortingLayerNamePointer, 0, sortingLayerNameWasmLength);
            Marshal.FreeHGlobal((IntPtr)sortingLayerNamePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__sortingLayerName(long selfObjectId, string sortingLayerName)
        {
            fixed (char* sortingLayerNamePointer = sortingLayerName)
            {
                UnityEngineRenderer__set__sortingLayerName(selfObjectId, sortingLayerNamePointer, sortingLayerName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderer__get__sortingLayerID(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__sortingLayerID(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__sortingLayerID(long selfObjectId, int sortingLayerID)
        {
            UnityEngineRenderer__set__sortingLayerID(selfObjectId, sortingLayerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderer__get__sortingOrder(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__sortingOrder(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__sortingOrder(long selfObjectId, int sortingOrder)
        {
            UnityEngineRenderer__set__sortingOrder(selfObjectId, sortingOrder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__allowOcclusionWhenDynamic(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__allowOcclusionWhenDynamic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__allowOcclusionWhenDynamic(long selfObjectId, bool allowOcclusionWhenDynamic)
        {
            var allowOcclusionWhenDynamicConverted = Unsafe.As<bool, int>(ref allowOcclusionWhenDynamic);
            UnityEngineRenderer__set__allowOcclusionWhenDynamic(selfObjectId, allowOcclusionWhenDynamicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__get__isPartOfStaticBatch(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__isPartOfStaticBatch(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineRenderer__get__worldToLocalMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 worldToLocalMatrixValue = default;
            UnityEngineRenderer__get__worldToLocalMatrix(selfObjectId, Unsafe.AsPointer(ref worldToLocalMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = worldToLocalMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineRenderer__get__localToWorldMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 localToWorldMatrixValue = default;
            UnityEngineRenderer__get__localToWorldMatrix(selfObjectId, Unsafe.AsPointer(ref localToWorldMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = localToWorldMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineRenderer__get__lightProbeProxyVolumeOverride(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__lightProbeProxyVolumeOverride(selfObjectId);
            var returnResult = new global::UnityEngine.GameObject(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__lightProbeProxyVolumeOverride(long selfObjectId, global::UnityEngine.GameObject lightProbeProxyVolumeOverride)
        {
            UnityEngineRenderer__set__lightProbeProxyVolumeOverride(selfObjectId, lightProbeProxyVolumeOverride.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineRenderer__get__probeAnchor(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__probeAnchor(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__probeAnchor(long selfObjectId, global::UnityEngine.Transform probeAnchor)
        {
            UnityEngineRenderer__set__probeAnchor(selfObjectId, probeAnchor.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderer__get__lightmapIndex(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__lightmapIndex(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__lightmapIndex(long selfObjectId, int lightmapIndex)
        {
            UnityEngineRenderer__set__lightmapIndex(selfObjectId, lightmapIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderer__get__realtimeLightmapIndex(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__realtimeLightmapIndex(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__realtimeLightmapIndex(long selfObjectId, int realtimeLightmapIndex)
        {
            UnityEngineRenderer__set__realtimeLightmapIndex(selfObjectId, realtimeLightmapIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineRenderer__get__lightmapScaleOffset(long selfObjectId)
        {
            global::UnityEngine.Vector4 lightmapScaleOffsetValue = default;
            UnityEngineRenderer__get__lightmapScaleOffset(selfObjectId, Unsafe.AsPointer(ref lightmapScaleOffsetValue));
            global::UnityEngine.Vector4 returnResult = lightmapScaleOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__lightmapScaleOffset(long selfObjectId, global::UnityEngine.Vector4 lightmapScaleOffset)
        {
            UnityEngineRenderer__set__lightmapScaleOffset(selfObjectId, Unsafe.AsPointer(ref lightmapScaleOffset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineRenderer__get__realtimeLightmapScaleOffset(long selfObjectId)
        {
            global::UnityEngine.Vector4 realtimeLightmapScaleOffsetValue = default;
            UnityEngineRenderer__get__realtimeLightmapScaleOffset(selfObjectId, Unsafe.AsPointer(ref realtimeLightmapScaleOffsetValue));
            global::UnityEngine.Vector4 returnResult = realtimeLightmapScaleOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__realtimeLightmapScaleOffset(long selfObjectId, global::UnityEngine.Vector4 realtimeLightmapScaleOffset)
        {
            UnityEngineRenderer__set__realtimeLightmapScaleOffset(selfObjectId, Unsafe.AsPointer(ref realtimeLightmapScaleOffset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material[] internal_UnityEngineRenderer__get__materials(long selfObjectId)
        {
            long* materialsIdsPointer = default;
            int materialsWasmLength = default;
            UnityEngineRenderer__get__materials(selfObjectId, &materialsIdsPointer, &materialsWasmLength);
            global::UnityEngine.Material[] returnResult = new global::UnityEngine.Material[materialsWasmLength];
            for (int i = 0; i < materialsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Material(materialsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)materialsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__materials(long selfObjectId, global::UnityEngine.Material[] materials)
        {
            int materialsWasmLength = materials.Length;
            long[] materialsIds = new long[materialsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < materialsWasmLength; i++) materialsIds[i] = (materials[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* materialsIdsPointer = materialsIds)
            {
                UnityEngineRenderer__set__materials(selfObjectId, materialsIdsPointer, materialsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineRenderer__get__material(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__material(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__material(long selfObjectId, global::UnityEngine.Material material)
        {
            UnityEngineRenderer__set__material(selfObjectId, material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineRenderer__get__sharedMaterial(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__get__sharedMaterial(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__sharedMaterial(long selfObjectId, global::UnityEngine.Material sharedMaterial)
        {
            UnityEngineRenderer__set__sharedMaterial(selfObjectId, sharedMaterial.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material[] internal_UnityEngineRenderer__get__sharedMaterials(long selfObjectId)
        {
            long* sharedMaterialsIdsPointer = default;
            int sharedMaterialsWasmLength = default;
            UnityEngineRenderer__get__sharedMaterials(selfObjectId, &sharedMaterialsIdsPointer, &sharedMaterialsWasmLength);
            global::UnityEngine.Material[] returnResult = new global::UnityEngine.Material[sharedMaterialsWasmLength];
            for (int i = 0; i < sharedMaterialsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Material(sharedMaterialsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)sharedMaterialsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__set__sharedMaterials(long selfObjectId, global::UnityEngine.Material[] sharedMaterials)
        {
            int sharedMaterialsWasmLength = sharedMaterials.Length;
            long[] sharedMaterialsIds = new long[sharedMaterialsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < sharedMaterialsWasmLength; i++) sharedMaterialsIds[i] = (sharedMaterials[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* sharedMaterialsIdsPointer = sharedMaterialsIds)
            {
                UnityEngineRenderer__set__sharedMaterials(selfObjectId, sharedMaterialsIdsPointer, sharedMaterialsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__ResetBounds__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderer__func__ResetBounds__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__ResetLocalBounds__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderer__func__ResetLocalBounds__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderer__func__HasPropertyBlock__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderer__func__HasPropertyBlock__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.MaterialPropertyBlock properties, int materialIndex)
        {
            UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(selfObjectId, properties.WrappedId, materialIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.MaterialPropertyBlock properties, int materialIndex)
        {
            UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(selfObjectId, properties.WrappedId, materialIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__GetMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Material> mList)
        {
            Span<global::UnityEngine.Material> m = CollectionsMarshal.AsSpan(mList);
            int mWasmLength = m.Length;
            long[] mIds = new long[mWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < mWasmLength; i++) mIds[i] = (m[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* mIdsPointer = mIds)
            {
                UnityEngineRenderer__func__GetMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(selfObjectId, mIdsPointer, mWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__GetSharedMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Material> mList)
        {
            Span<global::UnityEngine.Material> m = CollectionsMarshal.AsSpan(mList);
            int mWasmLength = m.Length;
            long[] mIds = new long[mWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < mWasmLength; i++) mIds[i] = (m[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* mIdsPointer = mIds)
            {
                UnityEngineRenderer__func__GetSharedMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(selfObjectId, mIdsPointer, mWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderer__func__GetClosestReflectionProbes__SystemCollectionsGeneric_List_UnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.ReflectionProbeBlendInfo> resultList)
        {
            Span<global::UnityEngine.Rendering.ReflectionProbeBlendInfo> result = CollectionsMarshal.AsSpan(resultList);
            int resultWasmLength = result.Length;
            long[] resultIds = new long[resultWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultWasmLength; i++) resultIds[i] = (result[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultIdsPointer = resultIds)
            {
                UnityEngineRenderer__func__GetClosestReflectionProbes__SystemCollectionsGeneric_List_UnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(selfObjectId, resultIdsPointer, resultWasmLength);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__localBounds(long selfObjectId, void* localBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__localBounds(long selfObjectId, void* localBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__enabled(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__enabled(long selfObjectId, int enabledConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__isVisible(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__shadowCastingMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__shadowCastingMode(long selfObjectId, int shadowCastingModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__receiveShadows(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__receiveShadows(long selfObjectId, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__forceRenderingOff(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__forceRenderingOff(long selfObjectId, int forceRenderingOffConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__staticShadowCaster(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__staticShadowCaster(long selfObjectId, int staticShadowCasterConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__motionVectorGenerationMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__motionVectorGenerationMode(long selfObjectId, int motionVectorGenerationModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__lightProbeUsage(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__lightProbeUsage(long selfObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__reflectionProbeUsage(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__reflectionProbeUsage(long selfObjectId, int reflectionProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__renderingLayerMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__renderingLayerMask(long selfObjectId, int renderingLayerMaskConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__rendererPriority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__rendererPriority(long selfObjectId, int rendererPriority);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__rayTracingMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__rayTracingMode(long selfObjectId, int rayTracingModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__sortingLayerName(long selfObjectId, void* sortingLayerNamePointer, void* sortingLayerNameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__sortingLayerName(long selfObjectId, void* sortingLayerNamePointer, int sortingLayerNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__sortingLayerID(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__sortingLayerID(long selfObjectId, int sortingLayerID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__sortingOrder(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__sortingOrder(long selfObjectId, int sortingOrder);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__allowOcclusionWhenDynamic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__allowOcclusionWhenDynamic(long selfObjectId, int allowOcclusionWhenDynamicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__isPartOfStaticBatch(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__worldToLocalMatrix(long selfObjectId, void* worldToLocalMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__localToWorldMatrix(long selfObjectId, void* localToWorldMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderer__get__lightProbeProxyVolumeOverride(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__lightProbeProxyVolumeOverride(long selfObjectId, long lightProbeProxyVolumeOverrideObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderer__get__probeAnchor(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__probeAnchor(long selfObjectId, long probeAnchorObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__lightmapIndex(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__lightmapIndex(long selfObjectId, int lightmapIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__get__realtimeLightmapIndex(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__realtimeLightmapIndex(long selfObjectId, int realtimeLightmapIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__lightmapScaleOffset(long selfObjectId, void* lightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__lightmapScaleOffset(long selfObjectId, void* lightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__realtimeLightmapScaleOffset(long selfObjectId, void* realtimeLightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__realtimeLightmapScaleOffset(long selfObjectId, void* realtimeLightmapScaleOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__materials(long selfObjectId, void* materialsIdsPointer, void* materialsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__materials(long selfObjectId, void* materialsIdsPointer, int materialsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderer__get__material(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__material(long selfObjectId, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderer__get__sharedMaterial(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__set__sharedMaterial(long selfObjectId, long sharedMaterialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__get__sharedMaterials(long selfObjectId, void* sharedMaterialsIdsPointer, void* sharedMaterialsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__set__sharedMaterials(long selfObjectId, void* sharedMaterialsIdsPointer, int sharedMaterialsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__ResetBounds__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__ResetLocalBounds__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderer__func__HasPropertyBlock__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(long selfObjectId, long propertiesObjectId, int materialIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderer__func__GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemInt32__SystemVoid(long selfObjectId, long propertiesObjectId, int materialIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__func__GetMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(long selfObjectId, void* mIdsPointer, int mWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__func__GetSharedMaterials__SystemCollectionsGeneric_List_UnityEngineMaterial__SystemVoid(long selfObjectId, void* mIdsPointer, int mWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderer__func__GetClosestReflectionProbes__SystemCollectionsGeneric_List_UnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(long selfObjectId, void* resultIdsPointer, int resultWasmLength);

        #endregion Imports
    }
}
