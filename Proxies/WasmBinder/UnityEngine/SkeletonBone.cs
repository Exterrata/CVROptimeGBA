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

    public partial struct SkeletonBone(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public string name
        {
            get => internal_UnityEngineSkeletonBone__get__name(WrappedId);
            set => internal_UnityEngineSkeletonBone__set__name(WrappedId, value);
        }

        public global::UnityEngine.Vector3 position
        {
            get => internal_UnityEngineSkeletonBone__get__position(WrappedId);
            set => internal_UnityEngineSkeletonBone__set__position(WrappedId, value);
        }

        public global::UnityEngine.Quaternion rotation
        {
            get => internal_UnityEngineSkeletonBone__get__rotation(WrappedId);
            set => internal_UnityEngineSkeletonBone__set__rotation(WrappedId, value);
        }

        public global::UnityEngine.Vector3 scale
        {
            get => internal_UnityEngineSkeletonBone__get__scale(WrappedId);
            set => internal_UnityEngineSkeletonBone__set__scale(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineSkeletonBone__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineSkeletonBone__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkeletonBone__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineSkeletonBone__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineSkeletonBone__get__position(long selfObjectId)
        {
            global::UnityEngine.Vector3 positionValue = default;
            UnityEngineSkeletonBone__get__position(selfObjectId, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector3 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkeletonBone__set__position(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            UnityEngineSkeletonBone__set__position(selfObjectId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineSkeletonBone__get__rotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion rotationValue = default;
            UnityEngineSkeletonBone__get__rotation(selfObjectId, Unsafe.AsPointer(ref rotationValue));
            global::UnityEngine.Quaternion returnResult = rotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkeletonBone__set__rotation(long selfObjectId, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineSkeletonBone__set__rotation(selfObjectId, Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineSkeletonBone__get__scale(long selfObjectId)
        {
            global::UnityEngine.Vector3 scaleValue = default;
            UnityEngineSkeletonBone__get__scale(selfObjectId, Unsafe.AsPointer(ref scaleValue));
            global::UnityEngine.Vector3 returnResult = scaleValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkeletonBone__set__scale(long selfObjectId, global::UnityEngine.Vector3 scale)
        {
            UnityEngineSkeletonBone__set__scale(selfObjectId, Unsafe.AsPointer(ref scale));
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__get__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__set__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__get__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__set__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__get__scale(long selfObjectId, void* scalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkeletonBone__set__scale(long selfObjectId, void* scalePointer);

        #endregion Imports
    }
}
