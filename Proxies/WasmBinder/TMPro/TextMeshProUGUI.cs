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

    public partial class TextMeshProUGUI(long id) : global::TMPro.TMP_Text(id)
    {

        #region Implementation

        public bool autoSizeTextContainer 
        {
            get => internal_TMProTextMeshProUGUI__get__autoSizeTextContainer(WrappedId);
            set => internal_TMProTextMeshProUGUI__set__autoSizeTextContainer(WrappedId, value);
        }

        public global::UnityEngine.Vector4 maskOffset 
        {
            get => internal_TMProTextMeshProUGUI__get__maskOffset(WrappedId);
            set => internal_TMProTextMeshProUGUI__set__maskOffset(WrappedId, value);
        }

        public void CalculateLayoutInputHorizontal()
        {
            internal_TMProTextMeshProUGUI__func__CalculateLayoutInputHorizontal__SystemVoid(WrappedId);
        }

        public void CalculateLayoutInputVertical()
        {
            internal_TMProTextMeshProUGUI__func__CalculateLayoutInputVertical__SystemVoid(WrappedId);
        }

        public void SetVerticesDirty()
        {
            internal_TMProTextMeshProUGUI__func__SetVerticesDirty__SystemVoid(WrappedId);
        }

        public void SetLayoutDirty()
        {
            internal_TMProTextMeshProUGUI__func__SetLayoutDirty__SystemVoid(WrappedId);
        }

        public void SetMaterialDirty()
        {
            internal_TMProTextMeshProUGUI__func__SetMaterialDirty__SystemVoid(WrappedId);
        }

        public void SetAllDirty()
        {
            internal_TMProTextMeshProUGUI__func__SetAllDirty__SystemVoid(WrappedId);
        }

        public void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
            internal_TMProTextMeshProUGUI__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(WrappedId, update);
        }

        public void RecalculateClipping()
        {
            internal_TMProTextMeshProUGUI__func__RecalculateClipping__SystemVoid(WrappedId);
        }

        public void Cull(global::UnityEngine.Rect clipRect, bool validRect)
        {
            internal_TMProTextMeshProUGUI__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(WrappedId, clipRect, validRect);
        }

        public void UpdateMeshPadding()
        {
            internal_TMProTextMeshProUGUI__func__UpdateMeshPadding__SystemVoid(WrappedId);
        }

        public void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing)
        {
            internal_TMProTextMeshProUGUI__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, ignoreActiveState, forceTextReparsing);
        }

        public void ClearMesh()
        {
            internal_TMProTextMeshProUGUI__func__ClearMesh__SystemVoid(WrappedId);
        }

        public void UpdateGeometry(global::UnityEngine.Mesh mesh, int index)
        {
            internal_TMProTextMeshProUGUI__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(WrappedId, mesh, index);
        }

        public void UpdateVertexData(global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
            internal_TMProTextMeshProUGUI__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void UpdateVertexData()
        {
            internal_TMProTextMeshProUGUI__func__UpdateVertexData__SystemVoid(WrappedId);
        }

        public void UpdateFontAsset()
        {
            internal_TMProTextMeshProUGUI__func__UpdateFontAsset__SystemVoid(WrappedId);
        }

        public void ComputeMarginSize()
        {
            internal_TMProTextMeshProUGUI__func__ComputeMarginSize__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTextMeshProUGUI__get__autoSizeTextContainer(long selfObjectId)
        {
            var methodCallResult = TMProTextMeshProUGUI__get__autoSizeTextContainer(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__set__autoSizeTextContainer(long selfObjectId, bool autoSizeTextContainer)
        {
            var autoSizeTextContainerConverted = Unsafe.As<bool, int>(ref autoSizeTextContainer);
            TMProTextMeshProUGUI__set__autoSizeTextContainer(selfObjectId, autoSizeTextContainerConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_TMProTextMeshProUGUI__get__maskOffset(long selfObjectId)
        {
            global::UnityEngine.Vector4 maskOffsetValue = default;
            TMProTextMeshProUGUI__get__maskOffset(selfObjectId, Unsafe.AsPointer(ref maskOffsetValue));
            global::UnityEngine.Vector4 returnResult = maskOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__set__maskOffset(long selfObjectId, global::UnityEngine.Vector4 maskOffset)
        {
            TMProTextMeshProUGUI__set__maskOffset(selfObjectId, Unsafe.AsPointer(ref maskOffset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__CalculateLayoutInputHorizontal__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__CalculateLayoutInputHorizontal__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__CalculateLayoutInputVertical__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__CalculateLayoutInputVertical__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__SetVerticesDirty__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__SetVerticesDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__SetLayoutDirty__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__SetLayoutDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__SetMaterialDirty__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__SetMaterialDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__SetAllDirty__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__SetAllDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(long selfObjectId, global::UnityEngine.UI.CanvasUpdate update)
        {
            TMProTextMeshProUGUI__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(selfObjectId, (int) update);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__RecalculateClipping__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__RecalculateClipping__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Rect clipRect, bool validRect)
        {
            var validRectConverted = Unsafe.As<bool, int>(ref validRect);
            TMProTextMeshProUGUI__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref clipRect), validRectConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__UpdateMeshPadding__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__UpdateMeshPadding__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, bool ignoreActiveState, bool forceTextReparsing)
        {
            var ignoreActiveStateConverted = Unsafe.As<bool, int>(ref ignoreActiveState);
            var forceTextReparsingConverted = Unsafe.As<bool, int>(ref forceTextReparsing);
            TMProTextMeshProUGUI__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, ignoreActiveStateConverted, forceTextReparsingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__ClearMesh__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__ClearMesh__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int index)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::UnityEngine.Mesh is not implemented yet! We need to find a way to pass non-wrapped instances...");
            TMProTextMeshProUGUI__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(long selfObjectId, global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
            TMProTextMeshProUGUI__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__UpdateVertexData__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__UpdateVertexData__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__UpdateFontAsset__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__UpdateFontAsset__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTextMeshProUGUI__func__ComputeMarginSize__SystemVoid(long selfObjectId)
        {
            TMProTextMeshProUGUI__func__ComputeMarginSize__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTextMeshProUGUI__get__autoSizeTextContainer(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__set__autoSizeTextContainer(long selfObjectId, int autoSizeTextContainerConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTextMeshProUGUI__get__maskOffset(long selfObjectId, void* maskOffsetPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTextMeshProUGUI__set__maskOffset(long selfObjectId, void* maskOffsetPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__CalculateLayoutInputHorizontal__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__CalculateLayoutInputVertical__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__SetVerticesDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__SetLayoutDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__SetMaterialDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__SetAllDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(long selfObjectId, int updateUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__RecalculateClipping__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTextMeshProUGUI__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, void* clipRectPointer, int validRectConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__UpdateMeshPadding__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int ignoreActiveStateConverted, int forceTextReparsingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__ClearMesh__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, int index);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__UpdateVertexData__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__UpdateFontAsset__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTextMeshProUGUI__func__ComputeMarginSize__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
