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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct RenderTextureDescriptor
    {

        #region Implementation

        public RenderTextureDescriptor(int width, int height)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32(ref this, width, height);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.RenderTextureFormat colorFormat)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(ref this, width, height, colorFormat);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(ref this, width, height, colorFormat, depthBufferBits);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(ref this, width, height, colorFormat, depthBufferBits);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32__SystemInt32(ref this, width, height, colorFormat, depthBufferBits, mipCount);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemInt32(ref this, width, height, colorFormat, depthBufferBits, mipCount);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(ref this, width, height, colorFormat, depthStencilFormat);
        }

        public RenderTextureDescriptor(int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
        {
            internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(ref this, width, height, colorFormat, depthStencilFormat, mipCount);
        }

        // [FieldOffset(0)] (the backing field offset)
        public int width { get; set; }

        // [FieldOffset(4)] (the backing field offset)
        public int height { get; set; }

        // [FieldOffset(8)] (the backing field offset)
        public int msaaSamples { get; set; }

        // [FieldOffset(12)] (the backing field offset)
        public int volumeDepth { get; set; }

        // [FieldOffset(16)] (the backing field offset)
        public int mipCount { get; set; }

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;

        // [FieldOffset(24)] (the backing field offset)
        public global::UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat { get; set; }

        // [FieldOffset(28)] (the backing field offset)
        public global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat { get; set; }

        // [FieldOffset(32)] (the backing field offset)
        public global::UnityEngine.Rendering.TextureDimension dimension { get; set; }

        // [FieldOffset(36)] (the backing field offset)
        public global::UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode { get; set; }

        // [FieldOffset(40)] (the backing field offset)
        public global::UnityEngine.VRTextureUsage vrUsage { get; set; }

        // [FieldOffset(44)] (implicit field offset from sequential layout kind)
        private global::UnityEngine.RenderTextureCreationFlags _flags;

        // [FieldOffset(48)] (the backing field offset)
        public global::UnityEngine.RenderTextureMemoryless memoryless { get; set; }

        public global::UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__graphicsFormat(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__graphicsFormat(ref this, value);
        }

        public global::UnityEngine.RenderTextureFormat colorFormat 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__colorFormat(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__colorFormat(ref this, value);
        }

        public bool sRGB 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__sRGB(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__sRGB(ref this, value);
        }

        public int depthBufferBits 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__depthBufferBits(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__depthBufferBits(ref this, value);
        }

        public global::UnityEngine.RenderTextureCreationFlags flags 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__flags(ref this);
        }

        public bool useMipMap 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__useMipMap(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__useMipMap(ref this, value);
        }

        public bool autoGenerateMips 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__autoGenerateMips(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__autoGenerateMips(ref this, value);
        }

        public bool enableRandomWrite 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__enableRandomWrite(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__enableRandomWrite(ref this, value);
        }

        public bool bindMS 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__bindMS(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__bindMS(ref this, value);
        }

        public bool useDynamicScale 
        {
            get => internal_UnityEngineRenderTextureDescriptor__get__useDynamicScale(ref this);
            set => internal_UnityEngineRenderTextureDescriptor__set__useDynamicScale(ref this, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32(selfStructPointer, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.RenderTextureFormat colorFormat)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(selfStructPointer, width, height, (int) colorFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(selfStructPointer, width, height, (int) colorFormat, depthBufferBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(selfStructPointer, width, height, (int) colorFormat, depthBufferBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32__SystemInt32(selfStructPointer, width, height, (int) colorFormat, depthBufferBits, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemInt32(selfStructPointer, width, height, (int) colorFormat, depthBufferBits, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(selfStructPointer, width, height, (int) colorFormat, (int) depthStencilFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int width, int height, global::UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, global::UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(selfStructPointer, width, height, (int) colorFormat, (int) depthStencilFormat, mipCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Experimental.Rendering.GraphicsFormat internal_UnityEngineRenderTextureDescriptor__get__graphicsFormat(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__graphicsFormat(selfStructPointer);
            var returnResult = (global::UnityEngine.Experimental.Rendering.GraphicsFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__graphicsFormat(ref global::UnityEngine.RenderTextureDescriptor selfStruct, global::UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__set__graphicsFormat(selfStructPointer, (int) graphicsFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTextureFormat internal_UnityEngineRenderTextureDescriptor__get__colorFormat(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__colorFormat(selfStructPointer);
            var returnResult = (global::UnityEngine.RenderTextureFormat)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__colorFormat(ref global::UnityEngine.RenderTextureDescriptor selfStruct, global::UnityEngine.RenderTextureFormat colorFormat)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__set__colorFormat(selfStructPointer, (int) colorFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__sRGB(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__sRGB(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__sRGB(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool sRGB)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var sRGBConverted = Unsafe.As<bool, int>(ref sRGB);
            UnityEngineRenderTextureDescriptor__set__sRGB(selfStructPointer, sRGBConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTextureDescriptor__get__depthBufferBits(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__depthBufferBits(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__depthBufferBits(ref global::UnityEngine.RenderTextureDescriptor selfStruct, int depthBufferBits)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEngineRenderTextureDescriptor__set__depthBufferBits(selfStructPointer, depthBufferBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTextureCreationFlags internal_UnityEngineRenderTextureDescriptor__get__flags(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__flags(selfStructPointer);
            var returnResult = (global::UnityEngine.RenderTextureCreationFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__useMipMap(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__useMipMap(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__useMipMap(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool useMipMap)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var useMipMapConverted = Unsafe.As<bool, int>(ref useMipMap);
            UnityEngineRenderTextureDescriptor__set__useMipMap(selfStructPointer, useMipMapConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__autoGenerateMips(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__autoGenerateMips(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__autoGenerateMips(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool autoGenerateMips)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var autoGenerateMipsConverted = Unsafe.As<bool, int>(ref autoGenerateMips);
            UnityEngineRenderTextureDescriptor__set__autoGenerateMips(selfStructPointer, autoGenerateMipsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__enableRandomWrite(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__enableRandomWrite(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__enableRandomWrite(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool enableRandomWrite)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var enableRandomWriteConverted = Unsafe.As<bool, int>(ref enableRandomWrite);
            UnityEngineRenderTextureDescriptor__set__enableRandomWrite(selfStructPointer, enableRandomWriteConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__bindMS(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__bindMS(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__bindMS(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool bindMS)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var bindMSConverted = Unsafe.As<bool, int>(ref bindMS);
            UnityEngineRenderTextureDescriptor__set__bindMS(selfStructPointer, bindMSConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineRenderTextureDescriptor__get__useDynamicScale(ref global::UnityEngine.RenderTextureDescriptor selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEngineRenderTextureDescriptor__get__useDynamicScale(selfStructPointer);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTextureDescriptor__set__useDynamicScale(ref global::UnityEngine.RenderTextureDescriptor selfStruct, bool useDynamicScale)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var useDynamicScaleConverted = Unsafe.As<bool, int>(ref useDynamicScale);
            UnityEngineRenderTextureDescriptor__set__useDynamicScale(selfStructPointer, useDynamicScaleConverted);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32(void* selfStructPointer, int width, int height);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthBufferBits);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthBufferBits);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineRenderTextureFormatEnum__SystemInt32__SystemInt32(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthBufferBits, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32__SystemInt32(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthBufferBits, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthStencilFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__ctor__SystemInt32__SystemInt32__UnityEngineExperimentalRenderingGraphicsFormatEnum__UnityEngineExperimentalRenderingGraphicsFormatEnum__SystemInt32(void* selfStructPointer, int width, int height, int colorFormatUnderlyingValue, int depthStencilFormatUnderlyingValue, int mipCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__graphicsFormat(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__graphicsFormat(void* selfStructPointer, int graphicsFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__colorFormat(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__colorFormat(void* selfStructPointer, int colorFormatUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__sRGB(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__sRGB(void* selfStructPointer, int sRGBConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__depthBufferBits(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__depthBufferBits(void* selfStructPointer, int depthBufferBits);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__flags(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__useMipMap(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__useMipMap(void* selfStructPointer, int useMipMapConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__autoGenerateMips(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__autoGenerateMips(void* selfStructPointer, int autoGenerateMipsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__enableRandomWrite(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__enableRandomWrite(void* selfStructPointer, int enableRandomWriteConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__bindMS(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__bindMS(void* selfStructPointer, int bindMSConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineRenderTextureDescriptor__get__useDynamicScale(void* selfStructPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTextureDescriptor__set__useDynamicScale(void* selfStructPointer, int useDynamicScaleConverted);

        #endregion Imports
    }
}
