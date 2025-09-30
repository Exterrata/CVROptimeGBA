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

    public partial class ComputeShader(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.Rendering.LocalKeywordSpace keywordSpace 
        {
            get => internal_UnityEngineComputeShader__get__keywordSpace(WrappedId);
        }

        public global::System.String[] shaderKeywords 
        {
            get => internal_UnityEngineComputeShader__get__shaderKeywords(WrappedId);
            set => internal_UnityEngineComputeShader__set__shaderKeywords(WrappedId, value);
        }

        public global::UnityEngine.Rendering.LocalKeyword[] enabledKeywords 
        {
            get => internal_UnityEngineComputeShader__get__enabledKeywords(WrappedId);
            set => internal_UnityEngineComputeShader__set__enabledKeywords(WrappedId, value);
        }

        public int FindKernel(string name)
        {
            return internal_UnityEngineComputeShader__func__FindKernel__SystemString__SystemInt32(WrappedId, name);
        }

        public bool HasKernel(string name)
        {
            return internal_UnityEngineComputeShader__func__HasKernel__SystemString__SystemBoolean(WrappedId, name);
        }

        public void SetFloat(int nameID, float val)
        {
            internal_UnityEngineComputeShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, nameID, val);
        }

        public void SetInt(int nameID, int val)
        {
            internal_UnityEngineComputeShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, val);
        }

        public void SetVector(int nameID, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineComputeShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, nameID, val);
        }

        public void SetMatrix(int nameID, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineComputeShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, val);
        }

        public void SetVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineComputeShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineComputeShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetTexture(int kernelIndex, int nameID, global::UnityEngine.Texture texture, int mipLevel)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(WrappedId, kernelIndex, nameID, texture, mipLevel);
        }

        public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
        {
            internal_UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, kernelIndex, nameID, globalTextureNameID);
        }

        public void SetBuffer(int kernelIndex, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, kernelIndex, nameID, buffer);
        }

        public void SetBuffer(int kernelIndex, int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, kernelIndex, nameID, buffer);
        }

        public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
        {
            internal_UnityEngineComputeShader__func__GetKernelThreadGroupSizes__SystemInt32__SystemUInt32Ref__SystemUInt32Ref__SystemUInt32Ref__SystemVoid(WrappedId, kernelIndex, out x, out y, out z);
        }

        public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
        {
            internal_UnityEngineComputeShader__func__Dispatch__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(WrappedId, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
        }

        public void EnableKeyword(string keyword)
        {
            internal_UnityEngineComputeShader__func__EnableKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public void DisableKeyword(string keyword)
        {
            internal_UnityEngineComputeShader__func__DisableKeyword__SystemString__SystemVoid(WrappedId, keyword);
        }

        public bool IsKeywordEnabled(string keyword)
        {
            return internal_UnityEngineComputeShader__func__IsKeywordEnabled__SystemString__SystemBoolean(WrappedId, keyword);
        }

        public void EnableKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineComputeShader__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void DisableKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            internal_UnityEngineComputeShader__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(WrappedId, in keyword);
        }

        public void SetKeyword(in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            internal_UnityEngineComputeShader__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(WrappedId, in keyword, value);
        }

        public bool IsKeywordEnabled(in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            return internal_UnityEngineComputeShader__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(WrappedId, in keyword);
        }

        public bool IsSupported(int kernelIndex)
        {
            return internal_UnityEngineComputeShader__func__IsSupported__SystemInt32__SystemBoolean(WrappedId, kernelIndex);
        }

        public void SetFloat(string name, float val)
        {
            internal_UnityEngineComputeShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, val);
        }

        public void SetInt(string name, int val)
        {
            internal_UnityEngineComputeShader__func__SetInt__SystemString__SystemInt32__SystemVoid(WrappedId, name, val);
        }

        public void SetVector(string name, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineComputeShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(WrappedId, name, val);
        }

        public void SetMatrix(string name, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineComputeShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, name, val);
        }

        public void SetVectorArray(string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineComputeShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineComputeShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetFloats(string name, params global::System.Single[] values)
        {
            internal_UnityEngineComputeShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(WrappedId, name, values);
        }

        public void SetFloats(int nameID, params global::System.Single[] values)
        {
            internal_UnityEngineComputeShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetInts(string name, params global::System.Int32[] values)
        {
            internal_UnityEngineComputeShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(WrappedId, name, values);
        }

        public void SetInts(int nameID, params global::System.Int32[] values)
        {
            internal_UnityEngineComputeShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetBool(string name, bool val)
        {
            internal_UnityEngineComputeShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(WrappedId, name, val);
        }

        public void SetBool(int nameID, bool val)
        {
            internal_UnityEngineComputeShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, val);
        }

        public void SetTexture(int kernelIndex, int nameID, global::UnityEngine.Texture texture)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemVoid(WrappedId, kernelIndex, nameID, texture);
        }

        public void SetTexture(int kernelIndex, string name, global::UnityEngine.Texture texture)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemVoid(WrappedId, kernelIndex, name, texture);
        }

        public void SetTexture(int kernelIndex, string name, global::UnityEngine.Texture texture, int mipLevel)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemInt32__SystemVoid(WrappedId, kernelIndex, name, texture, mipLevel);
        }

        public void SetTexture(int kernelIndex, int nameID, global::UnityEngine.RenderTexture texture, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, kernelIndex, nameID, texture, mipLevel, element);
        }

        public void SetTexture(int kernelIndex, string name, global::UnityEngine.RenderTexture texture, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(WrappedId, kernelIndex, name, texture, mipLevel, element);
        }

        public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
        {
            internal_UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemString__SystemString__SystemVoid(WrappedId, kernelIndex, name, globalTextureName);
        }

        public void SetBuffer(int kernelIndex, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, kernelIndex, name, buffer);
        }

        public void SetBuffer(int kernelIndex, string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, kernelIndex, name, buffer);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, buffer, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, buffer, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, buffer, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, buffer, offset, size);
        }

        public void DispatchIndirect(int kernelIndex, global::UnityEngine.ComputeBuffer argsBuffer, uint argsOffset)
        {
            internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(WrappedId, kernelIndex, argsBuffer, argsOffset);
        }

        public void DispatchIndirect(int kernelIndex, global::UnityEngine.ComputeBuffer argsBuffer)
        {
            internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, kernelIndex, argsBuffer);
        }

        public void DispatchIndirect(int kernelIndex, global::UnityEngine.GraphicsBuffer argsBuffer, uint argsOffset)
        {
            internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(WrappedId, kernelIndex, argsBuffer, argsOffset);
        }

        public void DispatchIndirect(int kernelIndex, global::UnityEngine.GraphicsBuffer argsBuffer)
        {
            internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, kernelIndex, argsBuffer);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeywordSpace internal_UnityEngineComputeShader__get__keywordSpace(long selfObjectId)
        {
            global::UnityEngine.Rendering.LocalKeywordSpace keywordSpaceValue = default;
            UnityEngineComputeShader__get__keywordSpace(selfObjectId, Unsafe.AsPointer(ref keywordSpaceValue));
            global::UnityEngine.Rendering.LocalKeywordSpace returnResult = keywordSpaceValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineComputeShader__get__shaderKeywords(long selfObjectId)
        {
            // Exterrata: I would really like to put shaderKeywordsPointer first instead of shaderKeywordsWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* shaderKeywordsWasmLengthsPointer = default;
            char** shaderKeywordsPointer = default;
            int shaderKeywordsWasmLength = default;
            UnityEngineComputeShader__get__shaderKeywords(selfObjectId, &shaderKeywordsWasmLengthsPointer, &shaderKeywordsPointer, &shaderKeywordsWasmLength);

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
        private static unsafe void internal_UnityEngineComputeShader__set__shaderKeywords(long selfObjectId, global::System.String[] shaderKeywords)
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

            UnityEngineComputeShader__set__shaderKeywords(selfObjectId, shaderKeywordsWasmLengthsPointer, shaderKeywordsPointer, shaderKeywordsWasmLength);

            // The changes were written to the pointers directly, we just need to clean up the allocations
            for (int i = 0; i < shaderKeywordsWasmLength; i++)
            {
                Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsPointer);
            Marshal.FreeHGlobal((IntPtr)shaderKeywordsWasmLengthsPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.LocalKeyword[] internal_UnityEngineComputeShader__get__enabledKeywords(long selfObjectId)
        {
            long* enabledKeywordsIdsPointer = default;
            int enabledKeywordsWasmLength = default;
            UnityEngineComputeShader__get__enabledKeywords(selfObjectId, &enabledKeywordsIdsPointer, &enabledKeywordsWasmLength);
            global::UnityEngine.Rendering.LocalKeyword[] returnResult = new global::UnityEngine.Rendering.LocalKeyword[enabledKeywordsWasmLength];
            for (int i = 0; i < enabledKeywordsWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.LocalKeyword(enabledKeywordsIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)enabledKeywordsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__set__enabledKeywords(long selfObjectId, global::UnityEngine.Rendering.LocalKeyword[] enabledKeywords)
        {
            int enabledKeywordsWasmLength = enabledKeywords.Length;
            long[] enabledKeywordsIds = new long[enabledKeywordsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < enabledKeywordsWasmLength; i++) enabledKeywordsIds[i] = (enabledKeywords[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* enabledKeywordsIdsPointer = enabledKeywordsIds)
            {
                UnityEngineComputeShader__set__enabledKeywords(selfObjectId, enabledKeywordsIdsPointer, enabledKeywordsWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineComputeShader__func__FindKernel__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineComputeShader__func__FindKernel__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComputeShader__func__HasKernel__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineComputeShader__func__HasKernel__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float val)
        {
            UnityEngineComputeShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int val)
        {
            UnityEngineComputeShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4 val)
        {
            UnityEngineComputeShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            UnityEngineComputeShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineComputeShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineComputeShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int nameID, global::UnityEngine.Texture texture, int mipLevel)
        {
            UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(selfObjectId, kernelIndex, nameID, texture.WrappedId, mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int nameID, int globalTextureNameID)
        {
            UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, kernelIndex, nameID, globalTextureNameID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, kernelIndex, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, kernelIndex, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__GetKernelThreadGroupSizes__SystemInt32__SystemUInt32Ref__SystemUInt32Ref__SystemUInt32Ref__SystemVoid(long selfObjectId, int kernelIndex, out uint x, out uint y, out uint z)
        {
            x = default;
            var xConverted = Unsafe.As<uint, int>(ref x);
            y = default;
            var yConverted = Unsafe.As<uint, int>(ref y);
            z = default;
            var zConverted = Unsafe.As<uint, int>(ref z);
            UnityEngineComputeShader__func__GetKernelThreadGroupSizes__SystemInt32__SystemUInt32Ref__SystemUInt32Ref__SystemUInt32Ref__SystemVoid(selfObjectId, kernelIndex, (long)Unsafe.AsPointer(ref x), (long)Unsafe.AsPointer(ref y), (long)Unsafe.AsPointer(ref z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__Dispatch__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
        {
            UnityEngineComputeShader__func__Dispatch__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(selfObjectId, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__EnableKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineComputeShader__func__EnableKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DisableKeyword__SystemString__SystemVoid(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                UnityEngineComputeShader__func__DisableKeyword__SystemString__SystemVoid(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComputeShader__func__IsKeywordEnabled__SystemString__SystemBoolean(long selfObjectId, string keyword)
        {
            fixed (char* keywordPointer = keyword)
            {
                var methodCallResult = UnityEngineComputeShader__func__IsKeywordEnabled__SystemString__SystemBoolean(selfObjectId, keywordPointer, keyword.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineComputeShader__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            UnityEngineComputeShader__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(selfObjectId, keyword.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineComputeShader__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(selfObjectId, keyword.WrappedId, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComputeShader__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(long selfObjectId, in global::UnityEngine.Rendering.LocalKeyword keyword)
        {
            var methodCallResult = UnityEngineComputeShader__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(selfObjectId, keyword.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineComputeShader__func__IsSupported__SystemInt32__SystemBoolean(long selfObjectId, int kernelIndex)
        {
            var methodCallResult = UnityEngineComputeShader__func__IsSupported__SystemInt32__SystemBoolean(selfObjectId, kernelIndex);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetInt__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineComputeShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineComputeShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineComputeShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineComputeShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, string name, global::System.Int32[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (int* valuesPointer = values)
                {
                    UnityEngineComputeShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, int nameID, global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                UnityEngineComputeShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, string name, bool val)
        {
            fixed (char* namePointer = name)
            {
                var valConverted = Unsafe.As<bool, int>(ref val);
                UnityEngineComputeShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, bool val)
        {
            var valConverted = Unsafe.As<bool, int>(ref val);
            UnityEngineComputeShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, valConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int kernelIndex, int nameID, global::UnityEngine.Texture texture)
        {
            UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemVoid(selfObjectId, kernelIndex, nameID, texture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, int kernelIndex, string name, global::UnityEngine.Texture texture)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), texture.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, string name, global::UnityEngine.Texture texture, int mipLevel)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemInt32__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), texture.WrappedId, mipLevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int kernelIndex, int nameID, global::UnityEngine.RenderTexture texture, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, kernelIndex, nameID, texture.WrappedId, mipLevel, (int) element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int kernelIndex, string name, global::UnityEngine.RenderTexture texture, int mipLevel, global::UnityEngine.Rendering.RenderTextureSubElement element)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), texture.WrappedId, mipLevel, (int) element);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemString__SystemString__SystemVoid(long selfObjectId, int kernelIndex, string name, string globalTextureName)
        {
            fixed (char* namePointer = name, globalTextureNamePointer = globalTextureName)
            {
                UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemString__SystemString__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), globalTextureNamePointer, globalTextureName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, kernelIndex, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, int kernelIndex, global::UnityEngine.ComputeBuffer argsBuffer, uint argsOffset)
        {
            var argsOffsetConverted = Unsafe.As<uint, int>(ref argsOffset);
            UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(selfObjectId, kernelIndex, argsBuffer.WrappedId, argsOffsetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, global::UnityEngine.ComputeBuffer argsBuffer)
        {
            UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, kernelIndex, argsBuffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, int kernelIndex, global::UnityEngine.GraphicsBuffer argsBuffer, uint argsOffset)
        {
            var argsOffsetConverted = Unsafe.As<uint, int>(ref argsOffset);
            UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(selfObjectId, kernelIndex, argsBuffer.WrappedId, argsOffsetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, global::UnityEngine.GraphicsBuffer argsBuffer)
        {
            UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, kernelIndex, argsBuffer.WrappedId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__get__keywordSpace(long selfObjectId, void* keywordSpacePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__get__shaderKeywords(long selfObjectId, void* shaderKeywordsWasmLengthsPointer, void* shaderKeywordsPointer, void* shaderKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__set__shaderKeywords(long selfObjectId, void* shaderKeywordsWasmLengthsPointer, void* shaderKeywordsPointer, int shaderKeywordsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__get__enabledKeywords(long selfObjectId, void* enabledKeywordsIdsPointer, void* enabledKeywordsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__set__enabledKeywords(long selfObjectId, void* enabledKeywordsIdsPointer, int enabledKeywordsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComputeShader__func__FindKernel__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComputeShader__func__HasKernel__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int nameID, long textureObjectId, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int nameID, int globalTextureNameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__GetKernelThreadGroupSizes__SystemInt32__SystemUInt32Ref__SystemUInt32Ref__SystemUInt32Ref__SystemVoid(long selfObjectId, int kernelIndex, long xPointer, long yPointer, long zPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__Dispatch__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__EnableKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__DisableKeyword__SystemString__SystemVoid(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineComputeShader__func__IsKeywordEnabled__SystemString__SystemBoolean(long selfObjectId, void* keywordPointer, int keywordWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__EnableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__DisableKeyword__UnityEngineRenderingLocalKeywordRef__SystemVoid(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetKeyword__UnityEngineRenderingLocalKeywordRef__SystemBoolean__SystemVoid(long selfObjectId, long keywordObjectId, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineComputeShader__func__IsKeywordEnabled__UnityEngineRenderingLocalKeywordRef__SystemBoolean(long selfObjectId, long keywordObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineComputeShader__func__IsSupported__SystemInt32__SystemBoolean(long selfObjectId, int kernelIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int valConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int valConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int kernelIndex, int nameID, long textureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long textureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineTexture__SystemInt32__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long textureObjectId, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemInt32__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int kernelIndex, int nameID, long textureObjectId, int mipLevel, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetTexture__SystemInt32__SystemString__UnityEngineRenderTexture__SystemInt32__UnityEngineRenderingRenderTextureSubElementEnum__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long textureObjectId, int mipLevel, int elementUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetTextureFromGlobal__SystemInt32__SystemString__SystemString__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, void* globalTextureNamePointer, int globalTextureNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetBuffer__SystemInt32__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineComputeShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemUInt32__SystemVoid(long selfObjectId, int kernelIndex, long argsBufferObjectId, int argsOffsetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int kernelIndex, long argsBufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemUInt32__SystemVoid(long selfObjectId, int kernelIndex, long argsBufferObjectId, int argsOffsetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineComputeShader__func__DispatchIndirect__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int kernelIndex, long argsBufferObjectId);

        #endregion Imports
    }
}
