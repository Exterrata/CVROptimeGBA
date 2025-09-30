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

    public partial class BoxCollider(long id) : Collider(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineBoxCollider__get__center(WrappedId);
            set => internal_UnityEngineBoxCollider__set__center(WrappedId, value);
        }

        public global::UnityEngine.Vector3 size 
        {
            get => internal_UnityEngineBoxCollider__get__size(WrappedId);
            set => internal_UnityEngineBoxCollider__set__size(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBoxCollider__get__center(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineBoxCollider__get__center(selfObjectId, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoxCollider__set__center(long selfObjectId, global::UnityEngine.Vector3 center)
        {
            UnityEngineBoxCollider__set__center(selfObjectId, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBoxCollider__get__size(long selfObjectId)
        {
            global::UnityEngine.Vector3 sizeValue = default;
            UnityEngineBoxCollider__get__size(selfObjectId, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector3 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoxCollider__set__size(long selfObjectId, global::UnityEngine.Vector3 size)
        {
            UnityEngineBoxCollider__set__size(selfObjectId, Unsafe.AsPointer(ref size));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoxCollider__get__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoxCollider__set__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoxCollider__get__size(long selfObjectId, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoxCollider__set__size(long selfObjectId, void* sizePointer);

        #endregion Imports
    }
}
