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

    public partial struct HumanBone(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public global::UnityEngine.HumanLimit limit
        {
            get => internal_UnityEngineHumanBone__get__limit(WrappedId);
            set => internal_UnityEngineHumanBone__set__limit(WrappedId, value);
        }

        public string boneName 
        {
            get => internal_UnityEngineHumanBone__get__boneName(WrappedId);
            set => internal_UnityEngineHumanBone__set__boneName(WrappedId, value);
        }

        public string humanName 
        {
            get => internal_UnityEngineHumanBone__get__humanName(WrappedId);
            set => internal_UnityEngineHumanBone__set__humanName(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.HumanLimit internal_UnityEngineHumanBone__get__limit(long selfObjectId)
        {
            global::UnityEngine.HumanLimit limitValue = default;
            UnityEngineHumanBone__get__limit(selfObjectId, Unsafe.AsPointer(ref limitValue));
            global::UnityEngine.HumanLimit returnResult = limitValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanBone__set__limit(long selfObjectId, global::UnityEngine.HumanLimit limit)
        {
            UnityEngineHumanBone__set__limit(selfObjectId, Unsafe.AsPointer(ref limit));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineHumanBone__get__boneName(long selfObjectId)
        {
            char* boneNamePointer = default;
            int boneNameWasmLength = default;
            UnityEngineHumanBone__get__boneName(selfObjectId, &boneNamePointer, &boneNameWasmLength);
            string returnResult = new(boneNamePointer, 0, boneNameWasmLength);
            Marshal.FreeHGlobal((IntPtr)boneNamePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanBone__set__boneName(long selfObjectId, string boneName)
        {
            fixed (char* boneNamePointer = boneName)
            {
                UnityEngineHumanBone__set__boneName(selfObjectId, boneNamePointer, boneName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineHumanBone__get__humanName(long selfObjectId)
        {
            char* humanNamePointer = default;
            int humanNameWasmLength = default;
            UnityEngineHumanBone__get__humanName(selfObjectId, &humanNamePointer, &humanNameWasmLength);
            string returnResult = new(humanNamePointer, 0, humanNameWasmLength);
            Marshal.FreeHGlobal((IntPtr)humanNamePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanBone__set__humanName(long selfObjectId, string humanName)
        {
            fixed (char* humanNamePointer = humanName)
            {
                UnityEngineHumanBone__set__humanName(selfObjectId, humanNamePointer, humanName.Length * sizeof(char));
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__get__limit(long selfObjectId, void* limitPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__set__limit(long selfObjectId, void* limitPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__get__boneName(long selfObjectId, void* boneNamePointer, void* boneNameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__set__boneName(long selfObjectId, void* boneNamePointer, int boneNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__get__humanName(long selfObjectId, void* humanNamePointer, void* humanNameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanBone__set__humanName(long selfObjectId, void* humanNamePointer, int humanNameWasmLength);

        #endregion Imports
    }
}
