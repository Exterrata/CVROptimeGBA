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

    public partial class TextAsset(long id) : global::UnityEngine.Object(id)
    {

        #region Implementation

        public TextAsset()
            : this(internal_UnityEngineTextAsset__ctor()) { }

        public TextAsset(string text)
            : this(internal_UnityEngineTextAsset__ctor__SystemString(text)) { }

        public global::System.Byte[] bytes 
        {
            get => internal_UnityEngineTextAsset__get__bytes(WrappedId);
        }

        public string text 
        {
            get => internal_UnityEngineTextAsset__get__text(WrappedId);
        }

        public long dataSize 
        {
            get => internal_UnityEngineTextAsset__get__dataSize(WrappedId);
        }

        public string ToString()
        {
            return internal_UnityEngineTextAsset__func__ToString__SystemString(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTextAsset__ctor()
        {
            return UnityEngineTextAsset__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTextAsset__ctor__SystemString(string text)
        {
            fixed (char* textPointer = text)
            {
                return UnityEngineTextAsset__ctor__SystemString(textPointer, text.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Byte[] internal_UnityEngineTextAsset__get__bytes(long selfObjectId)
        {
            byte* bytesIdsPointer = default;
            int bytesWasmLength = default;
            UnityEngineTextAsset__get__bytes(selfObjectId, &bytesIdsPointer, &bytesWasmLength);
            byte[] returnResult = new byte[bytesWasmLength];
            for (int i = 0; i < bytesWasmLength; i++)
            {
                returnResult[i] = bytesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)bytesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineTextAsset__get__text(long selfObjectId)
        {
            char* textPointer = default;
            int textWasmLength = default;
            UnityEngineTextAsset__get__text(selfObjectId, &textPointer, &textWasmLength);
            string returnResult = new(textPointer, 0, textWasmLength);
            Marshal.FreeHGlobal((IntPtr)textPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTextAsset__get__dataSize(long selfObjectId)
        {
            var methodCallResult = UnityEngineTextAsset__get__dataSize(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineTextAsset__func__ToString__SystemString(long selfObjectId)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTextAsset__func__ToString__SystemString(selfObjectId, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTextAsset__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineTextAsset__ctor__SystemString(void* textPointer, int textWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTextAsset__get__bytes(long selfObjectId, void* bytesIdsPointer, void* bytesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTextAsset__get__text(long selfObjectId, void* textPointer, void* textWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTextAsset__get__dataSize(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTextAsset__func__ToString__SystemString(long selfObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
