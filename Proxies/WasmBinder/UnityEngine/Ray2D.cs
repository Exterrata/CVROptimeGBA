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
    public partial struct Ray2D
    {

        #region Implementation

        public Ray2D(global::UnityEngine.Vector2 origin, global::UnityEngine.Vector2 direction)
        {
            internal_UnityEngineRay2D__ctor__UnityEngineVector2__UnityEngineVector2(ref this, origin, direction);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector2 m_Origin;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector2 m_Direction;

        public global::UnityEngine.Vector2 origin 
        {
            get => internal_UnityEngineRay2D__get__origin(ref this);
            set => internal_UnityEngineRay2D__set__origin(ref this, value);
        }

        public global::UnityEngine.Vector2 direction 
        {
            get => internal_UnityEngineRay2D__get__direction(ref this);
            set => internal_UnityEngineRay2D__set__direction(ref this, value);
        }

        public global::UnityEngine.Vector2 GetPoint(float distance)
        {
            return internal_UnityEngineRay2D__func__GetPoint__SystemSingle__UnityEngineVector2(ref this, distance);
        }

        public string ToString()
        {
            return internal_UnityEngineRay2D__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineRay2D__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineRay2D__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay2D__ctor__UnityEngineVector2__UnityEngineVector2(ref global::UnityEngine.Ray2D selfStruct, global::UnityEngine.Vector2 origin, global::UnityEngine.Vector2 direction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay2D__ctor__UnityEngineVector2__UnityEngineVector2(selfStructPointer, Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRay2D__get__origin(ref global::UnityEngine.Ray2D selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 originValue = default;
            UnityEngineRay2D__get__origin(selfStructPointer, Unsafe.AsPointer(ref originValue));
            global::UnityEngine.Vector2 returnResult = originValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay2D__set__origin(ref global::UnityEngine.Ray2D selfStruct, global::UnityEngine.Vector2 origin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay2D__set__origin(selfStructPointer, Unsafe.AsPointer(ref origin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRay2D__get__direction(ref global::UnityEngine.Ray2D selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 directionValue = default;
            UnityEngineRay2D__get__direction(selfStructPointer, Unsafe.AsPointer(ref directionValue));
            global::UnityEngine.Vector2 returnResult = directionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay2D__set__direction(ref global::UnityEngine.Ray2D selfStruct, global::UnityEngine.Vector2 direction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay2D__set__direction(selfStructPointer, Unsafe.AsPointer(ref direction));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRay2D__func__GetPoint__SystemSingle__UnityEngineVector2(ref global::UnityEngine.Ray2D selfStruct, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineRay2D__func__GetPoint__SystemSingle__UnityEngineVector2(selfStructPointer, distance, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay2D__func__ToString__SystemString(ref global::UnityEngine.Ray2D selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRay2D__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay2D__func__ToString__SystemString__SystemString(ref global::UnityEngine.Ray2D selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRay2D__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay2D__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Ray2D selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRay2D__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__ctor__UnityEngineVector2__UnityEngineVector2(void* selfStructPointer, void* originPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__get__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__set__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__get__direction(void* selfStructPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__set__direction(void* selfStructPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__func__GetPoint__SystemSingle__UnityEngineVector2(void* selfStructPointer, float distance, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay2D__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
