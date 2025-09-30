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

    public partial class OffMeshLink(long id) : Behaviour(id)
    {

        #region Implementation

        public bool activated 
        {
            get => internal_UnityEngineAIOffMeshLink__get__activated(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__activated(WrappedId, value);
        }

        public bool occupied 
        {
            get => internal_UnityEngineAIOffMeshLink__get__occupied(WrappedId);
        }

        public float costOverride 
        {
            get => internal_UnityEngineAIOffMeshLink__get__costOverride(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__costOverride(WrappedId, value);
        }

        public bool biDirectional 
        {
            get => internal_UnityEngineAIOffMeshLink__get__biDirectional(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__biDirectional(WrappedId, value);
        }

        public int area 
        {
            get => internal_UnityEngineAIOffMeshLink__get__area(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__area(WrappedId, value);
        }

        public bool autoUpdatePositions 
        {
            get => internal_UnityEngineAIOffMeshLink__get__autoUpdatePositions(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__autoUpdatePositions(WrappedId, value);
        }

        public global::UnityEngine.Transform startTransform 
        {
            get => internal_UnityEngineAIOffMeshLink__get__startTransform(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__startTransform(WrappedId, value);
        }

        public global::UnityEngine.Transform endTransform 
        {
            get => internal_UnityEngineAIOffMeshLink__get__endTransform(WrappedId);
            set => internal_UnityEngineAIOffMeshLink__set__endTransform(WrappedId, value);
        }

        public void UpdatePositions()
        {
            internal_UnityEngineAIOffMeshLink__func__UpdatePositions__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLink__get__activated(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__activated(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__activated(long selfObjectId, bool activated)
        {
            var activatedConverted = Unsafe.As<bool, int>(ref activated);
            UnityEngineAIOffMeshLink__set__activated(selfObjectId, activatedConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLink__get__occupied(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__occupied(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAIOffMeshLink__get__costOverride(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__costOverride(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__costOverride(long selfObjectId, float costOverride)
        {
            UnityEngineAIOffMeshLink__set__costOverride(selfObjectId, costOverride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLink__get__biDirectional(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__biDirectional(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__biDirectional(long selfObjectId, bool biDirectional)
        {
            var biDirectionalConverted = Unsafe.As<bool, int>(ref biDirectional);
            UnityEngineAIOffMeshLink__set__biDirectional(selfObjectId, biDirectionalConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAIOffMeshLink__get__area(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__area(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__area(long selfObjectId, int area)
        {
            UnityEngineAIOffMeshLink__set__area(selfObjectId, area);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAIOffMeshLink__get__autoUpdatePositions(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__autoUpdatePositions(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__autoUpdatePositions(long selfObjectId, bool autoUpdatePositions)
        {
            var autoUpdatePositionsConverted = Unsafe.As<bool, int>(ref autoUpdatePositions);
            UnityEngineAIOffMeshLink__set__autoUpdatePositions(selfObjectId, autoUpdatePositionsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineAIOffMeshLink__get__startTransform(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__startTransform(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__startTransform(long selfObjectId, global::UnityEngine.Transform startTransform)
        {
            UnityEngineAIOffMeshLink__set__startTransform(selfObjectId, startTransform.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineAIOffMeshLink__get__endTransform(long selfObjectId)
        {
            var methodCallResult = UnityEngineAIOffMeshLink__get__endTransform(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__set__endTransform(long selfObjectId, global::UnityEngine.Transform endTransform)
        {
            UnityEngineAIOffMeshLink__set__endTransform(selfObjectId, endTransform.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAIOffMeshLink__func__UpdatePositions__SystemVoid(long selfObjectId)
        {
            UnityEngineAIOffMeshLink__func__UpdatePositions__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAIOffMeshLink__get__activated(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__activated(long selfObjectId, int activatedConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAIOffMeshLink__get__occupied(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAIOffMeshLink__get__costOverride(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__costOverride(long selfObjectId, float costOverride);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAIOffMeshLink__get__biDirectional(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__biDirectional(long selfObjectId, int biDirectionalConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAIOffMeshLink__get__area(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__area(long selfObjectId, int area);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAIOffMeshLink__get__autoUpdatePositions(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__autoUpdatePositions(long selfObjectId, int autoUpdatePositionsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAIOffMeshLink__get__startTransform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__startTransform(long selfObjectId, long startTransformObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAIOffMeshLink__get__endTransform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__set__endTransform(long selfObjectId, long endTransformObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAIOffMeshLink__func__UpdatePositions__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
