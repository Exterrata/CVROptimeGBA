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

    public partial class SkinnedMeshRenderer(long id) : Renderer(id)
    {

        #region Implementation

        public global::UnityEngine.SkinQuality quality 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__quality(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__quality(WrappedId, value);
        }

        public bool updateWhenOffscreen 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__updateWhenOffscreen(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__updateWhenOffscreen(WrappedId, value);
        }

        public bool forceMatrixRecalculationPerRender 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__forceMatrixRecalculationPerRender(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__forceMatrixRecalculationPerRender(WrappedId, value);
        }

        public global::UnityEngine.Transform rootBone 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__rootBone(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__rootBone(WrappedId, value);
        }

        public global::UnityEngine.Transform[] bones 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__bones(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__bones(WrappedId, value);
        }

        public global::UnityEngine.Mesh sharedMesh 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__sharedMesh(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__sharedMesh(WrappedId, value);
        }

        public bool skinnedMotionVectors 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__skinnedMotionVectors(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__skinnedMotionVectors(WrappedId, value);
        }

        public global::UnityEngine.GraphicsBuffer.Target vertexBufferTarget 
        {
            get => internal_UnityEngineSkinnedMeshRenderer__get__vertexBufferTarget(WrappedId);
            set => internal_UnityEngineSkinnedMeshRenderer__set__vertexBufferTarget(WrappedId, value);
        }

        public float GetBlendShapeWeight(int index)
        {
            return internal_UnityEngineSkinnedMeshRenderer__func__GetBlendShapeWeight__SystemInt32__SystemSingle(WrappedId, index);
        }

        public void SetBlendShapeWeight(int index, float value)
        {
            internal_UnityEngineSkinnedMeshRenderer__func__SetBlendShapeWeight__SystemInt32__SystemSingle__SystemVoid(WrappedId, index, value);
        }

        public void BakeMesh(global::UnityEngine.Mesh mesh)
        {
            internal_UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemVoid(WrappedId, mesh);
        }

        public void BakeMesh(global::UnityEngine.Mesh mesh, bool useScale)
        {
            internal_UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemBoolean__SystemVoid(WrappedId, mesh, useScale);
        }

        public global::UnityEngine.GraphicsBuffer GetVertexBuffer()
        {
            return internal_UnityEngineSkinnedMeshRenderer__func__GetVertexBuffer__UnityEngineGraphicsBuffer(WrappedId);
        }

        public global::UnityEngine.GraphicsBuffer GetPreviousVertexBuffer()
        {
            return internal_UnityEngineSkinnedMeshRenderer__func__GetPreviousVertexBuffer__UnityEngineGraphicsBuffer(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.SkinQuality internal_UnityEngineSkinnedMeshRenderer__get__quality(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__quality(selfObjectId);
            var returnResult = (global::UnityEngine.SkinQuality)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__quality(long selfObjectId, global::UnityEngine.SkinQuality quality)
        {
            UnityEngineSkinnedMeshRenderer__set__quality(selfObjectId, (int) quality);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSkinnedMeshRenderer__get__updateWhenOffscreen(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__updateWhenOffscreen(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__updateWhenOffscreen(long selfObjectId, bool updateWhenOffscreen)
        {
            var updateWhenOffscreenConverted = Unsafe.As<bool, int>(ref updateWhenOffscreen);
            UnityEngineSkinnedMeshRenderer__set__updateWhenOffscreen(selfObjectId, updateWhenOffscreenConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSkinnedMeshRenderer__get__forceMatrixRecalculationPerRender(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__forceMatrixRecalculationPerRender(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__forceMatrixRecalculationPerRender(long selfObjectId, bool forceMatrixRecalculationPerRender)
        {
            var forceMatrixRecalculationPerRenderConverted = Unsafe.As<bool, int>(ref forceMatrixRecalculationPerRender);
            UnityEngineSkinnedMeshRenderer__set__forceMatrixRecalculationPerRender(selfObjectId, forceMatrixRecalculationPerRenderConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineSkinnedMeshRenderer__get__rootBone(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__rootBone(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__rootBone(long selfObjectId, global::UnityEngine.Transform rootBone)
        {
            UnityEngineSkinnedMeshRenderer__set__rootBone(selfObjectId, rootBone.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform[] internal_UnityEngineSkinnedMeshRenderer__get__bones(long selfObjectId)
        {
            long* bonesIdsPointer = default;
            int bonesWasmLength = default;
            UnityEngineSkinnedMeshRenderer__get__bones(selfObjectId, &bonesIdsPointer, &bonesWasmLength);
            global::UnityEngine.Transform[] returnResult = new global::UnityEngine.Transform[bonesWasmLength];
            for (int i = 0; i < bonesWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Transform(bonesIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)bonesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__bones(long selfObjectId, global::UnityEngine.Transform[] bones)
        {
            int bonesWasmLength = bones.Length;
            long[] bonesIds = new long[bonesWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < bonesWasmLength; i++) bonesIds[i] = (bones[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* bonesIdsPointer = bonesIds)
            {
                UnityEngineSkinnedMeshRenderer__set__bones(selfObjectId, bonesIdsPointer, bonesWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Mesh internal_UnityEngineSkinnedMeshRenderer__get__sharedMesh(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__sharedMesh(selfObjectId);
            var returnResult = new global::UnityEngine.Mesh(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__sharedMesh(long selfObjectId, global::UnityEngine.Mesh sharedMesh)
        {
            UnityEngineSkinnedMeshRenderer__set__sharedMesh(selfObjectId, sharedMesh.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineSkinnedMeshRenderer__get__skinnedMotionVectors(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__skinnedMotionVectors(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__skinnedMotionVectors(long selfObjectId, bool skinnedMotionVectors)
        {
            var skinnedMotionVectorsConverted = Unsafe.As<bool, int>(ref skinnedMotionVectors);
            UnityEngineSkinnedMeshRenderer__set__skinnedMotionVectors(selfObjectId, skinnedMotionVectorsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer.Target internal_UnityEngineSkinnedMeshRenderer__get__vertexBufferTarget(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__get__vertexBufferTarget(selfObjectId);
            var returnResult = (global::UnityEngine.GraphicsBuffer.Target)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__set__vertexBufferTarget(long selfObjectId, global::UnityEngine.GraphicsBuffer.Target vertexBufferTarget)
        {
            UnityEngineSkinnedMeshRenderer__set__vertexBufferTarget(selfObjectId, (int) vertexBufferTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineSkinnedMeshRenderer__func__GetBlendShapeWeight__SystemInt32__SystemSingle(long selfObjectId, int index)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__func__GetBlendShapeWeight__SystemInt32__SystemSingle(selfObjectId, index);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__func__SetBlendShapeWeight__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int index, float value)
        {
            UnityEngineSkinnedMeshRenderer__func__SetBlendShapeWeight__SystemInt32__SystemSingle__SystemVoid(selfObjectId, index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh)
        {
            UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemVoid(selfObjectId, mesh.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Mesh mesh, bool useScale)
        {
            var useScaleConverted = Unsafe.As<bool, int>(ref useScale);
            UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemBoolean__SystemVoid(selfObjectId, mesh.WrappedId, useScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer internal_UnityEngineSkinnedMeshRenderer__func__GetVertexBuffer__UnityEngineGraphicsBuffer(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__func__GetVertexBuffer__UnityEngineGraphicsBuffer(selfObjectId);
            var returnResult = new global::UnityEngine.GraphicsBuffer(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer internal_UnityEngineSkinnedMeshRenderer__func__GetPreviousVertexBuffer__UnityEngineGraphicsBuffer(long selfObjectId)
        {
            var methodCallResult = UnityEngineSkinnedMeshRenderer__func__GetPreviousVertexBuffer__UnityEngineGraphicsBuffer(selfObjectId);
            var returnResult = new global::UnityEngine.GraphicsBuffer(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineSkinnedMeshRenderer__get__quality(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__quality(long selfObjectId, int qualityUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineSkinnedMeshRenderer__get__updateWhenOffscreen(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__updateWhenOffscreen(long selfObjectId, int updateWhenOffscreenConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineSkinnedMeshRenderer__get__forceMatrixRecalculationPerRender(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__forceMatrixRecalculationPerRender(long selfObjectId, int forceMatrixRecalculationPerRenderConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineSkinnedMeshRenderer__get__rootBone(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__rootBone(long selfObjectId, long rootBoneObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkinnedMeshRenderer__get__bones(long selfObjectId, void* bonesIdsPointer, void* bonesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineSkinnedMeshRenderer__set__bones(long selfObjectId, void* bonesIdsPointer, int bonesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineSkinnedMeshRenderer__get__sharedMesh(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__sharedMesh(long selfObjectId, long sharedMeshObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineSkinnedMeshRenderer__get__skinnedMotionVectors(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__skinnedMotionVectors(long selfObjectId, int skinnedMotionVectorsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineSkinnedMeshRenderer__get__vertexBufferTarget(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__set__vertexBufferTarget(long selfObjectId, int vertexBufferTargetUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineSkinnedMeshRenderer__func__GetBlendShapeWeight__SystemInt32__SystemSingle(long selfObjectId, int index);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__func__SetBlendShapeWeight__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int index, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemVoid(long selfObjectId, long meshObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineSkinnedMeshRenderer__func__BakeMesh__UnityEngineMesh__SystemBoolean__SystemVoid(long selfObjectId, long meshObjectId, int useScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineSkinnedMeshRenderer__func__GetVertexBuffer__UnityEngineGraphicsBuffer(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineSkinnedMeshRenderer__func__GetPreviousVertexBuffer__UnityEngineGraphicsBuffer(long selfObjectId);

        #endregion Imports
    }
}
