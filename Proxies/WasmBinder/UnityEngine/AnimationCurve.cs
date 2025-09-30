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

    public partial class AnimationCurve(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public AnimationCurve(global::UnityEngine.Keyframe[] keys)
            : this(internal_UnityEngineAnimationCurve__ctor__UnityEngineKeyframeArray(keys)) { }

        public AnimationCurve()
            : this(internal_UnityEngineAnimationCurve__ctor()) { }

        public global::UnityEngine.Keyframe[] keys 
        {
            get => internal_UnityEngineAnimationCurve__get__keys(WrappedId);
            set => internal_UnityEngineAnimationCurve__set__keys(WrappedId, value);
        }

        public int length 
        {
            get => internal_UnityEngineAnimationCurve__get__length(WrappedId);
        }

        public global::UnityEngine.WrapMode preWrapMode 
        {
            get => internal_UnityEngineAnimationCurve__get__preWrapMode(WrappedId);
            set => internal_UnityEngineAnimationCurve__set__preWrapMode(WrappedId, value);
        }

        public global::UnityEngine.WrapMode postWrapMode 
        {
            get => internal_UnityEngineAnimationCurve__get__postWrapMode(WrappedId);
            set => internal_UnityEngineAnimationCurve__set__postWrapMode(WrappedId, value);
        }

        public float Evaluate(float time)
        {
            return internal_UnityEngineAnimationCurve__func__Evaluate__SystemSingle__SystemSingle(WrappedId, time);
        }

        public int AddKey(float time, float value)
        {
            return internal_UnityEngineAnimationCurve__func__AddKey__SystemSingle__SystemSingle__SystemInt32(WrappedId, time, value);
        }

        public int AddKey(global::UnityEngine.Keyframe key)
        {
            return internal_UnityEngineAnimationCurve__func__AddKey__UnityEngineKeyframe__SystemInt32(WrappedId, key);
        }

        public int MoveKey(int index, global::UnityEngine.Keyframe key)
        {
            return internal_UnityEngineAnimationCurve__func__MoveKey__SystemInt32__UnityEngineKeyframe__SystemInt32(WrappedId, index, key);
        }

        public void RemoveKey(int index)
        {
            internal_UnityEngineAnimationCurve__func__RemoveKey__SystemInt32__SystemVoid(WrappedId, index);
        }

        public void SmoothTangents(int index, float weight)
        {
            internal_UnityEngineAnimationCurve__func__SmoothTangents__SystemInt32__SystemSingle__SystemVoid(WrappedId, index, weight);
        }

        public static global::UnityEngine.AnimationCurve Constant(float timeStart, float timeEnd, float value)
        {
            return internal_UnityEngineAnimationCurve__func__Constant__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, timeEnd, value);
        }

        public static global::UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
        {
            return internal_UnityEngineAnimationCurve__func__Linear__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, valueStart, timeEnd, valueEnd);
        }

        public static global::UnityEngine.AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
        {
            return internal_UnityEngineAnimationCurve__func__EaseInOut__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, valueStart, timeEnd, valueEnd);
        }

        public bool Equals(object o)
        {
            return internal_UnityEngineAnimationCurve__func__Equals__SystemObject__SystemBoolean(WrappedId, o);
        }

        public bool Equals(global::UnityEngine.AnimationCurve other)
        {
            return internal_UnityEngineAnimationCurve__func__Equals__UnityEngineAnimationCurve__SystemBoolean(WrappedId, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEngineAnimationCurve__func__GetHashCode__SystemInt32(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAnimationCurve__ctor__UnityEngineKeyframeArray(global::UnityEngine.Keyframe[] keys)
        {
            fixed (global::UnityEngine.Keyframe* keysPointer = keys)
            {
                return UnityEngineAnimationCurve__ctor__UnityEngineKeyframeArray(keysPointer, keys.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineAnimationCurve__ctor()
        {
            return UnityEngineAnimationCurve__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Keyframe[] internal_UnityEngineAnimationCurve__get__keys(long selfObjectId)
        {
            global::UnityEngine.Keyframe* keysIdsPointer = default;
            int keysWasmLength = default;
            UnityEngineAnimationCurve__get__keys(selfObjectId, &keysIdsPointer, &keysWasmLength);
            global::UnityEngine.Keyframe[] returnResult = new global::UnityEngine.Keyframe[keysWasmLength];
            for (int i = 0; i < keysWasmLength; i++)
            {
                returnResult[i] = keysIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)keysIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationCurve__set__keys(long selfObjectId, global::UnityEngine.Keyframe[] keys)
        {
            fixed (global::UnityEngine.Keyframe* keysPointer = keys)
            {
                UnityEngineAnimationCurve__set__keys(selfObjectId, keysPointer, keys.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimationCurve__get__length(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationCurve__get__length(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.WrapMode internal_UnityEngineAnimationCurve__get__preWrapMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationCurve__get__preWrapMode(selfObjectId);
            var returnResult = (global::UnityEngine.WrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationCurve__set__preWrapMode(long selfObjectId, global::UnityEngine.WrapMode preWrapMode)
        {
            UnityEngineAnimationCurve__set__preWrapMode(selfObjectId, (int) preWrapMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.WrapMode internal_UnityEngineAnimationCurve__get__postWrapMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationCurve__get__postWrapMode(selfObjectId);
            var returnResult = (global::UnityEngine.WrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationCurve__set__postWrapMode(long selfObjectId, global::UnityEngine.WrapMode postWrapMode)
        {
            UnityEngineAnimationCurve__set__postWrapMode(selfObjectId, (int) postWrapMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimationCurve__func__Evaluate__SystemSingle__SystemSingle(long selfObjectId, float time)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__Evaluate__SystemSingle__SystemSingle(selfObjectId, time);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimationCurve__func__AddKey__SystemSingle__SystemSingle__SystemInt32(long selfObjectId, float time, float value)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__AddKey__SystemSingle__SystemSingle__SystemInt32(selfObjectId, time, value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimationCurve__func__AddKey__UnityEngineKeyframe__SystemInt32(long selfObjectId, global::UnityEngine.Keyframe key)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__AddKey__UnityEngineKeyframe__SystemInt32(selfObjectId, Unsafe.AsPointer(ref key));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimationCurve__func__MoveKey__SystemInt32__UnityEngineKeyframe__SystemInt32(long selfObjectId, int index, global::UnityEngine.Keyframe key)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__MoveKey__SystemInt32__UnityEngineKeyframe__SystemInt32(selfObjectId, index, Unsafe.AsPointer(ref key));
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationCurve__func__RemoveKey__SystemInt32__SystemVoid(long selfObjectId, int index)
        {
            UnityEngineAnimationCurve__func__RemoveKey__SystemInt32__SystemVoid(selfObjectId, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimationCurve__func__SmoothTangents__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int index, float weight)
        {
            UnityEngineAnimationCurve__func__SmoothTangents__SystemInt32__SystemSingle__SystemVoid(selfObjectId, index, weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationCurve internal_UnityEngineAnimationCurve__func__Constant__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float timeEnd, float value)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__Constant__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, timeEnd, value);
            var returnResult = new global::UnityEngine.AnimationCurve(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationCurve internal_UnityEngineAnimationCurve__func__Linear__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float valueStart, float timeEnd, float valueEnd)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__Linear__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, valueStart, timeEnd, valueEnd);
            var returnResult = new global::UnityEngine.AnimationCurve(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimationCurve internal_UnityEngineAnimationCurve__func__EaseInOut__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float valueStart, float timeEnd, float valueEnd)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__EaseInOut__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(timeStart, valueStart, timeEnd, valueEnd);
            var returnResult = new global::UnityEngine.AnimationCurve(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationCurve__func__Equals__SystemObject__SystemBoolean(long selfObjectId, object o)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEngineAnimationCurve__func__Equals__SystemObject__SystemBoolean(selfObjectId, (o as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimationCurve__func__Equals__UnityEngineAnimationCurve__SystemBoolean(long selfObjectId, global::UnityEngine.AnimationCurve other)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__Equals__UnityEngineAnimationCurve__SystemBoolean(selfObjectId, other.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimationCurve__func__GetHashCode__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimationCurve__func__GetHashCode__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAnimationCurve__ctor__UnityEngineKeyframeArray(void* keysPointer, int keysWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimationCurve__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimationCurve__get__keys(long selfObjectId, void* keysIdsPointer, void* keysWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimationCurve__set__keys(long selfObjectId, void* keysPointer, int keysWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__get__length(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__get__preWrapMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationCurve__set__preWrapMode(long selfObjectId, int preWrapModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__get__postWrapMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationCurve__set__postWrapMode(long selfObjectId, int postWrapModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimationCurve__func__Evaluate__SystemSingle__SystemSingle(long selfObjectId, float time);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__func__AddKey__SystemSingle__SystemSingle__SystemInt32(long selfObjectId, float time, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimationCurve__func__AddKey__UnityEngineKeyframe__SystemInt32(long selfObjectId, void* keyPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimationCurve__func__MoveKey__SystemInt32__UnityEngineKeyframe__SystemInt32(long selfObjectId, int index, void* keyPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationCurve__func__RemoveKey__SystemInt32__SystemVoid(long selfObjectId, int index);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimationCurve__func__SmoothTangents__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int index, float weight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimationCurve__func__Constant__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float timeEnd, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimationCurve__func__Linear__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float valueStart, float timeEnd, float valueEnd);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimationCurve__func__EaseInOut__SystemSingle__SystemSingle__SystemSingle__SystemSingle__UnityEngineAnimationCurve(float timeStart, float valueStart, float timeEnd, float valueEnd);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__func__Equals__SystemObject__SystemBoolean(long selfObjectId, long oObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__func__Equals__UnityEngineAnimationCurve__SystemBoolean(long selfObjectId, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimationCurve__func__GetHashCode__SystemInt32(long selfObjectId);

        #endregion Imports
    }
}
