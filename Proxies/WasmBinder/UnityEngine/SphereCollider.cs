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

    public partial class SphereCollider(long id) : Collider(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineSphereCollider__get__center(WrappedId);
            set => internal_UnityEngineSphereCollider__set__center(WrappedId, value);
        }

        public float radius 
        {
            get => internal_UnityEngineSphereCollider__get__radius(WrappedId);
            set => internal_UnityEngineSphereCollider__set__radius(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineSphereCollider__get__center(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineSphereCollider__get__center(selfObjectId, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSphereCollider__set__center(long selfObjectId, global::UnityEngine.Vector3 center)
        {
            UnityEngineSphereCollider__set__center(selfObjectId, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineSphereCollider__get__radius(long selfObjectId)
        {
            var methodCallResult = UnityEngineSphereCollider__get__radius(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSphereCollider__set__radius(long selfObjectId, float radius)
        {
            UnityEngineSphereCollider__set__radius(selfObjectId, radius);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSphereCollider__get__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSphereCollider__set__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineSphereCollider__get__radius(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSphereCollider__set__radius(long selfObjectId, float radius);

        #endregion Imports
    }
}
