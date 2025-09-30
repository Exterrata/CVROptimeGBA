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
    public partial struct MatchTargetWeightMask
    {

        #region Implementation

        public MatchTargetWeightMask(global::UnityEngine.Vector3 positionXYZWeight, float rotationWeight)
        {
            internal_UnityEngineMatchTargetWeightMask__ctor__UnityEngineVector3__SystemSingle(ref this, positionXYZWeight, rotationWeight);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_PositionXYZWeight;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_RotationWeight;

        public global::UnityEngine.Vector3 positionXYZWeight 
        {
            get => internal_UnityEngineMatchTargetWeightMask__get__positionXYZWeight(ref this);
            set => internal_UnityEngineMatchTargetWeightMask__set__positionXYZWeight(ref this, value);
        }

        public float rotationWeight 
        {
            get => internal_UnityEngineMatchTargetWeightMask__get__rotationWeight(ref this);
            set => internal_UnityEngineMatchTargetWeightMask__set__rotationWeight(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMatchTargetWeightMask__ctor__UnityEngineVector3__SystemSingle(ref global::UnityEngine.MatchTargetWeightMask selfStruct, global::UnityEngine.Vector3 positionXYZWeight, float rotationWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineMatchTargetWeightMask__ctor__UnityEngineVector3__SystemSingle(selfStructPointer, Unsafe.AsPointer(ref positionXYZWeight), rotationWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineMatchTargetWeightMask__get__positionXYZWeight(ref global::UnityEngine.MatchTargetWeightMask selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 positionXYZWeightValue = default;
            UnityEngineMatchTargetWeightMask__get__positionXYZWeight(selfStructPointer, Unsafe.AsPointer(ref positionXYZWeightValue));
            global::UnityEngine.Vector3 returnResult = positionXYZWeightValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMatchTargetWeightMask__set__positionXYZWeight(ref global::UnityEngine.MatchTargetWeightMask selfStruct, global::UnityEngine.Vector3 positionXYZWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineMatchTargetWeightMask__set__positionXYZWeight(selfStructPointer, Unsafe.AsPointer(ref positionXYZWeight));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMatchTargetWeightMask__get__rotationWeight(ref global::UnityEngine.MatchTargetWeightMask selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineMatchTargetWeightMask__get__rotationWeight(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMatchTargetWeightMask__set__rotationWeight(ref global::UnityEngine.MatchTargetWeightMask selfStruct, float rotationWeight)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineMatchTargetWeightMask__set__rotationWeight(selfStructPointer, rotationWeight);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatchTargetWeightMask__ctor__UnityEngineVector3__SystemSingle(void* selfStructPointer, void* positionXYZWeightPointer, float rotationWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatchTargetWeightMask__get__positionXYZWeight(void* selfStructPointer, void* positionXYZWeightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatchTargetWeightMask__set__positionXYZWeight(void* selfStructPointer, void* positionXYZWeightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMatchTargetWeightMask__get__rotationWeight(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMatchTargetWeightMask__set__rotationWeight(void* selfStructPointer, float rotationWeight);

        #endregion Imports
    }
}
