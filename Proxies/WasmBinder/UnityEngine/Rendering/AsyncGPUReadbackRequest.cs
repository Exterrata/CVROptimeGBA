//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    [StructLayout(LayoutKind.Sequential)]
    public partial struct AsyncGPUReadbackRequest
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        internal global::System.IntPtr m_Ptr;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        internal int m_Version;

        public bool done 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__done(ref this);
        }

        public bool hasError 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__hasError(ref this);
        }

        public int layerCount 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__layerCount(ref this);
        }

        public int layerDataSize 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__layerDataSize(ref this);
        }

        public int width 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__width(ref this);
        }

        public int height 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__height(ref this);
        }

        public int depth 
        {
            get => internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__depth(ref this);
        }

        public void Update()
        {
            internal_UnityEngineRenderingAsyncGPUReadbackRequest__func__Update__SystemVoid(ref this);
        }

        public void WaitForCompletion()
        {
            internal_UnityEngineRenderingAsyncGPUReadbackRequest__func__WaitForCompletion__SystemVoid(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__done(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__done(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__hasError(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__hasError(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__layerCount(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__layerCount(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__layerDataSize(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__layerDataSize(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__width(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__width(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__height(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__height(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingAsyncGPUReadbackRequest__get__depth(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderingAsyncGPUReadbackRequest__get__depth(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingAsyncGPUReadbackRequest__func__Update__SystemVoid(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingAsyncGPUReadbackRequest__func__Update__SystemVoid(selfStructPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingAsyncGPUReadbackRequest__func__WaitForCompletion__SystemVoid(ref global::UnityEngine.Rendering.AsyncGPUReadbackRequest selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderingAsyncGPUReadbackRequest__func__WaitForCompletion__SystemVoid(selfStructPointer);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__done(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__hasError(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__layerCount(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__layerDataSize(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__width(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__height(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderingAsyncGPUReadbackRequest__get__depth(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingAsyncGPUReadbackRequest__func__Update__SystemVoid(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingAsyncGPUReadbackRequest__func__WaitForCompletion__SystemVoid(void* selfStructPointer);

        #endregion Imports
    }
}
