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

    public partial class Time(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Time()
            : this(internal_UnityEngineTime__ctor()) { }

        public static float time 
        {
            get => internal_UnityEngineTime__get__time();
        }

        public static double timeAsDouble 
        {
            get => internal_UnityEngineTime__get__timeAsDouble();
        }

        public static float timeSinceLevelLoad 
        {
            get => internal_UnityEngineTime__get__timeSinceLevelLoad();
        }

        public static double timeSinceLevelLoadAsDouble 
        {
            get => internal_UnityEngineTime__get__timeSinceLevelLoadAsDouble();
        }

        public static float deltaTime 
        {
            get => internal_UnityEngineTime__get__deltaTime();
        }

        public static float fixedTime 
        {
            get => internal_UnityEngineTime__get__fixedTime();
        }

        public static double fixedTimeAsDouble 
        {
            get => internal_UnityEngineTime__get__fixedTimeAsDouble();
        }

        public static float unscaledTime 
        {
            get => internal_UnityEngineTime__get__unscaledTime();
        }

        public static double unscaledTimeAsDouble 
        {
            get => internal_UnityEngineTime__get__unscaledTimeAsDouble();
        }

        public static float fixedUnscaledTime 
        {
            get => internal_UnityEngineTime__get__fixedUnscaledTime();
        }

        public static double fixedUnscaledTimeAsDouble 
        {
            get => internal_UnityEngineTime__get__fixedUnscaledTimeAsDouble();
        }

        public static float unscaledDeltaTime 
        {
            get => internal_UnityEngineTime__get__unscaledDeltaTime();
        }

        public static float fixedUnscaledDeltaTime 
        {
            get => internal_UnityEngineTime__get__fixedUnscaledDeltaTime();
        }

        public static float fixedDeltaTime 
        {
            get => internal_UnityEngineTime__get__fixedDeltaTime();
            set => internal_UnityEngineTime__set__fixedDeltaTime(value);
        }

        public static float maximumDeltaTime 
        {
            get => internal_UnityEngineTime__get__maximumDeltaTime();
            set => internal_UnityEngineTime__set__maximumDeltaTime(value);
        }

        public static float smoothDeltaTime 
        {
            get => internal_UnityEngineTime__get__smoothDeltaTime();
        }

        public static float maximumParticleDeltaTime 
        {
            get => internal_UnityEngineTime__get__maximumParticleDeltaTime();
            set => internal_UnityEngineTime__set__maximumParticleDeltaTime(value);
        }

        public static float timeScale 
        {
            get => internal_UnityEngineTime__get__timeScale();
            set => internal_UnityEngineTime__set__timeScale(value);
        }

        public static int frameCount 
        {
            get => internal_UnityEngineTime__get__frameCount();
        }

        public static int renderedFrameCount 
        {
            get => internal_UnityEngineTime__get__renderedFrameCount();
        }

        public static float realtimeSinceStartup 
        {
            get => internal_UnityEngineTime__get__realtimeSinceStartup();
        }

        public static double realtimeSinceStartupAsDouble 
        {
            get => internal_UnityEngineTime__get__realtimeSinceStartupAsDouble();
        }

        public static float captureDeltaTime 
        {
            get => internal_UnityEngineTime__get__captureDeltaTime();
            set => internal_UnityEngineTime__set__captureDeltaTime(value);
        }

        public static int captureFramerate 
        {
            get => internal_UnityEngineTime__get__captureFramerate();
            set => internal_UnityEngineTime__set__captureFramerate(value);
        }

        public static bool inFixedTimeStep 
        {
            get => internal_UnityEngineTime__get__inFixedTimeStep();
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineTime__ctor()
        {
            return UnityEngineTime__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__time()
        {
            var methodCallResult = UnityEngineTime__get__time();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__timeAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__timeAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__timeSinceLevelLoad()
        {
            var methodCallResult = UnityEngineTime__get__timeSinceLevelLoad();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__timeSinceLevelLoadAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__timeSinceLevelLoadAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__deltaTime()
        {
            var methodCallResult = UnityEngineTime__get__deltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__fixedTime()
        {
            var methodCallResult = UnityEngineTime__get__fixedTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__fixedTimeAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__fixedTimeAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__unscaledTime()
        {
            var methodCallResult = UnityEngineTime__get__unscaledTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__unscaledTimeAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__unscaledTimeAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__fixedUnscaledTime()
        {
            var methodCallResult = UnityEngineTime__get__fixedUnscaledTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__fixedUnscaledTimeAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__fixedUnscaledTimeAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__unscaledDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__unscaledDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__fixedUnscaledDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__fixedUnscaledDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__fixedDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__fixedDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__fixedDeltaTime(float fixedDeltaTime)
        {
            UnityEngineTime__set__fixedDeltaTime(fixedDeltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__maximumDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__maximumDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__maximumDeltaTime(float maximumDeltaTime)
        {
            UnityEngineTime__set__maximumDeltaTime(maximumDeltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__smoothDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__smoothDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__maximumParticleDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__maximumParticleDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__maximumParticleDeltaTime(float maximumParticleDeltaTime)
        {
            UnityEngineTime__set__maximumParticleDeltaTime(maximumParticleDeltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__timeScale()
        {
            var methodCallResult = UnityEngineTime__get__timeScale();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__timeScale(float timeScale)
        {
            UnityEngineTime__set__timeScale(timeScale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTime__get__frameCount()
        {
            var methodCallResult = UnityEngineTime__get__frameCount();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTime__get__renderedFrameCount()
        {
            var methodCallResult = UnityEngineTime__get__renderedFrameCount();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__realtimeSinceStartup()
        {
            var methodCallResult = UnityEngineTime__get__realtimeSinceStartup();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe double internal_UnityEngineTime__get__realtimeSinceStartupAsDouble()
        {
            var methodCallResult = UnityEngineTime__get__realtimeSinceStartupAsDouble();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineTime__get__captureDeltaTime()
        {
            var methodCallResult = UnityEngineTime__get__captureDeltaTime();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__captureDeltaTime(float captureDeltaTime)
        {
            UnityEngineTime__set__captureDeltaTime(captureDeltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineTime__get__captureFramerate()
        {
            var methodCallResult = UnityEngineTime__get__captureFramerate();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineTime__set__captureFramerate(int captureFramerate)
        {
            UnityEngineTime__set__captureFramerate(captureFramerate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineTime__get__inFixedTimeStep()
        {
            var methodCallResult = UnityEngineTime__get__inFixedTimeStep();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineTime__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__time();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__timeAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__timeSinceLevelLoad();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__timeSinceLevelLoadAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__deltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__fixedTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__fixedTimeAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__unscaledTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__unscaledTimeAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__fixedUnscaledTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__fixedUnscaledTimeAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__unscaledDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__fixedUnscaledDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__fixedDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__fixedDeltaTime(float fixedDeltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__maximumDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__maximumDeltaTime(float maximumDeltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__smoothDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__maximumParticleDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__maximumParticleDeltaTime(float maximumParticleDeltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__timeScale();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__timeScale(float timeScale);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTime__get__frameCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTime__get__renderedFrameCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__realtimeSinceStartup();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern double UnityEngineTime__get__realtimeSinceStartupAsDouble();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineTime__get__captureDeltaTime();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__captureDeltaTime(float captureDeltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTime__get__captureFramerate();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineTime__set__captureFramerate(int captureFramerate);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineTime__get__inFixedTimeStep();

        #endregion Imports
    }
}
