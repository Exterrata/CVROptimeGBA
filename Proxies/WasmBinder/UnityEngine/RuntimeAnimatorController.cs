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

    public partial class RuntimeAnimatorController(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.AnimationClip[] animationClips 
        {
            get => internal_UnityEngineRuntimeAnimatorController__get__animationClips(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationClip[] internal_UnityEngineRuntimeAnimatorController__get__animationClips(long selfObjectId)
        {
            long* animationClipsIdsPointer = default;
            int animationClipsWasmLength = default;
            UnityEngineRuntimeAnimatorController__get__animationClips(selfObjectId, &animationClipsIdsPointer, &animationClipsWasmLength);
            global::UnityEngine.AnimationClip[] returnResult = new global::UnityEngine.AnimationClip[animationClipsWasmLength];
            for (int i = 0; i < animationClipsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.AnimationClip(animationClipsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)animationClipsIdsPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRuntimeAnimatorController__get__animationClips(long selfObjectId, void* animationClipsIdsPointer, void* animationClipsWasmLengthPointer);

        #endregion Imports
    }
}
