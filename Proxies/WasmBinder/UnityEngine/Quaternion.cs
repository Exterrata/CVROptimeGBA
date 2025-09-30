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
    public partial struct Quaternion
    {

        #region Implementation

        public static global::UnityEngine.Quaternion FromToRotation(global::UnityEngine.Vector3 fromDirection, global::UnityEngine.Vector3 toDirection)
        {
            return internal_UnityEngineQuaternion__func__FromToRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(fromDirection, toDirection);
        }

        public static global::UnityEngine.Quaternion Inverse(global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEngineQuaternion__func__Inverse__UnityEngineQuaternion__UnityEngineQuaternion(rotation);
        }

        public static global::UnityEngine.Quaternion Slerp(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            return internal_UnityEngineQuaternion__func__Slerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(a, b, t);
        }

        public static global::UnityEngine.Quaternion SlerpUnclamped(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            return internal_UnityEngineQuaternion__func__SlerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(a, b, t);
        }

        public static global::UnityEngine.Quaternion Lerp(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            return internal_UnityEngineQuaternion__func__Lerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(a, b, t);
        }

        public static global::UnityEngine.Quaternion LerpUnclamped(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            return internal_UnityEngineQuaternion__func__LerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(a, b, t);
        }

        public static global::UnityEngine.Quaternion AngleAxis(float angle, global::UnityEngine.Vector3 axis)
        {
            return internal_UnityEngineQuaternion__func__AngleAxis__SystemSingle__UnityEngineVector3__UnityEngineQuaternion(angle, axis);
        }

        public static global::UnityEngine.Quaternion LookRotation(global::UnityEngine.Vector3 forward, global::UnityEngine.Vector3 upwards)
        {
            return internal_UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(forward, upwards);
        }

        public static global::UnityEngine.Quaternion LookRotation(global::UnityEngine.Vector3 forward)
        {
            return internal_UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineQuaternion(forward);
        }

        public void SetLookRotation(global::UnityEngine.Vector3 view)
        {
            internal_UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__SystemVoid(ref this, view);
        }

        public void SetLookRotation(global::UnityEngine.Vector3 view, global::UnityEngine.Vector3 up)
        {
            internal_UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref this, view, up);
        }

        public static float Angle(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b)
        {
            return internal_UnityEngineQuaternion__func__Angle__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle(a, b);
        }

        public static global::UnityEngine.Quaternion Euler(float x, float y, float z)
        {
            return internal_UnityEngineQuaternion__func__Euler__SystemSingle__SystemSingle__SystemSingle__UnityEngineQuaternion(x, y, z);
        }

        public static global::UnityEngine.Quaternion Euler(global::UnityEngine.Vector3 euler)
        {
            return internal_UnityEngineQuaternion__func__Euler__UnityEngineVector3__UnityEngineQuaternion(euler);
        }

        public void ToAngleAxis(out float angle, out global::UnityEngine.Vector3 axis)
        {
            internal_UnityEngineQuaternion__func__ToAngleAxis__SystemSingleRef__UnityEngineVector3Ref__SystemVoid(ref this, out angle, out axis);
        }

        public void SetFromToRotation(global::UnityEngine.Vector3 fromDirection, global::UnityEngine.Vector3 toDirection)
        {
            internal_UnityEngineQuaternion__func__SetFromToRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref this, fromDirection, toDirection);
        }

        public static global::UnityEngine.Quaternion RotateTowards(global::UnityEngine.Quaternion from, global::UnityEngine.Quaternion to, float maxDegreesDelta)
        {
            return internal_UnityEngineQuaternion__func__RotateTowards__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(from, to, maxDegreesDelta);
        }

        public static global::UnityEngine.Quaternion Normalize(global::UnityEngine.Quaternion q)
        {
            return internal_UnityEngineQuaternion__func__Normalize__UnityEngineQuaternion__UnityEngineQuaternion(q);
        }

        public void Normalize()
        {
            internal_UnityEngineQuaternion__func__Normalize__SystemVoid(ref this);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineQuaternion__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineQuaternion__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Quaternion other)
        {
            return internal_UnityEngineQuaternion__func__Equals__UnityEngineQuaternion__SystemBoolean(ref this, other);
        }

        public string ToString()
        {
            return internal_UnityEngineQuaternion__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineQuaternion__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineQuaternion__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__FromToRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(global::UnityEngine.Vector3 fromDirection, global::UnityEngine.Vector3 toDirection)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__FromToRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(Unsafe.AsPointer(ref fromDirection), Unsafe.AsPointer(ref toDirection), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Inverse__UnityEngineQuaternion__UnityEngineQuaternion(global::UnityEngine.Quaternion rotation)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Inverse__UnityEngineQuaternion__UnityEngineQuaternion(Unsafe.AsPointer(ref rotation), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Slerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Slerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__SlerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__SlerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Lerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Lerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__LerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b, float t)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__LerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), t, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__AngleAxis__SystemSingle__UnityEngineVector3__UnityEngineQuaternion(float angle, global::UnityEngine.Vector3 axis)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__AngleAxis__SystemSingle__UnityEngineVector3__UnityEngineQuaternion(angle, Unsafe.AsPointer(ref axis), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(global::UnityEngine.Vector3 forward, global::UnityEngine.Vector3 upwards)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(Unsafe.AsPointer(ref forward), Unsafe.AsPointer(ref upwards), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineQuaternion(global::UnityEngine.Vector3 forward)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineQuaternion(Unsafe.AsPointer(ref forward), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Quaternion selfStruct, global::UnityEngine.Vector3 view)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref view));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Quaternion selfStruct, global::UnityEngine.Vector3 view, global::UnityEngine.Vector3 up)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref view), Unsafe.AsPointer(ref up));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineQuaternion__func__Angle__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b)
        {
            var methodCallResult = UnityEngineQuaternion__func__Angle__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle(Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Euler__SystemSingle__SystemSingle__SystemSingle__UnityEngineQuaternion(float x, float y, float z)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Euler__SystemSingle__SystemSingle__SystemSingle__UnityEngineQuaternion(x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Euler__UnityEngineVector3__UnityEngineQuaternion(global::UnityEngine.Vector3 euler)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Euler__UnityEngineVector3__UnityEngineQuaternion(Unsafe.AsPointer(ref euler), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineQuaternion__func__ToAngleAxis__SystemSingleRef__UnityEngineVector3Ref__SystemVoid(ref global::UnityEngine.Quaternion selfStruct, out float angle, out global::UnityEngine.Vector3 axis)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            angle = default;
            axis = default;
            UnityEngineQuaternion__func__ToAngleAxis__SystemSingleRef__UnityEngineVector3Ref__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref angle), Unsafe.AsPointer(ref axis));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineQuaternion__func__SetFromToRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Quaternion selfStruct, global::UnityEngine.Vector3 fromDirection, global::UnityEngine.Vector3 toDirection)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineQuaternion__func__SetFromToRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref fromDirection), Unsafe.AsPointer(ref toDirection));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__RotateTowards__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(global::UnityEngine.Quaternion from, global::UnityEngine.Quaternion to, float maxDegreesDelta)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__RotateTowards__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(Unsafe.AsPointer(ref from), Unsafe.AsPointer(ref to), maxDegreesDelta, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineQuaternion__func__Normalize__UnityEngineQuaternion__UnityEngineQuaternion(global::UnityEngine.Quaternion q)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineQuaternion__func__Normalize__UnityEngineQuaternion__UnityEngineQuaternion(Unsafe.AsPointer(ref q), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineQuaternion__func__Normalize__SystemVoid(ref global::UnityEngine.Quaternion selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineQuaternion__func__Normalize__SystemVoid(selfStructPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineQuaternion__func__GetHashCode__SystemInt32(ref global::UnityEngine.Quaternion selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineQuaternion__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineQuaternion__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Quaternion selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineQuaternion__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineQuaternion__func__Equals__UnityEngineQuaternion__SystemBoolean(ref global::UnityEngine.Quaternion selfStruct, global::UnityEngine.Quaternion other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineQuaternion__func__Equals__UnityEngineQuaternion__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineQuaternion__func__ToString__SystemString(ref global::UnityEngine.Quaternion selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineQuaternion__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineQuaternion__func__ToString__SystemString__SystemString(ref global::UnityEngine.Quaternion selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineQuaternion__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineQuaternion__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Quaternion selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineQuaternion__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__FromToRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(void* fromDirectionPointer, void* toDirectionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Inverse__UnityEngineQuaternion__UnityEngineQuaternion(void* rotationPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Slerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__SlerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Lerp__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__LerpUnclamped__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(void* aPointer, void* bPointer, float t, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__AngleAxis__SystemSingle__UnityEngineVector3__UnityEngineQuaternion(float angle, void* axisPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion(void* forwardPointer, void* upwardsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__LookRotation__UnityEngineVector3__UnityEngineQuaternion(void* forwardPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* viewPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__SetLookRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* viewPointer, void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineQuaternion__func__Angle__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle(void* aPointer, void* bPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Euler__SystemSingle__SystemSingle__SystemSingle__UnityEngineQuaternion(float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Euler__UnityEngineVector3__UnityEngineQuaternion(void* eulerPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__ToAngleAxis__SystemSingleRef__UnityEngineVector3Ref__SystemVoid(void* selfStructPointer, void* anglePointer, void* axisPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__SetFromToRotation__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* fromDirectionPointer, void* toDirectionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__RotateTowards__UnityEngineQuaternion__UnityEngineQuaternion__SystemSingle__UnityEngineQuaternion(void* fromPointer, void* toPointer, float maxDegreesDelta, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Normalize__UnityEngineQuaternion__UnityEngineQuaternion(void* qPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__Normalize__SystemVoid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineQuaternion__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineQuaternion__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineQuaternion__func__Equals__UnityEngineQuaternion__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineQuaternion__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
