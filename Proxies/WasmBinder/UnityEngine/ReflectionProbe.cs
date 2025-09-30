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

    public partial class ReflectionProbe(long id) : Behaviour(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 size 
        {
            get => internal_UnityEngineReflectionProbe__get__size(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__size(WrappedId, value);
        }

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineReflectionProbe__get__center(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__center(WrappedId, value);
        }

        public float nearClipPlane 
        {
            get => internal_UnityEngineReflectionProbe__get__nearClipPlane(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__nearClipPlane(WrappedId, value);
        }

        public float farClipPlane 
        {
            get => internal_UnityEngineReflectionProbe__get__farClipPlane(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__farClipPlane(WrappedId, value);
        }

        public float intensity 
        {
            get => internal_UnityEngineReflectionProbe__get__intensity(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__intensity(WrappedId, value);
        }

        public global::UnityEngine.Bounds bounds 
        {
            get => internal_UnityEngineReflectionProbe__get__bounds(WrappedId);
        }

        public bool hdr 
        {
            get => internal_UnityEngineReflectionProbe__get__hdr(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__hdr(WrappedId, value);
        }

        public bool renderDynamicObjects 
        {
            get => internal_UnityEngineReflectionProbe__get__renderDynamicObjects(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__renderDynamicObjects(WrappedId, value);
        }

        public float shadowDistance 
        {
            get => internal_UnityEngineReflectionProbe__get__shadowDistance(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__shadowDistance(WrappedId, value);
        }

        public int resolution 
        {
            get => internal_UnityEngineReflectionProbe__get__resolution(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__resolution(WrappedId, value);
        }

        public int cullingMask 
        {
            get => internal_UnityEngineReflectionProbe__get__cullingMask(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__cullingMask(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags 
        {
            get => internal_UnityEngineReflectionProbe__get__clearFlags(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__clearFlags(WrappedId, value);
        }

        public global::UnityEngine.Color backgroundColor 
        {
            get => internal_UnityEngineReflectionProbe__get__backgroundColor(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__backgroundColor(WrappedId, value);
        }

        public float blendDistance 
        {
            get => internal_UnityEngineReflectionProbe__get__blendDistance(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__blendDistance(WrappedId, value);
        }

        public bool boxProjection 
        {
            get => internal_UnityEngineReflectionProbe__get__boxProjection(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__boxProjection(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeMode mode 
        {
            get => internal_UnityEngineReflectionProbe__get__mode(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__mode(WrappedId, value);
        }

        public int importance 
        {
            get => internal_UnityEngineReflectionProbe__get__importance(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__importance(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode 
        {
            get => internal_UnityEngineReflectionProbe__get__refreshMode(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__refreshMode(WrappedId, value);
        }

        public global::UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode 
        {
            get => internal_UnityEngineReflectionProbe__get__timeSlicingMode(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__timeSlicingMode(WrappedId, value);
        }

        public global::UnityEngine.Texture bakedTexture 
        {
            get => internal_UnityEngineReflectionProbe__get__bakedTexture(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__bakedTexture(WrappedId, value);
        }

        public global::UnityEngine.Texture customBakedTexture 
        {
            get => internal_UnityEngineReflectionProbe__get__customBakedTexture(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__customBakedTexture(WrappedId, value);
        }

        public global::UnityEngine.RenderTexture realtimeTexture 
        {
            get => internal_UnityEngineReflectionProbe__get__realtimeTexture(WrappedId);
            set => internal_UnityEngineReflectionProbe__set__realtimeTexture(WrappedId, value);
        }

        public global::UnityEngine.Texture texture 
        {
            get => internal_UnityEngineReflectionProbe__get__texture(WrappedId);
        }

        public global::UnityEngine.Vector4 textureHDRDecodeValues 
        {
            get => internal_UnityEngineReflectionProbe__get__textureHDRDecodeValues(WrappedId);
        }

        public static int minBakedCubemapResolution 
        {
            get => internal_UnityEngineReflectionProbe__get__minBakedCubemapResolution();
        }

        public static int maxBakedCubemapResolution 
        {
            get => internal_UnityEngineReflectionProbe__get__maxBakedCubemapResolution();
        }

        public static global::UnityEngine.Vector4 defaultTextureHDRDecodeValues 
        {
            get => internal_UnityEngineReflectionProbe__get__defaultTextureHDRDecodeValues();
        }

        public static global::UnityEngine.Texture defaultTexture 
        {
            get => internal_UnityEngineReflectionProbe__get__defaultTexture();
        }

        public void Reset()
        {
            internal_UnityEngineReflectionProbe__func__Reset__SystemVoid(WrappedId);
        }

        public int RenderProbe()
        {
            return internal_UnityEngineReflectionProbe__func__RenderProbe__SystemInt32(WrappedId);
        }

        public int RenderProbe(global::UnityEngine.RenderTexture targetTexture)
        {
            return internal_UnityEngineReflectionProbe__func__RenderProbe__UnityEngineRenderTexture__SystemInt32(WrappedId, targetTexture);
        }

        public bool IsFinishedRendering(int renderId)
        {
            return internal_UnityEngineReflectionProbe__func__IsFinishedRendering__SystemInt32__SystemBoolean(WrappedId, renderId);
        }

        public static bool BlendCubemap(global::UnityEngine.Texture src, global::UnityEngine.Texture dst, float blend, global::UnityEngine.RenderTexture target)
        {
            return internal_UnityEngineReflectionProbe__func__BlendCubemap__UnityEngineTexture__UnityEngineTexture__SystemSingle__UnityEngineRenderTexture__SystemBoolean(src, dst, blend, target);
        }

        public static void UpdateCachedState()
        {
            internal_UnityEngineReflectionProbe__func__UpdateCachedState__SystemVoid();
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineReflectionProbe__get__size(long selfObjectId)
        {
            global::UnityEngine.Vector3 sizeValue = default;
            UnityEngineReflectionProbe__get__size(selfObjectId, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector3 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__size(long selfObjectId, global::UnityEngine.Vector3 size)
        {
            UnityEngineReflectionProbe__set__size(selfObjectId, Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineReflectionProbe__get__center(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineReflectionProbe__get__center(selfObjectId, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__center(long selfObjectId, global::UnityEngine.Vector3 center)
        {
            UnityEngineReflectionProbe__set__center(selfObjectId, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineReflectionProbe__get__nearClipPlane(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__nearClipPlane(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__nearClipPlane(long selfObjectId, float nearClipPlane)
        {
            UnityEngineReflectionProbe__set__nearClipPlane(selfObjectId, nearClipPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineReflectionProbe__get__farClipPlane(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__farClipPlane(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__farClipPlane(long selfObjectId, float farClipPlane)
        {
            UnityEngineReflectionProbe__set__farClipPlane(selfObjectId, farClipPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineReflectionProbe__get__intensity(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__intensity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__intensity(long selfObjectId, float intensity)
        {
            UnityEngineReflectionProbe__set__intensity(selfObjectId, intensity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineReflectionProbe__get__bounds(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsValue = default;
            UnityEngineReflectionProbe__get__bounds(selfObjectId, Unsafe.AsPointer(ref boundsValue));
            global::UnityEngine.Bounds returnResult = boundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineReflectionProbe__get__hdr(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__hdr(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__hdr(long selfObjectId, bool hdr)
        {
            var hdrConverted = Unsafe.As<bool, int>(ref hdr);
            UnityEngineReflectionProbe__set__hdr(selfObjectId, hdrConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineReflectionProbe__get__renderDynamicObjects(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__renderDynamicObjects(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__renderDynamicObjects(long selfObjectId, bool renderDynamicObjects)
        {
            var renderDynamicObjectsConverted = Unsafe.As<bool, int>(ref renderDynamicObjects);
            UnityEngineReflectionProbe__set__renderDynamicObjects(selfObjectId, renderDynamicObjectsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineReflectionProbe__get__shadowDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__shadowDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__shadowDistance(long selfObjectId, float shadowDistance)
        {
            UnityEngineReflectionProbe__set__shadowDistance(selfObjectId, shadowDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__get__resolution(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__resolution(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__resolution(long selfObjectId, int resolution)
        {
            UnityEngineReflectionProbe__set__resolution(selfObjectId, resolution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__get__cullingMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__cullingMask(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__cullingMask(long selfObjectId, int cullingMask)
        {
            UnityEngineReflectionProbe__set__cullingMask(selfObjectId, cullingMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeClearFlags internal_UnityEngineReflectionProbe__get__clearFlags(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__clearFlags(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeClearFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__clearFlags(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags)
        {
            UnityEngineReflectionProbe__set__clearFlags(selfObjectId, (int) clearFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineReflectionProbe__get__backgroundColor(long selfObjectId)
        {
            global::UnityEngine.Color backgroundColorValue = default;
            UnityEngineReflectionProbe__get__backgroundColor(selfObjectId, Unsafe.AsPointer(ref backgroundColorValue));
            global::UnityEngine.Color returnResult = backgroundColorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__backgroundColor(long selfObjectId, global::UnityEngine.Color backgroundColor)
        {
            UnityEngineReflectionProbe__set__backgroundColor(selfObjectId, Unsafe.AsPointer(ref backgroundColor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineReflectionProbe__get__blendDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__blendDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__blendDistance(long selfObjectId, float blendDistance)
        {
            UnityEngineReflectionProbe__set__blendDistance(selfObjectId, blendDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineReflectionProbe__get__boxProjection(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__boxProjection(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__boxProjection(long selfObjectId, bool boxProjection)
        {
            var boxProjectionConverted = Unsafe.As<bool, int>(ref boxProjection);
            UnityEngineReflectionProbe__set__boxProjection(selfObjectId, boxProjectionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeMode internal_UnityEngineReflectionProbe__get__mode(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__mode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__mode(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeMode mode)
        {
            UnityEngineReflectionProbe__set__mode(selfObjectId, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__get__importance(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__importance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__importance(long selfObjectId, int importance)
        {
            UnityEngineReflectionProbe__set__importance(selfObjectId, importance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeRefreshMode internal_UnityEngineReflectionProbe__get__refreshMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__refreshMode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeRefreshMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__refreshMode(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode)
        {
            UnityEngineReflectionProbe__set__refreshMode(selfObjectId, (int) refreshMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ReflectionProbeTimeSlicingMode internal_UnityEngineReflectionProbe__get__timeSlicingMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__timeSlicingMode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.ReflectionProbeTimeSlicingMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__timeSlicingMode(long selfObjectId, global::UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode)
        {
            UnityEngineReflectionProbe__set__timeSlicingMode(selfObjectId, (int) timeSlicingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineReflectionProbe__get__bakedTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__bakedTexture(selfObjectId);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__bakedTexture(long selfObjectId, global::UnityEngine.Texture bakedTexture)
        {
            UnityEngineReflectionProbe__set__bakedTexture(selfObjectId, bakedTexture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineReflectionProbe__get__customBakedTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__customBakedTexture(selfObjectId);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__customBakedTexture(long selfObjectId, global::UnityEngine.Texture customBakedTexture)
        {
            UnityEngineReflectionProbe__set__customBakedTexture(selfObjectId, customBakedTexture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineReflectionProbe__get__realtimeTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__realtimeTexture(selfObjectId);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__set__realtimeTexture(long selfObjectId, global::UnityEngine.RenderTexture realtimeTexture)
        {
            UnityEngineReflectionProbe__set__realtimeTexture(selfObjectId, realtimeTexture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineReflectionProbe__get__texture(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__get__texture(selfObjectId);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineReflectionProbe__get__textureHDRDecodeValues(long selfObjectId)
        {
            global::UnityEngine.Vector4 textureHDRDecodeValuesValue = default;
            UnityEngineReflectionProbe__get__textureHDRDecodeValues(selfObjectId, Unsafe.AsPointer(ref textureHDRDecodeValuesValue));
            global::UnityEngine.Vector4 returnResult = textureHDRDecodeValuesValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__get__minBakedCubemapResolution()
        {
            var methodCallResult = UnityEngineReflectionProbe__get__minBakedCubemapResolution();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__get__maxBakedCubemapResolution()
        {
            var methodCallResult = UnityEngineReflectionProbe__get__maxBakedCubemapResolution();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineReflectionProbe__get__defaultTextureHDRDecodeValues()
        {
            global::UnityEngine.Vector4 defaultTextureHDRDecodeValuesValue = default;
            UnityEngineReflectionProbe__get__defaultTextureHDRDecodeValues(Unsafe.AsPointer(ref defaultTextureHDRDecodeValuesValue));
            global::UnityEngine.Vector4 returnResult = defaultTextureHDRDecodeValuesValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineReflectionProbe__get__defaultTexture()
        {
            var methodCallResult = UnityEngineReflectionProbe__get__defaultTexture();
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__func__Reset__SystemVoid(long selfObjectId)
        {
            UnityEngineReflectionProbe__func__Reset__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__func__RenderProbe__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineReflectionProbe__func__RenderProbe__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineReflectionProbe__func__RenderProbe__UnityEngineRenderTexture__SystemInt32(long selfObjectId, global::UnityEngine.RenderTexture targetTexture)
        {
            var methodCallResult = UnityEngineReflectionProbe__func__RenderProbe__UnityEngineRenderTexture__SystemInt32(selfObjectId, targetTexture.WrappedId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineReflectionProbe__func__IsFinishedRendering__SystemInt32__SystemBoolean(long selfObjectId, int renderId)
        {
            var methodCallResult = UnityEngineReflectionProbe__func__IsFinishedRendering__SystemInt32__SystemBoolean(selfObjectId, renderId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineReflectionProbe__func__BlendCubemap__UnityEngineTexture__UnityEngineTexture__SystemSingle__UnityEngineRenderTexture__SystemBoolean(global::UnityEngine.Texture src, global::UnityEngine.Texture dst, float blend, global::UnityEngine.RenderTexture target)
        {
            var methodCallResult = UnityEngineReflectionProbe__func__BlendCubemap__UnityEngineTexture__UnityEngineTexture__SystemSingle__UnityEngineRenderTexture__SystemBoolean(src.WrappedId, dst.WrappedId, blend, target.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineReflectionProbe__func__UpdateCachedState__SystemVoid()
        {
            UnityEngineReflectionProbe__func__UpdateCachedState__SystemVoid();
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__size(long selfObjectId, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__set__size(long selfObjectId, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__set__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineReflectionProbe__get__nearClipPlane(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__nearClipPlane(long selfObjectId, float nearClipPlane);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineReflectionProbe__get__farClipPlane(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__farClipPlane(long selfObjectId, float farClipPlane);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineReflectionProbe__get__intensity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__intensity(long selfObjectId, float intensity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__hdr(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__hdr(long selfObjectId, int hdrConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__renderDynamicObjects(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__renderDynamicObjects(long selfObjectId, int renderDynamicObjectsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineReflectionProbe__get__shadowDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__shadowDistance(long selfObjectId, float shadowDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__resolution(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__resolution(long selfObjectId, int resolution);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__cullingMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__cullingMask(long selfObjectId, int cullingMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__clearFlags(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__clearFlags(long selfObjectId, int clearFlagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__backgroundColor(long selfObjectId, void* backgroundColorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__set__backgroundColor(long selfObjectId, void* backgroundColorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineReflectionProbe__get__blendDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__blendDistance(long selfObjectId, float blendDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__boxProjection(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__boxProjection(long selfObjectId, int boxProjectionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__mode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__mode(long selfObjectId, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__importance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__importance(long selfObjectId, int importance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__refreshMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__refreshMode(long selfObjectId, int refreshModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__timeSlicingMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__timeSlicingMode(long selfObjectId, int timeSlicingModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineReflectionProbe__get__bakedTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__bakedTexture(long selfObjectId, long bakedTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineReflectionProbe__get__customBakedTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__customBakedTexture(long selfObjectId, long customBakedTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineReflectionProbe__get__realtimeTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__set__realtimeTexture(long selfObjectId, long realtimeTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineReflectionProbe__get__texture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__textureHDRDecodeValues(long selfObjectId, void* textureHDRDecodeValuesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__minBakedCubemapResolution();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__get__maxBakedCubemapResolution();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineReflectionProbe__get__defaultTextureHDRDecodeValues(void* defaultTextureHDRDecodeValuesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineReflectionProbe__get__defaultTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__func__Reset__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__func__RenderProbe__SystemInt32(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__func__RenderProbe__UnityEngineRenderTexture__SystemInt32(long selfObjectId, long targetTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__func__IsFinishedRendering__SystemInt32__SystemBoolean(long selfObjectId, int renderId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineReflectionProbe__func__BlendCubemap__UnityEngineTexture__UnityEngineTexture__SystemSingle__UnityEngineRenderTexture__SystemBoolean(long srcObjectId, long dstObjectId, float blend, long targetObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineReflectionProbe__func__UpdateCachedState__SystemVoid();

        #endregion Imports
    }
}
