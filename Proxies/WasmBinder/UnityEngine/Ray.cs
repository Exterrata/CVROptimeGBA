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
    public partial struct Ray
    {

        #region Implementation

        public Ray(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            internal_UnityEngineRay__ctor__UnityEngineVector3__UnityEngineVector3(ref this, origin, direction);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Origin;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Direction;

        public global::UnityEngine.Vector3 origin 
        {
            get => internal_UnityEngineRay__get__origin(ref this);
            set => internal_UnityEngineRay__set__origin(ref this, value);
        }

        public global::UnityEngine.Vector3 direction 
        {
            get => internal_UnityEngineRay__get__direction(ref this);
            set => internal_UnityEngineRay__set__direction(ref this, value);
        }

        public global::UnityEngine.Vector3 GetPoint(float distance)
        {
            return internal_UnityEngineRay__func__GetPoint__SystemSingle__UnityEngineVector3(ref this, distance);
        }

        public string ToString()
        {
            return internal_UnityEngineRay__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineRay__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineRay__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay__ctor__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Ray selfStruct, global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay__ctor__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRay__get__origin(ref global::UnityEngine.Ray selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 originValue = default;
            UnityEngineRay__get__origin(selfStructPointer, Unsafe.AsPointer(ref originValue));
            global::UnityEngine.Vector3 returnResult = originValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay__set__origin(ref global::UnityEngine.Ray selfStruct, global::UnityEngine.Vector3 origin)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay__set__origin(selfStructPointer, Unsafe.AsPointer(ref origin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRay__get__direction(ref global::UnityEngine.Ray selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 directionValue = default;
            UnityEngineRay__get__direction(selfStructPointer, Unsafe.AsPointer(ref directionValue));
            global::UnityEngine.Vector3 returnResult = directionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRay__set__direction(ref global::UnityEngine.Ray selfStruct, global::UnityEngine.Vector3 direction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRay__set__direction(selfStructPointer, Unsafe.AsPointer(ref direction));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRay__func__GetPoint__SystemSingle__UnityEngineVector3(ref global::UnityEngine.Ray selfStruct, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineRay__func__GetPoint__SystemSingle__UnityEngineVector3(selfStructPointer, distance, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay__func__ToString__SystemString(ref global::UnityEngine.Ray selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRay__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay__func__ToString__SystemString__SystemString(ref global::UnityEngine.Ray selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRay__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRay__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Ray selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineRay__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__ctor__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* originPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__get__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__set__origin(void* selfStructPointer, void* originPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__get__direction(void* selfStructPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__set__direction(void* selfStructPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__func__GetPoint__SystemSingle__UnityEngineVector3(void* selfStructPointer, float distance, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRay__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
