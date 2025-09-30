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
    public partial struct Hash128
    {

        #region Implementation

        public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
        {
            internal_UnityEngineHash128__ctor__SystemUInt32__SystemUInt32__SystemUInt32__SystemUInt32(ref this, u32_0, u32_1, u32_2, u32_3);
        }

        public Hash128(ulong u64_0, ulong u64_1)
        {
            internal_UnityEngineHash128__ctor__SystemUInt64__SystemUInt64(ref this, u64_0, u64_1);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal ulong u64_0;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        internal ulong u64_1;

        public bool isValid 
        {
            get => internal_UnityEngineHash128__get__isValid(ref this);
        }

        public int CompareTo(global::UnityEngine.Hash128 rhs)
        {
            return internal_UnityEngineHash128__func__CompareTo__UnityEngineHash128__SystemInt32(ref this, rhs);
        }

        public string ToString()
        {
            return internal_UnityEngineHash128__func__ToString__SystemString(ref this);
        }

        public static global::UnityEngine.Hash128 Parse(string hashString)
        {
            return internal_UnityEngineHash128__func__Parse__SystemString__UnityEngineHash128(hashString);
        }

        public static global::UnityEngine.Hash128 Compute(string data)
        {
            return internal_UnityEngineHash128__func__Compute__SystemString__UnityEngineHash128(data);
        }

        public static global::UnityEngine.Hash128 Compute(int val)
        {
            return internal_UnityEngineHash128__func__Compute__SystemInt32__UnityEngineHash128(val);
        }

        public static global::UnityEngine.Hash128 Compute(float val)
        {
            return internal_UnityEngineHash128__func__Compute__SystemSingle__UnityEngineHash128(val);
        }

        public void Append(string data)
        {
            internal_UnityEngineHash128__func__Append__SystemString__SystemVoid(ref this, data);
        }

        public void Append(int val)
        {
            internal_UnityEngineHash128__func__Append__SystemInt32__SystemVoid(ref this, val);
        }

        public void Append(float val)
        {
            internal_UnityEngineHash128__func__Append__SystemSingle__SystemVoid(ref this, val);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEngineHash128__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public bool Equals(global::UnityEngine.Hash128 obj)
        {
            return internal_UnityEngineHash128__func__Equals__UnityEngineHash128__SystemBoolean(ref this, obj);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineHash128__func__GetHashCode__SystemInt32(ref this);
        }

        public int CompareTo(object obj)
        {
            return internal_UnityEngineHash128__func__CompareTo__SystemObject__SystemInt32(ref this, obj);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHash128__ctor__SystemUInt32__SystemUInt32__SystemUInt32__SystemUInt32(ref global::UnityEngine.Hash128 selfStruct, uint u32_0, uint u32_1, uint u32_2, uint u32_3)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var u32_0Converted = Unsafe.As<uint, int>(ref u32_0);
            var u32_1Converted = Unsafe.As<uint, int>(ref u32_1);
            var u32_2Converted = Unsafe.As<uint, int>(ref u32_2);
            var u32_3Converted = Unsafe.As<uint, int>(ref u32_3);
            UnityEngineHash128__ctor__SystemUInt32__SystemUInt32__SystemUInt32__SystemUInt32(selfStructPointer, u32_0Converted, u32_1Converted, u32_2Converted, u32_3Converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHash128__ctor__SystemUInt64__SystemUInt64(ref global::UnityEngine.Hash128 selfStruct, ulong u64_0, ulong u64_1)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var u64_0Converted = Unsafe.As<ulong, long>(ref u64_0);
            var u64_1Converted = Unsafe.As<ulong, long>(ref u64_1);
            UnityEngineHash128__ctor__SystemUInt64__SystemUInt64(selfStructPointer, u64_0Converted, u64_1Converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineHash128__get__isValid(ref global::UnityEngine.Hash128 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHash128__get__isValid(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineHash128__func__CompareTo__UnityEngineHash128__SystemInt32(ref global::UnityEngine.Hash128 selfStruct, global::UnityEngine.Hash128 rhs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHash128__func__CompareTo__UnityEngineHash128__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref rhs));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineHash128__func__ToString__SystemString(ref global::UnityEngine.Hash128 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineHash128__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Hash128 internal_UnityEngineHash128__func__Parse__SystemString__UnityEngineHash128(string hashString)
        {
            fixed (char* hashStringPointer = hashString)
            {
                global::UnityEngine.Hash128 returnResultValue = default;
                UnityEngineHash128__func__Parse__SystemString__UnityEngineHash128(hashStringPointer, hashString.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Hash128 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Hash128 internal_UnityEngineHash128__func__Compute__SystemString__UnityEngineHash128(string data)
        {
            fixed (char* dataPointer = data)
            {
                global::UnityEngine.Hash128 returnResultValue = default;
                UnityEngineHash128__func__Compute__SystemString__UnityEngineHash128(dataPointer, data.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Hash128 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Hash128 internal_UnityEngineHash128__func__Compute__SystemInt32__UnityEngineHash128(int val)
        {
            global::UnityEngine.Hash128 returnResultValue = default;
            UnityEngineHash128__func__Compute__SystemInt32__UnityEngineHash128(val, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Hash128 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Hash128 internal_UnityEngineHash128__func__Compute__SystemSingle__UnityEngineHash128(float val)
        {
            global::UnityEngine.Hash128 returnResultValue = default;
            UnityEngineHash128__func__Compute__SystemSingle__UnityEngineHash128(val, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Hash128 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHash128__func__Append__SystemString__SystemVoid(ref global::UnityEngine.Hash128 selfStruct, string data)
        {
            fixed (char* dataPointer = data)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineHash128__func__Append__SystemString__SystemVoid(selfStructPointer, dataPointer, data.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHash128__func__Append__SystemInt32__SystemVoid(ref global::UnityEngine.Hash128 selfStruct, int val)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHash128__func__Append__SystemInt32__SystemVoid(selfStructPointer, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHash128__func__Append__SystemSingle__SystemVoid(ref global::UnityEngine.Hash128 selfStruct, float val)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHash128__func__Append__SystemSingle__SystemVoid(selfStructPointer, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineHash128__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Hash128 selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineHash128__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineHash128__func__Equals__UnityEngineHash128__SystemBoolean(ref global::UnityEngine.Hash128 selfStruct, global::UnityEngine.Hash128 obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHash128__func__Equals__UnityEngineHash128__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref obj));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineHash128__func__GetHashCode__SystemInt32(ref global::UnityEngine.Hash128 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHash128__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineHash128__func__CompareTo__SystemObject__SystemInt32(ref global::UnityEngine.Hash128 selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineHash128__func__CompareTo__SystemObject__SystemInt32(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__ctor__SystemUInt32__SystemUInt32__SystemUInt32__SystemUInt32(void* selfStructPointer, int u32_0Converted, int u32_1Converted, int u32_2Converted, int u32_3Converted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__ctor__SystemUInt64__SystemUInt64(void* selfStructPointer, long u64_0Converted, long u64_1Converted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__get__isValid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__func__CompareTo__UnityEngineHash128__SystemInt32(void* selfStructPointer, void* rhsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Parse__SystemString__UnityEngineHash128(void* hashStringPointer, int hashStringWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Compute__SystemString__UnityEngineHash128(void* dataPointer, int dataWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Compute__SystemInt32__UnityEngineHash128(int val, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Compute__SystemSingle__UnityEngineHash128(float val, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Append__SystemString__SystemVoid(void* selfStructPointer, void* dataPointer, int dataWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Append__SystemInt32__SystemVoid(void* selfStructPointer, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHash128__func__Append__SystemSingle__SystemVoid(void* selfStructPointer, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__func__Equals__UnityEngineHash128__SystemBoolean(void* selfStructPointer, void* objPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHash128__func__CompareTo__SystemObject__SystemInt32(void* selfStructPointer, long objObjectId);

        #endregion Imports
    }
}
