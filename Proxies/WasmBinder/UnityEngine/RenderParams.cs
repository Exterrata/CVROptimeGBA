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

    public partial struct RenderParams(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public RenderParams(global::UnityEngine.Material mat)
            : this(internal_UnityEngineRenderParams__ctor__UnityEngineMaterial(mat)) { }

        public int layer 
        {
            get => internal_UnityEngineRenderParams__get__layer(WrappedId);
            set => internal_UnityEngineRenderParams__set__layer(WrappedId, value);
        }

        public uint renderingLayerMask 
        {
            get => internal_UnityEngineRenderParams__get__renderingLayerMask(WrappedId);
            set => internal_UnityEngineRenderParams__set__renderingLayerMask(WrappedId, value);
        }

        public int rendererPriority 
        {
            get => internal_UnityEngineRenderParams__get__rendererPriority(WrappedId);
            set => internal_UnityEngineRenderParams__set__rendererPriority(WrappedId, value);
        }

        public global::UnityEngine.Bounds worldBounds 
        {
            get => internal_UnityEngineRenderParams__get__worldBounds(WrappedId);
            set => internal_UnityEngineRenderParams__set__worldBounds(WrappedId, value);
        }

        public global::UnityEngine.Camera camera 
        {
            get => internal_UnityEngineRenderParams__get__camera(WrappedId);
            set => internal_UnityEngineRenderParams__set__camera(WrappedId, value);
        }

        public global::UnityEngine.MotionVectorGenerationMode motionVectorMode 
        {
            get => internal_UnityEngineRenderParams__get__motionVectorMode(WrappedId);
            set => internal_UnityEngineRenderParams__set__motionVectorMode(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage 
        {
            get => internal_UnityEngineRenderParams__get__reflectionProbeUsage(WrappedId);
            set => internal_UnityEngineRenderParams__set__reflectionProbeUsage(WrappedId, value);
        }

        public global::UnityEngine.Material material 
        {
            get => internal_UnityEngineRenderParams__get__material(WrappedId);
            set => internal_UnityEngineRenderParams__set__material(WrappedId, value);
        }

        public global::UnityEngine.MaterialPropertyBlock matProps 
        {
            get => internal_UnityEngineRenderParams__get__matProps(WrappedId);
            set => internal_UnityEngineRenderParams__set__matProps(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ShadowCastingMode shadowCastingMode 
        {
            get => internal_UnityEngineRenderParams__get__shadowCastingMode(WrappedId);
            set => internal_UnityEngineRenderParams__set__shadowCastingMode(WrappedId, value);
        }

        public bool receiveShadows 
        {
            get => internal_UnityEngineRenderParams__get__receiveShadows(WrappedId);
            set => internal_UnityEngineRenderParams__set__receiveShadows(WrappedId, value);
        }

        public global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage 
        {
            get => internal_UnityEngineRenderParams__get__lightProbeUsage(WrappedId);
            set => internal_UnityEngineRenderParams__set__lightProbeUsage(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume 
        {
            get => internal_UnityEngineRenderParams__get__lightProbeProxyVolume(WrappedId);
            set => internal_UnityEngineRenderParams__set__lightProbeProxyVolume(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderParams__ctor__UnityEngineMaterial(global::UnityEngine.Material mat)
        {
            return UnityEngineRenderParams__ctor__UnityEngineMaterial(mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderParams__get__layer(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__layer(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__layer(long selfObjectId, int layer)
        {
            UnityEngineRenderParams__set__layer(selfObjectId, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineRenderParams__get__renderingLayerMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__renderingLayerMask(selfObjectId);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__renderingLayerMask(long selfObjectId, uint renderingLayerMask)
        {
            var renderingLayerMaskConverted = Unsafe.As<uint, int>(ref renderingLayerMask);
            UnityEngineRenderParams__set__renderingLayerMask(selfObjectId, renderingLayerMaskConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderParams__get__rendererPriority(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__rendererPriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__rendererPriority(long selfObjectId, int rendererPriority)
        {
            UnityEngineRenderParams__set__rendererPriority(selfObjectId, rendererPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineRenderParams__get__worldBounds(long selfObjectId)
        {
            global::UnityEngine.Bounds worldBoundsValue = default;
            UnityEngineRenderParams__get__worldBounds(selfObjectId, Unsafe.AsPointer(ref worldBoundsValue));
            global::UnityEngine.Bounds returnResult = worldBoundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__worldBounds(long selfObjectId, global::UnityEngine.Bounds worldBounds)
        {
            UnityEngineRenderParams__set__worldBounds(selfObjectId, Unsafe.AsPointer(ref worldBounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera internal_UnityEngineRenderParams__get__camera(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__camera(selfObjectId);
            var returnResult = new global::UnityEngine.Camera(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__camera(long selfObjectId, global::UnityEngine.Camera camera)
        {
            UnityEngineRenderParams__set__camera(selfObjectId, camera.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MotionVectorGenerationMode internal_UnityEngineRenderParams__get__motionVectorMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__motionVectorMode(selfObjectId);
            var returnResult = (global::UnityEngine.MotionVectorGenerationMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__motionVectorMode(long selfObjectId, global::UnityEngine.MotionVectorGenerationMode motionVectorMode)
        {
            UnityEngineRenderParams__set__motionVectorMode(selfObjectId, (int) motionVectorMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeUsage internal_UnityEngineRenderParams__get__reflectionProbeUsage(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__reflectionProbeUsage(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeUsage)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__reflectionProbeUsage(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage)
        {
            UnityEngineRenderParams__set__reflectionProbeUsage(selfObjectId, (int) reflectionProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineRenderParams__get__material(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__material(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__material(long selfObjectId, global::UnityEngine.Material material)
        {
            UnityEngineRenderParams__set__material(selfObjectId, material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MaterialPropertyBlock internal_UnityEngineRenderParams__get__matProps(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__matProps(selfObjectId);
            var returnResult = new global::UnityEngine.MaterialPropertyBlock(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__matProps(long selfObjectId, global::UnityEngine.MaterialPropertyBlock matProps)
        {
            UnityEngineRenderParams__set__matProps(selfObjectId, matProps.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShadowCastingMode internal_UnityEngineRenderParams__get__shadowCastingMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__shadowCastingMode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ShadowCastingMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__shadowCastingMode(long selfObjectId, global::UnityEngine.Rendering.ShadowCastingMode shadowCastingMode)
        {
            UnityEngineRenderParams__set__shadowCastingMode(selfObjectId, (int) shadowCastingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderParams__get__receiveShadows(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__receiveShadows(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__receiveShadows(long selfObjectId, bool receiveShadows)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineRenderParams__set__receiveShadows(selfObjectId, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LightProbeUsage internal_UnityEngineRenderParams__get__lightProbeUsage(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__lightProbeUsage(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.LightProbeUsage)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__lightProbeUsage(long selfObjectId, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            UnityEngineRenderParams__set__lightProbeUsage(selfObjectId, (int) lightProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume internal_UnityEngineRenderParams__get__lightProbeProxyVolume(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderParams__get__lightProbeProxyVolume(selfObjectId);
            var returnResult = new global::UnityEngine.LightProbeProxyVolume(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderParams__set__lightProbeProxyVolume(long selfObjectId, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            UnityEngineRenderParams__set__lightProbeProxyVolume(selfObjectId, lightProbeProxyVolume.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderParams__ctor__UnityEngineMaterial(long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__layer(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__layer(long selfObjectId, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__renderingLayerMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__renderingLayerMask(long selfObjectId, int renderingLayerMaskConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__rendererPriority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__rendererPriority(long selfObjectId, int rendererPriority);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderParams__get__worldBounds(long selfObjectId, void* worldBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderParams__set__worldBounds(long selfObjectId, void* worldBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderParams__get__camera(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__camera(long selfObjectId, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__motionVectorMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__motionVectorMode(long selfObjectId, int motionVectorModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__reflectionProbeUsage(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__reflectionProbeUsage(long selfObjectId, int reflectionProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderParams__get__material(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__material(long selfObjectId, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderParams__get__matProps(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__matProps(long selfObjectId, long matPropsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__shadowCastingMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__shadowCastingMode(long selfObjectId, int shadowCastingModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__receiveShadows(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__receiveShadows(long selfObjectId, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderParams__get__lightProbeUsage(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__lightProbeUsage(long selfObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderParams__get__lightProbeProxyVolume(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderParams__set__lightProbeProxyVolume(long selfObjectId, long lightProbeProxyVolumeObjectId);

        #endregion Imports
    }
}
