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

    public partial class PhysicMaterial(long id) : Object(id)
    {

        #region Implementation

        public PhysicMaterial()
            : this(internal_UnityEnginePhysicMaterial__ctor()) { }

        public PhysicMaterial(string name)
            : this(internal_UnityEnginePhysicMaterial__ctor__SystemString(name)) { }

        public float bounciness 
        {
            get => internal_UnityEnginePhysicMaterial__get__bounciness(WrappedId);
            set => internal_UnityEnginePhysicMaterial__set__bounciness(WrappedId, value);
        }

        public float dynamicFriction 
        {
            get => internal_UnityEnginePhysicMaterial__get__dynamicFriction(WrappedId);
            set => internal_UnityEnginePhysicMaterial__set__dynamicFriction(WrappedId, value);
        }

        public float staticFriction 
        {
            get => internal_UnityEnginePhysicMaterial__get__staticFriction(WrappedId);
            set => internal_UnityEnginePhysicMaterial__set__staticFriction(WrappedId, value);
        }

        public global::UnityEngine.PhysicMaterialCombine frictionCombine 
        {
            get => internal_UnityEnginePhysicMaterial__get__frictionCombine(WrappedId);
            set => internal_UnityEnginePhysicMaterial__set__frictionCombine(WrappedId, value);
        }

        public global::UnityEngine.PhysicMaterialCombine bounceCombine 
        {
            get => internal_UnityEnginePhysicMaterial__get__bounceCombine(WrappedId);
            set => internal_UnityEnginePhysicMaterial__set__bounceCombine(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEnginePhysicMaterial__ctor()
        {
            return UnityEnginePhysicMaterial__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEnginePhysicMaterial__ctor__SystemString(string name)
        {
            fixed (char* namePointer = name)
            {
                return UnityEnginePhysicMaterial__ctor__SystemString(namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysicMaterial__get__bounciness(long selfObjectId)
        {
            var methodCallResult = UnityEnginePhysicMaterial__get__bounciness(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicMaterial__set__bounciness(long selfObjectId, float bounciness)
        {
            UnityEnginePhysicMaterial__set__bounciness(selfObjectId, bounciness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysicMaterial__get__dynamicFriction(long selfObjectId)
        {
            var methodCallResult = UnityEnginePhysicMaterial__get__dynamicFriction(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicMaterial__set__dynamicFriction(long selfObjectId, float dynamicFriction)
        {
            UnityEnginePhysicMaterial__set__dynamicFriction(selfObjectId, dynamicFriction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEnginePhysicMaterial__get__staticFriction(long selfObjectId)
        {
            var methodCallResult = UnityEnginePhysicMaterial__get__staticFriction(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicMaterial__set__staticFriction(long selfObjectId, float staticFriction)
        {
            UnityEnginePhysicMaterial__set__staticFriction(selfObjectId, staticFriction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.PhysicMaterialCombine internal_UnityEnginePhysicMaterial__get__frictionCombine(long selfObjectId)
        {
            var methodCallResult = UnityEnginePhysicMaterial__get__frictionCombine(selfObjectId);
            var returnResult = (global::UnityEngine.PhysicMaterialCombine)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicMaterial__set__frictionCombine(long selfObjectId, global::UnityEngine.PhysicMaterialCombine frictionCombine)
        {
            UnityEnginePhysicMaterial__set__frictionCombine(selfObjectId, (int) frictionCombine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.PhysicMaterialCombine internal_UnityEnginePhysicMaterial__get__bounceCombine(long selfObjectId)
        {
            var methodCallResult = UnityEnginePhysicMaterial__get__bounceCombine(selfObjectId);
            var returnResult = (global::UnityEngine.PhysicMaterialCombine)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePhysicMaterial__set__bounceCombine(long selfObjectId, global::UnityEngine.PhysicMaterialCombine bounceCombine)
        {
            UnityEnginePhysicMaterial__set__bounceCombine(selfObjectId, (int) bounceCombine);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEnginePhysicMaterial__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEnginePhysicMaterial__ctor__SystemString(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysicMaterial__get__bounciness(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysicMaterial__set__bounciness(long selfObjectId, float bounciness);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysicMaterial__get__dynamicFriction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysicMaterial__set__dynamicFriction(long selfObjectId, float dynamicFriction);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEnginePhysicMaterial__get__staticFriction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysicMaterial__set__staticFriction(long selfObjectId, float staticFriction);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysicMaterial__get__frictionCombine(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysicMaterial__set__frictionCombine(long selfObjectId, int frictionCombineUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEnginePhysicMaterial__get__bounceCombine(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEnginePhysicMaterial__set__bounceCombine(long selfObjectId, int bounceCombineUnderlyingValue);

        #endregion Imports
    }
}
