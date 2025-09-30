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

    public partial class Input(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Input()
            : this(internal_UnityEngineInput__ctor()) { }

        public static bool simulateMouseWithTouches 
        {
            get => internal_UnityEngineInput__get__simulateMouseWithTouches();
            set => internal_UnityEngineInput__set__simulateMouseWithTouches(value);
        }

        public static bool anyKey 
        {
            get => internal_UnityEngineInput__get__anyKey();
        }

        public static bool anyKeyDown 
        {
            get => internal_UnityEngineInput__get__anyKeyDown();
        }

        public static string inputString 
        {
            get => internal_UnityEngineInput__get__inputString();
        }

        public static global::UnityEngine.Vector3 mousePosition 
        {
            get => internal_UnityEngineInput__get__mousePosition();
        }

        public static global::UnityEngine.Vector2 mouseScrollDelta 
        {
            get => internal_UnityEngineInput__get__mouseScrollDelta();
        }

        public static string compositionString 
        {
            get => internal_UnityEngineInput__get__compositionString();
        }

        public static bool imeIsSelected 
        {
            get => internal_UnityEngineInput__get__imeIsSelected();
        }

        public static global::UnityEngine.Vector2 compositionCursorPos 
        {
            get => internal_UnityEngineInput__get__compositionCursorPos();
            set => internal_UnityEngineInput__set__compositionCursorPos(value);
        }

        public static bool mousePresent 
        {
            get => internal_UnityEngineInput__get__mousePresent();
        }

        public static int touchCount 
        {
            get => internal_UnityEngineInput__get__touchCount();
        }

        public static bool touchPressureSupported 
        {
            get => internal_UnityEngineInput__get__touchPressureSupported();
        }

        public static bool stylusTouchSupported 
        {
            get => internal_UnityEngineInput__get__stylusTouchSupported();
        }

        public static bool touchSupported 
        {
            get => internal_UnityEngineInput__get__touchSupported();
        }

        public static bool multiTouchEnabled 
        {
            get => internal_UnityEngineInput__get__multiTouchEnabled();
            set => internal_UnityEngineInput__set__multiTouchEnabled(value);
        }

        public static global::UnityEngine.Vector3 acceleration 
        {
            get => internal_UnityEngineInput__get__acceleration();
        }

        public static bool compensateSensors 
        {
            get => internal_UnityEngineInput__get__compensateSensors();
            set => internal_UnityEngineInput__set__compensateSensors(value);
        }

        public static int accelerationEventCount 
        {
            get => internal_UnityEngineInput__get__accelerationEventCount();
        }

        public static bool backButtonLeavesApp 
        {
            get => internal_UnityEngineInput__get__backButtonLeavesApp();
            set => internal_UnityEngineInput__set__backButtonLeavesApp(value);
        }

        public static float GetAxis(string axisName)
        {
            return internal_UnityEngineInput__func__GetAxis__SystemString__SystemSingle(axisName);
        }

        public static float GetAxisRaw(string axisName)
        {
            return internal_UnityEngineInput__func__GetAxisRaw__SystemString__SystemSingle(axisName);
        }

        public static bool GetButton(string buttonName)
        {
            return internal_UnityEngineInput__func__GetButton__SystemString__SystemBoolean(buttonName);
        }

        public static bool GetButtonDown(string buttonName)
        {
            return internal_UnityEngineInput__func__GetButtonDown__SystemString__SystemBoolean(buttonName);
        }

        public static bool GetButtonUp(string buttonName)
        {
            return internal_UnityEngineInput__func__GetButtonUp__SystemString__SystemBoolean(buttonName);
        }

        public static bool GetMouseButton(int button)
        {
            return internal_UnityEngineInput__func__GetMouseButton__SystemInt32__SystemBoolean(button);
        }

        public static bool GetMouseButtonDown(int button)
        {
            return internal_UnityEngineInput__func__GetMouseButtonDown__SystemInt32__SystemBoolean(button);
        }

        public static bool GetMouseButtonUp(int button)
        {
            return internal_UnityEngineInput__func__GetMouseButtonUp__SystemInt32__SystemBoolean(button);
        }

        public static void ResetInputAxes()
        {
            internal_UnityEngineInput__func__ResetInputAxes__SystemVoid();
        }

        public static global::System.String[] GetJoystickNames()
        {
            return internal_UnityEngineInput__func__GetJoystickNames__SystemStringArray();
        }

        public static bool GetKey(global::UnityEngine.KeyCode key)
        {
            return internal_UnityEngineInput__func__GetKey__UnityEngineKeyCodeEnum__SystemBoolean(key);
        }

        public static bool GetKey(string name)
        {
            return internal_UnityEngineInput__func__GetKey__SystemString__SystemBoolean(name);
        }

        public static bool GetKeyUp(global::UnityEngine.KeyCode key)
        {
            return internal_UnityEngineInput__func__GetKeyUp__UnityEngineKeyCodeEnum__SystemBoolean(key);
        }

        public static bool GetKeyUp(string name)
        {
            return internal_UnityEngineInput__func__GetKeyUp__SystemString__SystemBoolean(name);
        }

        public static bool GetKeyDown(global::UnityEngine.KeyCode key)
        {
            return internal_UnityEngineInput__func__GetKeyDown__UnityEngineKeyCodeEnum__SystemBoolean(key);
        }

        public static bool GetKeyDown(string name)
        {
            return internal_UnityEngineInput__func__GetKeyDown__SystemString__SystemBoolean(name);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineInput__ctor()
        {
            return UnityEngineInput__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__simulateMouseWithTouches()
        {
            var methodCallResult = UnityEngineInput__get__simulateMouseWithTouches();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__set__simulateMouseWithTouches(bool simulateMouseWithTouches)
        {
            var simulateMouseWithTouchesConverted = Unsafe.As<bool, int>(ref simulateMouseWithTouches);
            UnityEngineInput__set__simulateMouseWithTouches(simulateMouseWithTouchesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__anyKey()
        {
            var methodCallResult = UnityEngineInput__get__anyKey();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__anyKeyDown()
        {
            var methodCallResult = UnityEngineInput__get__anyKeyDown();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineInput__get__inputString()
        {
            char* inputStringPointer = default;
            int inputStringWasmLength = default;
            UnityEngineInput__get__inputString(&inputStringPointer, &inputStringWasmLength);
            string returnResult = new(inputStringPointer, 0, inputStringWasmLength);
            Marshal.FreeHGlobal((IntPtr)inputStringPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineInput__get__mousePosition()
        {
            global::UnityEngine.Vector3 mousePositionValue = default;
            UnityEngineInput__get__mousePosition(Unsafe.AsPointer(ref mousePositionValue));
            global::UnityEngine.Vector3 returnResult = mousePositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineInput__get__mouseScrollDelta()
        {
            global::UnityEngine.Vector2 mouseScrollDeltaValue = default;
            UnityEngineInput__get__mouseScrollDelta(Unsafe.AsPointer(ref mouseScrollDeltaValue));
            global::UnityEngine.Vector2 returnResult = mouseScrollDeltaValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineInput__get__compositionString()
        {
            char* compositionStringPointer = default;
            int compositionStringWasmLength = default;
            UnityEngineInput__get__compositionString(&compositionStringPointer, &compositionStringWasmLength);
            string returnResult = new(compositionStringPointer, 0, compositionStringWasmLength);
            Marshal.FreeHGlobal((IntPtr)compositionStringPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__imeIsSelected()
        {
            var methodCallResult = UnityEngineInput__get__imeIsSelected();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineInput__get__compositionCursorPos()
        {
            global::UnityEngine.Vector2 compositionCursorPosValue = default;
            UnityEngineInput__get__compositionCursorPos(Unsafe.AsPointer(ref compositionCursorPosValue));
            global::UnityEngine.Vector2 returnResult = compositionCursorPosValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__set__compositionCursorPos(global::UnityEngine.Vector2 compositionCursorPos)
        {
            UnityEngineInput__set__compositionCursorPos(Unsafe.AsPointer(ref compositionCursorPos));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__mousePresent()
        {
            var methodCallResult = UnityEngineInput__get__mousePresent();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineInput__get__touchCount()
        {
            var methodCallResult = UnityEngineInput__get__touchCount();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__touchPressureSupported()
        {
            var methodCallResult = UnityEngineInput__get__touchPressureSupported();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__stylusTouchSupported()
        {
            var methodCallResult = UnityEngineInput__get__stylusTouchSupported();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__touchSupported()
        {
            var methodCallResult = UnityEngineInput__get__touchSupported();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__multiTouchEnabled()
        {
            var methodCallResult = UnityEngineInput__get__multiTouchEnabled();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__set__multiTouchEnabled(bool multiTouchEnabled)
        {
            var multiTouchEnabledConverted = Unsafe.As<bool, int>(ref multiTouchEnabled);
            UnityEngineInput__set__multiTouchEnabled(multiTouchEnabledConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineInput__get__acceleration()
        {
            global::UnityEngine.Vector3 accelerationValue = default;
            UnityEngineInput__get__acceleration(Unsafe.AsPointer(ref accelerationValue));
            global::UnityEngine.Vector3 returnResult = accelerationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__compensateSensors()
        {
            var methodCallResult = UnityEngineInput__get__compensateSensors();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__set__compensateSensors(bool compensateSensors)
        {
            var compensateSensorsConverted = Unsafe.As<bool, int>(ref compensateSensors);
            UnityEngineInput__set__compensateSensors(compensateSensorsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineInput__get__accelerationEventCount()
        {
            var methodCallResult = UnityEngineInput__get__accelerationEventCount();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__get__backButtonLeavesApp()
        {
            var methodCallResult = UnityEngineInput__get__backButtonLeavesApp();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__set__backButtonLeavesApp(bool backButtonLeavesApp)
        {
            var backButtonLeavesAppConverted = Unsafe.As<bool, int>(ref backButtonLeavesApp);
            UnityEngineInput__set__backButtonLeavesApp(backButtonLeavesAppConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineInput__func__GetAxis__SystemString__SystemSingle(string axisName)
        {
            fixed (char* axisNamePointer = axisName)
            {
                var methodCallResult = UnityEngineInput__func__GetAxis__SystemString__SystemSingle(axisNamePointer, axisName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineInput__func__GetAxisRaw__SystemString__SystemSingle(string axisName)
        {
            fixed (char* axisNamePointer = axisName)
            {
                var methodCallResult = UnityEngineInput__func__GetAxisRaw__SystemString__SystemSingle(axisNamePointer, axisName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetButton__SystemString__SystemBoolean(string buttonName)
        {
            fixed (char* buttonNamePointer = buttonName)
            {
                var methodCallResult = UnityEngineInput__func__GetButton__SystemString__SystemBoolean(buttonNamePointer, buttonName.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetButtonDown__SystemString__SystemBoolean(string buttonName)
        {
            fixed (char* buttonNamePointer = buttonName)
            {
                var methodCallResult = UnityEngineInput__func__GetButtonDown__SystemString__SystemBoolean(buttonNamePointer, buttonName.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetButtonUp__SystemString__SystemBoolean(string buttonName)
        {
            fixed (char* buttonNamePointer = buttonName)
            {
                var methodCallResult = UnityEngineInput__func__GetButtonUp__SystemString__SystemBoolean(buttonNamePointer, buttonName.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetMouseButton__SystemInt32__SystemBoolean(int button)
        {
            var methodCallResult = UnityEngineInput__func__GetMouseButton__SystemInt32__SystemBoolean(button);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetMouseButtonDown__SystemInt32__SystemBoolean(int button)
        {
            var methodCallResult = UnityEngineInput__func__GetMouseButtonDown__SystemInt32__SystemBoolean(button);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetMouseButtonUp__SystemInt32__SystemBoolean(int button)
        {
            var methodCallResult = UnityEngineInput__func__GetMouseButtonUp__SystemInt32__SystemBoolean(button);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineInput__func__ResetInputAxes__SystemVoid()
        {
            UnityEngineInput__func__ResetInputAxes__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.String[] internal_UnityEngineInput__func__GetJoystickNames__SystemStringArray()
        {
            // Exterrata: I would really like to put returnResultPointer first instead of returnResultWasmLengthsPointer in the call parameters, but somehow if i do that it will always be 0...
            int* returnResultWasmLengthsPointer = default;
            char** returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineInput__func__GetJoystickNames__SystemStringArray(&returnResultWasmLengthsPointer, &returnResultPointer, &returnResultWasmLength);

            // The changes were written to the pointers directly, we need to write to the array and free allocations
            var returnResultAux = new string[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResultAux[i] = new string(returnResultPointer![i], 0, returnResultWasmLengthsPointer![i]);
                Marshal.FreeHGlobal((IntPtr)returnResultPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            Marshal.FreeHGlobal((IntPtr)returnResultWasmLengthsPointer);
            var returnResult = returnResultAux;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKey__UnityEngineKeyCodeEnum__SystemBoolean(global::UnityEngine.KeyCode key)
        {
            var methodCallResult = UnityEngineInput__func__GetKey__UnityEngineKeyCodeEnum__SystemBoolean((int) key);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKey__SystemString__SystemBoolean(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineInput__func__GetKey__SystemString__SystemBoolean(namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKeyUp__UnityEngineKeyCodeEnum__SystemBoolean(global::UnityEngine.KeyCode key)
        {
            var methodCallResult = UnityEngineInput__func__GetKeyUp__UnityEngineKeyCodeEnum__SystemBoolean((int) key);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKeyUp__SystemString__SystemBoolean(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineInput__func__GetKeyUp__SystemString__SystemBoolean(namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKeyDown__UnityEngineKeyCodeEnum__SystemBoolean(global::UnityEngine.KeyCode key)
        {
            var methodCallResult = UnityEngineInput__func__GetKeyDown__UnityEngineKeyCodeEnum__SystemBoolean((int) key);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineInput__func__GetKeyDown__SystemString__SystemBoolean(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineInput__func__GetKeyDown__SystemString__SystemBoolean(namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineInput__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__simulateMouseWithTouches();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineInput__set__simulateMouseWithTouches(int simulateMouseWithTouchesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__anyKey();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__anyKeyDown();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__inputString(void* inputStringPointer, void* inputStringWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__mousePosition(void* mousePositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__mouseScrollDelta(void* mouseScrollDeltaPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__compositionString(void* compositionStringPointer, void* compositionStringWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__imeIsSelected();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__compositionCursorPos(void* compositionCursorPosPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__set__compositionCursorPos(void* compositionCursorPosPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__mousePresent();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__touchCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__touchPressureSupported();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__stylusTouchSupported();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__touchSupported();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__multiTouchEnabled();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineInput__set__multiTouchEnabled(int multiTouchEnabledConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__get__acceleration(void* accelerationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__compensateSensors();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineInput__set__compensateSensors(int compensateSensorsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__accelerationEventCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__get__backButtonLeavesApp();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineInput__set__backButtonLeavesApp(int backButtonLeavesAppConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineInput__func__GetAxis__SystemString__SystemSingle(void* axisNamePointer, int axisNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineInput__func__GetAxisRaw__SystemString__SystemSingle(void* axisNamePointer, int axisNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetButton__SystemString__SystemBoolean(void* buttonNamePointer, int buttonNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetButtonDown__SystemString__SystemBoolean(void* buttonNamePointer, int buttonNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetButtonUp__SystemString__SystemBoolean(void* buttonNamePointer, int buttonNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetMouseButton__SystemInt32__SystemBoolean(int button);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetMouseButtonDown__SystemInt32__SystemBoolean(int button);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetMouseButtonUp__SystemInt32__SystemBoolean(int button);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineInput__func__ResetInputAxes__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineInput__func__GetJoystickNames__SystemStringArray(void* returnResultWasmLengthsPointer, void* returnResultPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetKey__UnityEngineKeyCodeEnum__SystemBoolean(int keyUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetKey__SystemString__SystemBoolean(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetKeyUp__UnityEngineKeyCodeEnum__SystemBoolean(int keyUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetKeyUp__SystemString__SystemBoolean(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineInput__func__GetKeyDown__UnityEngineKeyCodeEnum__SystemBoolean(int keyUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineInput__func__GetKeyDown__SystemString__SystemBoolean(void* namePointer, int nameWasmLength);

        #endregion Imports
    }
}
