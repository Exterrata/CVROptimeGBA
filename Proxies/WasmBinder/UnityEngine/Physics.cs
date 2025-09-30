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

    public partial class Physics(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Fields Constants

        public const int IgnoreRaycastLayer = 4;
        public const int DefaultRaycastLayers = -5;
        public const int AllLayers = -1;

        #endregion Fields Constants

        #region Implementation

        public Physics()
            : this(internal_UnityEnginePhysics__ctor()) { }

        public static global::UnityEngine.Vector3 gravity 
        {
            get => internal_UnityEnginePhysics__get__gravity();
            set => internal_UnityEnginePhysics__set__gravity(value);
        }

        public static float defaultContactOffset 
        {
            get => internal_UnityEnginePhysics__get__defaultContactOffset();
            set => internal_UnityEnginePhysics__set__defaultContactOffset(value);
        }

        public static float sleepThreshold 
        {
            get => internal_UnityEnginePhysics__get__sleepThreshold();
            set => internal_UnityEnginePhysics__set__sleepThreshold(value);
        }

        public static bool queriesHitTriggers 
        {
            get => internal_UnityEnginePhysics__get__queriesHitTriggers();
            set => internal_UnityEnginePhysics__set__queriesHitTriggers(value);
        }

        public static bool queriesHitBackfaces 
        {
            get => internal_UnityEnginePhysics__get__queriesHitBackfaces();
            set => internal_UnityEnginePhysics__set__queriesHitBackfaces(value);
        }

        public static float bounceThreshold 
        {
            get => internal_UnityEnginePhysics__get__bounceThreshold();
            set => internal_UnityEnginePhysics__set__bounceThreshold(value);
        }

        public static float defaultMaxDepenetrationVelocity 
        {
            get => internal_UnityEnginePhysics__get__defaultMaxDepenetrationVelocity();
            set => internal_UnityEnginePhysics__set__defaultMaxDepenetrationVelocity(value);
        }

        public static int defaultSolverIterations 
        {
            get => internal_UnityEnginePhysics__get__defaultSolverIterations();
            set => internal_UnityEnginePhysics__set__defaultSolverIterations(value);
        }

        public static int defaultSolverVelocityIterations 
        {
            get => internal_UnityEnginePhysics__get__defaultSolverVelocityIterations();
            set => internal_UnityEnginePhysics__set__defaultSolverVelocityIterations(value);
        }

        public static float defaultMaxAngularSpeed 
        {
            get => internal_UnityEnginePhysics__get__defaultMaxAngularSpeed();
            set => internal_UnityEnginePhysics__set__defaultMaxAngularSpeed(value);
        }

        public static bool improvedPatchFriction 
        {
            get => internal_UnityEnginePhysics__get__improvedPatchFriction();
            set => internal_UnityEnginePhysics__set__improvedPatchFriction(value);
        }

        public static global::UnityEngine.PhysicsScene defaultPhysicsScene 
        {
            get => internal_UnityEnginePhysics__get__defaultPhysicsScene();
        }

        public static bool autoSimulation 
        {
            get => internal_UnityEnginePhysics__get__autoSimulation();
            set => internal_UnityEnginePhysics__set__autoSimulation(value);
        }

        public static bool autoSyncTransforms 
        {
            get => internal_UnityEnginePhysics__get__autoSyncTransforms();
            set => internal_UnityEnginePhysics__set__autoSyncTransforms(value);
        }

        public static bool reuseCollisionCallbacks 
        {
            get => internal_UnityEnginePhysics__get__reuseCollisionCallbacks();
            set => internal_UnityEnginePhysics__set__reuseCollisionCallbacks(value);
        }

        public static float interCollisionDistance 
        {
            get => internal_UnityEnginePhysics__get__interCollisionDistance();
            set => internal_UnityEnginePhysics__set__interCollisionDistance(value);
        }

        public static float interCollisionStiffness 
        {
            get => internal_UnityEnginePhysics__get__interCollisionStiffness();
            set => internal_UnityEnginePhysics__set__interCollisionStiffness(value);
        }

        public static bool interCollisionSettingsToggle 
        {
            get => internal_UnityEnginePhysics__get__interCollisionSettingsToggle();
            set => internal_UnityEnginePhysics__set__interCollisionSettingsToggle(value);
        }

        public static global::UnityEngine.Vector3 clothGravity 
        {
            get => internal_UnityEnginePhysics__get__clothGravity();
            set => internal_UnityEnginePhysics__set__clothGravity(value);
        }

        public static void IgnoreCollision(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2, bool ignore)
        {
            internal_UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean__SystemVoid(collider1, collider2, ignore);
        }

        public static void IgnoreCollision(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2)
        {
            internal_UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemVoid(collider1, collider2);
        }

        public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
        {
            internal_UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(layer1, layer2, ignore);
        }

        public static void IgnoreLayerCollision(int layer1, int layer2)
        {
            internal_UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemVoid(layer1, layer2);
        }

        public static bool GetIgnoreLayerCollision(int layer1, int layer2)
        {
            return internal_UnityEnginePhysics__func__GetIgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean(layer1, layer2);
        }

        public static bool GetIgnoreCollision(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2)
        {
            return internal_UnityEnginePhysics__func__GetIgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean(collider1, collider2);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(origin, direction, maxDistance, layerMask);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(origin, direction, maxDistance);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(origin, direction);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(origin, direction, out hitInfo, maxDistance, layerMask);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(origin, direction, out hitInfo, maxDistance);
        }

        public static bool Raycast(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(origin, direction, out hitInfo);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ray, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__SystemBoolean(ray, maxDistance, layerMask);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemBoolean(ray, maxDistance);
        }

        public static bool Raycast(global::UnityEngine.Ray ray)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemBoolean(ray);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(ray, out hitInfo, maxDistance, layerMask);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(ray, out hitInfo, maxDistance);
        }

        public static bool Raycast(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemBoolean(ray, out hitInfo);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(start, end, layerMask, queryTriggerInteraction);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__SystemBoolean(start, end, layerMask);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(start, end);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(start, end, out hitInfo, layerMask, queryTriggerInteraction);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo, int layerMask)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__SystemBoolean(start, end, out hitInfo, layerMask);
        }

        public static bool Linecast(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(start, end, out hitInfo);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(point1, point2, radius, direction, maxDistance, layerMask);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemBoolean(point1, point2, radius, direction, maxDistance);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemBoolean(point1, point2, radius, direction);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(point1, point2, radius, direction, out hitInfo, maxDistance);
        }

        public static bool CapsuleCast(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(point1, point2, radius, direction, out hitInfo);
        }

        public static bool SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(origin, radius, direction, out hitInfo, maxDistance, layerMask);
        }

        public static bool SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(origin, radius, direction, out hitInfo, maxDistance);
        }

        public static bool SphereCast(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(origin, radius, direction, out hitInfo);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__SystemBoolean(ray, radius, maxDistance, layerMask);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemBoolean(ray, radius, maxDistance);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemBoolean(ray, radius);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(ray, radius, out hitInfo, maxDistance, layerMask);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(ray, radius, out hitInfo, maxDistance);
        }

        public static bool SphereCast(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemBoolean(ray, radius, out hitInfo);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(center, halfExtents, direction, orientation, maxDistance, layerMask);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemBoolean(center, halfExtents, direction, orientation, maxDistance);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(center, halfExtents, direction, orientation);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemBoolean(center, halfExtents, direction);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemBoolean(center, halfExtents, direction, out hitInfo, orientation, maxDistance);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemBoolean(center, halfExtents, direction, out hitInfo, orientation);
        }

        public static bool BoxCast(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            return internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(center, halfExtents, direction, out hitInfo);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(origin, direction, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(origin, direction, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(origin, direction);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Ray ray, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(ray, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Ray ray, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(ray, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Ray ray, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(ray, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] RaycastAll(global::UnityEngine.Ray ray)
        {
            return internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__UnityEngineRaycastHitArray(ray);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ray, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(ray, results, maxDistance, layerMask);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(ray, results, maxDistance);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemInt32(ray, results);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(origin, direction, results, maxDistance, layerMask);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(origin, direction, results, maxDistance);
        }

        public static int RaycastNonAlloc(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(origin, direction, results);
        }

        public static global::UnityEngine.RaycastHit[] CapsuleCastAll(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] CapsuleCastAll(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(point1, point2, radius, direction, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] CapsuleCastAll(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(point1, point2, radius, direction, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] CapsuleCastAll(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(point1, point2, radius, direction);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(origin, radius, direction, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(origin, radius, direction, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(origin, radius, direction);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(ray, radius, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Ray ray, float radius, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__UnityEngineRaycastHitArray(ray, radius, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] SphereCastAll(global::UnityEngine.Ray ray, float radius)
        {
            return internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(ray, radius);
        }

        public static global::UnityEngine.Collider[] OverlapCapsule(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(point0, point1, radius, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.Collider[] OverlapCapsule(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, int layerMask)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(point0, point1, radius, layerMask);
        }

        public static global::UnityEngine.Collider[] OverlapCapsule(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(point0, point1, radius);
        }

        public static global::UnityEngine.Collider[] OverlapSphere(global::UnityEngine.Vector3 position, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(position, radius, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.Collider[] OverlapSphere(global::UnityEngine.Vector3 position, float radius, int layerMask)
        {
            return internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(position, radius, layerMask);
        }

        public static global::UnityEngine.Collider[] OverlapSphere(global::UnityEngine.Vector3 position, float radius)
        {
            return internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(position, radius);
        }

        public static void Simulate(float step)
        {
            internal_UnityEnginePhysics__func__Simulate__SystemSingle__SystemVoid(step);
        }

        public static void SyncTransforms()
        {
            internal_UnityEnginePhysics__func__SyncTransforms__SystemVoid();
        }

        public static bool ComputePenetration(global::UnityEngine.Collider colliderA, global::UnityEngine.Vector3 positionA, global::UnityEngine.Quaternion rotationA, global::UnityEngine.Collider colliderB, global::UnityEngine.Vector3 positionB, global::UnityEngine.Quaternion rotationB, out global::UnityEngine.Vector3 direction, out float distance)
        {
            return internal_UnityEnginePhysics__func__ComputePenetration__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3Ref__SystemSingleRef__SystemBoolean(colliderA, positionA, rotationA, colliderB, positionB, rotationB, out direction, out distance);
        }

        public static global::UnityEngine.Vector3 ClosestPoint(global::UnityEngine.Vector3 point, global::UnityEngine.Collider collider, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            return internal_UnityEnginePhysics__func__ClosestPoint__UnityEngineVector3__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3(point, collider, position, rotation);
        }

        public static int OverlapSphereNonAlloc(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(position, radius, results, layerMask, queryTriggerInteraction);
        }

        public static int OverlapSphereNonAlloc(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask)
        {
            return internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(position, radius, results, layerMask);
        }

        public static int OverlapSphereNonAlloc(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results)
        {
            return internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(position, radius, results);
        }

        public static bool CheckSphere(global::UnityEngine.Vector3 position, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(position, radius, layerMask, queryTriggerInteraction);
        }

        public static bool CheckSphere(global::UnityEngine.Vector3 position, float radius, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(position, radius, layerMask);
        }

        public static bool CheckSphere(global::UnityEngine.Vector3 position, float radius)
        {
            return internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemBoolean(position, radius);
        }

        public static int CapsuleCastNonAlloc(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int CapsuleCastNonAlloc(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(point1, point2, radius, direction, results, maxDistance, layerMask);
        }

        public static int CapsuleCastNonAlloc(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(point1, point2, radius, direction, results, maxDistance);
        }

        public static int CapsuleCastNonAlloc(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(point1, point2, radius, direction, results);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(origin, radius, direction, results, maxDistance, layerMask);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(origin, radius, direction, results, maxDistance);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(origin, radius, direction, results);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(ray, radius, results, maxDistance, layerMask);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(ray, radius, results, maxDistance);
        }

        public static int SphereCastNonAlloc(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemInt32(ray, radius, results);
        }

        public static bool CheckCapsule(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(start, end, radius, layerMask, queryTriggerInteraction);
        }

        public static bool CheckCapsule(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(start, end, radius, layerMask);
        }

        public static bool CheckCapsule(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius)
        {
            return internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(start, end, radius);
        }

        public static bool CheckBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layermask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(center, halfExtents, orientation, layermask, queryTriggerInteraction);
        }

        public static bool CheckBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask)
        {
            return internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemBoolean(center, halfExtents, orientation, layerMask);
        }

        public static bool CheckBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(center, halfExtents, orientation);
        }

        public static bool CheckBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents)
        {
            return internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__SystemBoolean(center, halfExtents);
        }

        public static global::UnityEngine.Collider[] OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(center, halfExtents, orientation, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.Collider[] OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask)
        {
            return internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineColliderArray(center, halfExtents, orientation, layerMask);
        }

        public static global::UnityEngine.Collider[] OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineColliderArray(center, halfExtents, orientation);
        }

        public static global::UnityEngine.Collider[] OverlapBox(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents)
        {
            return internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray(center, halfExtents);
        }

        public static int OverlapBoxNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int mask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(center, halfExtents, results, orientation, mask, queryTriggerInteraction);
        }

        public static int OverlapBoxNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int mask)
        {
            return internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__SystemInt32(center, halfExtents, results, orientation, mask);
        }

        public static int OverlapBoxNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32(center, halfExtents, results, orientation);
        }

        public static int OverlapBoxNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results)
        {
            return internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(center, halfExtents, results);
        }

        public static int BoxCastNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static int BoxCastNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemInt32(center, halfExtents, direction, results, orientation);
        }

        public static int BoxCastNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32(center, halfExtents, direction, results, orientation, maxDistance);
        }

        public static int BoxCastNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemInt32(center, halfExtents, direction, results, orientation, maxDistance, layerMask);
        }

        public static int BoxCastNonAlloc(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            return internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(center, halfExtents, direction, results);
        }

        public static global::UnityEngine.RaycastHit[] BoxCastAll(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
        }

        public static global::UnityEngine.RaycastHit[] BoxCastAll(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            return internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(center, halfExtents, direction, orientation, maxDistance, layerMask);
        }

        public static global::UnityEngine.RaycastHit[] BoxCastAll(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            return internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__UnityEngineRaycastHitArray(center, halfExtents, direction, orientation, maxDistance);
        }

        public static global::UnityEngine.RaycastHit[] BoxCastAll(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation)
        {
            return internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineRaycastHitArray(center, halfExtents, direction, orientation);
        }

        public static global::UnityEngine.RaycastHit[] BoxCastAll(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(center, halfExtents, direction);
        }

        public static int OverlapCapsuleNonAlloc(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(point0, point1, radius, results, layerMask, queryTriggerInteraction);
        }

        public static int OverlapCapsuleNonAlloc(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(point0, point1, radius, results, layerMask);
        }

        public static int OverlapCapsuleNonAlloc(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results)
        {
            return internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(point0, point1, radius, results);
        }

        public static void RebuildBroadphaseRegions(global::UnityEngine.Bounds worldBounds, int subdivisions)
        {
            internal_UnityEnginePhysics__func__RebuildBroadphaseRegions__UnityEngineBounds__SystemInt32__SystemVoid(worldBounds, subdivisions);
        }

        public static void BakeMesh(int meshID, bool convex)
        {
            internal_UnityEnginePhysics__func__BakeMesh__SystemInt32__SystemBoolean__SystemVoid(meshID, convex);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEnginePhysics__ctor()
        {
            return UnityEnginePhysics__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePhysics__get__gravity()
        {
            global::UnityEngine.Vector3 gravityValue = default;
            UnityEnginePhysics__get__gravity(Unsafe.AsPointer(ref gravityValue));
            global::UnityEngine.Vector3 returnResult = gravityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__gravity(global::UnityEngine.Vector3 gravity)
        {
            UnityEnginePhysics__set__gravity(Unsafe.AsPointer(ref gravity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__defaultContactOffset()
        {
            var methodCallResult = UnityEnginePhysics__get__defaultContactOffset();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__defaultContactOffset(float defaultContactOffset)
        {
            UnityEnginePhysics__set__defaultContactOffset(defaultContactOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__sleepThreshold()
        {
            var methodCallResult = UnityEnginePhysics__get__sleepThreshold();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__sleepThreshold(float sleepThreshold)
        {
            UnityEnginePhysics__set__sleepThreshold(sleepThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__queriesHitTriggers()
        {
            var methodCallResult = UnityEnginePhysics__get__queriesHitTriggers();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__queriesHitTriggers(bool queriesHitTriggers)
        {
            var queriesHitTriggersConverted = Unsafe.As<bool, int>(ref queriesHitTriggers);
            UnityEnginePhysics__set__queriesHitTriggers(queriesHitTriggersConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__queriesHitBackfaces()
        {
            var methodCallResult = UnityEnginePhysics__get__queriesHitBackfaces();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__queriesHitBackfaces(bool queriesHitBackfaces)
        {
            var queriesHitBackfacesConverted = Unsafe.As<bool, int>(ref queriesHitBackfaces);
            UnityEnginePhysics__set__queriesHitBackfaces(queriesHitBackfacesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__bounceThreshold()
        {
            var methodCallResult = UnityEnginePhysics__get__bounceThreshold();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__bounceThreshold(float bounceThreshold)
        {
            UnityEnginePhysics__set__bounceThreshold(bounceThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__defaultMaxDepenetrationVelocity()
        {
            var methodCallResult = UnityEnginePhysics__get__defaultMaxDepenetrationVelocity();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__defaultMaxDepenetrationVelocity(float defaultMaxDepenetrationVelocity)
        {
            UnityEnginePhysics__set__defaultMaxDepenetrationVelocity(defaultMaxDepenetrationVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__get__defaultSolverIterations()
        {
            var methodCallResult = UnityEnginePhysics__get__defaultSolverIterations();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__defaultSolverIterations(int defaultSolverIterations)
        {
            UnityEnginePhysics__set__defaultSolverIterations(defaultSolverIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__get__defaultSolverVelocityIterations()
        {
            var methodCallResult = UnityEnginePhysics__get__defaultSolverVelocityIterations();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__defaultSolverVelocityIterations(int defaultSolverVelocityIterations)
        {
            UnityEnginePhysics__set__defaultSolverVelocityIterations(defaultSolverVelocityIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__defaultMaxAngularSpeed()
        {
            var methodCallResult = UnityEnginePhysics__get__defaultMaxAngularSpeed();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__defaultMaxAngularSpeed(float defaultMaxAngularSpeed)
        {
            UnityEnginePhysics__set__defaultMaxAngularSpeed(defaultMaxAngularSpeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__improvedPatchFriction()
        {
            var methodCallResult = UnityEnginePhysics__get__improvedPatchFriction();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__improvedPatchFriction(bool improvedPatchFriction)
        {
            var improvedPatchFrictionConverted = Unsafe.As<bool, int>(ref improvedPatchFriction);
            UnityEnginePhysics__set__improvedPatchFriction(improvedPatchFrictionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.PhysicsScene internal_UnityEnginePhysics__get__defaultPhysicsScene()
        {
            global::UnityEngine.PhysicsScene defaultPhysicsSceneValue = default;
            UnityEnginePhysics__get__defaultPhysicsScene(Unsafe.AsPointer(ref defaultPhysicsSceneValue));
            global::UnityEngine.PhysicsScene returnResult = defaultPhysicsSceneValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__autoSimulation()
        {
            var methodCallResult = UnityEnginePhysics__get__autoSimulation();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__autoSimulation(bool autoSimulation)
        {
            var autoSimulationConverted = Unsafe.As<bool, int>(ref autoSimulation);
            UnityEnginePhysics__set__autoSimulation(autoSimulationConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__autoSyncTransforms()
        {
            var methodCallResult = UnityEnginePhysics__get__autoSyncTransforms();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__autoSyncTransforms(bool autoSyncTransforms)
        {
            var autoSyncTransformsConverted = Unsafe.As<bool, int>(ref autoSyncTransforms);
            UnityEnginePhysics__set__autoSyncTransforms(autoSyncTransformsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__reuseCollisionCallbacks()
        {
            var methodCallResult = UnityEnginePhysics__get__reuseCollisionCallbacks();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__reuseCollisionCallbacks(bool reuseCollisionCallbacks)
        {
            var reuseCollisionCallbacksConverted = Unsafe.As<bool, int>(ref reuseCollisionCallbacks);
            UnityEnginePhysics__set__reuseCollisionCallbacks(reuseCollisionCallbacksConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__interCollisionDistance()
        {
            var methodCallResult = UnityEnginePhysics__get__interCollisionDistance();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__interCollisionDistance(float interCollisionDistance)
        {
            UnityEnginePhysics__set__interCollisionDistance(interCollisionDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysics__get__interCollisionStiffness()
        {
            var methodCallResult = UnityEnginePhysics__get__interCollisionStiffness();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__interCollisionStiffness(float interCollisionStiffness)
        {
            UnityEnginePhysics__set__interCollisionStiffness(interCollisionStiffness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__get__interCollisionSettingsToggle()
        {
            var methodCallResult = UnityEnginePhysics__get__interCollisionSettingsToggle();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__interCollisionSettingsToggle(bool interCollisionSettingsToggle)
        {
            var interCollisionSettingsToggleConverted = Unsafe.As<bool, int>(ref interCollisionSettingsToggle);
            UnityEnginePhysics__set__interCollisionSettingsToggle(interCollisionSettingsToggleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePhysics__get__clothGravity()
        {
            global::UnityEngine.Vector3 clothGravityValue = default;
            UnityEnginePhysics__get__clothGravity(Unsafe.AsPointer(ref clothGravityValue));
            global::UnityEngine.Vector3 returnResult = clothGravityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__set__clothGravity(global::UnityEngine.Vector3 clothGravity)
        {
            UnityEnginePhysics__set__clothGravity(Unsafe.AsPointer(ref clothGravity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean__SystemVoid(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2, bool ignore)
        {
            var ignoreConverted = Unsafe.As<bool, int>(ref ignore);
            UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean__SystemVoid(collider1.WrappedId, collider2.WrappedId, ignoreConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemVoid(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2)
        {
            UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemVoid(collider1.WrappedId, collider2.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(int layer1, int layer2, bool ignore)
        {
            var ignoreConverted = Unsafe.As<bool, int>(ref ignore);
            UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(layer1, layer2, ignoreConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemVoid(int layer1, int layer2)
        {
            UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemVoid(layer1, layer2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__GetIgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean(int layer1, int layer2)
        {
            var methodCallResult = UnityEnginePhysics__func__GetIgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean(layer1, layer2);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__GetIgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean(global::UnityEngine.Collider collider1, global::UnityEngine.Collider collider2)
        {
            var methodCallResult = UnityEnginePhysics__func__GetIgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean(collider1.WrappedId, collider2.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Ray ray, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref ray), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Ray ray, float maxDistance, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref ray), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemBoolean(global::UnityEngine.Ray ray, float maxDistance)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref ray), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemBoolean(global::UnityEngine.Ray ray)
        {
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemBoolean(Unsafe.AsPointer(ref ray));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref ray), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end)
        {
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref hitInfo), layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref hitInfo), layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction)
        {
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref ray), radius, maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref ray), radius, maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemBoolean(global::UnityEngine.Ray ray, float radius, float maxDistance)
        {
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref ray), radius, maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemBoolean(global::UnityEngine.Ray ray, float radius)
        {
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref ray), radius);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref ray), radius, Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref ray), radius, Unsafe.AsPointer(ref hitInfo), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref ray), radius, Unsafe.AsPointer(ref hitInfo), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Ray ray, float radius, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref ray), radius, Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation)
        {
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction)
        {
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), Unsafe.AsPointer(ref orientation), maxDistance, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), Unsafe.AsPointer(ref orientation), maxDistance);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo, global::UnityEngine.Quaternion orientation)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo), Unsafe.AsPointer(ref orientation));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, out global::UnityEngine.RaycastHit hitInfo)
        {
            hitInfo = default;
            var methodCallResult = UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref hitInfo));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__RaycastAll__UnityEngineRay__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__RaycastAll__UnityEngineRay__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref ray), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref ray), resultsPointer, results.Length, maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(Unsafe.AsPointer(ref ray), resultsPointer, results.Length, maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Ray ray, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref ray), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref origin), Unsafe.AsPointer(ref direction), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), radius, maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), radius, maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float radius, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), radius, maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Ray ray, float radius)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref ray), radius, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, int layerMask)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(global::UnityEngine.Vector3 position, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(Unsafe.AsPointer(ref position), radius, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(global::UnityEngine.Vector3 position, float radius, int layerMask)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(Unsafe.AsPointer(ref position), radius, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(global::UnityEngine.Vector3 position, float radius)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(Unsafe.AsPointer(ref position), radius, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__Simulate__SystemSingle__SystemVoid(float step)
        {
            UnityEnginePhysics__func__Simulate__SystemSingle__SystemVoid(step);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__SyncTransforms__SystemVoid()
        {
            UnityEnginePhysics__func__SyncTransforms__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__ComputePenetration__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3Ref__SystemSingleRef__SystemBoolean(global::UnityEngine.Collider colliderA, global::UnityEngine.Vector3 positionA, global::UnityEngine.Quaternion rotationA, global::UnityEngine.Collider colliderB, global::UnityEngine.Vector3 positionB, global::UnityEngine.Quaternion rotationB, out global::UnityEngine.Vector3 direction, out float distance)
        {
            direction = default;
            distance = default;
            var methodCallResult = UnityEnginePhysics__func__ComputePenetration__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3Ref__SystemSingleRef__SystemBoolean(colliderA.WrappedId, Unsafe.AsPointer(ref positionA), Unsafe.AsPointer(ref rotationA), colliderB.WrappedId, Unsafe.AsPointer(ref positionB), Unsafe.AsPointer(ref rotationB), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref distance));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePhysics__func__ClosestPoint__UnityEngineVector3__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3(global::UnityEngine.Vector3 point, global::UnityEngine.Collider collider, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEnginePhysics__func__ClosestPoint__UnityEngineVector3__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3(Unsafe.AsPointer(ref point), collider.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref position), radius, resultsIdsPointer, resultsWasmLength, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results, int layerMask)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(Unsafe.AsPointer(ref position), radius, resultsIdsPointer, resultsWasmLength, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(global::UnityEngine.Vector3 position, float radius, global::UnityEngine.Collider[] results)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(Unsafe.AsPointer(ref position), radius, resultsIdsPointer, resultsWasmLength);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 position, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref position), radius, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 position, float radius, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref position), radius, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 position, float radius)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref position), radius);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Vector3 point1, global::UnityEngine.Vector3 point2, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref point1), Unsafe.AsPointer(ref point2), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length, maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Vector3 origin, float radius, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref origin), radius, Unsafe.AsPointer(ref direction), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref ray), radius, resultsPointer, results.Length, maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref ray), radius, resultsPointer, results.Length, maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(Unsafe.AsPointer(ref ray), radius, resultsPointer, results.Length, maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Ray ray, float radius, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref ray), radius, resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), radius, layerMask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), radius, layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float radius)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), radius);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layermask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation), layermask, (int) queryTriggerInteraction);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation), layerMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__SystemBoolean(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents)
        {
            var methodCallResult = UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__SystemBoolean(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation), layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineColliderArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation, int layerMask)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineColliderArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation), layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineColliderArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Quaternion orientation)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineColliderArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref orientation), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider[] internal_UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Collider[] returnResult = new global::UnityEngine.Collider[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Collider(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int mask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength, Unsafe.AsPointer(ref orientation), mask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation, int mask)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength, Unsafe.AsPointer(ref orientation), mask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results, global::UnityEngine.Quaternion orientation)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength, Unsafe.AsPointer(ref orientation));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Collider[] results)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), resultsIdsPointer, resultsWasmLength);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, Unsafe.AsPointer(ref orientation));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, Unsafe.AsPointer(ref orientation), maxDistance);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length, Unsafe.AsPointer(ref orientation), maxDistance, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.RaycastHit[] results)
        {
            fixed (global::UnityEngine.RaycastHit* resultsPointer = results)
            {
                var methodCallResult = UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), resultsPointer, results.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance, layerMask, (int) queryTriggerInteraction, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance, layerMask, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation, float maxDistance)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), maxDistance, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction, global::UnityEngine.Quaternion orientation)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref orientation), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RaycastHit[] internal_UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.RaycastHit* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(Unsafe.AsPointer(ref center), Unsafe.AsPointer(ref halfExtents), Unsafe.AsPointer(ref direction), &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.RaycastHit[] returnResult = new global::UnityEngine.RaycastHit[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask, global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, resultsIdsPointer, resultsWasmLength, layerMask, (int) queryTriggerInteraction);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results, int layerMask)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, resultsIdsPointer, resultsWasmLength, layerMask);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(global::UnityEngine.Vector3 point0, global::UnityEngine.Vector3 point1, float radius, global::UnityEngine.Collider[] results)
        {
            int resultsWasmLength = results.Length;
            long[] resultsIds = new long[resultsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < resultsWasmLength; i++) resultsIds[i] = (results[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* resultsIdsPointer = resultsIds)
            {
                var methodCallResult = UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(Unsafe.AsPointer(ref point0), Unsafe.AsPointer(ref point1), radius, resultsIdsPointer, resultsWasmLength);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__RebuildBroadphaseRegions__UnityEngineBounds__SystemInt32__SystemVoid(global::UnityEngine.Bounds worldBounds, int subdivisions)
        {
            UnityEnginePhysics__func__RebuildBroadphaseRegions__UnityEngineBounds__SystemInt32__SystemVoid(Unsafe.AsPointer(ref worldBounds), subdivisions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysics__func__BakeMesh__SystemInt32__SystemBoolean__SystemVoid(int meshID, bool convex)
        {
            var convexConverted = Unsafe.As<bool, int>(ref convex);
            UnityEnginePhysics__func__BakeMesh__SystemInt32__SystemBoolean__SystemVoid(meshID, convexConverted);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEnginePhysics__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__get__gravity(void* gravityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__set__gravity(void* gravityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__defaultContactOffset();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__defaultContactOffset(float defaultContactOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__sleepThreshold();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__sleepThreshold(float sleepThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__queriesHitTriggers();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__queriesHitTriggers(int queriesHitTriggersConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__queriesHitBackfaces();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__queriesHitBackfaces(int queriesHitBackfacesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__bounceThreshold();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__bounceThreshold(float bounceThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__defaultMaxDepenetrationVelocity();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__defaultMaxDepenetrationVelocity(float defaultMaxDepenetrationVelocity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__defaultSolverIterations();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__defaultSolverIterations(int defaultSolverIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__defaultSolverVelocityIterations();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__defaultSolverVelocityIterations(int defaultSolverVelocityIterations);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__defaultMaxAngularSpeed();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__defaultMaxAngularSpeed(float defaultMaxAngularSpeed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__improvedPatchFriction();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__improvedPatchFriction(int improvedPatchFrictionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__get__defaultPhysicsScene(void* defaultPhysicsScenePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__autoSimulation();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__autoSimulation(int autoSimulationConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__autoSyncTransforms();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__autoSyncTransforms(int autoSyncTransformsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__reuseCollisionCallbacks();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__reuseCollisionCallbacks(int reuseCollisionCallbacksConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__interCollisionDistance();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__interCollisionDistance(float interCollisionDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysics__get__interCollisionStiffness();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__interCollisionStiffness(float interCollisionStiffness);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__get__interCollisionSettingsToggle();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__set__interCollisionSettingsToggle(int interCollisionSettingsToggleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__get__clothGravity(void* clothGravityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__set__clothGravity(void* clothGravityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean__SystemVoid(long collider1ObjectId, long collider2ObjectId, int ignoreConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__IgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemVoid(long collider1ObjectId, long collider2ObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(int layer1, int layer2, int ignoreConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__IgnoreLayerCollision__SystemInt32__SystemInt32__SystemVoid(int layer1, int layer2);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__func__GetIgnoreLayerCollision__SystemInt32__SystemInt32__SystemBoolean(int layer1, int layer2);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysics__func__GetIgnoreCollision__UnityEngineCollider__UnityEngineCollider__SystemBoolean(long collider1ObjectId, long collider2ObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* originPointer, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(void* originPointer, void* directionPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(void* originPointer, void* directionPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(void* originPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* originPointer, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(void* originPointer, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(void* originPointer, void* directionPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* originPointer, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* rayPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemInt32__SystemBoolean(void* rayPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemSingle__SystemBoolean(void* rayPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__SystemBoolean(void* rayPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* rayPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(void* rayPointer, void* hitInfoPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(void* rayPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Raycast__UnityEngineRay__UnityEngineRaycastHitRef__SystemBoolean(void* rayPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* startPointer, void* endPointer, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemInt32__SystemBoolean(void* startPointer, void* endPointer, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__SystemBoolean(void* startPointer, void* endPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* startPointer, void* endPointer, void* hitInfoPointer, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemInt32__SystemBoolean(void* startPointer, void* endPointer, void* hitInfoPointer, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__Linecast__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* startPointer, void* endPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCast__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* originPointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(void* originPointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(void* originPointer, float radius, void* directionPointer, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* originPointer, float radius, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* rayPointer, float radius, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__SystemBoolean(void* rayPointer, float radius, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemSingle__SystemBoolean(void* rayPointer, float radius, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__SystemBoolean(void* rayPointer, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* rayPointer, float radius, void* hitInfoPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemInt32__SystemBoolean(void* rayPointer, float radius, void* hitInfoPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemSingle__SystemBoolean(void* rayPointer, float radius, void* hitInfoPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCast__UnityEngineRay__SystemSingle__UnityEngineRaycastHitRef__SystemBoolean(void* rayPointer, float radius, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer, void* orientationPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemSingle__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer, void* orientationPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__UnityEngineQuaternion__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer, void* orientationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCast__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitRef__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* hitInfoPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* originPointer, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* originPointer, void* directionPointer, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(void* originPointer, void* directionPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(void* originPointer, void* directionPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* rayPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* rayPointer, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(void* rayPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RaycastAll__UnityEngineRay__UnityEngineRaycastHitArray(void* rayPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* rayPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(void* rayPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(void* rayPointer, void* resultsPointer, int resultsWasmLength, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineRay__UnityEngineRaycastHitArray__SystemInt32(void* rayPointer, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* originPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(void* originPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(void* originPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__RaycastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(void* originPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__CapsuleCastAll__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* originPointer, float radius, void* directionPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* originPointer, float radius, void* directionPointer, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__SystemSingle__UnityEngineRaycastHitArray(void* originPointer, float radius, void* directionPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray(void* originPointer, float radius, void* directionPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* rayPointer, float radius, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* rayPointer, float radius, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__SystemSingle__UnityEngineRaycastHitArray(void* rayPointer, float radius, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__SphereCastAll__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray(void* rayPointer, float radius, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(void* point0Pointer, void* point1Pointer, float radius, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(void* point0Pointer, void* point1Pointer, float radius, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(void* point0Pointer, void* point1Pointer, float radius, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(void* positionPointer, float radius, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineColliderArray(void* positionPointer, float radius, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapSphere__UnityEngineVector3__SystemSingle__UnityEngineColliderArray(void* positionPointer, float radius, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__Simulate__SystemSingle__SystemVoid(float step);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__SyncTransforms__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__ComputePenetration__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3Ref__SystemSingleRef__SystemBoolean(long colliderAObjectId, void* positionAPointer, void* rotationAPointer, long colliderBObjectId, void* positionBPointer, void* rotationBPointer, void* directionPointer, void* distancePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__ClosestPoint__UnityEngineVector3__UnityEngineCollider__UnityEngineVector3__UnityEngineQuaternion__UnityEngineVector3(void* pointPointer, long colliderObjectId, void* positionPointer, void* rotationPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* positionPointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(void* positionPointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapSphereNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(void* positionPointer, float radius, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* positionPointer, float radius, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(void* positionPointer, float radius, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckSphere__UnityEngineVector3__SystemSingle__SystemBoolean(void* positionPointer, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CapsuleCastNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(void* point1Pointer, void* point2Pointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* originPointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(void* originPointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(void* originPointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineVector3__SystemSingle__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(void* originPointer, float radius, void* directionPointer, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* rayPointer, float radius, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32__SystemInt32(void* rayPointer, float radius, void* resultsPointer, int resultsWasmLength, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemSingle__SystemInt32(void* rayPointer, float radius, void* resultsPointer, int resultsWasmLength, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__SphereCastNonAlloc__UnityEngineRay__SystemSingle__UnityEngineRaycastHitArray__SystemInt32(void* rayPointer, float radius, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* startPointer, void* endPointer, float radius, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemInt32__SystemBoolean(void* startPointer, void* endPointer, float radius, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckCapsule__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemBoolean(void* startPointer, void* endPointer, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* orientationPointer, int layermask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* orientationPointer, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemBoolean(void* centerPointer, void* halfExtentsPointer, void* orientationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__CheckBox__UnityEngineVector3__UnityEngineVector3__SystemBoolean(void* centerPointer, void* halfExtentsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineColliderArray(void* centerPointer, void* halfExtentsPointer, void* orientationPointer, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__UnityEngineColliderArray(void* centerPointer, void* halfExtentsPointer, void* orientationPointer, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineColliderArray(void* centerPointer, void* halfExtentsPointer, void* orientationPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__OverlapBox__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray(void* centerPointer, void* halfExtentsPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength, void* orientationPointer, int mask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength, void* orientationPointer, int mask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__UnityEngineQuaternion__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength, void* orientationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapBoxNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineColliderArray__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, void* orientationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, void* orientationPointer, float maxDistance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__UnityEngineQuaternion__SystemSingle__SystemInt32__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength, void* orientationPointer, float maxDistance, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__BoxCastNonAlloc__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray__SystemInt32(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineQueryTriggerInteractionEnum__UnityEngineRaycastHitArray(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance, int layerMask, int queryTriggerInteractionUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__SystemInt32__UnityEngineRaycastHitArray(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance, int layerMask, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__SystemSingle__UnityEngineRaycastHitArray(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, float maxDistance, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineQuaternion__UnityEngineRaycastHitArray(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* orientationPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__BoxCastAll__UnityEngineVector3__UnityEngineVector3__UnityEngineVector3__UnityEngineRaycastHitArray(void* centerPointer, void* halfExtentsPointer, void* directionPointer, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__UnityEngineQueryTriggerInteractionEnum__SystemInt32(void* point0Pointer, void* point1Pointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask, int queryTriggerInteractionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32__SystemInt32(void* point0Pointer, void* point1Pointer, float radius, void* resultsIdsPointer, int resultsWasmLength, int layerMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePhysics__func__OverlapCapsuleNonAlloc__UnityEngineVector3__UnityEngineVector3__SystemSingle__UnityEngineColliderArray__SystemInt32(void* point0Pointer, void* point1Pointer, float radius, void* resultsIdsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePhysics__func__RebuildBroadphaseRegions__UnityEngineBounds__SystemInt32__SystemVoid(void* worldBoundsPointer, int subdivisions);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysics__func__BakeMesh__SystemInt32__SystemBoolean__SystemVoid(int meshID, int convexConverted);

        #endregion Imports
    }
}
