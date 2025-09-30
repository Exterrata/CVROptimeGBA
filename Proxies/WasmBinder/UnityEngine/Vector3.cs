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
    public partial struct Vector3
    {

        #region Implementation

        public static global::UnityEngine.Vector3 Slerp(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float t)
        {
            return internal_UnityEngineVector3__func__Slerp__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(a, b, t);
        }

        public static global::UnityEngine.Vector3 SlerpUnclamped(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float t)
        {
            return internal_UnityEngineVector3__func__SlerpUnclamped__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(a, b, t);
        }

        public static void OrthoNormalize(ref global::UnityEngine.Vector3 normal, ref global::UnityEngine.Vector3 tangent)
        {
            internal_UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(ref normal, ref tangent);
        }

        public static void OrthoNormalize(ref global::UnityEngine.Vector3 normal, ref global::UnityEngine.Vector3 tangent, ref global::UnityEngine.Vector3 binormal)
        {
            internal_UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(ref normal, ref tangent, ref binormal);
        }

        public static global::UnityEngine.Vector3 RotateTowards(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
        {
            return internal_UnityEngineVector3__func__RotateTowards__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineVector3(current, target, maxRadiansDelta, maxMagnitudeDelta);
        }

        public static global::UnityEngine.Vector3 SmoothDamp(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, ref global::UnityEngine.Vector3 currentVelocity, float smoothTime, float maxSpeed)
        {
            return internal_UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__SystemSingle__UnityEngineVector3(current, target, ref currentVelocity, smoothTime, maxSpeed);
        }

        public static global::UnityEngine.Vector3 SmoothDamp(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, ref global::UnityEngine.Vector3 currentVelocity, float smoothTime)
        {
            return internal_UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__UnityEngineVector3(current, target, ref currentVelocity, smoothTime);
        }

        public string ToString()
        {
            return internal_UnityEngineVector3__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineVector3__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineVector3__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineVector3__func__Slerp__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float t)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineVector3__func__Slerp__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineVector3__func__SlerpUnclamped__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float t)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineVector3__func__SlerpUnclamped__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(ref global::UnityEngine.Vector3 normal, ref global::UnityEngine.Vector3 tangent)
        {
            UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(Unsafe.AsPointer(ref normal), Unsafe.AsPointer(ref tangent));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(ref global::UnityEngine.Vector3 normal, ref global::UnityEngine.Vector3 tangent, ref global::UnityEngine.Vector3 binormal)
        {
            UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(Unsafe.AsPointer(ref normal), Unsafe.AsPointer(ref tangent), Unsafe.AsPointer(ref binormal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineVector3__func__RotateTowards__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineVector3(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineVector3__func__RotateTowards__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineVector3(Unsafe.AsPointer(ref current), Unsafe.AsPointer(ref target), maxRadiansDelta, maxMagnitudeDelta, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__SystemSingle__UnityEngineVector3(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, ref global::UnityEngine.Vector3 currentVelocity, float smoothTime, float maxSpeed)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__SystemSingle__UnityEngineVector3(Unsafe.AsPointer(ref current), Unsafe.AsPointer(ref target), Unsafe.AsPointer(ref currentVelocity), smoothTime, maxSpeed, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__UnityEngineVector3(global::UnityEngine.Vector3 current, global::UnityEngine.Vector3 target, ref global::UnityEngine.Vector3 currentVelocity, float smoothTime)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__UnityEngineVector3(Unsafe.AsPointer(ref current), Unsafe.AsPointer(ref target), Unsafe.AsPointer(ref currentVelocity), smoothTime, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3__func__ToString__SystemString(ref global::UnityEngine.Vector3 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineVector3__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3__func__ToString__SystemString__SystemString(ref global::UnityEngine.Vector3 selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector3__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineVector3__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Vector3 selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineVector3__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__Slerp__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__SlerpUnclamped__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(void* normalPointer, void* tangentPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__OrthoNormalize__UnityEngineVector3Ref__UnityEngineVector3Ref__UnityEngineVector3Ref__SystemVoid(void* normalPointer, void* tangentPointer, void* binormalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__RotateTowards__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineVector3(void* currentPointer, void* targetPointer, float maxRadiansDelta, float maxMagnitudeDelta, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__SystemSingle__UnityEngineVector3(void* currentPointer, void* targetPointer, void* currentVelocityPointer, float smoothTime, float maxSpeed, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__SmoothDamp__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3Ref__SystemSingle__UnityEngineVector3(void* currentPointer, void* targetPointer, void* currentVelocityPointer, float smoothTime, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineVector3__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
