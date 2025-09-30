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
    public partial struct HumanLimit
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Min;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Max;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Center;

        // [FieldOffset(36)] (implicit field offset from sequential layout kind)
        private float m_AxisLength;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        private int m_UseDefaultValues;

        public bool useDefaultValues 
        {
            get => internal_UnityEngineHumanLimit__get__useDefaultValues(ref this);
            set => internal_UnityEngineHumanLimit__set__useDefaultValues(ref this, value);
        }

        public global::UnityEngine.Vector3 min 
        {
            get => internal_UnityEngineHumanLimit__get__min(ref this);
            set => internal_UnityEngineHumanLimit__set__min(ref this, value);
        }

        public global::UnityEngine.Vector3 max 
        {
            get => internal_UnityEngineHumanLimit__get__max(ref this);
            set => internal_UnityEngineHumanLimit__set__max(ref this, value);
        }

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineHumanLimit__get__center(ref this);
            set => internal_UnityEngineHumanLimit__set__center(ref this, value);
        }

        public float axisLength 
        {
            get => internal_UnityEngineHumanLimit__get__axisLength(ref this);
            set => internal_UnityEngineHumanLimit__set__axisLength(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineHumanLimit__get__useDefaultValues(ref global::UnityEngine.HumanLimit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHumanLimit__get__useDefaultValues(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanLimit__set__useDefaultValues(ref global::UnityEngine.HumanLimit selfStruct, bool useDefaultValues)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var useDefaultValuesConverted = Unsafe.As<bool, int>(ref useDefaultValues);
            UnityEngineHumanLimit__set__useDefaultValues(selfStructPointer, useDefaultValuesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineHumanLimit__get__min(ref global::UnityEngine.HumanLimit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 minValue = default;
            UnityEngineHumanLimit__get__min(selfStructPointer, Unsafe.AsPointer(ref minValue));
            global::UnityEngine.Vector3 returnResult = minValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanLimit__set__min(ref global::UnityEngine.HumanLimit selfStruct, global::UnityEngine.Vector3 min)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHumanLimit__set__min(selfStructPointer, Unsafe.AsPointer(ref min));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineHumanLimit__get__max(ref global::UnityEngine.HumanLimit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 maxValue = default;
            UnityEngineHumanLimit__get__max(selfStructPointer, Unsafe.AsPointer(ref maxValue));
            global::UnityEngine.Vector3 returnResult = maxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanLimit__set__max(ref global::UnityEngine.HumanLimit selfStruct, global::UnityEngine.Vector3 max)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHumanLimit__set__max(selfStructPointer, Unsafe.AsPointer(ref max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineHumanLimit__get__center(ref global::UnityEngine.HumanLimit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineHumanLimit__get__center(selfStructPointer, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanLimit__set__center(ref global::UnityEngine.HumanLimit selfStruct, global::UnityEngine.Vector3 center)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHumanLimit__set__center(selfStructPointer, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanLimit__get__axisLength(ref global::UnityEngine.HumanLimit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineHumanLimit__get__axisLength(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanLimit__set__axisLength(ref global::UnityEngine.HumanLimit selfStruct, float axisLength)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineHumanLimit__set__axisLength(selfStructPointer, axisLength);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineHumanLimit__get__useDefaultValues(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__set__useDefaultValues(void* selfStructPointer, int useDefaultValuesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__get__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__set__min(void* selfStructPointer, void* minPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__get__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__set__max(void* selfStructPointer, void* maxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__get__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__set__center(void* selfStructPointer, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineHumanLimit__get__axisLength(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanLimit__set__axisLength(void* selfStructPointer, float axisLength);

        #endregion Imports
    }
}
