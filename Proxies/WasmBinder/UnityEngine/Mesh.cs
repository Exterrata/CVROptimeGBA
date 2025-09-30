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

    public partial class Mesh(long id) : Object(id)
    {

        #region Implementation

        public Mesh()
            : this(internal_UnityEngineMesh__ctor()) { }

        public global::UnityEngine.Rendering.IndexFormat indexFormat 
        {
            get => internal_UnityEngineMesh__get__indexFormat(WrappedId);
            set => internal_UnityEngineMesh__set__indexFormat(WrappedId, value);
        }

        public int vertexBufferCount 
        {
            get => internal_UnityEngineMesh__get__vertexBufferCount(WrappedId);
        }

        public global::UnityEngine.GraphicsBuffer.Target vertexBufferTarget 
        {
            get => internal_UnityEngineMesh__get__vertexBufferTarget(WrappedId);
            set => internal_UnityEngineMesh__set__vertexBufferTarget(WrappedId, value);
        }

        public global::UnityEngine.GraphicsBuffer.Target indexBufferTarget 
        {
            get => internal_UnityEngineMesh__get__indexBufferTarget(WrappedId);
            set => internal_UnityEngineMesh__set__indexBufferTarget(WrappedId, value);
        }

        public int blendShapeCount 
        {
            get => internal_UnityEngineMesh__get__blendShapeCount(WrappedId);
        }

        public global::UnityEngine.Matrix4x4[] bindposes 
        {
            get => internal_UnityEngineMesh__get__bindposes(WrappedId);
            set => internal_UnityEngineMesh__set__bindposes(WrappedId, value);
        }

        public bool isReadable 
        {
            get => internal_UnityEngineMesh__get__isReadable(WrappedId);
        }

        public int vertexCount 
        {
            get => internal_UnityEngineMesh__get__vertexCount(WrappedId);
        }

        public int subMeshCount 
        {
            get => internal_UnityEngineMesh__get__subMeshCount(WrappedId);
            set => internal_UnityEngineMesh__set__subMeshCount(WrappedId, value);
        }

        public global::UnityEngine.Bounds bounds 
        {
            get => internal_UnityEngineMesh__get__bounds(WrappedId);
            set => internal_UnityEngineMesh__set__bounds(WrappedId, value);
        }

        public global::UnityEngine.Vector3[] vertices 
        {
            get => internal_UnityEngineMesh__get__vertices(WrappedId);
            set => internal_UnityEngineMesh__set__vertices(WrappedId, value);
        }

        public global::UnityEngine.Vector3[] normals 
        {
            get => internal_UnityEngineMesh__get__normals(WrappedId);
            set => internal_UnityEngineMesh__set__normals(WrappedId, value);
        }

        public global::UnityEngine.Vector4[] tangents 
        {
            get => internal_UnityEngineMesh__get__tangents(WrappedId);
            set => internal_UnityEngineMesh__set__tangents(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv 
        {
            get => internal_UnityEngineMesh__get__uv(WrappedId);
            set => internal_UnityEngineMesh__set__uv(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv2 
        {
            get => internal_UnityEngineMesh__get__uv2(WrappedId);
            set => internal_UnityEngineMesh__set__uv2(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv3 
        {
            get => internal_UnityEngineMesh__get__uv3(WrappedId);
            set => internal_UnityEngineMesh__set__uv3(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv4 
        {
            get => internal_UnityEngineMesh__get__uv4(WrappedId);
            set => internal_UnityEngineMesh__set__uv4(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv5 
        {
            get => internal_UnityEngineMesh__get__uv5(WrappedId);
            set => internal_UnityEngineMesh__set__uv5(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv6 
        {
            get => internal_UnityEngineMesh__get__uv6(WrappedId);
            set => internal_UnityEngineMesh__set__uv6(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv7 
        {
            get => internal_UnityEngineMesh__get__uv7(WrappedId);
            set => internal_UnityEngineMesh__set__uv7(WrappedId, value);
        }

        public global::UnityEngine.Vector2[] uv8 
        {
            get => internal_UnityEngineMesh__get__uv8(WrappedId);
            set => internal_UnityEngineMesh__set__uv8(WrappedId, value);
        }

        public global::UnityEngine.Color[] colors 
        {
            get => internal_UnityEngineMesh__get__colors(WrappedId);
            set => internal_UnityEngineMesh__set__colors(WrappedId, value);
        }

        public global::UnityEngine.Color32[] colors32 
        {
            get => internal_UnityEngineMesh__get__colors32(WrappedId);
            set => internal_UnityEngineMesh__set__colors32(WrappedId, value);
        }

        public int vertexAttributeCount 
        {
            get => internal_UnityEngineMesh__get__vertexAttributeCount(WrappedId);
        }

        public global::System.Int32[] triangles 
        {
            get => internal_UnityEngineMesh__get__triangles(WrappedId);
            set => internal_UnityEngineMesh__set__triangles(WrappedId, value);
        }

        public global::UnityEngine.BoneWeight[] boneWeights 
        {
            get => internal_UnityEngineMesh__get__boneWeights(WrappedId);
            set => internal_UnityEngineMesh__set__boneWeights(WrappedId, value);
        }

        public void SetIndexBufferParams(int indexCount, global::UnityEngine.Rendering.IndexFormat format)
        {
            internal_UnityEngineMesh__func__SetIndexBufferParams__SystemInt32__UnityEngineRenderingIndexFormatEnum__SystemVoid(WrappedId, indexCount, format);
        }

        public global::UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index)
        {
            return internal_UnityEngineMesh__func__GetVertexAttribute__SystemInt32__UnityEngineRenderingVertexAttributeDescriptor(WrappedId, index);
        }

        public bool HasVertexAttribute(global::UnityEngine.Rendering.VertexAttribute attr)
        {
            return internal_UnityEngineMesh__func__HasVertexAttribute__UnityEngineRenderingVertexAttributeEnum__SystemBoolean(WrappedId, attr);
        }

        public int GetVertexAttributeDimension(global::UnityEngine.Rendering.VertexAttribute attr)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributeDimension__UnityEngineRenderingVertexAttributeEnum__SystemInt32(WrappedId, attr);
        }

        public global::UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(global::UnityEngine.Rendering.VertexAttribute attr)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributeFormat__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum(WrappedId, attr);
        }

        public int GetVertexAttributeStream(global::UnityEngine.Rendering.VertexAttribute attr)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributeStream__UnityEngineRenderingVertexAttributeEnum__SystemInt32(WrappedId, attr);
        }

        public int GetVertexAttributeOffset(global::UnityEngine.Rendering.VertexAttribute attr)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributeOffset__UnityEngineRenderingVertexAttributeEnum__SystemInt32(WrappedId, attr);
        }

        public int GetVertexBufferStride(int stream)
        {
            return internal_UnityEngineMesh__func__GetVertexBufferStride__SystemInt32__SystemInt32(WrappedId, stream);
        }

        public void ClearBlendShapes()
        {
            internal_UnityEngineMesh__func__ClearBlendShapes__SystemVoid(WrappedId);
        }

        public string GetBlendShapeName(int shapeIndex)
        {
            return internal_UnityEngineMesh__func__GetBlendShapeName__SystemInt32__SystemString(WrappedId, shapeIndex);
        }

        public int GetBlendShapeIndex(string blendShapeName)
        {
            return internal_UnityEngineMesh__func__GetBlendShapeIndex__SystemString__SystemInt32(WrappedId, blendShapeName);
        }

        public int GetBlendShapeFrameCount(int shapeIndex)
        {
            return internal_UnityEngineMesh__func__GetBlendShapeFrameCount__SystemInt32__SystemInt32(WrappedId, shapeIndex);
        }

        public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
        {
            return internal_UnityEngineMesh__func__GetBlendShapeFrameWeight__SystemInt32__SystemInt32__SystemSingle(WrappedId, shapeIndex, frameIndex);
        }

        public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, global::UnityEngine.Vector3[] deltaVertices, global::UnityEngine.Vector3[] deltaNormals, global::UnityEngine.Vector3[] deltaTangents)
        {
            internal_UnityEngineMesh__func__GetBlendShapeFrameVertices__SystemInt32__SystemInt32__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(WrappedId, shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents);
        }

        public void AddBlendShapeFrame(string shapeName, float frameWeight, global::UnityEngine.Vector3[] deltaVertices, global::UnityEngine.Vector3[] deltaNormals, global::UnityEngine.Vector3[] deltaTangents)
        {
            internal_UnityEngineMesh__func__AddBlendShapeFrame__SystemString__SystemSingle__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(WrappedId, shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents);
        }

        public void SetSubMesh(int index, global::UnityEngine.Rendering.SubMeshDescriptor desc, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, index, desc, flags);
        }

        public global::UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index)
        {
            return internal_UnityEngineMesh__func__GetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor(WrappedId, index);
        }

        public void MarkModified()
        {
            internal_UnityEngineMesh__func__MarkModified__SystemVoid(WrappedId);
        }

        public float GetUVDistributionMetric(int uvSetIndex)
        {
            return internal_UnityEngineMesh__func__GetUVDistributionMetric__SystemInt32__SystemSingle(WrappedId, uvSetIndex);
        }

        public void GetVertices(global::System.Collections.Generic.List<global::UnityEngine.Vector3> vertices)
        {
            internal_UnityEngineMesh__func__GetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, vertices);
        }

        public void SetVertices(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVertices)
        {
            internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, inVertices);
        }

        public void SetVertices(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVertices, int start, int length)
        {
            internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(WrappedId, inVertices, start, length);
        }

        public void SetVertices(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVertices, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inVertices, start, length, flags);
        }

        public void SetVertices(global::UnityEngine.Vector3[] inVertices)
        {
            internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemVoid(WrappedId, inVertices);
        }

        public void SetVertices(global::UnityEngine.Vector3[] inVertices, int start, int length)
        {
            internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, inVertices, start, length);
        }

        public void SetVertices(global::UnityEngine.Vector3[] inVertices, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inVertices, start, length, flags);
        }

        public void GetNormals(global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals)
        {
            internal_UnityEngineMesh__func__GetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, normals);
        }

        public void SetNormals(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormals)
        {
            internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, inNormals);
        }

        public void SetNormals(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormals, int start, int length)
        {
            internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(WrappedId, inNormals, start, length);
        }

        public void SetNormals(global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormals, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inNormals, start, length, flags);
        }

        public void SetNormals(global::UnityEngine.Vector3[] inNormals)
        {
            internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemVoid(WrappedId, inNormals);
        }

        public void SetNormals(global::UnityEngine.Vector3[] inNormals, int start, int length)
        {
            internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, inNormals, start, length);
        }

        public void SetNormals(global::UnityEngine.Vector3[] inNormals, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inNormals, start, length, flags);
        }

        public void GetTangents(global::System.Collections.Generic.List<global::UnityEngine.Vector4> tangents)
        {
            internal_UnityEngineMesh__func__GetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, tangents);
        }

        public void SetTangents(global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangents)
        {
            internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, inTangents);
        }

        public void SetTangents(global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangents, int start, int length)
        {
            internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(WrappedId, inTangents, start, length);
        }

        public void SetTangents(global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangents, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inTangents, start, length, flags);
        }

        public void SetTangents(global::UnityEngine.Vector4[] inTangents)
        {
            internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemVoid(WrappedId, inTangents);
        }

        public void SetTangents(global::UnityEngine.Vector4[] inTangents, int start, int length)
        {
            internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, inTangents, start, length);
        }

        public void SetTangents(global::UnityEngine.Vector4[] inTangents, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inTangents, start, length, flags);
        }

        public void GetColors(global::System.Collections.Generic.List<global::UnityEngine.Color> colors)
        {
            internal_UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, colors);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color> inColors)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, inColors);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color> inColors, int start, int length)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__SystemVoid(WrappedId, inColors, start, length);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color> inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inColors, start, length, flags);
        }

        public void SetColors(global::UnityEngine.Color[] inColors)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemVoid(WrappedId, inColors);
        }

        public void SetColors(global::UnityEngine.Color[] inColors, int start, int length)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__SystemVoid(WrappedId, inColors, start, length);
        }

        public void SetColors(global::UnityEngine.Color[] inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inColors, start, length, flags);
        }

        public void GetColors(global::System.Collections.Generic.List<global::UnityEngine.Color32> colors)
        {
            internal_UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(WrappedId, colors);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color32> inColors)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(WrappedId, inColors);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color32> inColors, int start, int length)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__SystemVoid(WrappedId, inColors, start, length);
        }

        public void SetColors(global::System.Collections.Generic.List<global::UnityEngine.Color32> inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inColors, start, length, flags);
        }

        public void SetColors(global::UnityEngine.Color32[] inColors)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemVoid(WrappedId, inColors);
        }

        public void SetColors(global::UnityEngine.Color32[] inColors, int start, int length)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, inColors, start, length);
        }

        public void SetColors(global::UnityEngine.Color32[] inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, inColors, start, length, flags);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector2[] uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector3[] uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector4[] uvs)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, channel, uvs);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector2[] uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector2[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector3[] uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector3[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector4[] uvs, int start, int length)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(WrappedId, channel, uvs, start, length);
        }

        public void SetUVs(int channel, global::UnityEngine.Vector4[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, channel, uvs, start, length, flags);
        }

        public void GetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs)
        {
            internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(WrappedId, channel, uvs);
        }

        public void GetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvs)
        {
            internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(WrappedId, channel, uvs);
        }

        public void GetUVs(int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvs)
        {
            internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, channel, uvs);
        }

        public global::UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
        {
            return internal_UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray(WrappedId);
        }

        public int GetVertexAttributes(global::UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray__SystemInt32(WrappedId, attributes);
        }

        public int GetVertexAttributes(global::System.Collections.Generic.List<global::UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
        {
            return internal_UnityEngineMesh__func__GetVertexAttributes__SystemCollectionsGeneric_List_UnityEngineRenderingVertexAttributeDescriptor__SystemInt32(WrappedId, attributes);
        }

        public void SetVertexBufferParams(int vertexCount, params global::UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
        {
            internal_UnityEngineMesh__func__SetVertexBufferParams__SystemInt32__UnityEngineRenderingVertexAttributeDescriptorArray__SystemVoid(WrappedId, vertexCount, attributes);
        }

        public global::UnityEngine.GraphicsBuffer GetVertexBuffer(int index)
        {
            return internal_UnityEngineMesh__func__GetVertexBuffer__SystemInt32__UnityEngineGraphicsBuffer(WrappedId, index);
        }

        public global::UnityEngine.GraphicsBuffer GetIndexBuffer()
        {
            return internal_UnityEngineMesh__func__GetIndexBuffer__UnityEngineGraphicsBuffer(WrappedId);
        }

        public global::System.Int32[] GetTriangles(int submesh)
        {
            return internal_UnityEngineMesh__func__GetTriangles__SystemInt32__SystemInt32Array(WrappedId, submesh);
        }

        public global::System.Int32[] GetTriangles(int submesh, bool applyBaseVertex)
        {
            return internal_UnityEngineMesh__func__GetTriangles__SystemInt32__SystemBoolean__SystemInt32Array(WrappedId, submesh, applyBaseVertex);
        }

        public void GetTriangles(global::System.Collections.Generic.List<int> triangles, int submesh)
        {
            internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(WrappedId, triangles, submesh);
        }

        public void GetTriangles(global::System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex)
        {
            internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(WrappedId, triangles, submesh, applyBaseVertex);
        }

        public void GetTriangles(global::System.Collections.Generic.List<ushort> triangles, int submesh, bool applyBaseVertex)
        {
            internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(WrappedId, triangles, submesh, applyBaseVertex);
        }

        public global::System.Int32[] GetIndices(int submesh)
        {
            return internal_UnityEngineMesh__func__GetIndices__SystemInt32__SystemInt32Array(WrappedId, submesh);
        }

        public global::System.Int32[] GetIndices(int submesh, bool applyBaseVertex)
        {
            return internal_UnityEngineMesh__func__GetIndices__SystemInt32__SystemBoolean__SystemInt32Array(WrappedId, submesh, applyBaseVertex);
        }

        public void GetIndices(global::System.Collections.Generic.List<int> indices, int submesh)
        {
            internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(WrappedId, indices, submesh);
        }

        public void GetIndices(global::System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex)
        {
            internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(WrappedId, indices, submesh, applyBaseVertex);
        }

        public void GetIndices(global::System.Collections.Generic.List<ushort> indices, int submesh, bool applyBaseVertex)
        {
            internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(WrappedId, indices, submesh, applyBaseVertex);
        }

        public uint GetIndexStart(int submesh)
        {
            return internal_UnityEngineMesh__func__GetIndexStart__SystemInt32__SystemUInt32(WrappedId, submesh);
        }

        public uint GetIndexCount(int submesh)
        {
            return internal_UnityEngineMesh__func__GetIndexCount__SystemInt32__SystemUInt32(WrappedId, submesh);
        }

        public uint GetBaseVertex(int submesh)
        {
            return internal_UnityEngineMesh__func__GetBaseVertex__SystemInt32__SystemUInt32(WrappedId, submesh);
        }

        public void SetTriangles(global::System.Int32[] triangles, int submesh)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemVoid(WrappedId, triangles, submesh);
        }

        public void SetTriangles(global::System.Int32[] triangles, int submesh, bool calculateBounds)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemVoid(WrappedId, triangles, submesh, calculateBounds);
        }

        public void SetTriangles(global::System.Int32[] triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.UInt16[] triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.Collections.Generic.List<int> triangles, int submesh)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(WrappedId, triangles, submesh);
        }

        public void SetTriangles(global::System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(WrappedId, triangles, submesh, calculateBounds);
        }

        public void SetTriangles(global::System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.Collections.Generic.List<ushort> triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, submesh, calculateBounds, baseVertex);
        }

        public void SetTriangles(global::System.Collections.Generic.List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(WrappedId, indices, topology, submesh);
        }

        public void SetIndices(global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemVoid(WrappedId, indices, topology, submesh, calculateBounds);
        }

        public void SetIndices(global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Int32[] indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.UInt16[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemUInt16Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.UInt16[] indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemUInt16Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Collections.Generic.List<int> indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Collections.Generic.List<ushort> indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetIndices(global::System.Collections.Generic.List<ushort> indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(WrappedId, indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
        }

        public void SetSubMeshes(global::UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, desc, start, count, flags);
        }

        public void SetSubMeshes(global::UnityEngine.Rendering.SubMeshDescriptor[] desc, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, desc, flags);
        }

        public void SetSubMeshes(global::System.Collections.Generic.List<global::UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, desc, start, count, flags);
        }

        public void SetSubMeshes(global::System.Collections.Generic.List<global::UnityEngine.Rendering.SubMeshDescriptor> desc, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, desc, flags);
        }

        public void GetBindposes(global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> bindposes)
        {
            internal_UnityEngineMesh__func__GetBindposes__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, bindposes);
        }

        public void GetBoneWeights(global::System.Collections.Generic.List<global::UnityEngine.BoneWeight> boneWeights)
        {
            internal_UnityEngineMesh__func__GetBoneWeights__SystemCollectionsGeneric_List_UnityEngineBoneWeight__SystemVoid(WrappedId, boneWeights);
        }

        public void Clear(bool keepVertexLayout)
        {
            internal_UnityEngineMesh__func__Clear__SystemBoolean__SystemVoid(WrappedId, keepVertexLayout);
        }

        public void Clear()
        {
            internal_UnityEngineMesh__func__Clear__SystemVoid(WrappedId);
        }

        public void RecalculateBounds()
        {
            internal_UnityEngineMesh__func__RecalculateBounds__SystemVoid(WrappedId);
        }

        public void RecalculateNormals()
        {
            internal_UnityEngineMesh__func__RecalculateNormals__SystemVoid(WrappedId);
        }

        public void RecalculateTangents()
        {
            internal_UnityEngineMesh__func__RecalculateTangents__SystemVoid(WrappedId);
        }

        public void RecalculateBounds(global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__RecalculateBounds__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void RecalculateNormals(global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__RecalculateNormals__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void RecalculateTangents(global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            internal_UnityEngineMesh__func__RecalculateTangents__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(WrappedId, flags);
        }

        public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold)
        {
            internal_UnityEngineMesh__func__RecalculateUVDistributionMetric__SystemInt32__SystemSingle__SystemVoid(WrappedId, uvSetIndex, uvAreaThreshold);
        }

        public void RecalculateUVDistributionMetrics(float uvAreaThreshold)
        {
            internal_UnityEngineMesh__func__RecalculateUVDistributionMetrics__SystemSingle__SystemVoid(WrappedId, uvAreaThreshold);
        }

        public void MarkDynamic()
        {
            internal_UnityEngineMesh__func__MarkDynamic__SystemVoid(WrappedId);
        }

        public void UploadMeshData(bool markNoLongerReadable)
        {
            internal_UnityEngineMesh__func__UploadMeshData__SystemBoolean__SystemVoid(WrappedId, markNoLongerReadable);
        }

        public void Optimize()
        {
            internal_UnityEngineMesh__func__Optimize__SystemVoid(WrappedId);
        }

        public void OptimizeIndexBuffers()
        {
            internal_UnityEngineMesh__func__OptimizeIndexBuffers__SystemVoid(WrappedId);
        }

        public void OptimizeReorderVertexBuffer()
        {
            internal_UnityEngineMesh__func__OptimizeReorderVertexBuffer__SystemVoid(WrappedId);
        }

        public global::UnityEngine.MeshTopology GetTopology(int submesh)
        {
            return internal_UnityEngineMesh__func__GetTopology__SystemInt32__UnityEngineMeshTopologyEnum(WrappedId, submesh);
        }

        public void CombineMeshes(global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
        {
            internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, combine, mergeSubMeshes, useMatrices, hasLightmapData);
        }

        public void CombineMeshes(global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices)
        {
            internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, combine, mergeSubMeshes, useMatrices);
        }

        public void CombineMeshes(global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes)
        {
            internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemVoid(WrappedId, combine, mergeSubMeshes);
        }

        public void CombineMeshes(global::UnityEngine.CombineInstance[] combine)
        {
            internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemVoid(WrappedId, combine);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineMesh__ctor()
        {
            return UnityEngineMesh__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.IndexFormat internal_UnityEngineMesh__get__indexFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__indexFormat(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.IndexFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__indexFormat(long selfObjectId, global::UnityEngine.Rendering.IndexFormat indexFormat)
        {
            UnityEngineMesh__set__indexFormat(selfObjectId, (int) indexFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__get__vertexBufferCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__vertexBufferCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer.Target internal_UnityEngineMesh__get__vertexBufferTarget(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__vertexBufferTarget(selfObjectId);
            var returnResult = (global::UnityEngine.GraphicsBuffer.Target)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__vertexBufferTarget(long selfObjectId, global::UnityEngine.GraphicsBuffer.Target vertexBufferTarget)
        {
            UnityEngineMesh__set__vertexBufferTarget(selfObjectId, (int) vertexBufferTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer.Target internal_UnityEngineMesh__get__indexBufferTarget(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__indexBufferTarget(selfObjectId);
            var returnResult = (global::UnityEngine.GraphicsBuffer.Target)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__indexBufferTarget(long selfObjectId, global::UnityEngine.GraphicsBuffer.Target indexBufferTarget)
        {
            UnityEngineMesh__set__indexBufferTarget(selfObjectId, (int) indexBufferTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__get__blendShapeCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__blendShapeCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineMesh__get__bindposes(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4* bindposesIdsPointer = default;
            int bindposesWasmLength = default;
            UnityEngineMesh__get__bindposes(selfObjectId, &bindposesIdsPointer, &bindposesWasmLength);
            global::UnityEngine.Matrix4x4[] returnResult = new global::UnityEngine.Matrix4x4[bindposesWasmLength];
            for (int i = 0; i < bindposesWasmLength; i++)
            {
                returnResult[i] = bindposesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)bindposesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__bindposes(long selfObjectId, global::UnityEngine.Matrix4x4[] bindposes)
        {
            fixed (global::UnityEngine.Matrix4x4* bindposesPointer = bindposes)
            {
                UnityEngineMesh__set__bindposes(selfObjectId, bindposesPointer, bindposes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMesh__get__isReadable(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__isReadable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__get__vertexCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__vertexCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__get__subMeshCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__subMeshCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__subMeshCount(long selfObjectId, int subMeshCount)
        {
            UnityEngineMesh__set__subMeshCount(selfObjectId, subMeshCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Bounds internal_UnityEngineMesh__get__bounds(long selfObjectId)
        {
            global::UnityEngine.Bounds boundsValue = default;
            UnityEngineMesh__get__bounds(selfObjectId, Unsafe.AsPointer(ref boundsValue));
            global::UnityEngine.Bounds returnResult = boundsValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__bounds(long selfObjectId, global::UnityEngine.Bounds bounds)
        {
            UnityEngineMesh__set__bounds(selfObjectId, Unsafe.AsPointer(ref bounds));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3[] internal_UnityEngineMesh__get__vertices(long selfObjectId)
        {
            global::UnityEngine.Vector3* verticesIdsPointer = default;
            int verticesWasmLength = default;
            UnityEngineMesh__get__vertices(selfObjectId, &verticesIdsPointer, &verticesWasmLength);
            global::UnityEngine.Vector3[] returnResult = new global::UnityEngine.Vector3[verticesWasmLength];
            for (int i = 0; i < verticesWasmLength; i++)
            {
                returnResult[i] = verticesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)verticesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__vertices(long selfObjectId, global::UnityEngine.Vector3[] vertices)
        {
            fixed (global::UnityEngine.Vector3* verticesPointer = vertices)
            {
                UnityEngineMesh__set__vertices(selfObjectId, verticesPointer, vertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3[] internal_UnityEngineMesh__get__normals(long selfObjectId)
        {
            global::UnityEngine.Vector3* normalsIdsPointer = default;
            int normalsWasmLength = default;
            UnityEngineMesh__get__normals(selfObjectId, &normalsIdsPointer, &normalsWasmLength);
            global::UnityEngine.Vector3[] returnResult = new global::UnityEngine.Vector3[normalsWasmLength];
            for (int i = 0; i < normalsWasmLength; i++)
            {
                returnResult[i] = normalsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)normalsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__normals(long selfObjectId, global::UnityEngine.Vector3[] normals)
        {
            fixed (global::UnityEngine.Vector3* normalsPointer = normals)
            {
                UnityEngineMesh__set__normals(selfObjectId, normalsPointer, normals.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineMesh__get__tangents(long selfObjectId)
        {
            global::UnityEngine.Vector4* tangentsIdsPointer = default;
            int tangentsWasmLength = default;
            UnityEngineMesh__get__tangents(selfObjectId, &tangentsIdsPointer, &tangentsWasmLength);
            global::UnityEngine.Vector4[] returnResult = new global::UnityEngine.Vector4[tangentsWasmLength];
            for (int i = 0; i < tangentsWasmLength; i++)
            {
                returnResult[i] = tangentsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)tangentsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__tangents(long selfObjectId, global::UnityEngine.Vector4[] tangents)
        {
            fixed (global::UnityEngine.Vector4* tangentsPointer = tangents)
            {
                UnityEngineMesh__set__tangents(selfObjectId, tangentsPointer, tangents.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv(long selfObjectId)
        {
            global::UnityEngine.Vector2* uvIdsPointer = default;
            int uvWasmLength = default;
            UnityEngineMesh__get__uv(selfObjectId, &uvIdsPointer, &uvWasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uvWasmLength];
            for (int i = 0; i < uvWasmLength; i++)
            {
                returnResult[i] = uvIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uvIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv(long selfObjectId, global::UnityEngine.Vector2[] uv)
        {
            fixed (global::UnityEngine.Vector2* uvPointer = uv)
            {
                UnityEngineMesh__set__uv(selfObjectId, uvPointer, uv.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv2(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv2IdsPointer = default;
            int uv2WasmLength = default;
            UnityEngineMesh__get__uv2(selfObjectId, &uv2IdsPointer, &uv2WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv2WasmLength];
            for (int i = 0; i < uv2WasmLength; i++)
            {
                returnResult[i] = uv2IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv2IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv2(long selfObjectId, global::UnityEngine.Vector2[] uv2)
        {
            fixed (global::UnityEngine.Vector2* uv2Pointer = uv2)
            {
                UnityEngineMesh__set__uv2(selfObjectId, uv2Pointer, uv2.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv3(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv3IdsPointer = default;
            int uv3WasmLength = default;
            UnityEngineMesh__get__uv3(selfObjectId, &uv3IdsPointer, &uv3WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv3WasmLength];
            for (int i = 0; i < uv3WasmLength; i++)
            {
                returnResult[i] = uv3IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv3IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv3(long selfObjectId, global::UnityEngine.Vector2[] uv3)
        {
            fixed (global::UnityEngine.Vector2* uv3Pointer = uv3)
            {
                UnityEngineMesh__set__uv3(selfObjectId, uv3Pointer, uv3.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv4(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv4IdsPointer = default;
            int uv4WasmLength = default;
            UnityEngineMesh__get__uv4(selfObjectId, &uv4IdsPointer, &uv4WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv4WasmLength];
            for (int i = 0; i < uv4WasmLength; i++)
            {
                returnResult[i] = uv4IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv4IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv4(long selfObjectId, global::UnityEngine.Vector2[] uv4)
        {
            fixed (global::UnityEngine.Vector2* uv4Pointer = uv4)
            {
                UnityEngineMesh__set__uv4(selfObjectId, uv4Pointer, uv4.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv5(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv5IdsPointer = default;
            int uv5WasmLength = default;
            UnityEngineMesh__get__uv5(selfObjectId, &uv5IdsPointer, &uv5WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv5WasmLength];
            for (int i = 0; i < uv5WasmLength; i++)
            {
                returnResult[i] = uv5IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv5IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv5(long selfObjectId, global::UnityEngine.Vector2[] uv5)
        {
            fixed (global::UnityEngine.Vector2* uv5Pointer = uv5)
            {
                UnityEngineMesh__set__uv5(selfObjectId, uv5Pointer, uv5.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv6(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv6IdsPointer = default;
            int uv6WasmLength = default;
            UnityEngineMesh__get__uv6(selfObjectId, &uv6IdsPointer, &uv6WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv6WasmLength];
            for (int i = 0; i < uv6WasmLength; i++)
            {
                returnResult[i] = uv6IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv6IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv6(long selfObjectId, global::UnityEngine.Vector2[] uv6)
        {
            fixed (global::UnityEngine.Vector2* uv6Pointer = uv6)
            {
                UnityEngineMesh__set__uv6(selfObjectId, uv6Pointer, uv6.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv7(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv7IdsPointer = default;
            int uv7WasmLength = default;
            UnityEngineMesh__get__uv7(selfObjectId, &uv7IdsPointer, &uv7WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv7WasmLength];
            for (int i = 0; i < uv7WasmLength; i++)
            {
                returnResult[i] = uv7IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv7IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv7(long selfObjectId, global::UnityEngine.Vector2[] uv7)
        {
            fixed (global::UnityEngine.Vector2* uv7Pointer = uv7)
            {
                UnityEngineMesh__set__uv7(selfObjectId, uv7Pointer, uv7.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2[] internal_UnityEngineMesh__get__uv8(long selfObjectId)
        {
            global::UnityEngine.Vector2* uv8IdsPointer = default;
            int uv8WasmLength = default;
            UnityEngineMesh__get__uv8(selfObjectId, &uv8IdsPointer, &uv8WasmLength);
            global::UnityEngine.Vector2[] returnResult = new global::UnityEngine.Vector2[uv8WasmLength];
            for (int i = 0; i < uv8WasmLength; i++)
            {
                returnResult[i] = uv8IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)uv8IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__uv8(long selfObjectId, global::UnityEngine.Vector2[] uv8)
        {
            fixed (global::UnityEngine.Vector2* uv8Pointer = uv8)
            {
                UnityEngineMesh__set__uv8(selfObjectId, uv8Pointer, uv8.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineMesh__get__colors(long selfObjectId)
        {
            global::UnityEngine.Color* colorsIdsPointer = default;
            int colorsWasmLength = default;
            UnityEngineMesh__get__colors(selfObjectId, &colorsIdsPointer, &colorsWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[colorsWasmLength];
            for (int i = 0; i < colorsWasmLength; i++)
            {
                returnResult[i] = colorsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__colors(long selfObjectId, global::UnityEngine.Color[] colors)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineMesh__set__colors(selfObjectId, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32[] internal_UnityEngineMesh__get__colors32(long selfObjectId)
        {
            global::UnityEngine.Color32* colors32IdsPointer = default;
            int colors32WasmLength = default;
            UnityEngineMesh__get__colors32(selfObjectId, &colors32IdsPointer, &colors32WasmLength);
            global::UnityEngine.Color32[] returnResult = new global::UnityEngine.Color32[colors32WasmLength];
            for (int i = 0; i < colors32WasmLength; i++)
            {
                returnResult[i] = colors32IdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colors32IdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__colors32(long selfObjectId, global::UnityEngine.Color32[] colors32)
        {
            fixed (global::UnityEngine.Color32* colors32Pointer = colors32)
            {
                UnityEngineMesh__set__colors32(selfObjectId, colors32Pointer, colors32.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__get__vertexAttributeCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__get__vertexAttributeCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMesh__get__triangles(long selfObjectId)
        {
            int* trianglesIdsPointer = default;
            int trianglesWasmLength = default;
            UnityEngineMesh__get__triangles(selfObjectId, &trianglesIdsPointer, &trianglesWasmLength);
            int[] returnResult = new int[trianglesWasmLength];
            for (int i = 0; i < trianglesWasmLength; i++)
            {
                returnResult[i] = trianglesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)trianglesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__triangles(long selfObjectId, global::System.Int32[] triangles)
        {
            fixed (int* trianglesPointer = triangles)
            {
                UnityEngineMesh__set__triangles(selfObjectId, trianglesPointer, triangles.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.BoneWeight[] internal_UnityEngineMesh__get__boneWeights(long selfObjectId)
        {
            global::UnityEngine.BoneWeight* boneWeightsIdsPointer = default;
            int boneWeightsWasmLength = default;
            UnityEngineMesh__get__boneWeights(selfObjectId, &boneWeightsIdsPointer, &boneWeightsWasmLength);
            global::UnityEngine.BoneWeight[] returnResult = new global::UnityEngine.BoneWeight[boneWeightsWasmLength];
            for (int i = 0; i < boneWeightsWasmLength; i++)
            {
                returnResult[i] = boneWeightsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)boneWeightsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__set__boneWeights(long selfObjectId, global::UnityEngine.BoneWeight[] boneWeights)
        {
            fixed (global::UnityEngine.BoneWeight* boneWeightsPointer = boneWeights)
            {
                UnityEngineMesh__set__boneWeights(selfObjectId, boneWeightsPointer, boneWeights.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndexBufferParams__SystemInt32__UnityEngineRenderingIndexFormatEnum__SystemVoid(long selfObjectId, int indexCount, global::UnityEngine.Rendering.IndexFormat format)
        {
            UnityEngineMesh__func__SetIndexBufferParams__SystemInt32__UnityEngineRenderingIndexFormatEnum__SystemVoid(selfObjectId, indexCount, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.VertexAttributeDescriptor internal_UnityEngineMesh__func__GetVertexAttribute__SystemInt32__UnityEngineRenderingVertexAttributeDescriptor(long selfObjectId, int index)
        {
            global::UnityEngine.Rendering.VertexAttributeDescriptor returnResultValue = default;
            UnityEngineMesh__func__GetVertexAttribute__SystemInt32__UnityEngineRenderingVertexAttributeDescriptor(selfObjectId, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.VertexAttributeDescriptor returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMesh__func__HasVertexAttribute__UnityEngineRenderingVertexAttributeEnum__SystemBoolean(long selfObjectId, global::UnityEngine.Rendering.VertexAttribute attr)
        {
            var methodCallResult = UnityEngineMesh__func__HasVertexAttribute__UnityEngineRenderingVertexAttributeEnum__SystemBoolean(selfObjectId, (int) attr);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexAttributeDimension__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, global::UnityEngine.Rendering.VertexAttribute attr)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexAttributeDimension__UnityEngineRenderingVertexAttributeEnum__SystemInt32(selfObjectId, (int) attr);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.VertexAttributeFormat internal_UnityEngineMesh__func__GetVertexAttributeFormat__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum(long selfObjectId, global::UnityEngine.Rendering.VertexAttribute attr)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexAttributeFormat__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum(selfObjectId, (int) attr);
            var returnResult = (global::UnityEngine.Rendering.VertexAttributeFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexAttributeStream__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, global::UnityEngine.Rendering.VertexAttribute attr)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexAttributeStream__UnityEngineRenderingVertexAttributeEnum__SystemInt32(selfObjectId, (int) attr);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexAttributeOffset__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, global::UnityEngine.Rendering.VertexAttribute attr)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexAttributeOffset__UnityEngineRenderingVertexAttributeEnum__SystemInt32(selfObjectId, (int) attr);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexBufferStride__SystemInt32__SystemInt32(long selfObjectId, int stream)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexBufferStride__SystemInt32__SystemInt32(selfObjectId, stream);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__ClearBlendShapes__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__ClearBlendShapes__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMesh__func__GetBlendShapeName__SystemInt32__SystemString(long selfObjectId, int shapeIndex)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetBlendShapeName__SystemInt32__SystemString(selfObjectId, shapeIndex, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetBlendShapeIndex__SystemString__SystemInt32(long selfObjectId, string blendShapeName)
        {
            fixed (char* blendShapeNamePointer = blendShapeName)
            {
                var methodCallResult = UnityEngineMesh__func__GetBlendShapeIndex__SystemString__SystemInt32(selfObjectId, blendShapeNamePointer, blendShapeName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetBlendShapeFrameCount__SystemInt32__SystemInt32(long selfObjectId, int shapeIndex)
        {
            var methodCallResult = UnityEngineMesh__func__GetBlendShapeFrameCount__SystemInt32__SystemInt32(selfObjectId, shapeIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMesh__func__GetBlendShapeFrameWeight__SystemInt32__SystemInt32__SystemSingle(long selfObjectId, int shapeIndex, int frameIndex)
        {
            var methodCallResult = UnityEngineMesh__func__GetBlendShapeFrameWeight__SystemInt32__SystemInt32__SystemSingle(selfObjectId, shapeIndex, frameIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetBlendShapeFrameVertices__SystemInt32__SystemInt32__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(long selfObjectId, int shapeIndex, int frameIndex, global::UnityEngine.Vector3[] deltaVertices, global::UnityEngine.Vector3[] deltaNormals, global::UnityEngine.Vector3[] deltaTangents)
        {
            fixed (global::UnityEngine.Vector3* deltaVerticesPointer = deltaVertices, deltaNormalsPointer = deltaNormals, deltaTangentsPointer = deltaTangents)
            {
                UnityEngineMesh__func__GetBlendShapeFrameVertices__SystemInt32__SystemInt32__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(selfObjectId, shapeIndex, frameIndex, deltaVerticesPointer, deltaVertices.Length, deltaNormalsPointer, deltaNormals.Length, deltaTangentsPointer, deltaTangents.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__AddBlendShapeFrame__SystemString__SystemSingle__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(long selfObjectId, string shapeName, float frameWeight, global::UnityEngine.Vector3[] deltaVertices, global::UnityEngine.Vector3[] deltaNormals, global::UnityEngine.Vector3[] deltaTangents)
        {
            fixed (char* shapeNamePointer = shapeName)
            {
                fixed (global::UnityEngine.Vector3* deltaVerticesPointer = deltaVertices, deltaNormalsPointer = deltaNormals, deltaTangentsPointer = deltaTangents)
                {
                    UnityEngineMesh__func__AddBlendShapeFrame__SystemString__SystemSingle__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(selfObjectId, shapeNamePointer, shapeName.Length * sizeof(char), frameWeight, deltaVerticesPointer, deltaVertices.Length, deltaNormalsPointer, deltaNormals.Length, deltaTangentsPointer, deltaTangents.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int index, global::UnityEngine.Rendering.SubMeshDescriptor desc, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            UnityEngineMesh__func__SetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, index, Unsafe.AsPointer(ref desc), (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.SubMeshDescriptor internal_UnityEngineMesh__func__GetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor(long selfObjectId, int index)
        {
            global::UnityEngine.Rendering.SubMeshDescriptor returnResultValue = default;
            UnityEngineMesh__func__GetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor(selfObjectId, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.SubMeshDescriptor returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__MarkModified__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__MarkModified__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMesh__func__GetUVDistributionMetric__SystemInt32__SystemSingle(long selfObjectId, int uvSetIndex)
        {
            var methodCallResult = UnityEngineMesh__func__GetUVDistributionMetric__SystemInt32__SystemSingle(selfObjectId, uvSetIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> verticesList)
        {
            Span<global::UnityEngine.Vector3> vertices = CollectionsMarshal.AsSpan(verticesList);
            fixed (global::UnityEngine.Vector3* verticesPointer = vertices)
            {
                UnityEngineMesh__func__GetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, verticesPointer, vertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVerticesList)
        {
            Span<global::UnityEngine.Vector3> inVertices = CollectionsMarshal.AsSpan(inVerticesList);
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVerticesList, int start, int length)
        {
            Span<global::UnityEngine.Vector3> inVertices = CollectionsMarshal.AsSpan(inVerticesList);
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inVerticesList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector3> inVertices = CollectionsMarshal.AsSpan(inVerticesList);
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inVertices)
        {
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inVertices, int start, int length)
        {
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inVertices, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector3* inVerticesPointer = inVertices)
            {
                UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inVerticesPointer, inVertices.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> normalsList)
        {
            Span<global::UnityEngine.Vector3> normals = CollectionsMarshal.AsSpan(normalsList);
            fixed (global::UnityEngine.Vector3* normalsPointer = normals)
            {
                UnityEngineMesh__func__GetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, normalsPointer, normals.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormalsList)
        {
            Span<global::UnityEngine.Vector3> inNormals = CollectionsMarshal.AsSpan(inNormalsList);
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormalsList, int start, int length)
        {
            Span<global::UnityEngine.Vector3> inNormals = CollectionsMarshal.AsSpan(inNormalsList);
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector3> inNormalsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector3> inNormals = CollectionsMarshal.AsSpan(inNormalsList);
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inNormals)
        {
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inNormals, int start, int length)
        {
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] inNormals, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector3* inNormalsPointer = inNormals)
            {
                UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inNormalsPointer, inNormals.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> tangentsList)
        {
            Span<global::UnityEngine.Vector4> tangents = CollectionsMarshal.AsSpan(tangentsList);
            fixed (global::UnityEngine.Vector4* tangentsPointer = tangents)
            {
                UnityEngineMesh__func__GetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, tangentsPointer, tangents.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangentsList)
        {
            Span<global::UnityEngine.Vector4> inTangents = CollectionsMarshal.AsSpan(inTangentsList);
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangentsList, int start, int length)
        {
            Span<global::UnityEngine.Vector4> inTangents = CollectionsMarshal.AsSpan(inTangentsList);
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> inTangentsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector4> inTangents = CollectionsMarshal.AsSpan(inTangentsList);
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector4[] inTangents)
        {
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Vector4[] inTangents, int start, int length)
        {
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector4[] inTangents, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector4* inTangentsPointer = inTangents)
            {
                UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inTangentsPointer, inTangents.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color> colorsList)
        {
            Span<global::UnityEngine.Color> colors = CollectionsMarshal.AsSpan(colorsList);
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color> inColorsList)
        {
            Span<global::UnityEngine.Color> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, inColorsPointer, inColors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color> inColorsList, int start, int length)
        {
            Span<global::UnityEngine.Color> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color> inColorsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Color> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemVoid(long selfObjectId, global::UnityEngine.Color[] inColors)
        {
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemVoid(selfObjectId, inColorsPointer, inColors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Color[] inColors, int start, int length)
        {
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Color[] inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Color* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color32> colorsList)
        {
            Span<global::UnityEngine.Color32> colors = CollectionsMarshal.AsSpan(colorsList);
            fixed (global::UnityEngine.Color32* colorsPointer = colors)
            {
                UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(selfObjectId, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color32> inColorsList)
        {
            Span<global::UnityEngine.Color32> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(selfObjectId, inColorsPointer, inColors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color32> inColorsList, int start, int length)
        {
            Span<global::UnityEngine.Color32> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Color32> inColorsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Color32> inColors = CollectionsMarshal.AsSpan(inColorsList);
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemVoid(long selfObjectId, global::UnityEngine.Color32[] inColors)
        {
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemVoid(selfObjectId, inColorsPointer, inColors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Color32[] inColors, int start, int length)
        {
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Color32[] inColors, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Color32* inColorsPointer = inColors)
            {
                UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, inColorsPointer, inColors.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvsList)
        {
            Span<global::UnityEngine.Vector2> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvsList)
        {
            Span<global::UnityEngine.Vector3> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvsList)
        {
            Span<global::UnityEngine.Vector4> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvsList, int start, int length)
        {
            Span<global::UnityEngine.Vector2> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector2> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvsList, int start, int length)
        {
            Span<global::UnityEngine.Vector3> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector3> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvsList, int start, int length)
        {
            Span<global::UnityEngine.Vector4> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvsList, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Vector4> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector2[] uvs)
        {
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector3[] uvs)
        {
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector4[] uvs)
        {
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector2[] uvs, int start, int length)
        {
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector2[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector3[] uvs, int start, int length)
        {
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector3[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector4[] uvs, int start, int length)
        {
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, global::UnityEngine.Vector4[] uvs, int start, int length, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length, start, length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvsList)
        {
            Span<global::UnityEngine.Vector2> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector2* uvsPointer = uvs)
            {
                UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector3> uvsList)
        {
            Span<global::UnityEngine.Vector3> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector3* uvsPointer = uvs)
            {
                UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int channel, global::System.Collections.Generic.List<global::UnityEngine.Vector4> uvsList)
        {
            Span<global::UnityEngine.Vector4> uvs = CollectionsMarshal.AsSpan(uvsList);
            fixed (global::UnityEngine.Vector4* uvsPointer = uvs)
            {
                UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, channel, uvsPointer, uvs.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.VertexAttributeDescriptor[] internal_UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray(long selfObjectId)
        {
            global::UnityEngine.Rendering.VertexAttributeDescriptor* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray(selfObjectId, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Rendering.VertexAttributeDescriptor[] returnResult = new global::UnityEngine.Rendering.VertexAttributeDescriptor[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray__SystemInt32(long selfObjectId, global::UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
        {
            fixed (global::UnityEngine.Rendering.VertexAttributeDescriptor* attributesPointer = attributes)
            {
                var methodCallResult = UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray__SystemInt32(selfObjectId, attributesPointer, attributes.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMesh__func__GetVertexAttributes__SystemCollectionsGeneric_List_UnityEngineRenderingVertexAttributeDescriptor__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.VertexAttributeDescriptor> attributesList)
        {
            Span<global::UnityEngine.Rendering.VertexAttributeDescriptor> attributes = CollectionsMarshal.AsSpan(attributesList);
            fixed (global::UnityEngine.Rendering.VertexAttributeDescriptor* attributesPointer = attributes)
            {
                var methodCallResult = UnityEngineMesh__func__GetVertexAttributes__SystemCollectionsGeneric_List_UnityEngineRenderingVertexAttributeDescriptor__SystemInt32(selfObjectId, attributesPointer, attributes.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetVertexBufferParams__SystemInt32__UnityEngineRenderingVertexAttributeDescriptorArray__SystemVoid(long selfObjectId, int vertexCount, global::UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
        {
            fixed (global::UnityEngine.Rendering.VertexAttributeDescriptor* attributesPointer = attributes)
            {
                UnityEngineMesh__func__SetVertexBufferParams__SystemInt32__UnityEngineRenderingVertexAttributeDescriptorArray__SystemVoid(selfObjectId, vertexCount, attributesPointer, attributes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer internal_UnityEngineMesh__func__GetVertexBuffer__SystemInt32__UnityEngineGraphicsBuffer(long selfObjectId, int index)
        {
            var methodCallResult = UnityEngineMesh__func__GetVertexBuffer__SystemInt32__UnityEngineGraphicsBuffer(selfObjectId, index);
            var returnResult = new global::UnityEngine.GraphicsBuffer(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GraphicsBuffer internal_UnityEngineMesh__func__GetIndexBuffer__UnityEngineGraphicsBuffer(long selfObjectId)
        {
            var methodCallResult = UnityEngineMesh__func__GetIndexBuffer__UnityEngineGraphicsBuffer(selfObjectId);
            var returnResult = new global::UnityEngine.GraphicsBuffer(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMesh__func__GetTriangles__SystemInt32__SystemInt32Array(long selfObjectId, int submesh)
        {
            int* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetTriangles__SystemInt32__SystemInt32Array(selfObjectId, submesh, &returnResultIdsPointer, &returnResultWasmLength);
            int[] returnResult = new int[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMesh__func__GetTriangles__SystemInt32__SystemBoolean__SystemInt32Array(long selfObjectId, int submesh, bool applyBaseVertex)
        {
            var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
            int* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetTriangles__SystemInt32__SystemBoolean__SystemInt32Array(selfObjectId, submesh, applyBaseVertexConverted, &returnResultIdsPointer, &returnResultWasmLength);
            int[] returnResult = new int[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int submesh)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int submesh, bool applyBaseVertex)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
                UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, applyBaseVertexConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> trianglesList, int submesh, bool applyBaseVertex)
        {
            Span<ushort> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (ushort* trianglesPointer = triangles)
            {
                var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
                UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, applyBaseVertexConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMesh__func__GetIndices__SystemInt32__SystemInt32Array(long selfObjectId, int submesh)
        {
            int* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetIndices__SystemInt32__SystemInt32Array(selfObjectId, submesh, &returnResultIdsPointer, &returnResultWasmLength);
            int[] returnResult = new int[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMesh__func__GetIndices__SystemInt32__SystemBoolean__SystemInt32Array(long selfObjectId, int submesh, bool applyBaseVertex)
        {
            var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
            int* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMesh__func__GetIndices__SystemInt32__SystemBoolean__SystemInt32Array(selfObjectId, submesh, applyBaseVertexConverted, &returnResultIdsPointer, &returnResultWasmLength);
            int[] returnResult = new int[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> indicesList, int submesh)
        {
            Span<int> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (int* indicesPointer = indices)
            {
                UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, submesh);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> indicesList, int submesh, bool applyBaseVertex)
        {
            Span<int> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (int* indicesPointer = indices)
            {
                var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
                UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, indicesPointer, indices.Length, submesh, applyBaseVertexConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> indicesList, int submesh, bool applyBaseVertex)
        {
            Span<ushort> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (ushort* indicesPointer = indices)
            {
                var applyBaseVertexConverted = Unsafe.As<bool, int>(ref applyBaseVertex);
                UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, indicesPointer, indices.Length, submesh, applyBaseVertexConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineMesh__func__GetIndexStart__SystemInt32__SystemUInt32(long selfObjectId, int submesh)
        {
            var methodCallResult = UnityEngineMesh__func__GetIndexStart__SystemInt32__SystemUInt32(selfObjectId, submesh);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineMesh__func__GetIndexCount__SystemInt32__SystemUInt32(long selfObjectId, int submesh)
        {
            var methodCallResult = UnityEngineMesh__func__GetIndexCount__SystemInt32__SystemUInt32(selfObjectId, submesh);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineMesh__func__GetBaseVertex__SystemInt32__SystemUInt32(long selfObjectId, int submesh)
        {
            var methodCallResult = UnityEngineMesh__func__GetBaseVertex__SystemInt32__SystemUInt32(selfObjectId, submesh);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] triangles, int submesh)
        {
            fixed (int* trianglesPointer = triangles)
            {
                UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Int32[] triangles, int submesh, bool calculateBounds)
        {
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, trianglesStart, trianglesLength, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.UInt16[] triangles, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (ushort* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (ushort* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, trianglesStart, trianglesLength, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int submesh)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int submesh, bool calculateBounds)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> trianglesList, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<int> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (int* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, trianglesStart, trianglesLength, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> trianglesList, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<ushort> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (ushort* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> trianglesList, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<ushort> triangles = CollectionsMarshal.AsSpan(trianglesList);
            fixed (ushort* trianglesPointer = triangles)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, trianglesPointer, triangles.Length, trianglesStart, trianglesLength, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh)
        {
            fixed (int* indicesPointer = indices)
            {
                UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds)
        {
            fixed (int* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh, calculateBoundsConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (int* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemInt32Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Int32[] indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (int* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemInt32Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, indicesStart, indicesLength, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemUInt16Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.UInt16[] indices, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (ushort* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemUInt16Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemUInt16Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.UInt16[] indices, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            fixed (ushort* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemUInt16Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, indicesStart, indicesLength, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> indicesList, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<int> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (int* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> indicesList, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<int> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (int* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, indicesStart, indicesLength, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> indicesList, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<ushort> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (ushort* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<ushort> indicesList, int indicesStart, int indicesLength, global::UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
        {
            Span<ushort> indices = CollectionsMarshal.AsSpan(indicesList);
            fixed (ushort* indicesPointer = indices)
            {
                var calculateBoundsConverted = Unsafe.As<bool, int>(ref calculateBounds);
                UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(selfObjectId, indicesPointer, indices.Length, indicesStart, indicesLength, (int) topology, submesh, calculateBoundsConverted, baseVertex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Rendering.SubMeshDescriptor* descPointer = desc)
            {
                UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, descPointer, desc.Length, start, count, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.SubMeshDescriptor[] desc, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            fixed (global::UnityEngine.Rendering.SubMeshDescriptor* descPointer = desc)
            {
                UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, descPointer, desc.Length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.SubMeshDescriptor> descList, int start, int count, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Rendering.SubMeshDescriptor> desc = CollectionsMarshal.AsSpan(descList);
            fixed (global::UnityEngine.Rendering.SubMeshDescriptor* descPointer = desc)
            {
                UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, descPointer, desc.Length, start, count, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.SubMeshDescriptor> descList, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            Span<global::UnityEngine.Rendering.SubMeshDescriptor> desc = CollectionsMarshal.AsSpan(descList);
            fixed (global::UnityEngine.Rendering.SubMeshDescriptor* descPointer = desc)
            {
                UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, descPointer, desc.Length, (int) flags);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetBindposes__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> bindposesList)
        {
            Span<global::UnityEngine.Matrix4x4> bindposes = CollectionsMarshal.AsSpan(bindposesList);
            fixed (global::UnityEngine.Matrix4x4* bindposesPointer = bindposes)
            {
                UnityEngineMesh__func__GetBindposes__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, bindposesPointer, bindposes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__GetBoneWeights__SystemCollectionsGeneric_List_UnityEngineBoneWeight__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.BoneWeight> boneWeightsList)
        {
            Span<global::UnityEngine.BoneWeight> boneWeights = CollectionsMarshal.AsSpan(boneWeightsList);
            fixed (global::UnityEngine.BoneWeight* boneWeightsPointer = boneWeights)
            {
                UnityEngineMesh__func__GetBoneWeights__SystemCollectionsGeneric_List_UnityEngineBoneWeight__SystemVoid(selfObjectId, boneWeightsPointer, boneWeights.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__Clear__SystemBoolean__SystemVoid(long selfObjectId, bool keepVertexLayout)
        {
            var keepVertexLayoutConverted = Unsafe.As<bool, int>(ref keepVertexLayout);
            UnityEngineMesh__func__Clear__SystemBoolean__SystemVoid(selfObjectId, keepVertexLayoutConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__Clear__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__Clear__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateBounds__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__RecalculateBounds__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateNormals__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__RecalculateNormals__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateTangents__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__RecalculateTangents__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateBounds__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            UnityEngineMesh__func__RecalculateBounds__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateNormals__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            UnityEngineMesh__func__RecalculateNormals__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateTangents__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.MeshUpdateFlags flags)
        {
            UnityEngineMesh__func__RecalculateTangents__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(selfObjectId, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateUVDistributionMetric__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int uvSetIndex, float uvAreaThreshold)
        {
            UnityEngineMesh__func__RecalculateUVDistributionMetric__SystemInt32__SystemSingle__SystemVoid(selfObjectId, uvSetIndex, uvAreaThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__RecalculateUVDistributionMetrics__SystemSingle__SystemVoid(long selfObjectId, float uvAreaThreshold)
        {
            UnityEngineMesh__func__RecalculateUVDistributionMetrics__SystemSingle__SystemVoid(selfObjectId, uvAreaThreshold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__MarkDynamic__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__MarkDynamic__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__UploadMeshData__SystemBoolean__SystemVoid(long selfObjectId, bool markNoLongerReadable)
        {
            var markNoLongerReadableConverted = Unsafe.As<bool, int>(ref markNoLongerReadable);
            UnityEngineMesh__func__UploadMeshData__SystemBoolean__SystemVoid(selfObjectId, markNoLongerReadableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__Optimize__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__Optimize__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__OptimizeIndexBuffers__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__OptimizeIndexBuffers__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__OptimizeReorderVertexBuffer__SystemVoid(long selfObjectId)
        {
            UnityEngineMesh__func__OptimizeReorderVertexBuffer__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MeshTopology internal_UnityEngineMesh__func__GetTopology__SystemInt32__UnityEngineMeshTopologyEnum(long selfObjectId, int submesh)
        {
            var methodCallResult = UnityEngineMesh__func__GetTopology__SystemInt32__UnityEngineMeshTopologyEnum(selfObjectId, submesh);
            var returnResult = (global::UnityEngine.MeshTopology)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
        {
            fixed (global::UnityEngine.CombineInstance* combinePointer = combine)
            {
                var mergeSubMeshesConverted = Unsafe.As<bool, int>(ref mergeSubMeshes);
                var useMatricesConverted = Unsafe.As<bool, int>(ref useMatrices);
                var hasLightmapDataConverted = Unsafe.As<bool, int>(ref hasLightmapData);
                UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, combinePointer, combine.Length, mergeSubMeshesConverted, useMatricesConverted, hasLightmapDataConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices)
        {
            fixed (global::UnityEngine.CombineInstance* combinePointer = combine)
            {
                var mergeSubMeshesConverted = Unsafe.As<bool, int>(ref mergeSubMeshes);
                var useMatricesConverted = Unsafe.As<bool, int>(ref useMatrices);
                UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, combinePointer, combine.Length, mergeSubMeshesConverted, useMatricesConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.CombineInstance[] combine, bool mergeSubMeshes)
        {
            fixed (global::UnityEngine.CombineInstance* combinePointer = combine)
            {
                var mergeSubMeshesConverted = Unsafe.As<bool, int>(ref mergeSubMeshes);
                UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemVoid(selfObjectId, combinePointer, combine.Length, mergeSubMeshesConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemVoid(long selfObjectId, global::UnityEngine.CombineInstance[] combine)
        {
            fixed (global::UnityEngine.CombineInstance* combinePointer = combine)
            {
                UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemVoid(selfObjectId, combinePointer, combine.Length);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMesh__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__indexFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__set__indexFormat(long selfObjectId, int indexFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__vertexBufferCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__vertexBufferTarget(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__set__vertexBufferTarget(long selfObjectId, int vertexBufferTargetUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__indexBufferTarget(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__set__indexBufferTarget(long selfObjectId, int indexBufferTargetUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__blendShapeCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__bindposes(long selfObjectId, void* bindposesIdsPointer, void* bindposesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__bindposes(long selfObjectId, void* bindposesPointer, int bindposesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__isReadable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__vertexCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__subMeshCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__set__subMeshCount(long selfObjectId, int subMeshCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__bounds(long selfObjectId, void* boundsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__vertices(long selfObjectId, void* verticesIdsPointer, void* verticesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__vertices(long selfObjectId, void* verticesPointer, int verticesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__normals(long selfObjectId, void* normalsIdsPointer, void* normalsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__normals(long selfObjectId, void* normalsPointer, int normalsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__tangents(long selfObjectId, void* tangentsIdsPointer, void* tangentsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__tangents(long selfObjectId, void* tangentsPointer, int tangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv(long selfObjectId, void* uvIdsPointer, void* uvWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv(long selfObjectId, void* uvPointer, int uvWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv2(long selfObjectId, void* uv2IdsPointer, void* uv2WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv2(long selfObjectId, void* uv2Pointer, int uv2WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv3(long selfObjectId, void* uv3IdsPointer, void* uv3WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv3(long selfObjectId, void* uv3Pointer, int uv3WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv4(long selfObjectId, void* uv4IdsPointer, void* uv4WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv4(long selfObjectId, void* uv4Pointer, int uv4WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv5(long selfObjectId, void* uv5IdsPointer, void* uv5WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv5(long selfObjectId, void* uv5Pointer, int uv5WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv6(long selfObjectId, void* uv6IdsPointer, void* uv6WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv6(long selfObjectId, void* uv6Pointer, int uv6WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv7(long selfObjectId, void* uv7IdsPointer, void* uv7WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv7(long selfObjectId, void* uv7Pointer, int uv7WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__uv8(long selfObjectId, void* uv8IdsPointer, void* uv8WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__uv8(long selfObjectId, void* uv8Pointer, int uv8WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__colors(long selfObjectId, void* colorsIdsPointer, void* colorsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__colors(long selfObjectId, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__colors32(long selfObjectId, void* colors32IdsPointer, void* colors32WasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__colors32(long selfObjectId, void* colors32Pointer, int colors32WasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__get__vertexAttributeCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__triangles(long selfObjectId, void* trianglesIdsPointer, void* trianglesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__triangles(long selfObjectId, void* trianglesPointer, int trianglesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__get__boneWeights(long selfObjectId, void* boneWeightsIdsPointer, void* boneWeightsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__set__boneWeights(long selfObjectId, void* boneWeightsPointer, int boneWeightsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__SetIndexBufferParams__SystemInt32__UnityEngineRenderingIndexFormatEnum__SystemVoid(long selfObjectId, int indexCount, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetVertexAttribute__SystemInt32__UnityEngineRenderingVertexAttributeDescriptor(long selfObjectId, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__HasVertexAttribute__UnityEngineRenderingVertexAttributeEnum__SystemBoolean(long selfObjectId, int attrUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetVertexAttributeDimension__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, int attrUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetVertexAttributeFormat__UnityEngineRenderingVertexAttributeEnum__UnityEngineRenderingVertexAttributeFormatEnum(long selfObjectId, int attrUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetVertexAttributeStream__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, int attrUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetVertexAttributeOffset__UnityEngineRenderingVertexAttributeEnum__SystemInt32(long selfObjectId, int attrUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetVertexBufferStride__SystemInt32__SystemInt32(long selfObjectId, int stream);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__ClearBlendShapes__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetBlendShapeName__SystemInt32__SystemString(long selfObjectId, int shapeIndex, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMesh__func__GetBlendShapeIndex__SystemString__SystemInt32(long selfObjectId, void* blendShapeNamePointer, int blendShapeNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetBlendShapeFrameCount__SystemInt32__SystemInt32(long selfObjectId, int shapeIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMesh__func__GetBlendShapeFrameWeight__SystemInt32__SystemInt32__SystemSingle(long selfObjectId, int shapeIndex, int frameIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetBlendShapeFrameVertices__SystemInt32__SystemInt32__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(long selfObjectId, int shapeIndex, int frameIndex, void* deltaVerticesPointer, int deltaVerticesWasmLength, void* deltaNormalsPointer, int deltaNormalsWasmLength, void* deltaTangentsPointer, int deltaTangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__AddBlendShapeFrame__SystemString__SystemSingle__UnityEngineVector3Array__UnityEngineVector3Array__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* shapeNamePointer, int shapeNameWasmLength, float frameWeight, void* deltaVerticesPointer, int deltaVerticesWasmLength, void* deltaNormalsPointer, int deltaNormalsWasmLength, void* deltaTangentsPointer, int deltaTangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int index, void* descPointer, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetSubMesh__SystemInt32__UnityEngineRenderingSubMeshDescriptor(long selfObjectId, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__MarkModified__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMesh__func__GetUVDistributionMetric__SystemInt32__SystemSingle(long selfObjectId, int uvSetIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, void* verticesPointer, int verticesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertices__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inVerticesPointer, int inVerticesWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, void* normalsPointer, int normalsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetNormals__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inNormalsPointer, int inNormalsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* tangentsPointer, int tangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTangents__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inTangentsPointer, int inTangentsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__SystemCollectionsGeneric_List_UnityEngineColor32__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetColors__UnityEngineColor32Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* inColorsPointer, int inColorsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector2Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector3Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetUVs__SystemInt32__UnityEngineVector4Array__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength, int start, int length, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector2__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector3__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetUVs__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int channel, void* uvsPointer, int uvsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray(long selfObjectId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMesh__func__GetVertexAttributes__UnityEngineRenderingVertexAttributeDescriptorArray__SystemInt32(long selfObjectId, void* attributesPointer, int attributesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMesh__func__GetVertexAttributes__SystemCollectionsGeneric_List_UnityEngineRenderingVertexAttributeDescriptor__SystemInt32(long selfObjectId, void* attributesPointer, int attributesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetVertexBufferParams__SystemInt32__UnityEngineRenderingVertexAttributeDescriptorArray__SystemVoid(long selfObjectId, int vertexCount, void* attributesPointer, int attributesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMesh__func__GetVertexBuffer__SystemInt32__UnityEngineGraphicsBuffer(long selfObjectId, int index);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMesh__func__GetIndexBuffer__UnityEngineGraphicsBuffer(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTriangles__SystemInt32__SystemInt32Array(long selfObjectId, int submesh, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTriangles__SystemInt32__SystemBoolean__SystemInt32Array(long selfObjectId, int submesh, int applyBaseVertexConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int applyBaseVertexConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int applyBaseVertexConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetIndices__SystemInt32__SystemInt32Array(long selfObjectId, int submesh, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetIndices__SystemInt32__SystemBoolean__SystemInt32Array(long selfObjectId, int submesh, int applyBaseVertexConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int submesh, int applyBaseVertexConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int submesh, int applyBaseVertexConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetIndexStart__SystemInt32__SystemUInt32(long selfObjectId, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetIndexCount__SystemInt32__SystemUInt32(long selfObjectId, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetBaseVertex__SystemInt32__SystemUInt32(long selfObjectId, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemInt32Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int trianglesStart, int trianglesLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemUInt16Array__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int trianglesStart, int trianglesLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int trianglesStart, int trianglesLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetTriangles__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* trianglesPointer, int trianglesWasmLength, int trianglesStart, int trianglesLength, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemInt32Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemInt32Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int indicesStart, int indicesLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemUInt16Array__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemUInt16Array__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int indicesStart, int indicesLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemInt32__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int indicesStart, int indicesLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetIndices__SystemCollectionsGeneric_List_SystemUInt16__SystemInt32__SystemInt32__UnityEngineMeshTopologyEnum__SystemInt32__SystemBoolean__SystemInt32__SystemVoid(long selfObjectId, void* indicesPointer, int indicesWasmLength, int indicesStart, int indicesLength, int topologyUnderlyingValue, int submesh, int calculateBoundsConverted, int baseVertex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* descPointer, int descWasmLength, int start, int count, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetSubMeshes__UnityEngineRenderingSubMeshDescriptorArray__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* descPointer, int descWasmLength, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__SystemInt32__SystemInt32__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* descPointer, int descWasmLength, int start, int count, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__SetSubMeshes__SystemCollectionsGeneric_List_UnityEngineRenderingSubMeshDescriptor__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, void* descPointer, int descWasmLength, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetBindposes__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* bindposesPointer, int bindposesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__GetBoneWeights__SystemCollectionsGeneric_List_UnityEngineBoneWeight__SystemVoid(long selfObjectId, void* boneWeightsPointer, int boneWeightsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__Clear__SystemBoolean__SystemVoid(long selfObjectId, int keepVertexLayoutConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__Clear__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateBounds__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateNormals__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateTangents__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateBounds__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateNormals__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateTangents__UnityEngineRenderingMeshUpdateFlagsEnum__SystemVoid(long selfObjectId, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateUVDistributionMetric__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int uvSetIndex, float uvAreaThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__RecalculateUVDistributionMetrics__SystemSingle__SystemVoid(long selfObjectId, float uvAreaThreshold);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__MarkDynamic__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__UploadMeshData__SystemBoolean__SystemVoid(long selfObjectId, int markNoLongerReadableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__Optimize__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__OptimizeIndexBuffers__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMesh__func__OptimizeReorderVertexBuffer__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMesh__func__GetTopology__SystemInt32__UnityEngineMeshTopologyEnum(long selfObjectId, int submesh);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, void* combinePointer, int combineWasmLength, int mergeSubMeshesConverted, int useMatricesConverted, int hasLightmapDataConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, void* combinePointer, int combineWasmLength, int mergeSubMeshesConverted, int useMatricesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemBoolean__SystemVoid(long selfObjectId, void* combinePointer, int combineWasmLength, int mergeSubMeshesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMesh__func__CombineMeshes__UnityEngineCombineInstanceArray__SystemVoid(long selfObjectId, void* combinePointer, int combineWasmLength);

        #endregion Imports
    }
}
