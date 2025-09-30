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

    public partial class AnimationClip(long id) : Motion(id)
    {

        #region Implementation

        public AnimationClip()
            : this(internal_UnityEngineAnimationClip__ctor()) { }

        public float length 
        {
            get => internal_UnityEngineAnimationClip__get__length(WrappedId);
        }

        public float frameRate 
        {
            get => internal_UnityEngineAnimationClip__get__frameRate(WrappedId);
            set => internal_UnityEngineAnimationClip__set__frameRate(WrappedId, value);
        }

        public global::UnityEngine.WrapMode wrapMode 
        {
            get => internal_UnityEngineAnimationClip__get__wrapMode(WrappedId);
            set => internal_UnityEngineAnimationClip__set__wrapMode(WrappedId, value);
        }

        public global::UnityEngine.Bounds localBounds 
        {
            get => internal_UnityEngineAnimationClip__get__localBounds(WrappedId);
            set => internal_UnityEngineAnimationClip__set__localBounds(WrappedId, value);
        }

        public bool legacy 
        {
            get => internal_UnityEngineAnimationClip__get__legacy(WrappedId);
            set => internal_UnityEngineAnimationClip__set__legacy(WrappedId, value);
        }

        public bool humanMotion 
        {
            get => internal_UnityEngineAnimationClip__get__humanMotion(WrappedId);
        }

        public bool empty 
        {
            get => internal_UnityEngineAnimationClip__get__empty(WrappedId);
        }

        public bool hasGenericRootTransform 
        {
            get => internal_UnityEngineAnimationClip__get__hasGenericRootTransform(WrappedId);
        }

        public bool hasMotionFloatCurves 
        {
            get => internal_UnityEngineAnimationClip__get__hasMotionFloatCurves(WrappedId);
        }

        public bool hasMotionCurves 
        {
            get => internal_UnityEngineAnimationClip__get__hasMotionCurves(WrappedId);
        }

        public bool hasRootCurves 
        {
            get => internal_UnityEngineAnimationClip__get__hasRootCurves(WrappedId);
        }

        public void SampleAnimation(global::UnityEngine.GameObject go, float time)
        {
            internal_UnityEngineAnimationClip__func__SampleAnimation__UnityEngineGameObject__SystemSingle__SystemVoid(WrappedId, go, time);
        }

        public void SetCurve(string relativePath, global::System.Type type, string propertyName, global::UnityEngine.AnimationCurve curve)
        {
            internal_UnityEngineAnimationClip__func__SetCurve__SystemString__SystemType__SystemString__UnityEngineAnimationCurve__SystemVoid(WrappedId, relativePath, type, propertyName, curve);
        }

        public void EnsureQuaternionContinuity()
        {
            internal_UnityEngineAnimationClip__func__EnsureQuaternionContinuity__SystemVoid(WrappedId);
        }

        public void ClearCurves()
        {
            internal_UnityEngineAnimationClip__func__ClearCurves__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAnimationClip__ctor()
        {
            return UnityEngineAnimationClip__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimationClip__get__length(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__length(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimationClip__get__frameRate(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__frameRate(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__set__frameRate(long selfObjectId, float frameRate)
        {
            UnityEngineAnimationClip__set__frameRate(selfObjectId, frameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.WrapMode internal_UnityEngineAnimationClip__get__wrapMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__wrapMode(selfObjectId);
            var returnResult = (global::UnityEngine.WrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__set__wrapMode(long selfObjectId, global::UnityEngine.WrapMode wrapMode)
        {
            UnityEngineAnimationClip__set__wrapMode(selfObjectId, (int) wrapMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineAnimationClip__get__localBounds(long selfObjectId)
        {
            global::UnityEngine.Bounds localBoundsValue = default;
            UnityEngineAnimationClip__get__localBounds(selfObjectId, Unsafe.AsPointer(ref localBoundsValue));
            global::UnityEngine.Bounds returnResult = localBoundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__set__localBounds(long selfObjectId, global::UnityEngine.Bounds localBounds)
        {
            UnityEngineAnimationClip__set__localBounds(selfObjectId, Unsafe.AsPointer(ref localBounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__legacy(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__legacy(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__set__legacy(long selfObjectId, bool legacy)
        {
            var legacyConverted = Unsafe.As<bool, int>(ref legacy);
            UnityEngineAnimationClip__set__legacy(selfObjectId, legacyConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__humanMotion(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__humanMotion(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__empty(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__empty(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__hasGenericRootTransform(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__hasGenericRootTransform(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__hasMotionFloatCurves(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__hasMotionFloatCurves(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__hasMotionCurves(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__hasMotionCurves(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationClip__get__hasRootCurves(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationClip__get__hasRootCurves(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__func__SampleAnimation__UnityEngineGameObject__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.GameObject go, float time)
        {
            UnityEngineAnimationClip__func__SampleAnimation__UnityEngineGameObject__SystemSingle__SystemVoid(selfObjectId, go.WrappedId, time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__func__SetCurve__SystemString__SystemType__SystemString__UnityEngineAnimationCurve__SystemVoid(long selfObjectId, string relativePath, global::System.Type type, string propertyName, global::UnityEngine.AnimationCurve curve)
        {
            fixed (char* relativePathPointer = relativePath, propertyNamePointer = propertyName)
            {
                UnityEngineAnimationClip__func__SetCurve__SystemString__SystemType__SystemString__UnityEngineAnimationCurve__SystemVoid(selfObjectId, relativePathPointer, relativePath.Length * sizeof(char), global::WasmScripting.TypeMap.GetId(type), propertyNamePointer, propertyName.Length * sizeof(char), curve.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__func__EnsureQuaternionContinuity__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimationClip__func__EnsureQuaternionContinuity__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationClip__func__ClearCurves__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimationClip__func__ClearCurves__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimationClip__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimationClip__get__length(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimationClip__get__frameRate(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__set__frameRate(long selfObjectId, float frameRate);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__wrapMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__set__wrapMode(long selfObjectId, int wrapModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimationClip__get__localBounds(long selfObjectId, void* localBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimationClip__set__localBounds(long selfObjectId, void* localBoundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__legacy(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__set__legacy(long selfObjectId, int legacyConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__humanMotion(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__empty(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__hasGenericRootTransform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__hasMotionFloatCurves(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__hasMotionCurves(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationClip__get__hasRootCurves(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__func__SampleAnimation__UnityEngineGameObject__SystemSingle__SystemVoid(long selfObjectId, long goObjectId, float time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimationClip__func__SetCurve__SystemString__SystemType__SystemString__UnityEngineAnimationCurve__SystemVoid(long selfObjectId, void* relativePathPointer, int relativePathWasmLength, int typeId, void* propertyNamePointer, int propertyNameWasmLength, long curveObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__func__EnsureQuaternionContinuity__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationClip__func__ClearCurves__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
