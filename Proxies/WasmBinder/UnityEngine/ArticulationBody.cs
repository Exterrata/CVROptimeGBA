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

    public partial class ArticulationBody(long id) : Behaviour(id)
    {

        #region Implementation

        public global::UnityEngine.ArticulationJointType jointType 
        {
            get => internal_UnityEngineArticulationBody__get__jointType(WrappedId);
            set => internal_UnityEngineArticulationBody__set__jointType(WrappedId, value);
        }

        public global::UnityEngine.Vector3 anchorPosition 
        {
            get => internal_UnityEngineArticulationBody__get__anchorPosition(WrappedId);
            set => internal_UnityEngineArticulationBody__set__anchorPosition(WrappedId, value);
        }

        public global::UnityEngine.Vector3 parentAnchorPosition 
        {
            get => internal_UnityEngineArticulationBody__get__parentAnchorPosition(WrappedId);
            set => internal_UnityEngineArticulationBody__set__parentAnchorPosition(WrappedId, value);
        }

        public global::UnityEngine.Quaternion anchorRotation 
        {
            get => internal_UnityEngineArticulationBody__get__anchorRotation(WrappedId);
            set => internal_UnityEngineArticulationBody__set__anchorRotation(WrappedId, value);
        }

        public global::UnityEngine.Quaternion parentAnchorRotation 
        {
            get => internal_UnityEngineArticulationBody__get__parentAnchorRotation(WrappedId);
            set => internal_UnityEngineArticulationBody__set__parentAnchorRotation(WrappedId, value);
        }

        public bool isRoot 
        {
            get => internal_UnityEngineArticulationBody__get__isRoot(WrappedId);
        }

        public bool matchAnchors 
        {
            get => internal_UnityEngineArticulationBody__get__matchAnchors(WrappedId);
            set => internal_UnityEngineArticulationBody__set__matchAnchors(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock linearLockX 
        {
            get => internal_UnityEngineArticulationBody__get__linearLockX(WrappedId);
            set => internal_UnityEngineArticulationBody__set__linearLockX(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock linearLockY 
        {
            get => internal_UnityEngineArticulationBody__get__linearLockY(WrappedId);
            set => internal_UnityEngineArticulationBody__set__linearLockY(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock linearLockZ 
        {
            get => internal_UnityEngineArticulationBody__get__linearLockZ(WrappedId);
            set => internal_UnityEngineArticulationBody__set__linearLockZ(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock swingYLock 
        {
            get => internal_UnityEngineArticulationBody__get__swingYLock(WrappedId);
            set => internal_UnityEngineArticulationBody__set__swingYLock(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock swingZLock 
        {
            get => internal_UnityEngineArticulationBody__get__swingZLock(WrappedId);
            set => internal_UnityEngineArticulationBody__set__swingZLock(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDofLock twistLock 
        {
            get => internal_UnityEngineArticulationBody__get__twistLock(WrappedId);
            set => internal_UnityEngineArticulationBody__set__twistLock(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDrive xDrive 
        {
            get => internal_UnityEngineArticulationBody__get__xDrive(WrappedId);
            set => internal_UnityEngineArticulationBody__set__xDrive(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDrive yDrive 
        {
            get => internal_UnityEngineArticulationBody__get__yDrive(WrappedId);
            set => internal_UnityEngineArticulationBody__set__yDrive(WrappedId, value);
        }

        public global::UnityEngine.ArticulationDrive zDrive 
        {
            get => internal_UnityEngineArticulationBody__get__zDrive(WrappedId);
            set => internal_UnityEngineArticulationBody__set__zDrive(WrappedId, value);
        }

        public bool immovable 
        {
            get => internal_UnityEngineArticulationBody__get__immovable(WrappedId);
            set => internal_UnityEngineArticulationBody__set__immovable(WrappedId, value);
        }

        public bool useGravity 
        {
            get => internal_UnityEngineArticulationBody__get__useGravity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__useGravity(WrappedId, value);
        }

        public float linearDamping 
        {
            get => internal_UnityEngineArticulationBody__get__linearDamping(WrappedId);
            set => internal_UnityEngineArticulationBody__set__linearDamping(WrappedId, value);
        }

        public float angularDamping 
        {
            get => internal_UnityEngineArticulationBody__get__angularDamping(WrappedId);
            set => internal_UnityEngineArticulationBody__set__angularDamping(WrappedId, value);
        }

        public float jointFriction 
        {
            get => internal_UnityEngineArticulationBody__get__jointFriction(WrappedId);
            set => internal_UnityEngineArticulationBody__set__jointFriction(WrappedId, value);
        }

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineArticulationBody__get__velocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__velocity(WrappedId, value);
        }

        public global::UnityEngine.Vector3 angularVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__angularVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__angularVelocity(WrappedId, value);
        }

        public float mass 
        {
            get => internal_UnityEngineArticulationBody__get__mass(WrappedId);
            set => internal_UnityEngineArticulationBody__set__mass(WrappedId, value);
        }

        public global::UnityEngine.Vector3 centerOfMass 
        {
            get => internal_UnityEngineArticulationBody__get__centerOfMass(WrappedId);
            set => internal_UnityEngineArticulationBody__set__centerOfMass(WrappedId, value);
        }

        public global::UnityEngine.Vector3 worldCenterOfMass 
        {
            get => internal_UnityEngineArticulationBody__get__worldCenterOfMass(WrappedId);
        }

        public global::UnityEngine.Vector3 inertiaTensor 
        {
            get => internal_UnityEngineArticulationBody__get__inertiaTensor(WrappedId);
            set => internal_UnityEngineArticulationBody__set__inertiaTensor(WrappedId, value);
        }

        public global::UnityEngine.Quaternion inertiaTensorRotation 
        {
            get => internal_UnityEngineArticulationBody__get__inertiaTensorRotation(WrappedId);
            set => internal_UnityEngineArticulationBody__set__inertiaTensorRotation(WrappedId, value);
        }

        public float sleepThreshold 
        {
            get => internal_UnityEngineArticulationBody__get__sleepThreshold(WrappedId);
            set => internal_UnityEngineArticulationBody__set__sleepThreshold(WrappedId, value);
        }

        public int solverIterations 
        {
            get => internal_UnityEngineArticulationBody__get__solverIterations(WrappedId);
            set => internal_UnityEngineArticulationBody__set__solverIterations(WrappedId, value);
        }

        public int solverVelocityIterations 
        {
            get => internal_UnityEngineArticulationBody__get__solverVelocityIterations(WrappedId);
            set => internal_UnityEngineArticulationBody__set__solverVelocityIterations(WrappedId, value);
        }

        public float maxAngularVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__maxAngularVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__maxAngularVelocity(WrappedId, value);
        }

        public float maxLinearVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__maxLinearVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__maxLinearVelocity(WrappedId, value);
        }

        public float maxJointVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__maxJointVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__maxJointVelocity(WrappedId, value);
        }

        public float maxDepenetrationVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__maxDepenetrationVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__maxDepenetrationVelocity(WrappedId, value);
        }

        public global::UnityEngine.ArticulationReducedSpace jointPosition 
        {
            get => internal_UnityEngineArticulationBody__get__jointPosition(WrappedId);
            set => internal_UnityEngineArticulationBody__set__jointPosition(WrappedId, value);
        }

        public global::UnityEngine.ArticulationReducedSpace jointVelocity 
        {
            get => internal_UnityEngineArticulationBody__get__jointVelocity(WrappedId);
            set => internal_UnityEngineArticulationBody__set__jointVelocity(WrappedId, value);
        }

        public global::UnityEngine.ArticulationReducedSpace jointAcceleration 
        {
            get => internal_UnityEngineArticulationBody__get__jointAcceleration(WrappedId);
        }

        public global::UnityEngine.ArticulationReducedSpace jointForce 
        {
            get => internal_UnityEngineArticulationBody__get__jointForce(WrappedId);
            set => internal_UnityEngineArticulationBody__set__jointForce(WrappedId, value);
        }

        public int dofCount 
        {
            get => internal_UnityEngineArticulationBody__get__dofCount(WrappedId);
        }

        public int index 
        {
            get => internal_UnityEngineArticulationBody__get__index(WrappedId);
        }

        public global::UnityEngine.CollisionDetectionMode collisionDetectionMode 
        {
            get => internal_UnityEngineArticulationBody__get__collisionDetectionMode(WrappedId);
            set => internal_UnityEngineArticulationBody__set__collisionDetectionMode(WrappedId, value);
        }

        public void AddForce(global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, mode);
        }

        public void AddForce(global::UnityEngine.Vector3 force)
        {
            internal_UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__SystemVoid(WrappedId, force);
        }

        public void AddRelativeForce(global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, mode);
        }

        public void AddRelativeForce(global::UnityEngine.Vector3 force)
        {
            internal_UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(WrappedId, force);
        }

        public void AddTorque(global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, torque, mode);
        }

        public void AddTorque(global::UnityEngine.Vector3 torque)
        {
            internal_UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__SystemVoid(WrappedId, torque);
        }

        public void AddRelativeTorque(global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, torque, mode);
        }

        public void AddRelativeTorque(global::UnityEngine.Vector3 torque)
        {
            internal_UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(WrappedId, torque);
        }

        public void AddForceAtPosition(global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position, global::UnityEngine.ForceMode mode)
        {
            internal_UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(WrappedId, force, position, mode);
        }

        public void AddForceAtPosition(global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position)
        {
            internal_UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(WrappedId, force, position);
        }

        public void ResetCenterOfMass()
        {
            internal_UnityEngineArticulationBody__func__ResetCenterOfMass__SystemVoid(WrappedId);
        }

        public void ResetInertiaTensor()
        {
            internal_UnityEngineArticulationBody__func__ResetInertiaTensor__SystemVoid(WrappedId);
        }

        public void Sleep()
        {
            internal_UnityEngineArticulationBody__func__Sleep__SystemVoid(WrappedId);
        }

        public bool IsSleeping()
        {
            return internal_UnityEngineArticulationBody__func__IsSleeping__SystemBoolean(WrappedId);
        }

        public void WakeUp()
        {
            internal_UnityEngineArticulationBody__func__WakeUp__SystemVoid(WrappedId);
        }

        public void TeleportRoot(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEngineArticulationBody__func__TeleportRoot__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(WrappedId, position, rotation);
        }

        public global::UnityEngine.Vector3 GetClosestPoint(global::UnityEngine.Vector3 point)
        {
            return internal_UnityEngineArticulationBody__func__GetClosestPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, point);
        }

        public global::UnityEngine.Vector3 GetRelativePointVelocity(global::UnityEngine.Vector3 relativePoint)
        {
            return internal_UnityEngineArticulationBody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(WrappedId, relativePoint);
        }

        public global::UnityEngine.Vector3 GetPointVelocity(global::UnityEngine.Vector3 worldPoint)
        {
            return internal_UnityEngineArticulationBody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(WrappedId, worldPoint);
        }

        public int GetDenseJacobian(ref global::UnityEngine.ArticulationJacobian jacobian)
        {
            return internal_UnityEngineArticulationBody__func__GetDenseJacobian__UnityEngineArticulationJacobianRef__SystemInt32(WrappedId, ref jacobian);
        }

        public int GetJointPositions(global::System.Collections.Generic.List<float> positions)
        {
            return internal_UnityEngineArticulationBody__func__GetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, positions);
        }

        public void SetJointPositions(global::System.Collections.Generic.List<float> positions)
        {
            internal_UnityEngineArticulationBody__func__SetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, positions);
        }

        public int GetJointVelocities(global::System.Collections.Generic.List<float> velocities)
        {
            return internal_UnityEngineArticulationBody__func__GetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, velocities);
        }

        public void SetJointVelocities(global::System.Collections.Generic.List<float> velocities)
        {
            internal_UnityEngineArticulationBody__func__SetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, velocities);
        }

        public int GetJointAccelerations(global::System.Collections.Generic.List<float> accelerations)
        {
            return internal_UnityEngineArticulationBody__func__GetJointAccelerations__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, accelerations);
        }

        public int GetJointForces(global::System.Collections.Generic.List<float> forces)
        {
            return internal_UnityEngineArticulationBody__func__GetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, forces);
        }

        public void SetJointForces(global::System.Collections.Generic.List<float> forces)
        {
            internal_UnityEngineArticulationBody__func__SetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, forces);
        }

        public int GetDriveTargets(global::System.Collections.Generic.List<float> targets)
        {
            return internal_UnityEngineArticulationBody__func__GetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, targets);
        }

        public void SetDriveTargets(global::System.Collections.Generic.List<float> targets)
        {
            internal_UnityEngineArticulationBody__func__SetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, targets);
        }

        public int GetDriveTargetVelocities(global::System.Collections.Generic.List<float> targetVelocities)
        {
            return internal_UnityEngineArticulationBody__func__GetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(WrappedId, targetVelocities);
        }

        public void SetDriveTargetVelocities(global::System.Collections.Generic.List<float> targetVelocities)
        {
            internal_UnityEngineArticulationBody__func__SetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, targetVelocities);
        }

        public int GetDofStartIndices(global::System.Collections.Generic.List<int> dofStartIndices)
        {
            return internal_UnityEngineArticulationBody__func__GetDofStartIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32(WrappedId, dofStartIndices);
        }

        public void SnapAnchorToClosestContact()
        {
            internal_UnityEngineArticulationBody__func__SnapAnchorToClosestContact__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationJointType internal_UnityEngineArticulationBody__get__jointType(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__jointType(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationJointType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__jointType(long selfObjectId, global::UnityEngine.ArticulationJointType jointType)
        {
            UnityEngineArticulationBody__set__jointType(selfObjectId, (int) jointType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__anchorPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 anchorPositionValue = default;
            UnityEngineArticulationBody__get__anchorPosition(selfObjectId, Unsafe.AsPointer(ref anchorPositionValue));
            global::UnityEngine.Vector3 returnResult = anchorPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__anchorPosition(long selfObjectId, global::UnityEngine.Vector3 anchorPosition)
        {
            UnityEngineArticulationBody__set__anchorPosition(selfObjectId, Unsafe.AsPointer(ref anchorPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__parentAnchorPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 parentAnchorPositionValue = default;
            UnityEngineArticulationBody__get__parentAnchorPosition(selfObjectId, Unsafe.AsPointer(ref parentAnchorPositionValue));
            global::UnityEngine.Vector3 returnResult = parentAnchorPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__parentAnchorPosition(long selfObjectId, global::UnityEngine.Vector3 parentAnchorPosition)
        {
            UnityEngineArticulationBody__set__parentAnchorPosition(selfObjectId, Unsafe.AsPointer(ref parentAnchorPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineArticulationBody__get__anchorRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion anchorRotationValue = default;
            UnityEngineArticulationBody__get__anchorRotation(selfObjectId, Unsafe.AsPointer(ref anchorRotationValue));
            global::UnityEngine.Quaternion returnResult = anchorRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__anchorRotation(long selfObjectId, global::UnityEngine.Quaternion anchorRotation)
        {
            UnityEngineArticulationBody__set__anchorRotation(selfObjectId, Unsafe.AsPointer(ref anchorRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineArticulationBody__get__parentAnchorRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion parentAnchorRotationValue = default;
            UnityEngineArticulationBody__get__parentAnchorRotation(selfObjectId, Unsafe.AsPointer(ref parentAnchorRotationValue));
            global::UnityEngine.Quaternion returnResult = parentAnchorRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__parentAnchorRotation(long selfObjectId, global::UnityEngine.Quaternion parentAnchorRotation)
        {
            UnityEngineArticulationBody__set__parentAnchorRotation(selfObjectId, Unsafe.AsPointer(ref parentAnchorRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineArticulationBody__get__isRoot(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__isRoot(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineArticulationBody__get__matchAnchors(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__matchAnchors(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__matchAnchors(long selfObjectId, bool matchAnchors)
        {
            var matchAnchorsConverted = Unsafe.As<bool, int>(ref matchAnchors);
            UnityEngineArticulationBody__set__matchAnchors(selfObjectId, matchAnchorsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__linearLockX(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__linearLockX(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__linearLockX(long selfObjectId, global::UnityEngine.ArticulationDofLock linearLockX)
        {
            UnityEngineArticulationBody__set__linearLockX(selfObjectId, (int) linearLockX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__linearLockY(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__linearLockY(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__linearLockY(long selfObjectId, global::UnityEngine.ArticulationDofLock linearLockY)
        {
            UnityEngineArticulationBody__set__linearLockY(selfObjectId, (int) linearLockY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__linearLockZ(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__linearLockZ(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__linearLockZ(long selfObjectId, global::UnityEngine.ArticulationDofLock linearLockZ)
        {
            UnityEngineArticulationBody__set__linearLockZ(selfObjectId, (int) linearLockZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__swingYLock(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__swingYLock(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__swingYLock(long selfObjectId, global::UnityEngine.ArticulationDofLock swingYLock)
        {
            UnityEngineArticulationBody__set__swingYLock(selfObjectId, (int) swingYLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__swingZLock(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__swingZLock(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__swingZLock(long selfObjectId, global::UnityEngine.ArticulationDofLock swingZLock)
        {
            UnityEngineArticulationBody__set__swingZLock(selfObjectId, (int) swingZLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDofLock internal_UnityEngineArticulationBody__get__twistLock(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__twistLock(selfObjectId);
            var returnResult = (global::UnityEngine.ArticulationDofLock)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__twistLock(long selfObjectId, global::UnityEngine.ArticulationDofLock twistLock)
        {
            UnityEngineArticulationBody__set__twistLock(selfObjectId, (int) twistLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDrive internal_UnityEngineArticulationBody__get__xDrive(long selfObjectId)
        {
            global::UnityEngine.ArticulationDrive xDriveValue = default;
            UnityEngineArticulationBody__get__xDrive(selfObjectId, Unsafe.AsPointer(ref xDriveValue));
            global::UnityEngine.ArticulationDrive returnResult = xDriveValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__xDrive(long selfObjectId, global::UnityEngine.ArticulationDrive xDrive)
        {
            UnityEngineArticulationBody__set__xDrive(selfObjectId, Unsafe.AsPointer(ref xDrive));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDrive internal_UnityEngineArticulationBody__get__yDrive(long selfObjectId)
        {
            global::UnityEngine.ArticulationDrive yDriveValue = default;
            UnityEngineArticulationBody__get__yDrive(selfObjectId, Unsafe.AsPointer(ref yDriveValue));
            global::UnityEngine.ArticulationDrive returnResult = yDriveValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__yDrive(long selfObjectId, global::UnityEngine.ArticulationDrive yDrive)
        {
            UnityEngineArticulationBody__set__yDrive(selfObjectId, Unsafe.AsPointer(ref yDrive));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationDrive internal_UnityEngineArticulationBody__get__zDrive(long selfObjectId)
        {
            global::UnityEngine.ArticulationDrive zDriveValue = default;
            UnityEngineArticulationBody__get__zDrive(selfObjectId, Unsafe.AsPointer(ref zDriveValue));
            global::UnityEngine.ArticulationDrive returnResult = zDriveValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__zDrive(long selfObjectId, global::UnityEngine.ArticulationDrive zDrive)
        {
            UnityEngineArticulationBody__set__zDrive(selfObjectId, Unsafe.AsPointer(ref zDrive));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineArticulationBody__get__immovable(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__immovable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__immovable(long selfObjectId, bool immovable)
        {
            var immovableConverted = Unsafe.As<bool, int>(ref immovable);
            UnityEngineArticulationBody__set__immovable(selfObjectId, immovableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineArticulationBody__get__useGravity(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__useGravity(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__useGravity(long selfObjectId, bool useGravity)
        {
            var useGravityConverted = Unsafe.As<bool, int>(ref useGravity);
            UnityEngineArticulationBody__set__useGravity(selfObjectId, useGravityConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__linearDamping(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__linearDamping(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__linearDamping(long selfObjectId, float linearDamping)
        {
            UnityEngineArticulationBody__set__linearDamping(selfObjectId, linearDamping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__angularDamping(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__angularDamping(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__angularDamping(long selfObjectId, float angularDamping)
        {
            UnityEngineArticulationBody__set__angularDamping(selfObjectId, angularDamping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__jointFriction(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__jointFriction(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__jointFriction(long selfObjectId, float jointFriction)
        {
            UnityEngineArticulationBody__set__jointFriction(selfObjectId, jointFriction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineArticulationBody__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__velocity(long selfObjectId, global::UnityEngine.Vector3 velocity)
        {
            UnityEngineArticulationBody__set__velocity(selfObjectId, Unsafe.AsPointer(ref velocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__angularVelocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 angularVelocityValue = default;
            UnityEngineArticulationBody__get__angularVelocity(selfObjectId, Unsafe.AsPointer(ref angularVelocityValue));
            global::UnityEngine.Vector3 returnResult = angularVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__angularVelocity(long selfObjectId, global::UnityEngine.Vector3 angularVelocity)
        {
            UnityEngineArticulationBody__set__angularVelocity(selfObjectId, Unsafe.AsPointer(ref angularVelocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__mass(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__mass(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__mass(long selfObjectId, float mass)
        {
            UnityEngineArticulationBody__set__mass(selfObjectId, mass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__centerOfMass(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerOfMassValue = default;
            UnityEngineArticulationBody__get__centerOfMass(selfObjectId, Unsafe.AsPointer(ref centerOfMassValue));
            global::UnityEngine.Vector3 returnResult = centerOfMassValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__centerOfMass(long selfObjectId, global::UnityEngine.Vector3 centerOfMass)
        {
            UnityEngineArticulationBody__set__centerOfMass(selfObjectId, Unsafe.AsPointer(ref centerOfMass));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__worldCenterOfMass(long selfObjectId)
        {
            global::UnityEngine.Vector3 worldCenterOfMassValue = default;
            UnityEngineArticulationBody__get__worldCenterOfMass(selfObjectId, Unsafe.AsPointer(ref worldCenterOfMassValue));
            global::UnityEngine.Vector3 returnResult = worldCenterOfMassValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__get__inertiaTensor(long selfObjectId)
        {
            global::UnityEngine.Vector3 inertiaTensorValue = default;
            UnityEngineArticulationBody__get__inertiaTensor(selfObjectId, Unsafe.AsPointer(ref inertiaTensorValue));
            global::UnityEngine.Vector3 returnResult = inertiaTensorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__inertiaTensor(long selfObjectId, global::UnityEngine.Vector3 inertiaTensor)
        {
            UnityEngineArticulationBody__set__inertiaTensor(selfObjectId, Unsafe.AsPointer(ref inertiaTensor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineArticulationBody__get__inertiaTensorRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion inertiaTensorRotationValue = default;
            UnityEngineArticulationBody__get__inertiaTensorRotation(selfObjectId, Unsafe.AsPointer(ref inertiaTensorRotationValue));
            global::UnityEngine.Quaternion returnResult = inertiaTensorRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__inertiaTensorRotation(long selfObjectId, global::UnityEngine.Quaternion inertiaTensorRotation)
        {
            UnityEngineArticulationBody__set__inertiaTensorRotation(selfObjectId, Unsafe.AsPointer(ref inertiaTensorRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__sleepThreshold(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__sleepThreshold(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__sleepThreshold(long selfObjectId, float sleepThreshold)
        {
            UnityEngineArticulationBody__set__sleepThreshold(selfObjectId, sleepThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__get__solverIterations(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__solverIterations(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__solverIterations(long selfObjectId, int solverIterations)
        {
            UnityEngineArticulationBody__set__solverIterations(selfObjectId, solverIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__get__solverVelocityIterations(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__solverVelocityIterations(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__solverVelocityIterations(long selfObjectId, int solverVelocityIterations)
        {
            UnityEngineArticulationBody__set__solverVelocityIterations(selfObjectId, solverVelocityIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__maxAngularVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__maxAngularVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__maxAngularVelocity(long selfObjectId, float maxAngularVelocity)
        {
            UnityEngineArticulationBody__set__maxAngularVelocity(selfObjectId, maxAngularVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__maxLinearVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__maxLinearVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__maxLinearVelocity(long selfObjectId, float maxLinearVelocity)
        {
            UnityEngineArticulationBody__set__maxLinearVelocity(selfObjectId, maxLinearVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__maxJointVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__maxJointVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__maxJointVelocity(long selfObjectId, float maxJointVelocity)
        {
            UnityEngineArticulationBody__set__maxJointVelocity(selfObjectId, maxJointVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineArticulationBody__get__maxDepenetrationVelocity(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__maxDepenetrationVelocity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__maxDepenetrationVelocity(long selfObjectId, float maxDepenetrationVelocity)
        {
            UnityEngineArticulationBody__set__maxDepenetrationVelocity(selfObjectId, maxDepenetrationVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationReducedSpace internal_UnityEngineArticulationBody__get__jointPosition(long selfObjectId)
        {
            global::UnityEngine.ArticulationReducedSpace jointPositionValue = default;
            UnityEngineArticulationBody__get__jointPosition(selfObjectId, Unsafe.AsPointer(ref jointPositionValue));
            global::UnityEngine.ArticulationReducedSpace returnResult = jointPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__jointPosition(long selfObjectId, global::UnityEngine.ArticulationReducedSpace jointPosition)
        {
            UnityEngineArticulationBody__set__jointPosition(selfObjectId, Unsafe.AsPointer(ref jointPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationReducedSpace internal_UnityEngineArticulationBody__get__jointVelocity(long selfObjectId)
        {
            global::UnityEngine.ArticulationReducedSpace jointVelocityValue = default;
            UnityEngineArticulationBody__get__jointVelocity(selfObjectId, Unsafe.AsPointer(ref jointVelocityValue));
            global::UnityEngine.ArticulationReducedSpace returnResult = jointVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__jointVelocity(long selfObjectId, global::UnityEngine.ArticulationReducedSpace jointVelocity)
        {
            UnityEngineArticulationBody__set__jointVelocity(selfObjectId, Unsafe.AsPointer(ref jointVelocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationReducedSpace internal_UnityEngineArticulationBody__get__jointAcceleration(long selfObjectId)
        {
            global::UnityEngine.ArticulationReducedSpace jointAccelerationValue = default;
            UnityEngineArticulationBody__get__jointAcceleration(selfObjectId, Unsafe.AsPointer(ref jointAccelerationValue));
            global::UnityEngine.ArticulationReducedSpace returnResult = jointAccelerationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationReducedSpace internal_UnityEngineArticulationBody__get__jointForce(long selfObjectId)
        {
            global::UnityEngine.ArticulationReducedSpace jointForceValue = default;
            UnityEngineArticulationBody__get__jointForce(selfObjectId, Unsafe.AsPointer(ref jointForceValue));
            global::UnityEngine.ArticulationReducedSpace returnResult = jointForceValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__jointForce(long selfObjectId, global::UnityEngine.ArticulationReducedSpace jointForce)
        {
            UnityEngineArticulationBody__set__jointForce(selfObjectId, Unsafe.AsPointer(ref jointForce));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__get__dofCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__dofCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__get__index(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__index(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.CollisionDetectionMode internal_UnityEngineArticulationBody__get__collisionDetectionMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__get__collisionDetectionMode(selfObjectId);
            var returnResult = (global::UnityEngine.CollisionDetectionMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__set__collisionDetectionMode(long selfObjectId, global::UnityEngine.CollisionDetectionMode collisionDetectionMode)
        {
            UnityEngineArticulationBody__set__collisionDetectionMode(selfObjectId, (int) collisionDetectionMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force)
        {
            UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.ForceMode mode)
        {
            UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force)
        {
            UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque)
        {
            UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque, global::UnityEngine.ForceMode mode)
        {
            UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 torque)
        {
            UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref torque));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position, global::UnityEngine.ForceMode mode)
        {
            UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), Unsafe.AsPointer(ref position), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 position)
        {
            UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref force), Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__ResetCenterOfMass__SystemVoid(long selfObjectId)
        {
            UnityEngineArticulationBody__func__ResetCenterOfMass__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__ResetInertiaTensor__SystemVoid(long selfObjectId)
        {
            UnityEngineArticulationBody__func__ResetInertiaTensor__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__Sleep__SystemVoid(long selfObjectId)
        {
            UnityEngineArticulationBody__func__Sleep__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineArticulationBody__func__IsSleeping__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationBody__func__IsSleeping__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__WakeUp__SystemVoid(long selfObjectId)
        {
            UnityEngineArticulationBody__func__WakeUp__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__TeleportRoot__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineArticulationBody__func__TeleportRoot__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__func__GetClosestPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 point)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineArticulationBody__func__GetClosestPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 relativePoint)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineArticulationBody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref relativePoint), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineArticulationBody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 worldPoint)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineArticulationBody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref worldPoint), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetDenseJacobian__UnityEngineArticulationJacobianRef__SystemInt32(long selfObjectId, ref global::UnityEngine.ArticulationJacobian jacobian)
        {
            var methodCallResult = UnityEngineArticulationBody__func__GetDenseJacobian__UnityEngineArticulationJacobianRef__SystemInt32(selfObjectId, jacobian.WrappedId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> positionsList)
        {
            Span<float> positions = CollectionsMarshal.AsSpan(positionsList);
            fixed (float* positionsPointer = positions)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, positionsPointer, positions.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<float> positionsList)
        {
            Span<float> positions = CollectionsMarshal.AsSpan(positionsList);
            fixed (float* positionsPointer = positions)
            {
                UnityEngineArticulationBody__func__SetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, positionsPointer, positions.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> velocitiesList)
        {
            Span<float> velocities = CollectionsMarshal.AsSpan(velocitiesList);
            fixed (float* velocitiesPointer = velocities)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, velocitiesPointer, velocities.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<float> velocitiesList)
        {
            Span<float> velocities = CollectionsMarshal.AsSpan(velocitiesList);
            fixed (float* velocitiesPointer = velocities)
            {
                UnityEngineArticulationBody__func__SetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, velocitiesPointer, velocities.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetJointAccelerations__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> accelerationsList)
        {
            Span<float> accelerations = CollectionsMarshal.AsSpan(accelerationsList);
            fixed (float* accelerationsPointer = accelerations)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetJointAccelerations__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, accelerationsPointer, accelerations.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> forcesList)
        {
            Span<float> forces = CollectionsMarshal.AsSpan(forcesList);
            fixed (float* forcesPointer = forces)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, forcesPointer, forces.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<float> forcesList)
        {
            Span<float> forces = CollectionsMarshal.AsSpan(forcesList);
            fixed (float* forcesPointer = forces)
            {
                UnityEngineArticulationBody__func__SetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, forcesPointer, forces.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> targetsList)
        {
            Span<float> targets = CollectionsMarshal.AsSpan(targetsList);
            fixed (float* targetsPointer = targets)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, targetsPointer, targets.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<float> targetsList)
        {
            Span<float> targets = CollectionsMarshal.AsSpan(targetsList);
            fixed (float* targetsPointer = targets)
            {
                UnityEngineArticulationBody__func__SetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, targetsPointer, targets.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<float> targetVelocitiesList)
        {
            Span<float> targetVelocities = CollectionsMarshal.AsSpan(targetVelocitiesList);
            fixed (float* targetVelocitiesPointer = targetVelocities)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(selfObjectId, targetVelocitiesPointer, targetVelocities.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<float> targetVelocitiesList)
        {
            Span<float> targetVelocities = CollectionsMarshal.AsSpan(targetVelocitiesList);
            fixed (float* targetVelocitiesPointer = targetVelocities)
            {
                UnityEngineArticulationBody__func__SetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, targetVelocitiesPointer, targetVelocities.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationBody__func__GetDofStartIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<int> dofStartIndicesList)
        {
            Span<int> dofStartIndices = CollectionsMarshal.AsSpan(dofStartIndicesList);
            fixed (int* dofStartIndicesPointer = dofStartIndices)
            {
                var methodCallResult = UnityEngineArticulationBody__func__GetDofStartIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32(selfObjectId, dofStartIndicesPointer, dofStartIndices.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationBody__func__SnapAnchorToClosestContact__SystemVoid(long selfObjectId)
        {
            UnityEngineArticulationBody__func__SnapAnchorToClosestContact__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__jointType(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__jointType(long selfObjectId, int jointTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__anchorPosition(long selfObjectId, void* anchorPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__anchorPosition(long selfObjectId, void* anchorPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__parentAnchorPosition(long selfObjectId, void* parentAnchorPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__parentAnchorPosition(long selfObjectId, void* parentAnchorPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__anchorRotation(long selfObjectId, void* anchorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__anchorRotation(long selfObjectId, void* anchorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__parentAnchorRotation(long selfObjectId, void* parentAnchorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__parentAnchorRotation(long selfObjectId, void* parentAnchorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__isRoot(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__matchAnchors(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__matchAnchors(long selfObjectId, int matchAnchorsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__linearLockX(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__linearLockX(long selfObjectId, int linearLockXUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__linearLockY(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__linearLockY(long selfObjectId, int linearLockYUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__linearLockZ(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__linearLockZ(long selfObjectId, int linearLockZUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__swingYLock(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__swingYLock(long selfObjectId, int swingYLockUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__swingZLock(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__swingZLock(long selfObjectId, int swingZLockUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__twistLock(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__twistLock(long selfObjectId, int twistLockUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__xDrive(long selfObjectId, void* xDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__xDrive(long selfObjectId, void* xDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__yDrive(long selfObjectId, void* yDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__yDrive(long selfObjectId, void* yDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__zDrive(long selfObjectId, void* zDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__zDrive(long selfObjectId, void* zDrivePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__immovable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__immovable(long selfObjectId, int immovableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__useGravity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__useGravity(long selfObjectId, int useGravityConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__linearDamping(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__linearDamping(long selfObjectId, float linearDamping);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__angularDamping(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__angularDamping(long selfObjectId, float angularDamping);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__jointFriction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__jointFriction(long selfObjectId, float jointFriction);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__angularVelocity(long selfObjectId, void* angularVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__angularVelocity(long selfObjectId, void* angularVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__mass(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__mass(long selfObjectId, float mass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__centerOfMass(long selfObjectId, void* centerOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__centerOfMass(long selfObjectId, void* centerOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__worldCenterOfMass(long selfObjectId, void* worldCenterOfMassPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__inertiaTensor(long selfObjectId, void* inertiaTensorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__inertiaTensor(long selfObjectId, void* inertiaTensorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__inertiaTensorRotation(long selfObjectId, void* inertiaTensorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__inertiaTensorRotation(long selfObjectId, void* inertiaTensorRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__sleepThreshold(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__sleepThreshold(long selfObjectId, float sleepThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__solverIterations(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__solverIterations(long selfObjectId, int solverIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__solverVelocityIterations(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__solverVelocityIterations(long selfObjectId, int solverVelocityIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__maxAngularVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__maxAngularVelocity(long selfObjectId, float maxAngularVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__maxLinearVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__maxLinearVelocity(long selfObjectId, float maxLinearVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__maxJointVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__maxJointVelocity(long selfObjectId, float maxJointVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineArticulationBody__get__maxDepenetrationVelocity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__maxDepenetrationVelocity(long selfObjectId, float maxDepenetrationVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__jointPosition(long selfObjectId, void* jointPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__jointPosition(long selfObjectId, void* jointPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__jointVelocity(long selfObjectId, void* jointVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__jointVelocity(long selfObjectId, void* jointVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__jointAcceleration(long selfObjectId, void* jointAccelerationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__get__jointForce(long selfObjectId, void* jointForcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__set__jointForce(long selfObjectId, void* jointForcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__dofCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__index(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__get__collisionDetectionMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__set__collisionDetectionMode(long selfObjectId, int collisionDetectionModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddForce__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddRelativeForce__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* torquePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddTorque__UnityEngineVector3__SystemVoid(long selfObjectId, void* torquePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* torquePointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddRelativeTorque__UnityEngineVector3__SystemVoid(long selfObjectId, void* torquePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__UnityEngineForceModeEnum__SystemVoid(long selfObjectId, void* forcePointer, void* positionPointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__AddForceAtPosition__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, void* forcePointer, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__func__ResetCenterOfMass__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__func__ResetInertiaTensor__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__func__Sleep__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__func__IsSleeping__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__func__WakeUp__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__TeleportRoot__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__GetClosestPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* pointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* relativePointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__GetPointVelocity__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* worldPointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationBody__func__GetDenseJacobian__UnityEngineArticulationJacobianRef__SystemInt32(long selfObjectId, long jacobianObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* positionsPointer, int positionsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__SetJointPositions__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* positionsPointer, int positionsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* velocitiesPointer, int velocitiesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__SetJointVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* velocitiesPointer, int velocitiesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetJointAccelerations__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* accelerationsPointer, int accelerationsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* forcesPointer, int forcesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__SetJointForces__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* forcesPointer, int forcesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* targetsPointer, int targetsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__SetDriveTargets__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* targetsPointer, int targetsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemInt32(long selfObjectId, void* targetVelocitiesPointer, int targetVelocitiesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationBody__func__SetDriveTargetVelocities__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* targetVelocitiesPointer, int targetVelocitiesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineArticulationBody__func__GetDofStartIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32(long selfObjectId, void* dofStartIndicesPointer, int dofStartIndicesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationBody__func__SnapAnchorToClosestContact__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
