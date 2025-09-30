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
    public partial struct Bounds
    {

        #region Implementation

        public Bounds(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 size)
        {
            internal_UnityEngineBounds__ctor__UnityEngineVector3__UnityEngineVector3(ref this, center, size);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Center;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Extents;

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineBounds__get__center(ref this);
            set => internal_UnityEngineBounds__set__center(ref this, value);
        }

        public global::UnityEngine.Vector3 size 
        {
            get => internal_UnityEngineBounds__get__size(ref this);
            set => internal_UnityEngineBounds__set__size(ref this, value);
        }

        public global::UnityEngine.Vector3 extents 
        {
            get => internal_UnityEngineBounds__get__extents(ref this);
            set => internal_UnityEngineBounds__set__extents(ref this, value);
        }

        public global::UnityEngine.Vector3 min 
        {
            get => internal_UnityEngineBounds__get__min(ref this);
            set => internal_UnityEngineBounds__set__min(ref this, value);
        }

        public global::UnityEngine.Vector3 max 
        {
            get => internal_UnityEngineBounds__get__max(ref this);
            set => internal_UnityEngineBounds__set__max(ref this, value);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineBounds__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineBounds__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Bounds other)
        {
            return internal_UnityEngineBounds__func__Equals__UnityEngineBounds__SystemBoolean(ref this, other);
        }

        public void SetMinMax(global::UnityEngine.Vector3 min, global::UnityEngine.Vector3 max)
        {
            internal_UnityEngineBounds__func__SetMinMax__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref this, min, max);
        }

        public void Encapsulate(global::UnityEngine.Vector3 point)
        {
            internal_UnityEngineBounds__func__Encapsulate__UnityEngineVector3__SystemVoid(ref this, point);
        }

        public void Encapsulate(global::UnityEngine.Bounds bounds)
        {
            internal_UnityEngineBounds__func__Encapsulate__UnityEngineBounds__SystemVoid(ref this, bounds);
        }

        public void Expand(float amount)
        {
            internal_UnityEngineBounds__func__Expand__SystemSingle__SystemVoid(ref this, amount);
        }

        public void Expand(global::UnityEngine.Vector3 amount)
        {
            internal_UnityEngineBounds__func__Expand__UnityEngineVector3__SystemVoid(ref this, amount);
        }

        public bool Intersects(global::UnityEngine.Bounds bounds)
        {
            return internal_UnityEngineBounds__func__Intersects__UnityEngineBounds__SystemBoolean(ref this, bounds);
        }

        public bool IntersectRay(global::UnityEngine.Ray ray)
        {
            return internal_UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemBoolean(ref this, ray);
        }

        public bool IntersectRay(global::UnityEngine.Ray ray, out float distance)
        {
            return internal_UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemSingleRef__SystemBoolean(ref this, ray, out distance);
        }

        public string ToString()
        {
            return internal_UnityEngineBounds__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEngineBounds__func__ToString__SystemString__SystemString(ref this, format);
        }

        public string ToString(string format, global::System.IFormatProvider formatProvider)
        {
            return internal_UnityEngineBounds__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref this, format, formatProvider);
        }

        public bool Contains(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEngineBounds__func__Contains__UnityEngineVector3__SystemBoolean(ref this, point);
        }

        public float SqrDistance(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEngineBounds__func__SqrDistance__UnityEngineVector3__SystemSingle(ref this, point);
        }

        public global::UnityEngine.Vector3 ClosestPoint(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEngineBounds__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(ref this, point);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__ctor__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__ctor__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__get__center(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineBounds__get__center(selfStructPointer, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__set__center(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 center)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__set__center(selfStructPointer, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__get__size(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 sizeValue = default;
            UnityEngineBounds__get__size(selfStructPointer, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector3 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__set__size(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 size)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__set__size(selfStructPointer, Unsafe.AsPointer(ref size));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__get__extents(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 extentsValue = default;
            UnityEngineBounds__get__extents(selfStructPointer, Unsafe.AsPointer(ref extentsValue));
            global::UnityEngine.Vector3 returnResult = extentsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__set__extents(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 extents)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__set__extents(selfStructPointer, Unsafe.AsPointer(ref extents));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__get__min(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 minValue = default;
            UnityEngineBounds__get__min(selfStructPointer, Unsafe.AsPointer(ref minValue));
            global::UnityEngine.Vector3 returnResult = minValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__set__min(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 min)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__set__min(selfStructPointer, Unsafe.AsPointer(ref min));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__get__max(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 maxValue = default;
            UnityEngineBounds__get__max(selfStructPointer, Unsafe.AsPointer(ref maxValue));
            global::UnityEngine.Vector3 returnResult = maxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__set__max(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__set__max(selfStructPointer, Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineBounds__func__GetHashCode__SystemInt32(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineBounds__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__Equals__UnityEngineBounds__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Bounds other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__Equals__UnityEngineBounds__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__func__SetMinMax__UnityEngineVector3__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 min, global::UnityEngine.Vector3 max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__func__SetMinMax__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref min), Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__func__Encapsulate__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__func__Encapsulate__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref point));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__func__Encapsulate__UnityEngineBounds__SystemVoid(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Bounds bounds)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__func__Encapsulate__UnityEngineBounds__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref bounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__func__Expand__SystemSingle__SystemVoid(ref global::UnityEngine.Bounds selfStruct, float amount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__func__Expand__SystemSingle__SystemVoid(selfStructPointer, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineBounds__func__Expand__UnityEngineVector3__SystemVoid(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 amount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineBounds__func__Expand__UnityEngineVector3__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref amount));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__Intersects__UnityEngineBounds__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Bounds bounds)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__Intersects__UnityEngineBounds__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref bounds));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Ray ray)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref ray));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemSingleRef__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Ray ray, out float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            distance = default;
            var methodCallResult = UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemSingleRef__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref distance));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineBounds__func__ToString__SystemString(ref global::UnityEngine.Bounds selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineBounds__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineBounds__func__ToString__SystemString__SystemString(ref global::UnityEngine.Bounds selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineBounds__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineBounds__func__ToString__SystemString__SystemIFormatProvider__SystemString(ref global::UnityEngine.Bounds selfStruct, string format, global::System.IFormatProvider formatProvider)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                // Todo: throw new global::System.NotImplementedException("The type global::System.IFormatProvider is not implemented yet! We need to find a way to pass non-wrapped instances...");
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineBounds__func__ToString__SystemString__SystemIFormatProvider__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), 0 /* Todo: Fix this */, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineBounds__func__Contains__UnityEngineVector3__SystemBoolean(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__Contains__UnityEngineVector3__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineBounds__func__SqrDistance__UnityEngineVector3__SystemSingle(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineBounds__func__SqrDistance__UnityEngineVector3__SystemSingle(selfStructPointer, Unsafe.AsPointer(ref point));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineBounds__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(ref global::UnityEngine.Bounds selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineBounds__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(selfStructPointer, Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__ctor__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* centerPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__get__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__set__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__get__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__set__size(void* selfStructPointer, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__get__extents(void* selfStructPointer, void* extentsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__set__extents(void* selfStructPointer, void* extentsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__get__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__set__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__get__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__set__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__Equals__UnityEngineBounds__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__SetMinMax__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* minPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__Encapsulate__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__Encapsulate__UnityEngineBounds__SystemVoid(void* selfStructPointer, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__Expand__SystemSingle__SystemVoid(void* selfStructPointer, float amount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__Expand__UnityEngineVector3__SystemVoid(void* selfStructPointer, void* amountPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__Intersects__UnityEngineBounds__SystemBoolean(void* selfStructPointer, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemBoolean(void* selfStructPointer, void* rayPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__IntersectRay__UnityEngineRay__SystemSingleRef__SystemBoolean(void* selfStructPointer, void* rayPointer, void* distancePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__ToString__SystemString__SystemIFormatProvider__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, long formatProviderObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineBounds__func__Contains__UnityEngineVector3__SystemBoolean(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineBounds__func__SqrDistance__UnityEngineVector3__SystemSingle(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineBounds__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(void* selfStructPointer, void* pointPointer, void* returnResultPointer);

        #endregion Imports
    }
}
