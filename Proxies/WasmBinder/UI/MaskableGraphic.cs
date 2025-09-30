//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.UI
{

    public partial class MaskableGraphic(long id) : global::UnityEngine.UI.Graphic(id)
    {

        #region Implementation

        public bool maskable 
        {
            get => internal_UnityEngineUIMaskableGraphic__get__maskable(WrappedId);
            set => internal_UnityEngineUIMaskableGraphic__set__maskable(WrappedId, value);
        }

        public bool isMaskingGraphic 
        {
            get => internal_UnityEngineUIMaskableGraphic__get__isMaskingGraphic(WrappedId);
            set => internal_UnityEngineUIMaskableGraphic__set__isMaskingGraphic(WrappedId, value);
        }

        public global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return internal_UnityEngineUIMaskableGraphic__func__GetModifiedMaterial__UnityEngineMaterial__UnityEngineMaterial(WrappedId, baseMaterial);
        }

        public void Cull(global::UnityEngine.Rect clipRect, bool validRect)
        {
            internal_UnityEngineUIMaskableGraphic__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(WrappedId, clipRect, validRect);
        }

        public void SetClipRect(global::UnityEngine.Rect clipRect, bool validRect)
        {
            internal_UnityEngineUIMaskableGraphic__func__SetClipRect__UnityEngineRect__SystemBoolean__SystemVoid(WrappedId, clipRect, validRect);
        }

        public void SetClipSoftness(global::UnityEngine.Vector2 clipSoftness)
        {
            internal_UnityEngineUIMaskableGraphic__func__SetClipSoftness__UnityEngineVector2__SystemVoid(WrappedId, clipSoftness);
        }

        public void RecalculateClipping()
        {
            internal_UnityEngineUIMaskableGraphic__func__RecalculateClipping__SystemVoid(WrappedId);
        }

        public void RecalculateMasking()
        {
            internal_UnityEngineUIMaskableGraphic__func__RecalculateMasking__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineUIMaskableGraphic__get__maskable(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIMaskableGraphic__get__maskable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__set__maskable(long selfObjectId, bool maskable)
        {
            var maskableConverted = Unsafe.As<bool, int>(ref maskable);
            UnityEngineUIMaskableGraphic__set__maskable(selfObjectId, maskableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineUIMaskableGraphic__get__isMaskingGraphic(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIMaskableGraphic__get__isMaskingGraphic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__set__isMaskingGraphic(long selfObjectId, bool isMaskingGraphic)
        {
            var isMaskingGraphicConverted = Unsafe.As<bool, int>(ref isMaskingGraphic);
            UnityEngineUIMaskableGraphic__set__isMaskingGraphic(selfObjectId, isMaskingGraphicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineUIMaskableGraphic__func__GetModifiedMaterial__UnityEngineMaterial__UnityEngineMaterial(long selfObjectId, global::UnityEngine.Material baseMaterial)
        {
            var methodCallResult = UnityEngineUIMaskableGraphic__func__GetModifiedMaterial__UnityEngineMaterial__UnityEngineMaterial(selfObjectId, baseMaterial.WrappedId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Rect clipRect, bool validRect)
        {
            var validRectConverted = Unsafe.As<bool, int>(ref validRect);
            UnityEngineUIMaskableGraphic__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref clipRect), validRectConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__func__SetClipRect__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Rect clipRect, bool validRect)
        {
            var validRectConverted = Unsafe.As<bool, int>(ref validRect);
            UnityEngineUIMaskableGraphic__func__SetClipRect__UnityEngineRect__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref clipRect), validRectConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__func__SetClipSoftness__UnityEngineVector2__SystemVoid(long selfObjectId, global::UnityEngine.Vector2 clipSoftness)
        {
            UnityEngineUIMaskableGraphic__func__SetClipSoftness__UnityEngineVector2__SystemVoid(selfObjectId, Unsafe.AsPointer(ref clipSoftness));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__func__RecalculateClipping__SystemVoid(long selfObjectId)
        {
            UnityEngineUIMaskableGraphic__func__RecalculateClipping__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIMaskableGraphic__func__RecalculateMasking__SystemVoid(long selfObjectId)
        {
            UnityEngineUIMaskableGraphic__func__RecalculateMasking__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineUIMaskableGraphic__get__maskable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIMaskableGraphic__set__maskable(long selfObjectId, int maskableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineUIMaskableGraphic__get__isMaskingGraphic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIMaskableGraphic__set__isMaskingGraphic(long selfObjectId, int isMaskingGraphicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIMaskableGraphic__func__GetModifiedMaterial__UnityEngineMaterial__UnityEngineMaterial(long selfObjectId, long baseMaterialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIMaskableGraphic__func__Cull__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, void* clipRectPointer, int validRectConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIMaskableGraphic__func__SetClipRect__UnityEngineRect__SystemBoolean__SystemVoid(long selfObjectId, void* clipRectPointer, int validRectConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIMaskableGraphic__func__SetClipSoftness__UnityEngineVector2__SystemVoid(long selfObjectId, void* clipSoftnessPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIMaskableGraphic__func__RecalculateClipping__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIMaskableGraphic__func__RecalculateMasking__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
