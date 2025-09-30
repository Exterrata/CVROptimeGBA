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

    public partial class Collider(long id) : Component(id)
    {

        #region Implementation

        public bool enabled 
        {
            get => internal_UnityEngineCollider__get__enabled(WrappedId);
            set => internal_UnityEngineCollider__set__enabled(WrappedId, value);
        }

        public global::UnityEngine.Rigidbody attachedRigidbody 
        {
            get => internal_UnityEngineCollider__get__attachedRigidbody(WrappedId);
        }

        public global::UnityEngine.ArticulationBody attachedArticulationBody 
        {
            get => internal_UnityEngineCollider__get__attachedArticulationBody(WrappedId);
        }

        public bool isTrigger 
        {
            get => internal_UnityEngineCollider__get__isTrigger(WrappedId);
            set => internal_UnityEngineCollider__set__isTrigger(WrappedId, value);
        }

        public float contactOffset 
        {
            get => internal_UnityEngineCollider__get__contactOffset(WrappedId);
            set => internal_UnityEngineCollider__set__contactOffset(WrappedId, value);
        }

        public global::UnityEngine.Bounds bounds 
        {
            get => internal_UnityEngineCollider__get__bounds(WrappedId);
        }

        public bool hasModifiableContacts 
        {
            get => internal_UnityEngineCollider__get__hasModifiableContacts(WrappedId);
            set => internal_UnityEngineCollider__set__hasModifiableContacts(WrappedId, value);
        }

        public global::UnityEngine.PhysicMaterial sharedMaterial 
        {
            get => internal_UnityEngineCollider__get__sharedMaterial(WrappedId);
            set => internal_UnityEngineCollider__set__sharedMaterial(WrappedId, value);
        }

        public global::UnityEngine.PhysicMaterial material 
        {
            get => internal_UnityEngineCollider__get__material(WrappedId);
            set => internal_UnityEngineCollider__set__material(WrappedId, value);
        }

        public global::UnityEngine.Vector3 ClosestPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCollider__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public bool Raycast(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEngineCollider__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(WrappedId, ray, out hitInfo, maxDistance);
        }

        public global::UnityEngine.Vector3 ClosestPointOnBounds(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCollider__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCollider__get__enabled(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__enabled(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__enabled(long selfObjectId, bool enabled)
        {
            var enabledConverted = Unsafe.As<bool, int>(ref enabled);
            UnityEngineCollider__set__enabled(selfObjectId, enabledConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rigidbody internal_UnityEngineCollider__get__attachedRigidbody(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__attachedRigidbody(selfObjectId);
            var returnResult = new global::UnityEngine.Rigidbody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationBody internal_UnityEngineCollider__get__attachedArticulationBody(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__attachedArticulationBody(selfObjectId);
            var returnResult = new global::UnityEngine.ArticulationBody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCollider__get__isTrigger(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__isTrigger(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__isTrigger(long selfObjectId, bool isTrigger)
        {
            var isTriggerConverted = Unsafe.As<bool, int>(ref isTrigger);
            UnityEngineCollider__set__isTrigger(selfObjectId, isTriggerConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCollider__get__contactOffset(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__contactOffset(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__contactOffset(long selfObjectId, float contactOffset)
        {
            UnityEngineCollider__set__contactOffset(selfObjectId, contactOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineCollider__get__bounds(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsValue = default;
            UnityEngineCollider__get__bounds(selfObjectId, Unsafe.AsPointer(ref boundsValue));
            global::UnityEngine.Bounds returnResult = boundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCollider__get__hasModifiableContacts(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__hasModifiableContacts(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__hasModifiableContacts(long selfObjectId, bool hasModifiableContacts)
        {
            var hasModifiableContactsConverted = Unsafe.As<bool, int>(ref hasModifiableContacts);
            UnityEngineCollider__set__hasModifiableContacts(selfObjectId, hasModifiableContactsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.PhysicMaterial internal_UnityEngineCollider__get__sharedMaterial(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__sharedMaterial(selfObjectId);
            var returnResult = new global::UnityEngine.PhysicMaterial(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__sharedMaterial(long selfObjectId, global::UnityEngine.PhysicMaterial sharedMaterial)
        {
            UnityEngineCollider__set__sharedMaterial(selfObjectId, sharedMaterial.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.PhysicMaterial internal_UnityEngineCollider__get__material(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollider__get__material(selfObjectId);
            var returnResult = new global::UnityEngine.PhysicMaterial(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCollider__set__material(long selfObjectId, global::UnityEngine.PhysicMaterial material)
        {
            UnityEngineCollider__set__material(selfObjectId, material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCollider__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCollider__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCollider__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(long selfObjectId, global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEngineCollider__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCollider__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCollider__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCollider__get__enabled(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__enabled(long selfObjectId, int enabledConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollider__get__attachedRigidbody(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollider__get__attachedArticulationBody(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCollider__get__isTrigger(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__isTrigger(long selfObjectId, int isTriggerConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCollider__get__contactOffset(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__contactOffset(long selfObjectId, float contactOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollider__get__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCollider__get__hasModifiableContacts(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__hasModifiableContacts(long selfObjectId, int hasModifiableContactsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollider__get__sharedMaterial(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__sharedMaterial(long selfObjectId, long sharedMaterialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollider__get__material(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCollider__set__material(long selfObjectId, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollider__func__ClosestPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCollider__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(long selfObjectId, void* rayPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollider__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        #endregion Imports
    }
}
