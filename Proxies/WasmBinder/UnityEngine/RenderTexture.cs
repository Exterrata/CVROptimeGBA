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

    public partial class RenderTexture(long id) : Texture(id)
    {

        #region Implementation

        public RenderTexture(global::UnityEngine.RenderTextureDescriptor desc)
            : this(internal_UnityEngineRenderTexture__ctor__UnityEngineRenderTextureDescriptor(desc)) { }

        public RenderTexture(global::UnityEngine.RenderTexture textureToCopy)
            : this(internal_UnityEngineRenderTexture__ctor__UnityEngineRenderTexture(textureToCopy)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.DefaultFormat format)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum(width, height, depth, format)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum(width, height, depth, format)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(width, height, depth, format, mipCount)) { }

        public RenderTexture(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(width, height, colorFormat, depthStencilFormat, mipCount)) { }

        public RenderTexture(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(width, height, colorFormat, depthStencilFormat)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum(width, height, depth, format, readWrite)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(width, height, depth, format)) { }

        public RenderTexture(int width, int height, int depth)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32(width, height, depth)) { }

        public RenderTexture(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format, int mipCount)
            : this(internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(width, height, depth, format, mipCount)) { }

        public int width 
        {
            get => internal_UnityEngineRenderTexture__get__width(WrappedId);
            set => internal_UnityEngineRenderTexture__set__width(WrappedId, value);
        }

        public int height 
        {
            get => internal_UnityEngineRenderTexture__get__height(WrappedId);
            set => internal_UnityEngineRenderTexture__set__height(WrappedId, value);
        }

        public global::UnityEngine.Rendering.TextureDimension dimension 
        {
            get => internal_UnityEngineRenderTexture__get__dimension(WrappedId);
            set => internal_UnityEngineRenderTexture__set__dimension(WrappedId, value);
        }

        public global::UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat 
        {
            get => internal_UnityEngineRenderTexture__get__graphicsFormat(WrappedId);
            set => internal_UnityEngineRenderTexture__set__graphicsFormat(WrappedId, value);
        }

        public bool useMipMap 
        {
            get => internal_UnityEngineRenderTexture__get__useMipMap(WrappedId);
            set => internal_UnityEngineRenderTexture__set__useMipMap(WrappedId, value);
        }

        public bool sRGB 
        {
            get => internal_UnityEngineRenderTexture__get__sRGB(WrappedId);
        }

        public global::UnityEngine.VRTextureUsage vrUsage 
        {
            get => internal_UnityEngineRenderTexture__get__vrUsage(WrappedId);
            set => internal_UnityEngineRenderTexture__set__vrUsage(WrappedId, value);
        }

        public global::UnityEngine.RenderTextureMemoryless memorylessMode 
        {
            get => internal_UnityEngineRenderTexture__get__memorylessMode(WrappedId);
            set => internal_UnityEngineRenderTexture__set__memorylessMode(WrappedId, value);
        }

        public global::UnityEngine.RenderTextureFormat format 
        {
            get => internal_UnityEngineRenderTexture__get__format(WrappedId);
            set => internal_UnityEngineRenderTexture__set__format(WrappedId, value);
        }

        public global::UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat 
        {
            get => internal_UnityEngineRenderTexture__get__stencilFormat(WrappedId);
            set => internal_UnityEngineRenderTexture__set__stencilFormat(WrappedId, value);
        }

        public global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat 
        {
            get => internal_UnityEngineRenderTexture__get__depthStencilFormat(WrappedId);
            set => internal_UnityEngineRenderTexture__set__depthStencilFormat(WrappedId, value);
        }

        public bool autoGenerateMips 
        {
            get => internal_UnityEngineRenderTexture__get__autoGenerateMips(WrappedId);
            set => internal_UnityEngineRenderTexture__set__autoGenerateMips(WrappedId, value);
        }

        public int volumeDepth 
        {
            get => internal_UnityEngineRenderTexture__get__volumeDepth(WrappedId);
            set => internal_UnityEngineRenderTexture__set__volumeDepth(WrappedId, value);
        }

        public int antiAliasing 
        {
            get => internal_UnityEngineRenderTexture__get__antiAliasing(WrappedId);
            set => internal_UnityEngineRenderTexture__set__antiAliasing(WrappedId, value);
        }

        public bool bindTextureMS 
        {
            get => internal_UnityEngineRenderTexture__get__bindTextureMS(WrappedId);
            set => internal_UnityEngineRenderTexture__set__bindTextureMS(WrappedId, value);
        }

        public bool enableRandomWrite 
        {
            get => internal_UnityEngineRenderTexture__get__enableRandomWrite(WrappedId);
            set => internal_UnityEngineRenderTexture__set__enableRandomWrite(WrappedId, value);
        }

        public bool useDynamicScale 
        {
            get => internal_UnityEngineRenderTexture__get__useDynamicScale(WrappedId);
            set => internal_UnityEngineRenderTexture__set__useDynamicScale(WrappedId, value);
        }

        public bool isPowerOfTwo 
        {
            get => internal_UnityEngineRenderTexture__get__isPowerOfTwo(WrappedId);
            set => internal_UnityEngineRenderTexture__set__isPowerOfTwo(WrappedId, value);
        }

        public static global::UnityEngine.RenderTexture active 
        {
            get => internal_UnityEngineRenderTexture__get__active();
            set => internal_UnityEngineRenderTexture__set__active(value);
        }

        public global::UnityEngine.RenderBuffer colorBuffer 
        {
            get => internal_UnityEngineRenderTexture__get__colorBuffer(WrappedId);
        }

        public global::UnityEngine.RenderBuffer depthBuffer 
        {
            get => internal_UnityEngineRenderTexture__get__depthBuffer(WrappedId);
        }

        public int depth 
        {
            get => internal_UnityEngineRenderTexture__get__depth(WrappedId);
            set => internal_UnityEngineRenderTexture__set__depth(WrappedId, value);
        }

        public global::UnityEngine.RenderTextureDescriptor descriptor 
        {
            get => internal_UnityEngineRenderTexture__get__descriptor(WrappedId);
            set => internal_UnityEngineRenderTexture__set__descriptor(WrappedId, value);
        }

        public void DiscardContents(bool discardColor, bool discardDepth)
        {
            internal_UnityEngineRenderTexture__func__DiscardContents__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, discardColor, discardDepth);
        }

        public void DiscardContents()
        {
            internal_UnityEngineRenderTexture__func__DiscardContents__SystemVoid(WrappedId);
        }

        public void ResolveAntiAliasedSurface()
        {
            internal_UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__SystemVoid(WrappedId);
        }

        public void ResolveAntiAliasedSurface(global::UnityEngine.RenderTexture target)
        {
            internal_UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(WrappedId, target);
        }

        public void SetGlobalShaderProperty(string propertyName)
        {
            internal_UnityEngineRenderTexture__func__SetGlobalShaderProperty__SystemString__SystemVoid(WrappedId, propertyName);
        }

        public bool Create()
        {
            return internal_UnityEngineRenderTexture__func__Create__SystemBoolean(WrappedId);
        }

        public void Release()
        {
            internal_UnityEngineRenderTexture__func__Release__SystemVoid(WrappedId);
        }

        public bool IsCreated()
        {
            return internal_UnityEngineRenderTexture__func__IsCreated__SystemBoolean(WrappedId);
        }

        public void GenerateMips()
        {
            internal_UnityEngineRenderTexture__func__GenerateMips__SystemVoid(WrappedId);
        }

        public void ConvertToEquirect(global::UnityEngine.RenderTexture equirect, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            internal_UnityEngineRenderTexture__func__ConvertToEquirect__UnityEngineRenderTexture__UnityEngineMonoOrStereoscopicEyeEnum__SystemVoid(WrappedId, equirect, eye);
        }

        public static bool SupportsStencil(global::UnityEngine.RenderTexture rt)
        {
            return internal_UnityEngineRenderTexture__func__SupportsStencil__UnityEngineRenderTexture__SystemBoolean(rt);
        }

        public static void ReleaseTemporary(global::UnityEngine.RenderTexture temp)
        {
            internal_UnityEngineRenderTexture__func__ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(temp);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(global::UnityEngine.RenderTextureDescriptor desc)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(desc);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(width, height, depthBuffer, format, antiAliasing, memorylessMode);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer, format, antiAliasing);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineRenderTexture(width, height, depthBuffer, format);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, vrUsage);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer, format, readWrite, antiAliasing);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__UnityEngineRenderTexture(width, height, depthBuffer, format, readWrite);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTexture(width, height, depthBuffer, format);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer);
        }

        public static global::UnityEngine.RenderTexture GetTemporary(int width, int height)
        {
            return internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__UnityEngineRenderTexture(width, height);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__UnityEngineRenderTextureDescriptor(global::UnityEngine.RenderTextureDescriptor desc)
        {
            return UnityEngineRenderTexture__ctor__UnityEngineRenderTextureDescriptor(Unsafe.AsPointer(ref desc));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__UnityEngineRenderTexture(global::UnityEngine.RenderTexture textureToCopy)
        {
            return UnityEngineRenderTexture__ctor__UnityEngineRenderTexture(textureToCopy.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.DefaultFormat format)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum(width, height, depth, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum(width, height, depth, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(int width, int height, int depth, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(width, height, depth, (int) format, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(width, height, (int) colorFormat, (int) depthStencilFormat, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(width, height, (int) colorFormat, (int) depthStencilFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum(width, height, depth, (int) format, (int) readWrite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(width, height, depth, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32(int width, int height, int depth)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32(width, height, depth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(int width, int height, int depth, global::UnityEngine.RenderTextureFormat format, int mipCount)
        {
            return UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(width, height, depth, (int) format, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTexture__get__width(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__width(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__width(long selfObjectId, int width)
        {
            UnityEngineRenderTexture__set__width(selfObjectId, width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTexture__get__height(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__height(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__height(long selfObjectId, int height)
        {
            UnityEngineRenderTexture__set__height(selfObjectId, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.TextureDimension internal_UnityEngineRenderTexture__get__dimension(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__dimension(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.TextureDimension)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__dimension(long selfObjectId, global::UnityEngine.Rendering.TextureDimension dimension)
        {
            UnityEngineRenderTexture__set__dimension(selfObjectId, (int) dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.GraphicsFormat internal_UnityEngineRenderTexture__get__graphicsFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__graphicsFormat(selfObjectId);
            var returnResult = (global::UnityEngine.Experimental.Rendering.GraphicsFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__graphicsFormat(long selfObjectId, global::UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat)
        {
            UnityEngineRenderTexture__set__graphicsFormat(selfObjectId, (int) graphicsFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__useMipMap(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__useMipMap(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__useMipMap(long selfObjectId, bool useMipMap)
        {
            var useMipMapConverted = Unsafe.As<bool, int>(ref useMipMap);
            UnityEngineRenderTexture__set__useMipMap(selfObjectId, useMipMapConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__sRGB(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__sRGB(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.VRTextureUsage internal_UnityEngineRenderTexture__get__vrUsage(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__vrUsage(selfObjectId);
            var returnResult = (global::UnityEngine.VRTextureUsage)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__vrUsage(long selfObjectId, global::UnityEngine.VRTextureUsage vrUsage)
        {
            UnityEngineRenderTexture__set__vrUsage(selfObjectId, (int) vrUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTextureMemoryless internal_UnityEngineRenderTexture__get__memorylessMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__memorylessMode(selfObjectId);
            var returnResult = (global::UnityEngine.RenderTextureMemoryless)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__memorylessMode(long selfObjectId, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            UnityEngineRenderTexture__set__memorylessMode(selfObjectId, (int) memorylessMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTextureFormat internal_UnityEngineRenderTexture__get__format(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__format(selfObjectId);
            var returnResult = (global::UnityEngine.RenderTextureFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__format(long selfObjectId, global::UnityEngine.RenderTextureFormat format)
        {
            UnityEngineRenderTexture__set__format(selfObjectId, (int) format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.GraphicsFormat internal_UnityEngineRenderTexture__get__stencilFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__stencilFormat(selfObjectId);
            var returnResult = (global::UnityEngine.Experimental.Rendering.GraphicsFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__stencilFormat(long selfObjectId, global::UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat)
        {
            UnityEngineRenderTexture__set__stencilFormat(selfObjectId, (int) stencilFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.GraphicsFormat internal_UnityEngineRenderTexture__get__depthStencilFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__depthStencilFormat(selfObjectId);
            var returnResult = (global::UnityEngine.Experimental.Rendering.GraphicsFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__depthStencilFormat(long selfObjectId, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
        {
            UnityEngineRenderTexture__set__depthStencilFormat(selfObjectId, (int) depthStencilFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__autoGenerateMips(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__autoGenerateMips(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__autoGenerateMips(long selfObjectId, bool autoGenerateMips)
        {
            var autoGenerateMipsConverted = Unsafe.As<bool, int>(ref autoGenerateMips);
            UnityEngineRenderTexture__set__autoGenerateMips(selfObjectId, autoGenerateMipsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTexture__get__volumeDepth(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__volumeDepth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__volumeDepth(long selfObjectId, int volumeDepth)
        {
            UnityEngineRenderTexture__set__volumeDepth(selfObjectId, volumeDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTexture__get__antiAliasing(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__antiAliasing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__antiAliasing(long selfObjectId, int antiAliasing)
        {
            UnityEngineRenderTexture__set__antiAliasing(selfObjectId, antiAliasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__bindTextureMS(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__bindTextureMS(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__bindTextureMS(long selfObjectId, bool bindTextureMS)
        {
            var bindTextureMSConverted = Unsafe.As<bool, int>(ref bindTextureMS);
            UnityEngineRenderTexture__set__bindTextureMS(selfObjectId, bindTextureMSConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__enableRandomWrite(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__enableRandomWrite(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__enableRandomWrite(long selfObjectId, bool enableRandomWrite)
        {
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderTexture__set__enableRandomWrite(selfObjectId, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__useDynamicScale(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__useDynamicScale(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__useDynamicScale(long selfObjectId, bool useDynamicScale)
        {
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            UnityEngineRenderTexture__set__useDynamicScale(selfObjectId, useDynamicScaleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__get__isPowerOfTwo(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__isPowerOfTwo(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__isPowerOfTwo(long selfObjectId, bool isPowerOfTwo)
        {
            var isPowerOfTwoConverted = Unsafe.As<bool, int>(ref isPowerOfTwo);
            UnityEngineRenderTexture__set__isPowerOfTwo(selfObjectId, isPowerOfTwoConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__get__active()
        {
            var methodCallResult = UnityEngineRenderTexture__get__active();
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__active(global::UnityEngine.RenderTexture active)
        {
            UnityEngineRenderTexture__set__active(active.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer internal_UnityEngineRenderTexture__get__colorBuffer(long selfObjectId)
        {
            global::UnityEngine.RenderBuffer colorBufferValue = default;
            UnityEngineRenderTexture__get__colorBuffer(selfObjectId, Unsafe.AsPointer(ref colorBufferValue));
            global::UnityEngine.RenderBuffer returnResult = colorBufferValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer internal_UnityEngineRenderTexture__get__depthBuffer(long selfObjectId)
        {
            global::UnityEngine.RenderBuffer depthBufferValue = default;
            UnityEngineRenderTexture__get__depthBuffer(selfObjectId, Unsafe.AsPointer(ref depthBufferValue));
            global::UnityEngine.RenderBuffer returnResult = depthBufferValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTexture__get__depth(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__get__depth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__depth(long selfObjectId, int depth)
        {
            UnityEngineRenderTexture__set__depth(selfObjectId, depth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTextureDescriptor internal_UnityEngineRenderTexture__get__descriptor(long selfObjectId)
        {
            global::UnityEngine.RenderTextureDescriptor descriptorValue = default;
            UnityEngineRenderTexture__get__descriptor(selfObjectId, Unsafe.AsPointer(ref descriptorValue));
            global::UnityEngine.RenderTextureDescriptor returnResult = descriptorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__set__descriptor(long selfObjectId, global::UnityEngine.RenderTextureDescriptor descriptor)
        {
            UnityEngineRenderTexture__set__descriptor(selfObjectId, Unsafe.AsPointer(ref descriptor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__DiscardContents__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, bool discardColor, bool discardDepth)
        {
            var discardColorConverted = Unsafe.As<bool, int>(ref discardColor);
            var discardDepthConverted = Unsafe.As<bool, int>(ref discardDepth);
            UnityEngineRenderTexture__func__DiscardContents__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, discardColorConverted, discardDepthConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__DiscardContents__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderTexture__func__DiscardContents__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(long selfObjectId, global::UnityEngine.RenderTexture target)
        {
            UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(selfObjectId, target.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__SetGlobalShaderProperty__SystemString__SystemVoid(long selfObjectId, string propertyName)
        {
            fixed (char* propertyNamePointer = propertyName)
            {
                UnityEngineRenderTexture__func__SetGlobalShaderProperty__SystemString__SystemVoid(selfObjectId, propertyNamePointer, propertyName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__func__Create__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__func__Create__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__Release__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderTexture__func__Release__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__func__IsCreated__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTexture__func__IsCreated__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__GenerateMips__SystemVoid(long selfObjectId)
        {
            UnityEngineRenderTexture__func__GenerateMips__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__ConvertToEquirect__UnityEngineRenderTexture__UnityEngineMonoOrStereoscopicEyeEnum__SystemVoid(long selfObjectId, global::UnityEngine.RenderTexture equirect, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            UnityEngineRenderTexture__func__ConvertToEquirect__UnityEngineRenderTexture__UnityEngineMonoOrStereoscopicEyeEnum__SystemVoid(selfObjectId, equirect.WrappedId, (int) eye);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTexture__func__SupportsStencil__UnityEngineRenderTexture__SystemBoolean(global::UnityEngine.RenderTexture rt)
        {
            var methodCallResult = UnityEngineRenderTexture__func__SupportsStencil__UnityEngineRenderTexture__SystemBoolean(rt.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTexture__func__ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(global::UnityEngine.RenderTexture temp)
        {
            UnityEngineRenderTexture__func__ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(temp.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(global::UnityEngine.RenderTextureDescriptor desc)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(Unsafe.AsPointer(ref desc));
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale)
        {
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, antiAliasing, (int) memorylessMode, (int) vrUsage, useDynamicScaleConverted);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, antiAliasing, (int) memorylessMode, (int) vrUsage);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, antiAliasing, (int) memorylessMode);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, antiAliasing);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.Experimental.Rendering.GraphicsFormat format)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale)
        {
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, (int) readWrite, antiAliasing, (int) memorylessMode, (int) vrUsage, useDynamicScaleConverted);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode, global::UnityEngine.VRTextureUsage vrUsage)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, (int) readWrite, antiAliasing, (int) memorylessMode, (int) vrUsage);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, global::UnityEngine.RenderTextureMemoryless memorylessMode)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, (int) readWrite, antiAliasing, (int) memorylessMode);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, (int) readWrite, antiAliasing);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format, global::UnityEngine.RenderTextureReadWrite readWrite)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format, (int) readWrite);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, global::UnityEngine.RenderTextureFormat format)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTexture(width, height, depthBuffer, (int) format);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTexture(width, height, depthBuffer);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__UnityEngineRenderTexture(int width, int height)
        {
            var methodCallResult = UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__UnityEngineRenderTexture(width, height);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTexture__ctor__UnityEngineRenderTextureDescriptor(void* descPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__UnityEngineRenderTexture(long textureToCopyObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum(int width, int height, int depth, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum(int width, int height, int depth, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(int width, int height, int depth, int formatUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(int width, int height, int colorFormatUnderlyingValue, int depthStencilFormatUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(int width, int height, int colorFormatUnderlyingValue, int depthStencilFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum(int width, int height, int depth, int formatUnderlyingValue, int readWriteUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(int width, int height, int depth, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32(int width, int height, int depth);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__ctor__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(int width, int height, int depth, int formatUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__width(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__width(long selfObjectId, int width);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__height(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__height(long selfObjectId, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__dimension(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__dimension(long selfObjectId, int dimensionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__graphicsFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__graphicsFormat(long selfObjectId, int graphicsFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__useMipMap(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__useMipMap(long selfObjectId, int useMipMapConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__sRGB(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__vrUsage(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__vrUsage(long selfObjectId, int vrUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__memorylessMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__memorylessMode(long selfObjectId, int memorylessModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__format(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__format(long selfObjectId, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__stencilFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__stencilFormat(long selfObjectId, int stencilFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__depthStencilFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__depthStencilFormat(long selfObjectId, int depthStencilFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__autoGenerateMips(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__autoGenerateMips(long selfObjectId, int autoGenerateMipsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__volumeDepth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__volumeDepth(long selfObjectId, int volumeDepth);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__antiAliasing(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__antiAliasing(long selfObjectId, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__bindTextureMS(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__bindTextureMS(long selfObjectId, int bindTextureMSConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__enableRandomWrite(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__enableRandomWrite(long selfObjectId, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__useDynamicScale(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__useDynamicScale(long selfObjectId, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__isPowerOfTwo(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__isPowerOfTwo(long selfObjectId, int isPowerOfTwoConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__get__active();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__active(long activeObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTexture__get__colorBuffer(long selfObjectId, void* colorBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTexture__get__depthBuffer(long selfObjectId, void* depthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__get__depth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__set__depth(long selfObjectId, int depth);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTexture__get__descriptor(long selfObjectId, void* descriptorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTexture__set__descriptor(long selfObjectId, void* descriptorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__DiscardContents__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int discardColorConverted, int discardDepthConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__DiscardContents__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(long selfObjectId, long targetObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTexture__func__SetGlobalShaderProperty__SystemString__SystemVoid(long selfObjectId, void* propertyNamePointer, int propertyNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__func__Create__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__Release__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__func__IsCreated__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__GenerateMips__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__ConvertToEquirect__UnityEngineRenderTexture__UnityEngineMonoOrStereoscopicEyeEnum__SystemVoid(long selfObjectId, long equirectObjectId, int eyeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTexture__func__SupportsStencil__UnityEngineRenderTexture__SystemBoolean(long rtObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTexture__func__ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(long tempObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTexture__func__GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(void* descPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue, int vrUsageUnderlyingValue, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue, int vrUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__SystemBoolean__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue, int vrUsageUnderlyingValue, int useDynamicScaleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineVRTextureUsageEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue, int vrUsageUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTextureMemorylessEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing, int memorylessModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int readWriteUnderlyingValue, int antiAliasing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTextureReadWriteEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue, int readWriteUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__UnityEngineRenderTexture(int width, int height, int depthBuffer, int formatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__SystemInt32__UnityEngineRenderTexture(int width, int height, int depthBuffer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderTexture__func__GetTemporary__SystemInt32__SystemInt32__UnityEngineRenderTexture(int width, int height);

        #endregion Imports
    }
}
