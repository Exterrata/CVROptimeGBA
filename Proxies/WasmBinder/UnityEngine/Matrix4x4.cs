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
    public partial struct Matrix4x4
    {

        #region Implementation

        public global::UnityEngine.Quaternion rotation 
        {
            get => internal_UnityEngineMatrix4x4__get__rotation(ref this);
        }

        public global::UnityEngine.Vector3 lossyScale 
        {
            get => internal_UnityEngineMatrix4x4__get__lossyScale(ref this);
        }

        public bool isIdentity 
        {
            get => internal_UnityEngineMatrix4x4__get__isIdentity(ref this);
        }

        public float determinant 
        {
            get => internal_UnityEngineMatrix4x4__get__determinant(ref this);
        }

        public global::UnityEngine.FrustumPlanes decomposeProjection 
        {
            get => internal_UnityEngineMatrix4x4__get__decomposeProjection(ref this);
        }

        public global::UnityEngine.Matrix4x4 inverse 
        {
            get => internal_UnityEngineMatrix4x4__get__inverse(ref this);
        }

        public global::UnityEngine.Matrix4x4 transpose 
        {
            get => internal_UnityEngineMatrix4x4__get__transpose(ref this);
        }

        public bool ValidTRS()
        {
            return internal_UnityEngineMatrix4x4__func__ValidTRS__SystemBoolean(ref this);
        }

        public static float Determinant(global::UnityEngine.Matrix4x4 m)
        {
            return internal_UnityEngineMatrix4x4__func__Determinant__UnityEngineMatrix4x4__SystemSingle(m);
        }

        public static global::UnityEngine.Matrix4x4 TRS(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion q, global::UnityEngine.Vector3 s)
        {
            return internal_UnityEngineMatrix4x4__func__TRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__UnityEngineMatrix4x4(pos, q, s);
        }

        public void SetTRS(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion q, global::UnityEngine.Vector3 s)
        {
            internal_UnityEngineMatrix4x4__func__SetTRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__SystemVoid(ref this, pos, q, s);
        }

        public static bool Inverse3DAffine(global::UnityEngine.Matrix4x4 input, ref global::UnityEngine.Matrix4x4 result)
        {
            return internal_UnityEngineMatrix4x4__func__Inverse3DAffine__UnityEngineMatrix4x4__UnityEngineMatrix4x4Ref__SystemBoolean(input, ref result);
        }

        public static global::UnityEngine.Matrix4x4 Inverse(global::UnityEngine.Matrix4x4 m)
        {
            return internal_UnityEngineMatrix4x4__func__Inverse__UnityEngineMatrix4x4__UnityEngineMatrix4x4(m);
        }

        public static global::UnityEngine.Matrix4x4 Transpose(global::UnityEngine.Matrix4x4 m)
        {
            return internal_UnityEngineMatrix4x4__func__Transpose__UnityEngineMatrix4x4__UnityEngineMatrix4x4(m);
        }

        public static global::UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            return internal_UnityEngineMatrix4x4__func__Ortho__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(left, right, bottom, top, zNear, zFar);
        }

        public static global::UnityEngine.Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
        {
            return internal_UnityEngineMatrix4x4__func__Perspective__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(fov, aspect, zNear, zFar);
        }

        public static global::UnityEngine.Matrix4x4 LookAt(global::UnityEngine.Vector3 from, global::UnityEngine.Vector3 to, global::UnityEngine.Vector3 up)
        {
            return internal_UnityEngineMatrix4x4__func__LookAt__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineMatrix4x4(from, to, up);
        }

        public static global::UnityEngine.Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            return internal_UnityEngineMatrix4x4__func__Frustum__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(left, right, bottom, top, zNear, zFar);
        }

        public static global::UnityEngine.Matrix4x4 Frustum(global::UnityEngine.FrustumPlanes fp)
        {
            return internal_UnityEngineMatrix4x4__func__Frustum__UnityEngineFrustumPlanes__UnityEngineMatrix4x4(fp);
        }

        public string ToString()
        {
            return internal_UnityEngineMatrix4x4__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineMatrix4x4__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineMatrix4x4__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineMatrix4x4__get__rotation(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Quaternion rotationValue = default;
            UnityEngineMatrix4x4__get__rotation(selfStructPointer, Unsafe.AsPointer(ref rotationValue));
            global::UnityEngine.Quaternion returnResult = rotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineMatrix4x4__get__lossyScale(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 lossyScaleValue = default;
            UnityEngineMatrix4x4__get__lossyScale(selfStructPointer, Unsafe.AsPointer(ref lossyScaleValue));
            global::UnityEngine.Vector3 returnResult = lossyScaleValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMatrix4x4__get__isIdentity(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineMatrix4x4__get__isIdentity(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMatrix4x4__get__determinant(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineMatrix4x4__get__determinant(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.FrustumPlanes internal_UnityEngineMatrix4x4__get__decomposeProjection(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.FrustumPlanes decomposeProjectionValue = default;
            UnityEngineMatrix4x4__get__decomposeProjection(selfStructPointer, Unsafe.AsPointer(ref decomposeProjectionValue));
            global::UnityEngine.FrustumPlanes returnResult = decomposeProjectionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__get__inverse(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 inverseValue = default;
            UnityEngineMatrix4x4__get__inverse(selfStructPointer, Unsafe.AsPointer(ref inverseValue));
            global::UnityEngine.Matrix4x4 returnResult = inverseValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__get__transpose(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Matrix4x4 transposeValue = default;
            UnityEngineMatrix4x4__get__transpose(selfStructPointer, Unsafe.AsPointer(ref transposeValue));
            global::UnityEngine.Matrix4x4 returnResult = transposeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMatrix4x4__func__ValidTRS__SystemBoolean(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineMatrix4x4__func__ValidTRS__SystemBoolean(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMatrix4x4__func__Determinant__UnityEngineMatrix4x4__SystemSingle(global::UnityEngine.Matrix4x4 m)
        {
            var methodCallResult = UnityEngineMatrix4x4__func__Determinant__UnityEngineMatrix4x4__SystemSingle(Unsafe.AsPointer(ref m));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__TRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__UnityEngineMatrix4x4(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion q, global::UnityEngine.Vector3 s)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__TRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__UnityEngineMatrix4x4(Unsafe.AsPointer(ref pos), Unsafe.AsPointer(ref q), Unsafe.AsPointer(ref s), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMatrix4x4__func__SetTRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Matrix4x4 selfStruct, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion q, global::UnityEngine.Vector3 s)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineMatrix4x4__func__SetTRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref pos), Unsafe.AsPointer(ref q), Unsafe.AsPointer(ref s));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMatrix4x4__func__Inverse3DAffine__UnityEngineMatrix4x4__UnityEngineMatrix4x4Ref__SystemBoolean(global::UnityEngine.Matrix4x4 input, ref global::UnityEngine.Matrix4x4 result)
        {
            var methodCallResult = UnityEngineMatrix4x4__func__Inverse3DAffine__UnityEngineMatrix4x4__UnityEngineMatrix4x4Ref__SystemBoolean(Unsafe.AsPointer(ref input), Unsafe.AsPointer(ref result));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Inverse__UnityEngineMatrix4x4__UnityEngineMatrix4x4(global::UnityEngine.Matrix4x4 m)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Inverse__UnityEngineMatrix4x4__UnityEngineMatrix4x4(Unsafe.AsPointer(ref m), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Transpose__UnityEngineMatrix4x4__UnityEngineMatrix4x4(global::UnityEngine.Matrix4x4 m)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Transpose__UnityEngineMatrix4x4__UnityEngineMatrix4x4(Unsafe.AsPointer(ref m), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Ortho__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Ortho__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(left, right, bottom, top, zNear, zFar, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Perspective__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float fov, float aspect, float zNear, float zFar)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Perspective__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(fov, aspect, zNear, zFar, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__LookAt__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineMatrix4x4(global::UnityEngine.Vector3 from, global::UnityEngine.Vector3 to, global::UnityEngine.Vector3 up)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__LookAt__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineMatrix4x4(Unsafe.AsPointer(ref from), Unsafe.AsPointer(ref to), Unsafe.AsPointer(ref up), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Frustum__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Frustum__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(left, right, bottom, top, zNear, zFar, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMatrix4x4__func__Frustum__UnityEngineFrustumPlanes__UnityEngineMatrix4x4(global::UnityEngine.FrustumPlanes fp)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMatrix4x4__func__Frustum__UnityEngineFrustumPlanes__UnityEngineMatrix4x4(Unsafe.AsPointer(ref fp), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMatrix4x4__func__ToString__SystemString(ref global::UnityEngine.Matrix4x4 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMatrix4x4__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMatrix4x4__func__ToString__SystemString__SystemString(ref global::UnityEngine.Matrix4x4 selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMatrix4x4__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMatrix4x4__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Matrix4x4 selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMatrix4x4__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__get__rotation(void* selfStructPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__get__lossyScale(void* selfStructPointer, void* lossyScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMatrix4x4__get__isIdentity(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMatrix4x4__get__determinant(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__get__decomposeProjection(void* selfStructPointer, void* decomposeProjectionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__get__inverse(void* selfStructPointer, void* inversePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__get__transpose(void* selfStructPointer, void* transposePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMatrix4x4__func__ValidTRS__SystemBoolean(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMatrix4x4__func__Determinant__UnityEngineMatrix4x4__SystemSingle(void* mPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__TRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__UnityEngineMatrix4x4(void* posPointer, void* qPointer, void* sPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__SetTRS__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* posPointer, void* qPointer, void* sPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMatrix4x4__func__Inverse3DAffine__UnityEngineMatrix4x4__UnityEngineMatrix4x4Ref__SystemBoolean(void* inputPointer, void* resultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Inverse__UnityEngineMatrix4x4__UnityEngineMatrix4x4(void* mPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Transpose__UnityEngineMatrix4x4__UnityEngineMatrix4x4(void* mPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Ortho__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float left, float right, float bottom, float top, float zNear, float zFar, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Perspective__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float fov, float aspect, float zNear, float zFar, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__LookAt__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineMatrix4x4(void* fromPointer, void* toPointer, void* upPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Frustum__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineMatrix4x4(float left, float right, float bottom, float top, float zNear, float zFar, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__Frustum__UnityEngineFrustumPlanes__UnityEngineMatrix4x4(void* fpPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatrix4x4__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
