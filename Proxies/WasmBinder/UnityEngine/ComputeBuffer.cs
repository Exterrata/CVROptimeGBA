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

    public partial class ComputeBuffer(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public ComputeBuffer(int count, int stride)
            : this(internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32(count, stride)) { }

        public ComputeBuffer(int count, int stride, global::UnityEngine.ComputeBufferType type)
            : this(internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum(count, stride, type)) { }

        public ComputeBuffer(int count, int stride, global::UnityEngine.ComputeBufferType type, global::UnityEngine.ComputeBufferMode usage)
            : this(internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum__UnityEngineComputeBufferModeEnum(count, stride, type, usage)) { }

        public int count 
        {
            get => internal_UnityEngineComputeBuffer__get__count(WrappedId);
        }

        public int stride 
        {
            get => internal_UnityEngineComputeBuffer__get__stride(WrappedId);
        }

        public string name 
        {
            set => internal_UnityEngineComputeBuffer__set__name(WrappedId, value);
        }

        public void Dispose()
        {
            internal_UnityEngineComputeBuffer__func__Dispose__SystemVoid(WrappedId);
        }

        public void Release()
        {
            internal_UnityEngineComputeBuffer__func__Release__SystemVoid(WrappedId);
        }

        public bool IsValid()
        {
            return internal_UnityEngineComputeBuffer__func__IsValid__SystemBoolean(WrappedId);
        }

        public void SetData(global::System.Array data)
        {
            internal_UnityEngineComputeBuffer__func__SetData__SystemArray__SystemVoid(WrappedId, data);
        }

        public void SetData(global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            internal_UnityEngineComputeBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, data, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        public void GetData(global::System.Array data)
        {
            internal_UnityEngineComputeBuffer__func__GetData__SystemArray__SystemVoid(WrappedId, data);
        }

        public void GetData(global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            internal_UnityEngineComputeBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, data, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        public void SetCounterValue(uint counterValue)
        {
            internal_UnityEngineComputeBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(WrappedId, counterValue);
        }

        public static void CopyCount(global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            internal_UnityEngineComputeBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src, dst, dstOffsetBytes);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32(int count, int stride)
        {
            return UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32(count, stride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum(int count, int stride, global::UnityEngine.ComputeBufferType type)
        {
            return UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum(count, stride, (int) type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum__UnityEngineComputeBufferModeEnum(int count, int stride, global::UnityEngine.ComputeBufferType type, global::UnityEngine.ComputeBufferMode usage)
        {
            return UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum__UnityEngineComputeBufferModeEnum(count, stride, (int) type, (int) usage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineComputeBuffer__get__count(long selfObjectId)
        {
            var methodCallResult = UnityEngineComputeBuffer__get__count(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineComputeBuffer__get__stride(long selfObjectId)
        {
            var methodCallResult = UnityEngineComputeBuffer__get__stride(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeBuffer__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__Dispose__SystemVoid(long selfObjectId)
        {
            UnityEngineComputeBuffer__func__Dispose__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__Release__SystemVoid(long selfObjectId)
        {
            UnityEngineComputeBuffer__func__Release__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComputeBuffer__func__IsValid__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineComputeBuffer__func__IsValid__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__SetData__SystemArray__SystemVoid(long selfObjectId, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineComputeBuffer__func__SetData__SystemArray__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineComputeBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__GetData__SystemArray__SystemVoid(long selfObjectId, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineComputeBuffer__func__GetData__SystemArray__SystemVoid(selfObjectId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineComputeBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, 0 /* Todo: Fix this */, managedBufferStartIndex, computeBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(long selfObjectId, uint counterValue)
        {
            var counterValueConverted = Unsafe.As<uint, int>(ref counterValue);
            UnityEngineComputeBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(selfObjectId, counterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, int dstOffsetBytes)
        {
            UnityEngineComputeBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(src.WrappedId, dst.WrappedId, dstOffsetBytes);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32(int count, int stride);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum(int count, int stride, int typeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineComputeBuffer__ctor__SystemInt32__SystemInt32__UnityEngineComputeBufferTypeEnum__UnityEngineComputeBufferModeEnum(int count, int stride, int typeUnderlyingValue, int usageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineComputeBuffer__get__count(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineComputeBuffer__get__stride(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeBuffer__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__Dispose__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__Release__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineComputeBuffer__func__IsValid__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__SetData__SystemArray__SystemVoid(long selfObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__SetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long dataObjectId, int managedBufferStartIndex, int computeBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__GetData__SystemArray__SystemVoid(long selfObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__GetData__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long dataObjectId, int managedBufferStartIndex, int computeBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__SetCounterValue__SystemUInt32__SystemVoid(long selfObjectId, int counterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeBuffer__func__CopyCount__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long srcObjectId, long dstObjectId, int dstOffsetBytes);

        #endregion Imports
    }
}
