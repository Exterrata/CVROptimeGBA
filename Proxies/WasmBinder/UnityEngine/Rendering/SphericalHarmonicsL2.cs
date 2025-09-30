//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SphericalHarmonicsL2
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private float shr0;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private float shr1;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private float shr2;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float shr3;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private float shr4;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private float shr5;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float shr6;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private float shr7;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private float shr8;

        // [FieldOffset(36)] (implicit field offset from sequential layout kind)
        private float shg0;

        // [FieldOffset(40)] (implicit field offset from sequential layout kind)
        private float shg1;

        // [FieldOffset(44)] (implicit field offset from sequential layout kind)
        private float shg2;

        // [FieldOffset(48)] (implicit field offset from sequential layout kind)
        private float shg3;

        // [FieldOffset(52)] (implicit field offset from sequential layout kind)
        private float shg4;

        // [FieldOffset(56)] (implicit field offset from sequential layout kind)
        private float shg5;

        // [FieldOffset(60)] (implicit field offset from sequential layout kind)
        private float shg6;

        // [FieldOffset(64)] (implicit field offset from sequential layout kind)
        private float shg7;

        // [FieldOffset(68)] (implicit field offset from sequential layout kind)
        private float shg8;

        // [FieldOffset(72)] (implicit field offset from sequential layout kind)
        private float shb0;

        // [FieldOffset(76)] (implicit field offset from sequential layout kind)
        private float shb1;

        // [FieldOffset(80)] (implicit field offset from sequential layout kind)
        private float shb2;

        // [FieldOffset(84)] (implicit field offset from sequential layout kind)
        private float shb3;

        // [FieldOffset(88)] (implicit field offset from sequential layout kind)
        private float shb4;

        // [FieldOffset(92)] (implicit field offset from sequential layout kind)
        private float shb5;

        // [FieldOffset(96)] (implicit field offset from sequential layout kind)
        private float shb6;

        // [FieldOffset(100)] (implicit field offset from sequential layout kind)
        private float shb7;

        // [FieldOffset(104)] (implicit field offset from sequential layout kind)
        private float shb8;

        public void Clear()
        {
            internal_UnityEngineRenderingSphericalHarmonicsL2__func__Clear__SystemVoid(ref this);
        }

        public void AddAmbientLight(global::UnityEngine.Color color)
        {
            internal_UnityEngineRenderingSphericalHarmonicsL2__func__AddAmbientLight__UnityEngineColor__SystemVoid(ref this, color);
        }

        public void AddDirectionalLight(global::UnityEngine.Vector3 direction, global::UnityEngine.Color color, float intensity)
        {
            internal_UnityEngineRenderingSphericalHarmonicsL2__func__AddDirectionalLight__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(ref this, direction, color, intensity);
        }

        public void Evaluate(global::UnityEngine.Vector3[] directions, global::UnityEngine.Color[] results)
        {
            internal_UnityEngineRenderingSphericalHarmonicsL2__func__Evaluate__UnityEngineVector3Array__UnityEngineColorArray__SystemVoid(ref this, directions, results);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingSphericalHarmonicsL2__func__GetHashCode__SystemInt32(ref this);
        }

        public bool Equals(object other)
        {
            return internal_UnityEngineRenderingSphericalHarmonicsL2__func__Equals__SystemObject__SystemBoolean(ref this, other);
        }

        public bool Equals(global::UnityEngine.Rendering.SphericalHarmonicsL2 other)
        {
            return internal_UnityEngineRenderingSphericalHarmonicsL2__func__Equals__UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(ref this, other);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingSphericalHarmonicsL2__func__Clear__SystemVoid(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingSphericalHarmonicsL2__func__Clear__SystemVoid(selfStructPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingSphericalHarmonicsL2__func__AddAmbientLight__UnityEngineColor__SystemVoid(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct, global::UnityEngine.Color color)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingSphericalHarmonicsL2__func__AddAmbientLight__UnityEngineColor__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingSphericalHarmonicsL2__func__AddDirectionalLight__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct, global::UnityEngine.Vector3 direction, global::UnityEngine.Color color, float intensity)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingSphericalHarmonicsL2__func__AddDirectionalLight__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(selfStructPointer, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref color), intensity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingSphericalHarmonicsL2__func__Evaluate__UnityEngineVector3Array__UnityEngineColorArray__SystemVoid(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct, global::UnityEngine.Vector3[] directions, global::UnityEngine.Color[] results)
        {
            fixed (global::UnityEngine.Vector3* directionsPointer = directions)
            {
                fixed (global::UnityEngine.Color* resultsPointer = results)
                {
                    var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                    UnityEngineRenderingSphericalHarmonicsL2__func__Evaluate__UnityEngineVector3Array__UnityEngineColorArray__SystemVoid(selfStructPointer, directionsPointer, directions.Length, resultsPointer, results.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingSphericalHarmonicsL2__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingSphericalHarmonicsL2__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingSphericalHarmonicsL2__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct, object other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingSphericalHarmonicsL2__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingSphericalHarmonicsL2__func__Equals__UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(ref global::UnityEngine.Rendering.SphericalHarmonicsL2 selfStruct, global::UnityEngine.Rendering.SphericalHarmonicsL2 other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingSphericalHarmonicsL2__func__Equals__UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSphericalHarmonicsL2__func__Clear__SystemVoid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSphericalHarmonicsL2__func__AddAmbientLight__UnityEngineColor__SystemVoid(void* selfStructPointer, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSphericalHarmonicsL2__func__AddDirectionalLight__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(void* selfStructPointer, void* directionPointer, void* colorPointer, float intensity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingSphericalHarmonicsL2__func__Evaluate__UnityEngineVector3Array__UnityEngineColorArray__SystemVoid(void* selfStructPointer, void* directionsPointer, int directionsWasmLength, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingSphericalHarmonicsL2__func__GetHashCode__SystemInt32(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingSphericalHarmonicsL2__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingSphericalHarmonicsL2__func__Equals__UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(void* selfStructPointer, void* otherPointer);

        #endregion Imports
    }
}
