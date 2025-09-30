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

    public partial class CapsuleCollider(long id) : Collider(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineCapsuleCollider__get__center(WrappedId);
            set => internal_UnityEngineCapsuleCollider__set__center(WrappedId, value);
        }

        public float radius 
        {
            get => internal_UnityEngineCapsuleCollider__get__radius(WrappedId);
            set => internal_UnityEngineCapsuleCollider__set__radius(WrappedId, value);
        }

        public float height 
        {
            get => internal_UnityEngineCapsuleCollider__get__height(WrappedId);
            set => internal_UnityEngineCapsuleCollider__set__height(WrappedId, value);
        }

        public int direction 
        {
            get => internal_UnityEngineCapsuleCollider__get__direction(WrappedId);
            set => internal_UnityEngineCapsuleCollider__set__direction(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCapsuleCollider__get__center(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineCapsuleCollider__get__center(selfObjectId, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCapsuleCollider__set__center(long selfObjectId, global::UnityEngine.Vector3 center)
        {
            UnityEngineCapsuleCollider__set__center(selfObjectId, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCapsuleCollider__get__radius(long selfObjectId)
        {
            var methodCallResult = UnityEngineCapsuleCollider__get__radius(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCapsuleCollider__set__radius(long selfObjectId, float radius)
        {
            UnityEngineCapsuleCollider__set__radius(selfObjectId, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCapsuleCollider__get__height(long selfObjectId)
        {
            var methodCallResult = UnityEngineCapsuleCollider__get__height(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCapsuleCollider__set__height(long selfObjectId, float height)
        {
            UnityEngineCapsuleCollider__set__height(selfObjectId, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCapsuleCollider__get__direction(long selfObjectId)
        {
            var methodCallResult = UnityEngineCapsuleCollider__get__direction(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCapsuleCollider__set__direction(long selfObjectId, int direction)
        {
            UnityEngineCapsuleCollider__set__direction(selfObjectId, direction);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCapsuleCollider__get__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCapsuleCollider__set__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCapsuleCollider__get__radius(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCapsuleCollider__set__radius(long selfObjectId, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCapsuleCollider__get__height(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCapsuleCollider__set__height(long selfObjectId, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCapsuleCollider__get__direction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCapsuleCollider__set__direction(long selfObjectId, int direction);

        #endregion Imports
    }
}
