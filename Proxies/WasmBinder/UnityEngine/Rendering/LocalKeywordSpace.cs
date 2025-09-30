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
    public partial struct LocalKeywordSpace
    {

        #region Implementation

        public global::UnityEngine.Rendering.LocalKeyword[] keywords 
        {
            get => internal_UnityEngineRenderingLocalKeywordSpace__get__keywords(ref this);
        }

        public global::System.String[] keywordNames 
        {
            get => internal_UnityEngineRenderingLocalKeywordSpace__get__keywordNames(ref this);
        }

        public uint keywordCount 
        {
            get => internal_UnityEngineRenderingLocalKeywordSpace__get__keywordCount(ref this);
        }

        public global::UnityEngine.Rendering.LocalKeyword FindKeyword(string name)
        {
            return internal_UnityEngineRenderingLocalKeywordSpace__func__FindKeyword__SystemString__UnityEngineRenderingLocalKeyword(ref this, name);
        }

        public bool Equals(object o)
        {
            return internal_UnityEngineRenderingLocalKeywordSpace__func__Equals__SystemObject__SystemBoolean(ref this, o);
        }

        public bool Equals(global::UnityEngine.Rendering.LocalKeywordSpace rhs)
        {
            return internal_UnityEngineRenderingLocalKeywordSpace__func__Equals__UnityEngineRenderingLocalKeywordSpace__SystemBoolean(ref this, rhs);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineRenderingLocalKeywordSpace__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeyword[] internal_UnityEngineRenderingLocalKeywordSpace__get__keywords(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            long* keywordsIdsPointer = default;
            int keywordsWasmLength = default;
            UnityEngineRenderingLocalKeywordSpace__get__keywords(selfStructPointer, &keywordsIdsPointer, &keywordsWasmLength);
            global::UnityEngine.Rendering.LocalKeyword[] returnResult = new global::UnityEngine.Rendering.LocalKeyword[keywordsWasmLength];
            for (int i = 0; i < keywordsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.LocalKeyword(keywordsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)keywordsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineRenderingLocalKeywordSpace__get__keywordNames(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Exterrata: I would really like to put keywordNamesPointer first instead of keywordNamesWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* keywordNamesWasmLengthsPointer = default;
            char** keywordNamesPointer = default;
            int keywordNamesWasmLength = default;
            UnityEngineRenderingLocalKeywordSpace__get__keywordNames(selfStructPointer, &keywordNamesWasmLengthsPointer, &keywordNamesPointer, &keywordNamesWasmLength);

            // The changes were written to the pointers directly, we need to write to the array and free allocations
            var keywordNamesAux = new string[keywordNamesWasmLength];
            for (int i = 0; i < keywordNamesWasmLength; i++)
            {
                keywordNamesAux[i] = new string(keywordNamesPointer![i], 0, keywordNamesWasmLengthsPointer![i]);
                Marshal.FreeHGlobal((IntPtr)keywordNamesPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)keywordNamesPointer);
            Marshal.FreeHGlobal((IntPtr)keywordNamesWasmLengthsPointer);
            var returnResult = keywordNamesAux;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineRenderingLocalKeywordSpace__get__keywordCount(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLocalKeywordSpace__get__keywordCount(selfStructPointer);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeyword internal_UnityEngineRenderingLocalKeywordSpace__func__FindKeyword__SystemString__UnityEngineRenderingLocalKeyword(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEngineRenderingLocalKeywordSpace__func__FindKeyword__SystemString__UnityEngineRenderingLocalKeyword(selfStructPointer, namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Rendering.LocalKeyword(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeywordSpace__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct, object o)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineRenderingLocalKeywordSpace__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (o as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingLocalKeywordSpace__func__Equals__UnityEngineRenderingLocalKeywordSpace__SystemBoolean(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct, global::UnityEngine.Rendering.LocalKeywordSpace rhs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLocalKeywordSpace__func__Equals__UnityEngineRenderingLocalKeywordSpace__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref rhs));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingLocalKeywordSpace__func__GetHashCode__SystemInt32(ref global::UnityEngine.Rendering.LocalKeywordSpace selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingLocalKeywordSpace__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLocalKeywordSpace__get__keywords(void* selfStructPointer, void* keywordsIdsPointer, void* keywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingLocalKeywordSpace__get__keywordNames(void* selfStructPointer, void* keywordNamesWasmLengthsPointer, void* keywordNamesPointer, void* keywordNamesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLocalKeywordSpace__get__keywordCount(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingLocalKeywordSpace__func__FindKeyword__SystemString__UnityEngineRenderingLocalKeyword(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLocalKeywordSpace__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long oObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLocalKeywordSpace__func__Equals__UnityEngineRenderingLocalKeywordSpace__SystemBoolean(void* selfStructPointer, void* rhsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingLocalKeywordSpace__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
