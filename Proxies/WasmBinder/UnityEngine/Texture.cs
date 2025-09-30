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

    public partial class Texture(long id) : Object(id)
    {

        #region Implementation

        public int mipmapCount 
        {
            get => internal_UnityEngineTexture__get__mipmapCount(WrappedId);
        }

        public static global::UnityEngine.AnisotropicFiltering anisotropicFiltering 
        {
            get => internal_UnityEngineTexture__get__anisotropicFiltering();
            set => internal_UnityEngineTexture__set__anisotropicFiltering(value);
        }

        public global::UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat 
        {
            get => internal_UnityEngineTexture__get__graphicsFormat(WrappedId);
        }

        public int width 
        {
            get => internal_UnityEngineTexture__get__width(WrappedId);
            set => internal_UnityEngineTexture__set__width(WrappedId, value);
        }

        public int height 
        {
            get => internal_UnityEngineTexture__get__height(WrappedId);
            set => internal_UnityEngineTexture__set__height(WrappedId, value);
        }

        public global::UnityEngine.Rendering.TextureDimension dimension 
        {
            get => internal_UnityEngineTexture__get__dimension(WrappedId);
            set => internal_UnityEngineTexture__set__dimension(WrappedId, value);
        }

        public bool isReadable 
        {
            get => internal_UnityEngineTexture__get__isReadable(WrappedId);
        }

        public global::UnityEngine.TextureWrapMode wrapMode 
        {
            get => internal_UnityEngineTexture__get__wrapMode(WrappedId);
            set => internal_UnityEngineTexture__set__wrapMode(WrappedId, value);
        }

        public global::UnityEngine.TextureWrapMode wrapModeU 
        {
            get => internal_UnityEngineTexture__get__wrapModeU(WrappedId);
            set => internal_UnityEngineTexture__set__wrapModeU(WrappedId, value);
        }

        public global::UnityEngine.TextureWrapMode wrapModeV 
        {
            get => internal_UnityEngineTexture__get__wrapModeV(WrappedId);
            set => internal_UnityEngineTexture__set__wrapModeV(WrappedId, value);
        }

        public global::UnityEngine.TextureWrapMode wrapModeW 
        {
            get => internal_UnityEngineTexture__get__wrapModeW(WrappedId);
            set => internal_UnityEngineTexture__set__wrapModeW(WrappedId, value);
        }

        public global::UnityEngine.FilterMode filterMode 
        {
            get => internal_UnityEngineTexture__get__filterMode(WrappedId);
            set => internal_UnityEngineTexture__set__filterMode(WrappedId, value);
        }

        public int anisoLevel 
        {
            get => internal_UnityEngineTexture__get__anisoLevel(WrappedId);
            set => internal_UnityEngineTexture__set__anisoLevel(WrappedId, value);
        }

        public float mipMapBias 
        {
            get => internal_UnityEngineTexture__get__mipMapBias(WrappedId);
            set => internal_UnityEngineTexture__set__mipMapBias(WrappedId, value);
        }

        public global::UnityEngine.Vector2 texelSize 
        {
            get => internal_UnityEngineTexture__get__texelSize(WrappedId);
        }

        public uint updateCount 
        {
            get => internal_UnityEngineTexture__get__updateCount(WrappedId);
        }

        public bool isDataSRGB 
        {
            get => internal_UnityEngineTexture__get__isDataSRGB(WrappedId);
        }

        public static ulong totalTextureMemory 
        {
            get => internal_UnityEngineTexture__get__totalTextureMemory();
        }

        public static ulong desiredTextureMemory 
        {
            get => internal_UnityEngineTexture__get__desiredTextureMemory();
        }

        public static ulong targetTextureMemory 
        {
            get => internal_UnityEngineTexture__get__targetTextureMemory();
        }

        public static ulong currentTextureMemory 
        {
            get => internal_UnityEngineTexture__get__currentTextureMemory();
        }

        public static ulong nonStreamingTextureMemory 
        {
            get => internal_UnityEngineTexture__get__nonStreamingTextureMemory();
        }

        public static ulong streamingMipmapUploadCount 
        {
            get => internal_UnityEngineTexture__get__streamingMipmapUploadCount();
        }

        public static ulong streamingRendererCount 
        {
            get => internal_UnityEngineTexture__get__streamingRendererCount();
        }

        public static ulong streamingTextureCount 
        {
            get => internal_UnityEngineTexture__get__streamingTextureCount();
        }

        public static ulong nonStreamingTextureCount 
        {
            get => internal_UnityEngineTexture__get__nonStreamingTextureCount();
        }

        public static ulong streamingTexturePendingLoadCount 
        {
            get => internal_UnityEngineTexture__get__streamingTexturePendingLoadCount();
        }

        public static ulong streamingTextureLoadingCount 
        {
            get => internal_UnityEngineTexture__get__streamingTextureLoadingCount();
        }

        public static bool streamingTextureForceLoadAll 
        {
            get => internal_UnityEngineTexture__get__streamingTextureForceLoadAll();
            set => internal_UnityEngineTexture__set__streamingTextureForceLoadAll(value);
        }

        public static bool streamingTextureDiscardUnusedMips 
        {
            get => internal_UnityEngineTexture__get__streamingTextureDiscardUnusedMips();
            set => internal_UnityEngineTexture__set__streamingTextureDiscardUnusedMips(value);
        }

        public static bool allowThreadedTextureCreation 
        {
            get => internal_UnityEngineTexture__get__allowThreadedTextureCreation();
            set => internal_UnityEngineTexture__set__allowThreadedTextureCreation(value);
        }

        public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
        {
            internal_UnityEngineTexture__func__SetGlobalAnisotropicFilteringLimits__SystemInt32__SystemInt32__SystemVoid(forcedMin, globalMax);
        }

        public void IncrementUpdateCount()
        {
            internal_UnityEngineTexture__func__IncrementUpdateCount__SystemVoid(WrappedId);
        }

        public static void SetStreamingTextureMaterialDebugProperties()
        {
            internal_UnityEngineTexture__func__SetStreamingTextureMaterialDebugProperties__SystemVoid();
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture__get__mipmapCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__mipmapCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnisotropicFiltering internal_UnityEngineTexture__get__anisotropicFiltering()
        {
            var methodCallResult = UnityEngineTexture__get__anisotropicFiltering();
            var returnResult = (global::UnityEngine.AnisotropicFiltering)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__anisotropicFiltering(global::UnityEngine.AnisotropicFiltering anisotropicFiltering)
        {
            UnityEngineTexture__set__anisotropicFiltering((int) anisotropicFiltering);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.GraphicsFormat internal_UnityEngineTexture__get__graphicsFormat(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__graphicsFormat(selfObjectId);
            var returnResult = (global::UnityEngine.Experimental.Rendering.GraphicsFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture__get__width(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__width(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__width(long selfObjectId, int width)
        {
            UnityEngineTexture__set__width(selfObjectId, width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture__get__height(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__height(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__height(long selfObjectId, int height)
        {
            UnityEngineTexture__set__height(selfObjectId, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.TextureDimension internal_UnityEngineTexture__get__dimension(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__dimension(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.TextureDimension)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__dimension(long selfObjectId, global::UnityEngine.Rendering.TextureDimension dimension)
        {
            UnityEngineTexture__set__dimension(selfObjectId, (int) dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture__get__isReadable(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__isReadable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureWrapMode internal_UnityEngineTexture__get__wrapMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__wrapMode(selfObjectId);
            var returnResult = (global::UnityEngine.TextureWrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__wrapMode(long selfObjectId, global::UnityEngine.TextureWrapMode wrapMode)
        {
            UnityEngineTexture__set__wrapMode(selfObjectId, (int) wrapMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureWrapMode internal_UnityEngineTexture__get__wrapModeU(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__wrapModeU(selfObjectId);
            var returnResult = (global::UnityEngine.TextureWrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__wrapModeU(long selfObjectId, global::UnityEngine.TextureWrapMode wrapModeU)
        {
            UnityEngineTexture__set__wrapModeU(selfObjectId, (int) wrapModeU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureWrapMode internal_UnityEngineTexture__get__wrapModeV(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__wrapModeV(selfObjectId);
            var returnResult = (global::UnityEngine.TextureWrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__wrapModeV(long selfObjectId, global::UnityEngine.TextureWrapMode wrapModeV)
        {
            UnityEngineTexture__set__wrapModeV(selfObjectId, (int) wrapModeV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TextureWrapMode internal_UnityEngineTexture__get__wrapModeW(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__wrapModeW(selfObjectId);
            var returnResult = (global::UnityEngine.TextureWrapMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__wrapModeW(long selfObjectId, global::UnityEngine.TextureWrapMode wrapModeW)
        {
            UnityEngineTexture__set__wrapModeW(selfObjectId, (int) wrapModeW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.FilterMode internal_UnityEngineTexture__get__filterMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__filterMode(selfObjectId);
            var returnResult = (global::UnityEngine.FilterMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__filterMode(long selfObjectId, global::UnityEngine.FilterMode filterMode)
        {
            UnityEngineTexture__set__filterMode(selfObjectId, (int) filterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTexture__get__anisoLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__anisoLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__anisoLevel(long selfObjectId, int anisoLevel)
        {
            UnityEngineTexture__set__anisoLevel(selfObjectId, anisoLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTexture__get__mipMapBias(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__mipMapBias(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__mipMapBias(long selfObjectId, float mipMapBias)
        {
            UnityEngineTexture__set__mipMapBias(selfObjectId, mipMapBias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineTexture__get__texelSize(long selfObjectId)
        {
            global::UnityEngine.Vector2 texelSizeValue = default;
            UnityEngineTexture__get__texelSize(selfObjectId, Unsafe.AsPointer(ref texelSizeValue));
            global::UnityEngine.Vector2 returnResult = texelSizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint internal_UnityEngineTexture__get__updateCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__updateCount(selfObjectId);
            var returnResult = Unsafe.As<int, uint>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture__get__isDataSRGB(long selfObjectId)
        {
            var methodCallResult = UnityEngineTexture__get__isDataSRGB(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__totalTextureMemory()
        {
            var methodCallResult = UnityEngineTexture__get__totalTextureMemory();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__desiredTextureMemory()
        {
            var methodCallResult = UnityEngineTexture__get__desiredTextureMemory();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__targetTextureMemory()
        {
            var methodCallResult = UnityEngineTexture__get__targetTextureMemory();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__currentTextureMemory()
        {
            var methodCallResult = UnityEngineTexture__get__currentTextureMemory();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__nonStreamingTextureMemory()
        {
            var methodCallResult = UnityEngineTexture__get__nonStreamingTextureMemory();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__streamingMipmapUploadCount()
        {
            var methodCallResult = UnityEngineTexture__get__streamingMipmapUploadCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__streamingRendererCount()
        {
            var methodCallResult = UnityEngineTexture__get__streamingRendererCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__streamingTextureCount()
        {
            var methodCallResult = UnityEngineTexture__get__streamingTextureCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__nonStreamingTextureCount()
        {
            var methodCallResult = UnityEngineTexture__get__nonStreamingTextureCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__streamingTexturePendingLoadCount()
        {
            var methodCallResult = UnityEngineTexture__get__streamingTexturePendingLoadCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineTexture__get__streamingTextureLoadingCount()
        {
            var methodCallResult = UnityEngineTexture__get__streamingTextureLoadingCount();
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture__get__streamingTextureForceLoadAll()
        {
            var methodCallResult = UnityEngineTexture__get__streamingTextureForceLoadAll();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__streamingTextureForceLoadAll(bool streamingTextureForceLoadAll)
        {
            var streamingTextureForceLoadAllConverted = Unsafe.As<bool, int>(ref streamingTextureForceLoadAll);
            UnityEngineTexture__set__streamingTextureForceLoadAll(streamingTextureForceLoadAllConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture__get__streamingTextureDiscardUnusedMips()
        {
            var methodCallResult = UnityEngineTexture__get__streamingTextureDiscardUnusedMips();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__streamingTextureDiscardUnusedMips(bool streamingTextureDiscardUnusedMips)
        {
            var streamingTextureDiscardUnusedMipsConverted = Unsafe.As<bool, int>(ref streamingTextureDiscardUnusedMips);
            UnityEngineTexture__set__streamingTextureDiscardUnusedMips(streamingTextureDiscardUnusedMipsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTexture__get__allowThreadedTextureCreation()
        {
            var methodCallResult = UnityEngineTexture__get__allowThreadedTextureCreation();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__set__allowThreadedTextureCreation(bool allowThreadedTextureCreation)
        {
            var allowThreadedTextureCreationConverted = Unsafe.As<bool, int>(ref allowThreadedTextureCreation);
            UnityEngineTexture__set__allowThreadedTextureCreation(allowThreadedTextureCreationConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__func__SetGlobalAnisotropicFilteringLimits__SystemInt32__SystemInt32__SystemVoid(int forcedMin, int globalMax)
        {
            UnityEngineTexture__func__SetGlobalAnisotropicFilteringLimits__SystemInt32__SystemInt32__SystemVoid(forcedMin, globalMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__func__IncrementUpdateCount__SystemVoid(long selfObjectId)
        {
            UnityEngineTexture__func__IncrementUpdateCount__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTexture__func__SetStreamingTextureMaterialDebugProperties__SystemVoid()
        {
            UnityEngineTexture__func__SetStreamingTextureMaterialDebugProperties__SystemVoid();
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__mipmapCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__anisotropicFiltering();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__anisotropicFiltering(int anisotropicFilteringUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__graphicsFormat(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__width(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__width(long selfObjectId, int width);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__height(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__height(long selfObjectId, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__dimension(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__dimension(long selfObjectId, int dimensionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__isReadable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__wrapMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__wrapMode(long selfObjectId, int wrapModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__wrapModeU(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__wrapModeU(long selfObjectId, int wrapModeUUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__wrapModeV(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__wrapModeV(long selfObjectId, int wrapModeVUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__wrapModeW(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__wrapModeW(long selfObjectId, int wrapModeWUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__filterMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__filterMode(long selfObjectId, int filterModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__anisoLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__anisoLevel(long selfObjectId, int anisoLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTexture__get__mipMapBias(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__mipMapBias(long selfObjectId, float mipMapBias);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTexture__get__texelSize(long selfObjectId, void* texelSizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__updateCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__isDataSRGB(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__totalTextureMemory();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__desiredTextureMemory();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__targetTextureMemory();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__currentTextureMemory();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__nonStreamingTextureMemory();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__streamingMipmapUploadCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__streamingRendererCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__streamingTextureCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__nonStreamingTextureCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__streamingTexturePendingLoadCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTexture__get__streamingTextureLoadingCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__streamingTextureForceLoadAll();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__streamingTextureForceLoadAll(int streamingTextureForceLoadAllConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__streamingTextureDiscardUnusedMips();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__streamingTextureDiscardUnusedMips(int streamingTextureDiscardUnusedMipsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTexture__get__allowThreadedTextureCreation();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__set__allowThreadedTextureCreation(int allowThreadedTextureCreationConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__func__SetGlobalAnisotropicFilteringLimits__SystemInt32__SystemInt32__SystemVoid(int forcedMin, int globalMax);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__func__IncrementUpdateCount__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTexture__func__SetStreamingTextureMaterialDebugProperties__SystemVoid();

        #endregion Imports
    }
}
