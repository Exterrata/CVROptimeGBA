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
    public partial struct RaycastHit
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_Point;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector3 m_Normal;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        internal uint m_FaceID;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        internal float m_Distance;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Vector2 m_UV;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        internal int m_Collider;

        public global::UnityEngine.Collider collider 
        {
            get => internal_UnityEngineRaycastHit__get__collider(ref this);
        }

        public int colliderInstanceID 
        {
            get => internal_UnityEngineRaycastHit__get__colliderInstanceID(ref this);
        }

        public global::UnityEngine.Vector3 point 
        {
            get => internal_UnityEngineRaycastHit__get__point(ref this);
            set => internal_UnityEngineRaycastHit__set__point(ref this, value);
        }

        public global::UnityEngine.Vector3 normal 
        {
            get => internal_UnityEngineRaycastHit__get__normal(ref this);
            set => internal_UnityEngineRaycastHit__set__normal(ref this, value);
        }

        public global::UnityEngine.Vector3 barycentricCoordinate 
        {
            get => internal_UnityEngineRaycastHit__get__barycentricCoordinate(ref this);
            set => internal_UnityEngineRaycastHit__set__barycentricCoordinate(ref this, value);
        }

        public float distance 
        {
            get => internal_UnityEngineRaycastHit__get__distance(ref this);
            set => internal_UnityEngineRaycastHit__set__distance(ref this, value);
        }

        public int triangleIndex 
        {
            get => internal_UnityEngineRaycastHit__get__triangleIndex(ref this);
        }

        public global::UnityEngine.Vector2 textureCoord 
        {
            get => internal_UnityEngineRaycastHit__get__textureCoord(ref this);
        }

        public global::UnityEngine.Vector2 textureCoord2 
        {
            get => internal_UnityEngineRaycastHit__get__textureCoord2(ref this);
        }

        public global::UnityEngine.Transform transform 
        {
            get => internal_UnityEngineRaycastHit__get__transform(ref this);
        }

        public global::UnityEngine.Rigidbody rigidbody 
        {
            get => internal_UnityEngineRaycastHit__get__rigidbody(ref this);
        }

        public global::UnityEngine.ArticulationBody articulationBody 
        {
            get => internal_UnityEngineRaycastHit__get__articulationBody(ref this);
        }

        public global::UnityEngine.Vector2 lightmapCoord 
        {
            get => internal_UnityEngineRaycastHit__get__lightmapCoord(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider internal_UnityEngineRaycastHit__get__collider(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__collider(selfStructPointer);
            var returnResult = new global::UnityEngine.Collider(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRaycastHit__get__colliderInstanceID(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__colliderInstanceID(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRaycastHit__get__point(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 pointValue = default;
            UnityEngineRaycastHit__get__point(selfStructPointer, Unsafe.AsPointer(ref pointValue));
            global::UnityEngine.Vector3 returnResult = pointValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRaycastHit__set__point(ref global::UnityEngine.RaycastHit selfStruct, global::UnityEngine.Vector3 point)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRaycastHit__set__point(selfStructPointer, Unsafe.AsPointer(ref point));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRaycastHit__get__normal(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 normalValue = default;
            UnityEngineRaycastHit__get__normal(selfStructPointer, Unsafe.AsPointer(ref normalValue));
            global::UnityEngine.Vector3 returnResult = normalValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRaycastHit__set__normal(ref global::UnityEngine.RaycastHit selfStruct, global::UnityEngine.Vector3 normal)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRaycastHit__set__normal(selfStructPointer, Unsafe.AsPointer(ref normal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRaycastHit__get__barycentricCoordinate(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 barycentricCoordinateValue = default;
            UnityEngineRaycastHit__get__barycentricCoordinate(selfStructPointer, Unsafe.AsPointer(ref barycentricCoordinateValue));
            global::UnityEngine.Vector3 returnResult = barycentricCoordinateValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRaycastHit__set__barycentricCoordinate(ref global::UnityEngine.RaycastHit selfStruct, global::UnityEngine.Vector3 barycentricCoordinate)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRaycastHit__set__barycentricCoordinate(selfStructPointer, Unsafe.AsPointer(ref barycentricCoordinate));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRaycastHit__get__distance(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__distance(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRaycastHit__set__distance(ref global::UnityEngine.RaycastHit selfStruct, float distance)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRaycastHit__set__distance(selfStructPointer, distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRaycastHit__get__triangleIndex(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__triangleIndex(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRaycastHit__get__textureCoord(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 textureCoordValue = default;
            UnityEngineRaycastHit__get__textureCoord(selfStructPointer, Unsafe.AsPointer(ref textureCoordValue));
            global::UnityEngine.Vector2 returnResult = textureCoordValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRaycastHit__get__textureCoord2(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 textureCoord2Value = default;
            UnityEngineRaycastHit__get__textureCoord2(selfStructPointer, Unsafe.AsPointer(ref textureCoord2Value));
            global::UnityEngine.Vector2 returnResult = textureCoord2Value;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineRaycastHit__get__transform(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__transform(selfStructPointer);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rigidbody internal_UnityEngineRaycastHit__get__rigidbody(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__rigidbody(selfStructPointer);
            var returnResult = new global::UnityEngine.Rigidbody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationBody internal_UnityEngineRaycastHit__get__articulationBody(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRaycastHit__get__articulationBody(selfStructPointer);
            var returnResult = new global::UnityEngine.ArticulationBody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRaycastHit__get__lightmapCoord(ref global::UnityEngine.RaycastHit selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector2 lightmapCoordValue = default;
            UnityEngineRaycastHit__get__lightmapCoord(selfStructPointer, Unsafe.AsPointer(ref lightmapCoordValue));
            global::UnityEngine.Vector2 returnResult = lightmapCoordValue;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRaycastHit__get__collider(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRaycastHit__get__colliderInstanceID(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__point(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__set__point(void* selfStructPointer, void* pointPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__set__normal(void* selfStructPointer, void* normalPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__barycentricCoordinate(void* selfStructPointer, void* barycentricCoordinatePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__set__barycentricCoordinate(void* selfStructPointer, void* barycentricCoordinatePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineRaycastHit__get__distance(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__set__distance(void* selfStructPointer, float distance);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRaycastHit__get__triangleIndex(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__textureCoord(void* selfStructPointer, void* textureCoordPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__textureCoord2(void* selfStructPointer, void* textureCoord2Pointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRaycastHit__get__transform(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRaycastHit__get__rigidbody(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRaycastHit__get__articulationBody(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRaycastHit__get__lightmapCoord(void* selfStructPointer, void* lightmapCoordPointer);

        #endregion Imports
    }
}
