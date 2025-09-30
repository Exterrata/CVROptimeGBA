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
    public partial struct ArticulationReducedSpace
    {

        #region Implementation

        public ArticulationReducedSpace(float a)
        {
            internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle(ref this, a);
        }

        public ArticulationReducedSpace(float a, float b)
        {
            internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle(ref this, a, b);
        }

        public ArticulationReducedSpace(float a, float b, float c)
        {
            internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle__SystemSingle(ref this, a, b, c);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private unsafe fixed float x[3];

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        public int dofCount;

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle(ref global::UnityEngine.ArticulationReducedSpace selfStruct, float a)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineArticulationReducedSpace__ctor__SystemSingle(selfStructPointer, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle(ref global::UnityEngine.ArticulationReducedSpace selfStruct, float a, float b)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle(selfStructPointer, a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle__SystemSingle(ref global::UnityEngine.ArticulationReducedSpace selfStruct, float a, float b, float c)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle__SystemSingle(selfStructPointer, a, b, c);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationReducedSpace__ctor__SystemSingle(void* selfStructPointer, float a);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle(void* selfStructPointer, float a, float b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationReducedSpace__ctor__SystemSingle__SystemSingle__SystemSingle(void* selfStructPointer, float a, float b, float c);

        #endregion Imports
    }
}
