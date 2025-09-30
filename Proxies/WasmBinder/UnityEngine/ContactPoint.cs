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
    public partial struct ContactPoint
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_Point;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_Normal;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        internal int m_ThisColliderInstanceID;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        internal int m_OtherColliderInstanceID;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        internal float m_Separation;

        public global::UnityEngine.Vector3 point 
        {
            get => internal_UnityEngineContactPoint__get__point(ref this);
        }

        public global::UnityEngine.Vector3 normal 
        {
            get => internal_UnityEngineContactPoint__get__normal(ref this);
        }

        public global::UnityEngine.Collider thisCollider 
        {
            get => internal_UnityEngineContactPoint__get__thisCollider(ref this);
        }

        public global::UnityEngine.Collider otherCollider 
        {
            get => internal_UnityEngineContactPoint__get__otherCollider(ref this);
        }

        public float separation 
        {
            get => internal_UnityEngineContactPoint__get__separation(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineContactPoint__get__point(ref global::UnityEngine.ContactPoint selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 pointValue = default;
            UnityEngineContactPoint__get__point(selfStructPointer, Unsafe.AsPointer(ref pointValue));
            global::UnityEngine.Vector3 returnResult = pointValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineContactPoint__get__normal(ref global::UnityEngine.ContactPoint selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 normalValue = default;
            UnityEngineContactPoint__get__normal(selfStructPointer, Unsafe.AsPointer(ref normalValue));
            global::UnityEngine.Vector3 returnResult = normalValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider internal_UnityEngineContactPoint__get__thisCollider(ref global::UnityEngine.ContactPoint selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineContactPoint__get__thisCollider(selfStructPointer);
            var returnResult = new global::UnityEngine.Collider(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider internal_UnityEngineContactPoint__get__otherCollider(ref global::UnityEngine.ContactPoint selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineContactPoint__get__otherCollider(selfStructPointer);
            var returnResult = new global::UnityEngine.Collider(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineContactPoint__get__separation(ref global::UnityEngine.ContactPoint selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineContactPoint__get__separation(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineContactPoint__get__point(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineContactPoint__get__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineContactPoint__get__thisCollider(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineContactPoint__get__otherCollider(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineContactPoint__get__separation(void* selfStructPointer);

        #endregion Imports
    }
}
