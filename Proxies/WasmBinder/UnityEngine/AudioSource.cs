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

    public partial class AudioSource(long id) : AudioBehaviour(id)
    {

        #region Implementation

        public float volume 
        {
            get => internal_UnityEngineAudioSource__get__volume(WrappedId);
            set => internal_UnityEngineAudioSource__set__volume(WrappedId, value);
        }

        public float pitch 
        {
            get => internal_UnityEngineAudioSource__get__pitch(WrappedId);
            set => internal_UnityEngineAudioSource__set__pitch(WrappedId, value);
        }

        public float time 
        {
            get => internal_UnityEngineAudioSource__get__time(WrappedId);
            set => internal_UnityEngineAudioSource__set__time(WrappedId, value);
        }

        public int timeSamples 
        {
            get => internal_UnityEngineAudioSource__get__timeSamples(WrappedId);
            set => internal_UnityEngineAudioSource__set__timeSamples(WrappedId, value);
        }

        public global::UnityEngine.AudioClip clip 
        {
            get => internal_UnityEngineAudioSource__get__clip(WrappedId);
            set => internal_UnityEngineAudioSource__set__clip(WrappedId, value);
        }

        public global::UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup 
        {
            get => internal_UnityEngineAudioSource__get__outputAudioMixerGroup(WrappedId);
            set => internal_UnityEngineAudioSource__set__outputAudioMixerGroup(WrappedId, value);
        }

        public bool isPlaying 
        {
            get => internal_UnityEngineAudioSource__get__isPlaying(WrappedId);
        }

        public bool isVirtual 
        {
            get => internal_UnityEngineAudioSource__get__isVirtual(WrappedId);
        }

        public bool loop 
        {
            get => internal_UnityEngineAudioSource__get__loop(WrappedId);
            set => internal_UnityEngineAudioSource__set__loop(WrappedId, value);
        }

        public bool ignoreListenerVolume 
        {
            get => internal_UnityEngineAudioSource__get__ignoreListenerVolume(WrappedId);
            set => internal_UnityEngineAudioSource__set__ignoreListenerVolume(WrappedId, value);
        }

        public bool playOnAwake 
        {
            get => internal_UnityEngineAudioSource__get__playOnAwake(WrappedId);
            set => internal_UnityEngineAudioSource__set__playOnAwake(WrappedId, value);
        }

        public bool ignoreListenerPause 
        {
            get => internal_UnityEngineAudioSource__get__ignoreListenerPause(WrappedId);
            set => internal_UnityEngineAudioSource__set__ignoreListenerPause(WrappedId, value);
        }

        public global::UnityEngine.AudioVelocityUpdateMode velocityUpdateMode 
        {
            get => internal_UnityEngineAudioSource__get__velocityUpdateMode(WrappedId);
            set => internal_UnityEngineAudioSource__set__velocityUpdateMode(WrappedId, value);
        }

        public float panStereo 
        {
            get => internal_UnityEngineAudioSource__get__panStereo(WrappedId);
            set => internal_UnityEngineAudioSource__set__panStereo(WrappedId, value);
        }

        public float spatialBlend 
        {
            get => internal_UnityEngineAudioSource__get__spatialBlend(WrappedId);
            set => internal_UnityEngineAudioSource__set__spatialBlend(WrappedId, value);
        }

        public bool spatialize 
        {
            get => internal_UnityEngineAudioSource__get__spatialize(WrappedId);
            set => internal_UnityEngineAudioSource__set__spatialize(WrappedId, value);
        }

        public bool spatializePostEffects 
        {
            get => internal_UnityEngineAudioSource__get__spatializePostEffects(WrappedId);
            set => internal_UnityEngineAudioSource__set__spatializePostEffects(WrappedId, value);
        }

        public float reverbZoneMix 
        {
            get => internal_UnityEngineAudioSource__get__reverbZoneMix(WrappedId);
            set => internal_UnityEngineAudioSource__set__reverbZoneMix(WrappedId, value);
        }

        public bool bypassEffects 
        {
            get => internal_UnityEngineAudioSource__get__bypassEffects(WrappedId);
            set => internal_UnityEngineAudioSource__set__bypassEffects(WrappedId, value);
        }

        public bool bypassListenerEffects 
        {
            get => internal_UnityEngineAudioSource__get__bypassListenerEffects(WrappedId);
            set => internal_UnityEngineAudioSource__set__bypassListenerEffects(WrappedId, value);
        }

        public bool bypassReverbZones 
        {
            get => internal_UnityEngineAudioSource__get__bypassReverbZones(WrappedId);
            set => internal_UnityEngineAudioSource__set__bypassReverbZones(WrappedId, value);
        }

        public float dopplerLevel 
        {
            get => internal_UnityEngineAudioSource__get__dopplerLevel(WrappedId);
            set => internal_UnityEngineAudioSource__set__dopplerLevel(WrappedId, value);
        }

        public float spread 
        {
            get => internal_UnityEngineAudioSource__get__spread(WrappedId);
            set => internal_UnityEngineAudioSource__set__spread(WrappedId, value);
        }

        public int priority 
        {
            get => internal_UnityEngineAudioSource__get__priority(WrappedId);
            set => internal_UnityEngineAudioSource__set__priority(WrappedId, value);
        }

        public bool mute 
        {
            get => internal_UnityEngineAudioSource__get__mute(WrappedId);
            set => internal_UnityEngineAudioSource__set__mute(WrappedId, value);
        }

        public float minDistance 
        {
            get => internal_UnityEngineAudioSource__get__minDistance(WrappedId);
            set => internal_UnityEngineAudioSource__set__minDistance(WrappedId, value);
        }

        public float maxDistance 
        {
            get => internal_UnityEngineAudioSource__get__maxDistance(WrappedId);
            set => internal_UnityEngineAudioSource__set__maxDistance(WrappedId, value);
        }

        public global::UnityEngine.AudioRolloffMode rolloffMode 
        {
            get => internal_UnityEngineAudioSource__get__rolloffMode(WrappedId);
            set => internal_UnityEngineAudioSource__set__rolloffMode(WrappedId, value);
        }

        public void Play()
        {
            internal_UnityEngineAudioSource__func__Play__SystemVoid(WrappedId);
        }

        public void Play(ulong delay)
        {
            internal_UnityEngineAudioSource__func__Play__SystemUInt64__SystemVoid(WrappedId, delay);
        }

        public void PlayDelayed(float delay)
        {
            internal_UnityEngineAudioSource__func__PlayDelayed__SystemSingle__SystemVoid(WrappedId, delay);
        }

        public void PlayScheduled(double time)
        {
            internal_UnityEngineAudioSource__func__PlayScheduled__SystemDouble__SystemVoid(WrappedId, time);
        }

        public void PlayOneShot(global::UnityEngine.AudioClip clip)
        {
            internal_UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemVoid(WrappedId, clip);
        }

        public void PlayOneShot(global::UnityEngine.AudioClip clip, float volumeScale)
        {
            internal_UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemSingle__SystemVoid(WrappedId, clip, volumeScale);
        }

        public void SetScheduledStartTime(double time)
        {
            internal_UnityEngineAudioSource__func__SetScheduledStartTime__SystemDouble__SystemVoid(WrappedId, time);
        }

        public void SetScheduledEndTime(double time)
        {
            internal_UnityEngineAudioSource__func__SetScheduledEndTime__SystemDouble__SystemVoid(WrappedId, time);
        }

        public void Stop()
        {
            internal_UnityEngineAudioSource__func__Stop__SystemVoid(WrappedId);
        }

        public void Pause()
        {
            internal_UnityEngineAudioSource__func__Pause__SystemVoid(WrappedId);
        }

        public void UnPause()
        {
            internal_UnityEngineAudioSource__func__UnPause__SystemVoid(WrappedId);
        }

        public static void PlayClipAtPoint(global::UnityEngine.AudioClip clip, global::UnityEngine.Vector3 position)
        {
            internal_UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemVoid(clip, position);
        }

        public static void PlayClipAtPoint(global::UnityEngine.AudioClip clip, global::UnityEngine.Vector3 position, float volume)
        {
            internal_UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemSingle__SystemVoid(clip, position, volume);
        }

        public void SetCustomCurve(global::UnityEngine.AudioSourceCurveType type, global::UnityEngine.AnimationCurve curve)
        {
            internal_UnityEngineAudioSource__func__SetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve__SystemVoid(WrappedId, type, curve);
        }

        public global::UnityEngine.AnimationCurve GetCustomCurve(global::UnityEngine.AudioSourceCurveType type)
        {
            return internal_UnityEngineAudioSource__func__GetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve(WrappedId, type);
        }

        public void GetOutputData(global::System.Single[] samples, int channel)
        {
            internal_UnityEngineAudioSource__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(WrappedId, samples, channel);
        }

        public void GetSpectrumData(global::System.Single[] samples, int channel, global::UnityEngine.FFTWindow window)
        {
            internal_UnityEngineAudioSource__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(WrappedId, samples, channel, window);
        }

        public bool SetSpatializerFloat(int index, float value)
        {
            return internal_UnityEngineAudioSource__func__SetSpatializerFloat__SystemInt32__SystemSingle__SystemBoolean(WrappedId, index, value);
        }

        public bool GetSpatializerFloat(int index, out float value)
        {
            return internal_UnityEngineAudioSource__func__GetSpatializerFloat__SystemInt32__SystemSingleRef__SystemBoolean(WrappedId, index, out value);
        }

        public bool GetAmbisonicDecoderFloat(int index, out float value)
        {
            return internal_UnityEngineAudioSource__func__GetAmbisonicDecoderFloat__SystemInt32__SystemSingleRef__SystemBoolean(WrappedId, index, out value);
        }

        public bool SetAmbisonicDecoderFloat(int index, float value)
        {
            return internal_UnityEngineAudioSource__func__SetAmbisonicDecoderFloat__SystemInt32__SystemSingle__SystemBoolean(WrappedId, index, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__volume(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__volume(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__volume(long selfObjectId, float volume)
        {
            UnityEngineAudioSource__set__volume(selfObjectId, volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__pitch(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__pitch(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__pitch(long selfObjectId, float pitch)
        {
            UnityEngineAudioSource__set__pitch(selfObjectId, pitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__time(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__time(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__time(long selfObjectId, float time)
        {
            UnityEngineAudioSource__set__time(selfObjectId, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAudioSource__get__timeSamples(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__timeSamples(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__timeSamples(long selfObjectId, int timeSamples)
        {
            UnityEngineAudioSource__set__timeSamples(selfObjectId, timeSamples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioClip internal_UnityEngineAudioSource__get__clip(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__clip(selfObjectId);
            var returnResult = new global::UnityEngine.AudioClip(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__clip(long selfObjectId, global::UnityEngine.AudioClip clip)
        {
            UnityEngineAudioSource__set__clip(selfObjectId, clip.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixerGroup internal_UnityEngineAudioSource__get__outputAudioMixerGroup(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__outputAudioMixerGroup(selfObjectId);
            var returnResult = new global::UnityEngine.Audio.AudioMixerGroup(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__outputAudioMixerGroup(long selfObjectId, global::UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup)
        {
            UnityEngineAudioSource__set__outputAudioMixerGroup(selfObjectId, outputAudioMixerGroup.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__isPlaying(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__isPlaying(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__isVirtual(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__isVirtual(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__loop(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__loop(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__loop(long selfObjectId, bool loop)
        {
            var loopConverted = Unsafe.As<bool, int>(ref loop);
            UnityEngineAudioSource__set__loop(selfObjectId, loopConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__ignoreListenerVolume(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__ignoreListenerVolume(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__ignoreListenerVolume(long selfObjectId, bool ignoreListenerVolume)
        {
            var ignoreListenerVolumeConverted = Unsafe.As<bool, int>(ref ignoreListenerVolume);
            UnityEngineAudioSource__set__ignoreListenerVolume(selfObjectId, ignoreListenerVolumeConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__playOnAwake(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__playOnAwake(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__playOnAwake(long selfObjectId, bool playOnAwake)
        {
            var playOnAwakeConverted = Unsafe.As<bool, int>(ref playOnAwake);
            UnityEngineAudioSource__set__playOnAwake(selfObjectId, playOnAwakeConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__ignoreListenerPause(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__ignoreListenerPause(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__ignoreListenerPause(long selfObjectId, bool ignoreListenerPause)
        {
            var ignoreListenerPauseConverted = Unsafe.As<bool, int>(ref ignoreListenerPause);
            UnityEngineAudioSource__set__ignoreListenerPause(selfObjectId, ignoreListenerPauseConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioVelocityUpdateMode internal_UnityEngineAudioSource__get__velocityUpdateMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__velocityUpdateMode(selfObjectId);
            var returnResult = (global::UnityEngine.AudioVelocityUpdateMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__velocityUpdateMode(long selfObjectId, global::UnityEngine.AudioVelocityUpdateMode velocityUpdateMode)
        {
            UnityEngineAudioSource__set__velocityUpdateMode(selfObjectId, (int) velocityUpdateMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__panStereo(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__panStereo(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__panStereo(long selfObjectId, float panStereo)
        {
            UnityEngineAudioSource__set__panStereo(selfObjectId, panStereo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__spatialBlend(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__spatialBlend(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__spatialBlend(long selfObjectId, float spatialBlend)
        {
            UnityEngineAudioSource__set__spatialBlend(selfObjectId, spatialBlend);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__spatialize(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__spatialize(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__spatialize(long selfObjectId, bool spatialize)
        {
            var spatializeConverted = Unsafe.As<bool, int>(ref spatialize);
            UnityEngineAudioSource__set__spatialize(selfObjectId, spatializeConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__spatializePostEffects(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__spatializePostEffects(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__spatializePostEffects(long selfObjectId, bool spatializePostEffects)
        {
            var spatializePostEffectsConverted = Unsafe.As<bool, int>(ref spatializePostEffects);
            UnityEngineAudioSource__set__spatializePostEffects(selfObjectId, spatializePostEffectsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__reverbZoneMix(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__reverbZoneMix(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__reverbZoneMix(long selfObjectId, float reverbZoneMix)
        {
            UnityEngineAudioSource__set__reverbZoneMix(selfObjectId, reverbZoneMix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__bypassEffects(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__bypassEffects(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__bypassEffects(long selfObjectId, bool bypassEffects)
        {
            var bypassEffectsConverted = Unsafe.As<bool, int>(ref bypassEffects);
            UnityEngineAudioSource__set__bypassEffects(selfObjectId, bypassEffectsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__bypassListenerEffects(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__bypassListenerEffects(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__bypassListenerEffects(long selfObjectId, bool bypassListenerEffects)
        {
            var bypassListenerEffectsConverted = Unsafe.As<bool, int>(ref bypassListenerEffects);
            UnityEngineAudioSource__set__bypassListenerEffects(selfObjectId, bypassListenerEffectsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__bypassReverbZones(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__bypassReverbZones(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__bypassReverbZones(long selfObjectId, bool bypassReverbZones)
        {
            var bypassReverbZonesConverted = Unsafe.As<bool, int>(ref bypassReverbZones);
            UnityEngineAudioSource__set__bypassReverbZones(selfObjectId, bypassReverbZonesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__dopplerLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__dopplerLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__dopplerLevel(long selfObjectId, float dopplerLevel)
        {
            UnityEngineAudioSource__set__dopplerLevel(selfObjectId, dopplerLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__spread(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__spread(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__spread(long selfObjectId, float spread)
        {
            UnityEngineAudioSource__set__spread(selfObjectId, spread);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAudioSource__get__priority(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__priority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__priority(long selfObjectId, int priority)
        {
            UnityEngineAudioSource__set__priority(selfObjectId, priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__get__mute(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__mute(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__mute(long selfObjectId, bool mute)
        {
            var muteConverted = Unsafe.As<bool, int>(ref mute);
            UnityEngineAudioSource__set__mute(selfObjectId, muteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__minDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__minDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__minDistance(long selfObjectId, float minDistance)
        {
            UnityEngineAudioSource__set__minDistance(selfObjectId, minDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAudioSource__get__maxDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__maxDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__maxDistance(long selfObjectId, float maxDistance)
        {
            UnityEngineAudioSource__set__maxDistance(selfObjectId, maxDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AudioRolloffMode internal_UnityEngineAudioSource__get__rolloffMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioSource__get__rolloffMode(selfObjectId);
            var returnResult = (global::UnityEngine.AudioRolloffMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__set__rolloffMode(long selfObjectId, global::UnityEngine.AudioRolloffMode rolloffMode)
        {
            UnityEngineAudioSource__set__rolloffMode(selfObjectId, (int) rolloffMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__Play__SystemVoid(long selfObjectId)
        {
            UnityEngineAudioSource__func__Play__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__Play__SystemUInt64__SystemVoid(long selfObjectId, ulong delay)
        {
            var delayConverted = Unsafe.As<ulong, long>(ref delay);
            UnityEngineAudioSource__func__Play__SystemUInt64__SystemVoid(selfObjectId, delayConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayDelayed__SystemSingle__SystemVoid(long selfObjectId, float delay)
        {
            UnityEngineAudioSource__func__PlayDelayed__SystemSingle__SystemVoid(selfObjectId, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayScheduled__SystemDouble__SystemVoid(long selfObjectId, double time)
        {
            UnityEngineAudioSource__func__PlayScheduled__SystemDouble__SystemVoid(selfObjectId, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemVoid(long selfObjectId, global::UnityEngine.AudioClip clip)
        {
            UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemVoid(selfObjectId, clip.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.AudioClip clip, float volumeScale)
        {
            UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemSingle__SystemVoid(selfObjectId, clip.WrappedId, volumeScale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__SetScheduledStartTime__SystemDouble__SystemVoid(long selfObjectId, double time)
        {
            UnityEngineAudioSource__func__SetScheduledStartTime__SystemDouble__SystemVoid(selfObjectId, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__SetScheduledEndTime__SystemDouble__SystemVoid(long selfObjectId, double time)
        {
            UnityEngineAudioSource__func__SetScheduledEndTime__SystemDouble__SystemVoid(selfObjectId, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__Stop__SystemVoid(long selfObjectId)
        {
            UnityEngineAudioSource__func__Stop__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__Pause__SystemVoid(long selfObjectId)
        {
            UnityEngineAudioSource__func__Pause__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__UnPause__SystemVoid(long selfObjectId)
        {
            UnityEngineAudioSource__func__UnPause__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemVoid(global::UnityEngine.AudioClip clip, global::UnityEngine.Vector3 position)
        {
            UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemVoid(clip.WrappedId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemSingle__SystemVoid(global::UnityEngine.AudioClip clip, global::UnityEngine.Vector3 position, float volume)
        {
            UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemSingle__SystemVoid(clip.WrappedId, Unsafe.AsPointer(ref position), volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__SetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve__SystemVoid(long selfObjectId, global::UnityEngine.AudioSourceCurveType type, global::UnityEngine.AnimationCurve curve)
        {
            UnityEngineAudioSource__func__SetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve__SystemVoid(selfObjectId, (int) type, curve.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationCurve internal_UnityEngineAudioSource__func__GetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve(long selfObjectId, global::UnityEngine.AudioSourceCurveType type)
        {
            var methodCallResult = UnityEngineAudioSource__func__GetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve(selfObjectId, (int) type);
            var returnResult = new global::UnityEngine.AnimationCurve(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(long selfObjectId, global::System.Single[] samples, int channel)
        {
            fixed (float* samplesPointer = samples)
            {
                UnityEngineAudioSource__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(selfObjectId, samplesPointer, samples.Length, channel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioSource__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(long selfObjectId, global::System.Single[] samples, int channel, global::UnityEngine.FFTWindow window)
        {
            fixed (float* samplesPointer = samples)
            {
                UnityEngineAudioSource__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(selfObjectId, samplesPointer, samples.Length, channel, (int) window);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__func__SetSpatializerFloat__SystemInt32__SystemSingle__SystemBoolean(long selfObjectId, int index, float value)
        {
            var methodCallResult = UnityEngineAudioSource__func__SetSpatializerFloat__SystemInt32__SystemSingle__SystemBoolean(selfObjectId, index, value);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__func__GetSpatializerFloat__SystemInt32__SystemSingleRef__SystemBoolean(long selfObjectId, int index, out float value)
        {
            value = default;
            var methodCallResult = UnityEngineAudioSource__func__GetSpatializerFloat__SystemInt32__SystemSingleRef__SystemBoolean(selfObjectId, index, Unsafe.AsPointer(ref value));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__func__GetAmbisonicDecoderFloat__SystemInt32__SystemSingleRef__SystemBoolean(long selfObjectId, int index, out float value)
        {
            value = default;
            var methodCallResult = UnityEngineAudioSource__func__GetAmbisonicDecoderFloat__SystemInt32__SystemSingleRef__SystemBoolean(selfObjectId, index, Unsafe.AsPointer(ref value));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioSource__func__SetAmbisonicDecoderFloat__SystemInt32__SystemSingle__SystemBoolean(long selfObjectId, int index, float value)
        {
            var methodCallResult = UnityEngineAudioSource__func__SetAmbisonicDecoderFloat__SystemInt32__SystemSingle__SystemBoolean(selfObjectId, index, value);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__volume(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__volume(long selfObjectId, float volume);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__pitch(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__pitch(long selfObjectId, float pitch);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__time(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__time(long selfObjectId, float time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__timeSamples(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__timeSamples(long selfObjectId, int timeSamples);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioSource__get__clip(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__clip(long selfObjectId, long clipObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioSource__get__outputAudioMixerGroup(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__outputAudioMixerGroup(long selfObjectId, long outputAudioMixerGroupObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__isPlaying(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__isVirtual(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__loop(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__loop(long selfObjectId, int loopConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__ignoreListenerVolume(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__ignoreListenerVolume(long selfObjectId, int ignoreListenerVolumeConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__playOnAwake(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__playOnAwake(long selfObjectId, int playOnAwakeConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__ignoreListenerPause(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__ignoreListenerPause(long selfObjectId, int ignoreListenerPauseConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__velocityUpdateMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__velocityUpdateMode(long selfObjectId, int velocityUpdateModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__panStereo(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__panStereo(long selfObjectId, float panStereo);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__spatialBlend(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__spatialBlend(long selfObjectId, float spatialBlend);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__spatialize(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__spatialize(long selfObjectId, int spatializeConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__spatializePostEffects(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__spatializePostEffects(long selfObjectId, int spatializePostEffectsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__reverbZoneMix(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__reverbZoneMix(long selfObjectId, float reverbZoneMix);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__bypassEffects(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__bypassEffects(long selfObjectId, int bypassEffectsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__bypassListenerEffects(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__bypassListenerEffects(long selfObjectId, int bypassListenerEffectsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__bypassReverbZones(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__bypassReverbZones(long selfObjectId, int bypassReverbZonesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__dopplerLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__dopplerLevel(long selfObjectId, float dopplerLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__spread(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__spread(long selfObjectId, float spread);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__priority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__priority(long selfObjectId, int priority);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__mute(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__mute(long selfObjectId, int muteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__minDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__minDistance(long selfObjectId, float minDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAudioSource__get__maxDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__maxDistance(long selfObjectId, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__get__rolloffMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__set__rolloffMode(long selfObjectId, int rolloffModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__Play__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__Play__SystemUInt64__SystemVoid(long selfObjectId, long delayConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__PlayDelayed__SystemSingle__SystemVoid(long selfObjectId, float delay);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__PlayScheduled__SystemDouble__SystemVoid(long selfObjectId, double time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemVoid(long selfObjectId, long clipObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__PlayOneShot__UnityEngineAudioClip__SystemSingle__SystemVoid(long selfObjectId, long clipObjectId, float volumeScale);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__SetScheduledStartTime__SystemDouble__SystemVoid(long selfObjectId, double time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__SetScheduledEndTime__SystemDouble__SystemVoid(long selfObjectId, double time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__Stop__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__Pause__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__UnPause__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemVoid(long clipObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioSource__func__PlayClipAtPoint__UnityEngineAudioClip__UnityEngineVector3__SystemSingle__SystemVoid(long clipObjectId, void* positionPointer, float volume);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioSource__func__SetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve__SystemVoid(long selfObjectId, int typeUnderlyingValue, long curveObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioSource__func__GetCustomCurve__UnityEngineAudioSourceCurveTypeEnum__UnityEngineAnimationCurve(long selfObjectId, int typeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioSource__func__GetOutputData__SystemSingleArray__SystemInt32__SystemVoid(long selfObjectId, void* samplesPointer, int samplesWasmLength, int channel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioSource__func__GetSpectrumData__SystemSingleArray__SystemInt32__UnityEngineFFTWindowEnum__SystemVoid(long selfObjectId, void* samplesPointer, int samplesWasmLength, int channel, int windowUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__func__SetSpatializerFloat__SystemInt32__SystemSingle__SystemBoolean(long selfObjectId, int index, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioSource__func__GetSpatializerFloat__SystemInt32__SystemSingleRef__SystemBoolean(long selfObjectId, int index, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioSource__func__GetAmbisonicDecoderFloat__SystemInt32__SystemSingleRef__SystemBoolean(long selfObjectId, int index, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioSource__func__SetAmbisonicDecoderFloat__SystemInt32__SystemSingle__SystemBoolean(long selfObjectId, int index, float value);

        #endregion Imports
    }
}
