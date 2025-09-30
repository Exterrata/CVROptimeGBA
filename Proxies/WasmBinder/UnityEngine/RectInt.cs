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
    public partial struct RectInt
    {

        #region Implementation

        public RectInt(int xMin, int yMin, int width, int height)
        {
            internal_UnityEngineRectInt__ctor__SystemInt32__SystemInt32__SystemInt32__SystemInt32(ref this, xMin, yMin, width, height);
        }

        public RectInt(global::UnityEngine.Vector2Int position, global::UnityEngine.Vector2Int size)
        {
            internal_UnityEngineRectInt__ctor__UnityEngineVector2Int__UnityEngineVector2Int(ref this, position, size);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_XMin;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_YMin;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_Width;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private int m_Height;

        public int x 
        {
            get => internal_UnityEngineRectInt__get__x(ref this);
            set => internal_UnityEngineRectInt__set__x(ref this, value);
        }

        public int y 
        {
            get => internal_UnityEngineRectInt__get__y(ref this);
            set => internal_UnityEngineRectInt__set__y(ref this, value);
        }

        public global::UnityEngine.Vector2 center 
        {
            get => internal_UnityEngineRectInt__get__center(ref this);
        }

        public global::UnityEngine.Vector2Int min 
        {
            get => internal_UnityEngineRectInt__get__min(ref this);
            set => internal_UnityEngineRectInt__set__min(ref this, value);
        }

        public global::UnityEngine.Vector2Int max 
        {
            get => internal_UnityEngineRectInt__get__max(ref this);
            set => internal_UnityEngineRectInt__set__max(ref this, value);
        }

        public int width 
        {
            get => internal_UnityEngineRectInt__get__width(ref this);
            set => internal_UnityEngineRectInt__set__width(ref this, value);
        }

        public int height 
        {
            get => internal_UnityEngineRectInt__get__height(ref this);
            set => internal_UnityEngineRectInt__set__height(ref this, value);
        }

        public int xMin 
        {
            get => internal_UnityEngineRectInt__get__xMin(ref this);
            set => internal_UnityEngineRectInt__set__xMin(ref this, value);
        }

        public int yMin 
        {
            get => internal_UnityEngineRectInt__get__yMin(ref this);
            set => internal_UnityEngineRectInt__set__yMin(ref this, value);
        }

        public int xMax 
        {
            get => internal_UnityEngineRectInt__get__xMax(ref this);
            set => internal_UnityEngineRectInt__set__xMax(ref this, value);
        }

        public int yMax 
        {
            get => internal_UnityEngineRectInt__get__yMax(ref this);
            set => internal_UnityEngineRectInt__set__yMax(ref this, value);
        }

        public global::UnityEngine.Vector2Int position 
        {
            get => internal_UnityEngineRectInt__get__position(ref this);
            set => internal_UnityEngineRectInt__set__position(ref this, value);
        }

        public global::UnityEngine.Vector2Int size 
        {
            get => internal_UnityEngineRectInt__get__size(ref this);
            set => internal_UnityEngineRectInt__set__size(ref this, value);
        }

        public void SetMinMax(global::UnityEngine.Vector2Int minPosition, global::UnityEngine.Vector2Int maxPosition)
        {
            internal_UnityEngineRectInt__func__SetMinMax__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(ref this, minPosition, maxPosition);
        }

        public void ClampToBounds(global::UnityEngine.RectInt bounds)
        {
            internal_UnityEngineRectInt__func__ClampToBounds__UnityEngineRectInt__SystemVoid(ref this, bounds);
        }

        public bool Contains(global::UnityEngine.Vector2Int position)
        {
            return internal_UnityEngineRectInt__func__Contains__UnityEngineVector2Int__SystemBoolean(ref this, position);
        }

        public bool Overlaps(global::UnityEngine.RectInt other)
        {
            return internal_UnityEngineRectInt__func__Overlaps__UnityEngineRectInt__SystemBoolean(ref this, other);
        }

        public string ToString()
        {
            return internal_UnityEngineRectInt__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineRectInt__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineRectInt__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        public bool Equals(global::UnityEngine.RectInt other)
        {
            return internal_UnityEngineRectInt__func__Equals__UnityEngineRectInt__SystemBoolean(ref this, other);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__ctor__SystemInt32__SystemInt32__SystemInt32__SystemInt32(ref global::UnityEngine.RectInt selfStruct, int xMin, int yMin, int width, int height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__ctor__SystemInt32__SystemInt32__SystemInt32__SystemInt32(selfStructPointer, xMin, yMin, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__ctor__UnityEngineVector2Int__UnityEngineVector2Int(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int position, global::UnityEngine.Vector2Int size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__ctor__UnityEngineVector2Int__UnityEngineVector2Int(selfStructPointer, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__x(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__x(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__x(ref global::UnityEngine.RectInt selfStruct, int x)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__x(selfStructPointer, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__y(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__y(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__y(ref global::UnityEngine.RectInt selfStruct, int y)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__y(selfStructPointer, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectInt__get__center(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 centerValue = default;
            UnityEngineRectInt__get__center(selfStructPointer, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector2 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineRectInt__get__min(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2Int minValue = default;
            UnityEngineRectInt__get__min(selfStructPointer, Unsafe.AsPointer(ref minValue));
            global::UnityEngine.Vector2Int returnResult = minValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__min(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int min)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__min(selfStructPointer, Unsafe.AsPointer(ref min));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineRectInt__get__max(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2Int maxValue = default;
            UnityEngineRectInt__get__max(selfStructPointer, Unsafe.AsPointer(ref maxValue));
            global::UnityEngine.Vector2Int returnResult = maxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__max(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__max(selfStructPointer, Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__width(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__width(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__width(ref global::UnityEngine.RectInt selfStruct, int width)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__width(selfStructPointer, width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__height(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__height(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__height(ref global::UnityEngine.RectInt selfStruct, int height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__height(selfStructPointer, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__xMin(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__xMin(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__xMin(ref global::UnityEngine.RectInt selfStruct, int xMin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__xMin(selfStructPointer, xMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__yMin(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__yMin(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__yMin(ref global::UnityEngine.RectInt selfStruct, int yMin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__yMin(selfStructPointer, yMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__xMax(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__xMax(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__xMax(ref global::UnityEngine.RectInt selfStruct, int xMax)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__xMax(selfStructPointer, xMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRectInt__get__yMax(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__get__yMax(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__yMax(ref global::UnityEngine.RectInt selfStruct, int yMax)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__yMax(selfStructPointer, yMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineRectInt__get__position(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2Int positionValue = default;
            UnityEngineRectInt__get__position(selfStructPointer, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector2Int returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__position(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int position)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__position(selfStructPointer, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2Int internal_UnityEngineRectInt__get__size(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2Int sizeValue = default;
            UnityEngineRectInt__get__size(selfStructPointer, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector2Int returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__set__size(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__set__size(selfStructPointer, Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__func__SetMinMax__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int minPosition, global::UnityEngine.Vector2Int maxPosition)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__func__SetMinMax__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref minPosition), Unsafe.AsPointer(ref maxPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectInt__func__ClampToBounds__UnityEngineRectInt__SystemVoid(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.RectInt bounds)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRectInt__func__ClampToBounds__UnityEngineRectInt__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref bounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRectInt__func__Contains__UnityEngineVector2Int__SystemBoolean(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.Vector2Int position)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__func__Contains__UnityEngineVector2Int__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref position));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRectInt__func__Overlaps__UnityEngineRectInt__SystemBoolean(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.RectInt other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__func__Overlaps__UnityEngineRectInt__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRectInt__func__ToString__SystemString(ref global::UnityEngine.RectInt selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRectInt__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRectInt__func__ToString__SystemString__SystemString(ref global::UnityEngine.RectInt selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRectInt__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRectInt__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.RectInt selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRectInt__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRectInt__func__Equals__UnityEngineRectInt__SystemBoolean(ref global::UnityEngine.RectInt selfStruct, global::UnityEngine.RectInt other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRectInt__func__Equals__UnityEngineRectInt__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__ctor__SystemInt32__SystemInt32__SystemInt32__SystemInt32(void* selfStructPointer, int xMin, int yMin, int width, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__ctor__UnityEngineVector2Int__UnityEngineVector2Int(void* selfStructPointer, void* positionPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__x(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__x(void* selfStructPointer, int x);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__y(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__y(void* selfStructPointer, int y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__get__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__get__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__get__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__width(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__width(void* selfStructPointer, int width);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__height(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__height(void* selfStructPointer, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__xMin(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__xMin(void* selfStructPointer, int xMin);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__yMin(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__yMin(void* selfStructPointer, int yMin);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__xMax(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__xMax(void* selfStructPointer, int xMax);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__get__yMax(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__yMax(void* selfStructPointer, int yMax);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__get__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__get__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__set__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__func__SetMinMax__UnityEngineVector2Int__UnityEngineVector2Int__SystemVoid(void* selfStructPointer, void* minPositionPointer, void* maxPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__func__ClampToBounds__UnityEngineRectInt__SystemVoid(void* selfStructPointer, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__func__Contains__UnityEngineVector2Int__SystemBoolean(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__func__Overlaps__UnityEngineRectInt__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectInt__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRectInt__func__Equals__UnityEngineRectInt__SystemBoolean(void* selfStructPointer, void* otherPointer);

        #endregion Imports
    }
}
