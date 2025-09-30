//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.EventSystems
{

    public partial class UIBehaviour(long id) : MonoBehaviour(id)
    {

        #region Implementation

        public bool IsActive()
        {
            return internal_UnityEngineEventSystemsUIBehaviour__func__IsActive__SystemBoolean(WrappedId);
        }

        public bool IsDestroyed()
        {
            return internal_UnityEngineEventSystemsUIBehaviour__func__IsDestroyed__SystemBoolean(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineEventSystemsUIBehaviour__func__IsActive__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineEventSystemsUIBehaviour__func__IsActive__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineEventSystemsUIBehaviour__func__IsDestroyed__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineEventSystemsUIBehaviour__func__IsDestroyed__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineEventSystemsUIBehaviour__func__IsActive__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineEventSystemsUIBehaviour__func__IsDestroyed__SystemBoolean(long selfObjectId);

        #endregion Imports
    }
}
