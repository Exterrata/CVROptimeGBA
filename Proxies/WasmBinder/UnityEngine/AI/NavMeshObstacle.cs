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

    public partial class NavMeshObstacle(long id) : Behaviour(id)
    {

        #region Implementation

        public float height 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__height(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__height(WrappedId, value);
        }

        public float radius 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__radius(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__radius(WrappedId, value);
        }

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__velocity(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__velocity(WrappedId, value);
        }

        public bool carving 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__carving(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__carving(WrappedId, value);
        }

        public bool carveOnlyStationary 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__carveOnlyStationary(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__carveOnlyStationary(WrappedId, value);
        }

        public float carvingMoveThreshold 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__carvingMoveThreshold(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__carvingMoveThreshold(WrappedId, value);
        }

        public float carvingTimeToStationary 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__carvingTimeToStationary(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__carvingTimeToStationary(WrappedId, value);
        }

        public global::UnityEngine.AI.NavMeshObstacleShape shape 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__shape(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__shape(WrappedId, value);
        }

        public global::UnityEngine.Vector3 center 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__center(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__center(WrappedId, value);
        }

        public global::UnityEngine.Vector3 size 
        {
            get => internal_UnityEngineAINavMeshObstacle__get__size(WrappedId);
            set => internal_UnityEngineAINavMeshObstacle__set__size(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshObstacle__get__height(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__height(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__height(long selfObjectId, float height)
        {
            UnityEngineAINavMeshObstacle__set__height(selfObjectId, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshObstacle__get__radius(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__radius(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__radius(long selfObjectId, float radius)
        {
            UnityEngineAINavMeshObstacle__set__radius(selfObjectId, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshObstacle__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineAINavMeshObstacle__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__velocity(long selfObjectId, global::UnityEngine.Vector3 velocity)
        {
            UnityEngineAINavMeshObstacle__set__velocity(selfObjectId, Unsafe.AsPointer(ref velocity));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshObstacle__get__carving(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__carving(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__carving(long selfObjectId, bool carving)
        {
            var carvingConverted = Unsafe.As<bool, int>(ref carving);
            UnityEngineAINavMeshObstacle__set__carving(selfObjectId, carvingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAINavMeshObstacle__get__carveOnlyStationary(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__carveOnlyStationary(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__carveOnlyStationary(long selfObjectId, bool carveOnlyStationary)
        {
            var carveOnlyStationaryConverted = Unsafe.As<bool, int>(ref carveOnlyStationary);
            UnityEngineAINavMeshObstacle__set__carveOnlyStationary(selfObjectId, carveOnlyStationaryConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshObstacle__get__carvingMoveThreshold(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__carvingMoveThreshold(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__carvingMoveThreshold(long selfObjectId, float carvingMoveThreshold)
        {
            UnityEngineAINavMeshObstacle__set__carvingMoveThreshold(selfObjectId, carvingMoveThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAINavMeshObstacle__get__carvingTimeToStationary(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__carvingTimeToStationary(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__carvingTimeToStationary(long selfObjectId, float carvingTimeToStationary)
        {
            UnityEngineAINavMeshObstacle__set__carvingTimeToStationary(selfObjectId, carvingTimeToStationary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AI.NavMeshObstacleShape internal_UnityEngineAINavMeshObstacle__get__shape(long selfObjectId)
        {
            var methodCallResult = UnityEngineAINavMeshObstacle__get__shape(selfObjectId);
            var returnResult = (global::UnityEngine.AI.NavMeshObstacleShape)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__shape(long selfObjectId, global::UnityEngine.AI.NavMeshObstacleShape shape)
        {
            UnityEngineAINavMeshObstacle__set__shape(selfObjectId, (int) shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshObstacle__get__center(long selfObjectId)
        {
            global::UnityEngine.Vector3 centerValue = default;
            UnityEngineAINavMeshObstacle__get__center(selfObjectId, Unsafe.AsPointer(ref centerValue));
            global::UnityEngine.Vector3 returnResult = centerValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__center(long selfObjectId, global::UnityEngine.Vector3 center)
        {
            UnityEngineAINavMeshObstacle__set__center(selfObjectId, Unsafe.AsPointer(ref center));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAINavMeshObstacle__get__size(long selfObjectId)
        {
            global::UnityEngine.Vector3 sizeValue = default;
            UnityEngineAINavMeshObstacle__get__size(selfObjectId, Unsafe.AsPointer(ref sizeValue));
            global::UnityEngine.Vector3 returnResult = sizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAINavMeshObstacle__set__size(long selfObjectId, global::UnityEngine.Vector3 size)
        {
            UnityEngineAINavMeshObstacle__set__size(selfObjectId, Unsafe.AsPointer(ref size));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshObstacle__get__height(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__height(long selfObjectId, float height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshObstacle__get__radius(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__radius(long selfObjectId, float radius);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__set__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshObstacle__get__carving(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__carving(long selfObjectId, int carvingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshObstacle__get__carveOnlyStationary(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__carveOnlyStationary(long selfObjectId, int carveOnlyStationaryConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshObstacle__get__carvingMoveThreshold(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__carvingMoveThreshold(long selfObjectId, float carvingMoveThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAINavMeshObstacle__get__carvingTimeToStationary(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__carvingTimeToStationary(long selfObjectId, float carvingTimeToStationary);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAINavMeshObstacle__get__shape(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAINavMeshObstacle__set__shape(long selfObjectId, int shapeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__get__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__set__center(long selfObjectId, void* centerPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__get__size(long selfObjectId, void* sizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAINavMeshObstacle__set__size(long selfObjectId, void* sizePointer);

        #endregion Imports
    }
}
