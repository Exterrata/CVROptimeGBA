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

    public partial class MaterialPropertyBlock(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public MaterialPropertyBlock()
            : this(internal_UnityEngineMaterialPropertyBlock__ctor()) { }

        public bool isEmpty 
        {
            get => internal_UnityEngineMaterialPropertyBlock__get__isEmpty(WrappedId);
        }

        public void Clear()
        {
            internal_UnityEngineMaterialPropertyBlock__func__Clear__SystemVoid(WrappedId);
        }

        public void SetInt(string name, int value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetInt__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetInt(int nameID, int value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetInt__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetFloat(string name, float value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, value);
        }

        public void SetFloat(int nameID, float value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, nameID, value);
        }

        public void SetInteger(string name, int value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetInteger__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetInteger(int nameID, int value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value);
        }

        public void SetVector(string name, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(WrappedId, name, value);
        }

        public void SetVector(int nameID, global::UnityEngine.Vector4 value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, nameID, value);
        }

        public void SetColor(string name, global::UnityEngine.Color value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetColor__SystemString__UnityEngineColor__SystemVoid(WrappedId, name, value);
        }

        public void SetColor(int nameID, global::UnityEngine.Color value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(WrappedId, nameID, value);
        }

        public void SetMatrix(string name, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, name, value);
        }

        public void SetMatrix(int nameID, global::UnityEngine.Matrix4x4 value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, value);
        }

        public void SetBuffer(string name, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetBuffer(int nameID, global::UnityEngine.ComputeBuffer value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetBuffer(string name, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, name, value);
        }

        public void SetBuffer(int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, nameID, value);
        }

        public void SetTexture(string name, global::UnityEngine.Texture value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(WrappedId, name, value);
        }

        public void SetTexture(int nameID, global::UnityEngine.Texture value)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(WrappedId, nameID, value);
        }

        public void SetTexture(string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, name, value, element);
        }

        public void SetTexture(int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, nameID, value, element);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, value, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, value, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, value, offset, size);
        }

        public void SetFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, name, values);
        }

        public void SetFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, nameID, values);
        }

        public void SetFloatArray(string name, global::System.Single[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(WrappedId, name, values);
        }

        public void SetFloatArray(int nameID, global::System.Single[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, name, values);
        }

        public void SetVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetVectorArray(string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, nameID, values);
        }

        public bool HasProperty(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasProperty__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasProperty(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasProperty__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasInt(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasInt__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasInt(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasInt__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasFloat(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasFloat__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasFloat(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasFloat__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasInteger(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasInteger__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasInteger(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasInteger__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasTexture(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasTexture__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasTexture(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasTexture__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasMatrix(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasMatrix(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasVector(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasVector__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasVector(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasVector__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasColor(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasColor__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasColor(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasColor__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasBuffer(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasBuffer(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public bool HasConstantBuffer(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool HasConstantBuffer(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemInt32__SystemBoolean(WrappedId, nameID);
        }

        public float GetFloat(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetFloat__SystemString__SystemSingle(WrappedId, name);
        }

        public float GetFloat(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetFloat__SystemInt32__SystemSingle(WrappedId, nameID);
        }

        public int GetInt(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetInt__SystemString__SystemInt32(WrappedId, name);
        }

        public int GetInt(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetInt__SystemInt32__SystemInt32(WrappedId, nameID);
        }

        public int GetInteger(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetInteger__SystemString__SystemInt32(WrappedId, name);
        }

        public int GetInteger(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetInteger__SystemInt32__SystemInt32(WrappedId, nameID);
        }

        public global::UnityEngine.Vector4 GetVector(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetVector__SystemString__UnityEngineVector4(WrappedId, name);
        }

        public global::UnityEngine.Vector4 GetVector(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetVector__SystemInt32__UnityEngineVector4(WrappedId, nameID);
        }

        public global::UnityEngine.Color GetColor(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetColor__SystemString__UnityEngineColor(WrappedId, name);
        }

        public global::UnityEngine.Color GetColor(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetColor__SystemInt32__UnityEngineColor(WrappedId, nameID);
        }

        public global::UnityEngine.Matrix4x4 GetMatrix(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemString__UnityEngineMatrix4x4(WrappedId, name);
        }

        public global::UnityEngine.Matrix4x4 GetMatrix(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(WrappedId, nameID);
        }

        public global::UnityEngine.Texture GetTexture(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetTexture__SystemString__UnityEngineTexture(WrappedId, name);
        }

        public global::UnityEngine.Texture GetTexture(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetTexture__SystemInt32__UnityEngineTexture(WrappedId, nameID);
        }

        public global::System.Single[] GetFloatArray(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemSingleArray(WrappedId, name);
        }

        public global::System.Single[] GetFloatArray(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemSingleArray(WrappedId, nameID);
        }

        public global::UnityEngine.Vector4[] GetVectorArray(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__UnityEngineVector4Array(WrappedId, name);
        }

        public global::UnityEngine.Vector4[] GetVectorArray(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(WrappedId, nameID);
        }

        public global::UnityEngine.Matrix4x4[] GetMatrixArray(string name)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(WrappedId, name);
        }

        public global::UnityEngine.Matrix4x4[] GetMatrixArray(int nameID)
        {
            return internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(WrappedId, nameID);
        }

        public void GetFloatArray(string name, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, name, values);
        }

        public void GetFloatArray(int nameID, global::System.Collections.Generic.List<float> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(WrappedId, nameID, values);
        }

        public void GetVectorArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, name, values);
        }

        public void GetVectorArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, nameID, values);
        }

        public void GetMatrixArray(string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, name, values);
        }

        public void GetMatrixArray(int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> values)
        {
            internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, values);
        }

        public void CopySHCoefficientArraysFrom(global::System.Collections.Generic.List<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(WrappedId, lightProbes);
        }

        public void CopySHCoefficientArraysFrom(global::UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemVoid(WrappedId, lightProbes);
        }

        public void CopySHCoefficientArraysFrom(global::System.Collections.Generic.List<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, lightProbes, sourceStart, destStart, count);
        }

        public void CopySHCoefficientArraysFrom(global::UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, lightProbes, sourceStart, destStart, count);
        }

        public void CopyProbeOcclusionArrayFrom(global::System.Collections.Generic.List<global::UnityEngine.Vector4> occlusionProbes)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(WrappedId, occlusionProbes);
        }

        public void CopyProbeOcclusionArrayFrom(global::UnityEngine.Vector4[] occlusionProbes)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemVoid(WrappedId, occlusionProbes);
        }

        public void CopyProbeOcclusionArrayFrom(global::System.Collections.Generic.List<global::UnityEngine.Vector4> occlusionProbes, int sourceStart, int destStart, int count)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, occlusionProbes, sourceStart, destStart, count);
        }

        public void CopyProbeOcclusionArrayFrom(global::UnityEngine.Vector4[] occlusionProbes, int sourceStart, int destStart, int count)
        {
            internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, occlusionProbes, sourceStart, destStart, count);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineMaterialPropertyBlock__ctor()
        {
            return UnityEngineMaterialPropertyBlock__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__get__isEmpty(long selfObjectId)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__get__isEmpty(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__Clear__SystemVoid(long selfObjectId)
        {
            UnityEngineMaterialPropertyBlock__func__Clear__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetInt__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineMaterialPropertyBlock__func__SetInt__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value)
        {
            UnityEngineMaterialPropertyBlock__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetInteger__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value)
        {
            UnityEngineMaterialPropertyBlock__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4 value)
        {
            UnityEngineMaterialPropertyBlock__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, string name, global::UnityEngine.Color value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetColor__SystemString__UnityEngineColor__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Color value)
        {
            UnityEngineMaterialPropertyBlock__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4 value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4 value)
        {
            UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer value)
        {
            UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer value)
        {
            UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, string name, global::UnityEngine.Texture value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Texture value)
        {
            UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(selfObjectId, nameID, value.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, string name, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.RenderTexture value, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, nameID, value.WrappedId, (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer value, int offset, int size)
        {
            UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer value, int offset, int size)
        {
            UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, value.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasProperty__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasProperty__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasProperty__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasProperty__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasInt__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasInt__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasInt__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasInt__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasFloat__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasFloat__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasFloat__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasFloat__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasInteger__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasInteger__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasInteger__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasInteger__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasTexture__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasTexture__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasTexture__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasTexture__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasVector__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasVector__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasVector__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasVector__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasColor__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasColor__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasColor__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasColor__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemInt32__SystemBoolean(selfObjectId, nameID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMaterialPropertyBlock__func__GetFloat__SystemString__SystemSingle(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetFloat__SystemString__SystemSingle(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMaterialPropertyBlock__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetFloat__SystemInt32__SystemSingle(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterialPropertyBlock__func__GetInt__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetInt__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterialPropertyBlock__func__GetInt__SystemInt32__SystemInt32(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetInt__SystemInt32__SystemInt32(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterialPropertyBlock__func__GetInteger__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetInteger__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMaterialPropertyBlock__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetInteger__SystemInt32__SystemInt32(selfObjectId, nameID);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineMaterialPropertyBlock__func__GetVector__SystemString__UnityEngineVector4(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4 returnResultValue = default;
                UnityEngineMaterialPropertyBlock__func__GetVector__SystemString__UnityEngineVector4(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Vector4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4 internal_UnityEngineMaterialPropertyBlock__func__GetVector__SystemInt32__UnityEngineVector4(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector4 returnResultValue = default;
            UnityEngineMaterialPropertyBlock__func__GetVector__SystemInt32__UnityEngineVector4(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMaterialPropertyBlock__func__GetColor__SystemString__UnityEngineColor(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Color returnResultValue = default;
                UnityEngineMaterialPropertyBlock__func__GetColor__SystemString__UnityEngineColor(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Color returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMaterialPropertyBlock__func__GetColor__SystemInt32__UnityEngineColor(long selfObjectId, int nameID)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineMaterialPropertyBlock__func__GetColor__SystemInt32__UnityEngineColor(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemString__UnityEngineMatrix4x4(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4 returnResultValue = default;
                UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemString__UnityEngineMatrix4x4(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref returnResultValue));
                global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(long selfObjectId, int nameID)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(selfObjectId, nameID, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineMaterialPropertyBlock__func__GetTexture__SystemString__UnityEngineTexture(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetTexture__SystemString__UnityEngineTexture(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Texture(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture internal_UnityEngineMaterialPropertyBlock__func__GetTexture__SystemInt32__UnityEngineTexture(long selfObjectId, int nameID)
        {
            var methodCallResult = UnityEngineMaterialPropertyBlock__func__GetTexture__SystemInt32__UnityEngineTexture(selfObjectId, nameID);
            var returnResult = new global::UnityEngine.Texture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Single[] internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemSingleArray(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                float* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemSingleArray(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::System.Single[] internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemSingleArray(long selfObjectId, int nameID)
        {
            float* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemSingleArray(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            float[] returnResult = new float[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__UnityEngineVector4Array(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Vector4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__UnityEngineVector4Array(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Vector4[] internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(long selfObjectId, int nameID)
        {
            global::UnityEngine.Vector4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Vector4[] returnResult = new global::UnityEngine.Vector4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(selfObjectId, namePointer, name.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
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
        private static unsafe global::UnityEngine.Matrix4x4[] internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(long selfObjectId, int nameID)
        {
            global::UnityEngine.Matrix4x4* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(selfObjectId, nameID, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Matrix4x4[] returnResult = new global::UnityEngine.Matrix4x4[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<float> valuesList)
        {
            Span<float> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (float* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Vector4> valuesList)
        {
            Span<global::UnityEngine.Vector4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> valuesList)
        {
            Span<global::UnityEngine.Matrix4x4> values = CollectionsMarshal.AsSpan(valuesList);
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbesList)
        {
            Span<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes = CollectionsMarshal.AsSpan(lightProbesList);
            fixed (global::UnityEngine.Rendering.SphericalHarmonicsL2* lightProbesPointer = lightProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(selfObjectId, lightProbesPointer, lightProbes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes)
        {
            fixed (global::UnityEngine.Rendering.SphericalHarmonicsL2* lightProbesPointer = lightProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemVoid(selfObjectId, lightProbesPointer, lightProbes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbesList, int sourceStart, int destStart, int count)
        {
            Span<global::UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes = CollectionsMarshal.AsSpan(lightProbesList);
            fixed (global::UnityEngine.Rendering.SphericalHarmonicsL2* lightProbesPointer = lightProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, lightProbesPointer, lightProbes.Length, sourceStart, destStart, count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count)
        {
            fixed (global::UnityEngine.Rendering.SphericalHarmonicsL2* lightProbesPointer = lightProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, lightProbesPointer, lightProbes.Length, sourceStart, destStart, count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> occlusionProbesList)
        {
            Span<global::UnityEngine.Vector4> occlusionProbes = CollectionsMarshal.AsSpan(occlusionProbesList);
            fixed (global::UnityEngine.Vector4* occlusionProbesPointer = occlusionProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(selfObjectId, occlusionProbesPointer, occlusionProbes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector4[] occlusionProbes)
        {
            fixed (global::UnityEngine.Vector4* occlusionProbesPointer = occlusionProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemVoid(selfObjectId, occlusionProbesPointer, occlusionProbes.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.Vector4> occlusionProbesList, int sourceStart, int destStart, int count)
        {
            Span<global::UnityEngine.Vector4> occlusionProbes = CollectionsMarshal.AsSpan(occlusionProbesList);
            fixed (global::UnityEngine.Vector4* occlusionProbesPointer = occlusionProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, occlusionProbesPointer, occlusionProbes.Length, sourceStart, destStart, count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Vector4[] occlusionProbes, int sourceStart, int destStart, int count)
        {
            fixed (global::UnityEngine.Vector4* occlusionProbesPointer = occlusionProbes)
            {
                UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, occlusionProbesPointer, occlusionProbes.Length, sourceStart, destStart, count);
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterialPropertyBlock__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__get__isEmpty(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__Clear__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetColor__SystemString__UnityEngineColor__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetColor__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, long valueObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetTexture__SystemString__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetTexture__SystemInt32__UnityEngineRenderTexture__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineMaterialPropertyBlock__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long valueObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetFloatArray__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasProperty__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasProperty__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasInt__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasInt__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasFloat__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasFloat__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasInteger__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasInteger__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasTexture__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasTexture__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasMatrix__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasVector__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasVector__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasColor__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasColor__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__HasConstantBuffer__SystemInt32__SystemBoolean(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMaterialPropertyBlock__func__GetFloat__SystemString__SystemSingle(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMaterialPropertyBlock__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__GetInt__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__GetInt__SystemInt32__SystemInt32(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMaterialPropertyBlock__func__GetInteger__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMaterialPropertyBlock__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVector__SystemString__UnityEngineVector4(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVector__SystemInt32__UnityEngineVector4(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetColor__SystemString__UnityEngineColor(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetColor__SystemInt32__UnityEngineColor(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemString__UnityEngineMatrix4x4(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrix__SystemInt32__UnityEngineMatrix4x4(long selfObjectId, int nameID, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineMaterialPropertyBlock__func__GetTexture__SystemString__UnityEngineTexture(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineMaterialPropertyBlock__func__GetTexture__SystemInt32__UnityEngineTexture(long selfObjectId, int nameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemSingleArray(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemSingleArray(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__UnityEngineVector4Array(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__UnityEngineVector4Array(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__UnityEngineMatrix4x4Array(long selfObjectId, void* namePointer, int nameWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array(long selfObjectId, int nameID, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemString__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetFloatArray__SystemInt32__SystemCollectionsGeneric_List_SystemSingle__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemString__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetVectorArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemString__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__GetMatrixArray__SystemInt32__SystemCollectionsGeneric_List_UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(long selfObjectId, void* lightProbesPointer, int lightProbesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemVoid(long selfObjectId, void* lightProbesPointer, int lightProbesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__SystemCollectionsGeneric_List_UnityEngineRenderingSphericalHarmonicsL2__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* lightProbesPointer, int lightProbesWasmLength, int sourceStart, int destStart, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopySHCoefficientArraysFrom__UnityEngineRenderingSphericalHarmonicsL2Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* lightProbesPointer, int lightProbesWasmLength, int sourceStart, int destStart, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemVoid(long selfObjectId, void* occlusionProbesPointer, int occlusionProbesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* occlusionProbesPointer, int occlusionProbesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__SystemCollectionsGeneric_List_UnityEngineVector4__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* occlusionProbesPointer, int occlusionProbesWasmLength, int sourceStart, int destStart, int count);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMaterialPropertyBlock__func__CopyProbeOcclusionArrayFrom__UnityEngineVector4Array__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* occlusionProbesPointer, int occlusionProbesWasmLength, int sourceStart, int destStart, int count);

        #endregion Imports
    }
}
