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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct AnimatorClipInfo
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_ClipInstanceID;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float m_Weight;

        public global::UnityEngine.AnimationClip clip 
        {
            get => internal_UnityEngineAnimatorClipInfo__get__clip(ref this);
        }

        public float weight 
        {
            get => internal_UnityEngineAnimatorClipInfo__get__weight(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationClip internal_UnityEngineAnimatorClipInfo__get__clip(ref global::UnityEngine.AnimatorClipInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorClipInfo__get__clip(selfStructPointer);
            var returnResult = new global::UnityEngine.AnimationClip(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorClipInfo__get__weight(ref global::UnityEngine.AnimatorClipInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorClipInfo__get__weight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAnimatorClipInfo__get__clip(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorClipInfo__get__weight(void* selfStructPointer);

        #endregion Imports
    }
}
