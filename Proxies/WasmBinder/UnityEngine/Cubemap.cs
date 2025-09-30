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

    public partial class Cubemap(long id) : Texture(id)
    {

        #region Implementation

        public Cubemap(int width, global::UnityEngine.Experimental.Rendering.DefaultFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            : this(internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, format, flags)) { }

        public Cubemap(int width, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            : this(internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, format, flags)) { }

        public Cubemap(int width, global::UnityEngine.TextureFormat format, int mipCount)
            : this(internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32(width, format, mipCount)) { }

        public Cubemap(int width, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
            : this(internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum__SystemInt32(width, format, flags, mipCount)) { }

        public Cubemap(int width, global::UnityEngine.TextureFormat textureFormat, bool mipChain)
            : this(internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(width, textureFormat, mipChain)) { }

        public global::UnityEngine.TextureFormat format 
        {
            get => internal_UnityEngineCubemap__get__format(WrappedId);
        }

        public bool isReadable 
        {
            get => internal_UnityEngineCubemap__get__isReadable(WrappedId);
        }

        public bool streamingMipmaps 
        {
            get => internal_UnityEngineCubemap__get__streamingMipmaps(WrappedId);
        }

        public int streamingMipmapsPriority 
        {
            get => internal_UnityEngineCubemap__get__streamingMipmapsPriority(WrappedId);
        }

        public int requestedMipmapLevel 
        {
            get => internal_UnityEngineCubemap__get__requestedMipmapLevel(WrappedId);
            set => internal_UnityEngineCubemap__set__requestedMipmapLevel(WrappedId, value);
        }

        public int desiredMipmapLevel 
        {
            get => internal_UnityEngineCubemap__get__desiredMipmapLevel(WrappedId);
        }

        public int loadingMipmapLevel 
        {
            get => internal_UnityEngineCubemap__get__loadingMipmapLevel(WrappedId);
        }

        public int loadedMipmapLevel 
        {
            get => internal_UnityEngineCubemap__get__loadedMipmapLevel(WrappedId);
        }

        public void SmoothEdges(int smoothRegionWidthInPixels)
        {
            internal_UnityEngineCubemap__func__SmoothEdges__SystemInt32__SystemVoid(WrappedId, smoothRegionWidthInPixels);
        }

        public void SmoothEdges()
        {
            internal_UnityEngineCubemap__func__SmoothEdges__SystemVoid(WrappedId);
        }

        public global::UnityEngine.Color[] GetPixels(global::UnityEngine.CubemapFace face, int miplevel)
        {
            return internal_UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__SystemInt32__UnityEngineColorArray(WrappedId, face, miplevel);
        }

        public global::UnityEngine.Color[] GetPixels(global::UnityEngine.CubemapFace face)
        {
            return internal_UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__UnityEngineColorArray(WrappedId, face);
        }

        public void SetPixels(global::UnityEngine.Color[] colors, global::UnityEngine.CubemapFace face, int miplevel)
        {
            internal_UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(WrappedId, colors, face, miplevel);
        }

        public void SetPixels(global::UnityEngine.Color[] colors, global::UnityEngine.CubemapFace face)
        {
            internal_UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemVoid(WrappedId, colors, face);
        }

        public void ClearRequestedMipmapLevel()
        {
            internal_UnityEngineCubemap__func__ClearRequestedMipmapLevel__SystemVoid(WrappedId);
        }

        public bool IsRequestedMipmapLevelLoaded()
        {
            return internal_UnityEngineCubemap__func__IsRequestedMipmapLevelLoaded__SystemBoolean(WrappedId);
        }

        public void SetPixel(global::UnityEngine.CubemapFace face, int x, int y, global::UnityEngine.Color color)
        {
            internal_UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(WrappedId, face, x, y, color);
        }

        public void SetPixel(global::UnityEngine.CubemapFace face, int x, int y, global::UnityEngine.Color color, int mip)
        {
            internal_UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(WrappedId, face, x, y, color, mip);
        }

        public global::UnityEngine.Color GetPixel(global::UnityEngine.CubemapFace face, int x, int y)
        {
            return internal_UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor(WrappedId, face, x, y);
        }

        public global::UnityEngine.Color GetPixel(global::UnityEngine.CubemapFace face, int x, int y, int mip)
        {
            return internal_UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(WrappedId, face, x, y, mip);
        }

        public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
        {
            internal_UnityEngineCubemap__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, updateMipmaps, makeNoLongerReadable);
        }

        public void Apply(bool updateMipmaps)
        {
            internal_UnityEngineCubemap__func__Apply__SystemBoolean__SystemVoid(WrappedId, updateMipmaps);
        }

        public void Apply()
        {
            internal_UnityEngineCubemap__func__Apply__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, global::UnityEngine.Experimental.Rendering.DefaultFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        {
            return UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, (int) format, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        {
            return UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, (int) format, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32(int width, global::UnityEngine.TextureFormat format, int mipCount)
        {
            return UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32(width, (int) format, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum__SystemInt32(int width, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
        {
            return UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum__SystemInt32(width, (int) format, (int) flags, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(int width, global::UnityEngine.TextureFormat textureFormat, bool mipChain)
        {
            var mipChainConverted = Unsafe.As<bool, int>(ref mipChain);
            return UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(width, (int) textureFormat, mipChainConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureFormat internal_UnityEngineCubemap__get__format(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__format(selfObjectId);
            var returnResult = (global::UnityEngine.TextureFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCubemap__get__isReadable(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__isReadable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCubemap__get__streamingMipmaps(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__streamingMipmaps(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCubemap__get__streamingMipmapsPriority(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__streamingMipmapsPriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCubemap__get__requestedMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__requestedMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__set__requestedMipmapLevel(long selfObjectId, int requestedMipmapLevel)
        {
            UnityEngineCubemap__set__requestedMipmapLevel(selfObjectId, requestedMipmapLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCubemap__get__desiredMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__desiredMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCubemap__get__loadingMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__loadingMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCubemap__get__loadedMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__get__loadedMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SmoothEdges__SystemInt32__SystemVoid(long selfObjectId, int smoothRegionWidthInPixels)
        {
            UnityEngineCubemap__func__SmoothEdges__SystemInt32__SystemVoid(selfObjectId, smoothRegionWidthInPixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SmoothEdges__SystemVoid(long selfObjectId)
        {
            UnityEngineCubemap__func__SmoothEdges__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__SystemInt32__UnityEngineColorArray(long selfObjectId, global::UnityEngine.CubemapFace face, int miplevel)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__SystemInt32__UnityEngineColorArray(selfObjectId, (int) face, miplevel, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__UnityEngineColorArray(long selfObjectId, global::UnityEngine.CubemapFace face)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__UnityEngineColorArray(selfObjectId, (int) face, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Color[] colors, global::UnityEngine.CubemapFace face, int miplevel)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(selfObjectId, colorsPointer, colors.Length, (int) face, miplevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Color[] colors, global::UnityEngine.CubemapFace face)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemVoid(selfObjectId, colorsPointer, colors.Length, (int) face);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__ClearRequestedMipmapLevel__SystemVoid(long selfObjectId)
        {
            UnityEngineCubemap__func__ClearRequestedMipmapLevel__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCubemap__func__IsRequestedMipmapLevelLoaded__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineCubemap__func__IsRequestedMipmapLevelLoaded__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, global::UnityEngine.CubemapFace face, int x, int y, global::UnityEngine.Color color)
        {
            UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(selfObjectId, (int) face, x, y, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.CubemapFace face, int x, int y, global::UnityEngine.Color color, int mip)
        {
            UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(selfObjectId, (int) face, x, y, Unsafe.AsPointer(ref color), mip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, global::UnityEngine.CubemapFace face, int x, int y)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor(selfObjectId, (int) face, x, y, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, global::UnityEngine.CubemapFace face, int x, int y, int mip)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(selfObjectId, (int) face, x, y, mip, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, bool updateMipmaps, bool makeNoLongerReadable)
        {
            var updateMipmapsConverted = Unsafe.As<bool, int>(ref updateMipmaps);
            var makeNoLongerReadableConverted = Unsafe.As<bool, int>(ref makeNoLongerReadable);
            UnityEngineCubemap__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, updateMipmapsConverted, makeNoLongerReadableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__Apply__SystemBoolean__SystemVoid(long selfObjectId, bool updateMipmaps)
        {
            var updateMipmapsConverted = Unsafe.As<bool, int>(ref updateMipmaps);
            UnityEngineCubemap__func__Apply__SystemBoolean__SystemVoid(selfObjectId, updateMipmapsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCubemap__func__Apply__SystemVoid(long selfObjectId)
        {
            UnityEngineCubemap__func__Apply__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int formatUnderlyingValue, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int formatUnderlyingValue, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32(int width, int formatUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCubemap__ctor__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum__SystemInt32(int width, int formatUnderlyingValue, int flagsUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCubemap__ctor__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(int width, int textureFormatUnderlyingValue, int mipChainConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__format(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__isReadable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__streamingMipmaps(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__streamingMipmapsPriority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__requestedMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__set__requestedMipmapLevel(long selfObjectId, int requestedMipmapLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__desiredMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__loadingMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__get__loadedMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__SmoothEdges__SystemInt32__SystemVoid(long selfObjectId, int smoothRegionWidthInPixels);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__SmoothEdges__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__SystemInt32__UnityEngineColorArray(long selfObjectId, int faceUnderlyingValue, int miplevel, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__GetPixels__UnityEngineCubemapFaceEnum__UnityEngineColorArray(long selfObjectId, int faceUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemInt32__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, int faceUnderlyingValue, int miplevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__SetPixels__UnityEngineColorArray__UnityEngineCubemapFaceEnum__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, int faceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__ClearRequestedMipmapLevel__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCubemap__func__IsRequestedMipmapLevelLoaded__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int faceUnderlyingValue, int x, int y, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__SetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(long selfObjectId, int faceUnderlyingValue, int x, int y, void* colorPointer, int mip);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int faceUnderlyingValue, int x, int y, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCubemap__func__GetPixel__UnityEngineCubemapFaceEnum__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int faceUnderlyingValue, int x, int y, int mip, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int updateMipmapsConverted, int makeNoLongerReadableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__Apply__SystemBoolean__SystemVoid(long selfObjectId, int updateMipmapsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCubemap__func__Apply__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
