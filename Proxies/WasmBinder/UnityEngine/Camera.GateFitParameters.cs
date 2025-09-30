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

    public partial class Camera
    {
        [StructLayout(LayoutKind.Sequential)]
        public partial struct GateFitParameters
        {

            #region Implementation

            public GateFitParameters(global::UnityEngine.Camera.GateFitMode mode, float aspect)
            {
                internal_UnityEngineCamera_GateFitParameters__ctor__UnityEngineGateFitModeEnum__SystemSingle(ref this, mode, aspect);
            }

            // [FieldOffset(0)] (the backing field offset)
            public global::UnityEngine.Camera.GateFitMode mode { get; set; }

            // [FieldOffset(4)] (the backing field offset)
            public float aspect { get; set; }

            #endregion Implementation

            #region Marshaling

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static unsafe void internal_UnityEngineCamera_GateFitParameters__ctor__UnityEngineGateFitModeEnum__SystemSingle(ref global::UnityEngine.Camera.GateFitParameters selfStruct, global::UnityEngine.Camera.GateFitMode mode, float aspect)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                UnityEngineCamera_GateFitParameters__ctor__UnityEngineGateFitModeEnum__SystemSingle(selfStructPointer, (int) mode, aspect);
            }

            #endregion Marshaling

            #region Imports

            [WasmImportLinkage, DllImport("UnityEngine")]
            private static extern unsafe void UnityEngineCamera_GateFitParameters__ctor__UnityEngineGateFitModeEnum__SystemSingle(void* selfStructPointer, int modeUnderlyingValue, float aspect);

            #endregion Imports
        }
    }
}
