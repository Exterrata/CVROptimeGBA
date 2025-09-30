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
    public partial struct AnimatorStateInfo
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_Name;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        private int m_Path;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        private int m_FullPath;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        private float m_NormalizedTime;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        private float m_Length;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private float m_Speed;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        private float m_SpeedMultiplier;

        // [FieldOffset(28)] (implicit field offset from sequential layout kind)
        private int m_Tag;

        // [FieldOffset(32)] (implicit field offset from sequential layout kind)
        private int m_Loop;

        public int fullPathHash 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__fullPathHash(ref this);
        }

        public int shortNameHash 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__shortNameHash(ref this);
        }

        public float normalizedTime 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__normalizedTime(ref this);
        }

        public float length 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__length(ref this);
        }

        public float speed 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__speed(ref this);
        }

        public float speedMultiplier 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__speedMultiplier(ref this);
        }

        public int tagHash 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__tagHash(ref this);
        }

        public bool loop 
        {
            get => internal_UnityEngineAnimatorStateInfo__get__loop(ref this);
        }

        public bool IsName(string name)
        {
            return internal_UnityEngineAnimatorStateInfo__func__IsName__SystemString__SystemBoolean(ref this, name);
        }

        public bool IsTag(string tag)
        {
            return internal_UnityEngineAnimatorStateInfo__func__IsTag__SystemString__SystemBoolean(ref this, tag);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorStateInfo__get__fullPathHash(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__fullPathHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorStateInfo__get__shortNameHash(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__shortNameHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorStateInfo__get__normalizedTime(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__normalizedTime(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorStateInfo__get__length(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__length(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorStateInfo__get__speed(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__speed(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimatorStateInfo__get__speedMultiplier(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__speedMultiplier(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimatorStateInfo__get__tagHash(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__tagHash(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorStateInfo__get__loop(ref global::UnityEngine.AnimatorStateInfo selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineAnimatorStateInfo__get__loop(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorStateInfo__func__IsName__SystemString__SystemBoolean(ref global::UnityEngine.AnimatorStateInfo selfStruct, string name)
        {
            fixed (char* namePointer = name)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEngineAnimatorStateInfo__func__IsName__SystemString__SystemBoolean(selfStructPointer, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimatorStateInfo__func__IsTag__SystemString__SystemBoolean(ref global::UnityEngine.AnimatorStateInfo selfStruct, string tag)
        {
            fixed (char* tagPointer = tag)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                var methodCallResult = UnityEngineAnimatorStateInfo__func__IsTag__SystemString__SystemBoolean(selfStructPointer, tagPointer, tag.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__get__fullPathHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__get__shortNameHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorStateInfo__get__normalizedTime(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorStateInfo__get__length(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorStateInfo__get__speed(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimatorStateInfo__get__speedMultiplier(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__get__tagHash(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__get__loop(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__func__IsName__SystemString__SystemBoolean(void* selfStructPointer, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimatorStateInfo__func__IsTag__SystemString__SystemBoolean(void* selfStructPointer, void* tagPointer, int tagWasmLength);

        #endregion Imports
    }
}
