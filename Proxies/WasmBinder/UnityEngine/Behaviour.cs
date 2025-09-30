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

    public partial class Behaviour(long id) : Component(id)
    {

        #region Implementation

        public bool enabled 
        {
            get => internal_UnityEngineBehaviour__get__enabled(WrappedId);
            set => internal_UnityEngineBehaviour__set__enabled(WrappedId, value);
        }

        public bool isActiveAndEnabled 
        {
            get => internal_UnityEngineBehaviour__get__isActiveAndEnabled(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBehaviour__get__enabled(long selfObjectId)
        {
            var methodCallResult = UnityEngineBehaviour__get__enabled(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBehaviour__set__enabled(long selfObjectId, bool enabled)
        {
            var enabledConverted = Unsafe.As<bool, int>(ref enabled);
            UnityEngineBehaviour__set__enabled(selfObjectId, enabledConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBehaviour__get__isActiveAndEnabled(long selfObjectId)
        {
            var methodCallResult = UnityEngineBehaviour__get__isActiveAndEnabled(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineBehaviour__get__enabled(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineBehaviour__set__enabled(long selfObjectId, int enabledConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineBehaviour__get__isActiveAndEnabled(long selfObjectId);

        #endregion Imports
    }
}
