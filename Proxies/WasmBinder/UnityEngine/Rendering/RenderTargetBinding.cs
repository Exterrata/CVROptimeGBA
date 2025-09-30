//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    public partial struct RenderTargetBinding(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public RenderTargetBinding(global::UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
            : this(internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(colorRenderTargets, colorLoadActions, colorStoreActions, depthRenderTarget, depthLoadAction, depthStoreAction)) { }

        public RenderTargetBinding(global::UnityEngine.Rendering.RenderTargetIdentifier colorRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
            : this(internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(colorRenderTarget, colorLoadAction, colorStoreAction, depthRenderTarget, depthLoadAction, depthStoreAction)) { }

        public RenderTargetBinding(global::UnityEngine.RenderTargetSetup setup)
            : this(internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderTargetSetup(setup)) { }

        public global::UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__colorRenderTargets(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__colorRenderTargets(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__depthRenderTarget(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__depthRenderTarget(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__colorLoadActions(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__colorLoadActions(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__colorStoreActions(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__colorStoreActions(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__depthLoadAction(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__depthLoadAction(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__depthStoreAction(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__depthStoreAction(WrappedId, value);
        }

        public global::UnityEngine.Rendering.RenderTargetFlags flags 
        {
            get => internal_UnityEngineRenderingRenderTargetBinding__get__flags(WrappedId);
            set => internal_UnityEngineRenderingRenderTargetBinding__set__flags(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(global::UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            fixed (global::UnityEngine.Rendering.RenderTargetIdentifier* colorRenderTargetsPointer = colorRenderTargets)
            {
                fixed (global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadActionsPointer = colorLoadActions)
                {
                    fixed (global::UnityEngine.Rendering.RenderBufferStoreAction* colorStoreActionsPointer = colorStoreActions)
                    {
                        return UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(colorRenderTargetsPointer, colorRenderTargets.Length, colorLoadActionsPointer, colorLoadActions.Length, colorStoreActionsPointer, colorStoreActions.Length, Unsafe.AsPointer(ref depthRenderTarget), (int) depthLoadAction, (int) depthStoreAction);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(global::UnityEngine.Rendering.RenderTargetIdentifier colorRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            return UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(Unsafe.AsPointer(ref colorRenderTarget), (int) colorLoadAction, (int) colorStoreAction, Unsafe.AsPointer(ref depthRenderTarget), (int) depthLoadAction, (int) depthStoreAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderTargetSetup(global::UnityEngine.RenderTargetSetup setup)
        {
            return UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderTargetSetup(setup.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderTargetIdentifier[] internal_UnityEngineRenderingRenderTargetBinding__get__colorRenderTargets(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderTargetIdentifier* colorRenderTargetsIdsPointer = default;
            int colorRenderTargetsWasmLength = default;
            UnityEngineRenderingRenderTargetBinding__get__colorRenderTargets(selfObjectId, &colorRenderTargetsIdsPointer, &colorRenderTargetsWasmLength);
            global::UnityEngine.Rendering.RenderTargetIdentifier[] returnResult = new global::UnityEngine.Rendering.RenderTargetIdentifier[colorRenderTargetsWasmLength];
            for (int i = 0; i < colorRenderTargetsWasmLength; i++)
            {
                returnResult[i] = colorRenderTargetsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorRenderTargetsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__colorRenderTargets(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets)
        {
            fixed (global::UnityEngine.Rendering.RenderTargetIdentifier* colorRenderTargetsPointer = colorRenderTargets)
            {
                UnityEngineRenderingRenderTargetBinding__set__colorRenderTargets(selfObjectId, colorRenderTargetsPointer, colorRenderTargets.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderTargetIdentifier internal_UnityEngineRenderingRenderTargetBinding__get__depthRenderTarget(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTargetValue = default;
            UnityEngineRenderingRenderTargetBinding__get__depthRenderTarget(selfObjectId, Unsafe.AsPointer(ref depthRenderTargetValue));
            global::UnityEngine.Rendering.RenderTargetIdentifier returnResult = depthRenderTargetValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__depthRenderTarget(long selfObjectId, global::UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget)
        {
            UnityEngineRenderingRenderTargetBinding__set__depthRenderTarget(selfObjectId, Unsafe.AsPointer(ref depthRenderTarget));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferLoadAction[] internal_UnityEngineRenderingRenderTargetBinding__get__colorLoadActions(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadActionsIdsPointer = default;
            int colorLoadActionsWasmLength = default;
            UnityEngineRenderingRenderTargetBinding__get__colorLoadActions(selfObjectId, &colorLoadActionsIdsPointer, &colorLoadActionsWasmLength);
            global::UnityEngine.Rendering.RenderBufferLoadAction[] returnResult = new global::UnityEngine.Rendering.RenderBufferLoadAction[colorLoadActionsWasmLength];
            for (int i = 0; i < colorLoadActionsWasmLength; i++)
            {
                returnResult[i] = colorLoadActionsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorLoadActionsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__colorLoadActions(long selfObjectId, global::UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions)
        {
            fixed (global::UnityEngine.Rendering.RenderBufferLoadAction* colorLoadActionsPointer = colorLoadActions)
            {
                UnityEngineRenderingRenderTargetBinding__set__colorLoadActions(selfObjectId, colorLoadActionsPointer, colorLoadActions.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferStoreAction[] internal_UnityEngineRenderingRenderTargetBinding__get__colorStoreActions(long selfObjectId)
        {
            global::UnityEngine.Rendering.RenderBufferStoreAction* colorStoreActionsIdsPointer = default;
            int colorStoreActionsWasmLength = default;
            UnityEngineRenderingRenderTargetBinding__get__colorStoreActions(selfObjectId, &colorStoreActionsIdsPointer, &colorStoreActionsWasmLength);
            global::UnityEngine.Rendering.RenderBufferStoreAction[] returnResult = new global::UnityEngine.Rendering.RenderBufferStoreAction[colorStoreActionsWasmLength];
            for (int i = 0; i < colorStoreActionsWasmLength; i++)
            {
                returnResult[i] = colorStoreActionsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)colorStoreActionsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__colorStoreActions(long selfObjectId, global::UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions)
        {
            fixed (global::UnityEngine.Rendering.RenderBufferStoreAction* colorStoreActionsPointer = colorStoreActions)
            {
                UnityEngineRenderingRenderTargetBinding__set__colorStoreActions(selfObjectId, colorStoreActionsPointer, colorStoreActions.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferLoadAction internal_UnityEngineRenderingRenderTargetBinding__get__depthLoadAction(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingRenderTargetBinding__get__depthLoadAction(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.RenderBufferLoadAction)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__depthLoadAction(long selfObjectId, global::UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction)
        {
            UnityEngineRenderingRenderTargetBinding__set__depthLoadAction(selfObjectId, (int) depthLoadAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderBufferStoreAction internal_UnityEngineRenderingRenderTargetBinding__get__depthStoreAction(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingRenderTargetBinding__get__depthStoreAction(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.RenderBufferStoreAction)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__depthStoreAction(long selfObjectId, global::UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
        {
            UnityEngineRenderingRenderTargetBinding__set__depthStoreAction(selfObjectId, (int) depthStoreAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.RenderTargetFlags internal_UnityEngineRenderingRenderTargetBinding__get__flags(long selfObjectId)
        {
            var methodCallResult = UnityEngineRenderingRenderTargetBinding__get__flags(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.RenderTargetFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRenderingRenderTargetBinding__set__flags(long selfObjectId, global::UnityEngine.Rendering.RenderTargetFlags flags)
        {
            UnityEngineRenderingRenderTargetBinding__set__flags(selfObjectId, (int) flags);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifierArray__UnityEngineRenderingRenderBufferLoadActionEnumArray__UnityEngineRenderingRenderBufferStoreActionEnumArray__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(void* colorRenderTargetsPointer, int colorRenderTargetsWasmLength, void* colorLoadActionsPointer, int colorLoadActionsWasmLength, void* colorStoreActionsPointer, int colorStoreActionsWasmLength, void* depthRenderTargetPointer, int depthLoadActionUnderlyingValue, int depthStoreActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum__UnityEngineRenderingRenderTargetIdentifier__UnityEngineRenderingRenderBufferLoadActionEnum__UnityEngineRenderingRenderBufferStoreActionEnum(void* colorRenderTargetPointer, int colorLoadActionUnderlyingValue, int colorStoreActionUnderlyingValue, void* depthRenderTargetPointer, int depthLoadActionUnderlyingValue, int depthStoreActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRenderingRenderTargetBinding__ctor__UnityEngineRenderTargetSetup(long setupObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__get__colorRenderTargets(long selfObjectId, void* colorRenderTargetsIdsPointer, void* colorRenderTargetsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__set__colorRenderTargets(long selfObjectId, void* colorRenderTargetsPointer, int colorRenderTargetsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__get__depthRenderTarget(long selfObjectId, void* depthRenderTargetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__set__depthRenderTarget(long selfObjectId, void* depthRenderTargetPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__get__colorLoadActions(long selfObjectId, void* colorLoadActionsIdsPointer, void* colorLoadActionsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__set__colorLoadActions(long selfObjectId, void* colorLoadActionsPointer, int colorLoadActionsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__get__colorStoreActions(long selfObjectId, void* colorStoreActionsIdsPointer, void* colorStoreActionsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRenderingRenderTargetBinding__set__colorStoreActions(long selfObjectId, void* colorStoreActionsPointer, int colorStoreActionsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingRenderTargetBinding__get__depthLoadAction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingRenderTargetBinding__set__depthLoadAction(long selfObjectId, int depthLoadActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingRenderTargetBinding__get__depthStoreAction(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingRenderTargetBinding__set__depthStoreAction(long selfObjectId, int depthStoreActionUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineRenderingRenderTargetBinding__get__flags(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRenderingRenderTargetBinding__set__flags(long selfObjectId, int flagsUnderlyingValue);

        #endregion Imports
    }
}
