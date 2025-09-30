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

    public partial class GraphicsBuffer(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public GraphicsBuffer(global::UnityEngine.GraphicsBuffer.Target target, int count, int stride)
            : this(internal_UnityEngineGraphicsBuffer__ctor__UnityEngineTargetEnum__SystemInt32__SystemInt32(target, count, stride)) { }

        public int count 
        {
            get => internal_UnityEngineGraphicsBuffer__get__count(WrappedId);
        }

        public int stride 
        {
            get => internal_UnityEngineGraphicsBuffer__get__stride(WrappedId);
        }

        public global::UnityEngine.GraphicsBuffer.Target target 
        {
            get => internal_UnityEngineGraphicsBuffer__get__target(WrappedId);
        }

        public string name 
        {
            set => internal_UnityEngineGraphicsBuffer__set__name(WrappedId, value);
        }

        public void Dispose()
        {
            internal_UnityEngineGraphicsBuffer__func__Dispose__SystemVoid(WrappedId);
        }

        public void Release()
        {
            internal_UnityEngineGraphicsBuffer__func__Release__SystemVoid(WrappedId);
        }

        public bool IsValid()
        {
            return internal_UnityEngineGraphicsBuffer__func__IsValid__SystemBoolean(WrappedId);
        }

        public void SetData(global::System.Array data)
        {
            internal_UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemVoid(WrappedId, data);
        }

        public void SetData(global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            internal_UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, data, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        public void GetData(global::System.Array data)
        {
            internal_UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemVoid(WrappedId, data);
        }

        public void GetData(global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            internal_UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, data, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        public void SetCounterValue(uint counterValue)
        {
            internal_UnityEngineGraphicsBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(WrappedId, counterValue);
        }

        public static void CopyCount(global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src, dst, dstOffsetBytes);
        }

        public static void CopyCount(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src, dst, dstOffsetBytes);
        }

        public static void CopyCount(global::UnityEngine.ComputeBuffer src, global::UnityEngine.GraphicsBuffer dst, int dstOffsetBytes)
        {
            internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(src, dst, dstOffsetBytes);
        }

        public static void CopyCount(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.GraphicsBuffer dst, int dstOffsetBytes)
        {
            internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(src, dst, dstOffsetBytes);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineGraphicsBuffer__ctor__UnityEngineTargetEnum__SystemInt32__SystemInt32(global::UnityEngine.GraphicsBuffer.Target target, int count, int stride)
        {
            return UnityEngineGraphicsBuffer__ctor__UnityEngineTargetEnum__SystemInt32__SystemInt32((int) target, count, stride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineGraphicsBuffer__get__count(long selfObjectId)
        {
            var methodCallResult = UnityEngineGraphicsBuffer__get__count(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineGraphicsBuffer__get__stride(long selfObjectId)
        {
            var methodCallResult = UnityEngineGraphicsBuffer__get__stride(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer.Target internal_UnityEngineGraphicsBuffer__get__target(long selfObjectId)
        {
            var methodCallResult = UnityEngineGraphicsBuffer__get__target(selfObjectId);
            var returnResult = (global::UnityEngine.GraphicsBuffer.Target)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineGraphicsBuffer__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__Dispose__SystemVoid(long selfObjectId)
        {
            UnityEngineGraphicsBuffer__func__Dispose__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__Release__SystemVoid(long selfObjectId)
        {
            UnityEngineGraphicsBuffer__func__Release__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGraphicsBuffer__func__IsValid__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineGraphicsBuffer__func__IsValid__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemVoid(long selfObjectId, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemVoid(long selfObjectId, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(long selfObjectId, uint counterValue)
        {
            var counterValueConverted = Unsafe.As<uint, int>(ref counterValue);
            UnityEngineGraphicsBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(selfObjectId, counterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src.WrappedId, dst.WrappedId, dstOffsetBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src.WrappedId, dst.WrappedId, dstOffsetBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(global::UnityEngine.ComputeBuffer src, global::UnityEngine.GraphicsBuffer dst, int dstOffsetBytes)
        {
            UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(src.WrappedId, dst.WrappedId, dstOffsetBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.GraphicsBuffer dst, int dstOffsetBytes)
        {
            UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(src.WrappedId, dst.WrappedId, dstOffsetBytes);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGraphicsBuffer__ctor__UnityEngineTargetEnum__SystemInt32__SystemInt32(int targetUnderlyingValue, int count, int stride);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphicsBuffer__get__count(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphicsBuffer__get__stride(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphicsBuffer__get__target(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphicsBuffer__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__Dispose__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__Release__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphicsBuffer__func__IsValid__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemVoid(long selfObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long dataObjectId, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemVoid(long selfObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long dataObjectId, int managedBufferStartIndex, int computeBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(long selfObjectId, int counterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long srcObjectId, long dstObjectId, int dstOffsetBytes);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long srcObjectId, long dstObjectId, int dstOffsetBytes);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long srcObjectId, long dstObjectId, int dstOffsetBytes);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphicsBuffer__func__CopyCount__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long srcObjectId, long dstObjectId, int dstOffsetBytes);

        #endregion Imports
    }
}
