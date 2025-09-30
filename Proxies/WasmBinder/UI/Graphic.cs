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

    public partial class Graphic(long id) : global::UnityEngine.EventSystems.UIBehaviour(id)
    {

        #region Implementation

        public static global::UnityEngine.Material defaultGraphicMaterial 
        {
            get => internal_UnityEngineUIGraphic__get__defaultGraphicMaterial();
        }

        public global::UnityEngine.Color color 
        {
            get => internal_UnityEngineUIGraphic__get__color(WrappedId);
            set => internal_UnityEngineUIGraphic__set__color(WrappedId, value);
        }

        public bool raycastTarget 
        {
            get => internal_UnityEngineUIGraphic__get__raycastTarget(WrappedId);
            set => internal_UnityEngineUIGraphic__set__raycastTarget(WrappedId, value);
        }

        public global::UnityEngine.Vector4 raycastPadding 
        {
            get => internal_UnityEngineUIGraphic__get__raycastPadding(WrappedId);
            set => internal_UnityEngineUIGraphic__set__raycastPadding(WrappedId, value);
        }

        public int depth 
        {
            get => internal_UnityEngineUIGraphic__get__depth(WrappedId);
        }

        public global::UnityEngine.RectTransform rectTransform 
        {
            get => internal_UnityEngineUIGraphic__get__rectTransform(WrappedId);
        }

        public global::UnityEngine.Material defaultMaterial 
        {
            get => internal_UnityEngineUIGraphic__get__defaultMaterial(WrappedId);
        }

        public global::UnityEngine.Material material 
        {
            get => internal_UnityEngineUIGraphic__get__material(WrappedId);
            set => internal_UnityEngineUIGraphic__set__material(WrappedId, value);
        }

        public global::UnityEngine.Material materialForRendering 
        {
            get => internal_UnityEngineUIGraphic__get__materialForRendering(WrappedId);
        }

        public global::UnityEngine.Texture mainTexture 
        {
            get => internal_UnityEngineUIGraphic__get__mainTexture(WrappedId);
        }

        public void SetAllDirty()
        {
            internal_UnityEngineUIGraphic__func__SetAllDirty__SystemVoid(WrappedId);
        }

        public void SetLayoutDirty()
        {
            internal_UnityEngineUIGraphic__func__SetLayoutDirty__SystemVoid(WrappedId);
        }

        public void SetVerticesDirty()
        {
            internal_UnityEngineUIGraphic__func__SetVerticesDirty__SystemVoid(WrappedId);
        }

        public void SetMaterialDirty()
        {
            internal_UnityEngineUIGraphic__func__SetMaterialDirty__SystemVoid(WrappedId);
        }

        public void SetRaycastDirty()
        {
            internal_UnityEngineUIGraphic__func__SetRaycastDirty__SystemVoid(WrappedId);
        }

        public void OnCullingChanged()
        {
            internal_UnityEngineUIGraphic__func__OnCullingChanged__SystemVoid(WrappedId);
        }

        public void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
            internal_UnityEngineUIGraphic__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(WrappedId, update);
        }

        public void LayoutComplete()
        {
            internal_UnityEngineUIGraphic__func__LayoutComplete__SystemVoid(WrappedId);
        }

        public void GraphicUpdateComplete()
        {
            internal_UnityEngineUIGraphic__func__GraphicUpdateComplete__SystemVoid(WrappedId);
        }

        public void SetNativeSize()
        {
            internal_UnityEngineUIGraphic__func__SetNativeSize__SystemVoid(WrappedId);
        }

        public bool Raycast(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return internal_UnityEngineUIGraphic__func__Raycast__UnityEngineVector2__UnityEngineCamera__SystemBoolean(WrappedId, sp, eventCamera);
        }

        public global::UnityEngine.Vector2 PixelAdjustPoint(global::UnityEngine.Vector2 point)
        {
            return internal_UnityEngineUIGraphic__func__PixelAdjustPoint__UnityEngineVector2__UnityEngineVector2(WrappedId, point);
        }

        public global::UnityEngine.Rect GetPixelAdjustedRect()
        {
            return internal_UnityEngineUIGraphic__func__GetPixelAdjustedRect__UnityEngineRect(WrappedId);
        }

        public void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
            internal_UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, targetColor, duration, ignoreTimeScale, useAlpha);
        }

        public void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
        {
            internal_UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
        }

        public void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
            internal_UnityEngineUIGraphic__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(WrappedId, alpha, duration, ignoreTimeScale);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineUIGraphic__get__defaultGraphicMaterial()
        {
            var methodCallResult = UnityEngineUIGraphic__get__defaultGraphicMaterial();
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineUIGraphic__get__color(long selfObjectId)
        {
            global::UnityEngine.Color colorValue = default;
            UnityEngineUIGraphic__get__color(selfObjectId, Unsafe.AsPointer(ref colorValue));
            global::UnityEngine.Color returnResult = colorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__set__color(long selfObjectId, global::UnityEngine.Color color)
        {
            UnityEngineUIGraphic__set__color(selfObjectId, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineUIGraphic__get__raycastTarget(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__raycastTarget(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__set__raycastTarget(long selfObjectId, bool raycastTarget)
        {
            var raycastTargetConverted = Unsafe.As<bool, int>(ref raycastTarget);
            UnityEngineUIGraphic__set__raycastTarget(selfObjectId, raycastTargetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineUIGraphic__get__raycastPadding(long selfObjectId)
        {
            global::UnityEngine.Vector4 raycastPaddingValue = default;
            UnityEngineUIGraphic__get__raycastPadding(selfObjectId, Unsafe.AsPointer(ref raycastPaddingValue));
            global::UnityEngine.Vector4 returnResult = raycastPaddingValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__set__raycastPadding(long selfObjectId, global::UnityEngine.Vector4 raycastPadding)
        {
            UnityEngineUIGraphic__set__raycastPadding(selfObjectId, Unsafe.AsPointer(ref raycastPadding));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineUIGraphic__get__depth(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__depth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RectTransform internal_UnityEngineUIGraphic__get__rectTransform(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__rectTransform(selfObjectId);
            var returnResult = new global::UnityEngine.RectTransform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineUIGraphic__get__defaultMaterial(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__defaultMaterial(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineUIGraphic__get__material(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__material(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__set__material(long selfObjectId, global::UnityEngine.Material material)
        {
            UnityEngineUIGraphic__set__material(selfObjectId, material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Material internal_UnityEngineUIGraphic__get__materialForRendering(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__materialForRendering(selfObjectId);
            var returnResult = new global::UnityEngine.Material(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineUIGraphic__get__mainTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineUIGraphic__get__mainTexture(selfObjectId);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetAllDirty__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetAllDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetLayoutDirty__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetLayoutDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetVerticesDirty__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetVerticesDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetMaterialDirty__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetMaterialDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetRaycastDirty__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetRaycastDirty__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__OnCullingChanged__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__OnCullingChanged__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(long selfObjectId, global::UnityEngine.UI.CanvasUpdate update)
        {
            UnityEngineUIGraphic__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(selfObjectId, (int) update);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__LayoutComplete__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__LayoutComplete__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__GraphicUpdateComplete__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__GraphicUpdateComplete__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__SetNativeSize__SystemVoid(long selfObjectId)
        {
            UnityEngineUIGraphic__func__SetNativeSize__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineUIGraphic__func__Raycast__UnityEngineVector2__UnityEngineCamera__SystemBoolean(long selfObjectId, global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            var methodCallResult = UnityEngineUIGraphic__func__Raycast__UnityEngineVector2__UnityEngineCamera__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref sp), eventCamera.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineUIGraphic__func__PixelAdjustPoint__UnityEngineVector2__UnityEngineVector2(long selfObjectId, global::UnityEngine.Vector2 point)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineUIGraphic__func__PixelAdjustPoint__UnityEngineVector2__UnityEngineVector2(selfObjectId, Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineUIGraphic__func__GetPixelAdjustedRect__UnityEngineRect(long selfObjectId)
        {
            global::UnityEngine.Rect returnResultValue = default;
            UnityEngineUIGraphic__func__GetPixelAdjustedRect__UnityEngineRect(selfObjectId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rect returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
            var ignoreTimeScaleConverted = Unsafe.As<bool, int>(ref ignoreTimeScale);
            var useAlphaConverted = Unsafe.As<bool, int>(ref useAlpha);
            UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref targetColor), duration, ignoreTimeScaleConverted, useAlphaConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
        {
            var ignoreTimeScaleConverted = Unsafe.As<bool, int>(ref ignoreTimeScale);
            var useAlphaConverted = Unsafe.As<bool, int>(ref useAlpha);
            var useRGBConverted = Unsafe.As<bool, int>(ref useRGB);
            UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref targetColor), duration, ignoreTimeScaleConverted, useAlphaConverted, useRGBConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineUIGraphic__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, float alpha, float duration, bool ignoreTimeScale)
        {
            var ignoreTimeScaleConverted = Unsafe.As<bool, int>(ref ignoreTimeScale);
            UnityEngineUIGraphic__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(selfObjectId, alpha, duration, ignoreTimeScaleConverted);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__defaultGraphicMaterial();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__get__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__set__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineUIGraphic__get__raycastTarget(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__set__raycastTarget(long selfObjectId, int raycastTargetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__get__raycastPadding(long selfObjectId, void* raycastPaddingPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__set__raycastPadding(long selfObjectId, void* raycastPaddingPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineUIGraphic__get__depth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__rectTransform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__defaultMaterial(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__material(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__set__material(long selfObjectId, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__materialForRendering(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineUIGraphic__get__mainTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetAllDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetLayoutDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetVerticesDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetMaterialDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetRaycastDirty__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__OnCullingChanged__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__Rebuild__UnityEngineUICanvasUpdateEnum__SystemVoid(long selfObjectId, int updateUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__LayoutComplete__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__GraphicUpdateComplete__SystemVoid(long selfObjectId);
        
        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__SetNativeSize__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineUIGraphic__func__Raycast__UnityEngineVector2__UnityEngineCamera__SystemBoolean(long selfObjectId, void* spPointer, long eventCameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__func__PixelAdjustPoint__UnityEngineVector2__UnityEngineVector2(long selfObjectId, void* pointPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__func__GetPixelAdjustedRect__UnityEngineRect(long selfObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, void* targetColorPointer, float duration, int ignoreTimeScaleConverted, int useAlphaConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineUIGraphic__func__CrossFadeColor__UnityEngineColor__SystemSingle__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, void* targetColorPointer, float duration, int ignoreTimeScaleConverted, int useAlphaConverted, int useRGBConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineUIGraphic__func__CrossFadeAlpha__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, float alpha, float duration, int ignoreTimeScaleConverted);

        #endregion Imports
    }
}