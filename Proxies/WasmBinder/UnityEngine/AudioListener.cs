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

    public partial class AudioListener(long id) : AudioBehaviour(id)
    {

        #region Implementation

        public static float volume 
        {
            get => internal_UnityEngineAudioListener__get__volume();
            set => internal_UnityEngineAudioListener__set__volume(value);
        }

        public static bool pause 
        {
            get => internal_UnityEngineAudioListener__get__pause();
            set => internal_UnityEngineAudioListener__set__pause(value);
        }

        public global::UnityEngine.AudioVelocityUpdateMode velocityUpdateMode 
        {
            get => internal_UnityEngineAudioListener__get__velocityUpdateMode(WrappedId);
            set => internal_UnityEngineAudioListener__set__velocityUpdateMode(WrappedId, value);
        }

        public static void GetOutputData(global::System.Single[] samples, int channel)
        {
            internal_UnityEngineAudioListener__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(samples, channel);
        }

        public static void GetSpectrumData(global::System.Single[] samples, int channel, global::UnityEngine.FFTWindow window)
        {
            internal_UnityEngineAudioListener__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(samples, channel, window);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioListener__get__volume()
        {
            var methodCallResult = UnityEngineAudioListener__get__volume();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioListener__set__volume(float volume)
        {
            UnityEngineAudioListener__set__volume(volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioListener__get__pause()
        {
            var methodCallResult = UnityEngineAudioListener__get__pause();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioListener__set__pause(bool pause)
        {
            var pauseConverted = Unsafe.As<bool, int>(ref pause);
            UnityEngineAudioListener__set__pause(pauseConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioVelocityUpdateMode internal_UnityEngineAudioListener__get__velocityUpdateMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioListener__get__velocityUpdateMode(selfObjectId);
            var returnResult = (global::UnityEngine.AudioVelocityUpdateMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioListener__set__velocityUpdateMode(long selfObjectId, global::UnityEngine.AudioVelocityUpdateMode velocityUpdateMode)
        {
            UnityEngineAudioListener__set__velocityUpdateMode(selfObjectId, (int) velocityUpdateMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioListener__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(global::System.Single[] samples, int channel)
        {
            fixed (float* samplesPointer = samples)
            {
                UnityEngineAudioListener__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(samplesPointer, samples.Length, channel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioListener__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(global::System.Single[] samples, int channel, global::UnityEngine.FFTWindow window)
        {
            fixed (float* samplesPointer = samples)
            {
                UnityEngineAudioListener__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(samplesPointer, samples.Length, channel, (int) window);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioListener__get__volume();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioListener__set__volume(float volume);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioListener__get__pause();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioListener__set__pause(int pauseConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioListener__get__velocityUpdateMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioListener__set__velocityUpdateMode(long selfObjectId, int velocityUpdateModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioListener__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(void* samplesPointer, int samplesWasmLength, int channel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioListener__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(void* samplesPointer, int samplesWasmLength, int channel, int windowUnderlyingValue);

        #endregion Imports
    }
}
