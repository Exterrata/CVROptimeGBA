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
    public partial struct Vector2Int
    {

        #region Implementation

        public Vector2Int(int x, int y)
        {
            internal_UnityEngineVector2Int__ctor__SystemInt32__SystemInt32(ref this, x, y);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_X;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_Y;

        public int x 
        {
            get => internal_UnityEngineVector2Int__get__x(ref this);
            set => internal_UnityEngineVector2Int__set__x(ref this, value);
        }

        public int y 
        {
            get => internal_UnityEngineVector2Int__get__y(ref this);
            set => internal_UnityEngineVector2Int__set__y(ref this, value);
        }

        public float magnitude 
        {
            get => internal_UnityEngineVector2Int__get__magnitude(ref this);
        }

        public int sqrMagnitude 
        {
            get => internal_UnityEngineVector2Int__get__sqrMagnitude(ref this);
        }

        public static global::UnityEngine.Vector2Int zero 
        {
            get => internal_UnityEngineVector2Int__get__zero();
        }

        public static global::UnityEngine.Vector2Int one 
        {
            get => internal_UnityEngineVector2Int__get__one();
        }

        public static global::UnityEngine.Vector2Int up 
        {
            get => internal_UnityEngineVector2Int__get__up();
        }

        public static global::UnityEngine.Vector2Int down 
        {
            get => internal_UnityEngineVector2Int__get__down();
        }

        public static global::UnityEngine.Vector2Int left 
        {
            get => internal_UnityEngineVector2Int__get__left();
        }

        public static global::UnityEngine.Vector2Int right 
        {
            get => internal_UnityEngineVector2Int__get__right();
        }

        public void Set(int x, int y)
        {
            internal_UnityEngineVector2Int__func__Set__SystemInt32__SystemInt32__SystemVoid(ref this, x, y);
        }

        public static float Distance(global::UnityEngine.Vector2Int a, global::UnityEngine.Vector2Int b)
        {
            return internal_UnityEngineVector2Int__func__Distance__UnityEngineVector2Int__UnityEngineVector2Int__SystemSingle(a, b);
        }

        public static global::UnityEngine.Vector2Int Min(global::UnityEngine.Vector2Int lhs, global::UnityEngine.Vector2Int rhs)
        {
            return internal_UnityEngineVector2Int__func__Min__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(lhs, rhs);
        }

        public static global::UnityEngine.Vector2Int Max(global::UnityEngine.Vector2Int lhs, global::UnityEngine.Vector2Int rhs)
        {
            return internal_UnityEngineVector2Int__func__Max__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(lhs, rhs);
        }

        public static global::UnityEngine.Vector2Int Scale(global::UnityEngine.Vector2Int a, global::UnityEngine.Vector2Int b)
        {
            return internal_UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(a, b);
        }

        public void Scale(global::UnityEngine.Vector2Int scale)
        {
            internal_UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__SystemVoid(ref this, scale);
        }

        public void Clamp(global::UnityEngine.Vector2Int min, global::UnityEngine.Vector2Int max)
        {
            internal_UnityEngineVector2Int__func__Clamp__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(ref this, min, max);
        }

        public static global::UnityEngine.Vector2Int FloorToInt(global::UnityEngine.Vector2 v)
        {
            return internal_UnityEngineVector2Int__func__FloorToInt__UnityEngineVector2__UnityEngineVector2Int(v);
        }

        public static global::UnityEngine.Vector2Int CeilToInt(global::UnityEngine.Vector2 v)
        {
            return internal_UnityEngineVector2Int__func__CeilToInt__UnityEngineVector2__UnityEngineVector2Int(v);
        }

        public static global::UnityEngine.Vector2Int RoundToInt(global::UnityEngine.Vector2 v)
        {
            return internal_UnityEngineVector2Int__func__RoundToInt__UnityEngineVector2__UnityEngineVector2Int(v);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineVector2Int__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Vector2Int other)
        {
            return internal_UnityEngineVector2Int__func__Equals__UnityEngineVector2Int__SystemBoolean(ref this, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineVector2Int__func__GetHashCode__SystemInt32(ref this);
        }

        public string ToString()
        {
            return internal_UnityEngineVector2Int__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineVector2Int__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineVector2Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__ctor__SystemInt32__SystemInt32(ref global::UnityEngine.Vector2Int selfStruct, int x, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__ctor__SystemInt32__SystemInt32(selfStructPointer, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector2Int__get__x(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__get__x(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__set__x(ref global::UnityEngine.Vector2Int selfStruct, int x)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__set__x(selfStructPointer, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector2Int__get__y(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__get__y(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__set__y(ref global::UnityEngine.Vector2Int selfStruct, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__set__y(selfStructPointer, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineVector2Int__get__magnitude(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__get__magnitude(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector2Int__get__sqrMagnitude(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__get__sqrMagnitude(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__zero()
        {
            global::UnityEngine.Vector2Int zeroValue = default;
            UnityEngineVector2Int__get__zero(Unsafe.AsPointer(ref zeroValue));
            global::UnityEngine.Vector2Int returnResult = zeroValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__one()
        {
            global::UnityEngine.Vector2Int oneValue = default;
            UnityEngineVector2Int__get__one(Unsafe.AsPointer(ref oneValue));
            global::UnityEngine.Vector2Int returnResult = oneValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__up()
        {
            global::UnityEngine.Vector2Int upValue = default;
            UnityEngineVector2Int__get__up(Unsafe.AsPointer(ref upValue));
            global::UnityEngine.Vector2Int returnResult = upValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__down()
        {
            global::UnityEngine.Vector2Int downValue = default;
            UnityEngineVector2Int__get__down(Unsafe.AsPointer(ref downValue));
            global::UnityEngine.Vector2Int returnResult = downValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__left()
        {
            global::UnityEngine.Vector2Int leftValue = default;
            UnityEngineVector2Int__get__left(Unsafe.AsPointer(ref leftValue));
            global::UnityEngine.Vector2Int returnResult = leftValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__get__right()
        {
            global::UnityEngine.Vector2Int rightValue = default;
            UnityEngineVector2Int__get__right(Unsafe.AsPointer(ref rightValue));
            global::UnityEngine.Vector2Int returnResult = rightValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__func__Set__SystemInt32__SystemInt32__SystemVoid(ref global::UnityEngine.Vector2Int selfStruct, int x, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__func__Set__SystemInt32__SystemInt32__SystemVoid(selfStructPointer, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineVector2Int__func__Distance__UnityEngineVector2Int__UnityEngineVector2Int__SystemSingle(global::UnityEngine.Vector2Int a, global::UnityEngine.Vector2Int b)
        {
            var methodCallResult = UnityEngineVector2Int__func__Distance__UnityEngineVector2Int__UnityEngineVector2Int__SystemSingle(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__Min__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(global::UnityEngine.Vector2Int lhs, global::UnityEngine.Vector2Int rhs)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__Min__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(Unsafe.AsPointer(ref lhs), Unsafe.AsPointer(ref rhs), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__Max__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(global::UnityEngine.Vector2Int lhs, global::UnityEngine.Vector2Int rhs)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__Max__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(Unsafe.AsPointer(ref lhs), Unsafe.AsPointer(ref rhs), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(global::UnityEngine.Vector2Int a, global::UnityEngine.Vector2Int b)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__SystemVoid(ref global::UnityEngine.Vector2Int selfStruct, global::UnityEngine.Vector2Int scale)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector2Int__func__Clamp__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(ref global::UnityEngine.Vector2Int selfStruct, global::UnityEngine.Vector2Int min, global::UnityEngine.Vector2Int max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector2Int__func__Clamp__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref min), Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__FloorToInt__UnityEngineVector2__UnityEngineVector2Int(global::UnityEngine.Vector2 v)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__FloorToInt__UnityEngineVector2__UnityEngineVector2Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__CeilToInt__UnityEngineVector2__UnityEngineVector2Int(global::UnityEngine.Vector2 v)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__CeilToInt__UnityEngineVector2__UnityEngineVector2Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineVector2Int__func__RoundToInt__UnityEngineVector2__UnityEngineVector2Int(global::UnityEngine.Vector2 v)
        {
            global::UnityEngine.Vector2Int returnResultValue = default;
            UnityEngineVector2Int__func__RoundToInt__UnityEngineVector2__UnityEngineVector2Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineVector2Int__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Vector2Int selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineVector2Int__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineVector2Int__func__Equals__UnityEngineVector2Int__SystemBoolean(ref global::UnityEngine.Vector2Int selfStruct, global::UnityEngine.Vector2Int other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__func__Equals__UnityEngineVector2Int__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector2Int__func__GetHashCode__SystemInt32(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector2Int__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector2Int__func__ToString__SystemString(ref global::UnityEngine.Vector2Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineVector2Int__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector2Int__func__ToString__SystemString__SystemString(ref global::UnityEngine.Vector2Int selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector2Int__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector2Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Vector2Int selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector2Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__ctor__SystemInt32__SystemInt32(void* selfStructPointer, int x, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__get__x(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__set__x(void* selfStructPointer, int x);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__get__y(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__set__y(void* selfStructPointer, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineVector2Int__get__magnitude(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__get__sqrMagnitude(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__zero(void* zeroPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__one(void* onePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__up(void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__down(void* downPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__left(void* leftPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__get__right(void* rightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Set__SystemInt32__SystemInt32__SystemVoid(void* selfStructPointer, int x, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineVector2Int__func__Distance__UnityEngineVector2Int__UnityEngineVector2Int__SystemSingle(void* aPointer, void* bPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Min__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(void* lhsPointer, void* rhsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Max__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(void* lhsPointer, void* rhsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__UnityEngineVector2Int__UnityEngineVector2Int(void* aPointer, void* bPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Scale__UnityEngineVector2Int__SystemVoid(void* selfStructPointer, void* scalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__Clamp__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(void* selfStructPointer, void* minPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__FloorToInt__UnityEngineVector2__UnityEngineVector2Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__CeilToInt__UnityEngineVector2__UnityEngineVector2Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__RoundToInt__UnityEngineVector2__UnityEngineVector2Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__func__Equals__UnityEngineVector2Int__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector2Int__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector2Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
