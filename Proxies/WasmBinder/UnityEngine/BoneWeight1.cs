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
    public partial struct BoneWeight1
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private float m_Weight;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_BoneIndex;

        public float weight 
        {
            get => internal_UnityEngineBoneWeight1__get__weight(ref this);
            set => internal_UnityEngineBoneWeight1__set__weight(ref this, value);
        }

        public int boneIndex 
        {
            get => internal_UnityEngineBoneWeight1__get__boneIndex(ref this);
            set => internal_UnityEngineBoneWeight1__set__boneIndex(ref this, value);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineBoneWeight1__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.BoneWeight1 other)
        {
            return internal_UnityEngineBoneWeight1__func__Equals__UnityEngineBoneWeight1__SystemBoolean(ref this, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineBoneWeight1__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBoneWeight1__get__weight(ref global::UnityEngine.BoneWeight1 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight1__get__weight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight1__set__weight(ref global::UnityEngine.BoneWeight1 selfStruct, float weight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight1__set__weight(selfStructPointer, weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight1__get__boneIndex(ref global::UnityEngine.BoneWeight1 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight1__get__boneIndex(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight1__set__boneIndex(ref global::UnityEngine.BoneWeight1 selfStruct, int boneIndex)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight1__set__boneIndex(selfStructPointer, boneIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBoneWeight1__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.BoneWeight1 selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineBoneWeight1__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBoneWeight1__func__Equals__UnityEngineBoneWeight1__SystemBoolean(ref global::UnityEngine.BoneWeight1 selfStruct, global::UnityEngine.BoneWeight1 other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight1__func__Equals__UnityEngineBoneWeight1__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight1__func__GetHashCode__SystemInt32(ref global::UnityEngine.BoneWeight1 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight1__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBoneWeight1__get__weight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight1__set__weight(void* selfStructPointer, float weight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight1__get__boneIndex(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight1__set__boneIndex(void* selfStructPointer, int boneIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight1__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight1__func__Equals__UnityEngineBoneWeight1__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight1__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
