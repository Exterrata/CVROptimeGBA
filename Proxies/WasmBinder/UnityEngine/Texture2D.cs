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

    public partial class Texture2D(long id) : Texture(id)
    {

        #region Implementation

        public Texture2D(int width, int height, global::UnityEngine.Experimental.Rendering.DefaultFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, format, flags)) { }

        public Texture2D(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, format, flags)) { }

        public Texture2D(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, format, mipCount, flags)) { }

        public Texture2D(int width, int height, global::UnityEngine.TextureFormat textureFormat, int mipCount, bool linear)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32__SystemBoolean(width, height, textureFormat, mipCount, linear)) { }

        public Texture2D(int width, int height, global::UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(width, height, textureFormat, mipChain, linear)) { }

        public Texture2D(int width, int height, global::UnityEngine.TextureFormat textureFormat, bool mipChain)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(width, height, textureFormat, mipChain)) { }

        public Texture2D(int width, int height)
            : this(internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32(width, height)) { }

        public global::UnityEngine.TextureFormat format 
        {
            get => internal_UnityEngineTexture2D__get__format(WrappedId);
        }

        public bool ignoreMipmapLimit 
        {
            get => internal_UnityEngineTexture2D__get__ignoreMipmapLimit(WrappedId);
            set => internal_UnityEngineTexture2D__set__ignoreMipmapLimit(WrappedId, value);
        }

        public static global::UnityEngine.Texture2D whiteTexture 
        {
            get => internal_UnityEngineTexture2D__get__whiteTexture();
        }

        public static global::UnityEngine.Texture2D blackTexture 
        {
            get => internal_UnityEngineTexture2D__get__blackTexture();
        }

        public static global::UnityEngine.Texture2D redTexture 
        {
            get => internal_UnityEngineTexture2D__get__redTexture();
        }

        public static global::UnityEngine.Texture2D grayTexture 
        {
            get => internal_UnityEngineTexture2D__get__grayTexture();
        }

        public static global::UnityEngine.Texture2D linearGrayTexture 
        {
            get => internal_UnityEngineTexture2D__get__linearGrayTexture();
        }

        public static global::UnityEngine.Texture2D normalTexture 
        {
            get => internal_UnityEngineTexture2D__get__normalTexture();
        }

        public bool isReadable 
        {
            get => internal_UnityEngineTexture2D__get__isReadable(WrappedId);
        }

        public bool vtOnly 
        {
            get => internal_UnityEngineTexture2D__get__vtOnly(WrappedId);
        }

        public bool streamingMipmaps 
        {
            get => internal_UnityEngineTexture2D__get__streamingMipmaps(WrappedId);
        }

        public int streamingMipmapsPriority 
        {
            get => internal_UnityEngineTexture2D__get__streamingMipmapsPriority(WrappedId);
        }

        public int requestedMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__requestedMipmapLevel(WrappedId);
            set => internal_UnityEngineTexture2D__set__requestedMipmapLevel(WrappedId, value);
        }

        public int minimumMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__minimumMipmapLevel(WrappedId);
            set => internal_UnityEngineTexture2D__set__minimumMipmapLevel(WrappedId, value);
        }

        public int calculatedMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__calculatedMipmapLevel(WrappedId);
        }

        public int desiredMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__desiredMipmapLevel(WrappedId);
        }

        public int loadingMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__loadingMipmapLevel(WrappedId);
        }

        public int loadedMipmapLevel 
        {
            get => internal_UnityEngineTexture2D__get__loadedMipmapLevel(WrappedId);
        }

        public void Compress(bool highQuality)
        {
            internal_UnityEngineTexture2D__func__Compress__SystemBoolean__SystemVoid(WrappedId, highQuality);
        }

        public void ClearRequestedMipmapLevel()
        {
            internal_UnityEngineTexture2D__func__ClearRequestedMipmapLevel__SystemVoid(WrappedId);
        }

        public bool IsRequestedMipmapLevelLoaded()
        {
            return internal_UnityEngineTexture2D__func__IsRequestedMipmapLevelLoaded__SystemBoolean(WrappedId);
        }

        public void ClearMinimumMipmapLevel()
        {
            internal_UnityEngineTexture2D__func__ClearMinimumMipmapLevel__SystemVoid(WrappedId);
        }

        public global::System.Byte[] GetRawTextureData()
        {
            return internal_UnityEngineTexture2D__func__GetRawTextureData__SystemByteArray(WrappedId);
        }

        public global::UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel)
        {
            return internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(WrappedId, x, y, blockWidth, blockHeight, miplevel);
        }

        public global::UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
        {
            return internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(WrappedId, x, y, blockWidth, blockHeight);
        }

        public global::UnityEngine.Color32[] GetPixels32(int miplevel)
        {
            return internal_UnityEngineTexture2D__func__GetPixels32__SystemInt32__UnityEngineColor32Array(WrappedId, miplevel);
        }

        public global::UnityEngine.Color32[] GetPixels32()
        {
            return internal_UnityEngineTexture2D__func__GetPixels32__UnityEngineColor32Array(WrappedId);
        }

        public global::UnityEngine.Rect[] PackTextures(global::UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
        {
            return internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__SystemBoolean__UnityEngineRectArray(WrappedId, textures, padding, maximumAtlasSize, makeNoLongerReadable);
        }

        public global::UnityEngine.Rect[] PackTextures(global::UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize)
        {
            return internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__UnityEngineRectArray(WrappedId, textures, padding, maximumAtlasSize);
        }

        public global::UnityEngine.Rect[] PackTextures(global::UnityEngine.Texture2D[] textures, int padding)
        {
            return internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__UnityEngineRectArray(WrappedId, textures, padding);
        }

        public void SetPixel(int x, int y, global::UnityEngine.Color color)
        {
            internal_UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(WrappedId, x, y, color);
        }

        public void SetPixel(int x, int y, global::UnityEngine.Color color, int mipLevel)
        {
            internal_UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(WrappedId, x, y, color, mipLevel);
        }

        public void SetPixels(int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color[] colors, int miplevel)
        {
            internal_UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemInt32__SystemVoid(WrappedId, x, y, blockWidth, blockHeight, colors, miplevel);
        }

        public void SetPixels(int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color[] colors)
        {
            internal_UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemVoid(WrappedId, x, y, blockWidth, blockHeight, colors);
        }

        public void SetPixels(global::UnityEngine.Color[] colors, int miplevel)
        {
            internal_UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemInt32__SystemVoid(WrappedId, colors, miplevel);
        }

        public void SetPixels(global::UnityEngine.Color[] colors)
        {
            internal_UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemVoid(WrappedId, colors);
        }

        public global::UnityEngine.Color GetPixel(int x, int y)
        {
            return internal_UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__UnityEngineColor(WrappedId, x, y);
        }

        public global::UnityEngine.Color GetPixel(int x, int y, int mipLevel)
        {
            return internal_UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(WrappedId, x, y, mipLevel);
        }

        public global::UnityEngine.Color GetPixelBilinear(float u, float v)
        {
            return internal_UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__UnityEngineColor(WrappedId, u, v);
        }

        public global::UnityEngine.Color GetPixelBilinear(float u, float v, int mipLevel)
        {
            return internal_UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__SystemInt32__UnityEngineColor(WrappedId, u, v, mipLevel);
        }

        public void LoadRawTextureData(global::System.Byte[] data)
        {
            internal_UnityEngineTexture2D__func__LoadRawTextureData__SystemByteArray__SystemVoid(WrappedId, data);
        }

        public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
        {
            internal_UnityEngineTexture2D__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(WrappedId, updateMipmaps, makeNoLongerReadable);
        }

        public void Apply(bool updateMipmaps)
        {
            internal_UnityEngineTexture2D__func__Apply__SystemBoolean__SystemVoid(WrappedId, updateMipmaps);
        }

        public void Apply()
        {
            internal_UnityEngineTexture2D__func__Apply__SystemVoid(WrappedId);
        }

        public bool Reinitialize(int width, int height)
        {
            return internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__SystemBoolean(WrappedId, width, height);
        }

        public bool Reinitialize(int width, int height, global::UnityEngine.TextureFormat format, bool hasMipMap)
        {
            return internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(WrappedId, width, height, format, hasMipMap);
        }

        public bool Reinitialize(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
        {
            return internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemBoolean__SystemBoolean(WrappedId, width, height, format, hasMipMap);
        }

        public void ReadPixels(global::UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps)
        {
            internal_UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(WrappedId, source, destX, destY, recalculateMipMaps);
        }

        public void ReadPixels(global::UnityEngine.Rect source, int destX, int destY)
        {
            internal_UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemVoid(WrappedId, source, destX, destY);
        }

        public static bool GenerateAtlas(global::UnityEngine.Vector2[] sizes, int padding, int atlasSize, global::System.Collections.Generic.List<global::UnityEngine.Rect> results)
        {
            return internal_UnityEngineTexture2D__func__GenerateAtlas__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemCollectionsGeneric_List_UnityEngineRect__SystemBoolean(sizes, padding, atlasSize, results);
        }

        public void SetPixels32(global::UnityEngine.Color32[] colors, int miplevel)
        {
            internal_UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemInt32__SystemVoid(WrappedId, colors, miplevel);
        }

        public void SetPixels32(global::UnityEngine.Color32[] colors)
        {
            internal_UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(WrappedId, colors);
        }

        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color32[] colors, int miplevel)
        {
            internal_UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemInt32__SystemVoid(WrappedId, x, y, blockWidth, blockHeight, colors, miplevel);
        }

        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color32[] colors)
        {
            internal_UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemVoid(WrappedId, x, y, blockWidth, blockHeight, colors);
        }

        public global::UnityEngine.Color[] GetPixels(int miplevel)
        {
            return internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__UnityEngineColorArray(WrappedId, miplevel);
        }

        public global::UnityEngine.Color[] GetPixels()
        {
            return internal_UnityEngineTexture2D__func__GetPixels__UnityEngineColorArray(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, global::UnityEngine.Experimental.Rendering.DefaultFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        {
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, (int) format, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        {
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, (int) format, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, global::UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        {
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(width, height, (int) format, mipCount, (int) flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32__SystemBoolean(int width, int height, global::UnityEngine.TextureFormat textureFormat, int mipCount, bool linear)
        {
            var linearConverted = Unsafe.As<bool, int>(ref linear);
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32__SystemBoolean(width, height, (int) textureFormat, mipCount, linearConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(int width, int height, global::UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear)
        {
            var mipChainConverted = Unsafe.As<bool, int>(ref mipChain);
            var linearConverted = Unsafe.As<bool, int>(ref linear);
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(width, height, (int) textureFormat, mipChainConverted, linearConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(int width, int height, global::UnityEngine.TextureFormat textureFormat, bool mipChain)
        {
            var mipChainConverted = Unsafe.As<bool, int>(ref mipChain);
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(width, height, (int) textureFormat, mipChainConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTexture2D__ctor__SystemInt32__SystemInt32(int width, int height)
        {
            return UnityEngineTexture2D__ctor__SystemInt32__SystemInt32(width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureFormat internal_UnityEngineTexture2D__get__format(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__format(selfObjectId);
            var returnResult = (global::UnityEngine.TextureFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__get__ignoreMipmapLimit(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__ignoreMipmapLimit(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__set__ignoreMipmapLimit(long selfObjectId, bool ignoreMipmapLimit)
        {
            var ignoreMipmapLimitConverted = Unsafe.As<bool, int>(ref ignoreMipmapLimit);
            UnityEngineTexture2D__set__ignoreMipmapLimit(selfObjectId, ignoreMipmapLimitConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__whiteTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__whiteTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__blackTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__blackTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__redTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__redTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__grayTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__grayTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__linearGrayTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__linearGrayTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Texture2D internal_UnityEngineTexture2D__get__normalTexture()
        {
            var methodCallResult = UnityEngineTexture2D__get__normalTexture();
            var returnResult = new global::UnityEngine.Texture2D(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__get__isReadable(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__isReadable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__get__vtOnly(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__vtOnly(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__get__streamingMipmaps(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__streamingMipmaps(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__streamingMipmapsPriority(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__streamingMipmapsPriority(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__requestedMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__requestedMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__set__requestedMipmapLevel(long selfObjectId, int requestedMipmapLevel)
        {
            UnityEngineTexture2D__set__requestedMipmapLevel(selfObjectId, requestedMipmapLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__minimumMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__minimumMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__set__minimumMipmapLevel(long selfObjectId, int minimumMipmapLevel)
        {
            UnityEngineTexture2D__set__minimumMipmapLevel(selfObjectId, minimumMipmapLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__calculatedMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__calculatedMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__desiredMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__desiredMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__loadingMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__loadingMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture2D__get__loadedMipmapLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__get__loadedMipmapLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__Compress__SystemBoolean__SystemVoid(long selfObjectId, bool highQuality)
        {
            var highQualityConverted = Unsafe.As<bool, int>(ref highQuality);
            UnityEngineTexture2D__func__Compress__SystemBoolean__SystemVoid(selfObjectId, highQualityConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__ClearRequestedMipmapLevel__SystemVoid(long selfObjectId)
        {
            UnityEngineTexture2D__func__ClearRequestedMipmapLevel__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__func__IsRequestedMipmapLevelLoaded__SystemBoolean(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture2D__func__IsRequestedMipmapLevelLoaded__SystemBoolean(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__ClearMinimumMipmapLevel__SystemVoid(long selfObjectId)
        {
            UnityEngineTexture2D__func__ClearMinimumMipmapLevel__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Byte[] internal_UnityEngineTexture2D__func__GetRawTextureData__SystemByteArray(long selfObjectId)
        {
            byte* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetRawTextureData__SystemByteArray(selfObjectId, &returnResultIdsPointer, &returnResultWasmLength);
            byte[] returnResult = new byte[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(long selfObjectId, int x, int y, int blockWidth, int blockHeight, int miplevel)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(selfObjectId, x, y, blockWidth, blockHeight, miplevel, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(long selfObjectId, int x, int y, int blockWidth, int blockHeight)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(selfObjectId, x, y, blockWidth, blockHeight, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32[] internal_UnityEngineTexture2D__func__GetPixels32__SystemInt32__UnityEngineColor32Array(long selfObjectId, int miplevel)
        {
            global::UnityEngine.Color32* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels32__SystemInt32__UnityEngineColor32Array(selfObjectId, miplevel, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color32[] returnResult = new global::UnityEngine.Color32[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color32[] internal_UnityEngineTexture2D__func__GetPixels32__UnityEngineColor32Array(long selfObjectId)
        {
            global::UnityEngine.Color32* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels32__UnityEngineColor32Array(selfObjectId, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color32[] returnResult = new global::UnityEngine.Color32[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect[] internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__SystemBoolean__UnityEngineRectArray(long selfObjectId, global::UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
        {
            int texturesWasmLength = textures.Length;
            long[] texturesIds = new long[texturesWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < texturesWasmLength; i++) texturesIds[i] = (textures[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* texturesIdsPointer = texturesIds)
            {
                var makeNoLongerReadableConverted = Unsafe.As<bool, int>(ref makeNoLongerReadable);
                global::UnityEngine.Rect* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__SystemBoolean__UnityEngineRectArray(selfObjectId, texturesIdsPointer, texturesWasmLength, padding, maximumAtlasSize, makeNoLongerReadableConverted, &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Rect[] returnResult = new global::UnityEngine.Rect[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect[] internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__UnityEngineRectArray(long selfObjectId, global::UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize)
        {
            int texturesWasmLength = textures.Length;
            long[] texturesIds = new long[texturesWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < texturesWasmLength; i++) texturesIds[i] = (textures[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* texturesIdsPointer = texturesIds)
            {
                global::UnityEngine.Rect* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__UnityEngineRectArray(selfObjectId, texturesIdsPointer, texturesWasmLength, padding, maximumAtlasSize, &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Rect[] returnResult = new global::UnityEngine.Rect[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect[] internal_UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__UnityEngineRectArray(long selfObjectId, global::UnityEngine.Texture2D[] textures, int padding)
        {
            int texturesWasmLength = textures.Length;
            long[] texturesIds = new long[texturesWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < texturesWasmLength; i++) texturesIds[i] = (textures[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* texturesIdsPointer = texturesIds)
            {
                global::UnityEngine.Rect* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__UnityEngineRectArray(selfObjectId, texturesIdsPointer, texturesWasmLength, padding, &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Rect[] returnResult = new global::UnityEngine.Rect[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = returnResultIdsPointer![i];
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int x, int y, global::UnityEngine.Color color)
        {
            UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(selfObjectId, x, y, Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(long selfObjectId, int x, int y, global::UnityEngine.Color color, int mipLevel)
        {
            UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(selfObjectId, x, y, Unsafe.AsPointer(ref color), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemInt32__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color[] colors, int miplevel)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemInt32__SystemVoid(selfObjectId, x, y, blockWidth, blockHeight, colorsPointer, colors.Length, miplevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color[] colors)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemVoid(selfObjectId, x, y, blockWidth, blockHeight, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Color[] colors, int miplevel)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemInt32__SystemVoid(selfObjectId, colorsPointer, colors.Length, miplevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemVoid(long selfObjectId, global::UnityEngine.Color[] colors)
        {
            fixed (global::UnityEngine.Color* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemVoid(selfObjectId, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int x, int y)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__UnityEngineColor(selfObjectId, x, y, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int x, int y, int mipLevel)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(selfObjectId, x, y, mipLevel, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__UnityEngineColor(long selfObjectId, float u, float v)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__UnityEngineColor(selfObjectId, u, v, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__SystemInt32__UnityEngineColor(long selfObjectId, float u, float v, int mipLevel)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__SystemInt32__UnityEngineColor(selfObjectId, u, v, mipLevel, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__LoadRawTextureData__SystemByteArray__SystemVoid(long selfObjectId, global::System.Byte[] data)
        {
            fixed (byte* dataPointer = data)
            {
                UnityEngineTexture2D__func__LoadRawTextureData__SystemByteArray__SystemVoid(selfObjectId, dataPointer, data.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, bool updateMipmaps, bool makeNoLongerReadable)
        {
            var updateMipmapsConverted = Unsafe.As<bool, int>(ref updateMipmaps);
            var makeNoLongerReadableConverted = Unsafe.As<bool, int>(ref makeNoLongerReadable);
            UnityEngineTexture2D__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(selfObjectId, updateMipmapsConverted, makeNoLongerReadableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__Apply__SystemBoolean__SystemVoid(long selfObjectId, bool updateMipmaps)
        {
            var updateMipmapsConverted = Unsafe.As<bool, int>(ref updateMipmaps);
            UnityEngineTexture2D__func__Apply__SystemBoolean__SystemVoid(selfObjectId, updateMipmapsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__Apply__SystemVoid(long selfObjectId)
        {
            UnityEngineTexture2D__func__Apply__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__SystemBoolean(long selfObjectId, int width, int height)
        {
            var methodCallResult = UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__SystemBoolean(selfObjectId, width, height);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(long selfObjectId, int width, int height, global::UnityEngine.TextureFormat format, bool hasMipMap)
        {
            var hasMipMapConverted = Unsafe.As<bool, int>(ref hasMipMap);
            var methodCallResult = UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(selfObjectId, width, height, (int) format, hasMipMapConverted);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemBoolean__SystemBoolean(long selfObjectId, int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
        {
            var hasMipMapConverted = Unsafe.As<bool, int>(ref hasMipMap);
            var methodCallResult = UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemBoolean__SystemBoolean(selfObjectId, width, height, (int) format, hasMipMapConverted);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps)
        {
            var recalculateMipMapsConverted = Unsafe.As<bool, int>(ref recalculateMipMaps);
            UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), destX, destY, recalculateMipMapsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Rect source, int destX, int destY)
        {
            UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemVoid(selfObjectId, Unsafe.AsPointer(ref source), destX, destY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture2D__func__GenerateAtlas__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemCollectionsGeneric_List_UnityEngineRect__SystemBoolean(global::UnityEngine.Vector2[] sizes, int padding, int atlasSize, global::System.Collections.Generic.List<global::UnityEngine.Rect> resultsList)
        {
            Span<global::UnityEngine.Rect> results = CollectionsMarshal.AsSpan(resultsList);
            fixed (global::UnityEngine.Vector2* sizesPointer = sizes)
            {
                fixed (global::UnityEngine.Rect* resultsPointer = results)
                {
                    var methodCallResult = UnityEngineTexture2D__func__GenerateAtlas__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemCollectionsGeneric_List_UnityEngineRect__SystemBoolean(sizesPointer, sizes.Length, padding, atlasSize, resultsPointer, results.Length);
                    var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                    return returnResult;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemInt32__SystemVoid(long selfObjectId, global::UnityEngine.Color32[] colors, int miplevel)
        {
            fixed (global::UnityEngine.Color32* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemInt32__SystemVoid(selfObjectId, colorsPointer, colors.Length, miplevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(long selfObjectId, global::UnityEngine.Color32[] colors)
        {
            fixed (global::UnityEngine.Color32* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(selfObjectId, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemInt32__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color32[] colors, int miplevel)
        {
            fixed (global::UnityEngine.Color32* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemInt32__SystemVoid(selfObjectId, x, y, blockWidth, blockHeight, colorsPointer, colors.Length, miplevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, global::UnityEngine.Color32[] colors)
        {
            fixed (global::UnityEngine.Color32* colorsPointer = colors)
            {
                UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemVoid(selfObjectId, x, y, blockWidth, blockHeight, colorsPointer, colors.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineTexture2D__func__GetPixels__SystemInt32__UnityEngineColorArray(long selfObjectId, int miplevel)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels__SystemInt32__UnityEngineColorArray(selfObjectId, miplevel, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color[] internal_UnityEngineTexture2D__func__GetPixels__UnityEngineColorArray(long selfObjectId)
        {
            global::UnityEngine.Color* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineTexture2D__func__GetPixels__UnityEngineColorArray(selfObjectId, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Color[] returnResult = new global::UnityEngine.Color[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingDefaultFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, int formatUnderlyingValue, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, int formatUnderlyingValue, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__UnityEngineExperimentalRenderingTextureCreationFlagsEnum(int width, int height, int formatUnderlyingValue, int mipCount, int flagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemInt32__SystemBoolean(int width, int height, int textureFormatUnderlyingValue, int mipCount, int linearConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(int width, int height, int textureFormatUnderlyingValue, int mipChainConverted, int linearConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean(int width, int height, int textureFormatUnderlyingValue, int mipChainConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__ctor__SystemInt32__SystemInt32(int width, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__format(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__ignoreMipmapLimit(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__set__ignoreMipmapLimit(long selfObjectId, int ignoreMipmapLimitConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__whiteTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__blackTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__redTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__grayTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__linearGrayTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture2D__get__normalTexture();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__isReadable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__vtOnly(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__streamingMipmaps(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__streamingMipmapsPriority(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__requestedMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__set__requestedMipmapLevel(long selfObjectId, int requestedMipmapLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__minimumMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__set__minimumMipmapLevel(long selfObjectId, int minimumMipmapLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__calculatedMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__desiredMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__loadingMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__get__loadedMipmapLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__Compress__SystemBoolean__SystemVoid(long selfObjectId, int highQualityConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__ClearRequestedMipmapLevel__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__func__IsRequestedMipmapLevelLoaded__SystemBoolean(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__ClearMinimumMipmapLevel__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetRawTextureData__SystemByteArray(long selfObjectId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(long selfObjectId, int x, int y, int blockWidth, int blockHeight, int miplevel, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray(long selfObjectId, int x, int y, int blockWidth, int blockHeight, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels32__SystemInt32__UnityEngineColor32Array(long selfObjectId, int miplevel, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels32__UnityEngineColor32Array(long selfObjectId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__SystemBoolean__UnityEngineRectArray(long selfObjectId, void* texturesIdsPointer, int texturesWasmLength, int padding, int maximumAtlasSize, int makeNoLongerReadableConverted, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__SystemInt32__UnityEngineRectArray(long selfObjectId, void* texturesIdsPointer, int texturesWasmLength, int padding, int maximumAtlasSize, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__PackTextures__UnityEngineTexture2DArray__SystemInt32__UnityEngineRectArray(long selfObjectId, void* texturesIdsPointer, int texturesWasmLength, int padding, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemVoid(long selfObjectId, int x, int y, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixel__SystemInt32__SystemInt32__UnityEngineColor__SystemInt32__SystemVoid(long selfObjectId, int x, int y, void* colorPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemInt32__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, void* colorsPointer, int colorsWasmLength, int miplevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColorArray__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemInt32__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, int miplevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels__UnityEngineColorArray__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int x, int y, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixel__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor(long selfObjectId, int x, int y, int mipLevel, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__UnityEngineColor(long selfObjectId, float u, float v, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixelBilinear__SystemSingle__SystemSingle__SystemInt32__UnityEngineColor(long selfObjectId, float u, float v, int mipLevel, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__LoadRawTextureData__SystemByteArray__SystemVoid(long selfObjectId, void* dataPointer, int dataWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__Apply__SystemBoolean__SystemBoolean__SystemVoid(long selfObjectId, int updateMipmapsConverted, int makeNoLongerReadableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__Apply__SystemBoolean__SystemVoid(long selfObjectId, int updateMipmapsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture2D__func__Apply__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__SystemBoolean(long selfObjectId, int width, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineTextureFormatEnum__SystemBoolean__SystemBoolean(long selfObjectId, int width, int height, int formatUnderlyingValue, int hasMipMapConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture2D__func__Reinitialize__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemBoolean__SystemBoolean(long selfObjectId, int width, int height, int formatUnderlyingValue, int hasMipMapConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, void* sourcePointer, int destX, int destY, int recalculateMipMapsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__ReadPixels__UnityEngineRect__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, void* sourcePointer, int destX, int destY);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineTexture2D__func__GenerateAtlas__UnityEngineVector2Array__SystemInt32__SystemInt32__SystemCollectionsGeneric_List_UnityEngineRect__SystemBoolean(void* sizesPointer, int sizesWasmLength, int padding, int atlasSize, void* resultsPointer, int resultsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemInt32__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength, int miplevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemInt32__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, void* colorsPointer, int colorsWasmLength, int miplevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__SetPixels32__SystemInt32__SystemInt32__SystemInt32__SystemInt32__UnityEngineColor32Array__SystemVoid(long selfObjectId, int x, int y, int blockWidth, int blockHeight, void* colorsPointer, int colorsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels__SystemInt32__UnityEngineColorArray(long selfObjectId, int miplevel, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture2D__func__GetPixels__UnityEngineColorArray(long selfObjectId, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        #endregion Imports
    }
}
