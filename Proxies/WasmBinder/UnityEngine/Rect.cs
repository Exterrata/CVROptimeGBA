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
    public partial struct Rect
    {

        #region Implementation

        public Rect(float x, float y, float width, float height)
        {
            internal_UnityEngineRect__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref this, x, y, width, height);
        }

        public Rect(global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 size)
        {
            internal_UnityEngineRect__ctor__UnityEngineVector2__UnityEngineVector2(ref this, position, size);
        }

        public Rect(global::UnityEngine.Rect source)
        {
            internal_UnityEngineRect__ctor__UnityEngineRect(ref this, source);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private float m_XMin;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float m_YMin;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private float m_Width;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_Height;

        public static global::UnityEngine.Rect zero 
        {
            get => internal_UnityEngineRect__get__zero();
        }

        public float x 
        {
            get => internal_UnityEngineRect__get__x(ref this);
            set => internal_UnityEngineRect__set__x(ref this, value);
        }

        public float y 
        {
            get => internal_UnityEngineRect__get__y(ref this);
            set => internal_UnityEngineRect__set__y(ref this, value);
        }

        public global::UnityEngine.Vector2 position 
        {
            get => internal_UnityEngineRect__get__position(ref this);
            set => internal_UnityEngineRect__set__position(ref this, value);
        }

        public global::UnityEngine.Vector2 center 
        {
            get => internal_UnityEngineRect__get__center(ref this);
            set => internal_UnityEngineRect__set__center(ref this, value);
        }

        public global::UnityEngine.Vector2 min 
        {
            get => internal_UnityEngineRect__get__min(ref this);
            set => internal_UnityEngineRect__set__min(ref this, value);
        }

        public global::UnityEngine.Vector2 max 
        {
            get => internal_UnityEngineRect__get__max(ref this);
            set => internal_UnityEngineRect__set__max(ref this, value);
        }

        public float width 
        {
            get => internal_UnityEngineRect__get__width(ref this);
            set => internal_UnityEngineRect__set__width(ref this, value);
        }

        public float height 
        {
            get => internal_UnityEngineRect__get__height(ref this);
            set => internal_UnityEngineRect__set__height(ref this, value);
        }

        public global::UnityEngine.Vector2 size 
        {
            get => internal_UnityEngineRect__get__size(ref this);
            set => internal_UnityEngineRect__set__size(ref this, value);
        }

        public float xMin 
        {
            get => internal_UnityEngineRect__get__xMin(ref this);
            set => internal_UnityEngineRect__set__xMin(ref this, value);
        }

        public float yMin 
        {
            get => internal_UnityEngineRect__get__yMin(ref this);
            set => internal_UnityEngineRect__set__yMin(ref this, value);
        }

        public float xMax 
        {
            get => internal_UnityEngineRect__get__xMax(ref this);
            set => internal_UnityEngineRect__set__xMax(ref this, value);
        }

        public float yMax 
        {
            get => internal_UnityEngineRect__get__yMax(ref this);
            set => internal_UnityEngineRect__set__yMax(ref this, value);
        }

        public static global::UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
        {
            return internal_UnityEngineRect__func__MinMaxRect__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineRect(xmin, ymin, xmax, ymax);
        }

        public void Set(float x, float y, float width, float height)
        {
            internal_UnityEngineRect__func__Set__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(ref this, x, y, width, height);
        }

        public bool Contains(global::UnityEngine.Vector2 point)
        {
            return internal_UnityEngineRect__func__Contains__UnityEngineVector2__SystemBoolean(ref this, point);
        }

        public bool Contains(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean(ref this, point);
        }

        public bool Contains(global::UnityEngine.Vector3 point, bool allowInverse)
        {
            return internal_UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean__SystemBoolean(ref this, point, allowInverse);
        }

        public bool Overlaps(global::UnityEngine.Rect other)
        {
            return internal_UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean(ref this, other);
        }

        public bool Overlaps(global::UnityEngine.Rect other, bool allowInverse)
        {
            return internal_UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean__SystemBoolean(ref this, other, allowInverse);
        }

        public static global::UnityEngine.Vector2 NormalizedToPoint(global::UnityEngine.Rect rectangle, global::UnityEngine.Vector2 normalizedRectCoordinates)
        {
            return internal_UnityEngineRect__func__NormalizedToPoint__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(rectangle, normalizedRectCoordinates);
        }

        public static global::UnityEngine.Vector2 PointToNormalized(global::UnityEngine.Rect rectangle, global::UnityEngine.Vector2 point)
        {
            return internal_UnityEngineRect__func__PointToNormalized__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(rectangle, point);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRect__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineRect__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Rect other)
        {
            return internal_UnityEngineRect__func__Equals__UnityEngineRect__SystemBoolean(ref this, other);
        }

        public string ToString()
        {
            return internal_UnityEngineRect__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineRect__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineRect__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.Rect selfStruct, float x, float y, float width, float height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, x, y, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__ctor__UnityEngineVector2__UnityEngineVector2(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__ctor__UnityEngineVector2__UnityEngineVector2(selfStructPointer, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__ctor__UnityEngineRect(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Rect source)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__ctor__UnityEngineRect(selfStructPointer, Unsafe.AsPointer(ref source));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineRect__get__zero()
        {
            global::UnityEngine.Rect zeroValue = default;
            UnityEngineRect__get__zero(Unsafe.AsPointer(ref zeroValue));
            global::UnityEngine.Rect returnResult = zeroValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__x(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__x(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__x(ref global::UnityEngine.Rect selfStruct, float x)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__x(selfStructPointer, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__y(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__y(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__y(ref global::UnityEngine.Rect selfStruct, float y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__y(selfStructPointer, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__get__position(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 positionValue = default;
            UnityEngineRect__get__position(selfStructPointer, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector2 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__position(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 position)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__position(selfStructPointer, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__get__center(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 centerValue = default;
            UnityEngineRect__get__center(selfStructPointer, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector2 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__center(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 center)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__center(selfStructPointer, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__get__min(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 minValue = default;
            UnityEngineRect__get__min(selfStructPointer, Unsafe.AsPointer(ref minValue));
            global::UnityEngine.Vector2 returnResult = minValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__min(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 min)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__min(selfStructPointer, Unsafe.AsPointer(ref min));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__get__max(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 maxValue = default;
            UnityEngineRect__get__max(selfStructPointer, Unsafe.AsPointer(ref maxValue));
            global::UnityEngine.Vector2 returnResult = maxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__max(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__max(selfStructPointer, Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__width(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__width(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__width(ref global::UnityEngine.Rect selfStruct, float width)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__width(selfStructPointer, width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__height(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__height(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__height(ref global::UnityEngine.Rect selfStruct, float height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__height(selfStructPointer, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__get__size(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 sizeValue = default;
            UnityEngineRect__get__size(selfStructPointer, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector2 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__size(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__size(selfStructPointer, Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__xMin(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__xMin(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__xMin(ref global::UnityEngine.Rect selfStruct, float xMin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__xMin(selfStructPointer, xMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__yMin(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__yMin(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__yMin(ref global::UnityEngine.Rect selfStruct, float yMin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__yMin(selfStructPointer, yMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__xMax(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__xMax(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__xMax(ref global::UnityEngine.Rect selfStruct, float xMax)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__xMax(selfStructPointer, xMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRect__get__yMax(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__get__yMax(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__set__yMax(ref global::UnityEngine.Rect selfStruct, float yMax)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__set__yMax(selfStructPointer, yMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineRect__func__MinMaxRect__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineRect(float xmin, float ymin, float xmax, float ymax)
        {
            global::UnityEngine.Rect returnResultValue = default;
            UnityEngineRect__func__MinMaxRect__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineRect(xmin, ymin, xmax, ymax, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rect returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRect__func__Set__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(ref global::UnityEngine.Rect selfStruct, float x, float y, float width, float height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRect__func__Set__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfStructPointer, x, y, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Contains__UnityEngineVector2__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector2 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__func__Contains__UnityEngineVector2__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Vector3 point, bool allowInverse)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var allowInverseConverted = Unsafe.As<bool, int>(ref allowInverse);
            var methodCallResult = UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point), allowInverseConverted);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Rect other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Rect other, bool allowInverse)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var allowInverseConverted = Unsafe.As<bool, int>(ref allowInverse);
            var methodCallResult = UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other), allowInverseConverted);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__func__NormalizedToPoint__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(global::UnityEngine.Rect rectangle, global::UnityEngine.Vector2 normalizedRectCoordinates)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineRect__func__NormalizedToPoint__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(Unsafe.AsPointer(ref rectangle), Unsafe.AsPointer(ref normalizedRectCoordinates), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRect__func__PointToNormalized__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(global::UnityEngine.Rect rectangle, global::UnityEngine.Vector2 point)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineRect__func__PointToNormalized__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(Unsafe.AsPointer(ref rectangle), Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRect__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rect selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRect__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRect__func__Equals__UnityEngineRect__SystemBoolean(ref global::UnityEngine.Rect selfStruct, global::UnityEngine.Rect other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRect__func__Equals__UnityEngineRect__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRect__func__ToString__SystemString(ref global::UnityEngine.Rect selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRect__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRect__func__ToString__SystemString__SystemString(ref global::UnityEngine.Rect selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRect__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRect__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Rect selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRect__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float x, float y, float width, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__ctor__UnityEngineVector2__UnityEngineVector2(void* selfStructPointer, void* positionPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__ctor__UnityEngineRect(void* selfStructPointer, void* sourcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__zero(void* zeroPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__x(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__x(void* selfStructPointer, float x);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__y(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__y(void* selfStructPointer, float y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__width(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__width(void* selfStructPointer, float width);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__height(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__height(void* selfStructPointer, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__get__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__xMin(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__xMin(void* selfStructPointer, float xMin);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__yMin(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__yMin(void* selfStructPointer, float yMin);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__xMax(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__xMax(void* selfStructPointer, float xMax);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRect__get__yMax(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__set__yMax(void* selfStructPointer, float yMax);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__MinMaxRect__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineRect(float xmin, float ymin, float xmax, float ymax, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__Set__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(void* selfStructPointer, float x, float y, float width, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Contains__UnityEngineVector2__SystemBoolean(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Contains__UnityEngineVector3__SystemBoolean__SystemBoolean(void* selfStructPointer, void* pointPointer, int allowInverseConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Overlaps__UnityEngineRect__SystemBoolean__SystemBoolean(void* selfStructPointer, void* otherPointer, int allowInverseConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__NormalizedToPoint__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(void* rectanglePointer, void* normalizedRectCoordinatesPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__PointToNormalized__UnityEngineRect__UnityEngineVector2__UnityEngineVector2(void* rectanglePointer, void* pointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRect__func__Equals__UnityEngineRect__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRect__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
