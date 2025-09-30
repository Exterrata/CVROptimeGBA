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

    public partial class LightProbeProxyVolume(long id) : Behaviour(id)
    {

        #region Implementation

        public static bool isFeatureSupported 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__isFeatureSupported();
        }

        public global::UnityEngine.Bounds boundsGlobal 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__boundsGlobal(WrappedId);
        }

        public global::UnityEngine.Vector3 sizeCustom 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__sizeCustom(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__sizeCustom(WrappedId, value);
        }

        public global::UnityEngine.Vector3 originCustom 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__originCustom(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__originCustom(WrappedId, value);
        }

        public float probeDensity 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__probeDensity(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__probeDensity(WrappedId, value);
        }

        public int gridResolutionX 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__gridResolutionX(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__gridResolutionX(WrappedId, value);
        }

        public int gridResolutionY 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__gridResolutionY(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__gridResolutionY(WrappedId, value);
        }

        public int gridResolutionZ 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__gridResolutionZ(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__gridResolutionZ(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.BoundingBoxMode boundingBoxMode 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__boundingBoxMode(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__boundingBoxMode(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.ResolutionMode resolutionMode 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__resolutionMode(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__resolutionMode(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.ProbePositionMode probePositionMode 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__probePositionMode(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__probePositionMode(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.RefreshMode refreshMode 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__refreshMode(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__refreshMode(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.QualityMode qualityMode 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__qualityMode(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__qualityMode(WrappedId, value);
        }

        public global::UnityEngine.LightProbeProxyVolume.DataFormat dataFormat 
        {
            get => internal_UnityEngineLightProbeProxyVolume__get__dataFormat(WrappedId);
            set => internal_UnityEngineLightProbeProxyVolume__set__dataFormat(WrappedId, value);
        }

        public void Update()
        {
            internal_UnityEngineLightProbeProxyVolume__func__Update__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineLightProbeProxyVolume__get__isFeatureSupported()
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__isFeatureSupported();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineLightProbeProxyVolume__get__boundsGlobal(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsGlobalValue = default;
            UnityEngineLightProbeProxyVolume__get__boundsGlobal(selfObjectId, Unsafe.AsPointer(ref boundsGlobalValue));
            global::UnityEngine.Bounds returnResult = boundsGlobalValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineLightProbeProxyVolume__get__sizeCustom(long selfObjectId)
        {
            global::UnityEngine.Vector3 sizeCustomValue = default;
            UnityEngineLightProbeProxyVolume__get__sizeCustom(selfObjectId, Unsafe.AsPointer(ref sizeCustomValue));
            global::UnityEngine.Vector3 returnResult = sizeCustomValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__sizeCustom(long selfObjectId, global::UnityEngine.Vector3 sizeCustom)
        {
            UnityEngineLightProbeProxyVolume__set__sizeCustom(selfObjectId, Unsafe.AsPointer(ref sizeCustom));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineLightProbeProxyVolume__get__originCustom(long selfObjectId)
        {
            global::UnityEngine.Vector3 originCustomValue = default;
            UnityEngineLightProbeProxyVolume__get__originCustom(selfObjectId, Unsafe.AsPointer(ref originCustomValue));
            global::UnityEngine.Vector3 returnResult = originCustomValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__originCustom(long selfObjectId, global::UnityEngine.Vector3 originCustom)
        {
            UnityEngineLightProbeProxyVolume__set__originCustom(selfObjectId, Unsafe.AsPointer(ref originCustom));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineLightProbeProxyVolume__get__probeDensity(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__probeDensity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__probeDensity(long selfObjectId, float probeDensity)
        {
            UnityEngineLightProbeProxyVolume__set__probeDensity(selfObjectId, probeDensity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineLightProbeProxyVolume__get__gridResolutionX(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__gridResolutionX(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__gridResolutionX(long selfObjectId, int gridResolutionX)
        {
            UnityEngineLightProbeProxyVolume__set__gridResolutionX(selfObjectId, gridResolutionX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineLightProbeProxyVolume__get__gridResolutionY(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__gridResolutionY(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__gridResolutionY(long selfObjectId, int gridResolutionY)
        {
            UnityEngineLightProbeProxyVolume__set__gridResolutionY(selfObjectId, gridResolutionY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineLightProbeProxyVolume__get__gridResolutionZ(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__gridResolutionZ(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__gridResolutionZ(long selfObjectId, int gridResolutionZ)
        {
            UnityEngineLightProbeProxyVolume__set__gridResolutionZ(selfObjectId, gridResolutionZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.BoundingBoxMode internal_UnityEngineLightProbeProxyVolume__get__boundingBoxMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__boundingBoxMode(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.BoundingBoxMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__boundingBoxMode(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.BoundingBoxMode boundingBoxMode)
        {
            UnityEngineLightProbeProxyVolume__set__boundingBoxMode(selfObjectId, (int) boundingBoxMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.ResolutionMode internal_UnityEngineLightProbeProxyVolume__get__resolutionMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__resolutionMode(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.ResolutionMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__resolutionMode(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.ResolutionMode resolutionMode)
        {
            UnityEngineLightProbeProxyVolume__set__resolutionMode(selfObjectId, (int) resolutionMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.ProbePositionMode internal_UnityEngineLightProbeProxyVolume__get__probePositionMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__probePositionMode(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.ProbePositionMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__probePositionMode(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.ProbePositionMode probePositionMode)
        {
            UnityEngineLightProbeProxyVolume__set__probePositionMode(selfObjectId, (int) probePositionMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.RefreshMode internal_UnityEngineLightProbeProxyVolume__get__refreshMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__refreshMode(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.RefreshMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__refreshMode(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.RefreshMode refreshMode)
        {
            UnityEngineLightProbeProxyVolume__set__refreshMode(selfObjectId, (int) refreshMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.QualityMode internal_UnityEngineLightProbeProxyVolume__get__qualityMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__qualityMode(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.QualityMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__qualityMode(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.QualityMode qualityMode)
        {
            UnityEngineLightProbeProxyVolume__set__qualityMode(selfObjectId, (int) qualityMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.LightProbeProxyVolume.DataFormat internal_UnityEngineLightProbeProxyVolume__get__dataFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineLightProbeProxyVolume__get__dataFormat(selfObjectId);
            var returnResult = (global::UnityEngine.LightProbeProxyVolume.DataFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__set__dataFormat(long selfObjectId, global::UnityEngine.LightProbeProxyVolume.DataFormat dataFormat)
        {
            UnityEngineLightProbeProxyVolume__set__dataFormat(selfObjectId, (int) dataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLightProbeProxyVolume__func__Update__SystemVoid(long selfObjectId)
        {
            UnityEngineLightProbeProxyVolume__func__Update__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__isFeatureSupported();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLightProbeProxyVolume__get__boundsGlobal(long selfObjectId, void* boundsGlobalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLightProbeProxyVolume__get__sizeCustom(long selfObjectId, void* sizeCustomPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLightProbeProxyVolume__set__sizeCustom(long selfObjectId, void* sizeCustomPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLightProbeProxyVolume__get__originCustom(long selfObjectId, void* originCustomPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLightProbeProxyVolume__set__originCustom(long selfObjectId, void* originCustomPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineLightProbeProxyVolume__get__probeDensity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__probeDensity(long selfObjectId, float probeDensity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__gridResolutionX(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__gridResolutionX(long selfObjectId, int gridResolutionX);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__gridResolutionY(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__gridResolutionY(long selfObjectId, int gridResolutionY);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__gridResolutionZ(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__gridResolutionZ(long selfObjectId, int gridResolutionZ);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__boundingBoxMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__boundingBoxMode(long selfObjectId, int boundingBoxModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__resolutionMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__resolutionMode(long selfObjectId, int resolutionModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__probePositionMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__probePositionMode(long selfObjectId, int probePositionModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__refreshMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__refreshMode(long selfObjectId, int refreshModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__qualityMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__qualityMode(long selfObjectId, int qualityModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineLightProbeProxyVolume__get__dataFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__set__dataFormat(long selfObjectId, int dataFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineLightProbeProxyVolume__func__Update__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
