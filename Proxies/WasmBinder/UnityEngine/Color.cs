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
    public partial struct Color
    {

        #region Implementation

        public Color(float r, float g, float b, float a)
        {
            internal_UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref this, r, g, b, a);
        }

        public Color(float r, float g, float b)
        {
            internal_UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle(ref this, r, g, b);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        public float r;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        public float g;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        public float b;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        public float a;

        public static global::UnityEngine.Color red 
        {
            get => internal_UnityEngineColor__get__red();
        }

        public static global::UnityEngine.Color green 
        {
            get => internal_UnityEngineColor__get__green();
        }

        public static global::UnityEngine.Color blue 
        {
            get => internal_UnityEngineColor__get__blue();
        }

        public static global::UnityEngine.Color white 
        {
            get => internal_UnityEngineColor__get__white();
        }

        public static global::UnityEngine.Color black 
        {
            get => internal_UnityEngineColor__get__black();
        }

        public static global::UnityEngine.Color yellow 
        {
            get => internal_UnityEngineColor__get__yellow();
        }

        public static global::UnityEngine.Color cyan 
        {
            get => internal_UnityEngineColor__get__cyan();
        }

        public static global::UnityEngine.Color magenta 
        {
            get => internal_UnityEngineColor__get__magenta();
        }

        public static global::UnityEngine.Color gray 
        {
            get => internal_UnityEngineColor__get__gray();
        }

        public static global::UnityEngine.Color grey 
        {
            get => internal_UnityEngineColor__get__grey();
        }

        public static global::UnityEngine.Color clear 
        {
            get => internal_UnityEngineColor__get__clear();
        }

        public float grayscale 
        {
            get => internal_UnityEngineColor__get__grayscale(ref this);
        }

        public global::UnityEngine.Color linear 
        {
            get => internal_UnityEngineColor__get__linear(ref this);
        }

        public global::UnityEngine.Color gamma 
        {
            get => internal_UnityEngineColor__get__gamma(ref this);
        }

        public float maxColorComponent 
        {
            get => internal_UnityEngineColor__get__maxColorComponent(ref this);
        }

        public string ToString()
        {
            return internal_UnityEngineColor__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineColor__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineColor__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineColor__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineColor__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Color other)
        {
            return internal_UnityEngineColor__func__Equals__UnityEngineColor__SystemBoolean(ref this, other);
        }

        public static global::UnityEngine.Color Lerp(global::UnityEngine.Color a, global::UnityEngine.Color b, float t)
        {
            return internal_UnityEngineColor__func__Lerp__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(a, b, t);
        }

        public static global::UnityEngine.Color LerpUnclamped(global::UnityEngine.Color a, global::UnityEngine.Color b, float t)
        {
            return internal_UnityEngineColor__func__LerpUnclamped__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(a, b, t);
        }

        public static void RGBToHSV(global::UnityEngine.Color rgbColor, out float H, out float S, out float V)
        {
            internal_UnityEngineColor__func__RGBToHSV__UnityEngineColor__SystemSingleRef__SystemSingleRef__SystemSingleRef__SystemVoid(rgbColor, out H, out S, out V);
        }

        public static global::UnityEngine.Color HSVToRGB(float H, float S, float V)
        {
            return internal_UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__UnityEngineColor(H, S, V);
        }

        public static global::UnityEngine.Color HSVToRGB(float H, float S, float V, bool hdr)
        {
            return internal_UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__SystemBoolean__UnityEngineColor(H, S, V, hdr);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.Color selfStruct, float r, float g, float b, float a)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, r, g, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.Color selfStruct, float r, float g, float b)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, r, g, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__red()
        {
            global::UnityEngine.Color redValue = default;
            UnityEngineColor__get__red(Unsafe.AsPointer(ref redValue));
            global::UnityEngine.Color returnResult = redValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__green()
        {
            global::UnityEngine.Color greenValue = default;
            UnityEngineColor__get__green(Unsafe.AsPointer(ref greenValue));
            global::UnityEngine.Color returnResult = greenValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__blue()
        {
            global::UnityEngine.Color blueValue = default;
            UnityEngineColor__get__blue(Unsafe.AsPointer(ref blueValue));
            global::UnityEngine.Color returnResult = blueValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__white()
        {
            global::UnityEngine.Color whiteValue = default;
            UnityEngineColor__get__white(Unsafe.AsPointer(ref whiteValue));
            global::UnityEngine.Color returnResult = whiteValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__black()
        {
            global::UnityEngine.Color blackValue = default;
            UnityEngineColor__get__black(Unsafe.AsPointer(ref blackValue));
            global::UnityEngine.Color returnResult = blackValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__yellow()
        {
            global::UnityEngine.Color yellowValue = default;
            UnityEngineColor__get__yellow(Unsafe.AsPointer(ref yellowValue));
            global::UnityEngine.Color returnResult = yellowValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__cyan()
        {
            global::UnityEngine.Color cyanValue = default;
            UnityEngineColor__get__cyan(Unsafe.AsPointer(ref cyanValue));
            global::UnityEngine.Color returnResult = cyanValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__magenta()
        {
            global::UnityEngine.Color magentaValue = default;
            UnityEngineColor__get__magenta(Unsafe.AsPointer(ref magentaValue));
            global::UnityEngine.Color returnResult = magentaValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__gray()
        {
            global::UnityEngine.Color grayValue = default;
            UnityEngineColor__get__gray(Unsafe.AsPointer(ref grayValue));
            global::UnityEngine.Color returnResult = grayValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__grey()
        {
            global::UnityEngine.Color greyValue = default;
            UnityEngineColor__get__grey(Unsafe.AsPointer(ref greyValue));
            global::UnityEngine.Color returnResult = greyValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__clear()
        {
            global::UnityEngine.Color clearValue = default;
            UnityEngineColor__get__clear(Unsafe.AsPointer(ref clearValue));
            global::UnityEngine.Color returnResult = clearValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineColor__get__grayscale(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineColor__get__grayscale(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__linear(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Color linearValue = default;
            UnityEngineColor__get__linear(selfStructPointer, Unsafe.AsPointer(ref linearValue));
            global::UnityEngine.Color returnResult = linearValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__get__gamma(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Color gammaValue = default;
            UnityEngineColor__get__gamma(selfStructPointer, Unsafe.AsPointer(ref gammaValue));
            global::UnityEngine.Color returnResult = gammaValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineColor__get__maxColorComponent(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineColor__get__maxColorComponent(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor__func__ToString__SystemString(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineColor__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor__func__ToString__SystemString__SystemString(ref global::UnityEngine.Color selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineColor__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineColor__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Color selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineColor__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineColor__func__GetHashCode__SystemInt32(ref global::UnityEngine.Color selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineColor__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineColor__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Color selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineColor__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineColor__func__Equals__UnityEngineColor__SystemBoolean(ref global::UnityEngine.Color selfStruct, global::UnityEngine.Color other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineColor__func__Equals__UnityEngineColor__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__func__Lerp__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(global::UnityEngine.Color a, global::UnityEngine.Color b, float t)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineColor__func__Lerp__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__func__LerpUnclamped__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(global::UnityEngine.Color a, global::UnityEngine.Color b, float t)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineColor__func__LerpUnclamped__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineColor__func__RGBToHSV__UnityEngineColor__SystemSingleRef__SystemSingleRef__SystemSingleRef__SystemVoid(global::UnityEngine.Color rgbColor, out float H, out float S, out float V)
        {
            H = default;
            S = default;
            V = default;
            UnityEngineColor__func__RGBToHSV__UnityEngineColor__SystemSingleRef__SystemSingleRef__SystemSingleRef__SystemVoid(Unsafe.AsPointer(ref rgbColor), Unsafe.AsPointer(ref H), Unsafe.AsPointer(ref S), Unsafe.AsPointer(ref V));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__UnityEngineColor(float H, float S, float V)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__UnityEngineColor(H, S, V, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__SystemBoolean__UnityEngineColor(float H, float S, float V, bool hdr)
        {
            var hdrConverted = Unsafe.As<bool, int>(ref hdr);
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__SystemBoolean__UnityEngineColor(H, S, V, hdrConverted, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float r, float g, float b, float a);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__ctor__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float r, float g, float b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__red(void* redPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__green(void* greenPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__blue(void* bluePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__white(void* whitePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__black(void* blackPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__yellow(void* yellowPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__cyan(void* cyanPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__magenta(void* magentaPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__gray(void* grayPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__grey(void* greyPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__clear(void* clearPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineColor__get__grayscale(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__linear(void* selfStructPointer, void* linearPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__get__gamma(void* selfStructPointer, void* gammaPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineColor__get__maxColorComponent(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineColor__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineColor__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineColor__func__Equals__UnityEngineColor__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__Lerp__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__LerpUnclamped__UnityEngineColor__UnityEngineColor__SystemSingle__UnityEngineColor(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__RGBToHSV__UnityEngineColor__SystemSingleRef__SystemSingleRef__SystemSingleRef__SystemVoid(void* rgbColorPointer, void* HPointer, void* SPointer, void* VPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__UnityEngineColor(float H, float S, float V, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineColor__func__HSVToRGB__SystemSingle__SystemSingle__SystemSingle__SystemBoolean__UnityEngineColor(float H, float S, float V, int hdrConverted, void* returnResultPointer);

        #endregion Imports
    }
}
