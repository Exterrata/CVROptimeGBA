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

    public partial class Transform(long id) : Component(id)
    {

        #region Implementation

        public global::UnityEngine.Vector3 position 
        {
            get => internal_UnityEngineTransform__get__position(WrappedId);
            set => internal_UnityEngineTransform__set__position(WrappedId, value);
        }

        public global::UnityEngine.Vector3 localPosition 
        {
            get => internal_UnityEngineTransform__get__localPosition(WrappedId);
            set => internal_UnityEngineTransform__set__localPosition(WrappedId, value);
        }

        public global::UnityEngine.Vector3 eulerAngles 
        {
            get => internal_UnityEngineTransform__get__eulerAngles(WrappedId);
            set => internal_UnityEngineTransform__set__eulerAngles(WrappedId, value);
        }

        public global::UnityEngine.Vector3 localEulerAngles 
        {
            get => internal_UnityEngineTransform__get__localEulerAngles(WrappedId);
            set => internal_UnityEngineTransform__set__localEulerAngles(WrappedId, value);
        }

        public global::UnityEngine.Vector3 right 
        {
            get => internal_UnityEngineTransform__get__right(WrappedId);
            set => internal_UnityEngineTransform__set__right(WrappedId, value);
        }

        public global::UnityEngine.Vector3 up 
        {
            get => internal_UnityEngineTransform__get__up(WrappedId);
            set => internal_UnityEngineTransform__set__up(WrappedId, value);
        }

        public global::UnityEngine.Vector3 forward 
        {
            get => internal_UnityEngineTransform__get__forward(WrappedId);
            set => internal_UnityEngineTransform__set__forward(WrappedId, value);
        }

        public global::UnityEngine.Quaternion rotation 
        {
            get => internal_UnityEngineTransform__get__rotation(WrappedId);
            set => internal_UnityEngineTransform__set__rotation(WrappedId, value);
        }

        public global::UnityEngine.Quaternion localRotation 
        {
            get => internal_UnityEngineTransform__get__localRotation(WrappedId);
            set => internal_UnityEngineTransform__set__localRotation(WrappedId, value);
        }

        public global::UnityEngine.Vector3 localScale 
        {
            get => internal_UnityEngineTransform__get__localScale(WrappedId);
            set => internal_UnityEngineTransform__set__localScale(WrappedId, value);
        }

        public global::UnityEngine.Transform parent 
        {
            get => internal_UnityEngineTransform__get__parent(WrappedId);
            set => internal_UnityEngineTransform__set__parent(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 worldToLocalMatrix 
        {
            get => internal_UnityEngineTransform__get__worldToLocalMatrix(WrappedId);
        }

        public global::UnityEngine.Matrix4x4 localToWorldMatrix 
        {
            get => internal_UnityEngineTransform__get__localToWorldMatrix(WrappedId);
        }

        public global::UnityEngine.Transform root 
        {
            get => internal_UnityEngineTransform__get__root(WrappedId);
        }

        public int childCount 
        {
            get => internal_UnityEngineTransform__get__childCount(WrappedId);
        }

        public global::UnityEngine.Vector3 lossyScale 
        {
            get => internal_UnityEngineTransform__get__lossyScale(WrappedId);
        }

        public bool hasChanged 
        {
            get => internal_UnityEngineTransform__get__hasChanged(WrappedId);
            set => internal_UnityEngineTransform__set__hasChanged(WrappedId, value);
        }

        public int hierarchyCapacity 
        {
            get => internal_UnityEngineTransform__get__hierarchyCapacity(WrappedId);
            set => internal_UnityEngineTransform__set__hierarchyCapacity(WrappedId, value);
        }

        public int hierarchyCount 
        {
            get => internal_UnityEngineTransform__get__hierarchyCount(WrappedId);
        }

        public void SetParent(global::UnityEngine.Transform p)
        {
            internal_UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemVoid(WrappedId, p);
        }

        public void SetParent(global::UnityEngine.Transform parent, bool worldPositionStays)
        {
            internal_UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemBoolean__SystemVoid(WrappedId, parent, worldPositionStays);
        }

        public void SetPositionAndRotation(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEngineTransform__func__SetPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(WrappedId, position, rotation);
        }

        public void SetLocalPositionAndRotation(global::UnityEngine.Vector3 localPosition, global::UnityEngine.Quaternion localRotation)
        {
            internal_UnityEngineTransform__func__SetLocalPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(WrappedId, localPosition, localRotation);
        }

        public void GetPositionAndRotation(out global::UnityEngine.Vector3 position, out global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEngineTransform__func__GetPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(WrappedId, out position, out rotation);
        }

        public void GetLocalPositionAndRotation(out global::UnityEngine.Vector3 localPosition, out global::UnityEngine.Quaternion localRotation)
        {
            internal_UnityEngineTransform__func__GetLocalPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(WrappedId, out localPosition, out localRotation);
        }

        public void Translate(global::UnityEngine.Vector3 translation, global::UnityEngine.Space relativeTo)
        {
            internal_UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(WrappedId, translation, relativeTo);
        }

        public void Translate(global::UnityEngine.Vector3 translation)
        {
            internal_UnityEngineTransform__func__Translate__UnityEngineVector3__SystemVoid(WrappedId, translation);
        }

        public void Translate(float x, float y, float z, global::UnityEngine.Space relativeTo)
        {
            internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(WrappedId, x, y, z, relativeTo);
        }

        public void Translate(float x, float y, float z)
        {
            internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, x, y, z);
        }

        public void Translate(global::UnityEngine.Vector3 translation, global::UnityEngine.Transform relativeTo)
        {
            internal_UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineTransform__SystemVoid(WrappedId, translation, relativeTo);
        }

        public void Translate(float x, float y, float z, global::UnityEngine.Transform relativeTo)
        {
            internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineTransform__SystemVoid(WrappedId, x, y, z, relativeTo);
        }

        public void Rotate(global::UnityEngine.Vector3 eulers, global::UnityEngine.Space relativeTo)
        {
            internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(WrappedId, eulers, relativeTo);
        }

        public void Rotate(global::UnityEngine.Vector3 eulers)
        {
            internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemVoid(WrappedId, eulers);
        }

        public void Rotate(float xAngle, float yAngle, float zAngle, global::UnityEngine.Space relativeTo)
        {
            internal_UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(WrappedId, xAngle, yAngle, zAngle, relativeTo);
        }

        public void Rotate(float xAngle, float yAngle, float zAngle)
        {
            internal_UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, xAngle, yAngle, zAngle);
        }

        public void Rotate(global::UnityEngine.Vector3 axis, float angle, global::UnityEngine.Space relativeTo)
        {
            internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__UnityEngineSpaceEnum__SystemVoid(WrappedId, axis, angle, relativeTo);
        }

        public void Rotate(global::UnityEngine.Vector3 axis, float angle)
        {
            internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__SystemVoid(WrappedId, axis, angle);
        }

        public void RotateAround(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 axis, float angle)
        {
            internal_UnityEngineTransform__func__RotateAround__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemVoid(WrappedId, point, axis, angle);
        }

        public void LookAt(global::UnityEngine.Transform target, global::UnityEngine.Vector3 worldUp)
        {
            internal_UnityEngineTransform__func__LookAt__UnityEngineTransform__UnityEngineVector3__SystemVoid(WrappedId, target, worldUp);
        }

        public void LookAt(global::UnityEngine.Transform target)
        {
            internal_UnityEngineTransform__func__LookAt__UnityEngineTransform__SystemVoid(WrappedId, target);
        }

        public void LookAt(global::UnityEngine.Vector3 worldPosition, global::UnityEngine.Vector3 worldUp)
        {
            internal_UnityEngineTransform__func__LookAt__UnityEngineVector3__UnityEngineVector3__SystemVoid(WrappedId, worldPosition, worldUp);
        }

        public void LookAt(global::UnityEngine.Vector3 worldPosition)
        {
            internal_UnityEngineTransform__func__LookAt__UnityEngineVector3__SystemVoid(WrappedId, worldPosition);
        }

        public global::UnityEngine.Vector3 TransformDirection(global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEngineTransform__func__TransformDirection__UnityEngineVector3__UnityEngineVector3(WrappedId, direction);
        }

        public global::UnityEngine.Vector3 TransformDirection(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__TransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public global::UnityEngine.Vector3 InverseTransformDirection(global::UnityEngine.Vector3 direction)
        {
            return internal_UnityEngineTransform__func__InverseTransformDirection__UnityEngineVector3__UnityEngineVector3(WrappedId, direction);
        }

        public global::UnityEngine.Vector3 InverseTransformDirection(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__InverseTransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public global::UnityEngine.Vector3 TransformVector(global::UnityEngine.Vector3 vector)
        {
            return internal_UnityEngineTransform__func__TransformVector__UnityEngineVector3__UnityEngineVector3(WrappedId, vector);
        }

        public global::UnityEngine.Vector3 TransformVector(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__TransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public global::UnityEngine.Vector3 InverseTransformVector(global::UnityEngine.Vector3 vector)
        {
            return internal_UnityEngineTransform__func__InverseTransformVector__UnityEngineVector3__UnityEngineVector3(WrappedId, vector);
        }

        public global::UnityEngine.Vector3 InverseTransformVector(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__InverseTransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public global::UnityEngine.Vector3 TransformPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineTransform__func__TransformPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 TransformPoint(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__TransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public global::UnityEngine.Vector3 InverseTransformPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineTransform__func__InverseTransformPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 InverseTransformPoint(float x, float y, float z)
        {
            return internal_UnityEngineTransform__func__InverseTransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(WrappedId, x, y, z);
        }

        public void DetachChildren()
        {
            internal_UnityEngineTransform__func__DetachChildren__SystemVoid(WrappedId);
        }

        public void SetAsFirstSibling()
        {
            internal_UnityEngineTransform__func__SetAsFirstSibling__SystemVoid(WrappedId);
        }

        public void SetAsLastSibling()
        {
            internal_UnityEngineTransform__func__SetAsLastSibling__SystemVoid(WrappedId);
        }

        public void SetSiblingIndex(int index)
        {
            internal_UnityEngineTransform__func__SetSiblingIndex__SystemInt32__SystemVoid(WrappedId, index);
        }

        public int GetSiblingIndex()
        {
            return internal_UnityEngineTransform__func__GetSiblingIndex__SystemInt32(WrappedId);
        }

        public global::UnityEngine.Transform Find(string n)
        {
            return internal_UnityEngineTransform__func__Find__SystemString__UnityEngineTransform(WrappedId, n);
        }

        public bool IsChildOf(global::UnityEngine.Transform parent)
        {
            return internal_UnityEngineTransform__func__IsChildOf__UnityEngineTransform__SystemBoolean(WrappedId, parent);
        }

        public global::UnityEngine.Transform GetChild(int index)
        {
            return internal_UnityEngineTransform__func__GetChild__SystemInt32__UnityEngineTransform(WrappedId, index);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__position(long selfObjectId)
        {
            global::UnityEngine.Vector3 positionValue = default;
            UnityEngineTransform__get__position(selfObjectId, Unsafe.AsPointer(ref positionValue));
            global::UnityEngine.Vector3 returnResult = positionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__position(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            UnityEngineTransform__set__position(selfObjectId, Unsafe.AsPointer(ref position));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__localPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 localPositionValue = default;
            UnityEngineTransform__get__localPosition(selfObjectId, Unsafe.AsPointer(ref localPositionValue));
            global::UnityEngine.Vector3 returnResult = localPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__localPosition(long selfObjectId, global::UnityEngine.Vector3 localPosition)
        {
            UnityEngineTransform__set__localPosition(selfObjectId, Unsafe.AsPointer(ref localPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__eulerAngles(long selfObjectId)
        {
            global::UnityEngine.Vector3 eulerAnglesValue = default;
            UnityEngineTransform__get__eulerAngles(selfObjectId, Unsafe.AsPointer(ref eulerAnglesValue));
            global::UnityEngine.Vector3 returnResult = eulerAnglesValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__eulerAngles(long selfObjectId, global::UnityEngine.Vector3 eulerAngles)
        {
            UnityEngineTransform__set__eulerAngles(selfObjectId, Unsafe.AsPointer(ref eulerAngles));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__localEulerAngles(long selfObjectId)
        {
            global::UnityEngine.Vector3 localEulerAnglesValue = default;
            UnityEngineTransform__get__localEulerAngles(selfObjectId, Unsafe.AsPointer(ref localEulerAnglesValue));
            global::UnityEngine.Vector3 returnResult = localEulerAnglesValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__localEulerAngles(long selfObjectId, global::UnityEngine.Vector3 localEulerAngles)
        {
            UnityEngineTransform__set__localEulerAngles(selfObjectId, Unsafe.AsPointer(ref localEulerAngles));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__right(long selfObjectId)
        {
            global::UnityEngine.Vector3 rightValue = default;
            UnityEngineTransform__get__right(selfObjectId, Unsafe.AsPointer(ref rightValue));
            global::UnityEngine.Vector3 returnResult = rightValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__right(long selfObjectId, global::UnityEngine.Vector3 right)
        {
            UnityEngineTransform__set__right(selfObjectId, Unsafe.AsPointer(ref right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__up(long selfObjectId)
        {
            global::UnityEngine.Vector3 upValue = default;
            UnityEngineTransform__get__up(selfObjectId, Unsafe.AsPointer(ref upValue));
            global::UnityEngine.Vector3 returnResult = upValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__up(long selfObjectId, global::UnityEngine.Vector3 up)
        {
            UnityEngineTransform__set__up(selfObjectId, Unsafe.AsPointer(ref up));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__forward(long selfObjectId)
        {
            global::UnityEngine.Vector3 forwardValue = default;
            UnityEngineTransform__get__forward(selfObjectId, Unsafe.AsPointer(ref forwardValue));
            global::UnityEngine.Vector3 returnResult = forwardValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__forward(long selfObjectId, global::UnityEngine.Vector3 forward)
        {
            UnityEngineTransform__set__forward(selfObjectId, Unsafe.AsPointer(ref forward));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineTransform__get__rotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion rotationValue = default;
            UnityEngineTransform__get__rotation(selfObjectId, Unsafe.AsPointer(ref rotationValue));
            global::UnityEngine.Quaternion returnResult = rotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__rotation(long selfObjectId, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineTransform__set__rotation(selfObjectId, Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineTransform__get__localRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion localRotationValue = default;
            UnityEngineTransform__get__localRotation(selfObjectId, Unsafe.AsPointer(ref localRotationValue));
            global::UnityEngine.Quaternion returnResult = localRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__localRotation(long selfObjectId, global::UnityEngine.Quaternion localRotation)
        {
            UnityEngineTransform__set__localRotation(selfObjectId, Unsafe.AsPointer(ref localRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__localScale(long selfObjectId)
        {
            global::UnityEngine.Vector3 localScaleValue = default;
            UnityEngineTransform__get__localScale(selfObjectId, Unsafe.AsPointer(ref localScaleValue));
            global::UnityEngine.Vector3 returnResult = localScaleValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__localScale(long selfObjectId, global::UnityEngine.Vector3 localScale)
        {
            UnityEngineTransform__set__localScale(selfObjectId, Unsafe.AsPointer(ref localScale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineTransform__get__parent(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__parent(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__parent(long selfObjectId, global::UnityEngine.Transform parent)
        {
            UnityEngineTransform__set__parent(selfObjectId, parent.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineTransform__get__worldToLocalMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 worldToLocalMatrixValue = default;
            UnityEngineTransform__get__worldToLocalMatrix(selfObjectId, Unsafe.AsPointer(ref worldToLocalMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = worldToLocalMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineTransform__get__localToWorldMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 localToWorldMatrixValue = default;
            UnityEngineTransform__get__localToWorldMatrix(selfObjectId, Unsafe.AsPointer(ref localToWorldMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = localToWorldMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineTransform__get__root(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__root(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTransform__get__childCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__childCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__get__lossyScale(long selfObjectId)
        {
            global::UnityEngine.Vector3 lossyScaleValue = default;
            UnityEngineTransform__get__lossyScale(selfObjectId, Unsafe.AsPointer(ref lossyScaleValue));
            global::UnityEngine.Vector3 returnResult = lossyScaleValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTransform__get__hasChanged(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__hasChanged(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__hasChanged(long selfObjectId, bool hasChanged)
        {
            var hasChangedConverted = Unsafe.As<bool, int>(ref hasChanged);
            UnityEngineTransform__set__hasChanged(selfObjectId, hasChangedConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTransform__get__hierarchyCapacity(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__hierarchyCapacity(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__set__hierarchyCapacity(long selfObjectId, int hierarchyCapacity)
        {
            UnityEngineTransform__set__hierarchyCapacity(selfObjectId, hierarchyCapacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTransform__get__hierarchyCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__get__hierarchyCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemVoid(long selfObjectId, global::UnityEngine.Transform p)
        {
            UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemVoid(selfObjectId, p.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Transform parent, bool worldPositionStays)
        {
            var worldPositionStaysConverted = Unsafe.As<bool, int>(ref worldPositionStays);
            UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemBoolean__SystemVoid(selfObjectId, parent.WrappedId, worldPositionStaysConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineTransform__func__SetPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetLocalPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 localPosition, global::UnityEngine.Quaternion localRotation)
        {
            UnityEngineTransform__func__SetLocalPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(selfObjectId, Unsafe.AsPointer(ref localPosition), Unsafe.AsPointer(ref localRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__GetPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(long selfObjectId, out global::UnityEngine.Vector3 position, out global::UnityEngine.Quaternion rotation)
        {
            position = default;
            rotation = default;
            UnityEngineTransform__func__GetPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__GetLocalPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(long selfObjectId, out global::UnityEngine.Vector3 localPosition, out global::UnityEngine.Quaternion localRotation)
        {
            localPosition = default;
            localRotation = default;
            UnityEngineTransform__func__GetLocalPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(selfObjectId, Unsafe.AsPointer(ref localPosition), Unsafe.AsPointer(ref localRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 translation, global::UnityEngine.Space relativeTo)
        {
            UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref translation), (int) relativeTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 translation)
        {
            UnityEngineTransform__func__Translate__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref translation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.Space relativeTo)
        {
            UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(selfObjectId, x, y, z, (int) relativeTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z)
        {
            UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineTransform__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 translation, global::UnityEngine.Transform relativeTo)
        {
            UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineTransform__SystemVoid(selfObjectId, Unsafe.AsPointer(ref translation), relativeTo.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineTransform__SystemVoid(long selfObjectId, float x, float y, float z, global::UnityEngine.Transform relativeTo)
        {
            UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineTransform__SystemVoid(selfObjectId, x, y, z, relativeTo.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 eulers, global::UnityEngine.Space relativeTo)
        {
            UnityEngineTransform__func__Rotate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref eulers), (int) relativeTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 eulers)
        {
            UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref eulers));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, float xAngle, float yAngle, float zAngle, global::UnityEngine.Space relativeTo)
        {
            UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(selfObjectId, xAngle, yAngle, zAngle, (int) relativeTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float xAngle, float yAngle, float zAngle)
        {
            UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, xAngle, yAngle, zAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 axis, float angle, global::UnityEngine.Space relativeTo)
        {
            UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__UnityEngineSpaceEnum__SystemVoid(selfObjectId, Unsafe.AsPointer(ref axis), angle, (int) relativeTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 axis, float angle)
        {
            UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__SystemVoid(selfObjectId, Unsafe.AsPointer(ref axis), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__RotateAround__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 axis, float angle)
        {
            UnityEngineTransform__func__RotateAround__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemVoid(selfObjectId, Unsafe.AsPointer(ref point), Unsafe.AsPointer(ref axis), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__LookAt__UnityEngineTransform__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Transform target, global::UnityEngine.Vector3 worldUp)
        {
            UnityEngineTransform__func__LookAt__UnityEngineTransform__UnityEngineVector3__SystemVoid(selfObjectId, target.WrappedId, Unsafe.AsPointer(ref worldUp));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__LookAt__UnityEngineTransform__SystemVoid(long selfObjectId, global::UnityEngine.Transform target)
        {
            UnityEngineTransform__func__LookAt__UnityEngineTransform__SystemVoid(selfObjectId, target.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__LookAt__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 worldPosition, global::UnityEngine.Vector3 worldUp)
        {
            UnityEngineTransform__func__LookAt__UnityEngineVector3__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref worldPosition), Unsafe.AsPointer(ref worldUp));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__LookAt__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 worldPosition)
        {
            UnityEngineTransform__func__LookAt__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref worldPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformDirection__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformDirection__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformDirection__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 direction)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformDirection__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref direction), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformVector__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 vector)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformVector__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref vector), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformVector__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 vector)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformVector__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref vector), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__TransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__TransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineTransform__func__InverseTransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineTransform__func__InverseTransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(selfObjectId, x, y, z, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__DetachChildren__SystemVoid(long selfObjectId)
        {
            UnityEngineTransform__func__DetachChildren__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetAsFirstSibling__SystemVoid(long selfObjectId)
        {
            UnityEngineTransform__func__SetAsFirstSibling__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetAsLastSibling__SystemVoid(long selfObjectId)
        {
            UnityEngineTransform__func__SetAsLastSibling__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTransform__func__SetSiblingIndex__SystemInt32__SystemVoid(long selfObjectId, int index)
        {
            UnityEngineTransform__func__SetSiblingIndex__SystemInt32__SystemVoid(selfObjectId, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTransform__func__GetSiblingIndex__SystemInt32(long selfObjectId)
        {
            var methodCallResult = UnityEngineTransform__func__GetSiblingIndex__SystemInt32(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineTransform__func__Find__SystemString__UnityEngineTransform(long selfObjectId, string n)
        {
            fixed (char* nPointer = n)
            {
                var methodCallResult = UnityEngineTransform__func__Find__SystemString__UnityEngineTransform(selfObjectId, nPointer, n.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Transform(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTransform__func__IsChildOf__UnityEngineTransform__SystemBoolean(long selfObjectId, global::UnityEngine.Transform parent)
        {
            var methodCallResult = UnityEngineTransform__func__IsChildOf__UnityEngineTransform__SystemBoolean(selfObjectId, parent.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineTransform__func__GetChild__SystemInt32__UnityEngineTransform(long selfObjectId, int index)
        {
            var methodCallResult = UnityEngineTransform__func__GetChild__SystemInt32__UnityEngineTransform(selfObjectId, index);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__position(long selfObjectId, void* positionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__localPosition(long selfObjectId, void* localPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__localPosition(long selfObjectId, void* localPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__eulerAngles(long selfObjectId, void* eulerAnglesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__eulerAngles(long selfObjectId, void* eulerAnglesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__localEulerAngles(long selfObjectId, void* localEulerAnglesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__localEulerAngles(long selfObjectId, void* localEulerAnglesPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__right(long selfObjectId, void* rightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__right(long selfObjectId, void* rightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__up(long selfObjectId, void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__up(long selfObjectId, void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__forward(long selfObjectId, void* forwardPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__forward(long selfObjectId, void* forwardPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__rotation(long selfObjectId, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__localRotation(long selfObjectId, void* localRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__localRotation(long selfObjectId, void* localRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__localScale(long selfObjectId, void* localScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__set__localScale(long selfObjectId, void* localScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTransform__get__parent(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__set__parent(long selfObjectId, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__worldToLocalMatrix(long selfObjectId, void* worldToLocalMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__localToWorldMatrix(long selfObjectId, void* localToWorldMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTransform__get__root(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__get__childCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__get__lossyScale(long selfObjectId, void* lossyScalePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__get__hasChanged(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__set__hasChanged(long selfObjectId, int hasChangedConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__get__hierarchyCapacity(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__set__hierarchyCapacity(long selfObjectId, int hierarchyCapacity);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__get__hierarchyCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemVoid(long selfObjectId, long pObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__SetParent__UnityEngineTransform__SystemBoolean__SystemVoid(long selfObjectId, long parentObjectId, int worldPositionStaysConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__SetPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__SetLocalPositionAndRotation__UnityEngineVector3__UnityEngineQuaternion__SystemVoid(long selfObjectId, void* localPositionPointer, void* localRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__GetPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(long selfObjectId, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__GetLocalPositionAndRotation__UnityEngineVector3Ref__UnityEngineQuaternionRef__SystemVoid(long selfObjectId, void* localPositionPointer, void* localRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, void* translationPointer, int relativeToUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Translate__UnityEngineVector3__SystemVoid(long selfObjectId, void* translationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, float x, float y, float z, int relativeToUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float x, float y, float z);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Translate__UnityEngineVector3__UnityEngineTransform__SystemVoid(long selfObjectId, void* translationPointer, long relativeToObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__Translate__SystemSingle__SystemSingle__SystemSingle__UnityEngineTransform__SystemVoid(long selfObjectId, float x, float y, float z, long relativeToObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Rotate__UnityEngineVector3__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, void* eulersPointer, int relativeToUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemVoid(long selfObjectId, void* eulersPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, float xAngle, float yAngle, float zAngle, int relativeToUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__Rotate__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float xAngle, float yAngle, float zAngle);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__UnityEngineSpaceEnum__SystemVoid(long selfObjectId, void* axisPointer, float angle, int relativeToUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__Rotate__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, void* axisPointer, float angle);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__RotateAround__UnityEngineVector3__UnityEngineVector3__SystemSingle__SystemVoid(long selfObjectId, void* pointPointer, void* axisPointer, float angle);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__LookAt__UnityEngineTransform__UnityEngineVector3__SystemVoid(long selfObjectId, long targetObjectId, void* worldUpPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__LookAt__UnityEngineTransform__SystemVoid(long selfObjectId, long targetObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__LookAt__UnityEngineVector3__UnityEngineVector3__SystemVoid(long selfObjectId, void* worldPositionPointer, void* worldUpPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__LookAt__UnityEngineVector3__SystemVoid(long selfObjectId, void* worldPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformDirection__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* directionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformDirection__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* directionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformDirection__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformVector__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* vectorPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformVector__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* vectorPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformVector__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__TransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineTransform__func__InverseTransformPoint__SystemSingle__SystemSingle__SystemSingle__UnityEngineVector3(long selfObjectId, float x, float y, float z, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__DetachChildren__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__SetAsFirstSibling__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__SetAsLastSibling__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTransform__func__SetSiblingIndex__SystemInt32__SystemVoid(long selfObjectId, int index);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__func__GetSiblingIndex__SystemInt32(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineTransform__func__Find__SystemString__UnityEngineTransform(long selfObjectId, void* nPointer, int nWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTransform__func__IsChildOf__UnityEngineTransform__SystemBoolean(long selfObjectId, long parentObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTransform__func__GetChild__SystemInt32__UnityEngineTransform(long selfObjectId, int index);

        #endregion Imports
    }
}
