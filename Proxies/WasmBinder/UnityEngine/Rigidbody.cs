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

    public partial class Rigidbody(long id) : Component(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineRigidbody__get__velocity(WrappedId);
            set => internal_UnityEngineRigidbody__set__velocity(WrappedId, value);
        }

        public global::UnityEngine.Vector3 angularVelocity 
        {
            get => internal_UnityEngineRigidbody__get__angularVelocity(WrappedId);
            set => internal_UnityEngineRigidbody__set__angularVelocity(WrappedId, value);
        }

        public float drag 
        {
            get => internal_UnityEngineRigidbody__get__drag(WrappedId);
            set => internal_UnityEngineRigidbody__set__drag(WrappedId, value);
        }

        public float angularDrag 
        {
            get => internal_UnityEngineRigidbody__get__angularDrag(WrappedId);
            set => internal_UnityEngineRigidbody__set__angularDrag(WrappedId, value);
        }

        public float mass 
        {
            get => internal_UnityEngineRigidbody__get__mass(WrappedId);
            set => internal_UnityEngineRigidbody__set__mass(WrappedId, value);
        }

        public bool useGravity 
        {
            get => internal_UnityEngineRigidbody__get__useGravity(WrappedId);
            set => internal_UnityEngineRigidbody__set__useGravity(WrappedId, value);
        }

        public float maxDepenetrationVelocity 
        {
            get => internal_UnityEngineRigidbody__get__maxDepenetrationVelocity(WrappedId);
            set => internal_UnityEngineRigidbody__set__maxDepenetrationVelocity(WrappedId, value);
        }

        public bool isKinematic 
        {
            get => internal_UnityEngineRigidbody__get__isKinematic(WrappedId);
            set => internal_UnityEngineRigidbody__set__isKinematic(WrappedId, value);
        }

        public bool freezeRotation 
        {
            get => internal_UnityEngineRigidbody__get__freezeRotation(WrappedId);
            set => internal_UnityEngineRigidbody__set__freezeRotation(WrappedId, value);
        }

        public global::UnityEngine.RigidbodyConstraints constraints 
        {
            get => internal_UnityEngineRigidbody__get__constraints(WrappedId);
            set => internal_UnityEngineRigidbody__set__constraints(WrappedId, value);
        }

        public global::UnityEngine.CollisionDetectionMode collisionDetectionMode 
        {
            get => internal_UnityEngineRigidbody__get__collisionDetectionMode(WrappedId);
            set => internal_UnityEngineRigidbody__set__collisionDetectionMode(WrappedId, value);
        }

        public global::UnityEngine.Vector3 centerOfMass 
        {
            get => internal_UnityEngineRigidbody__get__centerOfMass(WrappedId);
            set => internal_UnityEngineRigidbody__set__centerOfMass(WrappedId, value);
        }

        public global::UnityEngine.Vector3 worldCenterOfMass 
        {
            get => internal_UnityEngineRigidbody__get__worldCenterOfMass(WrappedId);
        }

        public global::UnityEngine.Quaternion inertiaTensorRotation 
        {
            get => internal_UnityEngineRigidbody__get__inertiaTensorRotation(WrappedId);
            set => internal_UnityEngineRigidbody__set__inertiaTensorRotation(WrappedId, value);
        }

        public global::UnityEngine.Vector3 inertiaTensor 
        {
            get => internal_UnityEngineRigidbody__get__inertiaTensor(WrappedId);
            set => internal_UnityEngineRigidbody__set__inertiaTensor(WrappedId, value);
        }

        public bool detectCollisions 
        {
            get => internal_UnityEngineRigidbody__get__detectCollisions(WrappedId);
            set => internal_UnityEngineRigidbody__set__detectCollisions(WrappedId, value);
        }

        public global::UnityEngine.Vector3 position 
        {
            get => internal_UnityEngineRigidbody__get__position(WrappedId);
            set => internal_UnityEngineRigidbody__set__position(WrappedId, value);
        }

        public global::UnityEngine.Quaternion rotation 
        {
            get => internal_UnityEngineRigidbody__get__rotation(WrappedId);
            set => internal_UnityEngineRigidbody__set__rotation(WrappedId, value);
        }

        public global::UnityEngine.RigidbodyInterpolation interpolation 
        {
            get => internal_UnityEngineRigidbody__get__interpolation(WrappedId);
            set => internal_UnityEngineRigidbody__set__interpolation(WrappedId, value);
        }

        public int solverIterations 
        {
            get => internal_UnityEngineRigidbody__get__solverIterations(WrappedId);
            set => internal_UnityEngineRigidbody__set__solverIterations(WrappedId, value);
        }

        public float sleepThreshold 
        {
            get => internal_UnityEngineRigidbody__get__sleepThreshold(WrappedId);
            set => internal_UnityEngineRigidbody__set__sleepThreshold(WrappedId, value);
        }

        public float maxAngularVelocity 
        {
            get => internal_UnityEngineRigidbody__get__maxAngularVelocity(WrappedId);
            set => internal_UnityEngineRigidbody__set__maxAngularVelocity(WrappedId, value);
        }

        public int solverVelocityIterations 
        {
            get => internal_UnityEngineRigidbody__get__solverVelocityIterations(WrappedId);
            set => internal_UnityEngineRigidbody__set__solverVelocityIterations(WrappedId, value);
        }

        public void SetDensity(float density)
        {
            internal_UnityEngineRigidbody__func__SetDensity__SystemSingle__SystemVoid(WrappedId, density);
        }

        public void MovePosition(global::UnityEngine.Vector3 position)
        {
            internal_UnityEngineRigidbody__func__MovePosition__UnityEngineVector3__SystemVoid(WrappedId, position);
        }

        public void MoveRotation(global::UnityEngine.Quaternion rot)
        {
            internal_UnityEngineRigidbody__func__MoveRotation__UnityEngineQuaternion__SystemVoid(WrappedId, rot);
        }

        public void Sleep()
        {
            internal_UnityEngineRigidbody__func__Sleep__SystemVoid(WrappedId);
        }

        public bool IsSleeping()
        {
            return internal_UnityEngineRigidbody__func__IsSleeping__SystemBoolean(WrappedId);
        }

        public void WakeUp()
        {
            internal_UnityEngineRigidbody__func__WakeUp__SystemVoid(WrappedId);
        }

        public void ResetCenterOfMass()
        {
            internal_UnityEngineRigidbody__func__ResetCenterOfMass__SystemVoid(WrappedId);
        }

        public void ResetInertiaTensor()
        {
            internal_UnityEngineRigidbody__func__ResetInertiaTensor__SystemVoid(WrappedId);
        }

        public global::UnityEngine.Vector3 GetRelativePointVelocity(global::UnityEngine.Vector3 relativePoint)
        {
            return internal_UnityEngineRigidbody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(WrappedId, relativePoint);
        }

        public global::UnityEngine.Vector3 GetPointVelocity(global::UnityEngine.Vector3 worldPoint)
        {
            return internal_UnityEngineRigidbody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(WrappedId, worldPoint);
        }

        public void AddForce(global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, mode);
        }

        public void AddForce(global::UnityEngine.Vector3 force)
        {
            internal_UnityEngineRigidbody__func__AddForce__UnityEngineVector3__SystemVoid(WrappedId, force);
        }

        public void AddForce(float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(WrappedId, x, y, z, mode);
        }

        public void AddForce(float x, float y, float z)
        {
            internal_UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, x, y, z);
        }

        public void AddRelativeForce(global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, mode);
        }

        public void AddRelativeForce(global::UnityEngine.Vector3 force)
        {
            internal_UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(WrappedId, force);
        }

        public void AddRelativeForce(float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(WrappedId, x, y, z, mode);
        }

        public void AddRelativeForce(float x, float y, float z)
        {
            internal_UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, x, y, z);
        }

        public void AddTorque(global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, torque, mode);
        }

        public void AddTorque(global::UnityEngine.Vector3 torque)
        {
            internal_UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__SystemVoid(WrappedId, torque);
        }

        public void AddTorque(float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(WrappedId, x, y, z, mode);
        }

        public void AddTorque(float x, float y, float z)
        {
            internal_UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, x, y, z);
        }

        public void AddRelativeTorque(global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, torque, mode);
        }

        public void AddRelativeTorque(global::UnityEngine.Vector3 torque)
        {
            internal_UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(WrappedId, torque);
        }

        public void AddRelativeTorque(float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(WrappedId, x, y, z, mode);
        }

        public void AddRelativeTorque(float x, float y, float z)
        {
            internal_UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, x, y, z);
        }

        public void AddForceAtPosition(global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, position, mode);
        }

        public void AddForceAtPosition(global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position)
        {
            internal_UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(WrappedId, force, position);
        }

        public void AddExplosionForce(float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(WrappedId, explosionForce, explosionPosition, explosionRadius, upwardsModifier, mode);
        }

        public void AddExplosionForce(float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
        {
            internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__SystemVoid(WrappedId, explosionForce, explosionPosition, explosionRadius, upwardsModifier);
        }

        public void AddExplosionForce(float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius)
        {
            internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemVoid(WrappedId, explosionForce, explosionPosition, explosionRadius);
        }

        public global::UnityEngine.Vector3 ClosestPointOnBounds(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineRigidbody__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public bool SweepTest(global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(WrappedId, direction, out hitInfo, maxDistance, queryTriggerInteraction);
        }

        public bool SweepTest(global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(WrappedId, direction, out hitInfo, maxDistance);
        }

        public bool SweepTest(global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(WrappedId, direction, out hitInfo);
        }

        public global::UnityEngine.RaycastHit[] SweepTestAll(global::UnityEngine.Vector3 direction, float maxDistance, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(WrappedId, direction, maxDistance, queryTriggerInteraction);
        }

        public global::UnityEngine.RaycastHit[] SweepTestAll(global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(WrappedId, direction, maxDistance);
        }

        public global::UnityEngine.RaycastHit[] SweepTestAll(global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__UnityEngineRaycastHitArray(WrappedId, direction);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineRigidbody__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__velocity(long selfObjectId, global::UnityEngine.Vector3 velocity)
        {
            UnityEngineRigidbody__set__velocity(selfObjectId, Unsafe.AsPointer(ref velocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__angularVelocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 angularVelocityValue = default;
            UnityEngineRigidbody__get__angularVelocity(selfObjectId, Unsafe.AsPointer(ref angularVelocityValue));
            global::UnityEngine.Vector3 returnResult = angularVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__angularVelocity(long selfObjectId, global::UnityEngine.Vector3 angularVelocity)
        {
            UnityEngineRigidbody__set__angularVelocity(selfObjectId, Unsafe.AsPointer(ref angularVelocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__drag(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__drag(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__drag(long selfObjectId, float drag)
        {
            UnityEngineRigidbody__set__drag(selfObjectId, drag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__angularDrag(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__angularDrag(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__angularDrag(long selfObjectId, float angularDrag)
        {
            UnityEngineRigidbody__set__angularDrag(selfObjectId, angularDrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__mass(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__mass(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__mass(long selfObjectId, float mass)
        {
            UnityEngineRigidbody__set__mass(selfObjectId, mass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__get__useGravity(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__useGravity(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__useGravity(long selfObjectId, bool useGravity)
        {
            var useGravityConverted = Unsafe.As<bool, int>(ref useGravity);
            UnityEngineRigidbody__set__useGravity(selfObjectId, useGravityConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__maxDepenetrationVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__maxDepenetrationVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__maxDepenetrationVelocity(long selfObjectId, float maxDepenetrationVelocity)
        {
            UnityEngineRigidbody__set__maxDepenetrationVelocity(selfObjectId, maxDepenetrationVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__get__isKinematic(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__isKinematic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__isKinematic(long selfObjectId, bool isKinematic)
        {
            var isKinematicConverted = Unsafe.As<bool, int>(ref isKinematic);
            UnityEngineRigidbody__set__isKinematic(selfObjectId, isKinematicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__get__freezeRotation(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__freezeRotation(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__freezeRotation(long selfObjectId, bool freezeRotation)
        {
            var freezeRotationConverted = Unsafe.As<bool, int>(ref freezeRotation);
            UnityEngineRigidbody__set__freezeRotation(selfObjectId, freezeRotationConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RigidbodyConstraints internal_UnityEngineRigidbody__get__constraints(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__constraints(selfObjectId);
            var returnResult = (global::UnityEngine.RigidbodyConstraints)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__constraints(long selfObjectId, global::UnityEngine.RigidbodyConstraints constraints)
        {
            UnityEngineRigidbody__set__constraints(selfObjectId, (int) constraints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.CollisionDetectionMode internal_UnityEngineRigidbody__get__collisionDetectionMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__collisionDetectionMode(selfObjectId);
            var returnResult = (global::UnityEngine.CollisionDetectionMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__collisionDetectionMode(long selfObjectId, global::UnityEngine.CollisionDetectionMode collisionDetectionMode)
        {
            UnityEngineRigidbody__set__collisionDetectionMode(selfObjectId, (int) collisionDetectionMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__centerOfMass(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerOfMassValue = default;
            UnityEngineRigidbody__get__centerOfMass(selfObjectId, Unsafe.AsPointer(ref centerOfMassValue));
            global::UnityEngine.Vector3 returnResult = centerOfMassValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__centerOfMass(long selfObjectId, global::UnityEngine.Vector3 centerOfMass)
        {
            UnityEngineRigidbody__set__centerOfMass(selfObjectId, Unsafe.AsPointer(ref centerOfMass));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__worldCenterOfMass(long selfObjectId)
        {
            global::UnityEngine.Vector3 worldCenterOfMassValue = default;
            UnityEngineRigidbody__get__worldCenterOfMass(selfObjectId, Unsafe.AsPointer(ref worldCenterOfMassValue));
            global::UnityEngine.Vector3 returnResult = worldCenterOfMassValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineRigidbody__get__inertiaTensorRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion inertiaTensorRotationValue = default;
            UnityEngineRigidbody__get__inertiaTensorRotation(selfObjectId, Unsafe.AsPointer(ref inertiaTensorRotationValue));
            global::UnityEngine.Quaternion returnResult = inertiaTensorRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__inertiaTensorRotation(long selfObjectId, global::UnityEngine.Quaternion inertiaTensorRotation)
        {
            UnityEngineRigidbody__set__inertiaTensorRotation(selfObjectId, Unsafe.AsPointer(ref inertiaTensorRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__inertiaTensor(long selfObjectId)
        {
            global::UnityEngine.Vector3 inertiaTensorValue = default;
            UnityEngineRigidbody__get__inertiaTensor(selfObjectId, Unsafe.AsPointer(ref inertiaTensorValue));
            global::UnityEngine.Vector3 returnResult = inertiaTensorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__inertiaTensor(long selfObjectId, global::UnityEngine.Vector3 inertiaTensor)
        {
            UnityEngineRigidbody__set__inertiaTensor(selfObjectId, Unsafe.AsPointer(ref inertiaTensor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__get__detectCollisions(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__detectCollisions(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__detectCollisions(long selfObjectId, bool detectCollisions)
        {
            var detectCollisionsConverted = Unsafe.As<bool, int>(ref detectCollisions);
            UnityEngineRigidbody__set__detectCollisions(selfObjectId, detectCollisionsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__get__position(long selfObjectId)
        {
            global::UnityEngine.Vector3 positionValue = default;
            UnityEngineRigidbody__get__position(selfObjectId, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector3 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__position(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            UnityEngineRigidbody__set__position(selfObjectId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineRigidbody__get__rotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion rotationValue = default;
            UnityEngineRigidbody__get__rotation(selfObjectId, Unsafe.AsPointer(ref rotationValue));
            global::UnityEngine.Quaternion returnResult = rotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__rotation(long selfObjectId, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineRigidbody__set__rotation(selfObjectId, Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RigidbodyInterpolation internal_UnityEngineRigidbody__get__interpolation(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__interpolation(selfObjectId);
            var returnResult = (global::UnityEngine.RigidbodyInterpolation)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__interpolation(long selfObjectId, global::UnityEngine.RigidbodyInterpolation interpolation)
        {
            UnityEngineRigidbody__set__interpolation(selfObjectId, (int) interpolation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRigidbody__get__solverIterations(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__solverIterations(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__solverIterations(long selfObjectId, int solverIterations)
        {
            UnityEngineRigidbody__set__solverIterations(selfObjectId, solverIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__sleepThreshold(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__sleepThreshold(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__sleepThreshold(long selfObjectId, float sleepThreshold)
        {
            UnityEngineRigidbody__set__sleepThreshold(selfObjectId, sleepThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRigidbody__get__maxAngularVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__maxAngularVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__maxAngularVelocity(long selfObjectId, float maxAngularVelocity)
        {
            UnityEngineRigidbody__set__maxAngularVelocity(selfObjectId, maxAngularVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRigidbody__get__solverVelocityIterations(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__get__solverVelocityIterations(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__set__solverVelocityIterations(long selfObjectId, int solverVelocityIterations)
        {
            UnityEngineRigidbody__set__solverVelocityIterations(selfObjectId, solverVelocityIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__SetDensity__SystemSingle__SystemVoid(long selfObjectId, float density)
        {
            UnityEngineRigidbody__func__SetDensity__SystemSingle__SystemVoid(selfObjectId, density);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__MovePosition__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            UnityEngineRigidbody__func__MovePosition__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__MoveRotation__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.Quaternion rot)
        {
            UnityEngineRigidbody__func__MoveRotation__UnityEngineQuaternion__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rot));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__Sleep__SystemVoid(long selfObjectId)
        {
            UnityEngineRigidbody__func__Sleep__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__func__IsSleeping__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineRigidbody__func__IsSleeping__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__WakeUp__SystemVoid(long selfObjectId)
        {
            UnityEngineRigidbody__func__WakeUp__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__ResetCenterOfMass__SystemVoid(long selfObjectId)
        {
            UnityEngineRigidbody__func__ResetCenterOfMass__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__ResetInertiaTensor__SystemVoid(long selfObjectId)
        {
            UnityEngineRigidbody__func__ResetInertiaTensor__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 relativePoint)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineRigidbody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref relativePoint), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 worldPoint)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineRigidbody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref worldPoint), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForce__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force)
        {
            UnityEngineRigidbody__func__AddForce__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(selfObjectId, x, y, z, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z)
        {
            UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force)
        {
            UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(selfObjectId, x, y, z, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z)
        {
            UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque)
        {
            UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(selfObjectId, x, y, z, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z)
        {
            UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque)
        {
            UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(selfObjectId, x, y, z, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z)
        {
            UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), Unsafe.AsPointer(ref position), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position)
        {
            UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, global::UnityEngine.ForceMode mode)
        {
            UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(selfObjectId, explosionForce, Unsafe.AsPointer(ref explosionPosition), explosionRadius, upwardsModifier, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
        {
            UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__SystemVoid(selfObjectId, explosionForce, Unsafe.AsPointer(ref explosionPosition), explosionRadius, upwardsModifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, float explosionForce, global::UnityEngine.Vector3 explosionPosition, float explosionRadius)
        {
            UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemVoid(selfObjectId, explosionForce, Unsafe.AsPointer(ref explosionPosition), explosionRadius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRigidbody__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineRigidbody__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(long selfObjectId, global::UnityEngine.Vector3 direction, float maxDistance, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(selfObjectId, Unsafe.AsPointer(ref direction), maxDistance, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(long selfObjectId, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(selfObjectId, Unsafe.AsPointer(ref direction), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__UnityEngineRaycastHitArray(long selfObjectId, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__UnityEngineRaycastHitArray(selfObjectId, Unsafe.AsPointer(ref direction), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__angularVelocity(long selfObjectId, void* angularVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__angularVelocity(long selfObjectId, void* angularVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__drag(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__drag(long selfObjectId, float drag);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__angularDrag(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__angularDrag(long selfObjectId, float angularDrag);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__mass(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__mass(long selfObjectId, float mass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__useGravity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__useGravity(long selfObjectId, int useGravityConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__maxDepenetrationVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__maxDepenetrationVelocity(long selfObjectId, float maxDepenetrationVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__isKinematic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__isKinematic(long selfObjectId, int isKinematicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__freezeRotation(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__freezeRotation(long selfObjectId, int freezeRotationConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__constraints(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__constraints(long selfObjectId, int constraintsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__collisionDetectionMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__collisionDetectionMode(long selfObjectId, int collisionDetectionModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__centerOfMass(long selfObjectId, void* centerOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__centerOfMass(long selfObjectId, void* centerOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__worldCenterOfMass(long selfObjectId, void* worldCenterOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__inertiaTensorRotation(long selfObjectId, void* inertiaTensorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__inertiaTensorRotation(long selfObjectId, void* inertiaTensorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__inertiaTensor(long selfObjectId, void* inertiaTensorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__inertiaTensor(long selfObjectId, void* inertiaTensorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__detectCollisions(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__detectCollisions(long selfObjectId, int detectCollisionsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__get__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__set__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__interpolation(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__interpolation(long selfObjectId, int interpolationUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__solverIterations(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__solverIterations(long selfObjectId, int solverIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__sleepThreshold(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__sleepThreshold(long selfObjectId, float sleepThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRigidbody__get__maxAngularVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__maxAngularVelocity(long selfObjectId, float maxAngularVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__get__solverVelocityIterations(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__set__solverVelocityIterations(long selfObjectId, int solverVelocityIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__SetDensity__SystemSingle__SystemVoid(long selfObjectId, float density);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__MovePosition__UnityEngineVector3__SystemVoid(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__MoveRotation__UnityEngineQuaternion__SystemVoid(long selfObjectId, void* rotPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__Sleep__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRigidbody__func__IsSleeping__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__WakeUp__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__ResetCenterOfMass__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__ResetInertiaTensor__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* relativePointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* worldPointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddForce__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddRelativeForce__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* torquePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddTorque__UnityEngineVector3__SystemVoid(long selfObjectId, void* torquePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* torquePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(long selfObjectId, void* torquePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float x, float y, float z, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRigidbody__func__AddRelativeTorque__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, void* positionPointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, float explosionForce, void* explosionPositionPointer, float explosionRadius, float upwardsModifier, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float explosionForce, void* explosionPositionPointer, float explosionRadius, float upwardsModifier);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__AddExplosionForce__SystemSingle__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, float explosionForce, void* explosionPositionPointer, float explosionRadius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(long selfObjectId, void* directionPointer, void* hitInfoPointer, float maxDistance, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(long selfObjectId, void* directionPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRigidbody__func__SweepTest__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(long selfObjectId, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(long selfObjectId, void* directionPointer, float maxDistance, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(long selfObjectId, void* directionPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRigidbody__func__SweepTestAll__UnityEngineVector3__UnityEngineRaycastHitArray(long selfObjectId, void* directionPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        #endregion Imports
    }
}
