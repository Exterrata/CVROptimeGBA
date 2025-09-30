//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Audio
{

    public partial class AudioMixerSnapshot(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.Audio.AudioMixer audioMixer 
        {
            get => internal_UnityEngineAudioAudioMixerSnapshot__get__audioMixer(WrappedId);
        }

        public void TransitionTo(float timeToReach)
        {
            internal_UnityEngineAudioAudioMixerSnapshot__func__TransitionTo__SystemSingle__SystemVoid(WrappedId, timeToReach);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixer internal_UnityEngineAudioAudioMixerSnapshot__get__audioMixer(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioAudioMixerSnapshot__get__audioMixer(selfObjectId);
            var returnResult = new global::UnityEngine.Audio.AudioMixer(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioAudioMixerSnapshot__func__TransitionTo__SystemSingle__SystemVoid(long selfObjectId, float timeToReach)
        {
            UnityEngineAudioAudioMixerSnapshot__func__TransitionTo__SystemSingle__SystemVoid(selfObjectId, timeToReach);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioAudioMixerSnapshot__get__audioMixer(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioAudioMixerSnapshot__func__TransitionTo__SystemSingle__SystemVoid(long selfObjectId, float timeToReach);

        #endregion Imports
    }
}
