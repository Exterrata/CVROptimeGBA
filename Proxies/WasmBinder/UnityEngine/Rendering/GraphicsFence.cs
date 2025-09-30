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
    public partial struct GraphicsFence
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal global::System.IntPtr m_Ptr;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        internal int m_Version;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        internal global::UnityEngine.Rendering.GraphicsFenceType m_FenceType;

        public bool passed 
        {
            get => internal_UnityEngineRenderingGraphicsFence__get__passed(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingGraphicsFence__get__passed(ref global::UnityEngine.Rendering.GraphicsFence selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingGraphicsFence__get__passed(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingGraphicsFence__get__passed(void* selfStructPointer);

        #endregion Imports
    }
}
