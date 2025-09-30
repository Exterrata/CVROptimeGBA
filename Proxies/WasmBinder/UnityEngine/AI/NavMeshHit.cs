//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.AI
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct NavMeshHit
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Position;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Vector3 m_Normal;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float m_Distance;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private int m_Mask;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private int m_Hit;

        public global::UnityEngine.Vector3 position 
        {
            get => internal_UnityEngineAINavMeshHit__get__position(ref this);
            set => internal_UnityEngineAINavMeshHit__set__position(ref this, value);
        }

        public global::UnityEngine.Vector3 normal 
        {
            get => internal_UnityEngineAINavMeshHit__get__normal(ref this);
            set => internal_UnityEngineAINavMeshHit__set__normal(ref this, value);
        }

        public float distance 
        {
            get => internal_UnityEngineAINavMeshHit__get__distance(ref this);
            set => internal_UnityEngineAINavMeshHit__set__distance(ref this, value);
        }

        public int mask 
        {
            get => internal_UnityEngineAINavMeshHit__get__mask(ref this);
            set => internal_UnityEngineAINavMeshHit__set__mask(ref this, value);
        }

        public bool hit 
        {
            get => internal_UnityEngineAINavMeshHit__get__hit(ref this);
            set => internal_UnityEngineAINavMeshHit__set__hit(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshHit__get__position(ref global::UnityEngine.AI.NavMeshHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 positionValue = default;
            UnityEngineAINavMeshHit__get__position(selfStructPointer, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector3 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshHit__set__position(ref global::UnityEngine.AI.NavMeshHit selfStruct, global::UnityEngine.Vector3 position)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshHit__set__position(selfStructPointer, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshHit__get__normal(ref global::UnityEngine.AI.NavMeshHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 normalValue = default;
            UnityEngineAINavMeshHit__get__normal(selfStructPointer, Unsafe.AsPointer(ref normalValue));
            global::UnityEngine.Vector3 returnResult = normalValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshHit__set__normal(ref global::UnityEngine.AI.NavMeshHit selfStruct, global::UnityEngine.Vector3 normal)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshHit__set__normal(selfStructPointer, Unsafe.AsPointer(ref normal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshHit__get__distance(ref global::UnityEngine.AI.NavMeshHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshHit__get__distance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshHit__set__distance(ref global::UnityEngine.AI.NavMeshHit selfStruct, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshHit__set__distance(selfStructPointer, distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshHit__get__mask(ref global::UnityEngine.AI.NavMeshHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshHit__get__mask(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshHit__set__mask(ref global::UnityEngine.AI.NavMeshHit selfStruct, int mask)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineAINavMeshHit__set__mask(selfStructPointer, mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshHit__get__hit(ref global::UnityEngine.AI.NavMeshHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAINavMeshHit__get__hit(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshHit__set__hit(ref global::UnityEngine.AI.NavMeshHit selfStruct, bool hit)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var hitConverted = Unsafe.As<bool, int>(ref hit);
            UnityEngineAINavMeshHit__set__hit(selfStructPointer, hitConverted);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__get__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__set__position(void* selfStructPointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__get__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__set__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAINavMeshHit__get__distance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__set__distance(void* selfStructPointer, float distance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshHit__get__mask(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__set__mask(void* selfStructPointer, int mask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshHit__get__hit(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshHit__set__hit(void* selfStructPointer, int hitConverted);

        #endregion Imports
    }
}
