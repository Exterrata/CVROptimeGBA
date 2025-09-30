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

    public partial struct GlobalKeyword(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public GlobalKeyword(string name)
            : this(internal_UnityEngineRenderingGlobalKeyword__ctor__SystemString(name)) { }

        public string name 
        {
            get => internal_UnityEngineRenderingGlobalKeyword__get__name(WrappedId);
        }

        public static global::UnityEngine.Rendering.GlobalKeyword Create(string name)
        {
            return internal_UnityEngineRenderingGlobalKeyword__func__Create__SystemString__UnityEngineRenderingGlobalKeyword(name);
        }

        public string ToString()
        {
            return internal_UnityEngineRenderingGlobalKeyword__func__ToString__SystemString(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingGlobalKeyword__ctor__SystemString(string name)
        {
            fixed (char* namePointer = name)
            {
                return UnityEngineRenderingGlobalKeyword__ctor__SystemString(namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingGlobalKeyword__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineRenderingGlobalKeyword__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GlobalKeyword internal_UnityEngineRenderingGlobalKeyword__func__Create__SystemString__UnityEngineRenderingGlobalKeyword(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineRenderingGlobalKeyword__func__Create__SystemString__UnityEngineRenderingGlobalKeyword(namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Rendering.GlobalKeyword(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingGlobalKeyword__func__ToString__SystemString(long selfObjectId)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineRenderingGlobalKeyword__func__ToString__SystemString(selfObjectId, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingGlobalKeyword__ctor__SystemString(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingGlobalKeyword__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingGlobalKeyword__func__Create__SystemString__UnityEngineRenderingGlobalKeyword(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingGlobalKeyword__func__ToString__SystemString(long selfObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
