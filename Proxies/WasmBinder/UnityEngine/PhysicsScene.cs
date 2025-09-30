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
    public partial struct PhysicsScene
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_Handle;

        public string ToString()
        {
            return internal_UnityEnginePhysicsScene__func__ToString__SystemString(ref this);
        }

        public int GetHashCode()
        {
            return internal_UnityEnginePhysicsScene__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEnginePhysicsScene__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.PhysicsScene other)
        {
            return internal_UnityEnginePhysicsScene__func__Equals__UnityEnginePhysicsScene__SystemBoolean(ref this, other);
        }

        public bool IsValid()
        {
            return internal_UnityEnginePhysicsScene__func__IsValid__SystemBoolean(ref this);
        }

        public bool IsEmpty()
        {
            return internal_UnityEnginePhysicsScene__func__IsEmpty__SystemBoolean(ref this);
        }

        public void Simulate(float step)
        {
            internal_UnityEnginePhysicsScene__func__Simulate__SystemSingle__SystemVoid(ref this, step);
        }

        public bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref this, origin, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref this, origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, origin, direction, raycastHits, maxDistance, layerMask, queryTriggerInteraction);
        }

        public bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref this, point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int OverlapCapsule(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, point0, point1, radius, results, layerMask, queryTriggerInteraction);
        }

        public bool SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref this, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int OverlapSphere(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, position, radius, results, layerMask, queryTriggerInteraction);
        }

        public bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref this, center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(ref this, center, halfExtents, direction, out hitInfo);
        }

        public int OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, center, halfExtents, results, orientation, layerMask, queryTriggerInteraction);
        }

        public int OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results)
        {
            return internal_UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(ref this, center, halfExtents, results);
        }

        public int BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref this, center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public int BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(ref this, center, halfExtents, direction, results);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePhysicsScene__func__ToString__SystemString(ref global::UnityEngine.PhysicsScene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysicsScene__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__GetHashCode__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePhysicsScene__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEnginePhysicsScene__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__Equals__UnityEnginePhysicsScene__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.PhysicsScene other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePhysicsScene__func__Equals__UnityEnginePhysicsScene__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__IsValid__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePhysicsScene__func__IsValid__SystemBoolean(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__IsEmpty__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePhysicsScene__func__IsEmpty__SystemBoolean(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicsScene__func__Simulate__SystemSingle__SystemVoid(ref global::UnityEngine.PhysicsScene selfStruct, float step)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePhysicsScene__func__Simulate__SystemSingle__SystemVoid(selfStructPointer, step);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            hitInfo = default;
            var methodCallResult = UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* raycastHitsPointer = raycastHits)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), raycastHitsPointer, raycastHits.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            hitInfo = default;
            var methodCallResult = UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, resultsIdsPointer, resultsWasmLength, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            hitInfo = default;
            var methodCallResult = UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref position), radius, resultsIdsPointer, resultsWasmLength, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            hitInfo = default;
            var methodCallResult = UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            hitInfo = default;
            var methodCallResult = UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength, Unsafe.AsPointer(ref orientation), layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(ref global::UnityEngine.PhysicsScene selfStruct, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(selfStructPointer, Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysicsScene__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__Equals__UnityEnginePhysicsScene__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__IsValid__SystemBoolean(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__IsEmpty__SystemBoolean(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysicsScene__func__Simulate__SystemSingle__SystemVoid(void* selfStructPointer, float step);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* selfStructPointer, void* originPointer, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* selfStructPointer, void* originPointer, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* originPointer, void* directionPointer, void* raycastHitsPointer, int raycastHitsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* selfStructPointer, void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* point0Pointer, void* point1Pointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* selfStructPointer, void* originPointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* originPointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* positionPointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength, void* orientationPointer, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysicsScene__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(void* selfStructPointer, void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength);

        #endregion Imports
    }
}
