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

    public partial struct RenderTargetSetup(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public RenderTargetSetup(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mip, global::UnityEngine.CubemapFace face, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStore, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoad, global::UnityEngine.Rendering.RenderBufferStoreAction depthStore)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(color, depth, mip, face, colorLoad, colorStore, depthLoad, depthStore)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer(color, depth)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32(color, depth, mipLevel)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel, global::UnityEngine.CubemapFace face)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(color, depth, mipLevel, face)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(color, depth, mipLevel, face, depthSlice)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer(color, depth)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mipLevel)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32(color, depth, mipLevel)) { }

        public RenderTargetSetup(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mip, global::UnityEngine.CubemapFace face)
            : this(internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(color, depth, mip, face)) { }

        public global::UnityEngine.RenderBuffer[] color
        {
            get => internal_UnityEngineRenderTargetSetup__get__color(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__color(WrappedId, value);
        }

        public global::UnityEngine.RenderBuffer depth
        {
            get => internal_UnityEngineRenderTargetSetup__get__depth(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__depth(WrappedId, value);
        }

        public int mipLevel
        {
            get => internal_UnityEngineRenderTargetSetup__get__mipLevel(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__mipLevel(WrappedId, value);
        }

        public global::UnityEngine.CubemapFace cubemapFace
        {
            get => internal_UnityEngineRenderTargetSetup__get__cubemapFace(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__cubemapFace(WrappedId, value);
        }

        public int depthSlice
        {
            get => internal_UnityEngineRenderTargetSetup__get__depthSlice(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__depthSlice(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad
        {
            get => internal_UnityEngineRenderTargetSetup__get__colorLoad(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__colorLoad(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStore
        {
            get => internal_UnityEngineRenderTargetSetup__get__colorStore(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__colorStore(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferLoadAction depthLoad
        {
            get => internal_UnityEngineRenderTargetSetup__get__depthLoad(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__depthLoad(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferStoreAction depthStore
        {
            get => internal_UnityEngineRenderTargetSetup__get__depthStore(WrappedId);
            set => internal_UnityEngineRenderTargetSetup__set__depthStore(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mip, global::UnityEngine.CubemapFace face, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStore, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoad, global::UnityEngine.Rendering.RenderBufferStoreAction depthStore)
        {
            fixed (global::UnityEngine.RenderBuffer* colorPointer = color)
            {
                fixed (global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadPointer = colorLoad)
                {
                    fixed (global::UnityEngine.Rendering.RenderBufferStoreAction* colorStorePointer = colorStore)
                    {
                        return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(colorPointer, color.Length, Unsafe.AsPointer(ref depth), mip, (int) face, colorLoadPointer, colorLoad.Length, colorStorePointer, colorStore.Length, (int) depthLoad, (int) depthStore);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth)
        {
            return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer(Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel)
        {
            return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32(Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel, global::UnityEngine.CubemapFace face)
        {
            return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel, (int) face);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(global::UnityEngine.RenderBuffer color, global::UnityEngine.RenderBuffer depth, int mipLevel, global::UnityEngine.CubemapFace face, int depthSlice)
        {
            return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(Unsafe.AsPointer(ref color), Unsafe.AsPointer(ref depth), mipLevel, (int) face, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth)
        {
            fixed (global::UnityEngine.RenderBuffer* colorPointer = color)
            {
                return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer(colorPointer, color.Length, Unsafe.AsPointer(ref depth));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mipLevel)
        {
            fixed (global::UnityEngine.RenderBuffer* colorPointer = color)
            {
                return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32(colorPointer, color.Length, Unsafe.AsPointer(ref depth), mipLevel);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(global::UnityEngine.RenderBuffer[] color, global::UnityEngine.RenderBuffer depth, int mip, global::UnityEngine.CubemapFace face)
        {
            fixed (global::UnityEngine.RenderBuffer* colorPointer = color)
            {
                return UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(colorPointer, color.Length, Unsafe.AsPointer(ref depth), mip, (int) face);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer[] internal_UnityEngineRenderTargetSetup__get__color(long selfObjectId)
        {
            global::UnityEngine.RenderBuffer* colorIdsPointer = default;
            int colorWasmLength = default;
            UnityEngineRenderTargetSetup__get__color(selfObjectId, &colorIdsPointer, &colorWasmLength);
            global::UnityEngine.RenderBuffer[] returnResult = new global::UnityEngine.RenderBuffer[colorWasmLength];
            for (int i = 0; i < colorWasmLength; i++)
            {
                returnResult[i] = colorIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__color(long selfObjectId, global::UnityEngine.RenderBuffer[] color)
        {
            fixed (global::UnityEngine.RenderBuffer* colorPointer = color)
            {
                UnityEngineRenderTargetSetup__set__color(selfObjectId, colorPointer, color.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderBuffer internal_UnityEngineRenderTargetSetup__get__depth(long selfObjectId)
        {
            global::UnityEngine.RenderBuffer depthValue = default;
            UnityEngineRenderTargetSetup__get__depth(selfObjectId, Unsafe.AsPointer(ref depthValue));
            global::UnityEngine.RenderBuffer returnResult = depthValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__depth(long selfObjectId, global::UnityEngine.RenderBuffer depth)
        {
            UnityEngineRenderTargetSetup__set__depth(selfObjectId, Unsafe.AsPointer(ref depth));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTargetSetup__get__mipLevel(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTargetSetup__get__mipLevel(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__mipLevel(long selfObjectId, int mipLevel)
        {
            UnityEngineRenderTargetSetup__set__mipLevel(selfObjectId, mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.CubemapFace internal_UnityEngineRenderTargetSetup__get__cubemapFace(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTargetSetup__get__cubemapFace(selfObjectId);
            var returnResult = (global::UnityEngine.CubemapFace)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__cubemapFace(long selfObjectId, global::UnityEngine.CubemapFace cubemapFace)
        {
            UnityEngineRenderTargetSetup__set__cubemapFace(selfObjectId, (int) cubemapFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineRenderTargetSetup__get__depthSlice(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTargetSetup__get__depthSlice(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__depthSlice(long selfObjectId, int depthSlice)
        {
            UnityEngineRenderTargetSetup__set__depthSlice(selfObjectId, depthSlice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferLoadAction[] internal_UnityEngineRenderTargetSetup__get__colorLoad(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadIdsPointer = default;
            int colorLoadWasmLength = default;
            UnityEngineRenderTargetSetup__get__colorLoad(selfObjectId, &colorLoadIdsPointer, &colorLoadWasmLength);
            global::UnityEngine.Rendering.RenderBufferLoadAction[] returnResult = new global::UnityEngine.Rendering.RenderBufferLoadAction[colorLoadWasmLength];
            for (int i = 0; i < colorLoadWasmLength; i++)
            {
                returnResult[i] = colorLoadIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorLoadIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__colorLoad(long selfObjectId, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad)
        {
            fixed (global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadPointer = colorLoad)
            {
                UnityEngineRenderTargetSetup__set__colorLoad(selfObjectId, colorLoadPointer, colorLoad.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferStoreAction[] internal_UnityEngineRenderTargetSetup__get__colorStore(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderBufferStoreAction* colorStoreIdsPointer = default;
            int colorStoreWasmLength = default;
            UnityEngineRenderTargetSetup__get__colorStore(selfObjectId, &colorStoreIdsPointer, &colorStoreWasmLength);
            global::UnityEngine.Rendering.RenderBufferStoreAction[] returnResult = new global::UnityEngine.Rendering.RenderBufferStoreAction[colorStoreWasmLength];
            for (int i = 0; i < colorStoreWasmLength; i++)
            {
                returnResult[i] = colorStoreIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorStoreIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__colorStore(long selfObjectId, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStore)
        {
            fixed (global::UnityEngine.Rendering.RenderBufferStoreAction* colorStorePointer = colorStore)
            {
                UnityEngineRenderTargetSetup__set__colorStore(selfObjectId, colorStorePointer, colorStore.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferLoadAction internal_UnityEngineRenderTargetSetup__get__depthLoad(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTargetSetup__get__depthLoad(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.RenderBufferLoadAction)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__depthLoad(long selfObjectId, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoad)
        {
            UnityEngineRenderTargetSetup__set__depthLoad(selfObjectId, (int) depthLoad);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferStoreAction internal_UnityEngineRenderTargetSetup__get__depthStore(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderTargetSetup__get__depthStore(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.RenderBufferStoreAction)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderTargetSetup__set__depthStore(long selfObjectId, global::UnityEngine.Rendering.RenderBufferStoreAction depthStore)
        {
            UnityEngineRenderTargetSetup__set__depthStore(selfObjectId, (int) depthStore);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(void* colorPointer, int colorWasmLength, void* depthPointer, int mip, int faceUnderlyingValue, void* colorLoadPointer, int colorLoadWasmLength, void* colorStorePointer, int colorStoreWasmLength, int depthLoadUnderlyingValue, int depthStoreUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer(void* colorPointer, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32(void* colorPointer, void* depthPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(void* colorPointer, void* depthPointer, int mipLevel, int faceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum__SystemInt32(void* colorPointer, void* depthPointer, int mipLevel, int faceUnderlyingValue, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer(void* colorPointer, int colorWasmLength, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32(void* colorPointer, int colorWasmLength, void* depthPointer, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderTargetSetup__ctor__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemInt32__UnityEngineCubemapFaceEnum(void* colorPointer, int colorWasmLength, void* depthPointer, int mip, int faceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__get__color(long selfObjectId, void* colorIdsPointer, void* colorWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__set__color(long selfObjectId, void* colorPointer, int colorWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__get__depth(long selfObjectId, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__set__depth(long selfObjectId, void* depthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTargetSetup__get__mipLevel(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTargetSetup__set__mipLevel(long selfObjectId, int mipLevel);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTargetSetup__get__cubemapFace(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTargetSetup__set__cubemapFace(long selfObjectId, int cubemapFaceUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTargetSetup__get__depthSlice(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTargetSetup__set__depthSlice(long selfObjectId, int depthSlice);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__get__colorLoad(long selfObjectId, void* colorLoadIdsPointer, void* colorLoadWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__set__colorLoad(long selfObjectId, void* colorLoadPointer, int colorLoadWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__get__colorStore(long selfObjectId, void* colorStoreIdsPointer, void* colorStoreWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderTargetSetup__set__colorStore(long selfObjectId, void* colorStorePointer, int colorStoreWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTargetSetup__get__depthLoad(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTargetSetup__set__depthLoad(long selfObjectId, int depthLoadUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderTargetSetup__get__depthStore(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderTargetSetup__set__depthStore(long selfObjectId, int depthStoreUnderlyingValue);

        #endregion Imports
    }
}
