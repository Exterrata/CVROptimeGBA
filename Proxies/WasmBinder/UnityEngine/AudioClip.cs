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

    public partial class AudioClip(long id) : Object(id)
    {

        #region Implementation

        public float length 
        {
            get => internal_UnityEngineAudioClip__get__length(WrappedId);
        }

        public int samples 
        {
            get => internal_UnityEngineAudioClip__get__samples(WrappedId);
        }

        public int channels 
        {
            get => internal_UnityEngineAudioClip__get__channels(WrappedId);
        }

        public int frequency 
        {
            get => internal_UnityEngineAudioClip__get__frequency(WrappedId);
        }

        public global::UnityEngine.AudioClipLoadType loadType 
        {
            get => internal_UnityEngineAudioClip__get__loadType(WrappedId);
        }

        public bool preloadAudioData 
        {
            get => internal_UnityEngineAudioClip__get__preloadAudioData(WrappedId);
        }

        public bool ambisonic 
        {
            get => internal_UnityEngineAudioClip__get__ambisonic(WrappedId);
        }

        public bool loadInBackground 
        {
            get => internal_UnityEngineAudioClip__get__loadInBackground(WrappedId);
        }

        public global::UnityEngine.AudioDataLoadState loadState 
        {
            get => internal_UnityEngineAudioClip__get__loadState(WrappedId);
        }

        public bool LoadAudioData()
        {
            return internal_UnityEngineAudioClip__func__LoadAudioData__SystemBoolean(WrappedId);
        }

        public bool UnloadAudioData()
        {
            return internal_UnityEngineAudioClip__func__UnloadAudioData__SystemBoolean(WrappedId);
        }

        public bool GetData(global::System.Single[] data, int offsetSamples)
        {
            return internal_UnityEngineAudioClip__func__GetData__SystemSingleArray__SystemInt32__SystemBoolean(WrappedId, data, offsetSamples);
        }

        public bool SetData(global::System.Single[] data, int offsetSamples)
        {
            return internal_UnityEngineAudioClip__func__SetData__SystemSingleArray__SystemInt32__SystemBoolean(WrappedId, data, offsetSamples);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioClip__get__length(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__length(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAudioClip__get__samples(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__samples(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAudioClip__get__channels(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__channels(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAudioClip__get__frequency(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__frequency(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioClipLoadType internal_UnityEngineAudioClip__get__loadType(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__loadType(selfObjectId);
            var returnResult = (global::UnityEngine.AudioClipLoadType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__get__preloadAudioData(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__preloadAudioData(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__get__ambisonic(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__ambisonic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__get__loadInBackground(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__loadInBackground(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioDataLoadState internal_UnityEngineAudioClip__get__loadState(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__get__loadState(selfObjectId);
            var returnResult = (global::UnityEngine.AudioDataLoadState)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__func__LoadAudioData__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__func__LoadAudioData__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__func__UnloadAudioData__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioClip__func__UnloadAudioData__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__func__GetData__SystemSingleArray__SystemInt32__SystemBoolean(long selfObjectId, global::System.Single[] data, int offsetSamples)
        {
            fixed (float* dataPointer = data)
            {
                var methodCallResult = UnityEngineAudioClip__func__GetData__SystemSingleArray__SystemInt32__SystemBoolean(selfObjectId, dataPointer, data.Length, offsetSamples);
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioClip__func__SetData__SystemSingleArray__SystemInt32__SystemBoolean(long selfObjectId, global::System.Single[] data, int offsetSamples)
        {
            fixed (float* dataPointer = data)
            {
                var methodCallResult = UnityEngineAudioClip__func__SetData__SystemSingleArray__SystemInt32__SystemBoolean(selfObjectId, dataPointer, data.Length, offsetSamples);
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioClip__get__length(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__samples(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__channels(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__frequency(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__loadType(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__preloadAudioData(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__ambisonic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__loadInBackground(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__get__loadState(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__func__LoadAudioData__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioClip__func__UnloadAudioData__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioClip__func__GetData__SystemSingleArray__SystemInt32__SystemBoolean(long selfObjectId, void* dataPointer, int dataWasmLength, int offsetSamples);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioClip__func__SetData__SystemSingleArray__SystemInt32__SystemBoolean(long selfObjectId, void* dataPointer, int dataWasmLength, int offsetSamples);

        #endregion Imports
    }
}
