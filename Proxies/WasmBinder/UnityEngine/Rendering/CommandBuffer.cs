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

    public partial class CommandBuffer(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public CommandBuffer()
            : this(internal_UnityEngineRenderingCommandBuffer__ctor()) { }

        public string name 
        {
            get => internal_UnityEngineRenderingCommandBuffer__get__name(WrappedId);
            set => internal_UnityEngineRenderingCommandBuffer__set__name(WrappedId, value);
        }

        public int sizeInBytes 
        {
            get => internal_UnityEngineRenderingCommandBuffer__get__sizeInBytes(WrappedId);
        }

        public void ConvertTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rendering.RenderTargetIdentifier dst)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, src, dst);
        }

        public void ConvertTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, src, srcElement, dst, dstElement);
        }

        public void WaitAllAsyncReadbackRequests()
        {
            internal_UnityEngineRenderingCommandBuffer__func__WaitAllAsyncReadbackRequests__SystemVoid(WrappedId);
        }

        public void RequestAsyncReadback(global::UnityEngine.ComputeBuffer src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.GraphicsBuffer src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.ComputeBuffer src, int size, int offset, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, size, offset, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.GraphicsBuffer src, int size, int offset, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, size, offset, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, global::UnityEngine.TextureFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, global::UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, x, width, y, height, z, depth, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::UnityEngine.TextureFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void RequestAsyncReadback(global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(WrappedId, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void SetInvertCulling(bool invertCulling)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetInvertCulling__SystemBoolean__SystemVoid(WrappedId, invertCulling);
        }

        public void SetComputeFloatParam(global::UnityEngine.ComputeShader computeShader, int nameID, float val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemInt32__SystemSingle__SystemVoid(WrappedId, computeShader, nameID, val);
        }

        public void SetComputeIntParam(global::UnityEngine.ComputeShader computeShader, int nameID, int val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, nameID, val);
        }

        public void SetComputeVectorParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, computeShader, nameID, val);
        }

        public void SetComputeVectorArrayParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, computeShader, nameID, values);
        }

        public void SetComputeMatrixParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, computeShader, nameID, val);
        }

        public void SetComputeMatrixArrayParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, computeShader, nameID, values);
        }

        public void SetRayTracingShaderPass(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string passName)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingShaderPass__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemVoid(WrappedId, rayTracingShader, passName);
        }

        public void Clear()
        {
            internal_UnityEngineRenderingCommandBuffer__func__Clear__SystemVoid(WrappedId);
        }

        public void ClearRandomWriteTargets()
        {
            internal_UnityEngineRenderingCommandBuffer__func__ClearRandomWriteTargets__SystemVoid(WrappedId);
        }

        public void SetViewport(global::UnityEngine.Rect pixelRect)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetViewport__UnityEngineRect__SystemVoid(WrappedId, pixelRect);
        }

        public void EnableScissorRect(global::UnityEngine.Rect scissor)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EnableScissorRect__UnityEngineRect__SystemVoid(WrappedId, scissor);
        }

        public void DisableScissorRect()
        {
            internal_UnityEngineRenderingCommandBuffer__func__DisableScissorRect__SystemVoid(WrappedId);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, antiAliasing);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format, readWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter, format);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(WrappedId, nameID, width, height, depthBuffer, filter);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, width, height, depthBuffer);
        }

        public void GetTemporaryRT(int nameID, int width, int height)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, width, height);
        }

        public void GetTemporaryRT(int nameID, global::UnityEngine.RenderTextureDescriptor desc, global::UnityEngine.FilterMode filter)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__UnityEngineFilterModeEnum__SystemVoid(WrappedId, nameID, desc, filter);
        }

        public void GetTemporaryRT(int nameID, global::UnityEngine.RenderTextureDescriptor desc)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__SystemVoid(WrappedId, nameID, desc);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, useDynamicScale);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, antiAliasing);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format, readWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter, format);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer, filter);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, width, height, slices, depthBuffer);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, width, height, slices);
        }

        public void ReleaseTemporaryRT(int nameID)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ReleaseTemporaryRT__SystemInt32__SystemVoid(WrappedId, nameID);
        }

        public void ClearRenderTarget(global::UnityEngine.Rendering.RTClearFlags clearFlags, global::UnityEngine.Color backgroundColor, float depth, uint stencil)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__UnityEngineRenderingRTClearFlagsEnum__UnityEngineColor__SystemSingle__SystemUInt32__SystemVoid(WrappedId, clearFlags, backgroundColor, depth, stencil);
        }

        public void ClearRenderTarget(bool clearDepth, bool clearColor, global::UnityEngine.Color backgroundColor)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemVoid(WrappedId, clearDepth, clearColor, backgroundColor);
        }

        public void ClearRenderTarget(bool clearDepth, bool clearColor, global::UnityEngine.Color backgroundColor, float depth)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemSingle__SystemVoid(WrappedId, clearDepth, clearColor, backgroundColor, depth);
        }

        public void SetGlobalFloat(int nameID, float value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalInt(int nameID, int value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalInteger(int nameID, int value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalVector(int nameID, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalColor(int nameID, global::UnityEngine.Color value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalMatrix(int nameID, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, value);
        }

        public void EnableShaderKeyword(string keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EnableShaderKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public void EnableKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void EnableKeyword(global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, material, in keyword);
        }

        public void EnableKeyword(global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, computeShader, in keyword);
        }

        public void DisableShaderKeyword(string keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DisableShaderKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public void DisableKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void DisableKeyword(global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, material, in keyword);
        }

        public void DisableKeyword(global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, computeShader, in keyword);
        }

        public void SetKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword, bool value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(WrappedId, in keyword, value);
        }

        public void SetKeyword(global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(WrappedId, material, in keyword, value);
        }

        public void SetKeyword(global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(WrappedId, computeShader, in keyword, value);
        }

        public void SetViewMatrix(global::UnityEngine.Matrix4x4 view)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetViewMatrix__UnityEngineMatrix4x4__SystemVoid(WrappedId, view);
        }

        public void SetProjectionMatrix(global::UnityEngine.Matrix4x4 proj)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetProjectionMatrix__UnityEngineMatrix4x4__SystemVoid(WrappedId, proj);
        }

        public void SetViewProjectionMatrices(global::UnityEngine.Matrix4x4 view, global::UnityEngine.Matrix4x4 proj)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetViewProjectionMatrices__UnityEngineMatrix4x4__UnityEngineMatrix4x4__SystemVoid(WrappedId, view, proj);
        }

        public void SetGlobalDepthBias(float bias, float slopeBias)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalDepthBias__SystemSingle__SystemSingle__SystemVoid(WrappedId, bias, slopeBias);
        }

        public void SetExecutionFlags(global::UnityEngine.Rendering.CommandBufferExecutionFlags flags)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetExecutionFlags__UnityEngineRenderingCommandBufferExecutionFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void SetGlobalFloatArray(int nameID, global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetGlobalVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetGlobalMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetLateLatchProjectionMatrices(global::UnityEngine.Matrix4x4[] projectionMat)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetLateLatchProjectionMatrices__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, projectionMat);
        }

        public void MarkLateLatchMatrixShaderPropertyID(global::UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
        {
            internal_UnityEngineRenderingCommandBuffer__func__MarkLateLatchMatrixShaderPropertyID__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemInt32__SystemVoid(WrappedId, matrixPropertyType, shaderPropertyID);
        }

        public void UnmarkLateLatchMatrix(global::UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType)
        {
            internal_UnityEngineRenderingCommandBuffer__func__UnmarkLateLatchMatrix__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemVoid(WrappedId, matrixPropertyType);
        }

        public void BeginSample(string name)
        {
            internal_UnityEngineRenderingCommandBuffer__func__BeginSample__SystemString__SystemVoid(WrappedId, name);
        }

        public void EndSample(string name)
        {
            internal_UnityEngineRenderingCommandBuffer__func__EndSample__SystemString__SystemVoid(WrappedId, name);
        }

        public void IncrementUpdateCount(global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            internal_UnityEngineRenderingCommandBuffer__func__IncrementUpdateCount__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, dest);
        }

        public void SetInstanceMultiplier(uint multiplier)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetInstanceMultiplier__SystemUInt32__SystemVoid(WrappedId, multiplier);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, rt);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt, global::UnityEngine.Rendering.RenderBufferLoadAction loadAction, global::UnityEngine.Rendering.RenderBufferStoreAction storeAction)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(WrappedId, rt, loadAction, storeAction);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(WrappedId, rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, rt, mipLevel);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.CubemapFace cubemapFace)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(WrappedId, rt, mipLevel, cubemapFace);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(WrappedId, rt, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, color, depth);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, color, depth, mipLevel);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(WrappedId, color, depth, mipLevel, cubemapFace);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(WrappedId, color, depth, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderTargetIdentifier depth, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(WrappedId, color, colorLoadAction, colorStoreAction, depth, depthLoadAction, depthStoreAction);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier[] colors, global::UnityEngine.Rendering.RenderTargetIdentifier depth)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, colors, depth);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetIdentifier[] colors, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(WrappedId, colors, depth, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(WrappedId, binding, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(global::UnityEngine.Rendering.RenderTargetBinding binding)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemVoid(WrappedId, binding);
        }

        public void SetBufferData(global::UnityEngine.ComputeBuffer buffer, global::System.Array data)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemVoid(WrappedId, buffer, data);
        }

        public void SetBufferData(global::UnityEngine.ComputeBuffer buffer, global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        public void SetBufferCounterValue(global::UnityEngine.ComputeBuffer buffer, uint counterValue)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(WrappedId, buffer, counterValue);
        }

        public void SetBufferData(global::UnityEngine.GraphicsBuffer buffer, global::System.Array data)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemVoid(WrappedId, buffer, data);
        }

        public void SetBufferData(global::UnityEngine.GraphicsBuffer buffer, global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        public void SetBufferCounterValue(global::UnityEngine.GraphicsBuffer buffer, uint counterValue)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(WrappedId, buffer, counterValue);
        }

        public void Dispose()
        {
            internal_UnityEngineRenderingCommandBuffer__func__Dispose__SystemVoid(WrappedId);
        }

        public void Release()
        {
            internal_UnityEngineRenderingCommandBuffer__func__Release__SystemVoid(WrappedId);
        }

        public global::UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
        {
            return internal_UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(WrappedId);
        }

        public global::UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            return internal_UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(WrappedId, stage);
        }

        public global::UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(global::UnityEngine.Rendering.GraphicsFenceType fenceType, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            return internal_UnityEngineRenderingCommandBuffer__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(WrappedId, fenceType, stage);
        }

        public void WaitOnAsyncGraphicsFence(global::UnityEngine.Rendering.GraphicsFence fence)
        {
            internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(WrappedId, fence);
        }

        public void WaitOnAsyncGraphicsFence(global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(WrappedId, fence, stage);
        }

        public void WaitOnAsyncGraphicsFence(global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageFlagsEnum__SystemVoid(WrappedId, fence, stage);
        }

        public void SetComputeFloatParam(global::UnityEngine.ComputeShader computeShader, string name, float val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemString__SystemSingle__SystemVoid(WrappedId, computeShader, name, val);
        }

        public void SetComputeIntParam(global::UnityEngine.ComputeShader computeShader, string name, int val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemString__SystemInt32__SystemVoid(WrappedId, computeShader, name, val);
        }

        public void SetComputeVectorParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemString__UnityEngineVector4__SystemVoid(WrappedId, computeShader, name, val);
        }

        public void SetComputeVectorArrayParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, computeShader, name, values);
        }

        public void SetComputeMatrixParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, computeShader, name, val);
        }

        public void SetComputeMatrixArrayParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, computeShader, name, values);
        }

        public void SetComputeFloatParams(global::UnityEngine.ComputeShader computeShader, string name, params global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemString__SystemSingleArray__SystemVoid(WrappedId, computeShader, name, values);
        }

        public void SetComputeFloatParams(global::UnityEngine.ComputeShader computeShader, int nameID, params global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, computeShader, nameID, values);
        }

        public void SetComputeIntParams(global::UnityEngine.ComputeShader computeShader, string name, params global::System.Int32[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemString__SystemInt32Array__SystemVoid(WrappedId, computeShader, name, values);
        }

        public void SetComputeIntParams(global::UnityEngine.ComputeShader computeShader, int nameID, params global::System.Int32[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemInt32__SystemInt32Array__SystemVoid(WrappedId, computeShader, nameID, values);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, computeShader, kernelIndex, name, rt);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, computeShader, kernelIndex, nameID, rt);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, computeShader, kernelIndex, name, rt, mipLevel);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, computeShader, kernelIndex, nameID, rt, mipLevel);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, computeShader, kernelIndex, name, rt, mipLevel, element);
        }

        public void SetComputeTextureParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, computeShader, kernelIndex, nameID, rt, mipLevel, element);
        }

        public void SetComputeBufferParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, computeShader, kernelIndex, nameID, buffer);
        }

        public void SetComputeBufferParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, computeShader, kernelIndex, name, buffer);
        }

        public void SetComputeBufferParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, computeShader, kernelIndex, nameID, buffer);
        }

        public void SetComputeBufferParam(global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, computeShader, kernelIndex, name, buffer);
        }

        public void SetComputeConstantBufferParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, nameID, buffer, offset, size);
        }

        public void SetComputeConstantBufferParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, name, buffer, offset, size);
        }

        public void SetComputeConstantBufferParam(global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, nameID, buffer, offset, size);
        }

        public void SetComputeConstantBufferParam(global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, name, buffer, offset, size);
        }

        public void DispatchCompute(global::UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
        }

        public void DispatchCompute(global::UnityEngine.ComputeShader computeShader, int kernelIndex, global::UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(WrappedId, computeShader, kernelIndex, indirectBuffer, argsOffset);
        }

        public void DispatchCompute(global::UnityEngine.ComputeShader computeShader, int kernelIndex, global::UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(WrappedId, computeShader, kernelIndex, indirectBuffer, argsOffset);
        }

        public void BuildRayTracingAccelerationStructure(global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            internal_UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(WrappedId, accelerationStructure);
        }

        public void BuildRayTracingAccelerationStructure(global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, global::UnityEngine.Vector3 relativeOrigin)
        {
            internal_UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__UnityEngineVector3__SystemVoid(WrappedId, accelerationStructure, relativeOrigin);
        }

        public void SetRayTracingAccelerationStructure(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(WrappedId, rayTracingShader, name, rayTracingAccelerationStructure);
        }

        public void SetRayTracingAccelerationStructure(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(WrappedId, rayTracingShader, nameID, rayTracingAccelerationStructure);
        }

        public void SetRayTracingBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, rayTracingShader, name, buffer);
        }

        public void SetRayTracingBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, rayTracingShader, nameID, buffer);
        }

        public void SetRayTracingConstantBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, rayTracingShader, nameID, buffer, offset, size);
        }

        public void SetRayTracingConstantBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, rayTracingShader, name, buffer, offset, size);
        }

        public void SetRayTracingConstantBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, rayTracingShader, nameID, buffer, offset, size);
        }

        public void SetRayTracingConstantBufferParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, rayTracingShader, name, buffer, offset, size);
        }

        public void SetRayTracingTextureParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, rayTracingShader, name, rt);
        }

        public void SetRayTracingTextureParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, rayTracingShader, nameID, rt);
        }

        public void SetRayTracingFloatParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, float val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingle__SystemVoid(WrappedId, rayTracingShader, name, val);
        }

        public void SetRayTracingFloatParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingle__SystemVoid(WrappedId, rayTracingShader, nameID, val);
        }

        public void SetRayTracingFloatParams(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingleArray__SystemVoid(WrappedId, rayTracingShader, name, values);
        }

        public void SetRayTracingFloatParams(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, rayTracingShader, nameID, values);
        }

        public void SetRayTracingIntParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, int val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32__SystemVoid(WrappedId, rayTracingShader, name, val);
        }

        public void SetRayTracingIntParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32__SystemVoid(WrappedId, rayTracingShader, nameID, val);
        }

        public void SetRayTracingIntParams(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params global::System.Int32[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32Array__SystemVoid(WrappedId, rayTracingShader, name, values);
        }

        public void SetRayTracingIntParams(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params global::System.Int32[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32Array__SystemVoid(WrappedId, rayTracingShader, nameID, values);
        }

        public void SetRayTracingVectorParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4__SystemVoid(WrappedId, rayTracingShader, name, val);
        }

        public void SetRayTracingVectorParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, rayTracingShader, nameID, val);
        }

        public void SetRayTracingVectorArrayParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, rayTracingShader, name, values);
        }

        public void SetRayTracingVectorArrayParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, rayTracingShader, nameID, values);
        }

        public void SetRayTracingMatrixParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, rayTracingShader, name, val);
        }

        public void SetRayTracingMatrixParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, rayTracingShader, nameID, val);
        }

        public void SetRayTracingMatrixArrayParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, rayTracingShader, name, values);
        }

        public void SetRayTracingMatrixArrayParam(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, rayTracingShader, nameID, values);
        }

        public void DispatchRays(global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DispatchRays__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemUInt32__SystemUInt32__SystemUInt32__UnityEngineCamera__SystemVoid(WrappedId, rayTracingShader, rayGenName, width, height, depth, camera);
        }

        public void GenerateMips(global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, rt);
        }

        public void GenerateMips(global::UnityEngine.RenderTexture rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderTexture__SystemVoid(WrappedId, rt);
        }

        public void ResolveAntiAliasedSurface(global::UnityEngine.RenderTexture rt, global::UnityEngine.RenderTexture target)
        {
            internal_UnityEngineRenderingCommandBuffer__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__UnityEngineRenderTexture__SystemVoid(WrappedId, rt, target);
        }

        public void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex, int shaderPass, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, mesh, matrix, material, submeshIndex, shaderPass, properties);
        }

        public void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex, int shaderPass)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(WrappedId, mesh, matrix, material, submeshIndex, shaderPass);
        }

        public void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(WrappedId, mesh, matrix, material, submeshIndex);
        }

        public void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemVoid(WrappedId, mesh, matrix, material);
        }

        public void DrawRenderer(global::UnityEngine.Renderer renderer, global::UnityEngine.Material material, int submeshIndex, int shaderPass)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(WrappedId, renderer, material, submeshIndex, shaderPass);
        }

        public void DrawRenderer(global::UnityEngine.Renderer renderer, global::UnityEngine.Material material, int submeshIndex)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemVoid(WrappedId, renderer, material, submeshIndex);
        }

        public void DrawRenderer(global::UnityEngine.Renderer renderer, global::UnityEngine.Material material)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemVoid(WrappedId, renderer, material);
        }

        public void DrawRendererList(global::UnityEngine.Rendering.RendererList rendererList)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawRendererList__UnityEngineRenderingRendererList__SystemVoid(WrappedId, rendererList);
        }

        public void DrawProcedural(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
        }

        public void DrawProcedural(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(WrappedId, matrix, material, shaderPass, topology, vertexCount, instanceCount);
        }

        public void DrawProcedural(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(WrappedId, matrix, material, shaderPass, topology, vertexCount);
        }

        public void DrawProcedural(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount, int instanceCount, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
        }

        public void DrawProcedural(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount, int instanceCount)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount);
        }

        public void DrawProcedural(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, indexCount);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, matrices, count, properties);
        }

        public void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices, int count)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, matrices, count);
        }

        public void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, matrices);
        }

        public void DrawMeshInstancedProcedural(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, count, properties);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);
        }

        public void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, mesh, submeshIndex, material, shaderPass, bufferWithArgs);
        }

        public void DrawOcclusionMesh(global::UnityEngine.RectInt normalizedCamViewport)
        {
            internal_UnityEngineRenderingCommandBuffer__func__DrawOcclusionMesh__UnityEngineRectInt__SystemVoid(WrappedId, normalizedCamViewport);
        }

        public void SetRandomWriteTarget(int index, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, index, rt);
        }

        public void SetRandomWriteTarget(int index, global::UnityEngine.ComputeBuffer buffer, bool preserveCounterValue)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(WrappedId, index, buffer, preserveCounterValue);
        }

        public void SetRandomWriteTarget(int index, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, index, buffer);
        }

        public void SetRandomWriteTarget(int index, global::UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(WrappedId, index, buffer, preserveCounterValue);
        }

        public void SetRandomWriteTarget(int index, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, index, buffer);
        }

        public void CopyCounterValue(global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, uint dstOffsetBytes)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(WrappedId, src, dst, dstOffsetBytes);
        }

        public void CopyCounterValue(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.ComputeBuffer dst, uint dstOffsetBytes)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(WrappedId, src, dst, dstOffsetBytes);
        }

        public void CopyCounterValue(global::UnityEngine.ComputeBuffer src, global::UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(WrappedId, src, dst, dstOffsetBytes);
        }

        public void CopyCounterValue(global::UnityEngine.GraphicsBuffer src, global::UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(WrappedId, src, dst, dstOffsetBytes);
        }

        public void CopyTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rendering.RenderTargetIdentifier dst)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, src, dst);
        }

        public void CopyTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(WrappedId, src, srcElement, dst, dstElement);
        }

        public void CopyTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(WrappedId, src, srcElement, srcMip, dst, dstElement, dstMip);
        }

        public void CopyTexture(global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
        }

        public void Blit(global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, source, dest);
        }

        public void Blit(global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(WrappedId, source, dest, scale, offset);
        }

        public void Blit(global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(WrappedId, source, dest, mat);
        }

        public void Blit(global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(WrappedId, source, dest, mat, pass);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, source, dest);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(WrappedId, source, dest, scale, offset);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(WrappedId, source, dest, mat);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(WrappedId, source, dest, mat, pass);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(WrappedId, source, dest, sourceDepthSlice, destDepthSlice);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(WrappedId, source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
        }

        public void Blit(global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(WrappedId, source, dest, mat, pass, destDepthSlice);
        }

        public void SetGlobalFloat(string name, float value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalInt(string name, int value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalInteger(string name, int value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalVector(string name, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalColor(string name, global::UnityEngine.Color value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalMatrix(string name, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalFloatArray(string propertyName, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, nameID, values);
        }

        public void SetGlobalFloatArray(string propertyName, global::System.Single[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalVectorArray(string propertyName, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetGlobalVectorArray(string propertyName, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalMatrixArray(string propertyName, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetGlobalMatrixArray(string propertyName, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, propertyName, values);
        }

        public void SetGlobalTexture(string name, global::UnityEngine.Rendering.RenderTargetIdentifier value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalTexture(int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalTexture(string name, global::UnityEngine.Rendering.RenderTargetIdentifier value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, name, value, element);
        }

        public void SetGlobalTexture(int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, nameID, value, element);
        }

        public void SetGlobalBuffer(string name, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalBuffer(int nameID, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalBuffer(string name, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetGlobalBuffer(int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetGlobalConstantBuffer(global::UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, nameID, offset, size);
        }

        public void SetGlobalConstantBuffer(global::UnityEngine.ComputeBuffer buffer, string name, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, name, offset, size);
        }

        public void SetGlobalConstantBuffer(global::UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, nameID, offset, size);
        }

        public void SetGlobalConstantBuffer(global::UnityEngine.GraphicsBuffer buffer, string name, int offset, int size)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(WrappedId, buffer, name, offset, size);
        }

        public void SetShadowSamplingMode(global::UnityEngine.Rendering.RenderTargetIdentifier shadowmap, global::UnityEngine.Rendering.ShadowSamplingMode mode)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetShadowSamplingMode__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingShadowSamplingModeEnum__SystemVoid(WrappedId, shadowmap, mode);
        }

        public void SetSinglePassStereo(global::UnityEngine.Rendering.SinglePassStereoMode mode)
        {
            internal_UnityEngineRenderingCommandBuffer__func__SetSinglePassStereo__UnityEngineRenderingSinglePassStereoModeEnum__SystemVoid(WrappedId, mode);
        }

        public void CopyBuffer(global::UnityEngine.GraphicsBuffer source, global::UnityEngine.GraphicsBuffer dest)
        {
            internal_UnityEngineRenderingCommandBuffer__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, source, dest);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingCommandBuffer__ctor()
        {
            return UnityEngineRenderingCommandBuffer__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineRenderingCommandBuffer__get__name(long selfObjectId)
        {
            char* namePointer = default;
            int nameWasmLength = default;
            UnityEngineRenderingCommandBuffer__get__name(selfObjectId, &namePointer, &nameWasmLength);
            string returnResult = new(namePointer, 0, nameWasmLength);
            Marshal.FreeHGlobal((IntPtr)namePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__set__name(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__set__name(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderingCommandBuffer__get__sizeInBytes(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingCommandBuffer__get__sizeInBytes(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rendering.RenderTargetIdentifier dst)
        {
            UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), Unsafe.AsPointer(ref dst));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement)
        {
            UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), srcElement, Unsafe.AsPointer(ref dst), dstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__WaitAllAsyncReadbackRequests__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__WaitAllAsyncReadbackRequests__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer src, int size, int offset, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, size, offset, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer src, int size, int offset, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, size, offset, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, global::UnityEngine.TextureFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, (int) dstFormat, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, global::UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, (int) dstFormat, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, x, width, y, height, z, depth, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::UnityEngine.TextureFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, x, width, y, height, z, depth, (int) dstFormat, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, global::UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Action<global::UnityEngine.Rendering.AsyncGPUReadbackRequest> is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(selfObjectId, src.WrappedId, mipIndex, x, width, y, height, z, depth, (int) dstFormat, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetInvertCulling__SystemBoolean__SystemVoid(long selfObjectId, bool invertCulling)
        {
            var invertCullingConverted = Unsafe.As<bool, int>(ref invertCulling);
            UnityEngineRenderingCommandBuffer__func__SetInvertCulling__SystemBoolean__SystemVoid(selfObjectId, invertCullingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, float val)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemInt32__SystemSingle__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, int val)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Vector4 val)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingShaderPass__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string passName)
        {
            fixed (char* passNamePointer = passName)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingShaderPass__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemVoid(selfObjectId, rayTracingShader.WrappedId, passNamePointer, passName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Clear__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__Clear__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ClearRandomWriteTargets__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__ClearRandomWriteTargets__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetViewport__UnityEngineRect__SystemVoid(long selfObjectId, global::UnityEngine.Rect pixelRect)
        {
            UnityEngineRenderingCommandBuffer__func__SetViewport__UnityEngineRect__SystemVoid(selfObjectId, Unsafe.AsPointer(ref pixelRect));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EnableScissorRect__UnityEngineRect__SystemVoid(long selfObjectId, global::UnityEngine.Rect scissor)
        {
            UnityEngineRenderingCommandBuffer__func__EnableScissorRect__UnityEngineRect__SystemVoid(selfObjectId, Unsafe.AsPointer(ref scissor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DisableScissorRect__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__DisableScissorRect__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, antiAliasing, enableRandomWriteConverted, (int) memorylessMode, useDynamicScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, antiAliasing, enableRandomWriteConverted, (int) memorylessMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, antiAliasing, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, antiAliasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing, enableRandomWriteConverted, (int) memorylessMode, useDynamicScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing, enableRandomWriteConverted, (int) memorylessMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format, (int) readWrite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, global::UnityEngine.FilterMode filter)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(selfObjectId, nameID, width, height, depthBuffer, (int) filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, depthBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.RenderTextureDescriptor desc, global::UnityEngine.FilterMode filter)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__UnityEngineFilterModeEnum__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref desc), (int) filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.RenderTextureDescriptor desc)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref desc));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, antiAliasing, enableRandomWriteConverted, useDynamicScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, antiAliasing, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, antiAliasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, (int) readWrite, antiAliasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format, (int) readWrite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter, global::UnityEngine.RenderTextureFormat format)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, global::UnityEngine.FilterMode filter)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer, (int) filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, slices, depthBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices)
        {
            UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, width, height, slices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ReleaseTemporaryRT__SystemInt32__SystemVoid(long selfObjectId, int nameID)
        {
            UnityEngineRenderingCommandBuffer__func__ReleaseTemporaryRT__SystemInt32__SystemVoid(selfObjectId, nameID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__UnityEngineRenderingRTClearFlagsEnum__UnityEngineColor__SystemSingle__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RTClearFlags clearFlags, global::UnityEngine.Color backgroundColor, float depth, uint stencil)
        {
            var stencilConverted = Unsafe.As<uint, int>(ref stencil);
            UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__UnityEngineRenderingRTClearFlagsEnum__UnityEngineColor__SystemSingle__SystemUInt32__SystemVoid(selfObjectId, (int) clearFlags, Unsafe.AsPointer(ref backgroundColor), depth, stencilConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemVoid(long selfObjectId, bool clearDepth, bool clearColor, global::UnityEngine.Color backgroundColor)
        {
            var clearDepthConverted = Unsafe.As<bool, int>(ref clearDepth);
            var clearColorConverted = Unsafe.As<bool, int>(ref clearColor);
            UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemVoid(selfObjectId, clearDepthConverted, clearColorConverted, Unsafe.AsPointer(ref backgroundColor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemSingle__SystemVoid(long selfObjectId, bool clearDepth, bool clearColor, global::UnityEngine.Color backgroundColor, float depth)
        {
            var clearDepthConverted = Unsafe.As<bool, int>(ref clearDepth);
            var clearColorConverted = Unsafe.As<bool, int>(ref clearColor);
            UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemSingle__SystemVoid(selfObjectId, clearDepthConverted, clearColorConverted, Unsafe.AsPointer(ref backgroundColor), depth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4 value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Color value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4 value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EnableShaderKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineRenderingCommandBuffer__func__EnableShaderKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, material.WrappedId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, computeShader.WrappedId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DisableShaderKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineRenderingCommandBuffer__func__DisableShaderKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, material.WrappedId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, computeShader.WrappedId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.GlobalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(selfObjectId, keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Material material, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(selfObjectId, material.WrappedId, keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(selfObjectId, computeShader.WrappedId, keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetViewMatrix__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 view)
        {
            UnityEngineRenderingCommandBuffer__func__SetViewMatrix__UnityEngineMatrix4x4__SystemVoid(selfObjectId, Unsafe.AsPointer(ref view));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetProjectionMatrix__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 proj)
        {
            UnityEngineRenderingCommandBuffer__func__SetProjectionMatrix__UnityEngineMatrix4x4__SystemVoid(selfObjectId, Unsafe.AsPointer(ref proj));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetViewProjectionMatrices__UnityEngineMatrix4x4__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 view, global::UnityEngine.Matrix4x4 proj)
        {
            UnityEngineRenderingCommandBuffer__func__SetViewProjectionMatrices__UnityEngineMatrix4x4__UnityEngineMatrix4x4__SystemVoid(selfObjectId, Unsafe.AsPointer(ref view), Unsafe.AsPointer(ref proj));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalDepthBias__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float bias, float slopeBias)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalDepthBias__SystemSingle__SystemSingle__SystemVoid(selfObjectId, bias, slopeBias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetExecutionFlags__UnityEngineRenderingCommandBufferExecutionFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CommandBufferExecutionFlags flags)
        {
            UnityEngineRenderingCommandBuffer__func__SetExecutionFlags__UnityEngineRenderingCommandBufferExecutionFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetLateLatchProjectionMatrices__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4[] projectionMat)
        {
            fixed (global::UnityEngine.Matrix4x4* projectionMatPointer = projectionMat)
            {
                UnityEngineRenderingCommandBuffer__func__SetLateLatchProjectionMatrices__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, projectionMatPointer, projectionMat.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__MarkLateLatchMatrixShaderPropertyID__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
        {
            UnityEngineRenderingCommandBuffer__func__MarkLateLatchMatrixShaderPropertyID__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemInt32__SystemVoid(selfObjectId, (int) matrixPropertyType, shaderPropertyID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__UnmarkLateLatchMatrix__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType)
        {
            UnityEngineRenderingCommandBuffer__func__UnmarkLateLatchMatrix__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemVoid(selfObjectId, (int) matrixPropertyType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__BeginSample__SystemString__SystemVoid(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__BeginSample__SystemString__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__EndSample__SystemString__SystemVoid(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__EndSample__SystemString__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__IncrementUpdateCount__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            UnityEngineRenderingCommandBuffer__func__IncrementUpdateCount__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref dest));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetInstanceMultiplier__SystemUInt32__SystemVoid(long selfObjectId, uint multiplier)
        {
            var multiplierConverted = Unsafe.As<uint, int>(ref multiplier);
            UnityEngineRenderingCommandBuffer__func__SetInstanceMultiplier__SystemUInt32__SystemVoid(selfObjectId, multiplierConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt, global::UnityEngine.Rendering.RenderBufferLoadAction loadAction, global::UnityEngine.Rendering.RenderBufferStoreAction storeAction)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt), (int) loadAction, (int) storeAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt), (int) colorLoadAction, (int) colorStoreAction, (int) depthLoadAction, (int) depthStoreAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.CubemapFace cubemapFace)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt), mipLevel, (int) cubemapFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt), mipLevel, (int) cubemapFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel, (int) cubemapFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel, (int) cubemapFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier color, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderTargetIdentifier depth, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref color), (int) colorLoadAction, (int) colorStoreAction, Unsafe.AsPointer(ref depth), (int) depthLoadAction, (int) depthStoreAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier[] colors, global::UnityEngine.Rendering.RenderTargetIdentifier depth)
        {
            fixed (global::UnityEngine.Rendering.RenderTargetIdentifier* colorsPointer = colors)
            {
                UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, colorsPointer, colors.Length, Unsafe.AsPointer(ref depth));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier[] colors, global::UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            fixed (global::UnityEngine.Rendering.RenderTargetIdentifier* colorsPointer = colors)
            {
                UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(selfObjectId, colorsPointer, colors.Length, Unsafe.AsPointer(ref depth), mipLevel, (int) cubemapFace, depthSlice);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, global::UnityEngine.CubemapFace cubemapFace, int depthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(selfObjectId, binding.WrappedId, mipLevel, (int) cubemapFace, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetBinding binding)
        {
            UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemVoid(selfObjectId, binding.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer buffer, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemVoid(selfObjectId, buffer.WrappedId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer buffer, global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, 0 /* Todo: Fix this */, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer buffer, uint counterValue)
        {
            var counterValueConverted = Unsafe.As<uint, int>(ref counterValue);
            UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(selfObjectId, buffer.WrappedId, counterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer buffer, global::System.Array data)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemVoid(selfObjectId, buffer.WrappedId, 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer buffer, global::System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Array is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, 0 /* Todo: Fix this */, managedBufferStartIndex, graphicsBufferStartIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer buffer, uint counterValue)
        {
            var counterValueConverted = Unsafe.As<uint, int>(ref counterValue);
            UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(selfObjectId, buffer.WrappedId, counterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Dispose__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__Dispose__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Release__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderingCommandBuffer__func__Release__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(long selfObjectId)
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(selfObjectId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(long selfObjectId, global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(selfObjectId, (int) stage, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineRenderingCommandBuffer__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(long selfObjectId, global::UnityEngine.Rendering.GraphicsFenceType fenceType, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineRenderingCommandBuffer__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(selfObjectId, (int) fenceType, (int) stage, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.GraphicsFence fence)
        {
            UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(selfObjectId, Unsafe.AsPointer(ref fence));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref fence), (int) stage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageFlagsEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref fence), (int) stage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemString__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, float val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemString__SystemSingle__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemString__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, int val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemString__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Vector4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Matrix4x4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemString__SystemSingleArray__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::System.Int32[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (int* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemString__SystemInt32Array__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemInt32__SystemInt32Array__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref rt));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, nameID, Unsafe.AsPointer(ref rt));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref rt), mipLevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, nameID, Unsafe.AsPointer(ref rt), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref rt), mipLevel, (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, nameID, Unsafe.AsPointer(ref rt), mipLevel, (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
        {
            UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, global::UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset)
        {
            var argsOffsetConverted = Unsafe.As<uint, int>(ref argsOffset);
            UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, indirectBuffer.WrappedId, argsOffsetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeShader computeShader, int kernelIndex, global::UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset)
        {
            var argsOffsetConverted = Unsafe.As<uint, int>(ref argsOffset);
            UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(selfObjectId, computeShader.WrappedId, kernelIndex, indirectBuffer.WrappedId, argsOffsetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(selfObjectId, accelerationStructure.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, global::UnityEngine.Vector3 relativeOrigin)
        {
            UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__UnityEngineVector3__SystemVoid(selfObjectId, accelerationStructure.WrappedId, Unsafe.AsPointer(ref relativeOrigin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), rayTracingAccelerationStructure.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, rayTracingAccelerationStructure.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref rt));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, Unsafe.AsPointer(ref rt));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, float val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingle__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingle__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingleArray__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, int val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::System.Int32[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (int* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Vector4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Vector4 val)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Matrix4x4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, rayTracingShader.WrappedId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DispatchRays__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemUInt32__SystemUInt32__SystemUInt32__UnityEngineCamera__SystemVoid(long selfObjectId, global::UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, global::UnityEngine.Camera camera)
        {
            fixed (char* rayGenNamePointer = rayGenName)
            {
                var widthConverted = Unsafe.As<uint, int>(ref width);
                var heightConverted = Unsafe.As<uint, int>(ref height);
                var depthConverted = Unsafe.As<uint, int>(ref depth);
                UnityEngineRenderingCommandBuffer__func__DispatchRays__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemUInt32__SystemUInt32__SystemUInt32__UnityEngineCamera__SystemVoid(selfObjectId, rayTracingShader.WrappedId, rayGenNamePointer, rayGenName.Length * sizeof(char), widthConverted, heightConverted, depthConverted, camera.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rt));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderTexture__SystemVoid(long selfObjectId, global::UnityEngine.RenderTexture rt)
        {
            UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderTexture__SystemVoid(selfObjectId, rt.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__UnityEngineRenderTexture__SystemVoid(long selfObjectId, global::UnityEngine.RenderTexture rt, global::UnityEngine.RenderTexture target)
        {
            UnityEngineRenderingCommandBuffer__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__UnityEngineRenderTexture__SystemVoid(selfObjectId, rt.WrappedId, target.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex, int shaderPass, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, submeshIndex, shaderPass, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex, int shaderPass)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(selfObjectId, mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, submeshIndex, shaderPass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int submeshIndex)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(selfObjectId, mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, submeshIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemVoid(selfObjectId, mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer, global::UnityEngine.Material material, int submeshIndex, int shaderPass)
        {
            UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(selfObjectId, renderer.WrappedId, material.WrappedId, submeshIndex, shaderPass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer, global::UnityEngine.Material material, int submeshIndex)
        {
            UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemVoid(selfObjectId, renderer.WrappedId, material.WrappedId, submeshIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemVoid(long selfObjectId, global::UnityEngine.Renderer renderer, global::UnityEngine.Material material)
        {
            UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemVoid(selfObjectId, renderer.WrappedId, material.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawRendererList__UnityEngineRenderingRendererList__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RendererList rendererList)
        {
            UnityEngineRenderingCommandBuffer__func__DrawRendererList__UnityEngineRenderingRendererList__SystemVoid(selfObjectId, Unsafe.AsPointer(ref rendererList));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, vertexCount, instanceCount, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, vertexCount, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int vertexCount)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, vertexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount, int instanceCount, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, indexCount, instanceCount, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount, int instanceCount)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, indexCount, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, int indexCount)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, indexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, indexBuffer.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, shaderPass, (int) topology, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, matricesPointer, matrices.Length, count, properties.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices, int count)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, matricesPointer, matrices.Length, count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.Matrix4x4[] matrices)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, matricesPointer, matrices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, count, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.ComputeBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId, argsOffset, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, int shaderPass, global::UnityEngine.GraphicsBuffer bufferWithArgs)
        {
            UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, mesh.WrappedId, submeshIndex, material.WrappedId, shaderPass, bufferWithArgs.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__DrawOcclusionMesh__UnityEngineRectInt__SystemVoid(long selfObjectId, global::UnityEngine.RectInt normalizedCamViewport)
        {
            UnityEngineRenderingCommandBuffer__func__DrawOcclusionMesh__UnityEngineRectInt__SystemVoid(selfObjectId, Unsafe.AsPointer(ref normalizedCamViewport));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, int index, global::UnityEngine.Rendering.RenderTargetIdentifier rt)
        {
            UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, index, Unsafe.AsPointer(ref rt));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(long selfObjectId, int index, global::UnityEngine.ComputeBuffer buffer, bool preserveCounterValue)
        {
            var preserveCounterValueConverted = Unsafe.As<bool, int>(ref preserveCounterValue);
            UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(selfObjectId, index, buffer.WrappedId, preserveCounterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int index, global::UnityEngine.ComputeBuffer buffer)
        {
            UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, index, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(long selfObjectId, int index, global::UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue)
        {
            var preserveCounterValueConverted = Unsafe.As<bool, int>(ref preserveCounterValue);
            UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(selfObjectId, index, buffer.WrappedId, preserveCounterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int index, global::UnityEngine.GraphicsBuffer buffer)
        {
            UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, index, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer src, global::UnityEngine.ComputeBuffer dst, uint dstOffsetBytes)
        {
            var dstOffsetBytesConverted = Unsafe.As<uint, int>(ref dstOffsetBytes);
            UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(selfObjectId, src.WrappedId, dst.WrappedId, dstOffsetBytesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer src, global::UnityEngine.ComputeBuffer dst, uint dstOffsetBytes)
        {
            var dstOffsetBytesConverted = Unsafe.As<uint, int>(ref dstOffsetBytes);
            UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(selfObjectId, src.WrappedId, dst.WrappedId, dstOffsetBytesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer src, global::UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes)
        {
            var dstOffsetBytesConverted = Unsafe.As<uint, int>(ref dstOffsetBytes);
            UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(selfObjectId, src.WrappedId, dst.WrappedId, dstOffsetBytesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer src, global::UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes)
        {
            var dstOffsetBytesConverted = Unsafe.As<uint, int>(ref dstOffsetBytes);
            UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(selfObjectId, src.WrappedId, dst.WrappedId, dstOffsetBytesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rendering.RenderTargetIdentifier dst)
        {
            UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), Unsafe.AsPointer(ref dst));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement)
        {
            UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), srcElement, Unsafe.AsPointer(ref dst), dstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip)
        {
            UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), srcElement, srcMip, Unsafe.AsPointer(ref dst), dstElement, dstMip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, global::UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
        {
            UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, Unsafe.AsPointer(ref dst), dstElement, dstMip, dstX, dstY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, source.WrappedId, Unsafe.AsPointer(ref dest));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(long selfObjectId, global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(selfObjectId, source.WrappedId, Unsafe.AsPointer(ref dest), Unsafe.AsPointer(ref scale), Unsafe.AsPointer(ref offset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(long selfObjectId, global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(selfObjectId, source.WrappedId, Unsafe.AsPointer(ref dest), mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Texture source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(selfObjectId, source.WrappedId, Unsafe.AsPointer(ref dest), mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), Unsafe.AsPointer(ref scale), Unsafe.AsPointer(ref offset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), sourceDepthSlice, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), Unsafe.AsPointer(ref scale), Unsafe.AsPointer(ref offset), sourceDepthSlice, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier dest, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), Unsafe.AsPointer(ref dest), mat.WrappedId, pass, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, string name, global::UnityEngine.Color value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, string propertyName, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, string propertyName, global::System.Single[] values)
        {
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, string propertyName, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, string propertyName, global::UnityEngine.Vector4[] values)
        {
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string propertyName, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, string propertyName, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* propertyNamePointer = propertyName)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, string name, global::UnityEngine.Rendering.RenderTargetIdentifier value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, string name, global::UnityEngine.Rendering.RenderTargetIdentifier value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value), (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Rendering.RenderTargetIdentifier value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value), (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, nameID, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.ComputeBuffer buffer, string name, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, namePointer, name.Length * sizeof(char), offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size)
        {
            UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, nameID, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer buffer, string name, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(selfObjectId, buffer.WrappedId, namePointer, name.Length * sizeof(char), offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetShadowSamplingMode__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingShadowSamplingModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier shadowmap, global::UnityEngine.Rendering.ShadowSamplingMode mode)
        {
            UnityEngineRenderingCommandBuffer__func__SetShadowSamplingMode__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingShadowSamplingModeEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref shadowmap), (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__SetSinglePassStereo__UnityEngineRenderingSinglePassStereoModeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.SinglePassStereoMode mode)
        {
            UnityEngineRenderingCommandBuffer__func__SetSinglePassStereo__UnityEngineRenderingSinglePassStereoModeEnum__SystemVoid(selfObjectId, (int) mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingCommandBuffer__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, global::UnityEngine.GraphicsBuffer source, global::UnityEngine.GraphicsBuffer dest)
        {
            UnityEngineRenderingCommandBuffer__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, source.WrappedId, dest.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderingCommandBuffer__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__get__name(long selfObjectId, void* namePointer, void* nameWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__set__name(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingCommandBuffer__get__sizeInBytes(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* srcPointer, void* dstPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__ConvertTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, void* srcPointer, int srcElement, void* dstPointer, int dstElement);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__WaitAllAsyncReadbackRequests__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineComputeBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int size, int offset, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int size, int offset, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, int dstFormatUnderlyingValue, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, int dstFormatUnderlyingValue, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, int x, int width, int y, int height, int z, int depth, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, int x, int width, int y, int height, int z, int depth, int dstFormatUnderlyingValue, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__RequestAsyncReadback__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__System_Action_UnityEngineRenderingAsyncGPUReadbackRequest__SystemVoid(long selfObjectId, long srcObjectId, int mipIndex, int x, int width, int y, int height, int z, int depth, int dstFormatUnderlyingValue, long callbackObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetInvertCulling__SystemBoolean__SystemVoid(long selfObjectId, int invertCullingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingShaderPass__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* passNamePointer, int passNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__Clear__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__ClearRandomWriteTargets__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetViewport__UnityEngineRect__SystemVoid(long selfObjectId, void* pixelRectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__EnableScissorRect__UnityEngineRect__SystemVoid(long selfObjectId, void* scissorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DisableScissorRect__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing, int enableRandomWriteConverted, int memorylessModeUnderlyingValue, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing, int enableRandomWriteConverted, int memorylessModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int enableRandomWriteConverted, int memorylessModeUnderlyingValue, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__UnityEngineRenderTextureMemorylessEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int enableRandomWriteConverted, int memorylessModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer, int filterUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int depthBuffer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, void* descPointer, int filterUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__GetTemporaryRT__SystemInt32__UnityEngineRenderTextureDescriptor__SystemVoid(long selfObjectId, int nameID, void* descPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing, int enableRandomWriteConverted, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue, int readWriteUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__UnityEngineRenderTextureFormatEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineFilterModeEnum__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer, int filterUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices, int depthBuffer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GetTemporaryRTArray__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int width, int height, int slices);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__ReleaseTemporaryRT__SystemInt32__SystemVoid(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__UnityEngineRenderingRTClearFlagsEnum__UnityEngineColor__SystemSingle__SystemUInt32__SystemVoid(long selfObjectId, int clearFlagsUnderlyingValue, void* backgroundColorPointer, float depth, int stencilConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemVoid(long selfObjectId, int clearDepthConverted, int clearColorConverted, void* backgroundColorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__ClearRenderTarget__SystemBoolean__SystemBoolean__UnityEngineColor__SystemSingle__SystemVoid(long selfObjectId, int clearDepthConverted, int clearColorConverted, void* backgroundColorPointer, float depth);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__EnableShaderKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long materialObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__EnableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long computeShaderObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DisableShaderKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long materialObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DisableKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long computeShaderObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineMaterial__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, long materialObjectId, long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetKeyword__UnityEngineComputeShader__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, long computeShaderObjectId, long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetViewMatrix__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* viewPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetProjectionMatrix__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* projPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetViewProjectionMatrices__UnityEngineMatrix4x4__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* viewPointer, void* projPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalDepthBias__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float bias, float slopeBias);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetExecutionFlags__UnityEngineRenderingCommandBufferExecutionFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetLateLatchProjectionMatrices__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* projectionMatPointer, int projectionMatWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__MarkLateLatchMatrixShaderPropertyID__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemInt32__SystemVoid(long selfObjectId, int matrixPropertyTypeUnderlyingValue, int shaderPropertyID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__UnmarkLateLatchMatrix__UnityEngineRenderingCameraLateLatchMatrixTypeEnum__SystemVoid(long selfObjectId, int matrixPropertyTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__BeginSample__SystemString__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__EndSample__SystemString__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__IncrementUpdateCount__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* destPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetInstanceMultiplier__SystemUInt32__SystemVoid(long selfObjectId, int multiplierConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, void* rtPointer, int loadActionUnderlyingValue, int storeActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, void* rtPointer, int colorLoadActionUnderlyingValue, int colorStoreActionUnderlyingValue, int depthLoadActionUnderlyingValue, int depthStoreActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, void* rtPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, void* rtPointer, int mipLevel, int cubemapFaceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, void* rtPointer, int mipLevel, int cubemapFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* colorPointer, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, void* colorPointer, void* depthPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, void* colorPointer, void* depthPointer, int mipLevel, int cubemapFaceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, void* colorPointer, void* depthPointer, int mipLevel, int cubemapFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__SystemVoid(long selfObjectId, void* colorPointer, int colorLoadActionUnderlyingValue, int colorStoreActionUnderlyingValue, void* depthPointer, int depthLoadActionUnderlyingValue, int depthStoreActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, void* depthPointer, int mipLevel, int cubemapFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, long bindingObjectId, int mipLevel, int cubemapFaceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRenderTarget__UnityEngineRenderingRenderTargetBinding__SystemVoid(long selfObjectId, long bindingObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemVoid(long selfObjectId, long bufferObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineComputeBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, long dataObjectId, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, long bufferObjectId, int counterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemVoid(long selfObjectId, long bufferObjectId, long dataObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferData__UnityEngineGraphicsBuffer__SystemArray__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, long dataObjectId, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetBufferCounterValue__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, long bufferObjectId, int counterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__Dispose__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__Release__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(long selfObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(long selfObjectId, int stageUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(long selfObjectId, int fenceTypeUnderlyingValue, int stageUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(long selfObjectId, void* fencePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(long selfObjectId, void* fencePointer, int stageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageFlagsEnum__SystemVoid(long selfObjectId, void* fencePointer, int stageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeFloatParam__UnityEngineComputeShader__SystemString__SystemSingle__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeIntParam__UnityEngineComputeShader__SystemString__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeVectorParam__UnityEngineComputeShader__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeVectorArrayParam__UnityEngineComputeShader__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeMatrixParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeMatrixArrayParam__UnityEngineComputeShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeFloatParams__UnityEngineComputeShader__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeIntParams__UnityEngineComputeShader__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, void* namePointer, int nameWasmLength, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int nameID, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, void* namePointer, int nameWasmLength, void* rtPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int nameID, void* rtPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, void* namePointer, int nameWasmLength, void* rtPointer, int mipLevel, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeTextureParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int nameID, void* rtPointer, int mipLevel, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeBufferParam__UnityEngineComputeShader__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetComputeConstantBufferParam__UnityEngineComputeShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, long indirectBufferObjectId, int argsOffsetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DispatchCompute__UnityEngineComputeShader__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, long computeShaderObjectId, int kernelIndex, long indirectBufferObjectId, int argsOffsetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, long accelerationStructureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__BuildRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__UnityEngineVector3__SystemVoid(long selfObjectId, long accelerationStructureObjectId, void* relativeOriginPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, long rayTracingAccelerationStructureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingAccelerationStructure__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, long rayTracingAccelerationStructureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingConstantBufferParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingTextureParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingle__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingFloatParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingIntParams__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingVectorArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRayTracingMatrixArrayParam__UnityEngineExperimentalRenderingRayTracingShader__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DispatchRays__UnityEngineExperimentalRenderingRayTracingShader__SystemString__SystemUInt32__SystemUInt32__SystemUInt32__UnityEngineCamera__SystemVoid(long selfObjectId, long rayTracingShaderObjectId, void* rayGenNamePointer, int rayGenNameWasmLength, int widthConverted, int heightConverted, int depthConverted, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__GenerateMips__UnityEngineRenderTexture__SystemVoid(long selfObjectId, long rtObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__UnityEngineRenderTexture__SystemVoid(long selfObjectId, long rtObjectId, long targetObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long meshObjectId, void* matrixPointer, long materialObjectId, int submeshIndex, int shaderPass, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, void* matrixPointer, long materialObjectId, int submeshIndex, int shaderPass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, void* matrixPointer, long materialObjectId, int submeshIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemVoid(long selfObjectId, long meshObjectId, void* matrixPointer, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long rendererObjectId, long materialObjectId, int submeshIndex, int shaderPass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, long rendererObjectId, long materialObjectId, int submeshIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawRenderer__UnityEngineRenderer__UnityEngineMaterial__SystemVoid(long selfObjectId, long rendererObjectId, long materialObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawRendererList__UnityEngineRenderingRendererList__SystemVoid(long selfObjectId, void* rendererListPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int vertexCount, int instanceCount, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int vertexCount, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int vertexCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int indexCount, int instanceCount, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int indexCount, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProcedural__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, int indexCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawProceduralIndirect__UnityEngineGraphicsBuffer__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, long indexBufferObjectId, void* matrixPointer, long materialObjectId, int shaderPass, int topologyUnderlyingValue, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, void* matricesPointer, int matricesWasmLength, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, void* matricesPointer, int matricesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, int count, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, long meshObjectId, int submeshIndex, long materialObjectId, int shaderPass, long bufferWithArgsObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__DrawOcclusionMesh__UnityEngineRectInt__SystemVoid(long selfObjectId, void* normalizedCamViewportPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, int index, void* rtPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(long selfObjectId, int index, long bufferObjectId, int preserveCounterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int index, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(long selfObjectId, int index, long bufferObjectId, int preserveCounterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int index, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, long srcObjectId, long dstObjectId, int dstOffsetBytesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, long srcObjectId, long dstObjectId, int dstOffsetBytesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineComputeBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, long srcObjectId, long dstObjectId, int dstOffsetBytesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__CopyCounterValue__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, long srcObjectId, long dstObjectId, int dstOffsetBytesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* srcPointer, void* dstPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemVoid(long selfObjectId, void* srcPointer, int srcElement, void* dstPointer, int dstElement);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* srcPointer, int srcElement, int srcMip, void* dstPointer, int dstElement, int dstMip);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__CopyTexture__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* srcPointer, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, void* dstPointer, int dstElement, int dstMip, int dstX, int dstY);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, long sourceObjectId, void* destPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(long selfObjectId, long sourceObjectId, void* destPointer, void* scalePointer, void* offsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(long selfObjectId, long sourceObjectId, void* destPointer, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineTexture__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, long sourceObjectId, void* destPointer, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, void* scalePointer, void* offsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, int sourceDepthSlice, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, void* scalePointer, void* offsetPointer, int sourceDepthSlice, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__Blit__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTargetIdentifier__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourcePointer, void* destPointer, long matObjectId, int pass, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemString__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalTexture__SystemInt32__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, void* valuePointer, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, int nameID, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineComputeBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, void* namePointer, int nameWasmLength, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, int nameID, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetGlobalConstantBuffer__UnityEngineGraphicsBuffer__SystemString__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, long bufferObjectId, void* namePointer, int nameWasmLength, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingCommandBuffer__func__SetShadowSamplingMode__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingShadowSamplingModeEnum__SystemVoid(long selfObjectId, void* shadowmapPointer, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__SetSinglePassStereo__UnityEngineRenderingSinglePassStereoModeEnum__SystemVoid(long selfObjectId, int modeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingCommandBuffer__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, long sourceObjectId, long destObjectId);

        #endregion Imports
    }
}
