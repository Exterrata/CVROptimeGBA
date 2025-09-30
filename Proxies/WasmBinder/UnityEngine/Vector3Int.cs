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
    public partial struct Vector3Int
    {

        #region Implementation

        public Vector3Int(int x, int y)
        {
            internal_UnityEngineVector3Int__ctor__SystemInt32__SystemInt32(ref this, x, y);
        }

        public Vector3Int(int x, int y, int z)
        {
            internal_UnityEngineVector3Int__ctor__SystemInt32__SystemInt32__SystemInt32(ref this, x, y, z);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_X;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_Y;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_Z;

        public int x 
        {
            get => internal_UnityEngineVector3Int__get__x(ref this);
            set => internal_UnityEngineVector3Int__set__x(ref this, value);
        }

        public int y 
        {
            get => internal_UnityEngineVector3Int__get__y(ref this);
            set => internal_UnityEngineVector3Int__set__y(ref this, value);
        }

        public int z 
        {
            get => internal_UnityEngineVector3Int__get__z(ref this);
            set => internal_UnityEngineVector3Int__set__z(ref this, value);
        }

        public float magnitude 
        {
            get => internal_UnityEngineVector3Int__get__magnitude(ref this);
        }

        public int sqrMagnitude 
        {
            get => internal_UnityEngineVector3Int__get__sqrMagnitude(ref this);
        }

        public static global::UnityEngine.Vector3Int zero 
        {
            get => internal_UnityEngineVector3Int__get__zero();
        }

        public static global::UnityEngine.Vector3Int one 
        {
            get => internal_UnityEngineVector3Int__get__one();
        }

        public static global::UnityEngine.Vector3Int up 
        {
            get => internal_UnityEngineVector3Int__get__up();
        }

        public static global::UnityEngine.Vector3Int down 
        {
            get => internal_UnityEngineVector3Int__get__down();
        }

        public static global::UnityEngine.Vector3Int left 
        {
            get => internal_UnityEngineVector3Int__get__left();
        }

        public static global::UnityEngine.Vector3Int right 
        {
            get => internal_UnityEngineVector3Int__get__right();
        }

        public static global::UnityEngine.Vector3Int forward 
        {
            get => internal_UnityEngineVector3Int__get__forward();
        }

        public static global::UnityEngine.Vector3Int back 
        {
            get => internal_UnityEngineVector3Int__get__back();
        }

        public void Set(int x, int y, int z)
        {
            internal_UnityEngineVector3Int__func__Set__SystemInt32__SystemInt32__SystemInt32__SystemVoid(ref this, x, y, z);
        }

        public static float Distance(global::UnityEngine.Vector3Int a, global::UnityEngine.Vector3Int b)
        {
            return internal_UnityEngineVector3Int__func__Distance__UnityEngineVector3Int__UnityEngineVector3Int__SystemSingle(a, b);
        }

        public static global::UnityEngine.Vector3Int Min(global::UnityEngine.Vector3Int lhs, global::UnityEngine.Vector3Int rhs)
        {
            return internal_UnityEngineVector3Int__func__Min__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(lhs, rhs);
        }

        public static global::UnityEngine.Vector3Int Max(global::UnityEngine.Vector3Int lhs, global::UnityEngine.Vector3Int rhs)
        {
            return internal_UnityEngineVector3Int__func__Max__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(lhs, rhs);
        }

        public static global::UnityEngine.Vector3Int Scale(global::UnityEngine.Vector3Int a, global::UnityEngine.Vector3Int b)
        {
            return internal_UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(a, b);
        }

        public void Scale(global::UnityEngine.Vector3Int scale)
        {
            internal_UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__SystemVoid(ref this, scale);
        }

        public void Clamp(global::UnityEngine.Vector3Int min, global::UnityEngine.Vector3Int max)
        {
            internal_UnityEngineVector3Int__func__Clamp__UnityEngineVector3Int__UnityEngineVector3Int__SystemVoid(ref this, min, max);
        }

        public static global::UnityEngine.Vector3Int FloorToInt(global::UnityEngine.Vector3 v)
        {
            return internal_UnityEngineVector3Int__func__FloorToInt__UnityEngineVector3__UnityEngineVector3Int(v);
        }

        public static global::UnityEngine.Vector3Int CeilToInt(global::UnityEngine.Vector3 v)
        {
            return internal_UnityEngineVector3Int__func__CeilToInt__UnityEngineVector3__UnityEngineVector3Int(v);
        }

        public static global::UnityEngine.Vector3Int RoundToInt(global::UnityEngine.Vector3 v)
        {
            return internal_UnityEngineVector3Int__func__RoundToInt__UnityEngineVector3__UnityEngineVector3Int(v);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineVector3Int__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Vector3Int other)
        {
            return internal_UnityEngineVector3Int__func__Equals__UnityEngineVector3Int__SystemBoolean(ref this, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineVector3Int__func__GetHashCode__SystemInt32(ref this);
        }

        public string ToString()
        {
            return internal_UnityEngineVector3Int__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineVector3Int__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineVector3Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__ctor__SystemInt32__SystemInt32(ref global::UnityEngine.Vector3Int selfStruct, int x, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__ctor__SystemInt32__SystemInt32(selfStructPointer, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__ctor__SystemInt32__SystemInt32__SystemInt32(ref global::UnityEngine.Vector3Int selfStruct, int x, int y, int z)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__ctor__SystemInt32__SystemInt32__SystemInt32(selfStructPointer, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector3Int__get__x(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__get__x(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__set__x(ref global::UnityEngine.Vector3Int selfStruct, int x)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__set__x(selfStructPointer, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector3Int__get__y(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__get__y(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__set__y(ref global::UnityEngine.Vector3Int selfStruct, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__set__y(selfStructPointer, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector3Int__get__z(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__get__z(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__set__z(ref global::UnityEngine.Vector3Int selfStruct, int z)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__set__z(selfStructPointer, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineVector3Int__get__magnitude(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__get__magnitude(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector3Int__get__sqrMagnitude(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__get__sqrMagnitude(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__zero()
        {
            global::UnityEngine.Vector3Int zeroValue = default;
            UnityEngineVector3Int__get__zero(Unsafe.AsPointer(ref zeroValue));
            global::UnityEngine.Vector3Int returnResult = zeroValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__one()
        {
            global::UnityEngine.Vector3Int oneValue = default;
            UnityEngineVector3Int__get__one(Unsafe.AsPointer(ref oneValue));
            global::UnityEngine.Vector3Int returnResult = oneValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__up()
        {
            global::UnityEngine.Vector3Int upValue = default;
            UnityEngineVector3Int__get__up(Unsafe.AsPointer(ref upValue));
            global::UnityEngine.Vector3Int returnResult = upValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__down()
        {
            global::UnityEngine.Vector3Int downValue = default;
            UnityEngineVector3Int__get__down(Unsafe.AsPointer(ref downValue));
            global::UnityEngine.Vector3Int returnResult = downValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__left()
        {
            global::UnityEngine.Vector3Int leftValue = default;
            UnityEngineVector3Int__get__left(Unsafe.AsPointer(ref leftValue));
            global::UnityEngine.Vector3Int returnResult = leftValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__right()
        {
            global::UnityEngine.Vector3Int rightValue = default;
            UnityEngineVector3Int__get__right(Unsafe.AsPointer(ref rightValue));
            global::UnityEngine.Vector3Int returnResult = rightValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__forward()
        {
            global::UnityEngine.Vector3Int forwardValue = default;
            UnityEngineVector3Int__get__forward(Unsafe.AsPointer(ref forwardValue));
            global::UnityEngine.Vector3Int returnResult = forwardValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__get__back()
        {
            global::UnityEngine.Vector3Int backValue = default;
            UnityEngineVector3Int__get__back(Unsafe.AsPointer(ref backValue));
            global::UnityEngine.Vector3Int returnResult = backValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__func__Set__SystemInt32__SystemInt32__SystemInt32__SystemVoid(ref global::UnityEngine.Vector3Int selfStruct, int x, int y, int z)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__func__Set__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfStructPointer, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineVector3Int__func__Distance__UnityEngineVector3Int__UnityEngineVector3Int__SystemSingle(global::UnityEngine.Vector3Int a, global::UnityEngine.Vector3Int b)
        {
            var methodCallResult = UnityEngineVector3Int__func__Distance__UnityEngineVector3Int__UnityEngineVector3Int__SystemSingle(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__Min__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(global::UnityEngine.Vector3Int lhs, global::UnityEngine.Vector3Int rhs)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__Min__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(Unsafe.AsPointer(ref lhs), Unsafe.AsPointer(ref rhs), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__Max__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(global::UnityEngine.Vector3Int lhs, global::UnityEngine.Vector3Int rhs)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__Max__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(Unsafe.AsPointer(ref lhs), Unsafe.AsPointer(ref rhs), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(global::UnityEngine.Vector3Int a, global::UnityEngine.Vector3Int b)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__SystemVoid(ref global::UnityEngine.Vector3Int selfStruct, global::UnityEngine.Vector3Int scale)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3Int__func__Clamp__UnityEngineVector3Int__UnityEngineVector3Int__SystemVoid(ref global::UnityEngine.Vector3Int selfStruct, global::UnityEngine.Vector3Int min, global::UnityEngine.Vector3Int max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineVector3Int__func__Clamp__UnityEngineVector3Int__UnityEngineVector3Int__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref min), Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__FloorToInt__UnityEngineVector3__UnityEngineVector3Int(global::UnityEngine.Vector3 v)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__FloorToInt__UnityEngineVector3__UnityEngineVector3Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__CeilToInt__UnityEngineVector3__UnityEngineVector3Int(global::UnityEngine.Vector3 v)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__CeilToInt__UnityEngineVector3__UnityEngineVector3Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3Int internal_UnityEngineVector3Int__func__RoundToInt__UnityEngineVector3__UnityEngineVector3Int(global::UnityEngine.Vector3 v)
        {
            global::UnityEngine.Vector3Int returnResultValue = default;
            UnityEngineVector3Int__func__RoundToInt__UnityEngineVector3__UnityEngineVector3Int(Unsafe.AsPointer(ref v), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3Int returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineVector3Int__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Vector3Int selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineVector3Int__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineVector3Int__func__Equals__UnityEngineVector3Int__SystemBoolean(ref global::UnityEngine.Vector3Int selfStruct, global::UnityEngine.Vector3Int other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__func__Equals__UnityEngineVector3Int__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineVector3Int__func__GetHashCode__SystemInt32(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineVector3Int__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3Int__func__ToString__SystemString(ref global::UnityEngine.Vector3Int selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineVector3Int__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3Int__func__ToString__SystemString__SystemString(ref global::UnityEngine.Vector3Int selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector3Int__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Vector3Int selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector3Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__ctor__SystemInt32__SystemInt32(void* selfStructPointer, int x, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__ctor__SystemInt32__SystemInt32__SystemInt32(void* selfStructPointer, int x, int y, int z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__get__x(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__set__x(void* selfStructPointer, int x);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__get__y(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__set__y(void* selfStructPointer, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__get__z(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__set__z(void* selfStructPointer, int z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineVector3Int__get__magnitude(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__get__sqrMagnitude(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__zero(void* zeroPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__one(void* onePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__up(void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__down(void* downPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__left(void* leftPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__right(void* rightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__forward(void* forwardPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__get__back(void* backPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Set__SystemInt32__SystemInt32__SystemInt32__SystemVoid(void* selfStructPointer, int x, int y, int z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineVector3Int__func__Distance__UnityEngineVector3Int__UnityEngineVector3Int__SystemSingle(void* aPointer, void* bPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Min__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(void* lhsPointer, void* rhsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Max__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(void* lhsPointer, void* rhsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__UnityEngineVector3Int__UnityEngineVector3Int(void* aPointer, void* bPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Scale__UnityEngineVector3Int__SystemVoid(void* selfStructPointer, void* scalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__Clamp__UnityEngineVector3Int__UnityEngineVector3Int__SystemVoid(void* selfStructPointer, void* minPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__FloorToInt__UnityEngineVector3__UnityEngineVector3Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__CeilToInt__UnityEngineVector3__UnityEngineVector3Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__RoundToInt__UnityEngineVector3__UnityEngineVector3Int(void* vPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__func__Equals__UnityEngineVector3Int__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineVector3Int__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3Int__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
