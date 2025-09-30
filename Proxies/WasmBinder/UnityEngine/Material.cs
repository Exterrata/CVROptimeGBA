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

    public partial class Material(long id) : Object(id)
    {

        #region Implementation

        public Material(global::UnityEngine.Shader shader)
            : this(internal_UnityEngineMaterial__ctor__UnityEngineShader(shader)) { }

        public Material(global::UnityEngine.Material source)
            : this(internal_UnityEngineMaterial__ctor__UnityEngineMaterial(source)) { }

        public global::UnityEngine.Shader shader 
        {
            get => internal_UnityEngineMaterial__get__shader(WrappedId);
            set => internal_UnityEngineMaterial__set__shader(WrappedId, value);
        }

        public global::UnityEngine.Color color 
        {
            get => internal_UnityEngineMaterial__get__color(WrappedId);
            set => internal_UnityEngineMaterial__set__color(WrappedId, value);
        }

        public global::UnityEngine.Texture mainTexture 
        {
            get => internal_UnityEngineMaterial__get__mainTexture(WrappedId);
            set => internal_UnityEngineMaterial__set__mainTexture(WrappedId, value);
        }

        public global::UnityEngine.Vector2 mainTextureOffset 
        {
            get => internal_UnityEngineMaterial__get__mainTextureOffset(WrappedId);
            set => internal_UnityEngineMaterial__set__mainTextureOffset(WrappedId, value);
        }

        public global::UnityEngine.Vector2 mainTextureScale 
        {
            get => internal_UnityEngineMaterial__get__mainTextureScale(WrappedId);
            set => internal_UnityEngineMaterial__set__mainTextureScale(WrappedId, value);
        }

        public int renderQueue 
        {
            get => internal_UnityEngineMaterial__get__renderQueue(WrappedId);
            set => internal_UnityEngineMaterial__set__renderQueue(WrappedId, value);
        }

        public global::UnityEngine.Rendering.LocalKeyword[] enabledKeywords 
        {
            get => internal_UnityEngineMaterial__get__enabledKeywords(WrappedId);
            set => internal_UnityEngineMaterial__set__enabledKeywords(WrappedId, value);
        }

        public global::UnityEngine.MaterialGlobalIlluminationFlags globalIlluminationFlags 
        {
            get => internal_UnityEngineMaterial__get__globalIlluminationFlags(WrappedId);
            set => internal_UnityEngineMaterial__set__globalIlluminationFlags(WrappedId, value);
        }

        public bool doubleSidedGI 
        {
            get => internal_UnityEngineMaterial__get__doubleSidedGI(WrappedId);
            set => internal_UnityEngineMaterial__set__doubleSidedGI(WrappedId, value);
        }

        public bool enableInstancing 
        {
            get => internal_UnityEngineMaterial__get__enableInstancing(WrappedId);
            set => internal_UnityEngineMaterial__set__enableInstancing(WrappedId, value);
        }

        public int passCount 
        {
            get => internal_UnityEngineMaterial__get__passCount(WrappedId);
        }

        public global::System.String[] shaderKeywords 
        {
            get => internal_UnityEngineMaterial__get__shaderKeywords(WrappedId);
            set => internal_UnityEngineMaterial__set__shaderKeywords(WrappedId, value);
        }

        public bool HasProperty(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasProperty__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasProperty(string name)
        {
            return internal_UnityEngineMaterial__func__HasProperty__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasFloat(string name)
        {
            return internal_UnityEngineMaterial__func__HasFloat__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasFloat(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasFloat__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasInt(string name)
        {
            return internal_UnityEngineMaterial__func__HasInt__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasInt(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasInt__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasInteger(string name)
        {
            return internal_UnityEngineMaterial__func__HasInteger__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasInteger(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasInteger__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasTexture(string name)
        {
            return internal_UnityEngineMaterial__func__HasTexture__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasTexture(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasTexture__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasMatrix(string name)
        {
            return internal_UnityEngineMaterial__func__HasMatrix__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasMatrix(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasMatrix__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasVector(string name)
        {
            return internal_UnityEngineMaterial__func__HasVector__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasVector(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasVector__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasColor(string name)
        {
            return internal_UnityEngineMaterial__func__HasColor__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasColor(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasColor__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasBuffer(string name)
        {
            return internal_UnityEngineMaterial__func__HasBuffer__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasBuffer(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasBuffer__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasConstantBuffer(string name)
        {
            return internal_UnityEngineMaterial__func__HasConstantBuffer__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasConstantBuffer(int nameID)
        {
            return internal_UnityEngineMaterial__func__HasConstantBuffer__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public void EnableKeyword(string keyword)
        {
            internal_UnityEngineMaterial__func__EnableKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public void DisableKeyword(string keyword)
        {
            internal_UnityEngineMaterial__func__DisableKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public bool IsKeywordEnabled(string keyword)
        {
            return internal_UnityEngineMaterial__func__IsKeywordEnabled__SystemString__SystemBoolean(WrappedId, keyword);
        }

        public void EnableKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineMaterial__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void DisableKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineMaterial__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void SetKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            internal_UnityEngineMaterial__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(WrappedId, in keyword, value);
        }

        public bool IsKeywordEnabled(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            return internal_UnityEngineMaterial__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(WrappedId, in keyword);
        }

        public void SetShaderPassEnabled(string passName, bool enabled)
        {
            internal_UnityEngineMaterial__func__SetShaderPassEnabled__SystemString__SystemBoolean__SystemVoid(WrappedId, passName, enabled);
        }

        public bool GetShaderPassEnabled(string passName)
        {
            return internal_UnityEngineMaterial__func__GetShaderPassEnabled__SystemString__SystemBoolean(WrappedId, passName);
        }

        public string GetPassName(int pass)
        {
            return internal_UnityEngineMaterial__func__GetPassName__SystemInt32__SystemString(WrappedId, pass);
        }

        public int FindPass(string passName)
        {
            return internal_UnityEngineMaterial__func__FindPass__SystemString__SystemInt32(WrappedId, passName);
        }

        public void SetOverrideTag(string tag, string val)
        {
            internal_UnityEngineMaterial__func__SetOverrideTag__SystemString__SystemString__SystemVoid(WrappedId, tag, val);
        }

        public string GetTag(string tag, bool searchFallbacks, string defaultValue)
        {
            return internal_UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString__SystemString(WrappedId, tag, searchFallbacks, defaultValue);
        }

        public string GetTag(string tag, bool searchFallbacks)
        {
            return internal_UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString(WrappedId, tag, searchFallbacks);
        }

        public void Lerp(global::UnityEngine.Material start, global::UnityEngine.Material end, float t)
        {
            internal_UnityEngineMaterial__func__Lerp__UnityEngineMaterial__UnityEngineMaterial__SystemSingle__SystemVoid(WrappedId, start, end, t);
        }

        public bool SetPass(int pass)
        {
            return internal_UnityEngineMaterial__func__SetPass__SystemInt32__SystemBoolean(WrappedId, pass);
        }

        public void CopyPropertiesFromMaterial(global::UnityEngine.Material mat)
        {
            internal_UnityEngineMaterial__func__CopyPropertiesFromMaterial__UnityEngineMaterial__SystemVoid(WrappedId, mat);
        }

        public int ComputeCRC()
        {
            return internal_UnityEngineMaterial__func__ComputeCRC__SystemInt32(WrappedId);
        }

        public global::System.String[] GetTexturePropertyNames()
        {
            return internal_UnityEngineMaterial__func__GetTexturePropertyNames__SystemStringArray(WrappedId);
        }

        public global::System.Int32[] GetTexturePropertyNameIDs()
        {
            return internal_UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemInt32Array(WrappedId);
        }

        public void GetTexturePropertyNames(global::System.Collections.Generic.List<string> outNames)
        {
            internal_UnityEngineMaterial__func__GetTexturePropertyNames__SystemCollectionsGeneric_List_SystemString__SystemVoid(WrappedId, outNames);
        }

        public void GetTexturePropertyNameIDs(global::System.Collections.Generic.List<int> outNames)
        {
            internal_UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemCollectionsGeneric_List_SystemInt32__SystemVoid(WrappedId, outNames);
        }

        public void SetInt(string name, int value)
        {
            internal_UnityEngineMaterial__func__SetInt__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetInt(int nameID, int value)
        {
            internal_UnityEngineMaterial__func__SetInt__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetFloat(string name, float value)
        {
            internal_UnityEngineMaterial__func__SetFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, value);
        }

        public void SetFloat(int nameID, float value)
        {
            internal_UnityEngineMaterial__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, nameID, value);
        }

        public void SetInteger(string name, int value)
        {
            internal_UnityEngineMaterial__func__SetInteger__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetInteger(int nameID, int value)
        {
            internal_UnityEngineMaterial__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetColor(string name, global::UnityEngine.Color value)
        {
            internal_UnityEngineMaterial__func__SetColor__SystemString__UnityEngineColor__SystemVoid(WrappedId, name, value);
        }

        public void SetColor(int nameID, global::UnityEngine.Color value)
        {
            internal_UnityEngineMaterial__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(WrappedId, nameID, value);
        }

        public void SetVector(string name, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineMaterial__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(WrappedId, name, value);
        }

        public void SetVector(int nameID, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineMaterial__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, nameID, value);
        }

        public void SetMatrix(string name, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineMaterial__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, name, value);
        }

        public void SetMatrix(int nameID, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineMaterial__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, value);
        }

        public void SetTexture(string name, global::UnityEngine.Texture value)
        {
            internal_UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(WrappedId, name, value);
        }

        public void SetTexture(int nameID, global::UnityEngine.Texture value)
        {
            internal_UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(WrappedId, nameID, value);
        }

        public void SetTexture(string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, name, value, element);
        }

        public void SetTexture(int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, nameID, value, element);
        }

        public void SetBuffer(string name, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetBuffer(int nameID, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetBuffer(string name, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetBuffer(int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, value, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, value, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value, offset, size);
        }

        public void SetFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterial__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, name, values);
        }

        public void SetFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, nameID, values);
        }

        public void SetFloatArray(string name, global::System.Single[] values)
        {
            internal_UnityEngineMaterial__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(WrappedId, name, values);
        }

        public void SetFloatArray(int nameID, global::System.Single[] values)
        {
            internal_UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetColorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Color> values)
        {
            internal_UnityEngineMaterial__func__SetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, name, values);
        }

        public void SetColorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Color> values)
        {
            internal_UnityEngineMaterial__func__SetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, nameID, values);
        }

        public void SetColorArray(string name, global::UnityEngine.Color[] values)
        {
            internal_UnityEngineMaterial__func__SetColorArray__SystemString__UnityEngineColorArray__SystemVoid(WrappedId, name, values);
        }

        public void SetColorArray(int nameID, global::UnityEngine.Color[] values)
        {
            internal_UnityEngineMaterial__func__SetColorArray__SystemInt32__UnityEngineColorArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterial__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, name, values);
        }

        public void SetVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterial__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetVectorArray(string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineMaterial__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineMaterial__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterial__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterial__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineMaterial__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineMaterial__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, nameID, values);
        }

        public int GetInt(string name)
        {
            return internal_UnityEngineMaterial__func__GetInt__SystemString__SystemInt32(WrappedId, name);
        }

        public int GetInt(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetInt__SystemInt32__SystemInt32(WrappedId, nameID);
        }

        public float GetFloat(string name)
        {
            return internal_UnityEngineMaterial__func__GetFloat__SystemString__SystemSingle(WrappedId, name);
        }

        public float GetFloat(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetFloat__SystemInt32__SystemSingle(WrappedId, nameID);
        }

        public int GetInteger(string name)
        {
            return internal_UnityEngineMaterial__func__GetInteger__SystemString__SystemInt32(WrappedId, name);
        }

        public int GetInteger(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetInteger__SystemInt32__SystemInt32(WrappedId, nameID);
        }

        public global::UnityEngine.Color GetColor(string name)
        {
            return internal_UnityEngineMaterial__func__GetColor__SystemString__UnityEngineColor(WrappedId, name);
        }

        public global::UnityEngine.Color GetColor(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetColor__SystemInt32__UnityEngineColor(WrappedId, nameID);
        }

        public global::UnityEngine.Vector4 GetVector(string name)
        {
            return internal_UnityEngineMaterial__func__GetVector__SystemString__UnityEngineVector4(WrappedId, name);
        }

        public global::UnityEngine.Vector4 GetVector(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetVector__SystemInt32__UnityEngineVector4(WrappedId, nameID);
        }

        public global::UnityEngine.Matrix4x4 GetMatrix(string name)
        {
            return internal_UnityEngineMaterial__func__GetMatrix__SystemString__UnityEngineMatrix4x4(WrappedId, name);
        }

        public global::UnityEngine.Matrix4x4 GetMatrix(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(WrappedId, nameID);
        }

        public global::UnityEngine.Texture GetTexture(string name)
        {
            return internal_UnityEngineMaterial__func__GetTexture__SystemString__UnityEngineTexture(WrappedId, name);
        }

        public global::UnityEngine.Texture GetTexture(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetTexture__SystemInt32__UnityEngineTexture(WrappedId, nameID);
        }

        public global::System.Single[] GetFloatArray(string name)
        {
            return internal_UnityEngineMaterial__func__GetFloatArray__SystemString__SystemSingleArray(WrappedId, name);
        }

        public global::System.Single[] GetFloatArray(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemSingleArray(WrappedId, nameID);
        }

        public global::UnityEngine.Color[] GetColorArray(string name)
        {
            return internal_UnityEngineMaterial__func__GetColorArray__SystemString__UnityEngineColorArray(WrappedId, name);
        }

        public global::UnityEngine.Color[] GetColorArray(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetColorArray__SystemInt32__UnityEngineColorArray(WrappedId, nameID);
        }

        public global::UnityEngine.Vector4[] GetVectorArray(string name)
        {
            return internal_UnityEngineMaterial__func__GetVectorArray__SystemString__UnityEngineVector4Array(WrappedId, name);
        }

        public global::UnityEngine.Vector4[] GetVectorArray(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(WrappedId, nameID);
        }

        public global::UnityEngine.Matrix4x4[] GetMatrixArray(string name)
        {
            return internal_UnityEngineMaterial__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(WrappedId, name);
        }

        public global::UnityEngine.Matrix4x4[] GetMatrixArray(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(WrappedId, nameID);
        }

        public void GetFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterial__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, name, values);
        }

        public void GetFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, nameID, values);
        }

        public void GetColorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Color> values)
        {
            internal_UnityEngineMaterial__func__GetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, name, values);
        }

        public void GetColorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Color> values)
        {
            internal_UnityEngineMaterial__func__GetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(WrappedId, nameID, values);
        }

        public void GetVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterial__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, name, values);
        }

        public void GetVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterial__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, nameID, values);
        }

        public void GetMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterial__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, name, values);
        }

        public void GetMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterial__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetTextureOffset(string name, global::UnityEngine.Vector2 value)
        {
            internal_UnityEngineMaterial__func__SetTextureOffset__SystemString__UnityEngineVector2__SystemVoid(WrappedId, name, value);
        }

        public void SetTextureOffset(int nameID, global::UnityEngine.Vector2 value)
        {
            internal_UnityEngineMaterial__func__SetTextureOffset__SystemInt32__UnityEngineVector2__SystemVoid(WrappedId, nameID, value);
        }

        public void SetTextureScale(string name, global::UnityEngine.Vector2 value)
        {
            internal_UnityEngineMaterial__func__SetTextureScale__SystemString__UnityEngineVector2__SystemVoid(WrappedId, name, value);
        }

        public void SetTextureScale(int nameID, global::UnityEngine.Vector2 value)
        {
            internal_UnityEngineMaterial__func__SetTextureScale__SystemInt32__UnityEngineVector2__SystemVoid(WrappedId, nameID, value);
        }

        public global::UnityEngine.Vector2 GetTextureOffset(string name)
        {
            return internal_UnityEngineMaterial__func__GetTextureOffset__SystemString__UnityEngineVector2(WrappedId, name);
        }

        public global::UnityEngine.Vector2 GetTextureOffset(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetTextureOffset__SystemInt32__UnityEngineVector2(WrappedId, nameID);
        }

        public global::UnityEngine.Vector2 GetTextureScale(string name)
        {
            return internal_UnityEngineMaterial__func__GetTextureScale__SystemString__UnityEngineVector2(WrappedId, name);
        }

        public global::UnityEngine.Vector2 GetTextureScale(int nameID)
        {
            return internal_UnityEngineMaterial__func__GetTextureScale__SystemInt32__UnityEngineVector2(WrappedId, nameID);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineMaterial__ctor__UnityEngineShader(global::UnityEngine.Shader shader)
        {
            return UnityEngineMaterial__ctor__UnityEngineShader(shader.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineMaterial__ctor__UnityEngineMaterial(global::UnityEngine.Material source)
        {
            return UnityEngineMaterial__ctor__UnityEngineMaterial(source.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Shader internal_UnityEngineMaterial__get__shader(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__shader(selfObjectId);
            var returnResult = new global::UnityEngine.Shader(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__shader(long selfObjectId, global::UnityEngine.Shader shader)
        {
            UnityEngineMaterial__set__shader(selfObjectId, shader.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMaterial__get__color(long selfObjectId)
        {
            global::UnityEngine.Color colorValue = default;
            UnityEngineMaterial__get__color(selfObjectId, Unsafe.AsPointer(ref colorValue));
            global::UnityEngine.Color returnResult = colorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__color(long selfObjectId, global::UnityEngine.Color color)
        {
            UnityEngineMaterial__set__color(selfObjectId, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineMaterial__get__mainTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__mainTexture(selfObjectId);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__mainTexture(long selfObjectId, global::UnityEngine.Texture mainTexture)
        {
            UnityEngineMaterial__set__mainTexture(selfObjectId, mainTexture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__get__mainTextureOffset(long selfObjectId)
        {
            global::UnityEngine.Vector2 mainTextureOffsetValue = default;
            UnityEngineMaterial__get__mainTextureOffset(selfObjectId, Unsafe.AsPointer(ref mainTextureOffsetValue));
            global::UnityEngine.Vector2 returnResult = mainTextureOffsetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__mainTextureOffset(long selfObjectId, global::UnityEngine.Vector2 mainTextureOffset)
        {
            UnityEngineMaterial__set__mainTextureOffset(selfObjectId, Unsafe.AsPointer(ref mainTextureOffset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__get__mainTextureScale(long selfObjectId)
        {
            global::UnityEngine.Vector2 mainTextureScaleValue = default;
            UnityEngineMaterial__get__mainTextureScale(selfObjectId, Unsafe.AsPointer(ref mainTextureScaleValue));
            global::UnityEngine.Vector2 returnResult = mainTextureScaleValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__mainTextureScale(long selfObjectId, global::UnityEngine.Vector2 mainTextureScale)
        {
            UnityEngineMaterial__set__mainTextureScale(selfObjectId, Unsafe.AsPointer(ref mainTextureScale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__get__renderQueue(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__renderQueue(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__renderQueue(long selfObjectId, int renderQueue)
        {
            UnityEngineMaterial__set__renderQueue(selfObjectId, renderQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeyword[] internal_UnityEngineMaterial__get__enabledKeywords(long selfObjectId)
        {
            long* enabledKeywordsIdsPointer = default;
            int enabledKeywordsWasmLength = default;
            UnityEngineMaterial__get__enabledKeywords(selfObjectId, &enabledKeywordsIdsPointer, &enabledKeywordsWasmLength);
            global::UnityEngine.Rendering.LocalKeyword[] returnResult = new global::UnityEngine.Rendering.LocalKeyword[enabledKeywordsWasmLength];
            for (int i = 0; i < enabledKeywordsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.LocalKeyword(enabledKeywordsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)enabledKeywordsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__enabledKeywords(long selfObjectId, global::UnityEngine.Rendering.LocalKeyword[] enabledKeywords)
        {
            int enabledKeywordsWasmLength = enabledKeywords.Length;
            long[] enabledKeywordsIds = new long[enabledKeywordsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < enabledKeywordsWasmLength; i++) enabledKeywordsIds[i] = (enabledKeywords[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* enabledKeywordsIdsPointer = enabledKeywordsIds)
            {
                UnityEngineMaterial__set__enabledKeywords(selfObjectId, enabledKeywordsIdsPointer, enabledKeywordsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.MaterialGlobalIlluminationFlags internal_UnityEngineMaterial__get__globalIlluminationFlags(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__globalIlluminationFlags(selfObjectId);
            var returnResult = (global::UnityEngine.MaterialGlobalIlluminationFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__globalIlluminationFlags(long selfObjectId, global::UnityEngine.MaterialGlobalIlluminationFlags globalIlluminationFlags)
        {
            UnityEngineMaterial__set__globalIlluminationFlags(selfObjectId, (int) globalIlluminationFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__get__doubleSidedGI(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__doubleSidedGI(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__doubleSidedGI(long selfObjectId, bool doubleSidedGI)
        {
            var doubleSidedGIConverted = Unsafe.As<bool, int>(ref doubleSidedGI);
            UnityEngineMaterial__set__doubleSidedGI(selfObjectId, doubleSidedGIConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__get__enableInstancing(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__enableInstancing(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__enableInstancing(long selfObjectId, bool enableInstancing)
        {
            var enableInstancingConverted = Unsafe.As<bool, int>(ref enableInstancing);
            UnityEngineMaterial__set__enableInstancing(selfObjectId, enableInstancingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__get__passCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__get__passCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineMaterial__get__shaderKeywords(long selfObjectId)
        {
            // Exterrata: I would really like to put shaderKeywordsPointer first instead of shaderKeywordsWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* shaderKeywordsWasmLengthsPointer = default;
            char** shaderKeywordsPointer = default;
            int shaderKeywordsWasmLength = default;
            UnityEngineMaterial__get__shaderKeywords(selfObjectId, &shaderKeywordsWasmLengthsPointer, &shaderKeywordsPointer, &shaderKeywordsWasmLength);

            // The changes were written to the pointers directly, we need to write to the array and free allocations
            var shaderKeywordsAux = new string[shaderKeywordsWasmLength];
            for (int i = 0; i < shaderKeywordsWasmLength; i++)
            {
                shaderKeywordsAux[i] = new string(shaderKeywordsPointer![i], 0, shaderKeywordsWasmLengthsPointer![i]);
                Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer);
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsWasmLengthsPointer);
            var returnResult = shaderKeywordsAux;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__set__shaderKeywords(long selfObjectId, global::System.String[] shaderKeywords)
        {
            // Allocate the pointers needed for the array of strings
            int shaderKeywordsWasmLength = shaderKeywords.Length;
            char** shaderKeywordsPointer = (char**)Marshal.AllocHGlobal(shaderKeywordsWasmLength * sizeof(long));
            int* shaderKeywordsWasmLengthsPointer = (int*)Marshal.AllocHGlobal(shaderKeywordsWasmLength * sizeof(int));
            for (int i = 0; i < shaderKeywordsWasmLength; i++)
            {
                shaderKeywordsPointer![i] = (char*)Marshal.StringToHGlobalUni(shaderKeywords[i]);
                shaderKeywordsWasmLengthsPointer![i] = shaderKeywords[i].Length;
            }

            UnityEngineMaterial__set__shaderKeywords(selfObjectId, shaderKeywordsWasmLengthsPointer, shaderKeywordsPointer, shaderKeywordsWasmLength);

            // The changes were written to the pointers directly, we just need to clean up the allocations
            for (int i = 0; i < shaderKeywordsWasmLength; i++)
            {
                Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer);
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsWasmLengthsPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasProperty__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasProperty__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasProperty__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasProperty__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasFloat__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasFloat__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasFloat__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasFloat__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasInt__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasInt__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasInt__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasInt__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasInteger__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasInteger__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasInteger__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasInteger__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasTexture__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasTexture__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasTexture__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasTexture__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasMatrix__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasMatrix__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasMatrix__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasMatrix__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasVector__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasVector__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasVector__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasVector__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasColor__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasColor__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasColor__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasColor__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasBuffer__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasBuffer__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasBuffer__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasConstantBuffer__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__HasConstantBuffer__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__HasConstantBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__HasConstantBuffer__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__EnableKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineMaterial__func__EnableKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__DisableKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineMaterial__func__DisableKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__IsKeywordEnabled__SystemString__SystemBoolean(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                var methodCallResult = UnityEngineMaterial__func__IsKeywordEnabled__SystemString__SystemBoolean(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineMaterial__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineMaterial__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineMaterial__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(selfObjectId, keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            var methodCallResult = UnityEngineMaterial__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(selfObjectId, keyword.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetShaderPassEnabled__SystemString__SystemBoolean__SystemVoid(long selfObjectId, string passName, bool enabled)
        {
            fixed (char* passNamePointer = passName)
            {
                var enabledConverted = Unsafe.As<bool, int>(ref enabled);
                UnityEngineMaterial__func__SetShaderPassEnabled__SystemString__SystemBoolean__SystemVoid(selfObjectId, passNamePointer, passName.Length * sizeof(char), enabledConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__GetShaderPassEnabled__SystemString__SystemBoolean(long selfObjectId, string passName)
        {
            fixed (char* passNamePointer = passName)
            {
                var methodCallResult = UnityEngineMaterial__func__GetShaderPassEnabled__SystemString__SystemBoolean(selfObjectId, passNamePointer, passName.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMaterial__func__GetPassName__SystemInt32__SystemString(long selfObjectId, int pass)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetPassName__SystemInt32__SystemString(selfObjectId, pass, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__FindPass__SystemString__SystemInt32(long selfObjectId, string passName)
        {
            fixed (char* passNamePointer = passName)
            {
                var methodCallResult = UnityEngineMaterial__func__FindPass__SystemString__SystemInt32(selfObjectId, passNamePointer, passName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetOverrideTag__SystemString__SystemString__SystemVoid(long selfObjectId, string tag, string val)
        {
            fixed (char* tagPointer = tag, valPointer = val)
            {
                UnityEngineMaterial__func__SetOverrideTag__SystemString__SystemString__SystemVoid(selfObjectId, tagPointer, tag.Length * sizeof(char), valPointer, val.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString__SystemString(long selfObjectId, string tag, bool searchFallbacks, string defaultValue)
        {
            fixed (char* tagPointer = tag, defaultValuePointer = defaultValue)
            {
                var searchFallbacksConverted = Unsafe.As<bool, int>(ref searchFallbacks);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString__SystemString(selfObjectId, tagPointer, tag.Length * sizeof(char), searchFallbacksConverted, defaultValuePointer, defaultValue.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString(long selfObjectId, string tag, bool searchFallbacks)
        {
            fixed (char* tagPointer = tag)
            {
                var searchFallbacksConverted = Unsafe.As<bool, int>(ref searchFallbacks);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString(selfObjectId, tagPointer, tag.Length * sizeof(char), searchFallbacksConverted, &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__Lerp__UnityEngineMaterial__UnityEngineMaterial__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Material start, global::UnityEngine.Material end, float t)
        {
            UnityEngineMaterial__func__Lerp__UnityEngineMaterial__UnityEngineMaterial__SystemSingle__SystemVoid(selfObjectId, start.WrappedId, end.WrappedId, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterial__func__SetPass__SystemInt32__SystemBoolean(long selfObjectId, int pass)
        {
            var methodCallResult = UnityEngineMaterial__func__SetPass__SystemInt32__SystemBoolean(selfObjectId, pass);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__CopyPropertiesFromMaterial__UnityEngineMaterial__SystemVoid(long selfObjectId, global::UnityEngine.Material mat)
        {
            UnityEngineMaterial__func__CopyPropertiesFromMaterial__UnityEngineMaterial__SystemVoid(selfObjectId, mat.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__ComputeCRC__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterial__func__ComputeCRC__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineMaterial__func__GetTexturePropertyNames__SystemStringArray(long selfObjectId)
        {
            // Exterrata: I would really like to put returnResultPointer first instead of returnResultWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* returnResultWasmLengthsPointer = default;
            char** returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetTexturePropertyNames__SystemStringArray(selfObjectId, &returnResultWasmLengthsPointer, &returnResultPointer, &returnResultWasmLength);

            // The changes were written to the pointers directly, we need to write to the array and free allocations
            var returnResultAux = new string[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResultAux[i] = new string(returnResultPointer![i], 0, returnResultWasmLengthsPointer![i]);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            Marshal.FreeHGlobal((IntPtr)returnResultWasmLengthsPointer);
            var returnResult = returnResultAux;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Int32[] internal_UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemInt32Array(long selfObjectId)
        {
            int* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemInt32Array(selfObjectId, &returnResultIdsPointer, &returnResultWasmLength);
            int[] returnResult = new int[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetTexturePropertyNames__SystemCollectionsGeneric_List_SystemString__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<string> outNamesList)
        {
            Span<string> outNames = CollectionsMarshal.AsSpan(outNamesList);
            int outNamesUnmanagedCount = outNames.Length;
            char** outNamesUnmanagedPointer = (char**)Marshal.AllocHGlobal(outNamesUnmanagedCount * sizeof(long));
            int* outNamesUnmanagedWasmLengthsPointer = (int*)Marshal.AllocHGlobal(outNamesUnmanagedCount * sizeof(int));

            int outNamesWasmLength = outNamesUnmanagedCount;
            char** outNamesPointer = outNamesUnmanagedPointer;
            int* outNamesWasmLengthsPointer = outNamesUnmanagedWasmLengthsPointer;

            for (int i = 0; i < outNamesUnmanagedCount; i++)
            {
                outNamesUnmanagedPointer![i] = (char*)Marshal.StringToHGlobalUni(outNames[i]);
                outNamesUnmanagedWasmLengthsPointer![i] = outNames[i].Length;
            }
            UnityEngineMaterial__func__GetTexturePropertyNames__SystemCollectionsGeneric_List_SystemString__SystemVoid(selfObjectId, &outNamesUnmanagedWasmLengthsPointer, &outNamesUnmanagedPointer, &outNamesUnmanagedCount);
            for (int i = 0; i < outNamesWasmLength; i++)
                Marshal.FreeHGlobal((IntPtr)outNamesPointer![i]);
            Marshal.FreeHGlobal((IntPtr)outNamesPointer);
            Marshal.FreeHGlobal((IntPtr)outNamesWasmLengthsPointer);

            outNamesList.Clear();
            for (int i = 0; i < outNamesUnmanagedCount; i++)
            {
                outNamesList.Add(new(outNamesUnmanagedPointer![i], 0, outNamesUnmanagedWasmLengthsPointer![i]));
                Marshal.FreeHGlobal((IntPtr)outNamesUnmanagedPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)outNamesUnmanagedPointer);
            Marshal.FreeHGlobal((IntPtr)outNamesUnmanagedWasmLengthsPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemCollectionsGeneric_List_SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<int> outNamesList)
        {
            Span<int> outNames = CollectionsMarshal.AsSpan(outNamesList);
            fixed (int* outNamesPointer = outNames)
            {
                UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemCollectionsGeneric_List_SystemInt32__SystemVoid(selfObjectId, outNamesPointer, outNames.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetInt__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineMaterial__func__SetInt__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value)
        {
            UnityEngineMaterial__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetInteger__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineMaterial__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, string name, global::UnityEngine.Color value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetColor__SystemString__UnityEngineColor__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Color value)
        {
            UnityEngineMaterial__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4 value)
        {
            UnityEngineMaterial__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4 value)
        {
            UnityEngineMaterial__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, string name, global::UnityEngine.Texture value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Texture value)
        {
            UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, nameID, value.WrappedId, (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer value)
        {
            UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Color> valuesList)
        {
            Span<global::UnityEngine.Color> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Color* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Color> valuesList)
        {
            Span<global::UnityEngine.Color> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Color* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColorArray__SystemString__UnityEngineColorArray__SystemVoid(long selfObjectId, string name, global::UnityEngine.Color[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Color* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetColorArray__SystemString__UnityEngineColorArray__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetColorArray__SystemInt32__UnityEngineColorArray__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Color[] values)
        {
            fixed (global::UnityEngine.Color* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetColorArray__SystemInt32__UnityEngineColorArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterial__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__GetInt__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__GetInt__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__GetInt__SystemInt32__SystemInt32(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__GetInt__SystemInt32__SystemInt32(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMaterial__func__GetFloat__SystemString__SystemSingle(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__GetFloat__SystemString__SystemSingle(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMaterial__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__GetFloat__SystemInt32__SystemSingle(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__GetInteger__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__GetInteger__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterial__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__GetInteger__SystemInt32__SystemInt32(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMaterial__func__GetColor__SystemString__UnityEngineColor(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Color returnResultValue = default;
                UnityEngineMaterial__func__GetColor__SystemString__UnityEngineColor(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Color returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMaterial__func__GetColor__SystemInt32__UnityEngineColor(long selfObjectId, int nameID)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineMaterial__func__GetColor__SystemInt32__UnityEngineColor(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineMaterial__func__GetVector__SystemString__UnityEngineVector4(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4 returnResultValue = default;
                UnityEngineMaterial__func__GetVector__SystemString__UnityEngineVector4(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineMaterial__func__GetVector__SystemInt32__UnityEngineVector4(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector4 returnResultValue = default;
            UnityEngineMaterial__func__GetVector__SystemInt32__UnityEngineVector4(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMaterial__func__GetMatrix__SystemString__UnityEngineMatrix4x4(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4 returnResultValue = default;
                UnityEngineMaterial__func__GetMatrix__SystemString__UnityEngineMatrix4x4(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMaterial__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(long selfObjectId, int nameID)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMaterial__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineMaterial__func__GetTexture__SystemString__UnityEngineTexture(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterial__func__GetTexture__SystemString__UnityEngineTexture(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Texture(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineMaterial__func__GetTexture__SystemInt32__UnityEngineTexture(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterial__func__GetTexture__SystemInt32__UnityEngineTexture(selfObjectId, nameID);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Single[] internal_UnityEngineMaterial__func__GetFloatArray__SystemString__SystemSingleArray(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                float* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetFloatArray__SystemString__SystemSingleArray(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                float[] returnResult = new float[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Single[] internal_UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemSingleArray(long selfObjectId, int nameID)
        {
            float* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemSingleArray(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            float[] returnResult = new float[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineMaterial__func__GetColorArray__SystemString__UnityEngineColorArray(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Color* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetColorArray__SystemString__UnityEngineColorArray(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineMaterial__func__GetColorArray__SystemInt32__UnityEngineColorArray(long selfObjectId, int nameID)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetColorArray__SystemInt32__UnityEngineColorArray(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineMaterial__func__GetVectorArray__SystemString__UnityEngineVector4Array(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetVectorArray__SystemString__UnityEngineVector4Array(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Vector4[] returnResult = new global::UnityEngine.Vector4[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineMaterial__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Vector4[] returnResult = new global::UnityEngine.Vector4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineMaterial__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterial__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Matrix4x4[] returnResult = new global::UnityEngine.Matrix4x4[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineMaterial__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(long selfObjectId, int nameID)
        {
            global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterial__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Matrix4x4[] returnResult = new global::UnityEngine.Matrix4x4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterial__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Color> valuesList)
        {
            Span<global::UnityEngine.Color> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Color* valuesPointer = values)
                {
                    UnityEngineMaterial__func__GetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Color> valuesList)
        {
            Span<global::UnityEngine.Color> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Color* valuesPointer = values)
            {
                UnityEngineMaterial__func__GetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterial__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterial__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterial__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTextureOffset__SystemString__UnityEngineVector2__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector2 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetTextureOffset__SystemString__UnityEngineVector2__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTextureOffset__SystemInt32__UnityEngineVector2__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector2 value)
        {
            UnityEngineMaterial__func__SetTextureOffset__SystemInt32__UnityEngineVector2__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTextureScale__SystemString__UnityEngineVector2__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector2 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterial__func__SetTextureScale__SystemString__UnityEngineVector2__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterial__func__SetTextureScale__SystemInt32__UnityEngineVector2__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector2 value)
        {
            UnityEngineMaterial__func__SetTextureScale__SystemInt32__UnityEngineVector2__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__func__GetTextureOffset__SystemString__UnityEngineVector2(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector2 returnResultValue = default;
                UnityEngineMaterial__func__GetTextureOffset__SystemString__UnityEngineVector2(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector2 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__func__GetTextureOffset__SystemInt32__UnityEngineVector2(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineMaterial__func__GetTextureOffset__SystemInt32__UnityEngineVector2(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__func__GetTextureScale__SystemString__UnityEngineVector2(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector2 returnResultValue = default;
                UnityEngineMaterial__func__GetTextureScale__SystemString__UnityEngineVector2(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector2 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineMaterial__func__GetTextureScale__SystemInt32__UnityEngineVector2(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineMaterial__func__GetTextureScale__SystemInt32__UnityEngineVector2(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterial__ctor__UnityEngineShader(long shaderObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterial__ctor__UnityEngineMaterial(long sourceObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterial__get__shader(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__shader(long selfObjectId, long shaderObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__get__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__set__color(long selfObjectId, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterial__get__mainTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__mainTexture(long selfObjectId, long mainTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__get__mainTextureOffset(long selfObjectId, void* mainTextureOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__set__mainTextureOffset(long selfObjectId, void* mainTextureOffsetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__get__mainTextureScale(long selfObjectId, void* mainTextureScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__set__mainTextureScale(long selfObjectId, void* mainTextureScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__get__renderQueue(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__renderQueue(long selfObjectId, int renderQueue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__get__enabledKeywords(long selfObjectId, void* enabledKeywordsIdsPointer, void* enabledKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__set__enabledKeywords(long selfObjectId, void* enabledKeywordsIdsPointer, int enabledKeywordsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__get__globalIlluminationFlags(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__globalIlluminationFlags(long selfObjectId, int globalIlluminationFlagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__get__doubleSidedGI(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__doubleSidedGI(long selfObjectId, int doubleSidedGIConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__get__enableInstancing(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__set__enableInstancing(long selfObjectId, int enableInstancingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__get__passCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__get__shaderKeywords(long selfObjectId, void* shaderKeywordsWasmLengthsPointer, void* shaderKeywordsPointer, void* shaderKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__set__shaderKeywords(long selfObjectId, void* shaderKeywordsWasmLengthsPointer, void* shaderKeywordsPointer, int shaderKeywordsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasProperty__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasProperty__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasFloat__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasFloat__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasInt__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasInt__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasInteger__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasInteger__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasTexture__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasTexture__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasMatrix__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasMatrix__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasVector__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasVector__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasColor__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasColor__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasBuffer__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__HasConstantBuffer__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__HasConstantBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__EnableKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__DisableKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__IsKeywordEnabled__SystemString__SystemBoolean(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetShaderPassEnabled__SystemString__SystemBoolean__SystemVoid(long selfObjectId, void* passNamePointer, int passNameWasmLength, int enabledConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__GetShaderPassEnabled__SystemString__SystemBoolean(long selfObjectId, void* passNamePointer, int passNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetPassName__SystemInt32__SystemString(long selfObjectId, int pass, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__FindPass__SystemString__SystemInt32(long selfObjectId, void* passNamePointer, int passNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetOverrideTag__SystemString__SystemString__SystemVoid(long selfObjectId, void* tagPointer, int tagWasmLength, void* valPointer, int valWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString__SystemString(long selfObjectId, void* tagPointer, int tagWasmLength, int searchFallbacksConverted, void* defaultValuePointer, int defaultValueWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTag__SystemString__SystemBoolean__SystemString(long selfObjectId, void* tagPointer, int tagWasmLength, int searchFallbacksConverted, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__Lerp__UnityEngineMaterial__UnityEngineMaterial__SystemSingle__SystemVoid(long selfObjectId, long startObjectId, long endObjectId, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__SetPass__SystemInt32__SystemBoolean(long selfObjectId, int pass);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__CopyPropertiesFromMaterial__UnityEngineMaterial__SystemVoid(long selfObjectId, long matObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__ComputeCRC__SystemInt32(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTexturePropertyNames__SystemStringArray(long selfObjectId, void* returnResultWasmLengthsPointer, void* returnResultPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemInt32Array(long selfObjectId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTexturePropertyNames__SystemCollectionsGeneric_List_SystemString__SystemVoid(long selfObjectId, void* outNamesWasmLengthsPointerPointer, void* outNamesPointerPointer, void* outNamesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTexturePropertyNameIDs__SystemCollectionsGeneric_List_SystemInt32__SystemVoid(long selfObjectId, void* outNamesPointer, int outNamesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterial__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColorArray__SystemString__UnityEngineColorArray__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetColorArray__SystemInt32__UnityEngineColorArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__GetInt__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__GetInt__SystemInt32__SystemInt32(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMaterial__func__GetFloat__SystemString__SystemSingle(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMaterial__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterial__func__GetInteger__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterial__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColor__SystemString__UnityEngineColor(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColor__SystemInt32__UnityEngineColor(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVector__SystemString__UnityEngineVector4(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVector__SystemInt32__UnityEngineVector4(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrix__SystemString__UnityEngineMatrix4x4(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineMaterial__func__GetTexture__SystemString__UnityEngineTexture(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterial__func__GetTexture__SystemInt32__UnityEngineTexture(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetFloatArray__SystemString__SystemSingleArray(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemSingleArray(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColorArray__SystemString__UnityEngineColorArray(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColorArray__SystemInt32__UnityEngineColorArray(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVectorArray__SystemString__UnityEngineVector4Array(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetColorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineColor__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTextureOffset__SystemString__UnityEngineVector2__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTextureOffset__SystemInt32__UnityEngineVector2__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTextureScale__SystemString__UnityEngineVector2__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__SetTextureScale__SystemInt32__UnityEngineVector2__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTextureOffset__SystemString__UnityEngineVector2(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTextureOffset__SystemInt32__UnityEngineVector2(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTextureScale__SystemString__UnityEngineVector2(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterial__func__GetTextureScale__SystemInt32__UnityEngineVector2(long selfObjectId, int nameID, void* returnResultPointer);

        #endregion Imports
    }
}
