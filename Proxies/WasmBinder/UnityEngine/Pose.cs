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
    public partial struct Pose
    {

        #region Implementation

        public Pose(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEnginePose__ctor__UnityEngineVector3__UnityEngineQuaternion(ref this, position, rotation);
        }

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Vector3 position;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        public global::UnityEngine.Quaternion rotation;

        public global::UnityEngine.Vector3 forward 
        {
            get => internal_UnityEnginePose__get__forward(ref this);
        }

        public global::UnityEngine.Vector3 right 
        {
            get => internal_UnityEnginePose__get__right(ref this);
        }

        public global::UnityEngine.Vector3 up 
        {
            get => internal_UnityEnginePose__get__up(ref this);
        }

        public static global::UnityEngine.Pose identity 
        {
            get => internal_UnityEnginePose__get__identity();
        }

        public string ToString()
        {
            return internal_UnityEnginePose__func__ToString__SystemString(ref this);
        }

        public string ToString(string format)
        {
            return internal_UnityEnginePose__func__ToString__SystemString__SystemString(ref this, format);
        }

        public global::UnityEngine.Pose GetTransformedBy(global::UnityEngine.Pose lhs)
        {
            return internal_UnityEnginePose__func__GetTransformedBy__UnityEnginePose__UnityEnginePose(ref this, lhs);
        }

        public global::UnityEngine.Pose GetTransformedBy(global::UnityEngine.Transform lhs)
        {
            return internal_UnityEnginePose__func__GetTransformedBy__UnityEngineTransform__UnityEnginePose(ref this, lhs);
        }

        public bool Equals(object obj)
        {
            return internal_UnityEnginePose__func__Equals__SystemObject__SystemBoolean(ref this, obj);
        }

        public bool Equals(global::UnityEngine.Pose other)
        {
            return internal_UnityEnginePose__func__Equals__UnityEnginePose__SystemBoolean(ref this, other);
        }

        public int GetHashCode()
        {
            return internal_UnityEnginePose__func__GetHashCode__SystemInt32(ref this);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEnginePose__ctor__UnityEngineVector3__UnityEngineQuaternion(ref global::UnityEngine.Pose selfStruct, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            UnityEnginePose__ctor__UnityEngineVector3__UnityEngineQuaternion(selfStructPointer, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePose__get__forward(ref global::UnityEngine.Pose selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 forwardValue = default;
            UnityEnginePose__get__forward(selfStructPointer, Unsafe.AsPointer(ref forwardValue));
            global::UnityEngine.Vector3 returnResult = forwardValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePose__get__right(ref global::UnityEngine.Pose selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 rightValue = default;
            UnityEnginePose__get__right(selfStructPointer, Unsafe.AsPointer(ref rightValue));
            global::UnityEngine.Vector3 returnResult = rightValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEnginePose__get__up(ref global::UnityEngine.Pose selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Vector3 upValue = default;
            UnityEnginePose__get__up(selfStructPointer, Unsafe.AsPointer(ref upValue));
            global::UnityEngine.Vector3 returnResult = upValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Pose internal_UnityEnginePose__get__identity()
        {
            global::UnityEngine.Pose identityValue = default;
            UnityEnginePose__get__identity(Unsafe.AsPointer(ref identityValue));
            global::UnityEngine.Pose returnResult = identityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePose__func__ToString__SystemString(ref global::UnityEngine.Pose selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEnginePose__func__ToString__SystemString(selfStructPointer, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEnginePose__func__ToString__SystemString__SystemString(ref global::UnityEngine.Pose selfStruct, string format)
        {
            fixed (char* formatPointer = format)
            {
                var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
                char* returnResultPointer = default;
                int returnResultWasmLength = default;
                UnityEnginePose__func__ToString__SystemString__SystemString(selfStructPointer, formatPointer, format.Length * sizeof(char), &returnResultPointer, &returnResultWasmLength);
                string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Pose internal_UnityEnginePose__func__GetTransformedBy__UnityEnginePose__UnityEnginePose(ref global::UnityEngine.Pose selfStruct, global::UnityEngine.Pose lhs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Pose returnResultValue = default;
            UnityEnginePose__func__GetTransformedBy__UnityEnginePose__UnityEnginePose(selfStructPointer, Unsafe.AsPointer(ref lhs), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Pose returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Pose internal_UnityEnginePose__func__GetTransformedBy__UnityEngineTransform__UnityEnginePose(ref global::UnityEngine.Pose selfStruct, global::UnityEngine.Transform lhs)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            global::UnityEngine.Pose returnResultValue = default;
            UnityEnginePose__func__GetTransformedBy__UnityEngineTransform__UnityEnginePose(selfStructPointer, lhs.WrappedId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Pose returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePose__func__Equals__SystemObject__SystemBoolean(ref global::UnityEngine.Pose selfStruct, object obj)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            var methodCallResult = UnityEnginePose__func__Equals__SystemObject__SystemBoolean(selfStructPointer, (obj as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEnginePose__func__Equals__UnityEnginePose__SystemBoolean(ref global::UnityEngine.Pose selfStruct, global::UnityEngine.Pose other)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePose__func__Equals__UnityEnginePose__SystemBoolean(selfStructPointer, Unsafe.AsPointer(ref other));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEnginePose__func__GetHashCode__SystemInt32(ref global::UnityEngine.Pose selfStruct)
        {
            var selfStructPointer = Unsafe.AsPointer(ref selfStruct);
            var methodCallResult = UnityEnginePose__func__GetHashCode__SystemInt32(selfStructPointer);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__ctor__UnityEngineVector3__UnityEngineQuaternion(void* selfStructPointer, void* positionPointer, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__get__forward(void* selfStructPointer, void* forwardPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__get__right(void* selfStructPointer, void* rightPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__get__up(void* selfStructPointer, void* upPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__get__identity(void* identityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__func__ToString__SystemString(void* selfStructPointer, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__func__ToString__SystemString__SystemString(void* selfStructPointer, void* formatPointer, int formatWasmLength, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__func__GetTransformedBy__UnityEnginePose__UnityEnginePose(void* selfStructPointer, void* lhsPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEnginePose__func__GetTransformedBy__UnityEngineTransform__UnityEnginePose(void* selfStructPointer, long lhsObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePose__func__Equals__SystemObject__SystemBoolean(void* selfStructPointer, long objObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePose__func__Equals__UnityEnginePose__SystemBoolean(void* selfStructPointer, void* otherPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEnginePose__func__GetHashCode__SystemInt32(void* selfStructPointer);

        #endregion Imports
    }
}
