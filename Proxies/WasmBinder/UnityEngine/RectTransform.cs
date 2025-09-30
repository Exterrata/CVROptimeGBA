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

    public partial class RectTransform(long id) : Transform(id)
    {

        #region Implementation

        public global::UnityEngine.Rect rect 
        {
            get => internal_UnityEngineRectTransform__get__rect(WrappedId);
        }

        public global::UnityEngine.Vector2 anchorMin 
        {
            get => internal_UnityEngineRectTransform__get__anchorMin(WrappedId);
            set => internal_UnityEngineRectTransform__set__anchorMin(WrappedId, value);
        }

        public global::UnityEngine.Vector2 anchorMax 
        {
            get => internal_UnityEngineRectTransform__get__anchorMax(WrappedId);
            set => internal_UnityEngineRectTransform__set__anchorMax(WrappedId, value);
        }

        public global::UnityEngine.Vector2 anchoredPosition 
        {
            get => internal_UnityEngineRectTransform__get__anchoredPosition(WrappedId);
            set => internal_UnityEngineRectTransform__set__anchoredPosition(WrappedId, value);
        }

        public global::UnityEngine.Vector2 sizeDelta 
        {
            get => internal_UnityEngineRectTransform__get__sizeDelta(WrappedId);
            set => internal_UnityEngineRectTransform__set__sizeDelta(WrappedId, value);
        }

        public global::UnityEngine.Vector2 pivot 
        {
            get => internal_UnityEngineRectTransform__get__pivot(WrappedId);
            set => internal_UnityEngineRectTransform__set__pivot(WrappedId, value);
        }

        public global::UnityEngine.Vector3 anchoredPosition3D 
        {
            get => internal_UnityEngineRectTransform__get__anchoredPosition3D(WrappedId);
            set => internal_UnityEngineRectTransform__set__anchoredPosition3D(WrappedId, value);
        }

        public global::UnityEngine.Vector2 offsetMin 
        {
            get => internal_UnityEngineRectTransform__get__offsetMin(WrappedId);
            set => internal_UnityEngineRectTransform__set__offsetMin(WrappedId, value);
        }

        public global::UnityEngine.Vector2 offsetMax 
        {
            get => internal_UnityEngineRectTransform__get__offsetMax(WrappedId);
            set => internal_UnityEngineRectTransform__set__offsetMax(WrappedId, value);
        }

        public global::UnityEngine.Object drivenByObject 
        {
            get => internal_UnityEngineRectTransform__get__drivenByObject(WrappedId);
        }

        public void ForceUpdateRectTransforms()
        {
            internal_UnityEngineRectTransform__func__ForceUpdateRectTransforms__SystemVoid(WrappedId);
        }

        public void GetLocalCorners(global::UnityEngine.Vector3[] fourCornersArray)
        {
            internal_UnityEngineRectTransform__func__GetLocalCorners__UnityEngineVector3Array__SystemVoid(WrappedId, fourCornersArray);
        }

        public void GetWorldCorners(global::UnityEngine.Vector3[] fourCornersArray)
        {
            internal_UnityEngineRectTransform__func__GetWorldCorners__UnityEngineVector3Array__SystemVoid(WrappedId, fourCornersArray);
        }

        public void SetInsetAndSizeFromParentEdge(global::UnityEngine.RectTransform.Edge edge, float inset, float size)
        {
            internal_UnityEngineRectTransform__func__SetInsetAndSizeFromParentEdge__UnityEngineEdgeEnum__SystemSingle__SystemSingle__SystemVoid(WrappedId, edge, inset, size);
        }

        public void SetSizeWithCurrentAnchors(global::UnityEngine.RectTransform.Axis axis, float size)
        {
            internal_UnityEngineRectTransform__func__SetSizeWithCurrentAnchors__UnityEngineAxisEnum__SystemSingle__SystemVoid(WrappedId, axis, size);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineRectTransform__get__rect(long selfObjectId)
        {
            global::UnityEngine.Rect rectValue = default;
            UnityEngineRectTransform__get__rect(selfObjectId, Unsafe.AsPointer(ref rectValue));
            global::UnityEngine.Rect returnResult = rectValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__anchorMin(long selfObjectId)
        {
            global::UnityEngine.Vector2 anchorMinValue = default;
            UnityEngineRectTransform__get__anchorMin(selfObjectId, Unsafe.AsPointer(ref anchorMinValue));
            global::UnityEngine.Vector2 returnResult = anchorMinValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__anchorMin(long selfObjectId, global::UnityEngine.Vector2 anchorMin)
        {
            UnityEngineRectTransform__set__anchorMin(selfObjectId, Unsafe.AsPointer(ref anchorMin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__anchorMax(long selfObjectId)
        {
            global::UnityEngine.Vector2 anchorMaxValue = default;
            UnityEngineRectTransform__get__anchorMax(selfObjectId, Unsafe.AsPointer(ref anchorMaxValue));
            global::UnityEngine.Vector2 returnResult = anchorMaxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__anchorMax(long selfObjectId, global::UnityEngine.Vector2 anchorMax)
        {
            UnityEngineRectTransform__set__anchorMax(selfObjectId, Unsafe.AsPointer(ref anchorMax));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__anchoredPosition(long selfObjectId)
        {
            global::UnityEngine.Vector2 anchoredPositionValue = default;
            UnityEngineRectTransform__get__anchoredPosition(selfObjectId, Unsafe.AsPointer(ref anchoredPositionValue));
            global::UnityEngine.Vector2 returnResult = anchoredPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__anchoredPosition(long selfObjectId, global::UnityEngine.Vector2 anchoredPosition)
        {
            UnityEngineRectTransform__set__anchoredPosition(selfObjectId, Unsafe.AsPointer(ref anchoredPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__sizeDelta(long selfObjectId)
        {
            global::UnityEngine.Vector2 sizeDeltaValue = default;
            UnityEngineRectTransform__get__sizeDelta(selfObjectId, Unsafe.AsPointer(ref sizeDeltaValue));
            global::UnityEngine.Vector2 returnResult = sizeDeltaValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__sizeDelta(long selfObjectId, global::UnityEngine.Vector2 sizeDelta)
        {
            UnityEngineRectTransform__set__sizeDelta(selfObjectId, Unsafe.AsPointer(ref sizeDelta));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__pivot(long selfObjectId)
        {
            global::UnityEngine.Vector2 pivotValue = default;
            UnityEngineRectTransform__get__pivot(selfObjectId, Unsafe.AsPointer(ref pivotValue));
            global::UnityEngine.Vector2 returnResult = pivotValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__pivot(long selfObjectId, global::UnityEngine.Vector2 pivot)
        {
            UnityEngineRectTransform__set__pivot(selfObjectId, Unsafe.AsPointer(ref pivot));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineRectTransform__get__anchoredPosition3D(long selfObjectId)
        {
            global::UnityEngine.Vector3 anchoredPosition3DValue = default;
            UnityEngineRectTransform__get__anchoredPosition3D(selfObjectId, Unsafe.AsPointer(ref anchoredPosition3DValue));
            global::UnityEngine.Vector3 returnResult = anchoredPosition3DValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__anchoredPosition3D(long selfObjectId, global::UnityEngine.Vector3 anchoredPosition3D)
        {
            UnityEngineRectTransform__set__anchoredPosition3D(selfObjectId, Unsafe.AsPointer(ref anchoredPosition3D));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__offsetMin(long selfObjectId)
        {
            global::UnityEngine.Vector2 offsetMinValue = default;
            UnityEngineRectTransform__get__offsetMin(selfObjectId, Unsafe.AsPointer(ref offsetMinValue));
            global::UnityEngine.Vector2 returnResult = offsetMinValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__offsetMin(long selfObjectId, global::UnityEngine.Vector2 offsetMin)
        {
            UnityEngineRectTransform__set__offsetMin(selfObjectId, Unsafe.AsPointer(ref offsetMin));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineRectTransform__get__offsetMax(long selfObjectId)
        {
            global::UnityEngine.Vector2 offsetMaxValue = default;
            UnityEngineRectTransform__get__offsetMax(selfObjectId, Unsafe.AsPointer(ref offsetMaxValue));
            global::UnityEngine.Vector2 returnResult = offsetMaxValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__set__offsetMax(long selfObjectId, global::UnityEngine.Vector2 offsetMax)
        {
            UnityEngineRectTransform__set__offsetMax(selfObjectId, Unsafe.AsPointer(ref offsetMax));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Object internal_UnityEngineRectTransform__get__drivenByObject(long selfObjectId)
        {
            var methodCallResult = UnityEngineRectTransform__get__drivenByObject(selfObjectId);
            var returnResult = new global::UnityEngine.Object(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__func__ForceUpdateRectTransforms__SystemVoid(long selfObjectId)
        {
            UnityEngineRectTransform__func__ForceUpdateRectTransforms__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__func__GetLocalCorners__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] fourCornersArray)
        {
            fixed (global::UnityEngine.Vector3* fourCornersArrayPointer = fourCornersArray)
            {
                UnityEngineRectTransform__func__GetLocalCorners__UnityEngineVector3Array__SystemVoid(selfObjectId, fourCornersArrayPointer, fourCornersArray.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__func__GetWorldCorners__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Vector3[] fourCornersArray)
        {
            fixed (global::UnityEngine.Vector3* fourCornersArrayPointer = fourCornersArray)
            {
                UnityEngineRectTransform__func__GetWorldCorners__UnityEngineVector3Array__SystemVoid(selfObjectId, fourCornersArrayPointer, fourCornersArray.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__func__SetInsetAndSizeFromParentEdge__UnityEngineEdgeEnum__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.RectTransform.Edge edge, float inset, float size)
        {
            UnityEngineRectTransform__func__SetInsetAndSizeFromParentEdge__UnityEngineEdgeEnum__SystemSingle__SystemSingle__SystemVoid(selfObjectId, (int) edge, inset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineRectTransform__func__SetSizeWithCurrentAnchors__UnityEngineAxisEnum__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.RectTransform.Axis axis, float size)
        {
            UnityEngineRectTransform__func__SetSizeWithCurrentAnchors__UnityEngineAxisEnum__SystemSingle__SystemVoid(selfObjectId, (int) axis, size);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__rect(long selfObjectId, void* rectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__anchorMin(long selfObjectId, void* anchorMinPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__anchorMin(long selfObjectId, void* anchorMinPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__anchorMax(long selfObjectId, void* anchorMaxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__anchorMax(long selfObjectId, void* anchorMaxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__anchoredPosition(long selfObjectId, void* anchoredPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__anchoredPosition(long selfObjectId, void* anchoredPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__sizeDelta(long selfObjectId, void* sizeDeltaPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__sizeDelta(long selfObjectId, void* sizeDeltaPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__pivot(long selfObjectId, void* pivotPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__pivot(long selfObjectId, void* pivotPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__anchoredPosition3D(long selfObjectId, void* anchoredPosition3DPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__anchoredPosition3D(long selfObjectId, void* anchoredPosition3DPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__offsetMin(long selfObjectId, void* offsetMinPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__offsetMin(long selfObjectId, void* offsetMinPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__get__offsetMax(long selfObjectId, void* offsetMaxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__set__offsetMax(long selfObjectId, void* offsetMaxPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineRectTransform__get__drivenByObject(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRectTransform__func__ForceUpdateRectTransforms__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__func__GetLocalCorners__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* fourCornersArrayPointer, int fourCornersArrayWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineRectTransform__func__GetWorldCorners__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* fourCornersArrayPointer, int fourCornersArrayWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRectTransform__func__SetInsetAndSizeFromParentEdge__UnityEngineEdgeEnum__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int edgeUnderlyingValue, float inset, float size);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineRectTransform__func__SetSizeWithCurrentAnchors__UnityEngineAxisEnum__SystemSingle__SystemVoid(long selfObjectId, int axisUnderlyingValue, float size);

        #endregion Imports
    }
}
