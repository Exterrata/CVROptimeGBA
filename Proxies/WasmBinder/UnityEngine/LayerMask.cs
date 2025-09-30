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
    public partial struct LayerMask
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        private int m_Mask;

        public int value 
        {
            get => internal_UnityEngineLayerMask__get__value(ref this);
            set => internal_UnityEngineLayerMask__set__value(ref this, value);
        }

        public static string LayerToName(int layer)
        {
            return internal_UnityEngineLayerMask__func__LayerToName__SystemInt32__SystemString(layer);
        }

        public static int NameToLayer(string layerName)
        {
            return internal_UnityEngineLayerMask__func__NameToLayer__SystemString__SystemInt32(layerName);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineLayerMask__get__value(ref global::UnityEngine.LayerMask selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineLayerMask__get__value(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineLayerMask__set__value(ref global::UnityEngine.LayerMask selfStruct, int value)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineLayerMask__set__value(selfStructPointer, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineLayerMask__func__LayerToName__SystemInt32__SystemString(int layer)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineLayerMask__func__LayerToName__SystemInt32__SystemString(layer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineLayerMask__func__NameToLayer__SystemString__SystemInt32(string layerName)
        {
            fixed (char* layerNamePointer = layerName)
            {
                var methodCallResult = UnityEngineLayerMask__func__NameToLayer__SystemString__SystemInt32(layerNamePointer, layerName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineLayerMask__get__value(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLayerMask__set__value(void* selfStructPointer, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineLayerMask__func__LayerToName__SystemInt32__SystemString(int layer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineLayerMask__func__NameToLayer__SystemString__SystemInt32(void* layerNamePointer, int layerNameWasmLength);

        #endregion Imports
    }
}
