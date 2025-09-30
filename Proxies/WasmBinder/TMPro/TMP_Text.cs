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

    public partial class TMP_Text(long id) : global::UnityEngine.UI.MaskableGraphic(id)
    {

        #region Implementation

        public string text 
        {
            get => internal_TMProTMP_Text__get__text(WrappedId);
            set => internal_TMProTMP_Text__set__text(WrappedId, value);
        }

        public bool isRightToLeftText 
        {
            get => internal_TMProTMP_Text__get__isRightToLeftText(WrappedId);
            set => internal_TMProTMP_Text__set__isRightToLeftText(WrappedId, value);
        }

        public global::UnityEngine.Material[] fontSharedMaterials 
        {
            get => internal_TMProTMP_Text__get__fontSharedMaterials(WrappedId);
            set => internal_TMProTMP_Text__set__fontSharedMaterials(WrappedId, value);
        }

        public global::UnityEngine.Material[] fontMaterials 
        {
            get => internal_TMProTMP_Text__get__fontMaterials(WrappedId);
            set => internal_TMProTMP_Text__set__fontMaterials(WrappedId, value);
        }

        public global::UnityEngine.Color color 
        {
            get => internal_TMProTMP_Text__get__color(WrappedId);
            set => internal_TMProTMP_Text__set__color(WrappedId, value);
        }

        public float alpha 
        {
            get => internal_TMProTMP_Text__get__alpha(WrappedId);
            set => internal_TMProTMP_Text__set__alpha(WrappedId, value);
        }

        public bool enableVertexGradient 
        {
            get => internal_TMProTMP_Text__get__enableVertexGradient(WrappedId);
            set => internal_TMProTMP_Text__set__enableVertexGradient(WrappedId, value);
        }

        public global::TMPro.VertexGradient colorGradient 
        {
            get => internal_TMProTMP_Text__get__colorGradient(WrappedId);
            set => internal_TMProTMP_Text__set__colorGradient(WrappedId, value);
        }

        public bool tintAllSprites 
        {
            get => internal_TMProTMP_Text__get__tintAllSprites(WrappedId);
            set => internal_TMProTMP_Text__set__tintAllSprites(WrappedId, value);
        }

        public global::TMPro.TMP_Style textStyle 
        {
            get => internal_TMProTMP_Text__get__textStyle(WrappedId);
            set => internal_TMProTMP_Text__set__textStyle(WrappedId, value);
        }

        public bool overrideColorTags 
        {
            get => internal_TMProTMP_Text__get__overrideColorTags(WrappedId);
            set => internal_TMProTMP_Text__set__overrideColorTags(WrappedId, value);
        }

        public global::UnityEngine.Color32 faceColor 
        {
            get => internal_TMProTMP_Text__get__faceColor(WrappedId);
            set => internal_TMProTMP_Text__set__faceColor(WrappedId, value);
        }

        public global::UnityEngine.Color32 outlineColor 
        {
            get => internal_TMProTMP_Text__get__outlineColor(WrappedId);
            set => internal_TMProTMP_Text__set__outlineColor(WrappedId, value);
        }

        public float outlineWidth 
        {
            get => internal_TMProTMP_Text__get__outlineWidth(WrappedId);
            set => internal_TMProTMP_Text__set__outlineWidth(WrappedId, value);
        }

        public float fontSize 
        {
            get => internal_TMProTMP_Text__get__fontSize(WrappedId);
            set => internal_TMProTMP_Text__set__fontSize(WrappedId, value);
        }

        public global::TMPro.FontWeight fontWeight 
        {
            get => internal_TMProTMP_Text__get__fontWeight(WrappedId);
            set => internal_TMProTMP_Text__set__fontWeight(WrappedId, value);
        }

        public float pixelsPerUnit 
        {
            get => internal_TMProTMP_Text__get__pixelsPerUnit(WrappedId);
        }

        public bool enableAutoSizing 
        {
            get => internal_TMProTMP_Text__get__enableAutoSizing(WrappedId);
            set => internal_TMProTMP_Text__set__enableAutoSizing(WrappedId, value);
        }

        public float fontSizeMin 
        {
            get => internal_TMProTMP_Text__get__fontSizeMin(WrappedId);
            set => internal_TMProTMP_Text__set__fontSizeMin(WrappedId, value);
        }

        public float fontSizeMax 
        {
            get => internal_TMProTMP_Text__get__fontSizeMax(WrappedId);
            set => internal_TMProTMP_Text__set__fontSizeMax(WrappedId, value);
        }

        public global::TMPro.FontStyles fontStyle 
        {
            get => internal_TMProTMP_Text__get__fontStyle(WrappedId);
            set => internal_TMProTMP_Text__set__fontStyle(WrappedId, value);
        }

        public bool isUsingBold 
        {
            get => internal_TMProTMP_Text__get__isUsingBold(WrappedId);
        }

        public global::TMPro.HorizontalAlignmentOptions horizontalAlignment 
        {
            get => internal_TMProTMP_Text__get__horizontalAlignment(WrappedId);
            set => internal_TMProTMP_Text__set__horizontalAlignment(WrappedId, value);
        }

        public global::TMPro.VerticalAlignmentOptions verticalAlignment 
        {
            get => internal_TMProTMP_Text__get__verticalAlignment(WrappedId);
            set => internal_TMProTMP_Text__set__verticalAlignment(WrappedId, value);
        }

        public global::TMPro.TextAlignmentOptions alignment 
        {
            get => internal_TMProTMP_Text__get__alignment(WrappedId);
            set => internal_TMProTMP_Text__set__alignment(WrappedId, value);
        }

        public float characterSpacing 
        {
            get => internal_TMProTMP_Text__get__characterSpacing(WrappedId);
            set => internal_TMProTMP_Text__set__characterSpacing(WrappedId, value);
        }

        public float wordSpacing 
        {
            get => internal_TMProTMP_Text__get__wordSpacing(WrappedId);
            set => internal_TMProTMP_Text__set__wordSpacing(WrappedId, value);
        }

        public float lineSpacing 
        {
            get => internal_TMProTMP_Text__get__lineSpacing(WrappedId);
            set => internal_TMProTMP_Text__set__lineSpacing(WrappedId, value);
        }

        public float lineSpacingAdjustment 
        {
            get => internal_TMProTMP_Text__get__lineSpacingAdjustment(WrappedId);
            set => internal_TMProTMP_Text__set__lineSpacingAdjustment(WrappedId, value);
        }

        public float paragraphSpacing 
        {
            get => internal_TMProTMP_Text__get__paragraphSpacing(WrappedId);
            set => internal_TMProTMP_Text__set__paragraphSpacing(WrappedId, value);
        }

        public float characterWidthAdjustment 
        {
            get => internal_TMProTMP_Text__get__characterWidthAdjustment(WrappedId);
            set => internal_TMProTMP_Text__set__characterWidthAdjustment(WrappedId, value);
        }

        public bool enableWordWrapping 
        {
            get => internal_TMProTMP_Text__get__enableWordWrapping(WrappedId);
            set => internal_TMProTMP_Text__set__enableWordWrapping(WrappedId, value);
        }

        public float wordWrappingRatios 
        {
            get => internal_TMProTMP_Text__get__wordWrappingRatios(WrappedId);
            set => internal_TMProTMP_Text__set__wordWrappingRatios(WrappedId, value);
        }

        public global::TMPro.TextOverflowModes overflowMode 
        {
            get => internal_TMProTMP_Text__get__overflowMode(WrappedId);
            set => internal_TMProTMP_Text__set__overflowMode(WrappedId, value);
        }

        public bool isTextOverflowing 
        {
            get => internal_TMProTMP_Text__get__isTextOverflowing(WrappedId);
        }

        public int firstOverflowCharacterIndex 
        {
            get => internal_TMProTMP_Text__get__firstOverflowCharacterIndex(WrappedId);
        }

        public global::TMPro.TMP_Text linkedTextComponent 
        {
            get => internal_TMProTMP_Text__get__linkedTextComponent(WrappedId);
            set => internal_TMProTMP_Text__set__linkedTextComponent(WrappedId, value);
        }

        public bool isTextTruncated 
        {
            get => internal_TMProTMP_Text__get__isTextTruncated(WrappedId);
        }

        public bool enableKerning 
        {
            get => internal_TMProTMP_Text__get__enableKerning(WrappedId);
            set => internal_TMProTMP_Text__set__enableKerning(WrappedId, value);
        }

        public bool extraPadding 
        {
            get => internal_TMProTMP_Text__get__extraPadding(WrappedId);
            set => internal_TMProTMP_Text__set__extraPadding(WrappedId, value);
        }

        public bool richText 
        {
            get => internal_TMProTMP_Text__get__richText(WrappedId);
            set => internal_TMProTMP_Text__set__richText(WrappedId, value);
        }

        public bool parseCtrlCharacters 
        {
            get => internal_TMProTMP_Text__get__parseCtrlCharacters(WrappedId);
            set => internal_TMProTMP_Text__set__parseCtrlCharacters(WrappedId, value);
        }

        public bool isOverlay 
        {
            get => internal_TMProTMP_Text__get__isOverlay(WrappedId);
            set => internal_TMProTMP_Text__set__isOverlay(WrappedId, value);
        }

        public bool isOrthographic 
        {
            get => internal_TMProTMP_Text__get__isOrthographic(WrappedId);
            set => internal_TMProTMP_Text__set__isOrthographic(WrappedId, value);
        }

        public bool enableCulling 
        {
            get => internal_TMProTMP_Text__get__enableCulling(WrappedId);
            set => internal_TMProTMP_Text__set__enableCulling(WrappedId, value);
        }

        public bool ignoreVisibility 
        {
            get => internal_TMProTMP_Text__get__ignoreVisibility(WrappedId);
            set => internal_TMProTMP_Text__set__ignoreVisibility(WrappedId, value);
        }

        public global::TMPro.TextureMappingOptions horizontalMapping 
        {
            get => internal_TMProTMP_Text__get__horizontalMapping(WrappedId);
            set => internal_TMProTMP_Text__set__horizontalMapping(WrappedId, value);
        }

        public global::TMPro.TextureMappingOptions verticalMapping 
        {
            get => internal_TMProTMP_Text__get__verticalMapping(WrappedId);
            set => internal_TMProTMP_Text__set__verticalMapping(WrappedId, value);
        }

        public float mappingUvLineOffset 
        {
            get => internal_TMProTMP_Text__get__mappingUvLineOffset(WrappedId);
            set => internal_TMProTMP_Text__set__mappingUvLineOffset(WrappedId, value);
        }

        public global::TMPro.TextRenderFlags renderMode 
        {
            get => internal_TMProTMP_Text__get__renderMode(WrappedId);
            set => internal_TMProTMP_Text__set__renderMode(WrappedId, value);
        }

        public global::TMPro.VertexSortingOrder geometrySortingOrder 
        {
            get => internal_TMProTMP_Text__get__geometrySortingOrder(WrappedId);
            set => internal_TMProTMP_Text__set__geometrySortingOrder(WrappedId, value);
        }

        public bool isTextObjectScaleStatic 
        {
            get => internal_TMProTMP_Text__get__isTextObjectScaleStatic(WrappedId);
            set => internal_TMProTMP_Text__set__isTextObjectScaleStatic(WrappedId, value);
        }

        public bool vertexBufferAutoSizeReduction 
        {
            get => internal_TMProTMP_Text__get__vertexBufferAutoSizeReduction(WrappedId);
            set => internal_TMProTMP_Text__set__vertexBufferAutoSizeReduction(WrappedId, value);
        }

        public int firstVisibleCharacter 
        {
            get => internal_TMProTMP_Text__get__firstVisibleCharacter(WrappedId);
            set => internal_TMProTMP_Text__set__firstVisibleCharacter(WrappedId, value);
        }

        public int maxVisibleCharacters 
        {
            get => internal_TMProTMP_Text__get__maxVisibleCharacters(WrappedId);
            set => internal_TMProTMP_Text__set__maxVisibleCharacters(WrappedId, value);
        }

        public int maxVisibleWords 
        {
            get => internal_TMProTMP_Text__get__maxVisibleWords(WrappedId);
            set => internal_TMProTMP_Text__set__maxVisibleWords(WrappedId, value);
        }

        public int maxVisibleLines 
        {
            get => internal_TMProTMP_Text__get__maxVisibleLines(WrappedId);
            set => internal_TMProTMP_Text__set__maxVisibleLines(WrappedId, value);
        }

        public bool useMaxVisibleDescender 
        {
            get => internal_TMProTMP_Text__get__useMaxVisibleDescender(WrappedId);
            set => internal_TMProTMP_Text__set__useMaxVisibleDescender(WrappedId, value);
        }

        public int pageToDisplay 
        {
            get => internal_TMProTMP_Text__get__pageToDisplay(WrappedId);
            set => internal_TMProTMP_Text__set__pageToDisplay(WrappedId, value);
        }

        public global::UnityEngine.Vector4 margin 
        {
            get => internal_TMProTMP_Text__get__margin(WrappedId);
            set => internal_TMProTMP_Text__set__margin(WrappedId, value);
        }

        public bool havePropertiesChanged 
        {
            get => internal_TMProTMP_Text__get__havePropertiesChanged(WrappedId);
            set => internal_TMProTMP_Text__set__havePropertiesChanged(WrappedId, value);
        }

        public bool isUsingLegacyAnimationComponent 
        {
            get => internal_TMProTMP_Text__get__isUsingLegacyAnimationComponent(WrappedId);
            set => internal_TMProTMP_Text__set__isUsingLegacyAnimationComponent(WrappedId, value);
        }

        public bool autoSizeTextContainer 
        {
            get => internal_TMProTMP_Text__get__autoSizeTextContainer(WrappedId);
            set => internal_TMProTMP_Text__set__autoSizeTextContainer(WrappedId, value);
        }

        public bool isVolumetricText 
        {
            get => internal_TMProTMP_Text__get__isVolumetricText(WrappedId);
            set => internal_TMProTMP_Text__set__isVolumetricText(WrappedId, value);
        }

        public global::UnityEngine.Bounds bounds 
        {
            get => internal_TMProTMP_Text__get__bounds(WrappedId);
        }

        public global::UnityEngine.Bounds textBounds 
        {
            get => internal_TMProTMP_Text__get__textBounds(WrappedId);
        }

        public float flexibleHeight 
        {
            get => internal_TMProTMP_Text__get__flexibleHeight(WrappedId);
        }

        public float flexibleWidth 
        {
            get => internal_TMProTMP_Text__get__flexibleWidth(WrappedId);
        }

        public float minWidth 
        {
            get => internal_TMProTMP_Text__get__minWidth(WrappedId);
        }

        public float minHeight 
        {
            get => internal_TMProTMP_Text__get__minHeight(WrappedId);
        }

        public float maxWidth 
        {
            get => internal_TMProTMP_Text__get__maxWidth(WrappedId);
        }

        public float maxHeight 
        {
            get => internal_TMProTMP_Text__get__maxHeight(WrappedId);
        }

        public float preferredWidth 
        {
            get => internal_TMProTMP_Text__get__preferredWidth(WrappedId);
        }

        public float preferredHeight 
        {
            get => internal_TMProTMP_Text__get__preferredHeight(WrappedId);
        }

        public float renderedWidth 
        {
            get => internal_TMProTMP_Text__get__renderedWidth(WrappedId);
        }

        public float renderedHeight 
        {
            get => internal_TMProTMP_Text__get__renderedHeight(WrappedId);
        }

        public int layoutPriority 
        {
            get => internal_TMProTMP_Text__get__layoutPriority(WrappedId);
        }

        public void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing)
        {
            internal_TMProTMP_Text__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, ignoreActiveState, forceTextReparsing);
        }

        public void UpdateGeometry(global::UnityEngine.Mesh mesh, int index)
        {
            internal_TMProTMP_Text__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(WrappedId, mesh, index);
        }

        public void UpdateVertexData(global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
            internal_TMProTMP_Text__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void UpdateVertexData()
        {
            internal_TMProTMP_Text__func__UpdateVertexData__SystemVoid(WrappedId);
        }

        public void SetVertices(global::UnityEngine.Vector3[] vertices)
        {
            internal_TMProTMP_Text__func__SetVertices__UnityEngineVector3Array__SystemVoid(WrappedId, vertices);
        }

        public void UpdateMeshPadding()
        {
            internal_TMProTMP_Text__func__UpdateMeshPadding__SystemVoid(WrappedId);
        }

        public void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
            internal_TMProTMP_Text__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, targetColor, duration, ignoreTimeScale, useAlpha);
        }

        public void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
            internal_TMProTMP_Text__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(WrappedId, alpha, duration, ignoreTimeScale);
        }

        public void SetText(string sourceText, bool syncTextInputBox)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemBoolean__SystemVoid(WrappedId, sourceText, syncTextInputBox);
        }

        public void SetText(string sourceText, float arg0)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemVoid(WrappedId, sourceText, arg0);
        }

        public void SetText(string sourceText, float arg0, float arg1)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2, arg3);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2, arg3, arg4);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2, arg3, arg4, arg5);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
        {
            internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, sourceText, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public void SetText(global::System.Text.StringBuilder sourceText)
        {
            internal_TMProTMP_Text__func__SetText__SystemTextStringBuilder__SystemVoid(WrappedId, sourceText);
        }

        public void SetText(global::System.Char[] sourceText)
        {
            internal_TMProTMP_Text__func__SetText__SystemCharArray__SystemVoid(WrappedId, sourceText);
        }

        public void SetText(global::System.Char[] sourceText, int start, int length)
        {
            internal_TMProTMP_Text__func__SetText__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(WrappedId, sourceText, start, length);
        }

        public void SetCharArray(global::System.Char[] sourceText)
        {
            internal_TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemVoid(WrappedId, sourceText);
        }

        public void SetCharArray(global::System.Char[] sourceText, int start, int length)
        {
            internal_TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(WrappedId, sourceText, start, length);
        }

        public global::UnityEngine.Vector2 GetPreferredValues()
        {
            return internal_TMProTMP_Text__func__GetPreferredValues__UnityEngineVector2(WrappedId);
        }

        public global::UnityEngine.Vector2 GetPreferredValues(float width, float height)
        {
            return internal_TMProTMP_Text__func__GetPreferredValues__SystemSingle__SystemSingle__UnityEngineVector2(WrappedId, width, height);
        }

        public global::UnityEngine.Vector2 GetPreferredValues(string text)
        {
            return internal_TMProTMP_Text__func__GetPreferredValues__SystemString__UnityEngineVector2(WrappedId, text);
        }

        public global::UnityEngine.Vector2 GetPreferredValues(string text, float width, float height)
        {
            return internal_TMProTMP_Text__func__GetPreferredValues__SystemString__SystemSingle__SystemSingle__UnityEngineVector2(WrappedId, text, width, height);
        }

        public global::UnityEngine.Vector2 GetRenderedValues()
        {
            return internal_TMProTMP_Text__func__GetRenderedValues__UnityEngineVector2(WrappedId);
        }

        public global::UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters)
        {
            return internal_TMProTMP_Text__func__GetRenderedValues__SystemBoolean__UnityEngineVector2(WrappedId, onlyVisibleCharacters);
        }

        public void ComputeMarginSize()
        {
            internal_TMProTMP_Text__func__ComputeMarginSize__SystemVoid(WrappedId);
        }

        public void ClearMesh()
        {
            internal_TMProTMP_Text__func__ClearMesh__SystemVoid(WrappedId);
        }

        public void ClearMesh(bool uploadGeometry)
        {
            internal_TMProTMP_Text__func__ClearMesh__SystemBoolean__SystemVoid(WrappedId, uploadGeometry);
        }

        public string GetParsedText()
        {
            return internal_TMProTMP_Text__func__GetParsedText__SystemString(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_TMProTMP_Text__get__text(long selfObjectId)
        {
            char* textPointer = default;
            int textWasmLength = default;
            TMProTMP_Text__get__text(selfObjectId, &textPointer, &textWasmLength);
            string returnResult = new(textPointer, 0, textWasmLength);
            Marshal.FreeHGlobal((IntPtr)textPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__text(long selfObjectId, string text)
        {
            fixed (char* textPointer = text)
            {
                TMProTMP_Text__set__text(selfObjectId, textPointer, text.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isRightToLeftText(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isRightToLeftText(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isRightToLeftText(long selfObjectId, bool isRightToLeftText)
        {
            var isRightToLeftTextConverted = Unsafe.As<bool, int>(ref isRightToLeftText);
            TMProTMP_Text__set__isRightToLeftText(selfObjectId, isRightToLeftTextConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material[] internal_TMProTMP_Text__get__fontSharedMaterials(long selfObjectId)
        {
            long* fontSharedMaterialsIdsPointer = default;
            int fontSharedMaterialsWasmLength = default;
            TMProTMP_Text__get__fontSharedMaterials(selfObjectId, &fontSharedMaterialsIdsPointer, &fontSharedMaterialsWasmLength);
            global::UnityEngine.Material[] returnResult = new global::UnityEngine.Material[fontSharedMaterialsWasmLength];
            for (int i = 0; i < fontSharedMaterialsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Material(fontSharedMaterialsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)fontSharedMaterialsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontSharedMaterials(long selfObjectId, global::UnityEngine.Material[] fontSharedMaterials)
        {
            int fontSharedMaterialsWasmLength = fontSharedMaterials.Length;
            long[] fontSharedMaterialsIds = new long[fontSharedMaterialsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < fontSharedMaterialsWasmLength; i++) fontSharedMaterialsIds[i] = (fontSharedMaterials[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* fontSharedMaterialsIdsPointer = fontSharedMaterialsIds)
            {
                TMProTMP_Text__set__fontSharedMaterials(selfObjectId, fontSharedMaterialsIdsPointer, fontSharedMaterialsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material[] internal_TMProTMP_Text__get__fontMaterials(long selfObjectId)
        {
            long* fontMaterialsIdsPointer = default;
            int fontMaterialsWasmLength = default;
            TMProTMP_Text__get__fontMaterials(selfObjectId, &fontMaterialsIdsPointer, &fontMaterialsWasmLength);
            global::UnityEngine.Material[] returnResult = new global::UnityEngine.Material[fontMaterialsWasmLength];
            for (int i = 0; i < fontMaterialsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Material(fontMaterialsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)fontMaterialsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontMaterials(long selfObjectId, global::UnityEngine.Material[] fontMaterials)
        {
            int fontMaterialsWasmLength = fontMaterials.Length;
            long[] fontMaterialsIds = new long[fontMaterialsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < fontMaterialsWasmLength; i++) fontMaterialsIds[i] = (fontMaterials[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* fontMaterialsIdsPointer = fontMaterialsIds)
            {
                TMProTMP_Text__set__fontMaterials(selfObjectId, fontMaterialsIdsPointer, fontMaterialsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_TMProTMP_Text__get__color(long selfObjectId)
        {
            global::UnityEngine.Color colorValue = default;
            TMProTMP_Text__get__color(selfObjectId, Unsafe.AsPointer(ref colorValue));
            global::UnityEngine.Color returnResult = colorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__color(long selfObjectId, global::UnityEngine.Color color)
        {
            TMProTMP_Text__set__color(selfObjectId, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__alpha(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__alpha(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__alpha(long selfObjectId, float alpha)
        {
            TMProTMP_Text__set__alpha(selfObjectId, alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__enableVertexGradient(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__enableVertexGradient(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__enableVertexGradient(long selfObjectId, bool enableVertexGradient)
        {
            var enableVertexGradientConverted = Unsafe.As<bool, int>(ref enableVertexGradient);
            TMProTMP_Text__set__enableVertexGradient(selfObjectId, enableVertexGradientConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.VertexGradient internal_TMProTMP_Text__get__colorGradient(long selfObjectId)
        {
            global::TMPro.VertexGradient colorGradientValue = default;
            TMProTMP_Text__get__colorGradient(selfObjectId, Unsafe.AsPointer(ref colorGradientValue));
            global::TMPro.VertexGradient returnResult = colorGradientValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__colorGradient(long selfObjectId, global::TMPro.VertexGradient colorGradient)
        {
            TMProTMP_Text__set__colorGradient(selfObjectId, Unsafe.AsPointer(ref colorGradient));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__tintAllSprites(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__tintAllSprites(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__tintAllSprites(long selfObjectId, bool tintAllSprites)
        {
            var tintAllSpritesConverted = Unsafe.As<bool, int>(ref tintAllSprites);
            TMProTMP_Text__set__tintAllSprites(selfObjectId, tintAllSpritesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TMP_Style internal_TMProTMP_Text__get__textStyle(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__textStyle(selfObjectId);
            var returnResult = new global::TMPro.TMP_Style(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__textStyle(long selfObjectId, global::TMPro.TMP_Style textStyle)
        {
            TMProTMP_Text__set__textStyle(selfObjectId, textStyle.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__overrideColorTags(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__overrideColorTags(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__overrideColorTags(long selfObjectId, bool overrideColorTags)
        {
            var overrideColorTagsConverted = Unsafe.As<bool, int>(ref overrideColorTags);
            TMProTMP_Text__set__overrideColorTags(selfObjectId, overrideColorTagsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32 internal_TMProTMP_Text__get__faceColor(long selfObjectId)
        {
            global::UnityEngine.Color32 faceColorValue = default;
            TMProTMP_Text__get__faceColor(selfObjectId, Unsafe.AsPointer(ref faceColorValue));
            global::UnityEngine.Color32 returnResult = faceColorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__faceColor(long selfObjectId, global::UnityEngine.Color32 faceColor)
        {
            TMProTMP_Text__set__faceColor(selfObjectId, Unsafe.AsPointer(ref faceColor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32 internal_TMProTMP_Text__get__outlineColor(long selfObjectId)
        {
            global::UnityEngine.Color32 outlineColorValue = default;
            TMProTMP_Text__get__outlineColor(selfObjectId, Unsafe.AsPointer(ref outlineColorValue));
            global::UnityEngine.Color32 returnResult = outlineColorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__outlineColor(long selfObjectId, global::UnityEngine.Color32 outlineColor)
        {
            TMProTMP_Text__set__outlineColor(selfObjectId, Unsafe.AsPointer(ref outlineColor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__outlineWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__outlineWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__outlineWidth(long selfObjectId, float outlineWidth)
        {
            TMProTMP_Text__set__outlineWidth(selfObjectId, outlineWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__fontSize(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__fontSize(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontSize(long selfObjectId, float fontSize)
        {
            TMProTMP_Text__set__fontSize(selfObjectId, fontSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.FontWeight internal_TMProTMP_Text__get__fontWeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__fontWeight(selfObjectId);
            var returnResult = (global::TMPro.FontWeight)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontWeight(long selfObjectId, global::TMPro.FontWeight fontWeight)
        {
            TMProTMP_Text__set__fontWeight(selfObjectId, (int) fontWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__pixelsPerUnit(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__pixelsPerUnit(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__enableAutoSizing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__enableAutoSizing(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__enableAutoSizing(long selfObjectId, bool enableAutoSizing)
        {
            var enableAutoSizingConverted = Unsafe.As<bool, int>(ref enableAutoSizing);
            TMProTMP_Text__set__enableAutoSizing(selfObjectId, enableAutoSizingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__fontSizeMin(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__fontSizeMin(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontSizeMin(long selfObjectId, float fontSizeMin)
        {
            TMProTMP_Text__set__fontSizeMin(selfObjectId, fontSizeMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__fontSizeMax(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__fontSizeMax(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontSizeMax(long selfObjectId, float fontSizeMax)
        {
            TMProTMP_Text__set__fontSizeMax(selfObjectId, fontSizeMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.FontStyles internal_TMProTMP_Text__get__fontStyle(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__fontStyle(selfObjectId);
            var returnResult = (global::TMPro.FontStyles)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__fontStyle(long selfObjectId, global::TMPro.FontStyles fontStyle)
        {
            TMProTMP_Text__set__fontStyle(selfObjectId, (int) fontStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isUsingBold(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isUsingBold(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.HorizontalAlignmentOptions internal_TMProTMP_Text__get__horizontalAlignment(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__horizontalAlignment(selfObjectId);
            var returnResult = (global::TMPro.HorizontalAlignmentOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__horizontalAlignment(long selfObjectId, global::TMPro.HorizontalAlignmentOptions horizontalAlignment)
        {
            TMProTMP_Text__set__horizontalAlignment(selfObjectId, (int) horizontalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.VerticalAlignmentOptions internal_TMProTMP_Text__get__verticalAlignment(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__verticalAlignment(selfObjectId);
            var returnResult = (global::TMPro.VerticalAlignmentOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__verticalAlignment(long selfObjectId, global::TMPro.VerticalAlignmentOptions verticalAlignment)
        {
            TMProTMP_Text__set__verticalAlignment(selfObjectId, (int) verticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TextAlignmentOptions internal_TMProTMP_Text__get__alignment(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__alignment(selfObjectId);
            var returnResult = (global::TMPro.TextAlignmentOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__alignment(long selfObjectId, global::TMPro.TextAlignmentOptions alignment)
        {
            TMProTMP_Text__set__alignment(selfObjectId, (int) alignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__characterSpacing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__characterSpacing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__characterSpacing(long selfObjectId, float characterSpacing)
        {
            TMProTMP_Text__set__characterSpacing(selfObjectId, characterSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__wordSpacing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__wordSpacing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__wordSpacing(long selfObjectId, float wordSpacing)
        {
            TMProTMP_Text__set__wordSpacing(selfObjectId, wordSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__lineSpacing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__lineSpacing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__lineSpacing(long selfObjectId, float lineSpacing)
        {
            TMProTMP_Text__set__lineSpacing(selfObjectId, lineSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__lineSpacingAdjustment(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__lineSpacingAdjustment(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__lineSpacingAdjustment(long selfObjectId, float lineSpacingAdjustment)
        {
            TMProTMP_Text__set__lineSpacingAdjustment(selfObjectId, lineSpacingAdjustment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__paragraphSpacing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__paragraphSpacing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__paragraphSpacing(long selfObjectId, float paragraphSpacing)
        {
            TMProTMP_Text__set__paragraphSpacing(selfObjectId, paragraphSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__characterWidthAdjustment(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__characterWidthAdjustment(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__characterWidthAdjustment(long selfObjectId, float characterWidthAdjustment)
        {
            TMProTMP_Text__set__characterWidthAdjustment(selfObjectId, characterWidthAdjustment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__enableWordWrapping(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__enableWordWrapping(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__enableWordWrapping(long selfObjectId, bool enableWordWrapping)
        {
            var enableWordWrappingConverted = Unsafe.As<bool, int>(ref enableWordWrapping);
            TMProTMP_Text__set__enableWordWrapping(selfObjectId, enableWordWrappingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__wordWrappingRatios(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__wordWrappingRatios(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__wordWrappingRatios(long selfObjectId, float wordWrappingRatios)
        {
            TMProTMP_Text__set__wordWrappingRatios(selfObjectId, wordWrappingRatios);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TextOverflowModes internal_TMProTMP_Text__get__overflowMode(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__overflowMode(selfObjectId);
            var returnResult = (global::TMPro.TextOverflowModes)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__overflowMode(long selfObjectId, global::TMPro.TextOverflowModes overflowMode)
        {
            TMProTMP_Text__set__overflowMode(selfObjectId, (int) overflowMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isTextOverflowing(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isTextOverflowing(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__firstOverflowCharacterIndex(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__firstOverflowCharacterIndex(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TMP_Text internal_TMProTMP_Text__get__linkedTextComponent(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__linkedTextComponent(selfObjectId);
            var returnResult = new global::TMPro.TMP_Text(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__linkedTextComponent(long selfObjectId, global::TMPro.TMP_Text linkedTextComponent)
        {
            TMProTMP_Text__set__linkedTextComponent(selfObjectId, linkedTextComponent.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isTextTruncated(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isTextTruncated(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__enableKerning(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__enableKerning(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__enableKerning(long selfObjectId, bool enableKerning)
        {
            var enableKerningConverted = Unsafe.As<bool, int>(ref enableKerning);
            TMProTMP_Text__set__enableKerning(selfObjectId, enableKerningConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__extraPadding(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__extraPadding(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__extraPadding(long selfObjectId, bool extraPadding)
        {
            var extraPaddingConverted = Unsafe.As<bool, int>(ref extraPadding);
            TMProTMP_Text__set__extraPadding(selfObjectId, extraPaddingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__richText(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__richText(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__richText(long selfObjectId, bool richText)
        {
            var richTextConverted = Unsafe.As<bool, int>(ref richText);
            TMProTMP_Text__set__richText(selfObjectId, richTextConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__parseCtrlCharacters(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__parseCtrlCharacters(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__parseCtrlCharacters(long selfObjectId, bool parseCtrlCharacters)
        {
            var parseCtrlCharactersConverted = Unsafe.As<bool, int>(ref parseCtrlCharacters);
            TMProTMP_Text__set__parseCtrlCharacters(selfObjectId, parseCtrlCharactersConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isOverlay(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isOverlay(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isOverlay(long selfObjectId, bool isOverlay)
        {
            var isOverlayConverted = Unsafe.As<bool, int>(ref isOverlay);
            TMProTMP_Text__set__isOverlay(selfObjectId, isOverlayConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isOrthographic(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isOrthographic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isOrthographic(long selfObjectId, bool isOrthographic)
        {
            var isOrthographicConverted = Unsafe.As<bool, int>(ref isOrthographic);
            TMProTMP_Text__set__isOrthographic(selfObjectId, isOrthographicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__enableCulling(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__enableCulling(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__enableCulling(long selfObjectId, bool enableCulling)
        {
            var enableCullingConverted = Unsafe.As<bool, int>(ref enableCulling);
            TMProTMP_Text__set__enableCulling(selfObjectId, enableCullingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__ignoreVisibility(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__ignoreVisibility(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__ignoreVisibility(long selfObjectId, bool ignoreVisibility)
        {
            var ignoreVisibilityConverted = Unsafe.As<bool, int>(ref ignoreVisibility);
            TMProTMP_Text__set__ignoreVisibility(selfObjectId, ignoreVisibilityConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TextureMappingOptions internal_TMProTMP_Text__get__horizontalMapping(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__horizontalMapping(selfObjectId);
            var returnResult = (global::TMPro.TextureMappingOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__horizontalMapping(long selfObjectId, global::TMPro.TextureMappingOptions horizontalMapping)
        {
            TMProTMP_Text__set__horizontalMapping(selfObjectId, (int) horizontalMapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TextureMappingOptions internal_TMProTMP_Text__get__verticalMapping(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__verticalMapping(selfObjectId);
            var returnResult = (global::TMPro.TextureMappingOptions)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__verticalMapping(long selfObjectId, global::TMPro.TextureMappingOptions verticalMapping)
        {
            TMProTMP_Text__set__verticalMapping(selfObjectId, (int) verticalMapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__mappingUvLineOffset(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__mappingUvLineOffset(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__mappingUvLineOffset(long selfObjectId, float mappingUvLineOffset)
        {
            TMProTMP_Text__set__mappingUvLineOffset(selfObjectId, mappingUvLineOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.TextRenderFlags internal_TMProTMP_Text__get__renderMode(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__renderMode(selfObjectId);
            var returnResult = (global::TMPro.TextRenderFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__renderMode(long selfObjectId, global::TMPro.TextRenderFlags renderMode)
        {
            TMProTMP_Text__set__renderMode(selfObjectId, (int) renderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::TMPro.VertexSortingOrder internal_TMProTMP_Text__get__geometrySortingOrder(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__geometrySortingOrder(selfObjectId);
            var returnResult = (global::TMPro.VertexSortingOrder)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__geometrySortingOrder(long selfObjectId, global::TMPro.VertexSortingOrder geometrySortingOrder)
        {
            TMProTMP_Text__set__geometrySortingOrder(selfObjectId, (int) geometrySortingOrder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isTextObjectScaleStatic(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isTextObjectScaleStatic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isTextObjectScaleStatic(long selfObjectId, bool isTextObjectScaleStatic)
        {
            var isTextObjectScaleStaticConverted = Unsafe.As<bool, int>(ref isTextObjectScaleStatic);
            TMProTMP_Text__set__isTextObjectScaleStatic(selfObjectId, isTextObjectScaleStaticConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__vertexBufferAutoSizeReduction(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__vertexBufferAutoSizeReduction(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__vertexBufferAutoSizeReduction(long selfObjectId, bool vertexBufferAutoSizeReduction)
        {
            var vertexBufferAutoSizeReductionConverted = Unsafe.As<bool, int>(ref vertexBufferAutoSizeReduction);
            TMProTMP_Text__set__vertexBufferAutoSizeReduction(selfObjectId, vertexBufferAutoSizeReductionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__firstVisibleCharacter(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__firstVisibleCharacter(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__firstVisibleCharacter(long selfObjectId, int firstVisibleCharacter)
        {
            TMProTMP_Text__set__firstVisibleCharacter(selfObjectId, firstVisibleCharacter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__maxVisibleCharacters(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__maxVisibleCharacters(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__maxVisibleCharacters(long selfObjectId, int maxVisibleCharacters)
        {
            TMProTMP_Text__set__maxVisibleCharacters(selfObjectId, maxVisibleCharacters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__maxVisibleWords(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__maxVisibleWords(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__maxVisibleWords(long selfObjectId, int maxVisibleWords)
        {
            TMProTMP_Text__set__maxVisibleWords(selfObjectId, maxVisibleWords);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__maxVisibleLines(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__maxVisibleLines(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__maxVisibleLines(long selfObjectId, int maxVisibleLines)
        {
            TMProTMP_Text__set__maxVisibleLines(selfObjectId, maxVisibleLines);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__useMaxVisibleDescender(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__useMaxVisibleDescender(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__useMaxVisibleDescender(long selfObjectId, bool useMaxVisibleDescender)
        {
            var useMaxVisibleDescenderConverted = Unsafe.As<bool, int>(ref useMaxVisibleDescender);
            TMProTMP_Text__set__useMaxVisibleDescender(selfObjectId, useMaxVisibleDescenderConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__pageToDisplay(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__pageToDisplay(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__pageToDisplay(long selfObjectId, int pageToDisplay)
        {
            TMProTMP_Text__set__pageToDisplay(selfObjectId, pageToDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_TMProTMP_Text__get__margin(long selfObjectId)
        {
            global::UnityEngine.Vector4 marginValue = default;
            TMProTMP_Text__get__margin(selfObjectId, Unsafe.AsPointer(ref marginValue));
            global::UnityEngine.Vector4 returnResult = marginValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__margin(long selfObjectId, global::UnityEngine.Vector4 margin)
        {
            TMProTMP_Text__set__margin(selfObjectId, Unsafe.AsPointer(ref margin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__havePropertiesChanged(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__havePropertiesChanged(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__havePropertiesChanged(long selfObjectId, bool havePropertiesChanged)
        {
            var havePropertiesChangedConverted = Unsafe.As<bool, int>(ref havePropertiesChanged);
            TMProTMP_Text__set__havePropertiesChanged(selfObjectId, havePropertiesChangedConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isUsingLegacyAnimationComponent(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isUsingLegacyAnimationComponent(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isUsingLegacyAnimationComponent(long selfObjectId, bool isUsingLegacyAnimationComponent)
        {
            var isUsingLegacyAnimationComponentConverted = Unsafe.As<bool, int>(ref isUsingLegacyAnimationComponent);
            TMProTMP_Text__set__isUsingLegacyAnimationComponent(selfObjectId, isUsingLegacyAnimationComponentConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__autoSizeTextContainer(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__autoSizeTextContainer(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__autoSizeTextContainer(long selfObjectId, bool autoSizeTextContainer)
        {
            var autoSizeTextContainerConverted = Unsafe.As<bool, int>(ref autoSizeTextContainer);
            TMProTMP_Text__set__autoSizeTextContainer(selfObjectId, autoSizeTextContainerConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_TMProTMP_Text__get__isVolumetricText(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__isVolumetricText(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__set__isVolumetricText(long selfObjectId, bool isVolumetricText)
        {
            var isVolumetricTextConverted = Unsafe.As<bool, int>(ref isVolumetricText);
            TMProTMP_Text__set__isVolumetricText(selfObjectId, isVolumetricTextConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_TMProTMP_Text__get__bounds(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsValue = default;
            TMProTMP_Text__get__bounds(selfObjectId, Unsafe.AsPointer(ref boundsValue));
            global::UnityEngine.Bounds returnResult = boundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_TMProTMP_Text__get__textBounds(long selfObjectId)
        {
            global::UnityEngine.Bounds textBoundsValue = default;
            TMProTMP_Text__get__textBounds(selfObjectId, Unsafe.AsPointer(ref textBoundsValue));
            global::UnityEngine.Bounds returnResult = textBoundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__flexibleHeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__flexibleHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__flexibleWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__flexibleWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__minWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__minWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__minHeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__minHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__maxWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__maxWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__maxHeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__maxHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__preferredWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__preferredWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__preferredHeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__preferredHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__renderedWidth(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__renderedWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_TMProTMP_Text__get__renderedHeight(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__renderedHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_TMProTMP_Text__get__layoutPriority(long selfObjectId)
        {
            var methodCallResult = TMProTMP_Text__get__layoutPriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, bool ignoreActiveState, bool forceTextReparsing)
        {
            var ignoreActiveStateConverted = Unsafe.As<bool, int>(ref ignoreActiveState);
            var forceTextReparsingConverted = Unsafe.As<bool, int>(ref forceTextReparsing);
            TMProTMP_Text__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, ignoreActiveStateConverted, forceTextReparsingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int index)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::UnityEngine.Mesh is not implemented yet! We need to find a way to pass non-wrapped instances...");
            TMProTMP_Text__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(long selfObjectId, global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
            TMProTMP_Text__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__UpdateVertexData__SystemVoid(long selfObjectId)
        {
            TMProTMP_Text__func__UpdateVertexData__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetVertices__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] vertices)
        {
            fixed (global::UnityEngine.Vector3* verticesPointer = vertices)
            {
                TMProTMP_Text__func__SetVertices__UnityEngineVector3Array__SystemVoid(selfObjectId, verticesPointer, vertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__UpdateMeshPadding__SystemVoid(long selfObjectId)
        {
            TMProTMP_Text__func__UpdateMeshPadding__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
            var ignoreTimeScaleConverted = Unsafe.As<bool, int>(ref ignoreTimeScale);
            var useAlphaConverted = Unsafe.As<bool, int>(ref useAlpha);
            TMProTMP_Text__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref targetColor), duration, ignoreTimeScaleConverted, useAlphaConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, float alpha, float duration, bool ignoreTimeScale)
        {
            var ignoreTimeScaleConverted = Unsafe.As<bool, int>(ref ignoreTimeScale);
            TMProTMP_Text__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(selfObjectId, alpha, duration, ignoreTimeScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemBoolean__SystemVoid(long selfObjectId, string sourceText, bool syncTextInputBox)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                var syncTextInputBoxConverted = Unsafe.As<bool, int>(ref syncTextInputBox);
                TMProTMP_Text__func__SetText__SystemString__SystemBoolean__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), syncTextInputBoxConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2, float arg3)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2, arg3);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2, arg3, arg4);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2, arg3, arg4, arg5);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length * sizeof(char), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemTextStringBuilder__SystemVoid(long selfObjectId, global::System.Text.StringBuilder sourceText)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Text.StringBuilder is not implemented yet! We need to find a way to pass non-wrapped instances...");
            TMProTMP_Text__func__SetText__SystemTextStringBuilder__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemCharArray__SystemVoid(long selfObjectId, global::System.Char[] sourceText)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemCharArray__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetText__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Char[] sourceText, int start, int length)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetText__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemVoid(long selfObjectId, global::System.Char[] sourceText)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Char[] sourceText, int start, int length)
        {
            fixed (char* sourceTextPointer = sourceText)
            {
                TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(selfObjectId, sourceTextPointer, sourceText.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetPreferredValues__UnityEngineVector2(long selfObjectId)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            TMProTMP_Text__func__GetPreferredValues__UnityEngineVector2(selfObjectId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetPreferredValues__SystemSingle__SystemSingle__UnityEngineVector2(long selfObjectId, float width, float height)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            TMProTMP_Text__func__GetPreferredValues__SystemSingle__SystemSingle__UnityEngineVector2(selfObjectId, width, height, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetPreferredValues__SystemString__UnityEngineVector2(long selfObjectId, string text)
        {
            fixed (char* textPointer = text)
            {
                global::UnityEngine.Vector2 returnResultValue = default;
                TMProTMP_Text__func__GetPreferredValues__SystemString__UnityEngineVector2(selfObjectId, textPointer, text.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector2 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetPreferredValues__SystemString__SystemSingle__SystemSingle__UnityEngineVector2(long selfObjectId, string text, float width, float height)
        {
            fixed (char* textPointer = text)
            {
                global::UnityEngine.Vector2 returnResultValue = default;
                TMProTMP_Text__func__GetPreferredValues__SystemString__SystemSingle__SystemSingle__UnityEngineVector2(selfObjectId, textPointer, text.Length * sizeof(char), width, height, Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector2 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetRenderedValues__UnityEngineVector2(long selfObjectId)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            TMProTMP_Text__func__GetRenderedValues__UnityEngineVector2(selfObjectId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_TMProTMP_Text__func__GetRenderedValues__SystemBoolean__UnityEngineVector2(long selfObjectId, bool onlyVisibleCharacters)
        {
            var onlyVisibleCharactersConverted = Unsafe.As<bool, int>(ref onlyVisibleCharacters);
            global::UnityEngine.Vector2 returnResultValue = default;
            TMProTMP_Text__func__GetRenderedValues__SystemBoolean__UnityEngineVector2(selfObjectId, onlyVisibleCharactersConverted, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__ComputeMarginSize__SystemVoid(long selfObjectId)
        {
            TMProTMP_Text__func__ComputeMarginSize__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__ClearMesh__SystemVoid(long selfObjectId)
        {
            TMProTMP_Text__func__ClearMesh__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_TMProTMP_Text__func__ClearMesh__SystemBoolean__SystemVoid(long selfObjectId, bool uploadGeometry)
        {
            var uploadGeometryConverted = Unsafe.As<bool, int>(ref uploadGeometry);
            TMProTMP_Text__func__ClearMesh__SystemBoolean__SystemVoid(selfObjectId, uploadGeometryConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_TMProTMP_Text__func__GetParsedText__SystemString(long selfObjectId)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            TMProTMP_Text__func__GetParsedText__SystemString(selfObjectId, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__text(long selfObjectId, void* textPointer, void* textWasmLengthsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__text(long selfObjectId, void* textPointer, int textWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isRightToLeftText(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isRightToLeftText(long selfObjectId, int isRightToLeftTextConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__fontSharedMaterials(long selfObjectId, void* fontSharedMaterialsIdsPointer, void* fontSharedMaterialsWasmLengthPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__fontSharedMaterials(long selfObjectId, void* fontSharedMaterialsIdsPointer, int fontSharedMaterialsWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__fontMaterials(long selfObjectId, void* fontMaterialsIdsPointer, void* fontMaterialsWasmLengthPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__fontMaterials(long selfObjectId, void* fontMaterialsIdsPointer, int fontMaterialsWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__alpha(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__alpha(long selfObjectId, float alpha);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__enableVertexGradient(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__enableVertexGradient(long selfObjectId, int enableVertexGradientConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__colorGradient(long selfObjectId, void* colorGradientPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__colorGradient(long selfObjectId, void* colorGradientPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__tintAllSprites(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__tintAllSprites(long selfObjectId, int tintAllSpritesConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern long TMProTMP_Text__get__textStyle(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__textStyle(long selfObjectId, long textStyleObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__overrideColorTags(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__overrideColorTags(long selfObjectId, int overrideColorTagsConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__faceColor(long selfObjectId, void* faceColorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__faceColor(long selfObjectId, void* faceColorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__outlineColor(long selfObjectId, void* outlineColorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__outlineColor(long selfObjectId, void* outlineColorPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__outlineWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__outlineWidth(long selfObjectId, float outlineWidth);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__fontSize(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__fontSize(long selfObjectId, float fontSize);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__fontWeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__fontWeight(long selfObjectId, int fontWeightUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__pixelsPerUnit(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__enableAutoSizing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__enableAutoSizing(long selfObjectId, int enableAutoSizingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__fontSizeMin(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__fontSizeMin(long selfObjectId, float fontSizeMin);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__fontSizeMax(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__fontSizeMax(long selfObjectId, float fontSizeMax);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__fontStyle(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__fontStyle(long selfObjectId, int fontStyleUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isUsingBold(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__horizontalAlignment(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__horizontalAlignment(long selfObjectId, int horizontalAlignmentUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__verticalAlignment(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__verticalAlignment(long selfObjectId, int verticalAlignmentUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__alignment(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__alignment(long selfObjectId, int alignmentUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__characterSpacing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__characterSpacing(long selfObjectId, float characterSpacing);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__wordSpacing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__wordSpacing(long selfObjectId, float wordSpacing);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__lineSpacing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__lineSpacing(long selfObjectId, float lineSpacing);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__lineSpacingAdjustment(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__lineSpacingAdjustment(long selfObjectId, float lineSpacingAdjustment);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__paragraphSpacing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__paragraphSpacing(long selfObjectId, float paragraphSpacing);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__characterWidthAdjustment(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__characterWidthAdjustment(long selfObjectId, float characterWidthAdjustment);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__enableWordWrapping(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__enableWordWrapping(long selfObjectId, int enableWordWrappingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__wordWrappingRatios(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__wordWrappingRatios(long selfObjectId, float wordWrappingRatios);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__overflowMode(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__overflowMode(long selfObjectId, int overflowModeUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isTextOverflowing(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__firstOverflowCharacterIndex(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern long TMProTMP_Text__get__linkedTextComponent(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__linkedTextComponent(long selfObjectId, long linkedTextComponentObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isTextTruncated(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__enableKerning(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__enableKerning(long selfObjectId, int enableKerningConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__extraPadding(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__extraPadding(long selfObjectId, int extraPaddingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__richText(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__richText(long selfObjectId, int richTextConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__parseCtrlCharacters(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__parseCtrlCharacters(long selfObjectId, int parseCtrlCharactersConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isOverlay(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isOverlay(long selfObjectId, int isOverlayConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isOrthographic(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isOrthographic(long selfObjectId, int isOrthographicConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__enableCulling(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__enableCulling(long selfObjectId, int enableCullingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__ignoreVisibility(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__ignoreVisibility(long selfObjectId, int ignoreVisibilityConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__horizontalMapping(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__horizontalMapping(long selfObjectId, int horizontalMappingUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__verticalMapping(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__verticalMapping(long selfObjectId, int verticalMappingUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__mappingUvLineOffset(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__mappingUvLineOffset(long selfObjectId, float mappingUvLineOffset);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__renderMode(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__renderMode(long selfObjectId, int renderModeUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__geometrySortingOrder(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__geometrySortingOrder(long selfObjectId, int geometrySortingOrderUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isTextObjectScaleStatic(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isTextObjectScaleStatic(long selfObjectId, int isTextObjectScaleStaticConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__vertexBufferAutoSizeReduction(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__vertexBufferAutoSizeReduction(long selfObjectId, int vertexBufferAutoSizeReductionConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__firstVisibleCharacter(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__firstVisibleCharacter(long selfObjectId, int firstVisibleCharacter);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__maxVisibleCharacters(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__maxVisibleCharacters(long selfObjectId, int maxVisibleCharacters);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__maxVisibleWords(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__maxVisibleWords(long selfObjectId, int maxVisibleWords);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__maxVisibleLines(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__maxVisibleLines(long selfObjectId, int maxVisibleLines);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__useMaxVisibleDescender(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__useMaxVisibleDescender(long selfObjectId, int useMaxVisibleDescenderConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__pageToDisplay(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__pageToDisplay(long selfObjectId, int pageToDisplay);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__margin(long selfObjectId, void* marginPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__set__margin(long selfObjectId, void* marginPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__havePropertiesChanged(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__havePropertiesChanged(long selfObjectId, int havePropertiesChangedConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isUsingLegacyAnimationComponent(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isUsingLegacyAnimationComponent(long selfObjectId, int isUsingLegacyAnimationComponentConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__autoSizeTextContainer(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__autoSizeTextContainer(long selfObjectId, int autoSizeTextContainerConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__isVolumetricText(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__set__isVolumetricText(long selfObjectId, int isVolumetricTextConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__get__textBounds(long selfObjectId, void* textBoundsPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__flexibleHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__flexibleWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__minWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__minHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__maxWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__maxHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__preferredWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__preferredHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__renderedWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern float TMProTMP_Text__get__renderedHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern int TMProTMP_Text__get__layoutPriority(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__ForceMeshUpdate__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int ignoreActiveStateConverted, int forceTextReparsingConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__UpdateGeometry__UnityEngineMesh__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, int index);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__UpdateVertexData__TMProTMP_VertexDataUpdateFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__UpdateVertexData__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetVertices__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* verticesPointer, int verticesWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__UpdateMeshPadding__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, void* targetColorPointer, float duration, int ignoreTimeScaleConverted, int useAlphaConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, float alpha, float duration, int ignoreTimeScaleConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemBoolean__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, int syncTextInputBoxConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2, float arg3);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2, float arg3, float arg4);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__SetText__SystemTextStringBuilder__SystemVoid(long selfObjectId, long sourceTextObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemCharArray__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetText__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__SetCharArray__SystemCharArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourceTextPointer, int sourceTextWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetPreferredValues__UnityEngineVector2(long selfObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetPreferredValues__SystemSingle__SystemSingle__UnityEngineVector2(long selfObjectId, float width, float height, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetPreferredValues__SystemString__UnityEngineVector2(long selfObjectId, void* textPointer, int textWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetPreferredValues__SystemString__SystemSingle__SystemSingle__UnityEngineVector2(long selfObjectId, void* textPointer, int textWasmLength, float width, float height, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetRenderedValues__UnityEngineVector2(long selfObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetRenderedValues__SystemBoolean__UnityEngineVector2(long selfObjectId, int onlyVisibleCharactersConverted, void* returnResultPointer);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__ComputeMarginSize__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__ClearMesh__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern void TMProTMP_Text__func__ClearMesh__SystemBoolean__SystemVoid(long selfObjectId, int uploadGeometryConverted);

        [WasmImportLinkage, DllImport("TMPro")]
        private static extern unsafe void TMProTMP_Text__func__GetParsedText__SystemString(long selfObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        #endregion Imports
    }
}
