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

    public partial class TMP_Style(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public static global::TMPro.TMP_Style NormalStyle 
        {
            get => internal_TMProTMP_Style__get__NormalStyle();
        }

        public string name 
        {
            get => internal_TMProTMP_Style__get__name(WrappedId);
            set => internal_TMProTMP_Style__set__name(WrappedId, value);
        }

        public int hashCode 
        {
            get => internal_TMProTMP_Style__get__hashCode(WrappedId);
            set => internal_TMProTMP_Style__set__hashCode(WrappedId, value);
        }

        public string styleOpeningDefinition 
        {
            get => internal_TMProTMP_Style__get__styleOpeningDefinition(WrappedId);
        }

        public string styleClosingDefinition 
        {
            get => internal_TMProTMP_Style__get__styleClosingDefinition(WrappedId);
        }

        public global::System.Int32[] styleOpeningTagArray 
        {
            get => internal_TMProTMP_Style__get__styleOpeningTagArray(WrappedId);
        }

        public global::System.Int32[] styleClosingTagArray 
        {
            get => internal_TMProTMP_Style__get__styleClosingTagArray(WrappedId);
        }

        public void RefreshStyle()
        {
            internal_TMProTMP_Style__func__RefreshStyle__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TMP_Style internal_TMProTMP_Style__get__NormalStyle()
        {
            var methodCallResult = TMProTMP_Style__get__NormalStyle();
            var returnResult = new global::TMPro.TMP_Style(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_TMProTMP_Style__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            TMProTMP_Style__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Style__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                TMProTMP_Style__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Style__get__hashCode(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Style__get__hashCode(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Style__set__hashCode(long selfObjectId, int hashCode)
        {
            TMProTMP_Style__set__hashCode(selfObjectId, hashCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_TMProTMP_Style__get__styleOpeningDefinition(long selfObjectId)
        {
            char* styleOpeningDefinitionPointer = default;
            int styleOpeningDefinitionWasmLength = default;
            TMProTMP_Style__get__styleOpeningDefinition(selfObjectId, &styleOpeningDefinitionPointer, &styleOpeningDefinitionWasmLength);
            string returnResult = new(styleOpeningDefinitionPointer, 0, styleOpeningDefinitionWasmLength);
            Marshal.FreeHGlobal((IntPtr)styleOpeningDefinitionPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_TMProTMP_Style__get__styleClosingDefinition(long selfObjectId)
        {
            char* styleClosingDefinitionPointer = default;
            int styleClosingDefinitionWasmLength = default;
            TMProTMP_Style__get__styleClosingDefinition(selfObjectId, &styleClosingDefinitionPointer, &styleClosingDefinitionWasmLength);
            string returnResult = new(styleClosingDefinitionPointer, 0, styleClosingDefinitionWasmLength);
            Marshal.FreeHGlobal((IntPtr)styleClosingDefinitionPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_TMProTMP_Style__get__styleOpeningTagArray(long selfObjectId)
        {
            int* styleOpeningTagArrayIdsPointer = default;
            int styleOpeningTagArrayWasmLength = default;
            TMProTMP_Style__get__styleOpeningTagArray(selfObjectId, &styleOpeningTagArrayIdsPointer, &styleOpeningTagArrayWasmLength);
            int[] returnResult = new int[styleOpeningTagArrayWasmLength];
            for (int i = 0; i < styleOpeningTagArrayWasmLength; i++)
            {
                returnResult[i] = styleOpeningTagArrayIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)styleOpeningTagArrayIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_TMProTMP_Style__get__styleClosingTagArray(long selfObjectId)
        {
            int* styleClosingTagArrayIdsPointer = default;
            int styleClosingTagArrayWasmLength = default;
            TMProTMP_Style__get__styleClosingTagArray(selfObjectId, &styleClosingTagArrayIdsPointer, &styleClosingTagArrayWasmLength);
            int[] returnResult = new int[styleClosingTagArrayWasmLength];
            for (int i = 0; i < styleClosingTagArrayWasmLength; i++)
            {
                returnResult[i] = styleClosingTagArrayIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)styleClosingTagArrayIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Style__func__RefreshStyle__SystemVoid(long selfObjectId)
        {
            TMProTMP_Style__func__RefreshStyle__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern long TMProTMP_Style__get__NormalStyle();

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Style__get__hashCode(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Style__set__hashCode(long selfObjectId, int hashCode);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__get__styleOpeningDefinition(long selfObjectId, void* styleOpeningDefinitionPointer, void* styleOpeningDefinitionWasmLengthsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__get__styleClosingDefinition(long selfObjectId, void* styleClosingDefinitionPointer, void* styleClosingDefinitionWasmLengthsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__get__styleOpeningTagArray(long selfObjectId, void* styleOpeningTagArrayIdsPointer, void* styleOpeningTagArrayWasmLengthPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Style__get__styleClosingTagArray(long selfObjectId, void* styleClosingTagArrayIdsPointer, void* styleClosingTagArrayWasmLengthPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Style__func__RefreshStyle__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
