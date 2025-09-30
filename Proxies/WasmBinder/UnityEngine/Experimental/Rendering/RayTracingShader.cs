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

    public partial class RayTracingShader(long id) : Object(id)
    {

        #region Implementation

        public float maxRecursionDepth 
        {
            get => internal_UnityEngineExperimentalRenderingRayTracingShader__get__maxRecursionDepth(WrappedId);
        }

        public void SetFloat(int nameID, float val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, nameID, val);
        }

        public void SetInt(int nameID, int val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, val);
        }

        public void SetVector(int nameID, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(WrappedId, nameID, val);
        }

        public void SetMatrix(int nameID, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(WrappedId, nameID, val);
        }

        public void SetVectorArray(int nameID, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetMatrixArray(int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetTexture(int nameID, global::UnityEngine.Texture texture)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(WrappedId, nameID, texture);
        }

        public void SetBuffer(int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(WrappedId, nameID, buffer);
        }

        public void SetAccelerationStructure(int nameID, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(WrappedId, nameID, accelerationStructure);
        }

        public void SetShaderPass(string passName)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetShaderPass__SystemString__SystemVoid(WrappedId, passName);
        }

        public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, globalTextureNameID);
        }

        public void Dispatch(string rayGenFunctionName, int width, int height, int depth, global::UnityEngine.Camera camera)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__Dispatch__SystemString__SystemInt32__SystemInt32__SystemInt32__UnityEngineCamera__SystemVoid(WrappedId, rayGenFunctionName, width, height, depth, camera);
        }

        public void SetBuffer(int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, nameID, buffer);
        }

        public void SetFloat(string name, float val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, val);
        }

        public void SetInt(string name, int val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemString__SystemInt32__SystemVoid(WrappedId, name, val);
        }

        public void SetVector(string name, global::UnityEngine.Vector4 val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(WrappedId, name, val);
        }

        public void SetMatrix(string name, global::UnityEngine.Matrix4x4 val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(WrappedId, name, val);
        }

        public void SetVectorArray(string name, global::UnityEngine.Vector4[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetMatrixArray(string name, global::UnityEngine.Matrix4x4[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(WrappedId, name, values);
        }

        public void SetFloats(string name, params global::System.Single[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(WrappedId, name, values);
        }

        public void SetFloats(int nameID, params global::System.Single[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(WrappedId, nameID, values);
        }

        public void SetInts(string name, params global::System.Int32[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(WrappedId, name, values);
        }

        public void SetInts(int nameID, params global::System.Int32[] values)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(WrappedId, nameID, values);
        }

        public void SetBool(string name, bool val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(WrappedId, name, val);
        }

        public void SetBool(int nameID, bool val)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(WrappedId, nameID, val);
        }

        public void SetTexture(string name, global::UnityEngine.Texture texture)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(WrappedId, name, texture);
        }

        public void SetBuffer(string name, global::UnityEngine.ComputeBuffer buffer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(WrappedId, name, buffer);
        }

        public void SetBuffer(string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(WrappedId, name, buffer);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, buffer, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, buffer, offset, size);
        }

        public void SetConstantBuffer(int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, nameID, buffer, offset, size);
        }

        public void SetConstantBuffer(string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(WrappedId, name, buffer, offset, size);
        }

        public void SetAccelerationStructure(string name, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(WrappedId, name, accelerationStructure);
        }

        public void SetTextureFromGlobal(string name, string globalTextureName)
        {
            internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemString__SystemString__SystemVoid(WrappedId, name, globalTextureName);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineExperimentalRenderingRayTracingShader__get__maxRecursionDepth(long selfObjectId)
        {
            var methodCallResult = UnityEngineExperimentalRenderingRayTracingShader__get__maxRecursionDepth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float val)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int val)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4 val)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4 val)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(selfObjectId, nameID, Unsafe.AsPointer(ref val));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Vector4[] values)
        {
            fixed (global::UnityEngine.Vector4* valuesPointer = values)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Texture texture)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(selfObjectId, nameID, texture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer buffer)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(selfObjectId, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(selfObjectId, nameID, accelerationStructure.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetShaderPass__SystemString__SystemVoid(long selfObjectId, string passName)
        {
            fixed (char* passNamePointer = passName)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetShaderPass__SystemString__SystemVoid(selfObjectId, passNamePointer, passName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int globalTextureNameID)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, globalTextureNameID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__Dispatch__SystemString__SystemInt32__SystemInt32__SystemInt32__UnityEngineCamera__SystemVoid(long selfObjectId, string rayGenFunctionName, int width, int height, int depth, global::UnityEngine.Camera camera)
        {
            fixed (char* rayGenFunctionNamePointer = rayGenFunctionName)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__Dispatch__SystemString__SystemInt32__SystemInt32__SystemInt32__UnityEngineCamera__SystemVoid(selfObjectId, rayGenFunctionNamePointer, rayGenFunctionName.Length * sizeof(char), width, height, depth, camera.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer buffer)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, nameID, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4 val)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref val));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Vector4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Vector4* valuesPointer = values)
                {
                    UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, string name, global::UnityEngine.Matrix4x4[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (global::UnityEngine.Matrix4x4* valuesPointer = values)
                {
                    UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, string name, global::System.Single[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (float* valuesPointer = values)
                {
                    UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, string name, global::System.Int32[] values)
        {
            fixed (char* namePointer = name)
            {
                fixed (int* valuesPointer = values)
                {
                    UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valuesPointer, values.Length);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, int nameID, global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(selfObjectId, nameID, valuesPointer, values.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, string name, bool val)
        {
            fixed (char* namePointer = name)
            {
                var valConverted = Unsafe.As<bool, int>(ref val);
                UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, bool val)
        {
            var valConverted = Unsafe.As<bool, int>(ref val);
            UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, nameID, valConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, string name, global::UnityEngine.Texture texture)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), texture.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer buffer)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.ComputeBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, nameID, buffer.WrappedId, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, string name, global::UnityEngine.GraphicsBuffer buffer, int offset, int size)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), buffer.WrappedId, offset, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, string name, global::UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), accelerationStructure.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemString__SystemString__SystemVoid(long selfObjectId, string name, string globalTextureName)
        {
            fixed (char* namePointer = name, globalTextureNamePointer = globalTextureName)
            {
                UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemString__SystemString__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), globalTextureNamePointer, globalTextureName.Length * sizeof(char));
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineExperimentalRenderingRayTracingShader__get__maxRecursionDepth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int nameID, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemInt32__UnityEngineVector4__SystemVoid(long selfObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemInt32__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int nameID, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemInt32__UnityEngineVector4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemInt32__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemInt32__UnityEngineTexture__SystemVoid(long selfObjectId, int nameID, long textureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemInt32__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, int nameID, long accelerationStructureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetShaderPass__SystemString__SystemVoid(long selfObjectId, void* passNamePointer, int passNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, int globalTextureNameID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__Dispatch__SystemString__SystemInt32__SystemInt32__SystemInt32__UnityEngineCamera__SystemVoid(long selfObjectId, void* rayGenFunctionNamePointer, int rayGenFunctionNameWasmLength, int width, int height, int depth, long cameraObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, int nameID, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetInt__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetVector__SystemString__UnityEngineVector4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrix__SystemString__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetVectorArray__SystemString__UnityEngineVector4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetMatrixArray__SystemString__UnityEngineMatrix4x4Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemString__SystemSingleArray__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetFloats__SystemInt32__SystemSingleArray__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemString__SystemInt32Array__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetInts__SystemInt32__SystemInt32Array__SystemVoid(long selfObjectId, int nameID, void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int valConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int nameID, int valConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetTexture__SystemString__UnityEngineTexture__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long textureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineComputeBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetBuffer__SystemString__UnityEngineGraphicsBuffer__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineComputeBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemInt32__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int nameID, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetConstantBuffer__SystemString__UnityEngineGraphicsBuffer__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long bufferObjectId, int offset, int size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetAccelerationStructure__SystemString__UnityEngineExperimentalRenderingRayTracingAccelerationStructure__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, long accelerationStructureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineExperimentalRenderingRayTracingShader__func__SetTextureFromGlobal__SystemString__SystemString__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, void* globalTextureNamePointer, int globalTextureNameWasmLength);

        #endregion Imports
    }
}
