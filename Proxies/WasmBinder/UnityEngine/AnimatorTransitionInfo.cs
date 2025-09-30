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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct AnimatorTransitionInfo
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_FullPath;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_UserName;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_Name;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private bool m_HasFixedDuration;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private float m_Duration;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private float m_NormalizedTime;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private bool m_AnyState;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private int m_TransitionType;

        public int fullPathHash 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__fullPathHash(ref this);
        }

        public int nameHash 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__nameHash(ref this);
        }

        public int userNameHash 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__userNameHash(ref this);
        }

        public global::UnityEngine.DurationUnit durationUnit 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__durationUnit(ref this);
        }

        public float duration 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__duration(ref this);
        }

        public float normalizedTime 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__normalizedTime(ref this);
        }

        public bool anyState 
        {
            get => internal_UnityEngineAnimatorTransitionInfo__get__anyState(ref this);
        }

        public bool IsName(string name)
        {
            return internal_UnityEngineAnimatorTransitionInfo__func__IsName__SystemString__SystemBoolean(ref this, name);
        }

        public bool IsUserName(string name)
        {
            return internal_UnityEngineAnimatorTransitionInfo__func__IsUserName__SystemString__SystemBoolean(ref this, name);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorTransitionInfo__get__fullPathHash(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__fullPathHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorTransitionInfo__get__nameHash(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__nameHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorTransitionInfo__get__userNameHash(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__userNameHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.DurationUnit internal_UnityEngineAnimatorTransitionInfo__get__durationUnit(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__durationUnit(selfStructPointer);
            var returnResult = (global::UnityEngine.DurationUnit)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorTransitionInfo__get__duration(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__duration(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorTransitionInfo__get__normalizedTime(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__normalizedTime(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorTransitionInfo__get__anyState(ref global::UnityEngine.AnimatorTransitionInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorTransitionInfo__get__anyState(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorTransitionInfo__func__IsName__SystemString__SystemBoolean(ref global::UnityEngine.AnimatorTransitionInfo selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEngineAnimatorTransitionInfo__func__IsName__SystemString__SystemBoolean(selfStructPointer, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorTransitionInfo__func__IsUserName__SystemString__SystemBoolean(ref global::UnityEngine.AnimatorTransitionInfo selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEngineAnimatorTransitionInfo__func__IsUserName__SystemString__SystemBoolean(selfStructPointer, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__get__fullPathHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__get__nameHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__get__userNameHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__get__durationUnit(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorTransitionInfo__get__duration(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorTransitionInfo__get__normalizedTime(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__get__anyState(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__func__IsName__SystemString__SystemBoolean(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorTransitionInfo__func__IsUserName__SystemString__SystemBoolean(void* selfStructPointer, void* namePointer, int nameWasmLength);

        #endregion Imports
    }
}
