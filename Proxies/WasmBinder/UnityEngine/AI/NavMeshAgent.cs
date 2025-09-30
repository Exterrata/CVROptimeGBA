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

    public partial class NavMeshAgent(long id) : Behaviour(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 destination 
        {
            get => internal_UnityEngineAINavMeshAgent__get__destination(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__destination(WrappedId, value);
        }

        public float stoppingDistance 
        {
            get => internal_UnityEngineAINavMeshAgent__get__stoppingDistance(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__stoppingDistance(WrappedId, value);
        }

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineAINavMeshAgent__get__velocity(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__velocity(WrappedId, value);
        }

        public global::UnityEngine.Vector3 nextPosition 
        {
            get => internal_UnityEngineAINavMeshAgent__get__nextPosition(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__nextPosition(WrappedId, value);
        }

        public global::UnityEngine.Vector3 steeringTarget 
        {
            get => internal_UnityEngineAINavMeshAgent__get__steeringTarget(WrappedId);
        }

        public global::UnityEngine.Vector3 desiredVelocity 
        {
            get => internal_UnityEngineAINavMeshAgent__get__desiredVelocity(WrappedId);
        }

        public float remainingDistance 
        {
            get => internal_UnityEngineAINavMeshAgent__get__remainingDistance(WrappedId);
        }

        public float baseOffset 
        {
            get => internal_UnityEngineAINavMeshAgent__get__baseOffset(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__baseOffset(WrappedId, value);
        }

        public bool isOnOffMeshLink 
        {
            get => internal_UnityEngineAINavMeshAgent__get__isOnOffMeshLink(WrappedId);
        }

        public global::UnityEngine.AI.OffMeshLinkData currentOffMeshLinkData 
        {
            get => internal_UnityEngineAINavMeshAgent__get__currentOffMeshLinkData(WrappedId);
        }

        public global::UnityEngine.AI.OffMeshLinkData nextOffMeshLinkData 
        {
            get => internal_UnityEngineAINavMeshAgent__get__nextOffMeshLinkData(WrappedId);
        }

        public bool autoTraverseOffMeshLink 
        {
            get => internal_UnityEngineAINavMeshAgent__get__autoTraverseOffMeshLink(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__autoTraverseOffMeshLink(WrappedId, value);
        }

        public bool autoBraking 
        {
            get => internal_UnityEngineAINavMeshAgent__get__autoBraking(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__autoBraking(WrappedId, value);
        }

        public bool autoRepath 
        {
            get => internal_UnityEngineAINavMeshAgent__get__autoRepath(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__autoRepath(WrappedId, value);
        }

        public bool hasPath 
        {
            get => internal_UnityEngineAINavMeshAgent__get__hasPath(WrappedId);
        }

        public bool pathPending 
        {
            get => internal_UnityEngineAINavMeshAgent__get__pathPending(WrappedId);
        }

        public bool isPathStale 
        {
            get => internal_UnityEngineAINavMeshAgent__get__isPathStale(WrappedId);
        }

        public global::UnityEngine.AI.NavMeshPathStatus pathStatus 
        {
            get => internal_UnityEngineAINavMeshAgent__get__pathStatus(WrappedId);
        }

        public global::UnityEngine.Vector3 pathEndPosition 
        {
            get => internal_UnityEngineAINavMeshAgent__get__pathEndPosition(WrappedId);
        }

        public bool isStopped 
        {
            get => internal_UnityEngineAINavMeshAgent__get__isStopped(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__isStopped(WrappedId, value);
        }

        public global::UnityEngine.AI.NavMeshPath path 
        {
            get => internal_UnityEngineAINavMeshAgent__get__path(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__path(WrappedId, value);
        }

        public global::UnityEngine.Object navMeshOwner 
        {
            get => internal_UnityEngineAINavMeshAgent__get__navMeshOwner(WrappedId);
        }

        public int agentTypeID 
        {
            get => internal_UnityEngineAINavMeshAgent__get__agentTypeID(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__agentTypeID(WrappedId, value);
        }

        public int areaMask 
        {
            get => internal_UnityEngineAINavMeshAgent__get__areaMask(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__areaMask(WrappedId, value);
        }

        public float speed 
        {
            get => internal_UnityEngineAINavMeshAgent__get__speed(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__speed(WrappedId, value);
        }

        public float angularSpeed 
        {
            get => internal_UnityEngineAINavMeshAgent__get__angularSpeed(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__angularSpeed(WrappedId, value);
        }

        public float acceleration 
        {
            get => internal_UnityEngineAINavMeshAgent__get__acceleration(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__acceleration(WrappedId, value);
        }

        public bool updatePosition 
        {
            get => internal_UnityEngineAINavMeshAgent__get__updatePosition(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__updatePosition(WrappedId, value);
        }

        public bool updateRotation 
        {
            get => internal_UnityEngineAINavMeshAgent__get__updateRotation(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__updateRotation(WrappedId, value);
        }

        public bool updateUpAxis 
        {
            get => internal_UnityEngineAINavMeshAgent__get__updateUpAxis(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__updateUpAxis(WrappedId, value);
        }

        public float radius 
        {
            get => internal_UnityEngineAINavMeshAgent__get__radius(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__radius(WrappedId, value);
        }

        public float height 
        {
            get => internal_UnityEngineAINavMeshAgent__get__height(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__height(WrappedId, value);
        }

        public global::UnityEngine.AI.ObstacleAvoidanceType obstacleAvoidanceType 
        {
            get => internal_UnityEngineAINavMeshAgent__get__obstacleAvoidanceType(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__obstacleAvoidanceType(WrappedId, value);
        }

        public int avoidancePriority 
        {
            get => internal_UnityEngineAINavMeshAgent__get__avoidancePriority(WrappedId);
            set => internal_UnityEngineAINavMeshAgent__set__avoidancePriority(WrappedId, value);
        }

        public bool isOnNavMesh 
        {
            get => internal_UnityEngineAINavMeshAgent__get__isOnNavMesh(WrappedId);
        }

        public bool SetDestination(global::UnityEngine.Vector3 target)
        {
            return internal_UnityEngineAINavMeshAgent__func__SetDestination__UnityEngineVector3__SystemBoolean(WrappedId, target);
        }

        public void ActivateCurrentOffMeshLink(bool activated)
        {
            internal_UnityEngineAINavMeshAgent__func__ActivateCurrentOffMeshLink__SystemBoolean__SystemVoid(WrappedId, activated);
        }

        public void CompleteOffMeshLink()
        {
            internal_UnityEngineAINavMeshAgent__func__CompleteOffMeshLink__SystemVoid(WrappedId);
        }

        public bool Warp(global::UnityEngine.Vector3 newPosition)
        {
            return internal_UnityEngineAINavMeshAgent__func__Warp__UnityEngineVector3__SystemBoolean(WrappedId, newPosition);
        }

        public void Move(global::UnityEngine.Vector3 offset)
        {
            internal_UnityEngineAINavMeshAgent__func__Move__UnityEngineVector3__SystemVoid(WrappedId, offset);
        }

        public void ResetPath()
        {
            internal_UnityEngineAINavMeshAgent__func__ResetPath__SystemVoid(WrappedId);
        }

        public bool SetPath(global::UnityEngine.AI.NavMeshPath path)
        {
            return internal_UnityEngineAINavMeshAgent__func__SetPath__UnityEngineAINavMeshPath__SystemBoolean(WrappedId, path);
        }

        public bool FindClosestEdge(out global::UnityEngine.AI.NavMeshHit hit)
        {
            return internal_UnityEngineAINavMeshAgent__func__FindClosestEdge__UnityEngineAINavMeshHitRef__SystemBoolean(WrappedId, out hit);
        }

        public bool Raycast(global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit)
        {
            return internal_UnityEngineAINavMeshAgent__func__Raycast__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemBoolean(WrappedId, targetPosition, out hit);
        }

        public bool CalculatePath(global::UnityEngine.Vector3 targetPosition, global::UnityEngine.AI.NavMeshPath path)
        {
            return internal_UnityEngineAINavMeshAgent__func__CalculatePath__UnityEngineVector3__UnityEngineAINavMeshPath__SystemBoolean(WrappedId, targetPosition, path);
        }

        public bool SamplePathPosition(int areaMask, float maxDistance, out global::UnityEngine.AI.NavMeshHit hit)
        {
            return internal_UnityEngineAINavMeshAgent__func__SamplePathPosition__SystemInt32__SystemSingle__UnityEngineAINavMeshHitRef__SystemBoolean(WrappedId, areaMask, maxDistance, out hit);
        }

        public void SetAreaCost(int areaIndex, float areaCost)
        {
            internal_UnityEngineAINavMeshAgent__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(WrappedId, areaIndex, areaCost);
        }

        public float GetAreaCost(int areaIndex)
        {
            return internal_UnityEngineAINavMeshAgent__func__GetAreaCost__SystemInt32__SystemSingle(WrappedId, areaIndex);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__destination(long selfObjectId)
        {
            global::UnityEngine.Vector3 destinationValue = default;
            UnityEngineAINavMeshAgent__get__destination(selfObjectId, Unsafe.AsPointer(ref destinationValue));
            global::UnityEngine.Vector3 returnResult = destinationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__destination(long selfObjectId, global::UnityEngine.Vector3 destination)
        {
            UnityEngineAINavMeshAgent__set__destination(selfObjectId, Unsafe.AsPointer(ref destination));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__stoppingDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__stoppingDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__stoppingDistance(long selfObjectId, float stoppingDistance)
        {
            UnityEngineAINavMeshAgent__set__stoppingDistance(selfObjectId, stoppingDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineAINavMeshAgent__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__velocity(long selfObjectId, global::UnityEngine.Vector3 velocity)
        {
            UnityEngineAINavMeshAgent__set__velocity(selfObjectId, Unsafe.AsPointer(ref velocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__nextPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 nextPositionValue = default;
            UnityEngineAINavMeshAgent__get__nextPosition(selfObjectId, Unsafe.AsPointer(ref nextPositionValue));
            global::UnityEngine.Vector3 returnResult = nextPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__nextPosition(long selfObjectId, global::UnityEngine.Vector3 nextPosition)
        {
            UnityEngineAINavMeshAgent__set__nextPosition(selfObjectId, Unsafe.AsPointer(ref nextPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__steeringTarget(long selfObjectId)
        {
            global::UnityEngine.Vector3 steeringTargetValue = default;
            UnityEngineAINavMeshAgent__get__steeringTarget(selfObjectId, Unsafe.AsPointer(ref steeringTargetValue));
            global::UnityEngine.Vector3 returnResult = steeringTargetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__desiredVelocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 desiredVelocityValue = default;
            UnityEngineAINavMeshAgent__get__desiredVelocity(selfObjectId, Unsafe.AsPointer(ref desiredVelocityValue));
            global::UnityEngine.Vector3 returnResult = desiredVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__remainingDistance(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__remainingDistance(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__baseOffset(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__baseOffset(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__baseOffset(long selfObjectId, float baseOffset)
        {
            UnityEngineAINavMeshAgent__set__baseOffset(selfObjectId, baseOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__isOnOffMeshLink(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__isOnOffMeshLink(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.OffMeshLinkData internal_UnityEngineAINavMeshAgent__get__currentOffMeshLinkData(long selfObjectId)
        {
            global::UnityEngine.AI.OffMeshLinkData currentOffMeshLinkDataValue = default;
            UnityEngineAINavMeshAgent__get__currentOffMeshLinkData(selfObjectId, Unsafe.AsPointer(ref currentOffMeshLinkDataValue));
            global::UnityEngine.AI.OffMeshLinkData returnResult = currentOffMeshLinkDataValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.OffMeshLinkData internal_UnityEngineAINavMeshAgent__get__nextOffMeshLinkData(long selfObjectId)
        {
            global::UnityEngine.AI.OffMeshLinkData nextOffMeshLinkDataValue = default;
            UnityEngineAINavMeshAgent__get__nextOffMeshLinkData(selfObjectId, Unsafe.AsPointer(ref nextOffMeshLinkDataValue));
            global::UnityEngine.AI.OffMeshLinkData returnResult = nextOffMeshLinkDataValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__autoTraverseOffMeshLink(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__autoTraverseOffMeshLink(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__autoTraverseOffMeshLink(long selfObjectId, bool autoTraverseOffMeshLink)
        {
            var autoTraverseOffMeshLinkConverted = Unsafe.As<bool, int>(ref autoTraverseOffMeshLink);
            UnityEngineAINavMeshAgent__set__autoTraverseOffMeshLink(selfObjectId, autoTraverseOffMeshLinkConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__autoBraking(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__autoBraking(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__autoBraking(long selfObjectId, bool autoBraking)
        {
            var autoBrakingConverted = Unsafe.As<bool, int>(ref autoBraking);
            UnityEngineAINavMeshAgent__set__autoBraking(selfObjectId, autoBrakingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__autoRepath(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__autoRepath(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__autoRepath(long selfObjectId, bool autoRepath)
        {
            var autoRepathConverted = Unsafe.As<bool, int>(ref autoRepath);
            UnityEngineAINavMeshAgent__set__autoRepath(selfObjectId, autoRepathConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__hasPath(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__hasPath(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__pathPending(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__pathPending(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__isPathStale(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__isPathStale(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshPathStatus internal_UnityEngineAINavMeshAgent__get__pathStatus(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__pathStatus(selfObjectId);
            var returnResult = (global::UnityEngine.AI.NavMeshPathStatus)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshAgent__get__pathEndPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 pathEndPositionValue = default;
            UnityEngineAINavMeshAgent__get__pathEndPosition(selfObjectId, Unsafe.AsPointer(ref pathEndPositionValue));
            global::UnityEngine.Vector3 returnResult = pathEndPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__isStopped(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__isStopped(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__isStopped(long selfObjectId, bool isStopped)
        {
            var isStoppedConverted = Unsafe.As<bool, int>(ref isStopped);
            UnityEngineAINavMeshAgent__set__isStopped(selfObjectId, isStoppedConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshPath internal_UnityEngineAINavMeshAgent__get__path(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__path(selfObjectId);
            var returnResult = new global::UnityEngine.AI.NavMeshPath(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__path(long selfObjectId, global::UnityEngine.AI.NavMeshPath path)
        {
            UnityEngineAINavMeshAgent__set__path(selfObjectId, path.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineAINavMeshAgent__get__navMeshOwner(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__navMeshOwner(selfObjectId);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshAgent__get__agentTypeID(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__agentTypeID(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__agentTypeID(long selfObjectId, int agentTypeID)
        {
            UnityEngineAINavMeshAgent__set__agentTypeID(selfObjectId, agentTypeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshAgent__get__areaMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__areaMask(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__areaMask(long selfObjectId, int areaMask)
        {
            UnityEngineAINavMeshAgent__set__areaMask(selfObjectId, areaMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__speed(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__speed(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__speed(long selfObjectId, float speed)
        {
            UnityEngineAINavMeshAgent__set__speed(selfObjectId, speed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__angularSpeed(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__angularSpeed(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__angularSpeed(long selfObjectId, float angularSpeed)
        {
            UnityEngineAINavMeshAgent__set__angularSpeed(selfObjectId, angularSpeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__acceleration(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__acceleration(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__acceleration(long selfObjectId, float acceleration)
        {
            UnityEngineAINavMeshAgent__set__acceleration(selfObjectId, acceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__updatePosition(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__updatePosition(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__updatePosition(long selfObjectId, bool updatePosition)
        {
            var updatePositionConverted = Unsafe.As<bool, int>(ref updatePosition);
            UnityEngineAINavMeshAgent__set__updatePosition(selfObjectId, updatePositionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__updateRotation(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__updateRotation(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__updateRotation(long selfObjectId, bool updateRotation)
        {
            var updateRotationConverted = Unsafe.As<bool, int>(ref updateRotation);
            UnityEngineAINavMeshAgent__set__updateRotation(selfObjectId, updateRotationConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__updateUpAxis(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__updateUpAxis(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__updateUpAxis(long selfObjectId, bool updateUpAxis)
        {
            var updateUpAxisConverted = Unsafe.As<bool, int>(ref updateUpAxis);
            UnityEngineAINavMeshAgent__set__updateUpAxis(selfObjectId, updateUpAxisConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__radius(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__radius(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__radius(long selfObjectId, float radius)
        {
            UnityEngineAINavMeshAgent__set__radius(selfObjectId, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__get__height(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__height(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__height(long selfObjectId, float height)
        {
            UnityEngineAINavMeshAgent__set__height(selfObjectId, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.ObstacleAvoidanceType internal_UnityEngineAINavMeshAgent__get__obstacleAvoidanceType(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__obstacleAvoidanceType(selfObjectId);
            var returnResult = (global::UnityEngine.AI.ObstacleAvoidanceType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__obstacleAvoidanceType(long selfObjectId, global::UnityEngine.AI.ObstacleAvoidanceType obstacleAvoidanceType)
        {
            UnityEngineAINavMeshAgent__set__obstacleAvoidanceType(selfObjectId, (int) obstacleAvoidanceType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAINavMeshAgent__get__avoidancePriority(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__avoidancePriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__set__avoidancePriority(long selfObjectId, int avoidancePriority)
        {
            UnityEngineAINavMeshAgent__set__avoidancePriority(selfObjectId, avoidancePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__get__isOnNavMesh(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__get__isOnNavMesh(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__SetDestination__UnityEngineVector3__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 target)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__func__SetDestination__UnityEngineVector3__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref target));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__func__ActivateCurrentOffMeshLink__SystemBoolean__SystemVoid(long selfObjectId, bool activated)
        {
            var activatedConverted = Unsafe.As<bool, int>(ref activated);
            UnityEngineAINavMeshAgent__func__ActivateCurrentOffMeshLink__SystemBoolean__SystemVoid(selfObjectId, activatedConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__func__CompleteOffMeshLink__SystemVoid(long selfObjectId)
        {
            UnityEngineAINavMeshAgent__func__CompleteOffMeshLink__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__Warp__UnityEngineVector3__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 newPosition)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__func__Warp__UnityEngineVector3__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref newPosition));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__func__Move__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 offset)
        {
            UnityEngineAINavMeshAgent__func__Move__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref offset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__func__ResetPath__SystemVoid(long selfObjectId)
        {
            UnityEngineAINavMeshAgent__func__ResetPath__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__SetPath__UnityEngineAINavMeshPath__SystemBoolean(long selfObjectId, global::UnityEngine.AI.NavMeshPath path)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__func__SetPath__UnityEngineAINavMeshPath__SystemBoolean(selfObjectId, path.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__FindClosestEdge__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, out global::UnityEngine.AI.NavMeshHit hit)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMeshAgent__func__FindClosestEdge__UnityEngineAINavMeshHitRef__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref hit));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__Raycast__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.AI.NavMeshHit hit)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMeshAgent__func__Raycast__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref targetPosition), Unsafe.AsPointer(ref hit));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__CalculatePath__UnityEngineVector3__UnityEngineAINavMeshPath__SystemBoolean(long selfObjectId, global::UnityEngine.Vector3 targetPosition, global::UnityEngine.AI.NavMeshPath path)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__func__CalculatePath__UnityEngineVector3__UnityEngineAINavMeshPath__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref targetPosition), path.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshAgent__func__SamplePathPosition__SystemInt32__SystemSingle__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, int areaMask, float maxDistance, out global::UnityEngine.AI.NavMeshHit hit)
        {
            hit = default;
            var methodCallResult = UnityEngineAINavMeshAgent__func__SamplePathPosition__SystemInt32__SystemSingle__UnityEngineAINavMeshHitRef__SystemBoolean(selfObjectId, areaMask, maxDistance, Unsafe.AsPointer(ref hit));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshAgent__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int areaIndex, float areaCost)
        {
            UnityEngineAINavMeshAgent__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(selfObjectId, areaIndex, areaCost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshAgent__func__GetAreaCost__SystemInt32__SystemSingle(long selfObjectId, int areaIndex)
        {
            var methodCallResult = UnityEngineAINavMeshAgent__func__GetAreaCost__SystemInt32__SystemSingle(selfObjectId, areaIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__destination(long selfObjectId, void* destinationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__set__destination(long selfObjectId, void* destinationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__stoppingDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__stoppingDistance(long selfObjectId, float stoppingDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__set__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__nextPosition(long selfObjectId, void* nextPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__set__nextPosition(long selfObjectId, void* nextPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__steeringTarget(long selfObjectId, void* steeringTargetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__desiredVelocity(long selfObjectId, void* desiredVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__remainingDistance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__baseOffset(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__baseOffset(long selfObjectId, float baseOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__isOnOffMeshLink(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__currentOffMeshLinkData(long selfObjectId, void* currentOffMeshLinkDataPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__nextOffMeshLinkData(long selfObjectId, void* nextOffMeshLinkDataPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__autoTraverseOffMeshLink(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__autoTraverseOffMeshLink(long selfObjectId, int autoTraverseOffMeshLinkConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__autoBraking(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__autoBraking(long selfObjectId, int autoBrakingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__autoRepath(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__autoRepath(long selfObjectId, int autoRepathConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__hasPath(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__pathPending(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__isPathStale(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__pathStatus(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__get__pathEndPosition(long selfObjectId, void* pathEndPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__isStopped(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__isStopped(long selfObjectId, int isStoppedConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMeshAgent__get__path(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__path(long selfObjectId, long pathObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAINavMeshAgent__get__navMeshOwner(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__agentTypeID(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__agentTypeID(long selfObjectId, int agentTypeID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__areaMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__areaMask(long selfObjectId, int areaMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__speed(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__speed(long selfObjectId, float speed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__angularSpeed(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__angularSpeed(long selfObjectId, float angularSpeed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__acceleration(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__acceleration(long selfObjectId, float acceleration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__updatePosition(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__updatePosition(long selfObjectId, int updatePositionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__updateRotation(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__updateRotation(long selfObjectId, int updateRotationConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__updateUpAxis(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__updateUpAxis(long selfObjectId, int updateUpAxisConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__radius(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__radius(long selfObjectId, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__get__height(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__height(long selfObjectId, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__obstacleAvoidanceType(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__obstacleAvoidanceType(long selfObjectId, int obstacleAvoidanceTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__avoidancePriority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__set__avoidancePriority(long selfObjectId, int avoidancePriority);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__get__isOnNavMesh(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__SetDestination__UnityEngineVector3__SystemBoolean(long selfObjectId, void* targetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__func__ActivateCurrentOffMeshLink__SystemBoolean__SystemVoid(long selfObjectId, int activatedConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__func__CompleteOffMeshLink__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__Warp__UnityEngineVector3__SystemBoolean(long selfObjectId, void* newPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshAgent__func__Move__UnityEngineVector3__SystemVoid(long selfObjectId, void* offsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__func__ResetPath__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshAgent__func__SetPath__UnityEngineAINavMeshPath__SystemBoolean(long selfObjectId, long pathObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__FindClosestEdge__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, void* hitPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__Raycast__UnityEngineVector3__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, void* targetPositionPointer, void* hitPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__CalculatePath__UnityEngineVector3__UnityEngineAINavMeshPath__SystemBoolean(long selfObjectId, void* targetPositionPointer, long pathObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAINavMeshAgent__func__SamplePathPosition__SystemInt32__SystemSingle__UnityEngineAINavMeshHitRef__SystemBoolean(long selfObjectId, int areaMask, float maxDistance, void* hitPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshAgent__func__SetAreaCost__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int areaIndex, float areaCost);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshAgent__func__GetAreaCost__SystemInt32__SystemSingle(long selfObjectId, int areaIndex);

        #endregion Imports
    }
}
