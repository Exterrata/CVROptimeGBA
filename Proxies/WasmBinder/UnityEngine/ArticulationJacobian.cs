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

    public partial struct ArticulationJacobian(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public ArticulationJacobian(int rows, int cols)
            : this(internal_UnityEngineArticulationJacobian__ctor__SystemInt32__SystemInt32(rows, cols)) { }

        public int rows 
        {
            get => internal_UnityEngineArticulationJacobian__get__rows(WrappedId);
            set => internal_UnityEngineArticulationJacobian__set__rows(WrappedId, value);
        }

        public int columns 
        {
            get => internal_UnityEngineArticulationJacobian__get__columns(WrappedId);
            set => internal_UnityEngineArticulationJacobian__set__columns(WrappedId, value);
        }

        public global::System.Collections.Generic.List<float> elements 
        {
            get => internal_UnityEngineArticulationJacobian__get__elements(WrappedId);
            set => internal_UnityEngineArticulationJacobian__set__elements(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineArticulationJacobian__ctor__SystemInt32__SystemInt32(int rows, int cols)
        {
            return UnityEngineArticulationJacobian__ctor__SystemInt32__SystemInt32(rows, cols);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationJacobian__get__rows(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationJacobian__get__rows(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationJacobian__set__rows(long selfObjectId, int rows)
        {
            UnityEngineArticulationJacobian__set__rows(selfObjectId, rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineArticulationJacobian__get__columns(long selfObjectId)
        {
            var methodCallResult = UnityEngineArticulationJacobian__get__columns(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationJacobian__set__columns(long selfObjectId, int columns)
        {
            UnityEngineArticulationJacobian__set__columns(selfObjectId, columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Collections.Generic.List<float> internal_UnityEngineArticulationJacobian__get__elements(long selfObjectId)
        {
            float* elementsIdsPointer = default;
            int elementsWasmLength = default;
            UnityEngineArticulationJacobian__get__elements(selfObjectId, &elementsIdsPointer, &elementsWasmLength);
            List<float> returnResult = new List<float>(elementsWasmLength);
            for (int i = 0; i < elementsWasmLength; i++)
            {
                returnResult.Add(elementsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)elementsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineArticulationJacobian__set__elements(long selfObjectId, global::System.Collections.Generic.List<float> elementsList)
        {
            Span<float> elements = CollectionsMarshal.AsSpan(elementsList);
            fixed (float* elementsPointer = elements)
            {
                UnityEngineArticulationJacobian__set__elements(selfObjectId, elementsPointer, elements.Length);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineArticulationJacobian__ctor__SystemInt32__SystemInt32(int rows, int cols);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationJacobian__get__rows(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationJacobian__set__rows(long selfObjectId, int rows);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineArticulationJacobian__get__columns(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineArticulationJacobian__set__columns(long selfObjectId, int columns);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationJacobian__get__elements(long selfObjectId, void* elementsIdsPointer, void* elementsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineArticulationJacobian__set__elements(long selfObjectId, void* elementsPointer, int elementsWasmLength);

        #endregion Imports
    }
}
