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
    public partial struct Plane
    {

        #region Implementation

        public Plane(global::UnityEngine.Vector3 inNormal, global::UnityEngine.Vector3 inPoint)
        {
            internal_UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3(ref this, inNormal, inPoint);
        }

        public Plane(global::UnityEngine.Vector3 inNormal, float d)
        {
            internal_UnityEnginePlane__ctor__UnityEngineVector3__SystemSingle(ref this, inNormal, d);
        }

        public Plane(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c)
        {
            internal_UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3(ref this, a, b, c);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Normal;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_Distance;

        public global::UnityEngine.Vector3 normal 
        {
            get => internal_UnityEnginePlane__get__normal(ref this);
            set => internal_UnityEnginePlane__set__normal(ref this, value);
        }

        public float distance 
        {
            get => internal_UnityEnginePlane__get__distance(ref this);
            set => internal_UnityEnginePlane__set__distance(ref this, value);
        }

        public global::UnityEngine.Plane flipped 
        {
            get => internal_UnityEnginePlane__get__flipped(ref this);
        }

        public void SetNormalAndPosition(global::UnityEngine.Vector3 inNormal, global::UnityEngine.Vector3 inPoint)
        {
            internal_UnityEnginePlane__func__SetNormalAndPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref this, inNormal, inPoint);
        }

        public void Set3Points(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c)
        {
            internal_UnityEnginePlane__func__Set3Points__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref this, a, b, c);
        }

        public void Flip()
        {
            internal_UnityEnginePlane__func__Flip__SystemVoid(ref this);
        }

        public void Translate(global::UnityEngine.Vector3 translation)
        {
            internal_UnityEnginePlane__func__Translate__UnityEngineVector3__SystemVoid(ref this, translation);
        }

        public static global::UnityEngine.Plane Translate(global::UnityEngine.Plane plane, global::UnityEngine.Vector3 translation)
        {
            return internal_UnityEnginePlane__func__Translate__UnityEnginePlane__UnityEngineVector3__UnityEnginePlane(plane, translation);
        }

        public global::UnityEngine.Vector3 ClosestPointOnPlane(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEnginePlane__func__ClosestPointOnPlane__UnityEngineVector3__UnityEngineVector3(ref this, point);
        }

        public float GetDistanceToPoint(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEnginePlane__func__GetDistanceToPoint__UnityEngineVector3__SystemSingle(ref this, point);
        }

        public bool GetSide(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEnginePlane__func__GetSide__UnityEngineVector3__SystemBoolean(ref this, point);
        }

        public bool SameSide(global::UnityEngine.Vector3 inPt0, global::UnityEngine.Vector3 inPt1)
        {
            return internal_UnityEnginePlane__func__SameSide__UnityEngineVector3__UnityEngineVector3__SystemBoolean(ref this, inPt0, inPt1);
        }

        public bool Raycast(global::UnityEngine.Ray ray, out float enter)
        {
            return internal_UnityEnginePlane__func__Raycast__UnityEngineRay__SystemSingleRef__SystemBoolean(ref this, ray, out enter);
        }

        public string ToString()
        {
            return internal_UnityEnginePlane__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEnginePlane__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEnginePlane__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 inNormal, global::UnityEngine.Vector3 inPoint)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref inNormal), Unsafe.AsPointer(ref inPoint));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__ctor__UnityEngineVector3__SystemSingle(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 inNormal, float d)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__ctor__UnityEngineVector3__SystemSingle(selfStructPointer, Unsafe.AsPointer(ref inNormal), d);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), Unsafe.AsPointer(ref c));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePlane__get__normal(ref global::UnityEngine.Plane selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 normalValue = default;
            UnityEnginePlane__get__normal(selfStructPointer, Unsafe.AsPointer(ref normalValue));
            global::UnityEngine.Vector3 returnResult = normalValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__set__normal(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 normal)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__set__normal(selfStructPointer, Unsafe.AsPointer(ref normal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePlane__get__distance(ref global::UnityEngine.Plane selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePlane__get__distance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__set__distance(ref global::UnityEngine.Plane selfStruct, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__set__distance(selfStructPointer, distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Plane internal_UnityEnginePlane__get__flipped(ref global::UnityEngine.Plane selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Plane flippedValue = default;
            UnityEnginePlane__get__flipped(selfStructPointer, Unsafe.AsPointer(ref flippedValue));
            global::UnityEngine.Plane returnResult = flippedValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__func__SetNormalAndPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 inNormal, global::UnityEngine.Vector3 inPoint)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__func__SetNormalAndPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref inNormal), Unsafe.AsPointer(ref inPoint));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__func__Set3Points__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__func__Set3Points__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref a), Unsafe.AsPointer(ref b), Unsafe.AsPointer(ref c));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__func__Flip__SystemVoid(ref global::UnityEngine.Plane selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__func__Flip__SystemVoid(selfStructPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePlane__func__Translate__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 translation)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePlane__func__Translate__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref translation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Plane internal_UnityEnginePlane__func__Translate__UnityEnginePlane__UnityEngineVector3__UnityEnginePlane(global::UnityEngine.Plane plane, global::UnityEngine.Vector3 translation)
        {
            global::UnityEngine.Plane returnResultValue = default;
            UnityEnginePlane__func__Translate__UnityEnginePlane__UnityEngineVector3__UnityEnginePlane(Unsafe.AsPointer(ref plane), Unsafe.AsPointer(ref translation), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Plane returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePlane__func__ClosestPointOnPlane__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEnginePlane__func__ClosestPointOnPlane__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePlane__func__GetDistanceToPoint__UnityEngineVector3__SystemSingle(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePlane__func__GetDistanceToPoint__UnityEngineVector3__SystemSingle(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePlane__func__GetSide__UnityEngineVector3__SystemBoolean(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePlane__func__GetSide__UnityEngineVector3__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePlane__func__SameSide__UnityEngineVector3__UnityEngineVector3__SystemBoolean(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Vector3 inPt0, global::UnityEngine.Vector3 inPt1)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePlane__func__SameSide__UnityEngineVector3__UnityEngineVector3__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref inPt0), Unsafe.AsPointer(ref inPt1));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePlane__func__Raycast__UnityEngineRay__SystemSingleRef__SystemBoolean(ref global::UnityEngine.Plane selfStruct, global::UnityEngine.Ray ray, out float enter)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            enter = default;
            var methodCallResult = UnityEnginePlane__func__Raycast__UnityEngineRay__SystemSingleRef__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref enter));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePlane__func__ToString__SystemString(ref global::UnityEngine.Plane selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePlane__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePlane__func__ToString__SystemString__SystemString(ref global::UnityEngine.Plane selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEnginePlane__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePlane__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Plane selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEnginePlane__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* inNormalPointer, void* inPointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__ctor__UnityEngineVector3__SystemSingle(void* selfStructPointer, void* inNormalPointer, float d);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__ctor__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* aPointer, void* bPointer, void* cPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__get__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__set__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEnginePlane__get__distance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__set__distance(void* selfStructPointer, float distance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__get__flipped(void* selfStructPointer, void* flippedPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__SetNormalAndPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* inNormalPointer, void* inPointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__Set3Points__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* aPointer, void* bPointer, void* cPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__Flip__SystemVoid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__Translate__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* translationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__Translate__UnityEnginePlane__UnityEngineVector3__UnityEnginePlane(void* planePointer, void* translationPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__ClosestPointOnPlane__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* pointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEnginePlane__func__GetDistanceToPoint__UnityEngineVector3__SystemSingle(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePlane__func__GetSide__UnityEngineVector3__SystemBoolean(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePlane__func__SameSide__UnityEngineVector3__UnityEngineVector3__SystemBoolean(void* selfStructPointer, void* inPt0Pointer, void* inPt1Pointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePlane__func__Raycast__UnityEngineRay__SystemSingleRef__SystemBoolean(void* selfStructPointer, void* rayPointer, void* enterPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePlane__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
