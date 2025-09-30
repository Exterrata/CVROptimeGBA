//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace TMPro
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct VertexGradient
    {

        #region Implementation

        public VertexGradient(global::UnityEngine.Color color)
        {
            internal_TMProVertexGradient__ctor__UnityEngineColor(ref this, color);
        }

        public VertexGradient(global::UnityEngine.Color color0, global::UnityEngine.Color color1, global::UnityEngine.Color color2, global::UnityEngine.Color color3)
        {
            internal_TMProVertexGradient__ctor__UnityEngineColor__UnityEngineColor__UnityEngineColor__UnityEngineColor(ref this, color0, color1, color2, color3);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Color topLeft;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Color topRight;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Color bottomLeft;

        // [FieldOffset(48)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Color bottomRight;

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProVertexGradient__ctor__UnityEngineColor(ref global::TMPro.VertexGradient selfStruct, global::UnityEngine.Color color)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            TMProVertexGradient__ctor__UnityEngineColor(selfStructPointer, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProVertexGradient__ctor__UnityEngineColor__UnityEngineColor__UnityEngineColor__UnityEngineColor(ref global::TMPro.VertexGradient selfStruct, global::UnityEngine.Color color0, global::UnityEngine.Color color1, global::UnityEngine.Color color2, global::UnityEngine.Color color3)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            TMProVertexGradient__ctor__UnityEngineColor__UnityEngineColor__UnityEngineColor__UnityEngineColor(selfStructPointer, Unsafe.AsPointer(ref color0), Unsafe.AsPointer(ref color1), Unsafe.AsPointer(ref color2), Unsafe.AsPointer(ref color3));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProVertexGradient__ctor__UnityEngineColor(void* selfStructPointer, void* colorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProVertexGradient__ctor__UnityEngineColor__UnityEngineColor__UnityEngineColor__UnityEngineColor(void* selfStructPointer, void* color0Pointer, void* color1Pointer, void* color2Pointer, void* color3Pointer);

        #endregion Imports
    }
}
