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

    public partial class Avatar(long id) : Object(id)
    {

        #region Implementation

        public bool isValid 
        {
            get => internal_UnityEngineAvatar__get__isValid(WrappedId);
        }

        public bool isHuman 
        {
            get => internal_UnityEngineAvatar__get__isHuman(WrappedId);
        }

        public global::UnityEngine.HumanDescription humanDescription 
        {
            get => internal_UnityEngineAvatar__get__humanDescription(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAvatar__get__isValid(long selfObjectId)
        {
            var methodCallResult = UnityEngineAvatar__get__isValid(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAvatar__get__isHuman(long selfObjectId)
        {
            var methodCallResult = UnityEngineAvatar__get__isHuman(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.HumanDescription internal_UnityEngineAvatar__get__humanDescription(long selfObjectId)
        {
            var methodCallResult = UnityEngineAvatar__get__humanDescription(selfObjectId);
            var returnResult = new global::UnityEngine.HumanDescription(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAvatar__get__isValid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAvatar__get__isHuman(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAvatar__get__humanDescription(long selfObjectId);

        #endregion Imports
    }
}
