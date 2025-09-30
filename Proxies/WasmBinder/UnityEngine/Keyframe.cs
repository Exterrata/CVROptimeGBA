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
    public partial struct Keyframe
    {

        #region Implementation

        public Keyframe(float time, float value)
        {
            internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle(ref this, time, value);
        }

        public Keyframe(float time, float value, float inTangent, float outTangent)
        {
            internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref this, time, value, inTangent, outTangent);
        }

        public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
        {
            internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref this, time, value, inTangent, outTangent, inWeight, outWeight);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private float m_Time;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float m_Value;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private float m_InTangent;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_OutTangent;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private int m_TangentMode;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private int m_WeightedMode;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float m_InWeight;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private float m_OutWeight;

        public float time 
        {
            get => internal_UnityEngineKeyframe__get__time(ref this);
            set => internal_UnityEngineKeyframe__set__time(ref this, value);
        }

        public float value 
        {
            get => internal_UnityEngineKeyframe__get__value(ref this);
            set => internal_UnityEngineKeyframe__set__value(ref this, value);
        }

        public float inTangent 
        {
            get => internal_UnityEngineKeyframe__get__inTangent(ref this);
            set => internal_UnityEngineKeyframe__set__inTangent(ref this, value);
        }

        public float outTangent 
        {
            get => internal_UnityEngineKeyframe__get__outTangent(ref this);
            set => internal_UnityEngineKeyframe__set__outTangent(ref this, value);
        }

        public float inWeight 
        {
            get => internal_UnityEngineKeyframe__get__inWeight(ref this);
            set => internal_UnityEngineKeyframe__set__inWeight(ref this, value);
        }

        public float outWeight 
        {
            get => internal_UnityEngineKeyframe__get__outWeight(ref this);
            set => internal_UnityEngineKeyframe__set__outWeight(ref this, value);
        }

        public global::UnityEngine.WeightedMode weightedMode 
        {
            get => internal_UnityEngineKeyframe__get__weightedMode(ref this);
            set => internal_UnityEngineKeyframe__set__weightedMode(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle(ref global::UnityEngine.Keyframe selfStruct, float time, float value)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__ctor__SystemSingle__SystemSingle(selfStructPointer, time, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.Keyframe selfStruct, float time, float value, float inTangent, float outTangent)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, time, value, inTangent, outTangent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.Keyframe selfStruct, float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, time, value, inTangent, outTangent, inWeight, outWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__time(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__time(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__time(ref global::UnityEngine.Keyframe selfStruct, float time)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__time(selfStructPointer, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__value(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__value(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__value(ref global::UnityEngine.Keyframe selfStruct, float value)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__value(selfStructPointer, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__inTangent(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__inTangent(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__inTangent(ref global::UnityEngine.Keyframe selfStruct, float inTangent)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__inTangent(selfStructPointer, inTangent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__outTangent(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__outTangent(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__outTangent(ref global::UnityEngine.Keyframe selfStruct, float outTangent)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__outTangent(selfStructPointer, outTangent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__inWeight(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__inWeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__inWeight(ref global::UnityEngine.Keyframe selfStruct, float inWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__inWeight(selfStructPointer, inWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineKeyframe__get__outWeight(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__outWeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__outWeight(ref global::UnityEngine.Keyframe selfStruct, float outWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__outWeight(selfStructPointer, outWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.WeightedMode internal_UnityEngineKeyframe__get__weightedMode(ref global::UnityEngine.Keyframe selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineKeyframe__get__weightedMode(selfStructPointer);
            var returnResult = (global::UnityEngine.WeightedMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineKeyframe__set__weightedMode(ref global::UnityEngine.Keyframe selfStruct, global::UnityEngine.WeightedMode weightedMode)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineKeyframe__set__weightedMode(selfStructPointer, (int) weightedMode);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__ctor__SystemSingle__SystemSingle(void* selfStructPointer, float time, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float time, float value, float inTangent, float outTangent);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__ctor__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float time, float value, float inTangent, float outTangent, float inWeight, float outWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__time(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__time(void* selfStructPointer, float time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__value(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__value(void* selfStructPointer, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__inTangent(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__inTangent(void* selfStructPointer, float inTangent);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__outTangent(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__outTangent(void* selfStructPointer, float outTangent);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__inWeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__inWeight(void* selfStructPointer, float inWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineKeyframe__get__outWeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__outWeight(void* selfStructPointer, float outWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineKeyframe__get__weightedMode(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineKeyframe__set__weightedMode(void* selfStructPointer, int weightedModeUnderlyingValue);

        #endregion Imports
    }
}
