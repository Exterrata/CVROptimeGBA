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

    public partial struct ReflectionProbeBlendInfo(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public global::UnityEngine.ReflectionProbe probe
        {
            get => internal_UnityEngineRenderingReflectionProbeBlendInfo__get__probe(WrappedId);
            set => internal_UnityEngineRenderingReflectionProbeBlendInfo__set__probe(WrappedId, value);
        }

        public float weight
        {
            get => internal_UnityEngineRenderingReflectionProbeBlendInfo__get__weight(WrappedId);
            set => internal_UnityEngineRenderingReflectionProbeBlendInfo__set__weight(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ReflectionProbe internal_UnityEngineRenderingReflectionProbeBlendInfo__get__probe(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingReflectionProbeBlendInfo__get__probe(selfObjectId);
            var returnResult = new global::UnityEngine.ReflectionProbe(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingReflectionProbeBlendInfo__set__probe(long selfObjectId, global::UnityEngine.ReflectionProbe probe)
        {
            UnityEngineRenderingReflectionProbeBlendInfo__set__probe(selfObjectId, probe.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineRenderingReflectionProbeBlendInfo__get__weight(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingReflectionProbeBlendInfo__get__weight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingReflectionProbeBlendInfo__set__weight(long selfObjectId, float weight)
        {
            UnityEngineRenderingReflectionProbeBlendInfo__set__weight(selfObjectId, weight);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderingReflectionProbeBlendInfo__get__probe(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingReflectionProbeBlendInfo__set__probe(long selfObjectId, long probeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineRenderingReflectionProbeBlendInfo__get__weight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingReflectionProbeBlendInfo__set__weight(long selfObjectId, float weight);

        #endregion Imports
    }
}
