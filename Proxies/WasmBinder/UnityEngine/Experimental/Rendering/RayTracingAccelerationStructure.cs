//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Experimental.Rendering
{

    public partial class RayTracingAccelerationStructure(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public RayTracingAccelerationStructure()
            : this(internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__ctor()) { }

        public void Dispose()
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Dispose__SystemVoid(WrappedId);
        }

        public void Release()
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Release__SystemVoid(WrappedId);
        }

        public void Build()
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__SystemVoid(WrappedId);
        }

        public void Build(global::UnityEngine.Vector3 relativeOrigin)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__UnityEngineVector3__SystemVoid(WrappedId, relativeOrigin);
        }

        public void AddInstance(global::UnityEngine.Renderer targetRenderer, global::System.Boolean[] subMeshMask, global::System.Boolean[] subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__SystemBooleanArray__SystemBooleanArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(WrappedId, targetRenderer, subMeshMask, subMeshTransparencyFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
        }

        public void AddInstance(global::UnityEngine.Renderer targetRenderer, global::UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__UnityEngineExperimentalRenderingRayTracingSubMeshFlagsEnumArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(WrappedId, targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
        }

        public void RemoveInstance(global::UnityEngine.Renderer targetRenderer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__RemoveInstance__UnityEngineRenderer__SystemVoid(WrappedId, targetRenderer);
        }

        public void AddInstance(global::UnityEngine.GraphicsBuffer aabbBuffer, uint numElements, global::UnityEngine.Material material, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(WrappedId, aabbBuffer, numElements, material, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
        }

        public void AddInstance(global::UnityEngine.GraphicsBuffer aabbBuffer, uint numElements, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__UnityEngineMatrix4x4__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(WrappedId, aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
        }

        public void UpdateInstanceTransform(global::UnityEngine.Renderer renderer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceTransform__UnityEngineRenderer__SystemVoid(WrappedId, renderer);
        }

        public void UpdateInstanceMask(global::UnityEngine.Renderer renderer, uint mask)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceMask__UnityEngineRenderer__SystemUInt32__SystemVoid(WrappedId, renderer, mask);
        }

        public void UpdateInstanceID(global::UnityEngine.Renderer renderer, uint instanceID)
        {
            internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceID__UnityEngineRenderer__SystemUInt32__SystemVoid(WrappedId, renderer, instanceID);
        }

        public ulong GetSize()
        {
            return internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetSize__SystemUInt64(WrappedId);
        }

        public uint GetInstanceCount()
        {
            return internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetInstanceCount__SystemUInt32(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__ctor()
        {
            return UnityEngineExperimentalRenderingRayTracingAccelerationStructure__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Dispose__SystemVoid(long selfObjectId)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Dispose__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Release__SystemVoid(long selfObjectId)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Release__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__SystemVoid(long selfObjectId)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 relativeOrigin)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref relativeOrigin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__SystemBooleanArray__SystemBooleanArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer targetRenderer, global::System.Boolean[] subMeshMask, global::System.Boolean[] subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id)
        {
            fixed (bool* subMeshMaskPointer = subMeshMask, subMeshTransparencyFlagsPointer = subMeshTransparencyFlags)
            {
                var enableTriangleCullingConverted = Unsafe.As<bool, int>(ref enableTriangleCulling);
                var frontTriangleCounterClockwiseConverted = Unsafe.As<bool, int>(ref frontTriangleCounterClockwise);
                var maskConverted = Unsafe.As<uint, int>(ref mask);
                var idConverted = Unsafe.As<uint, int>(ref id);
                UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__SystemBooleanArray__SystemBooleanArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(selfObjectId, targetRenderer.WrappedId, subMeshMaskPointer, subMeshMask.Length, subMeshTransparencyFlagsPointer, subMeshTransparencyFlags.Length, enableTriangleCullingConverted, frontTriangleCounterClockwiseConverted, maskConverted, idConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__UnityEngineExperimentalRenderingRayTracingSubMeshFlagsEnumArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer targetRenderer, global::UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id)
        {
            fixed (global::UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags* subMeshFlagsPointer = subMeshFlags)
            {
                var enableTriangleCullingConverted = Unsafe.As<bool, int>(ref enableTriangleCulling);
                var frontTriangleCounterClockwiseConverted = Unsafe.As<bool, int>(ref frontTriangleCounterClockwise);
                var maskConverted = Unsafe.As<uint, int>(ref mask);
                var idConverted = Unsafe.As<uint, int>(ref id);
                UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__UnityEngineExperimentalRenderingRayTracingSubMeshFlagsEnumArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(selfObjectId, targetRenderer.WrappedId, subMeshFlagsPointer, subMeshFlags.Length, enableTriangleCullingConverted, frontTriangleCounterClockwiseConverted, maskConverted, idConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__RemoveInstance__UnityEngineRenderer__SystemVoid(long selfObjectId, global::UnityEngine.Renderer targetRenderer)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__RemoveInstance__UnityEngineRenderer__SystemVoid(selfObjectId, targetRenderer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer aabbBuffer, uint numElements, global::UnityEngine.Material material, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id)
        {
            var numElementsConverted = Unsafe.As<uint, int>(ref numElements);
            var isCutOffConverted = Unsafe.As<bool, int>(ref isCutOff);
            var enableTriangleCullingConverted = Unsafe.As<bool, int>(ref enableTriangleCulling);
            var frontTriangleCounterClockwiseConverted = Unsafe.As<bool, int>(ref frontTriangleCounterClockwise);
            var maskConverted = Unsafe.As<uint, int>(ref mask);
            var reuseBoundsConverted = Unsafe.As<bool, int>(ref reuseBounds);
            var idConverted = Unsafe.As<uint, int>(ref id);
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(selfObjectId, aabbBuffer.WrappedId, numElementsConverted, material.WrappedId, isCutOffConverted, enableTriangleCullingConverted, frontTriangleCounterClockwiseConverted, maskConverted, reuseBoundsConverted, idConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__UnityEngineMatrix4x4__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer aabbBuffer, uint numElements, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id)
        {
            var numElementsConverted = Unsafe.As<uint, int>(ref numElements);
            var isCutOffConverted = Unsafe.As<bool, int>(ref isCutOff);
            var enableTriangleCullingConverted = Unsafe.As<bool, int>(ref enableTriangleCulling);
            var frontTriangleCounterClockwiseConverted = Unsafe.As<bool, int>(ref frontTriangleCounterClockwise);
            var maskConverted = Unsafe.As<uint, int>(ref mask);
            var reuseBoundsConverted = Unsafe.As<bool, int>(ref reuseBounds);
            var idConverted = Unsafe.As<uint, int>(ref id);
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__UnityEngineMatrix4x4__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(selfObjectId, aabbBuffer.WrappedId, numElementsConverted, material.WrappedId, Unsafe.AsPointer(ref instanceTransform), isCutOffConverted, enableTriangleCullingConverted, frontTriangleCounterClockwiseConverted, maskConverted, reuseBoundsConverted, idConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceTransform__UnityEngineRenderer__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer)
        {
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceTransform__UnityEngineRenderer__SystemVoid(selfObjectId, renderer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceMask__UnityEngineRenderer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer, uint mask)
        {
            var maskConverted = Unsafe.As<uint, int>(ref mask);
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceMask__UnityEngineRenderer__SystemUInt32__SystemVoid(selfObjectId, renderer.WrappedId, maskConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceID__UnityEngineRenderer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer, uint instanceID)
        {
            var instanceIDConverted = Unsafe.As<uint, int>(ref instanceID);
            UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceID__UnityEngineRenderer__SystemUInt32__SystemVoid(selfObjectId, renderer.WrappedId, instanceIDConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetSize__SystemUInt64(long selfObjectId)
        {
            var methodCallResult = UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetSize__SystemUInt64(selfObjectId);
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetInstanceCount__SystemUInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetInstanceCount__SystemUInt32(selfObjectId);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineExperimentalRenderingRayTracingAccelerationStructure__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Dispose__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Release__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__Build__UnityEngineVector3__SystemVoid(long selfObjectId, void* relativeOriginPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__SystemBooleanArray__SystemBooleanArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(long selfObjectId, long targetRendererObjectId, void* subMeshMaskPointer, int subMeshMaskWasmLength, void* subMeshTransparencyFlagsPointer, int subMeshTransparencyFlagsWasmLength, int enableTriangleCullingConverted, int frontTriangleCounterClockwiseConverted, int maskConverted, int idConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineRenderer__UnityEngineExperimentalRenderingRayTracingSubMeshFlagsEnumArray__SystemBoolean__SystemBoolean__SystemUInt32__SystemUInt32__SystemVoid(long selfObjectId, long targetRendererObjectId, void* subMeshFlagsPointer, int subMeshFlagsWasmLength, int enableTriangleCullingConverted, int frontTriangleCounterClockwiseConverted, int maskConverted, int idConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__RemoveInstance__UnityEngineRenderer__SystemVoid(long selfObjectId, long targetRendererObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(long selfObjectId, long aabbBufferObjectId, int numElementsConverted, long materialObjectId, int isCutOffConverted, int enableTriangleCullingConverted, int frontTriangleCounterClockwiseConverted, int maskConverted, int reuseBoundsConverted, int idConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__AddInstance__UnityEngineGraphicsBuffer__SystemUInt32__UnityEngineMaterial__UnityEngineMatrix4x4__SystemBoolean__SystemBoolean__SystemBoolean__SystemUInt32__SystemBoolean__SystemUInt32__SystemVoid(long selfObjectId, long aabbBufferObjectId, int numElementsConverted, long materialObjectId, void* instanceTransformPointer, int isCutOffConverted, int enableTriangleCullingConverted, int frontTriangleCounterClockwiseConverted, int maskConverted, int reuseBoundsConverted, int idConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceTransform__UnityEngineRenderer__SystemVoid(long selfObjectId, long rendererObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceMask__UnityEngineRenderer__SystemUInt32__SystemVoid(long selfObjectId, long rendererObjectId, int maskConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__UpdateInstanceID__UnityEngineRenderer__SystemUInt32__SystemVoid(long selfObjectId, long rendererObjectId, int instanceIDConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetSize__SystemUInt64(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineExperimentalRenderingRayTracingAccelerationStructure__func__GetInstanceCount__SystemUInt32(long selfObjectId);

        #endregion Imports
    }
}
