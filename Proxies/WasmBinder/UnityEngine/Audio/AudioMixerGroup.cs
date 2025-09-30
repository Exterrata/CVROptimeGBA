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

    public partial class AudioMixerGroup(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.Audio.AudioMixer audioMixer 
        {
            get => internal_UnityEngineAudioAudioMixerGroup__get__audioMixer(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixer internal_UnityEngineAudioAudioMixerGroup__get__audioMixer(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioAudioMixerGroup__get__audioMixer(selfObjectId);
            var returnResult = new global::UnityEngine.Audio.AudioMixer(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioAudioMixerGroup__get__audioMixer(long selfObjectId);

        #endregion Imports
    }
}
