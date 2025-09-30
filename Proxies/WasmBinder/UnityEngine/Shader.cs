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

    public partial class Shader(long id) : Object(id)
    {

        #region Implementation

        public static int maximumChunksOverride 
        {
            get => internal_UnityEngineShader__get__maximumChunksOverride();
            set => internal_UnityEngineShader__set__maximumChunksOverride(value);
        }

        public int maximumLOD 
        {
            get => internal_UnityEngineShader__get__maximumLOD(WrappedId);
            set => internal_UnityEngineShader__set__maximumLOD(WrappedId, value);
        }

        public static int globalMaximumLOD 
        {
            get => internal_UnityEngineShader__get__globalMaximumLOD();
            set => internal_UnityEngineShader__set__globalMaximumLOD(value);
        }

        public bool isSupported 
        {
            get => internal_UnityEngineShader__get__isSupported(WrappedId);
        }

        public static string globalRenderPipeline 
        {
            get => internal_UnityEngineShader__get__globalRenderPipeline();
            set => internal_UnityEngineShader__set__globalRenderPipeline(value);
        }

        public static global::UnityEngine.Rendering.GlobalKeyword[] enabledGlobalKeywords 
        {
            get => internal_UnityEngineShader__get__enabledGlobalKeywords();
        }

        public static global::UnityEngine.Rendering.GlobalKeyword[] globalKeywords 
        {
            get => internal_UnityEngineShader__get__globalKeywords();
        }

        public global::UnityEngine.Rendering.LocalKeywordSpace keywordSpace 
        {
            get => internal_UnityEngineShader__get__keywordSpace(WrappedId);
        }

        public int renderQueue 
        {
            get => internal_UnityEngineShader__get__renderQueue(WrappedId);
        }

        public int passCount 
        {
            get => internal_UnityEngineShader__get__passCount(WrappedId);
        }

        public int subshaderCount 
        {
            get => internal_UnityEngineShader__get__subshaderCount(WrappedId);
        }

        public static global::UnityEngine.Shader Find(string name)
        {
            return internal_UnityEngineShader__func__Find__SystemString__UnityEngineShader(name);
        }

        public static void EnableKeyword(string keyword)
        {
            internal_UnityEngineShader__func__EnableKeyword__SystemString__SystemVoid(keyword);
        }

        public static void DisableKeyword(string keyword)
        {
            internal_UnityEngineShader__func__DisableKeyword__SystemString__SystemVoid(keyword);
        }

        public static bool IsKeywordEnabled(string keyword)
        {
            return internal_UnityEngineShader__func__IsKeywordEnabled__SystemString__SystemBoolean(keyword);
        }

        public static void EnableKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            internal_UnityEngineShader__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(in keyword);
        }

        public static void DisableKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            internal_UnityEngineShader__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(in keyword);
        }

        public static void SetKeyword(in global::UnityEngine.Rendering.GlobalKeyword keyword, bool value)
        {
            internal_UnityEngineShader__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(in keyword, value);
        }

        public static bool IsKeywordEnabled(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            return internal_UnityEngineShader__func__IsKeywordEnabled__UnityEngineRenderingGlobalKeywordRef__SystemBoolean(in keyword);
        }

        public static void WarmupAllShaders()
        {
            internal_UnityEngineShader__func__WarmupAllShaders__SystemVoid();
        }

        public static int PropertyToID(string name)
        {
            return internal_UnityEngineShader__func__PropertyToID__SystemString__SystemInt32(name);
        }

        public global::UnityEngine.Shader GetDependency(string name)
        {
            return internal_UnityEngineShader__func__GetDependency__SystemString__UnityEngineShader(WrappedId, name);
        }

        public int GetPassCountInSubshader(int subshaderIndex)
        {
            return internal_UnityEngineShader__func__GetPassCountInSubshader__SystemInt32__SystemInt32(WrappedId, subshaderIndex);
        }

        public global::UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            return internal_UnityEngineShader__func__FindPassTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(WrappedId, passIndex, tagName);
        }

        public global::UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            return internal_UnityEngineShader__func__FindPassTagValue__SystemInt32__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(WrappedId, subshaderIndex, passIndex, tagName);
        }

        public global::UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            return internal_UnityEngineShader__func__FindSubshaderTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(WrappedId, subshaderIndex, tagName);
        }

        public static void SetGlobalInt(string name, int value)
        {
            internal_UnityEngineShader__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(name, value);
        }

        public static void SetGlobalInt(int nameID, int value)
        {
            internal_UnityEngineShader__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(nameID, value);
        }

        public static void SetGlobalFloat(string name, float value)
        {
            internal_UnityEngineShader__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(name, value);
        }

        public static void SetGlobalFloat(int nameID, float value)
        {
            internal_UnityEngineShader__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(nameID, value);
        }

        public static void SetGlobalInteger(string name, int value)
        {
            internal_UnityEngineShader__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(name, value);
        }

        public static void SetGlobalInteger(int nameID, int value)
        {
            internal_UnityEngineShader__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(nameID, value);
        }

        public static void SetGlobalVector(string name, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineShader__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(name, value);
        }

        public static void SetGlobalVector(int nameID, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineShader__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(nameID, value);
        }

        public static void SetGlobalColor(string name, global::UnityEngine.Color value)
        {
            internal_UnityEngineShader__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(name, value);
        }

        public static void SetGlobalColor(int nameID, global::UnityEngine.Color value)
        {
            internal_UnityEngineShader__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(nameID, value);
        }

        public static void SetGlobalMatrix(string name, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineShader__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(name, value);
        }

        public static void SetGlobalMatrix(int nameID, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineShader__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(nameID, value);
        }

        public static void SetGlobalTexture(string name, global::UnityEngine.Texture value)
        {
            internal_UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineTexture__SystemVoid(name, value);
        }

        public static void SetGlobalTexture(int nameID, global::UnityEngine.Texture value)
        {
            internal_UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineTexture__SystemVoid(nameID, value);
        }

        public static void SetGlobalTexture(string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(name, value, element);
        }

        public static void SetGlobalTexture(int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(nameID, value, element);
        }

        public static void SetGlobalBuffer(string name, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(name, value);
        }

        public static void SetGlobalBuffer(int nameID, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(nameID, value);
        }

        public static void SetGlobalBuffer(string name, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(name, value);
        }

        public static void SetGlobalBuffer(int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(nameID, value);
        }

        public static void SetGlobalConstantBuffer(string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(name, value, offset, size);
        }

        public static void SetGlobalConstantBuffer(int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(nameID, value, offset, size);
        }

        public static void SetGlobalConstantBuffer(string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(name, value, offset, size);
        }

        public static void SetGlobalConstantBuffer(int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(nameID, value, offset, size);
        }

        public static void SetGlobalFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(name, values);
        }

        public static void SetGlobalFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(nameID, values);
        }

        public static void SetGlobalFloatArray(string name, global::System.Single[] values)
        {
            internal_UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(name, values);
        }

        public static void SetGlobalFloatArray(int nameID, global::System.Single[] values)
        {
            internal_UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(nameID, values);
        }

        public static void SetGlobalVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineShader__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(name, values);
        }

        public static void SetGlobalVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(nameID, values);
        }

        public static void SetGlobalVectorArray(string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineShader__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(name, values);
        }

        public static void SetGlobalVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(nameID, values);
        }

        public static void SetGlobalMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(name, values);
        }

        public static void SetGlobalMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(nameID, values);
        }

        public static void SetGlobalMatrixArray(string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(name, values);
        }

        public static void SetGlobalMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(nameID, values);
        }

        public static int GetGlobalInt(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalInt__SystemString__SystemInt32(name);
        }

        public static int GetGlobalInt(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalInt__SystemInt32__SystemInt32(nameID);
        }

        public static float GetGlobalFloat(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalFloat__SystemString__SystemSingle(name);
        }

        public static float GetGlobalFloat(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalFloat__SystemInt32__SystemSingle(nameID);
        }

        public static int GetGlobalInteger(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalInteger__SystemString__SystemInt32(name);
        }

        public static int GetGlobalInteger(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalInteger__SystemInt32__SystemInt32(nameID);
        }

        public static global::UnityEngine.Vector4 GetGlobalVector(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalVector__SystemString__UnityEngineVector4(name);
        }

        public static global::UnityEngine.Vector4 GetGlobalVector(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalVector__SystemInt32__UnityEngineVector4(nameID);
        }

        public static global::UnityEngine.Color GetGlobalColor(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalColor__SystemString__UnityEngineColor(name);
        }

        public static global::UnityEngine.Color GetGlobalColor(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalColor__SystemInt32__UnityEngineColor(nameID);
        }

        public static global::UnityEngine.Matrix4x4 GetGlobalMatrix(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalMatrix__SystemString__UnityEngineMatrix4x4(name);
        }

        public static global::UnityEngine.Matrix4x4 GetGlobalMatrix(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4(nameID);
        }

        public static global::UnityEngine.Texture GetGlobalTexture(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalTexture__SystemString__UnityEngineTexture(name);
        }

        public static global::UnityEngine.Texture GetGlobalTexture(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalTexture__SystemInt32__UnityEngineTexture(nameID);
        }

        public static global::System.Single[] GetGlobalFloatArray(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemSingleArray(name);
        }

        public static global::System.Single[] GetGlobalFloatArray(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemSingleArray(nameID);
        }

        public static global::UnityEngine.Vector4[] GetGlobalVectorArray(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalVectorArray__SystemString__UnityEngineVector4Array(name);
        }

        public static global::UnityEngine.Vector4[] GetGlobalVectorArray(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__UnityEngineVector4Array(nameID);
        }

        public static global::UnityEngine.Matrix4x4[] GetGlobalMatrixArray(string name)
        {
            return internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array(name);
        }

        public static global::UnityEngine.Matrix4x4[] GetGlobalMatrixArray(int nameID)
        {
            return internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(nameID);
        }

        public static void GetGlobalFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(name, values);
        }

        public static void GetGlobalFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(nameID, values);
        }

        public static void GetGlobalVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineShader__func__GetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(name, values);
        }

        public static void GetGlobalVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(nameID, values);
        }

        public static void GetGlobalMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(name, values);
        }

        public static void GetGlobalMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(nameID, values);
        }

        public int GetPropertyCount()
        {
            return internal_UnityEngineShader__func__GetPropertyCount__SystemInt32(WrappedId);
        }

        public int FindPropertyIndex(string propertyName)
        {
            return internal_UnityEngineShader__func__FindPropertyIndex__SystemString__SystemInt32(WrappedId, propertyName);
        }

        public string GetPropertyName(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyName__SystemInt32__SystemString(WrappedId, propertyIndex);
        }

        public int GetPropertyNameId(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyNameId__SystemInt32__SystemInt32(WrappedId, propertyIndex);
        }

        public global::UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyType__SystemInt32__UnityEngineRenderingShaderPropertyTypeEnum(WrappedId, propertyIndex);
        }

        public string GetPropertyDescription(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyDescription__SystemInt32__SystemString(WrappedId, propertyIndex);
        }

        public global::UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyFlags__SystemInt32__UnityEngineRenderingShaderPropertyFlagsEnum(WrappedId, propertyIndex);
        }

        public global::System.String[] GetPropertyAttributes(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyAttributes__SystemInt32__SystemStringArray(WrappedId, propertyIndex);
        }

        public float GetPropertyDefaultFloatValue(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyDefaultFloatValue__SystemInt32__SystemSingle(WrappedId, propertyIndex);
        }

        public global::UnityEngine.Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyDefaultVectorValue__SystemInt32__UnityEngineVector4(WrappedId, propertyIndex);
        }

        public global::UnityEngine.Vector2 GetPropertyRangeLimits(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyRangeLimits__SystemInt32__UnityEngineVector2(WrappedId, propertyIndex);
        }

        public global::UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyTextureDimension__SystemInt32__UnityEngineRenderingTextureDimensionEnum(WrappedId, propertyIndex);
        }

        public string GetPropertyTextureDefaultName(int propertyIndex)
        {
            return internal_UnityEngineShader__func__GetPropertyTextureDefaultName__SystemInt32__SystemString(WrappedId, propertyIndex);
        }

        public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
        {
            return internal_UnityEngineShader__func__FindTextureStack__SystemInt32__SystemStringRef__SystemInt32Ref__SystemBoolean(WrappedId, propertyIndex, out stackName, out layerIndex);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__maximumChunksOverride()
        {
            var methodCallResult = UnityEngineShader__get__maximumChunksOverride();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__set__maximumChunksOverride(int maximumChunksOverride)
        {
            UnityEngineShader__set__maximumChunksOverride(maximumChunksOverride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__maximumLOD(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__get__maximumLOD(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__set__maximumLOD(long selfObjectId, int maximumLOD)
        {
            UnityEngineShader__set__maximumLOD(selfObjectId, maximumLOD);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__globalMaximumLOD()
        {
            var methodCallResult = UnityEngineShader__get__globalMaximumLOD();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__set__globalMaximumLOD(int globalMaximumLOD)
        {
            UnityEngineShader__set__globalMaximumLOD(globalMaximumLOD);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineShader__get__isSupported(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__get__isSupported(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineShader__get__globalRenderPipeline()
        {
            char* globalRenderPipelinePointer = default;
            int globalRenderPipelineWasmLength = default;
            UnityEngineShader__get__globalRenderPipeline(&globalRenderPipelinePointer, &globalRenderPipelineWasmLength);
            string returnResult = new(globalRenderPipelinePointer, 0, globalRenderPipelineWasmLength);
            Marshal.FreeHGlobal((IntPtr)globalRenderPipelinePointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__set__globalRenderPipeline(string globalRenderPipeline)
        {
            fixed (char* globalRenderPipelinePointer = globalRenderPipeline)
            {
                UnityEngineShader__set__globalRenderPipeline(globalRenderPipelinePointer, globalRenderPipeline.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GlobalKeyword[] internal_UnityEngineShader__get__enabledGlobalKeywords()
        {
            long* enabledGlobalKeywordsIdsPointer = default;
            int enabledGlobalKeywordsWasmLength = default;
            UnityEngineShader__get__enabledGlobalKeywords(&enabledGlobalKeywordsIdsPointer, &enabledGlobalKeywordsWasmLength);
            global::UnityEngine.Rendering.GlobalKeyword[] returnResult = new global::UnityEngine.Rendering.GlobalKeyword[enabledGlobalKeywordsWasmLength];
            for (int i = 0; i < enabledGlobalKeywordsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.GlobalKeyword(enabledGlobalKeywordsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)enabledGlobalKeywordsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.GlobalKeyword[] internal_UnityEngineShader__get__globalKeywords()
        {
            long* globalKeywordsIdsPointer = default;
            int globalKeywordsWasmLength = default;
            UnityEngineShader__get__globalKeywords(&globalKeywordsIdsPointer, &globalKeywordsWasmLength);
            global::UnityEngine.Rendering.GlobalKeyword[] returnResult = new global::UnityEngine.Rendering.GlobalKeyword[globalKeywordsWasmLength];
            for (int i = 0; i < globalKeywordsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.GlobalKeyword(globalKeywordsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)globalKeywordsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeywordSpace internal_UnityEngineShader__get__keywordSpace(long selfObjectId)
        {
            global::UnityEngine.Rendering.LocalKeywordSpace keywordSpaceValue = default;
            UnityEngineShader__get__keywordSpace(selfObjectId, Unsafe.AsPointer(ref keywordSpaceValue));
            global::UnityEngine.Rendering.LocalKeywordSpace returnResult = keywordSpaceValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__renderQueue(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__get__renderQueue(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__passCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__get__passCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__get__subshaderCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__get__subshaderCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Shader internal_UnityEngineShader__func__Find__SystemString__UnityEngineShader(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__Find__SystemString__UnityEngineShader(namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Shader(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__EnableKeyword__SystemString__SystemVoid(string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineShader__func__EnableKeyword__SystemString__SystemVoid(keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__DisableKeyword__SystemString__SystemVoid(string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineShader__func__DisableKeyword__SystemString__SystemVoid(keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineShader__func__IsKeywordEnabled__SystemString__SystemBoolean(string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                var methodCallResult = UnityEngineShader__func__IsKeywordEnabled__SystemString__SystemBoolean(keywordPointer, keyword.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            UnityEngineShader__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            UnityEngineShader__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(in global::UnityEngine.Rendering.GlobalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineShader__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineShader__func__IsKeywordEnabled__UnityEngineRenderingGlobalKeywordRef__SystemBoolean(in global::UnityEngine.Rendering.GlobalKeyword keyword)
        {
            var methodCallResult = UnityEngineShader__func__IsKeywordEnabled__UnityEngineRenderingGlobalKeywordRef__SystemBoolean(keyword.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__WarmupAllShaders__SystemVoid()
        {
            UnityEngineShader__func__WarmupAllShaders__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__PropertyToID__SystemString__SystemInt32(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__PropertyToID__SystemString__SystemInt32(namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Shader internal_UnityEngineShader__func__GetDependency__SystemString__UnityEngineShader(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__GetDependency__SystemString__UnityEngineShader(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Shader(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetPassCountInSubshader__SystemInt32__SystemInt32(long selfObjectId, int subshaderIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPassCountInSubshader__SystemInt32__SystemInt32(selfObjectId, subshaderIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderTagId internal_UnityEngineShader__func__FindPassTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int passIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            global::UnityEngine.Rendering.ShaderTagId returnResultValue = default;
            UnityEngineShader__func__FindPassTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(selfObjectId, passIndex, Unsafe.AsPointer(ref tagName), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.ShaderTagId returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderTagId internal_UnityEngineShader__func__FindPassTagValue__SystemInt32__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int subshaderIndex, int passIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            global::UnityEngine.Rendering.ShaderTagId returnResultValue = default;
            UnityEngineShader__func__FindPassTagValue__SystemInt32__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(selfObjectId, subshaderIndex, passIndex, Unsafe.AsPointer(ref tagName), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.ShaderTagId returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderTagId internal_UnityEngineShader__func__FindSubshaderTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int subshaderIndex, global::UnityEngine.Rendering.ShaderTagId tagName)
        {
            global::UnityEngine.Rendering.ShaderTagId returnResultValue = default;
            UnityEngineShader__func__FindSubshaderTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(selfObjectId, subshaderIndex, Unsafe.AsPointer(ref tagName), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Rendering.ShaderTagId returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(int nameID, int value)
        {
            UnityEngineShader__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(string name, float value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(int nameID, float value)
        {
            UnityEngineShader__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(int nameID, int value)
        {
            UnityEngineShader__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(string name, global::UnityEngine.Vector4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(int nameID, global::UnityEngine.Vector4 value)
        {
            UnityEngineShader__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(string name, global::UnityEngine.Color value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(int nameID, global::UnityEngine.Color value)
        {
            UnityEngineShader__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(string name, global::UnityEngine.Matrix4x4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(int nameID, global::UnityEngine.Matrix4x4 value)
        {
            UnityEngineShader__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineTexture__SystemVoid(string name, global::UnityEngine.Texture value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineTexture__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineTexture__SystemVoid(int nameID, global::UnityEngine.Texture value)
        {
            UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineTexture__SystemVoid(nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId, (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(nameID, value.WrappedId, (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(string name, global::UnityEngine.ComputeBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(int nameID, global::UnityEngine.ComputeBuffer value)
        {
            UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(string name, global::UnityEngine.GraphicsBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineShader__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetGlobalInt__SystemString__SystemInt32(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__GetGlobalInt__SystemString__SystemInt32(namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetGlobalInt__SystemInt32__SystemInt32(int nameID)
        {
            var methodCallResult = UnityEngineShader__func__GetGlobalInt__SystemInt32__SystemInt32(nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineShader__func__GetGlobalFloat__SystemString__SystemSingle(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__GetGlobalFloat__SystemString__SystemSingle(namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineShader__func__GetGlobalFloat__SystemInt32__SystemSingle(int nameID)
        {
            var methodCallResult = UnityEngineShader__func__GetGlobalFloat__SystemInt32__SystemSingle(nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetGlobalInteger__SystemString__SystemInt32(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__GetGlobalInteger__SystemString__SystemInt32(namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetGlobalInteger__SystemInt32__SystemInt32(int nameID)
        {
            var methodCallResult = UnityEngineShader__func__GetGlobalInteger__SystemInt32__SystemInt32(nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineShader__func__GetGlobalVector__SystemString__UnityEngineVector4(string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4 returnResultValue = default;
                UnityEngineShader__func__GetGlobalVector__SystemString__UnityEngineVector4(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineShader__func__GetGlobalVector__SystemInt32__UnityEngineVector4(int nameID)
        {
            global::UnityEngine.Vector4 returnResultValue = default;
            UnityEngineShader__func__GetGlobalVector__SystemInt32__UnityEngineVector4(nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineShader__func__GetGlobalColor__SystemString__UnityEngineColor(string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Color returnResultValue = default;
                UnityEngineShader__func__GetGlobalColor__SystemString__UnityEngineColor(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Color returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineShader__func__GetGlobalColor__SystemInt32__UnityEngineColor(int nameID)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineShader__func__GetGlobalColor__SystemInt32__UnityEngineColor(nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineShader__func__GetGlobalMatrix__SystemString__UnityEngineMatrix4x4(string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4 returnResultValue = default;
                UnityEngineShader__func__GetGlobalMatrix__SystemString__UnityEngineMatrix4x4(namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineShader__func__GetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4(int nameID)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineShader__func__GetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4(nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineShader__func__GetGlobalTexture__SystemString__UnityEngineTexture(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineShader__func__GetGlobalTexture__SystemString__UnityEngineTexture(namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Texture(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineShader__func__GetGlobalTexture__SystemInt32__UnityEngineTexture(int nameID)
        {
            var methodCallResult = UnityEngineShader__func__GetGlobalTexture__SystemInt32__UnityEngineTexture(nameID);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Single[] internal_UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemSingleArray(string name)
        {
            fixed (char* namePointer = name)
            {
                float* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemSingleArray(namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::System.Single[] internal_UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemSingleArray(int nameID)
        {
            float* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemSingleArray(nameID, &returnResultIdsPointer, &returnResultWasmLength);
            float[] returnResult = new float[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineShader__func__GetGlobalVectorArray__SystemString__UnityEngineVector4Array(string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineShader__func__GetGlobalVectorArray__SystemString__UnityEngineVector4Array(namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__UnityEngineVector4Array(int nameID)
        {
            global::UnityEngine.Vector4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__UnityEngineVector4Array(nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Vector4[] returnResult = new global::UnityEngine.Vector4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array(string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineShader__func__GetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array(namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(int nameID)
        {
            global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Matrix4x4[] returnResult = new global::UnityEngine.Matrix4x4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineShader__func__GetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineShader__func__GetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetPropertyCount__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyCount__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__FindPropertyIndex__SystemString__SystemInt32(long selfObjectId, string propertyName)
        {
            fixed (char* propertyNamePointer = propertyName)
            {
                var methodCallResult = UnityEngineShader__func__FindPropertyIndex__SystemString__SystemInt32(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineShader__func__GetPropertyName__SystemInt32__SystemString(long selfObjectId, int propertyIndex)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetPropertyName__SystemInt32__SystemString(selfObjectId, propertyIndex, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineShader__func__GetPropertyNameId__SystemInt32__SystemInt32(long selfObjectId, int propertyIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyNameId__SystemInt32__SystemInt32(selfObjectId, propertyIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderPropertyType internal_UnityEngineShader__func__GetPropertyType__SystemInt32__UnityEngineRenderingShaderPropertyTypeEnum(long selfObjectId, int propertyIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyType__SystemInt32__UnityEngineRenderingShaderPropertyTypeEnum(selfObjectId, propertyIndex);
            var returnResult = (global::UnityEngine.Rendering.ShaderPropertyType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineShader__func__GetPropertyDescription__SystemInt32__SystemString(long selfObjectId, int propertyIndex)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetPropertyDescription__SystemInt32__SystemString(selfObjectId, propertyIndex, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.ShaderPropertyFlags internal_UnityEngineShader__func__GetPropertyFlags__SystemInt32__UnityEngineRenderingShaderPropertyFlagsEnum(long selfObjectId, int propertyIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyFlags__SystemInt32__UnityEngineRenderingShaderPropertyFlagsEnum(selfObjectId, propertyIndex);
            var returnResult = (global::UnityEngine.Rendering.ShaderPropertyFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineShader__func__GetPropertyAttributes__SystemInt32__SystemStringArray(long selfObjectId, int propertyIndex)
        {
            // Exterrata: I would really like to put returnResultPointer first instead of returnResultWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* returnResultWasmLengthsPointer = default;
            char** returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetPropertyAttributes__SystemInt32__SystemStringArray(selfObjectId, propertyIndex, &returnResultWasmLengthsPointer, &returnResultPointer, &returnResultWasmLength);

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
        private static unsafe float internal_UnityEngineShader__func__GetPropertyDefaultFloatValue__SystemInt32__SystemSingle(long selfObjectId, int propertyIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyDefaultFloatValue__SystemInt32__SystemSingle(selfObjectId, propertyIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineShader__func__GetPropertyDefaultVectorValue__SystemInt32__UnityEngineVector4(long selfObjectId, int propertyIndex)
        {
            global::UnityEngine.Vector4 returnResultValue = default;
            UnityEngineShader__func__GetPropertyDefaultVectorValue__SystemInt32__UnityEngineVector4(selfObjectId, propertyIndex, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineShader__func__GetPropertyRangeLimits__SystemInt32__UnityEngineVector2(long selfObjectId, int propertyIndex)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineShader__func__GetPropertyRangeLimits__SystemInt32__UnityEngineVector2(selfObjectId, propertyIndex, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.TextureDimension internal_UnityEngineShader__func__GetPropertyTextureDimension__SystemInt32__UnityEngineRenderingTextureDimensionEnum(long selfObjectId, int propertyIndex)
        {
            var methodCallResult = UnityEngineShader__func__GetPropertyTextureDimension__SystemInt32__UnityEngineRenderingTextureDimensionEnum(selfObjectId, propertyIndex);
            var returnResult = (global::UnityEngine.Rendering.TextureDimension)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineShader__func__GetPropertyTextureDefaultName__SystemInt32__SystemString(long selfObjectId, int propertyIndex)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineShader__func__GetPropertyTextureDefaultName__SystemInt32__SystemString(selfObjectId, propertyIndex, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineShader__func__FindTextureStack__SystemInt32__SystemStringRef__SystemInt32Ref__SystemBoolean(long selfObjectId, int propertyIndex, out string stackName, out int layerIndex)
        {
            char* stackNamePointer = default;
            int stackNameWasmLength = default;
            layerIndex = default;
            var methodCallResult = UnityEngineShader__func__FindTextureStack__SystemInt32__SystemStringRef__SystemInt32Ref__SystemBoolean(selfObjectId, propertyIndex, stackNamePointer, &stackNameWasmLength, Unsafe.AsPointer(ref layerIndex));
            stackName = new(stackNamePointer, 0, stackNameWasmLength);
            Marshal.FreeHGlobal((IntPtr)stackNamePointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__maximumChunksOverride();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__set__maximumChunksOverride(int maximumChunksOverride);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__maximumLOD(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__set__maximumLOD(long selfObjectId, int maximumLOD);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__globalMaximumLOD();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__set__globalMaximumLOD(int globalMaximumLOD);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__isSupported(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__get__globalRenderPipeline(void* globalRenderPipelinePointer, void* globalRenderPipelineWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__set__globalRenderPipeline(void* globalRenderPipelinePointer, int globalRenderPipelineWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__get__enabledGlobalKeywords(void* enabledGlobalKeywordsIdsPointer, void* enabledGlobalKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__get__globalKeywords(void* globalKeywordsIdsPointer, void* globalKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__get__keywordSpace(long selfObjectId, void* keywordSpacePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__renderQueue(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__passCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__get__subshaderCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineShader__func__Find__SystemString__UnityEngineShader(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__EnableKeyword__SystemString__SystemVoid(void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__DisableKeyword__SystemString__SystemVoid(void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__IsKeywordEnabled__SystemString__SystemBoolean(void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__EnableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__DisableKeyword__UnityEngineRenderingGlobalKeywordRef__SystemVoid(long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetKeyword__UnityEngineRenderingGlobalKeywordRef__SystemBoolean__SystemVoid(long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__IsKeywordEnabled__UnityEngineRenderingGlobalKeywordRef__SystemBoolean(long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__WarmupAllShaders__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__PropertyToID__SystemString__SystemInt32(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineShader__func__GetDependency__SystemString__UnityEngineShader(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPassCountInSubshader__SystemInt32__SystemInt32(long selfObjectId, int subshaderIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__FindPassTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int passIndex, void* tagNamePointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__FindPassTagValue__SystemInt32__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int subshaderIndex, int passIndex, void* tagNamePointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__FindSubshaderTagValue__SystemInt32__UnityEngineRenderingShaderTagId__UnityEngineRenderingShaderTagId(long selfObjectId, int subshaderIndex, void* tagNamePointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalInt__SystemString__SystemInt32__SystemVoid(void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalInt__SystemInt32__SystemInt32__SystemVoid(int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalFloat__SystemString__SystemSingle__SystemVoid(void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalFloat__SystemInt32__SystemSingle__SystemVoid(int nameID, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalInteger__SystemString__SystemInt32__SystemVoid(void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalInteger__SystemInt32__SystemInt32__SystemVoid(int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVector__SystemString__UnityEngineVector4__SystemVoid(void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVector__SystemInt32__UnityEngineVector4__SystemVoid(int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalColor__SystemString__UnityEngineColor__SystemVoid(void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalColor__SystemInt32__UnityEngineColor__SystemVoid(int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineTexture__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineTexture__SystemVoid(int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(int nameID, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineShader__func__SetGlobalConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalFloatArray__SystemString__SystemSingleArray__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalFloatArray__SystemInt32__SystemSingleArray__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__SetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__GetGlobalInt__SystemString__SystemInt32(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetGlobalInt__SystemInt32__SystemInt32(int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineShader__func__GetGlobalFloat__SystemString__SystemSingle(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineShader__func__GetGlobalFloat__SystemInt32__SystemSingle(int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__GetGlobalInteger__SystemString__SystemInt32(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetGlobalInteger__SystemInt32__SystemInt32(int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVector__SystemString__UnityEngineVector4(void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVector__SystemInt32__UnityEngineVector4(int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalColor__SystemString__UnityEngineColor(void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalColor__SystemInt32__UnityEngineColor(int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrix__SystemString__UnityEngineMatrix4x4(void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrix__SystemInt32__UnityEngineMatrix4x4(int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineShader__func__GetGlobalTexture__SystemString__UnityEngineTexture(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineShader__func__GetGlobalTexture__SystemInt32__UnityEngineTexture(int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemSingleArray(void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemSingleArray(int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVectorArray__SystemString__UnityEngineVector4Array(void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__UnityEngineVector4Array(int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrixArray__SystemString__UnityEngineMatrix4x4Array(void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetGlobalMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPropertyCount__SystemInt32(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__FindPropertyIndex__SystemString__SystemInt32(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyName__SystemInt32__SystemString(long selfObjectId, int propertyIndex, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPropertyNameId__SystemInt32__SystemInt32(long selfObjectId, int propertyIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPropertyType__SystemInt32__UnityEngineRenderingShaderPropertyTypeEnum(long selfObjectId, int propertyIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyDescription__SystemInt32__SystemString(long selfObjectId, int propertyIndex, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPropertyFlags__SystemInt32__UnityEngineRenderingShaderPropertyFlagsEnum(long selfObjectId, int propertyIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyAttributes__SystemInt32__SystemStringArray(long selfObjectId, int propertyIndex, void* returnResultWasmLengthsPointer, void* returnResultPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineShader__func__GetPropertyDefaultFloatValue__SystemInt32__SystemSingle(long selfObjectId, int propertyIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyDefaultVectorValue__SystemInt32__UnityEngineVector4(long selfObjectId, int propertyIndex, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyRangeLimits__SystemInt32__UnityEngineVector2(long selfObjectId, int propertyIndex, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineShader__func__GetPropertyTextureDimension__SystemInt32__UnityEngineRenderingTextureDimensionEnum(long selfObjectId, int propertyIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineShader__func__GetPropertyTextureDefaultName__SystemInt32__SystemString(long selfObjectId, int propertyIndex, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineShader__func__FindTextureStack__SystemInt32__SystemStringRef__SystemInt32Ref__SystemBoolean(long selfObjectId, int propertyIndex, void* stackNamePointer, void* stackNameWasmLengthsPointer, void* layerIndexPointer);

        #endregion Imports
    }
}
