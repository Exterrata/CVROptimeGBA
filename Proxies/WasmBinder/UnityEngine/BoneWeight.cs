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
    public partial struct BoneWeight
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private float m_Weight0;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float m_Weight1;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private float m_Weight2;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_Weight3;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private int m_BoneIndex0;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private int m_BoneIndex1;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private int m_BoneIndex2;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private int m_BoneIndex3;

        public float weight0 
        {
            get => internal_UnityEngineBoneWeight__get__weight0(ref this);
            set => internal_UnityEngineBoneWeight__set__weight0(ref this, value);
        }

        public float weight1 
        {
            get => internal_UnityEngineBoneWeight__get__weight1(ref this);
            set => internal_UnityEngineBoneWeight__set__weight1(ref this, value);
        }

        public float weight2 
        {
            get => internal_UnityEngineBoneWeight__get__weight2(ref this);
            set => internal_UnityEngineBoneWeight__set__weight2(ref this, value);
        }

        public float weight3 
        {
            get => internal_UnityEngineBoneWeight__get__weight3(ref this);
            set => internal_UnityEngineBoneWeight__set__weight3(ref this, value);
        }

        public int boneIndex0 
        {
            get => internal_UnityEngineBoneWeight__get__boneIndex0(ref this);
            set => internal_UnityEngineBoneWeight__set__boneIndex0(ref this, value);
        }

        public int boneIndex1 
        {
            get => internal_UnityEngineBoneWeight__get__boneIndex1(ref this);
            set => internal_UnityEngineBoneWeight__set__boneIndex1(ref this, value);
        }

        public int boneIndex2 
        {
            get => internal_UnityEngineBoneWeight__get__boneIndex2(ref this);
            set => internal_UnityEngineBoneWeight__set__boneIndex2(ref this, value);
        }

        public int boneIndex3 
        {
            get => internal_UnityEngineBoneWeight__get__boneIndex3(ref this);
            set => internal_UnityEngineBoneWeight__set__boneIndex3(ref this, value);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineBoneWeight__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineBoneWeight__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.BoneWeight other)
        {
            return internal_UnityEngineBoneWeight__func__Equals__UnityEngineBoneWeight__SystemBoolean(ref this, other);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBoneWeight__get__weight0(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__weight0(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__weight0(ref global::UnityEngine.BoneWeight selfStruct, float weight0)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__weight0(selfStructPointer, weight0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBoneWeight__get__weight1(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__weight1(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__weight1(ref global::UnityEngine.BoneWeight selfStruct, float weight1)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__weight1(selfStructPointer, weight1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBoneWeight__get__weight2(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__weight2(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__weight2(ref global::UnityEngine.BoneWeight selfStruct, float weight2)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__weight2(selfStructPointer, weight2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBoneWeight__get__weight3(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__weight3(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__weight3(ref global::UnityEngine.BoneWeight selfStruct, float weight3)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__weight3(selfStructPointer, weight3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight__get__boneIndex0(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__boneIndex0(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__boneIndex0(ref global::UnityEngine.BoneWeight selfStruct, int boneIndex0)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__boneIndex0(selfStructPointer, boneIndex0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight__get__boneIndex1(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__boneIndex1(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__boneIndex1(ref global::UnityEngine.BoneWeight selfStruct, int boneIndex1)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__boneIndex1(selfStructPointer, boneIndex1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight__get__boneIndex2(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__boneIndex2(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__boneIndex2(ref global::UnityEngine.BoneWeight selfStruct, int boneIndex2)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__boneIndex2(selfStructPointer, boneIndex2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight__get__boneIndex3(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__get__boneIndex3(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBoneWeight__set__boneIndex3(ref global::UnityEngine.BoneWeight selfStruct, int boneIndex3)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBoneWeight__set__boneIndex3(selfStructPointer, boneIndex3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBoneWeight__func__GetHashCode__SystemInt32(ref global::UnityEngine.BoneWeight selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBoneWeight__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.BoneWeight selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineBoneWeight__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBoneWeight__func__Equals__UnityEngineBoneWeight__SystemBoolean(ref global::UnityEngine.BoneWeight selfStruct, global::UnityEngine.BoneWeight other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBoneWeight__func__Equals__UnityEngineBoneWeight__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBoneWeight__get__weight0(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__weight0(void* selfStructPointer, float weight0);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBoneWeight__get__weight1(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__weight1(void* selfStructPointer, float weight1);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBoneWeight__get__weight2(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__weight2(void* selfStructPointer, float weight2);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBoneWeight__get__weight3(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__weight3(void* selfStructPointer, float weight3);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__get__boneIndex0(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__boneIndex0(void* selfStructPointer, int boneIndex0);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__get__boneIndex1(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__boneIndex1(void* selfStructPointer, int boneIndex1);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__get__boneIndex2(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__boneIndex2(void* selfStructPointer, int boneIndex2);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__get__boneIndex3(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBoneWeight__set__boneIndex3(void* selfStructPointer, int boneIndex3);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBoneWeight__func__Equals__UnityEngineBoneWeight__SystemBoolean(void* selfStructPointer, void* otherPointer);

        #endregion Imports
    }
}
