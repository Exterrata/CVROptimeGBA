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

    public partial class Graphics(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Graphics()
            : this(internal_UnityEngineGraphics__ctor()) { }

        public static global::UnityEngine.ColorGamut activeColorGamut 
        {
            get => internal_UnityEngineGraphics__get__activeColorGamut();
        }

        public static global::UnityEngine.Rendering.GraphicsTier activeTier 
        {
            get => internal_UnityEngineGraphics__get__activeTier();
            set => internal_UnityEngineGraphics__set__activeTier(value);
        }

        public static bool preserveFramebufferAlpha 
        {
            get => internal_UnityEngineGraphics__get__preserveFramebufferAlpha();
        }

        public static global::UnityEngine.Rendering.OpenGLESVersion minOpenGLESVersion 
        {
            get => internal_UnityEngineGraphics__get__minOpenGLESVersion();
        }

        public static global::UnityEngine.RenderBuffer activeColorBuffer 
        {
            get => internal_UnityEngineGraphics__get__activeColorBuffer();
        }

        public static global::UnityEngine.RenderBuffer activeDepthBuffer 
        {
            get => internal_UnityEngineGraphics__get__activeDepthBuffer();
        }

        public static void ClearRandomWriteTargets()
        {
            internal_UnityEngineGraphics__func__ClearRandomWriteTargets__SystemVoid();
        }

        public static void ExecuteCommandBuffer(global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            internal_UnityEngineGraphics__func__ExecuteCommandBuffer__UnityEngineRenderingCommandBuffer__SystemVoid(buffer);
        }

        public static void ExecuteCommandBufferAsync(global::UnityEngine.Rendering.CommandBuffer buffer, global::UnityEngine.Rendering.ComputeQueueType queueType)
        {
            internal_UnityEngineGraphics__func__ExecuteCommandBufferAsync__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(buffer, queueType);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderTexture rt, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(rt, mipLevel, face, depthSlice);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderBuffer[] colorBuffers, global::UnityEngine.RenderBuffer depthBuffer)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(colorBuffers, depthBuffer);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderTargetSetup setup)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTargetSetup__SystemVoid(setup);
        }

        public static void SetRandomWriteTarget(int index, global::UnityEngine.RenderTexture uav)
        {
            internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderTexture__SystemVoid(index, uav);
        }

        public static void SetRandomWriteTarget(int index, global::UnityEngine.ComputeBuffer uav, bool preserveCounterValue)
        {
            internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(index, uav, preserveCounterValue);
        }

        public static void SetRandomWriteTarget(int index, global::UnityEngine.GraphicsBuffer uav, bool preserveCounterValue)
        {
            internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(index, uav, preserveCounterValue);
        }

        public static void CopyTexture(global::UnityEngine.Texture src, global::UnityEngine.Texture dst)
        {
            internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__UnityEngineTexture__SystemVoid(src, dst);
        }

        public static void CopyTexture(global::UnityEngine.Texture src, int srcElement, global::UnityEngine.Texture dst, int dstElement)
        {
            internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(src, srcElement, dst, dstElement);
        }

        public static void CopyTexture(global::UnityEngine.Texture src, int srcElement, int srcMip, global::UnityEngine.Texture dst, int dstElement, int dstMip)
        {
            internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemVoid(src, srcElement, srcMip, dst, dstElement, dstMip);
        }

        public static void CopyTexture(global::UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, global::UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY)
        {
            internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
        }

        public static bool ConvertTexture(global::UnityEngine.Texture src, global::UnityEngine.Texture dst)
        {
            return internal_UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__UnityEngineTexture__SystemBoolean(src, dst);
        }

        public static bool ConvertTexture(global::UnityEngine.Texture src, int srcElement, global::UnityEngine.Texture dst, int dstElement)
        {
            return internal_UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemBoolean(src, srcElement, dst, dstElement);
        }

        public static global::UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            return internal_UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(stage);
        }

        public static global::UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
        {
            return internal_UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence();
        }

        public static global::UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(global::UnityEngine.Rendering.GraphicsFenceType fenceType, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            return internal_UnityEngineGraphics__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(fenceType, stage);
        }

        public static void WaitOnAsyncGraphicsFence(global::UnityEngine.Rendering.GraphicsFence fence)
        {
            internal_UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(fence);
        }

        public static void WaitOnAsyncGraphicsFence(global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            internal_UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(fence, stage);
        }

        public static void CopyBuffer(global::UnityEngine.GraphicsBuffer source, global::UnityEngine.GraphicsBuffer dest)
        {
            internal_UnityEngineGraphics__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(source, dest);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemInt32__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(screenRect, texture, mat, pass);
        }

        public static void RenderMesh(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Matrix4x4 objectToWorld, global::UnityEngine.Matrix4x4? prevObjectToWorld)
        {
            internal_UnityEngineGraphics__func__RenderMesh__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__UnityEngineMatrix4x4__System_Nullable_UnityEngineMatrix4x4__SystemVoid(in rparams, mesh, submeshIndex, objectToWorld, prevObjectToWorld);
        }

        public static void RenderMeshIndirect(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            internal_UnityEngineGraphics__func__RenderMeshIndirect__UnityEngineRenderParamsRef__UnityEngineMesh__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in rparams, mesh, commandBuffer, commandCount, startCommand);
        }

        public static void RenderMeshPrimitives(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, int submeshIndex, int instanceCount)
        {
            internal_UnityEngineGraphics__func__RenderMeshPrimitives__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__SystemInt32__SystemVoid(in rparams, mesh, submeshIndex, instanceCount);
        }

        public static void RenderPrimitives(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            internal_UnityEngineGraphics__func__RenderPrimitives__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(in rparams, topology, vertexCount, instanceCount);
        }

        public static void RenderPrimitivesIndexed(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int startIndex, int instanceCount)
        {
            internal_UnityEngineGraphics__func__RenderPrimitivesIndexed__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(in rparams, topology, indexBuffer, indexCount, startIndex, instanceCount);
        }

        public static void RenderPrimitivesIndirect(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            internal_UnityEngineGraphics__func__RenderPrimitivesIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in rparams, topology, commandBuffer, commandCount, startCommand);
        }

        public static void RenderPrimitivesIndexedIndirect(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            internal_UnityEngineGraphics__func__RenderPrimitivesIndexedIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in rparams, topology, indexBuffer, commandBuffer, commandCount, startCommand);
        }

        public static void DrawMeshNow(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, int materialIndex)
        {
            internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemVoid(mesh, position, rotation, materialIndex);
        }

        public static void DrawMeshNow(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, int materialIndex)
        {
            internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemInt32__SystemVoid(mesh, matrix, materialIndex);
        }

        public static void DrawMeshNow(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(mesh, position, rotation);
        }

        public static void DrawMeshNow(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix)
        {
            internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemVoid(mesh, matrix);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, bool useLightProbes)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawMeshInstancedProcedural(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
        }

        public static void DrawProceduralNow(global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            internal_UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(topology, vertexCount, instanceCount);
        }

        public static void DrawProceduralNow(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
        {
            internal_UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(topology, indexBuffer, indexCount, instanceCount);
        }

        public static void DrawProceduralIndirectNow(global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(topology, bufferWithArgs, argsOffset);
        }

        public static void DrawProceduralIndirectNow(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(topology, indexBuffer, bufferWithArgs, argsOffset);
        }

        public static void DrawProceduralIndirectNow(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(topology, bufferWithArgs, argsOffset);
        }

        public static void DrawProceduralIndirectNow(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(topology, indexBuffer, bufferWithArgs, argsOffset);
        }

        public static void DrawProcedural(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawProcedural(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int instanceCount, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawProceduralIndirect(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawProceduralIndirect(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawProceduralIndirect(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawProceduralIndirect(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemVoid(source, dest);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemInt32__SystemInt32__SystemVoid(source, dest, sourceDepthSlice, destDepthSlice);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemVoid(source, dest, scale, offset);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemVoid(source, dest, mat, pass);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(source, dest, mat, pass, destDepthSlice);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemVoid(source, dest, mat);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.Material mat, int pass)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(source, mat, pass);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(source, mat, pass, destDepthSlice);
        }

        public static void Blit(global::UnityEngine.Texture source, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemVoid(source, mat);
        }

        public static void BlitMultiTap(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, params global::UnityEngine.Vector2[] offsets)
        {
            internal_UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__UnityEngineVector2Array__SystemVoid(source, dest, mat, offsets);
        }

        public static void BlitMultiTap(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int destDepthSlice, params global::UnityEngine.Vector2[] offsets)
        {
            internal_UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__UnityEngineVector2Array__SystemVoid(source, dest, mat, destDepthSlice, offsets);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__SystemVoid(mesh, position, rotation, material, layer);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(mesh, position, rotation, material, layer, camera);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(mesh, matrix, material, layer);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(mesh, matrix, material, layer, camera);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, bool useLightProbes)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
        }

        public static void DrawMesh(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemVoid(mesh, submeshIndex, material, matrices);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(mesh, submeshIndex, material, matrices, count);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh, submeshIndex, material, matrices, count, properties);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(mesh, submeshIndex, material, matrices);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__SystemVoid(mesh, submeshIndex, material, matrices, properties);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
        }

        public static void DrawMeshInstanced(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matrices, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
        }

        public static void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
        }

        public static void DrawMeshInstancedIndirect(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Material mat)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemVoid(screenRect, texture, mat);
        }

        public static void DrawTexture(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture)
        {
            internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemVoid(screenRect, texture);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderTexture rt)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemVoid(rt);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderTexture rt, int mipLevel)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__SystemVoid(rt, mipLevel);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderTexture rt, int mipLevel, global::UnityEngine.CubemapFace face)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(rt, mipLevel, face);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(colorBuffer, depthBuffer);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__SystemVoid(colorBuffer, depthBuffer, mipLevel);
        }

        public static void SetRenderTarget(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel, global::UnityEngine.CubemapFace face)
        {
            internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(colorBuffer, depthBuffer, mipLevel, face);
        }

        public static void SetRandomWriteTarget(int index, global::UnityEngine.ComputeBuffer uav)
        {
            internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(index, uav);
        }

        public static void SetRandomWriteTarget(int index, global::UnityEngine.GraphicsBuffer uav)
        {
            internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(index, uav);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineGraphics__ctor()
        {
            return UnityEngineGraphics__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ColorGamut internal_UnityEngineGraphics__get__activeColorGamut()
        {
            var methodCallResult = UnityEngineGraphics__get__activeColorGamut();
            var returnResult = (global::UnityEngine.ColorGamut)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsTier internal_UnityEngineGraphics__get__activeTier()
        {
            var methodCallResult = UnityEngineGraphics__get__activeTier();
            var returnResult = (global::UnityEngine.Rendering.GraphicsTier)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__set__activeTier(global::UnityEngine.Rendering.GraphicsTier activeTier)
        {
            UnityEngineGraphics__set__activeTier((int) activeTier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGraphics__get__preserveFramebufferAlpha()
        {
            var methodCallResult = UnityEngineGraphics__get__preserveFramebufferAlpha();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.OpenGLESVersion internal_UnityEngineGraphics__get__minOpenGLESVersion()
        {
            var methodCallResult = UnityEngineGraphics__get__minOpenGLESVersion();
            var returnResult = (global::UnityEngine.Rendering.OpenGLESVersion)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer internal_UnityEngineGraphics__get__activeColorBuffer()
        {
            global::UnityEngine.RenderBuffer activeColorBufferValue = default;
            UnityEngineGraphics__get__activeColorBuffer(Unsafe.AsPointer(ref activeColorBufferValue));
            global::UnityEngine.RenderBuffer returnResult = activeColorBufferValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer internal_UnityEngineGraphics__get__activeDepthBuffer()
        {
            global::UnityEngine.RenderBuffer activeDepthBufferValue = default;
            UnityEngineGraphics__get__activeDepthBuffer(Unsafe.AsPointer(ref activeDepthBufferValue));
            global::UnityEngine.RenderBuffer returnResult = activeDepthBufferValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__ClearRandomWriteTargets__SystemVoid()
        {
            UnityEngineGraphics__func__ClearRandomWriteTargets__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__ExecuteCommandBuffer__UnityEngineRenderingCommandBuffer__SystemVoid(global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            UnityEngineGraphics__func__ExecuteCommandBuffer__UnityEngineRenderingCommandBuffer__SystemVoid(buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__ExecuteCommandBufferAsync__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(global::UnityEngine.Rendering.CommandBuffer buffer, global::UnityEngine.Rendering.ComputeQueueType queueType)
        {
            UnityEngineGraphics__func__ExecuteCommandBufferAsync__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(buffer.WrappedId, (int) queueType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(global::UnityEngine.RenderTexture rt, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(rt.WrappedId, mipLevel, (int) face, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(Unsafe.AsPointer(ref colorBuffer), Unsafe.AsPointer(ref depthBuffer), mipLevel, (int) face, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(global::UnityEngine.RenderBuffer[] colorBuffers, global::UnityEngine.RenderBuffer depthBuffer)
        {
            fixed (global::UnityEngine.RenderBuffer* colorBuffersPointer = colorBuffers)
            {
                UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(colorBuffersPointer, colorBuffers.Length, Unsafe.AsPointer(ref depthBuffer));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTargetSetup__SystemVoid(global::UnityEngine.RenderTargetSetup setup)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTargetSetup__SystemVoid(setup.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderTexture__SystemVoid(int index, global::UnityEngine.RenderTexture uav)
        {
            UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderTexture__SystemVoid(index, uav.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(int index, global::UnityEngine.ComputeBuffer uav, bool preserveCounterValue)
        {
            var preserveCounterValueConverted = Unsafe.As<bool, int>(ref preserveCounterValue);
            UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(index, uav.WrappedId, preserveCounterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(int index, global::UnityEngine.GraphicsBuffer uav, bool preserveCounterValue)
        {
            var preserveCounterValueConverted = Unsafe.As<bool, int>(ref preserveCounterValue);
            UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(index, uav.WrappedId, preserveCounterValueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__UnityEngineTexture__SystemVoid(global::UnityEngine.Texture src, global::UnityEngine.Texture dst)
        {
            UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__UnityEngineTexture__SystemVoid(src.WrappedId, dst.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(global::UnityEngine.Texture src, int srcElement, global::UnityEngine.Texture dst, int dstElement)
        {
            UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(src.WrappedId, srcElement, dst.WrappedId, dstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture src, int srcElement, int srcMip, global::UnityEngine.Texture dst, int dstElement, int dstMip)
        {
            UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemVoid(src.WrappedId, srcElement, srcMip, dst.WrappedId, dstElement, dstMip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, global::UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY)
        {
            UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(src.WrappedId, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst.WrappedId, dstElement, dstMip, dstX, dstY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__UnityEngineTexture__SystemBoolean(global::UnityEngine.Texture src, global::UnityEngine.Texture dst)
        {
            var methodCallResult = UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__UnityEngineTexture__SystemBoolean(src.WrappedId, dst.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemBoolean(global::UnityEngine.Texture src, int srcElement, global::UnityEngine.Texture dst, int dstElement)
        {
            var methodCallResult = UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemBoolean(src.WrappedId, srcElement, dst.WrappedId, dstElement);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence((int) stage, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence()
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GraphicsFence internal_UnityEngineGraphics__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(global::UnityEngine.Rendering.GraphicsFenceType fenceType, global::UnityEngine.Rendering.SynchronisationStageFlags stage)
        {
            global::UnityEngine.Rendering.GraphicsFence returnResultValue = default;
            UnityEngineGraphics__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence((int) fenceType, (int) stage, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.GraphicsFence returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(global::UnityEngine.Rendering.GraphicsFence fence)
        {
            UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(Unsafe.AsPointer(ref fence));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(global::UnityEngine.Rendering.GraphicsFence fence, global::UnityEngine.Rendering.SynchronisationStage stage)
        {
            UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(Unsafe.AsPointer(ref fence), (int) stage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(global::UnityEngine.GraphicsBuffer source, global::UnityEngine.GraphicsBuffer dest)
        {
            UnityEngineGraphics__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(source.WrappedId, dest.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder, Unsafe.AsPointer(ref color), mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder, mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, leftBorder, rightBorder, topBorder, bottomBorder, mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderMesh__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__UnityEngineMatrix4x4__System_Nullable_UnityEngineMatrix4x4__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Matrix4x4 objectToWorld, global::UnityEngine.Matrix4x4? prevObjectToWorld)
        {
            UnityEngineGraphics__func__RenderMesh__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__UnityEngineMatrix4x4__System_Nullable_UnityEngineMatrix4x4__SystemVoid(rparams.WrappedId, mesh.WrappedId, submeshIndex, Unsafe.AsPointer(ref objectToWorld), Unsafe.AsPointer(ref prevObjectToWorld));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderMeshIndirect__UnityEngineRenderParamsRef__UnityEngineMesh__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            UnityEngineGraphics__func__RenderMeshIndirect__UnityEngineRenderParamsRef__UnityEngineMesh__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, mesh.WrappedId, commandBuffer.WrappedId, commandCount, startCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderMeshPrimitives__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.Mesh mesh, int submeshIndex, int instanceCount)
        {
            UnityEngineGraphics__func__RenderMeshPrimitives__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, mesh.WrappedId, submeshIndex, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderPrimitives__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            UnityEngineGraphics__func__RenderPrimitives__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, (int) topology, vertexCount, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderPrimitivesIndexed__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int startIndex, int instanceCount)
        {
            UnityEngineGraphics__func__RenderPrimitivesIndexed__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, (int) topology, indexBuffer.WrappedId, indexCount, startIndex, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderPrimitivesIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            UnityEngineGraphics__func__RenderPrimitivesIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, (int) topology, commandBuffer.WrappedId, commandCount, startCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__RenderPrimitivesIndexedIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(in global::UnityEngine.RenderParams rparams, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer commandBuffer, int commandCount, int startCommand)
        {
            UnityEngineGraphics__func__RenderPrimitivesIndexedIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(rparams.WrappedId, (int) topology, indexBuffer.WrappedId, commandBuffer.WrappedId, commandCount, startCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, int materialIndex)
        {
            UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), materialIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, int materialIndex)
        {
            UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), materialIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix)
        {
            UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            var useLightProbesConverted = Unsafe.As<bool, int>(ref useLightProbes);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted, receiveShadowsConverted, useLightProbesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, bool useLightProbes)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            var useLightProbesConverted = Unsafe.As<bool, int>(ref useLightProbes);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId, useLightProbesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            var useLightProbesConverted = Unsafe.As<bool, int>(ref useLightProbes);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted, receiveShadowsConverted, useLightProbesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, Unsafe.AsPointer(ref bounds), count, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, Unsafe.AsPointer(ref bounds), bufferWithArgs.WrappedId, argsOffset, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage, global::UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, Unsafe.AsPointer(ref bounds), bufferWithArgs.WrappedId, argsOffset, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage, lightProbeProxyVolume.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount)
        {
            UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid((int) topology, vertexCount, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
        {
            UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid((int) topology, indexBuffer.WrappedId, indexCount, instanceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid((int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid((int) topology, indexBuffer.WrappedId, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid((int) topology, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset)
        {
            UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid((int) topology, indexBuffer.WrappedId, bufferWithArgs.WrappedId, argsOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, vertexCount, instanceCount, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, int indexCount, int instanceCount, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, indexBuffer.WrappedId, indexCount, instanceCount, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, bufferWithArgs.WrappedId, argsOffset, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, bufferWithArgs.WrappedId, argsOffset, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, indexBuffer.WrappedId, bufferWithArgs.WrappedId, argsOffset, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.MeshTopology topology, global::UnityEngine.GraphicsBuffer indexBuffer, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.Camera camera, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(material.WrappedId, Unsafe.AsPointer(ref bounds), (int) topology, indexBuffer.WrappedId, bufferWithArgs.WrappedId, argsOffset, camera.WrappedId, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemVoid(source.WrappedId, dest.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemInt32__SystemInt32__SystemVoid(source.WrappedId, dest.WrappedId, sourceDepthSlice, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemVoid(source.WrappedId, dest.WrappedId, Unsafe.AsPointer(ref scale), Unsafe.AsPointer(ref offset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(source.WrappedId, dest.WrappedId, Unsafe.AsPointer(ref scale), Unsafe.AsPointer(ref offset), sourceDepthSlice, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemVoid(source.WrappedId, dest.WrappedId, mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(source.WrappedId, dest.WrappedId, mat.WrappedId, pass, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemVoid(source.WrappedId, dest.WrappedId, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.Material mat, int pass)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(source.WrappedId, mat.WrappedId, pass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.Material mat, int pass, int destDepthSlice)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(source.WrappedId, mat.WrappedId, pass, destDepthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemVoid(source.WrappedId, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__UnityEngineVector2Array__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, global::UnityEngine.Vector2[] offsets)
        {
            fixed (global::UnityEngine.Vector2* offsetsPointer = offsets)
            {
                UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__UnityEngineVector2Array__SystemVoid(source.WrappedId, dest.WrappedId, mat.WrappedId, offsetsPointer, offsets.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__UnityEngineVector2Array__SystemVoid(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture dest, global::UnityEngine.Material mat, int destDepthSlice, global::UnityEngine.Vector2[] offsets)
        {
            fixed (global::UnityEngine.Vector2* offsetsPointer = offsets)
            {
                UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__UnityEngineVector2Array__SystemVoid(source.WrappedId, dest.WrappedId, mat.WrappedId, destDepthSlice, offsetsPointer, offsets.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
        {
            var castShadowsConverted = Unsafe.As<bool, int>(ref castShadows);
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, castShadowsConverted, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, bool useLightProbes)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            var useLightProbesConverted = Unsafe.As<bool, int>(ref useLightProbes);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId, useLightProbesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(global::UnityEngine.Mesh mesh, global::UnityEngine.Matrix4x4 matrix, global::UnityEngine.Material material, int layer, global::UnityEngine.Camera camera, int submeshIndex, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, global::UnityEngine.Transform probeAnchor, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh.WrappedId, Unsafe.AsPointer(ref matrix), material.WrappedId, layer, camera.WrappedId, submeshIndex, properties.WrappedId, (int) castShadows, receiveShadowsConverted, probeAnchor.WrappedId, (int) lightProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows, receiveShadowsConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Matrix4x4[] matrices, int count, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, count, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows, receiveShadowsConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> matricesList, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            Span<global::UnityEngine.Matrix4x4> matrices = CollectionsMarshal.AsSpan(matricesList);
            fixed (global::UnityEngine.Matrix4x4* matricesPointer = matrices)
            {
                var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
                UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, matricesPointer, matrices.Length, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, Unsafe.AsPointer(ref bounds), bufferWithArgs.WrappedId, argsOffset, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(global::UnityEngine.Mesh mesh, int submeshIndex, global::UnityEngine.Material material, global::UnityEngine.Bounds bounds, global::UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, global::UnityEngine.MaterialPropertyBlock properties, global::UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, global::UnityEngine.Camera camera, global::UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
        {
            var receiveShadowsConverted = Unsafe.As<bool, int>(ref receiveShadows);
            UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(mesh.WrappedId, submeshIndex, material.WrappedId, Unsafe.AsPointer(ref bounds), bufferWithArgs.WrappedId, argsOffset, properties.WrappedId, (int) castShadows, receiveShadowsConverted, layer, camera.WrappedId, (int) lightProbeUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder, Unsafe.AsPointer(ref color), mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Color color)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, Unsafe.AsPointer(ref sourceRect), leftBorder, rightBorder, topBorder, bottomBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, leftBorder, rightBorder, topBorder, bottomBorder, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, leftBorder, rightBorder, topBorder, bottomBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture, global::UnityEngine.Material mat)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemVoid(global::UnityEngine.Rect screenRect, global::UnityEngine.Texture texture)
        {
            UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemVoid(Unsafe.AsPointer(ref screenRect), texture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemVoid(global::UnityEngine.RenderTexture rt)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemVoid(rt.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__SystemVoid(global::UnityEngine.RenderTexture rt, int mipLevel)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__SystemVoid(rt.WrappedId, mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(global::UnityEngine.RenderTexture rt, int mipLevel, global::UnityEngine.CubemapFace face)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(rt.WrappedId, mipLevel, (int) face);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(Unsafe.AsPointer(ref colorBuffer), Unsafe.AsPointer(ref depthBuffer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__SystemVoid(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__SystemVoid(Unsafe.AsPointer(ref colorBuffer), Unsafe.AsPointer(ref depthBuffer), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer, int mipLevel, global::UnityEngine.CubemapFace face)
        {
            UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(Unsafe.AsPointer(ref colorBuffer), Unsafe.AsPointer(ref depthBuffer), mipLevel, (int) face);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(int index, global::UnityEngine.ComputeBuffer uav)
        {
            UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(index, uav.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(int index, global::UnityEngine.GraphicsBuffer uav)
        {
            UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(index, uav.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineGraphics__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__get__activeColorGamut();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__get__activeTier();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__set__activeTier(int activeTierUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__get__preserveFramebufferAlpha();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__get__minOpenGLESVersion();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__get__activeColorBuffer(void* activeColorBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__get__activeDepthBuffer(void* activeDepthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__ClearRandomWriteTargets__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__ExecuteCommandBuffer__UnityEngineRenderingCommandBuffer__SystemVoid(long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__ExecuteCommandBufferAsync__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(long bufferObjectId, int queueTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long rtObjectId, int mipLevel, int faceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(void* colorBufferPointer, void* depthBufferPointer, int mipLevel, int faceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(void* colorBuffersPointer, int colorBuffersWasmLength, void* depthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTargetSetup__SystemVoid(long setupObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineRenderTexture__SystemVoid(int index, long uavObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemBoolean__SystemVoid(int index, long uavObjectId, int preserveCounterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemBoolean__SystemVoid(int index, long uavObjectId, int preserveCounterValueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__UnityEngineTexture__SystemVoid(long srcObjectId, long dstObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(long srcObjectId, int srcElement, long dstObjectId, int dstElement);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemVoid(long srcObjectId, int srcElement, int srcMip, long dstObjectId, int dstElement, int dstMip);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__CopyTexture__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long srcObjectId, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, long dstObjectId, int dstElement, int dstMip, int dstX, int dstY);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__UnityEngineTexture__SystemBoolean(long srcObjectId, long dstObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineGraphics__func__ConvertTexture__UnityEngineTexture__SystemInt32__UnityEngineTexture__SystemInt32__SystemBoolean(long srcObjectId, int srcElement, long dstObjectId, int dstElement);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__UnityEngineRenderingGraphicsFence(int stageUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__CreateAsyncGraphicsFence__UnityEngineRenderingGraphicsFence(void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__CreateGraphicsFence__UnityEngineRenderingGraphicsFenceTypeEnum__UnityEngineRenderingSynchronisationStageFlagsEnum__UnityEngineRenderingGraphicsFence(int fenceTypeUnderlyingValue, int stageUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__SystemVoid(void* fencePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__WaitOnAsyncGraphicsFence__UnityEngineRenderingGraphicsFence__UnityEngineRenderingSynchronisationStageEnum__SystemVoid(void* fencePointer, int stageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__CopyBuffer__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemVoid(long sourceObjectId, long destObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder, void* colorPointer, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, int leftBorder, int rightBorder, int topBorder, int bottomBorder, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__RenderMesh__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__UnityEngineMatrix4x4__System_Nullable_UnityEngineMatrix4x4__SystemVoid(long rparamsObjectId, long meshObjectId, int submeshIndex, void* objectToWorldPointer, void* prevObjectToWorldPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderMeshIndirect__UnityEngineRenderParamsRef__UnityEngineMesh__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, long meshObjectId, long commandBufferObjectId, int commandCount, int startCommand);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderMeshPrimitives__UnityEngineRenderParamsRef__UnityEngineMesh__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, long meshObjectId, int submeshIndex, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderPrimitives__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, int topologyUnderlyingValue, int vertexCount, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderPrimitivesIndexed__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, int topologyUnderlyingValue, long indexBufferObjectId, int indexCount, int startIndex, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderPrimitivesIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, int topologyUnderlyingValue, long commandBufferObjectId, int commandCount, int startCommand);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__RenderPrimitivesIndexedIndirect__UnityEngineRenderParamsRef__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long rparamsObjectId, int topologyUnderlyingValue, long indexBufferObjectId, long commandBufferObjectId, int commandCount, int startCommand);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemInt32__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, int materialIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemInt32__SystemVoid(long meshObjectId, void* matrixPointer, int materialIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshNow__UnityEngineMesh__UnityEngineMatrix4x4__SystemVoid(long meshObjectId, void* matrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted, int receiveShadowsConverted, int useLightProbesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId, int useLightProbesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted, int receiveShadowsConverted, int useLightProbesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstancedProcedural__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* boundsPointer, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* boundsPointer, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__UnityEngineLightProbeProxyVolume__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* boundsPointer, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue, long lightProbeProxyVolumeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__SystemVoid(int topologyUnderlyingValue, int vertexCount, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(int topologyUnderlyingValue, long indexBufferObjectId, int indexCount, int instanceCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__SystemVoid(int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__SystemVoid(int topologyUnderlyingValue, long indexBufferObjectId, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__DrawProceduralIndirectNow__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__SystemVoid(int topologyUnderlyingValue, long indexBufferObjectId, long bufferWithArgsObjectId, int argsOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, int vertexCount, int instanceCount, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProcedural__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, long indexBufferObjectId, int indexCount, int instanceCount, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, long bufferWithArgsObjectId, int argsOffset, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineComputeBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, long indexBufferObjectId, long bufferWithArgsObjectId, int argsOffset, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawProceduralIndirect__UnityEngineMaterial__UnityEngineBounds__UnityEngineMeshTopologyEnum__UnityEngineGraphicsBuffer__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineCamera__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long materialObjectId, void* boundsPointer, int topologyUnderlyingValue, long indexBufferObjectId, long bufferWithArgsObjectId, int argsOffset, long cameraObjectId, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemVoid(long sourceObjectId, long destObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__SystemInt32__SystemInt32__SystemVoid(long sourceObjectId, long destObjectId, int sourceDepthSlice, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemVoid(long sourceObjectId, long destObjectId, void* scalePointer, void* offsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineVector2__UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(long sourceObjectId, long destObjectId, void* scalePointer, void* offsetPointer, int sourceDepthSlice, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemVoid(long sourceObjectId, long destObjectId, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long sourceObjectId, long destObjectId, long matObjectId, int pass, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemVoid(long sourceObjectId, long destObjectId, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemVoid(long sourceObjectId, long matObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemInt32__SystemInt32__SystemVoid(long sourceObjectId, long matObjectId, int pass, int destDepthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__Blit__UnityEngineTexture__UnityEngineMaterial__SystemVoid(long sourceObjectId, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__UnityEngineVector2Array__SystemVoid(long sourceObjectId, long destObjectId, long matObjectId, void* offsetsPointer, int offsetsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__BlitMultiTap__UnityEngineTexture__UnityEngineRenderTexture__UnityEngineMaterial__SystemInt32__UnityEngineVector2Array__SystemVoid(long sourceObjectId, long destObjectId, long matObjectId, int destDepthSlice, void* offsetsPointer, int offsetsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineVector3__UnityEngineQuaternion__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(long meshObjectId, void* positionPointer, void* rotationPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__SystemBoolean__SystemBoolean__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsConverted, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__SystemBoolean__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId, int useLightProbesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMesh__UnityEngineMesh__UnityEngineMatrix4x4__UnityEngineMaterial__SystemInt32__UnityEngineCamera__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__UnityEngineTransform__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(long meshObjectId, void* matrixPointer, long materialObjectId, int layer, long cameraObjectId, int submeshIndex, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, long probeAnchorObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineMatrix4x4Array__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, int count, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstanced__UnityEngineMesh__SystemInt32__UnityEngineMaterial__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* matricesPointer, int matricesWasmLength, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineComputeBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* boundsPointer, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawMeshInstancedIndirect__UnityEngineMesh__SystemInt32__UnityEngineMaterial__UnityEngineBounds__UnityEngineGraphicsBuffer__SystemInt32__UnityEngineMaterialPropertyBlock__UnityEngineRenderingShadowCastingModeEnum__SystemBoolean__SystemInt32__UnityEngineCamera__UnityEngineRenderingLightProbeUsageEnum__SystemVoid(long meshObjectId, int submeshIndex, long materialObjectId, void* boundsPointer, long bufferWithArgsObjectId, int argsOffset, long propertiesObjectId, int castShadowsUnderlyingValue, int receiveShadowsConverted, int layer, long cameraObjectId, int lightProbeUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__UnityEngineMaterial__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder, void* colorPointer, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineRect__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, void* sourceRectPointer, int leftBorder, int rightBorder, int topBorder, int bottomBorder);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineMaterial__SystemVoid(void* screenRectPointer, long textureObjectId, int leftBorder, int rightBorder, int topBorder, int bottomBorder, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(void* screenRectPointer, long textureObjectId, int leftBorder, int rightBorder, int topBorder, int bottomBorder);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__UnityEngineMaterial__SystemVoid(void* screenRectPointer, long textureObjectId, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__DrawTexture__UnityEngineRect__UnityEngineTexture__SystemVoid(void* screenRectPointer, long textureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemVoid(long rtObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__SystemVoid(long rtObjectId, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderTexture__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(long rtObjectId, int mipLevel, int faceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(void* colorBufferPointer, void* depthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__SystemVoid(void* colorBufferPointer, void* depthBufferPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineGraphics__func__SetRenderTarget__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemVoid(void* colorBufferPointer, void* depthBufferPointer, int mipLevel, int faceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineComputeBuffer__SystemVoid(int index, long uavObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineGraphics__func__SetRandomWriteTarget__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(int index, long uavObjectId);

        #endregion Imports
    }
}
