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
    public partial struct RendererList
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal global::System.UIntPtr context;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        internal uint index;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        internal uint frame;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        internal uint type;

        public bool isValid 
        {
            get => internal_UnityEngineRenderingRendererList__get__isValid(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingRendererList__get__isValid(ref global::UnityEngine.Rendering.RendererList selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingRendererList__get__isValid(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingRendererList__get__isValid(void* selfStructPointer);

        #endregion Imports
    }
}
