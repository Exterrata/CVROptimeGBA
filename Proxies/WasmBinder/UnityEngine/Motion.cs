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

    public partial class Motion(long id) : Object(id)
    {

        #region Implementation

        public float averageDuration 
        {
            get => internal_UnityEngineMotion__get__averageDuration(WrappedId);
        }

        public float averageAngularSpeed 
        {
            get => internal_UnityEngineMotion__get__averageAngularSpeed(WrappedId);
        }

        public global::UnityEngine.Vector3 averageSpeed 
        {
            get => internal_UnityEngineMotion__get__averageSpeed(WrappedId);
        }

        public float apparentSpeed 
        {
            get => internal_UnityEngineMotion__get__apparentSpeed(WrappedId);
        }

        public bool isLooping 
        {
            get => internal_UnityEngineMotion__get__isLooping(WrappedId);
        }

        public bool legacy 
        {
            get => internal_UnityEngineMotion__get__legacy(WrappedId);
        }

        public bool isHumanMotion 
        {
            get => internal_UnityEngineMotion__get__isHumanMotion(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMotion__get__averageDuration(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__averageDuration(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMotion__get__averageAngularSpeed(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__averageAngularSpeed(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineMotion__get__averageSpeed(long selfObjectId)
        {
            global::UnityEngine.Vector3 averageSpeedValue = default;
            UnityEngineMotion__get__averageSpeed(selfObjectId, Unsafe.AsPointer(ref averageSpeedValue));
            global::UnityEngine.Vector3 returnResult = averageSpeedValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMotion__get__apparentSpeed(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__apparentSpeed(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMotion__get__isLooping(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__isLooping(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMotion__get__legacy(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__legacy(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMotion__get__isHumanMotion(long selfObjectId)
        {
            var methodCallResult = UnityEngineMotion__get__isHumanMotion(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMotion__get__averageDuration(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMotion__get__averageAngularSpeed(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMotion__get__averageSpeed(long selfObjectId, void* averageSpeedPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMotion__get__apparentSpeed(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMotion__get__isLooping(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMotion__get__legacy(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMotion__get__isHumanMotion(long selfObjectId);

        #endregion Imports
    }
}
