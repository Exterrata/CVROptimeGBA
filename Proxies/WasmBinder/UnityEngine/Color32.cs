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

    [StructLayout(LayoutKind.Explicit)]
    public partial struct Color32
    {

        #region Implementation

        public Color32(byte r, byte g, byte b, byte a)
        {
            internal_UnityEngineColor32__ctor__SystemByte__SystemByte__SystemByte__SystemByte(ref this, r, g, b, a);
        }

        [FieldOffset(0)]
        private int rgba;

        [FieldOffset(0)]
        public byte r;

        [FieldOffset(1)]
        public byte g;

        [FieldOffset(2)]
        public byte b;

        [FieldOffset(3)]
        public byte a;

        public static global::UnityEngine.Color32 Lerp(global::UnityEngine.Color32 a, global::UnityEngine.Color32 b, float t)
        {
            return internal_UnityEngineColor32__func__Lerp__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(a, b, t);
        }

        public static global::UnityEngine.Color32 LerpUnclamped(global::UnityEngine.Color32 a, global::UnityEngine.Color32 b, float t)
        {
            return internal_UnityEngineColor32__func__LerpUnclamped__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(a, b, t);
        }

        public string ToString()
        {
            return internal_UnityEngineColor32__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineColor32__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineColor32__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineColor32__ctor__SystemByte__SystemByte__SystemByte__SystemByte(ref global::UnityEngine.Color32 selfStruct, byte r, byte g, byte b, byte a)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var rConverted = Unsafe.As<byte, int>(ref r);
            var gConverted = Unsafe.As<byte, int>(ref g);
            var bConverted = Unsafe.As<byte, int>(ref b);
            var aConverted = Unsafe.As<byte, int>(ref a);
            UnityEngineColor32__ctor__SystemByte__SystemByte__SystemByte__SystemByte(selfStructPointer, rConverted, gConverted, bConverted, aConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32 internal_UnityEngineColor32__func__Lerp__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(global::UnityEngine.Color32 a, global::UnityEngine.Color32 b, float t)
        {
            global::UnityEngine.Color32 returnResultValue = default;
            UnityEngineColor32__func__Lerp__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color32 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32 internal_UnityEngineColor32__func__LerpUnclamped__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(global::UnityEngine.Color32 a, global::UnityEngine.Color32 b, float t)
        {
            global::UnityEngine.Color32 returnResultValue = default;
            UnityEngineColor32__func__LerpUnclamped__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color32 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor32__func__ToString__SystemString(ref global::UnityEngine.Color32 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineColor32__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor32__func__ToString__SystemString__SystemString(ref global::UnityEngine.Color32 selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineColor32__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor32__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Color32 selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineColor32__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__ctor__SystemByte__SystemByte__SystemByte__SystemByte(void* selfStructPointer, int rConverted, int gConverted, int bConverted, int aConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__func__Lerp__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__func__LerpUnclamped__UnityEngineColor32__UnityEngineColor32__SystemSingle__UnityEngineColor32(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor32__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
