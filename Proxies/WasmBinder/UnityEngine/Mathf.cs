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
    public partial struct Mathf
    {

        #region Implementation

        public static int ClosestPowerOfTwo(int value)
        {
            return internal_UnityEngineMathf__func__ClosestPowerOfTwo__SystemInt32__SystemInt32(value);
        }

        public static bool IsPowerOfTwo(int value)
        {
            return internal_UnityEngineMathf__func__IsPowerOfTwo__SystemInt32__SystemBoolean(value);
        }

        public static int NextPowerOfTwo(int value)
        {
            return internal_UnityEngineMathf__func__NextPowerOfTwo__SystemInt32__SystemInt32(value);
        }

        public static float GammaToLinearSpace(float value)
        {
            return internal_UnityEngineMathf__func__GammaToLinearSpace__SystemSingle__SystemSingle(value);
        }

        public static float LinearToGammaSpace(float value)
        {
            return internal_UnityEngineMathf__func__LinearToGammaSpace__SystemSingle__SystemSingle(value);
        }

        public static global::UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin)
        {
            return internal_UnityEngineMathf__func__CorrelatedColorTemperatureToRGB__SystemSingle__UnityEngineColor(kelvin);
        }

        public static ushort FloatToHalf(float val)
        {
            return internal_UnityEngineMathf__func__FloatToHalf__SystemSingle__SystemUInt16(val);
        }

        public static float HalfToFloat(ushort val)
        {
            return internal_UnityEngineMathf__func__HalfToFloat__SystemUInt16__SystemSingle(val);
        }

        public static float PerlinNoise(float x, float y)
        {
            return internal_UnityEngineMathf__func__PerlinNoise__SystemSingle__SystemSingle__SystemSingle(x, y);
        }

        public static float Sin(float f)
        {
            return internal_UnityEngineMathf__func__Sin__SystemSingle__SystemSingle(f);
        }

        public static float Cos(float f)
        {
            return internal_UnityEngineMathf__func__Cos__SystemSingle__SystemSingle(f);
        }

        public static float Tan(float f)
        {
            return internal_UnityEngineMathf__func__Tan__SystemSingle__SystemSingle(f);
        }

        public static float Asin(float f)
        {
            return internal_UnityEngineMathf__func__Asin__SystemSingle__SystemSingle(f);
        }

        public static float Acos(float f)
        {
            return internal_UnityEngineMathf__func__Acos__SystemSingle__SystemSingle(f);
        }

        public static float Atan(float f)
        {
            return internal_UnityEngineMathf__func__Atan__SystemSingle__SystemSingle(f);
        }

        public static float Atan2(float y, float x)
        {
            return internal_UnityEngineMathf__func__Atan2__SystemSingle__SystemSingle__SystemSingle(y, x);
        }

        public static float Sqrt(float f)
        {
            return internal_UnityEngineMathf__func__Sqrt__SystemSingle__SystemSingle(f);
        }

        public static float Abs(float f)
        {
            return internal_UnityEngineMathf__func__Abs__SystemSingle__SystemSingle(f);
        }

        public static int Abs(int value)
        {
            return internal_UnityEngineMathf__func__Abs__SystemInt32__SystemInt32(value);
        }

        public static float Min(float a, float b)
        {
            return internal_UnityEngineMathf__func__Min__SystemSingle__SystemSingle__SystemSingle(a, b);
        }

        public static float Min(params global::System.Single[] values)
        {
            return internal_UnityEngineMathf__func__Min__SystemSingleArray__SystemSingle(values);
        }

        public static int Min(int a, int b)
        {
            return internal_UnityEngineMathf__func__Min__SystemInt32__SystemInt32__SystemInt32(a, b);
        }

        public static int Min(params global::System.Int32[] values)
        {
            return internal_UnityEngineMathf__func__Min__SystemInt32Array__SystemInt32(values);
        }

        public static float Max(float a, float b)
        {
            return internal_UnityEngineMathf__func__Max__SystemSingle__SystemSingle__SystemSingle(a, b);
        }

        public static float Max(params global::System.Single[] values)
        {
            return internal_UnityEngineMathf__func__Max__SystemSingleArray__SystemSingle(values);
        }

        public static int Max(int a, int b)
        {
            return internal_UnityEngineMathf__func__Max__SystemInt32__SystemInt32__SystemInt32(a, b);
        }

        public static int Max(params global::System.Int32[] values)
        {
            return internal_UnityEngineMathf__func__Max__SystemInt32Array__SystemInt32(values);
        }

        public static float Pow(float f, float p)
        {
            return internal_UnityEngineMathf__func__Pow__SystemSingle__SystemSingle__SystemSingle(f, p);
        }

        public static float Exp(float power)
        {
            return internal_UnityEngineMathf__func__Exp__SystemSingle__SystemSingle(power);
        }

        public static float Log(float f, float p)
        {
            return internal_UnityEngineMathf__func__Log__SystemSingle__SystemSingle__SystemSingle(f, p);
        }

        public static float Log(float f)
        {
            return internal_UnityEngineMathf__func__Log__SystemSingle__SystemSingle(f);
        }

        public static float Log10(float f)
        {
            return internal_UnityEngineMathf__func__Log10__SystemSingle__SystemSingle(f);
        }

        public static float Ceil(float f)
        {
            return internal_UnityEngineMathf__func__Ceil__SystemSingle__SystemSingle(f);
        }

        public static float Floor(float f)
        {
            return internal_UnityEngineMathf__func__Floor__SystemSingle__SystemSingle(f);
        }

        public static float Round(float f)
        {
            return internal_UnityEngineMathf__func__Round__SystemSingle__SystemSingle(f);
        }

        public static int CeilToInt(float f)
        {
            return internal_UnityEngineMathf__func__CeilToInt__SystemSingle__SystemInt32(f);
        }

        public static int FloorToInt(float f)
        {
            return internal_UnityEngineMathf__func__FloorToInt__SystemSingle__SystemInt32(f);
        }

        public static int RoundToInt(float f)
        {
            return internal_UnityEngineMathf__func__RoundToInt__SystemSingle__SystemInt32(f);
        }

        public static float Sign(float f)
        {
            return internal_UnityEngineMathf__func__Sign__SystemSingle__SystemSingle(f);
        }

        public static float Clamp(float value, float min, float max)
        {
            return internal_UnityEngineMathf__func__Clamp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(value, min, max);
        }

        public static int Clamp(int value, int min, int max)
        {
            return internal_UnityEngineMathf__func__Clamp__SystemInt32__SystemInt32__SystemInt32__SystemInt32(value, min, max);
        }

        public static float Clamp01(float value)
        {
            return internal_UnityEngineMathf__func__Clamp01__SystemSingle__SystemSingle(value);
        }

        public static float Lerp(float a, float b, float t)
        {
            return internal_UnityEngineMathf__func__Lerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
        }

        public static float LerpUnclamped(float a, float b, float t)
        {
            return internal_UnityEngineMathf__func__LerpUnclamped__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
        }

        public static float LerpAngle(float a, float b, float t)
        {
            return internal_UnityEngineMathf__func__LerpAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
        }

        public static float MoveTowards(float current, float target, float maxDelta)
        {
            return internal_UnityEngineMathf__func__MoveTowards__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, maxDelta);
        }

        public static float MoveTowardsAngle(float current, float target, float maxDelta)
        {
            return internal_UnityEngineMathf__func__MoveTowardsAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, maxDelta);
        }

        public static float SmoothStep(float from, float to, float t)
        {
            return internal_UnityEngineMathf__func__SmoothStep__SystemSingle__SystemSingle__SystemSingle__SystemSingle(from, to, t);
        }

        public static float Gamma(float value, float absmax, float gamma)
        {
            return internal_UnityEngineMathf__func__Gamma__SystemSingle__SystemSingle__SystemSingle__SystemSingle(value, absmax, gamma);
        }

        public static bool Approximately(float a, float b)
        {
            return internal_UnityEngineMathf__func__Approximately__SystemSingle__SystemSingle__SystemBoolean(a, b);
        }

        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            return internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime, maxSpeed);
        }

        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
        {
            return internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime);
        }

        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            return internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime, maxSpeed);
        }

        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
        {
            return internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime);
        }

        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        public static float Repeat(float t, float length)
        {
            return internal_UnityEngineMathf__func__Repeat__SystemSingle__SystemSingle__SystemSingle(t, length);
        }

        public static float PingPong(float t, float length)
        {
            return internal_UnityEngineMathf__func__PingPong__SystemSingle__SystemSingle__SystemSingle(t, length);
        }

        public static float InverseLerp(float a, float b, float value)
        {
            return internal_UnityEngineMathf__func__InverseLerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, value);
        }

        public static float DeltaAngle(float current, float target)
        {
            return internal_UnityEngineMathf__func__DeltaAngle__SystemSingle__SystemSingle__SystemSingle(current, target);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__ClosestPowerOfTwo__SystemInt32__SystemInt32(int value)
        {
            var methodCallResult = UnityEngineMathf__func__ClosestPowerOfTwo__SystemInt32__SystemInt32(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMathf__func__IsPowerOfTwo__SystemInt32__SystemBoolean(int value)
        {
            var methodCallResult = UnityEngineMathf__func__IsPowerOfTwo__SystemInt32__SystemBoolean(value);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__NextPowerOfTwo__SystemInt32__SystemInt32(int value)
        {
            var methodCallResult = UnityEngineMathf__func__NextPowerOfTwo__SystemInt32__SystemInt32(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__GammaToLinearSpace__SystemSingle__SystemSingle(float value)
        {
            var methodCallResult = UnityEngineMathf__func__GammaToLinearSpace__SystemSingle__SystemSingle(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__LinearToGammaSpace__SystemSingle__SystemSingle(float value)
        {
            var methodCallResult = UnityEngineMathf__func__LinearToGammaSpace__SystemSingle__SystemSingle(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineMathf__func__CorrelatedColorTemperatureToRGB__SystemSingle__UnityEngineColor(float kelvin)
        {
            global::UnityEngine.Color returnResultValue = default;
            UnityEngineMathf__func__CorrelatedColorTemperatureToRGB__SystemSingle__UnityEngineColor(kelvin, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Color returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ushort internal_UnityEngineMathf__func__FloatToHalf__SystemSingle__SystemUInt16(float val)
        {
            var methodCallResult = UnityEngineMathf__func__FloatToHalf__SystemSingle__SystemUInt16(val);
            var returnResult = Unsafe.As<int, ushort>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__HalfToFloat__SystemUInt16__SystemSingle(ushort val)
        {
            var valConverted = Unsafe.As<ushort, int>(ref val);
            var methodCallResult = UnityEngineMathf__func__HalfToFloat__SystemUInt16__SystemSingle(valConverted);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__PerlinNoise__SystemSingle__SystemSingle__SystemSingle(float x, float y)
        {
            var methodCallResult = UnityEngineMathf__func__PerlinNoise__SystemSingle__SystemSingle__SystemSingle(x, y);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Sin__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Sin__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Cos__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Cos__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Tan__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Tan__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Asin__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Asin__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Acos__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Acos__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Atan__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Atan__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Atan2__SystemSingle__SystemSingle__SystemSingle(float y, float x)
        {
            var methodCallResult = UnityEngineMathf__func__Atan2__SystemSingle__SystemSingle__SystemSingle(y, x);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Sqrt__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Sqrt__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Abs__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Abs__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Abs__SystemInt32__SystemInt32(int value)
        {
            var methodCallResult = UnityEngineMathf__func__Abs__SystemInt32__SystemInt32(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Min__SystemSingle__SystemSingle__SystemSingle(float a, float b)
        {
            var methodCallResult = UnityEngineMathf__func__Min__SystemSingle__SystemSingle__SystemSingle(a, b);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Min__SystemSingleArray__SystemSingle(global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                var methodCallResult = UnityEngineMathf__func__Min__SystemSingleArray__SystemSingle(valuesPointer, values.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Min__SystemInt32__SystemInt32__SystemInt32(int a, int b)
        {
            var methodCallResult = UnityEngineMathf__func__Min__SystemInt32__SystemInt32__SystemInt32(a, b);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Min__SystemInt32Array__SystemInt32(global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                var methodCallResult = UnityEngineMathf__func__Min__SystemInt32Array__SystemInt32(valuesPointer, values.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Max__SystemSingle__SystemSingle__SystemSingle(float a, float b)
        {
            var methodCallResult = UnityEngineMathf__func__Max__SystemSingle__SystemSingle__SystemSingle(a, b);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Max__SystemSingleArray__SystemSingle(global::System.Single[] values)
        {
            fixed (float* valuesPointer = values)
            {
                var methodCallResult = UnityEngineMathf__func__Max__SystemSingleArray__SystemSingle(valuesPointer, values.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Max__SystemInt32__SystemInt32__SystemInt32(int a, int b)
        {
            var methodCallResult = UnityEngineMathf__func__Max__SystemInt32__SystemInt32__SystemInt32(a, b);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Max__SystemInt32Array__SystemInt32(global::System.Int32[] values)
        {
            fixed (int* valuesPointer = values)
            {
                var methodCallResult = UnityEngineMathf__func__Max__SystemInt32Array__SystemInt32(valuesPointer, values.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Pow__SystemSingle__SystemSingle__SystemSingle(float f, float p)
        {
            var methodCallResult = UnityEngineMathf__func__Pow__SystemSingle__SystemSingle__SystemSingle(f, p);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Exp__SystemSingle__SystemSingle(float power)
        {
            var methodCallResult = UnityEngineMathf__func__Exp__SystemSingle__SystemSingle(power);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Log__SystemSingle__SystemSingle__SystemSingle(float f, float p)
        {
            var methodCallResult = UnityEngineMathf__func__Log__SystemSingle__SystemSingle__SystemSingle(f, p);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Log__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Log__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Log10__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Log10__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Ceil__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Ceil__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Floor__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Floor__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Round__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Round__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__CeilToInt__SystemSingle__SystemInt32(float f)
        {
            var methodCallResult = UnityEngineMathf__func__CeilToInt__SystemSingle__SystemInt32(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__FloorToInt__SystemSingle__SystemInt32(float f)
        {
            var methodCallResult = UnityEngineMathf__func__FloorToInt__SystemSingle__SystemInt32(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__RoundToInt__SystemSingle__SystemInt32(float f)
        {
            var methodCallResult = UnityEngineMathf__func__RoundToInt__SystemSingle__SystemInt32(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Sign__SystemSingle__SystemSingle(float f)
        {
            var methodCallResult = UnityEngineMathf__func__Sign__SystemSingle__SystemSingle(f);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Clamp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float value, float min, float max)
        {
            var methodCallResult = UnityEngineMathf__func__Clamp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(value, min, max);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineMathf__func__Clamp__SystemInt32__SystemInt32__SystemInt32__SystemInt32(int value, int min, int max)
        {
            var methodCallResult = UnityEngineMathf__func__Clamp__SystemInt32__SystemInt32__SystemInt32__SystemInt32(value, min, max);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Clamp01__SystemSingle__SystemSingle(float value)
        {
            var methodCallResult = UnityEngineMathf__func__Clamp01__SystemSingle__SystemSingle(value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Lerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t)
        {
            var methodCallResult = UnityEngineMathf__func__Lerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__LerpUnclamped__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t)
        {
            var methodCallResult = UnityEngineMathf__func__LerpUnclamped__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__LerpAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t)
        {
            var methodCallResult = UnityEngineMathf__func__LerpAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, t);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__MoveTowards__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, float maxDelta)
        {
            var methodCallResult = UnityEngineMathf__func__MoveTowards__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, maxDelta);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__MoveTowardsAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, float maxDelta)
        {
            var methodCallResult = UnityEngineMathf__func__MoveTowardsAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, maxDelta);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothStep__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float from, float to, float t)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothStep__SystemSingle__SystemSingle__SystemSingle__SystemSingle(from, to, t);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Gamma__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float value, float absmax, float gamma)
        {
            var methodCallResult = UnityEngineMathf__func__Gamma__SystemSingle__SystemSingle__SystemSingle__SystemSingle(value, absmax, gamma);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineMathf__func__Approximately__SystemSingle__SystemSingle__SystemBoolean(float a, float b)
        {
            var methodCallResult = UnityEngineMathf__func__Approximately__SystemSingle__SystemSingle__SystemBoolean(a, b);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime, maxSpeed);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime, maxSpeed, deltaTime);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime, maxSpeed);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            var methodCallResult = UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(current, target, Unsafe.AsPointer(ref currentVelocity), smoothTime, maxSpeed, deltaTime);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__Repeat__SystemSingle__SystemSingle__SystemSingle(float t, float length)
        {
            var methodCallResult = UnityEngineMathf__func__Repeat__SystemSingle__SystemSingle__SystemSingle(t, length);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__PingPong__SystemSingle__SystemSingle__SystemSingle(float t, float length)
        {
            var methodCallResult = UnityEngineMathf__func__PingPong__SystemSingle__SystemSingle__SystemSingle(t, length);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__InverseLerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float value)
        {
            var methodCallResult = UnityEngineMathf__func__InverseLerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(a, b, value);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineMathf__func__DeltaAngle__SystemSingle__SystemSingle__SystemSingle(float current, float target)
        {
            var methodCallResult = UnityEngineMathf__func__DeltaAngle__SystemSingle__SystemSingle__SystemSingle(current, target);
            var returnResult = methodCallResult;
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__ClosestPowerOfTwo__SystemInt32__SystemInt32(int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__IsPowerOfTwo__SystemInt32__SystemBoolean(int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__NextPowerOfTwo__SystemInt32__SystemInt32(int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__GammaToLinearSpace__SystemSingle__SystemSingle(float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__LinearToGammaSpace__SystemSingle__SystemSingle(float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineMathf__func__CorrelatedColorTemperatureToRGB__SystemSingle__UnityEngineColor(float kelvin, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__FloatToHalf__SystemSingle__SystemUInt16(float val);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__HalfToFloat__SystemUInt16__SystemSingle(int valConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__PerlinNoise__SystemSingle__SystemSingle__SystemSingle(float x, float y);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Sin__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Cos__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Tan__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Asin__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Acos__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Atan__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Atan2__SystemSingle__SystemSingle__SystemSingle(float y, float x);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Sqrt__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Abs__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__Abs__SystemInt32__SystemInt32(int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Min__SystemSingle__SystemSingle__SystemSingle(float a, float b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__Min__SystemSingleArray__SystemSingle(void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__Min__SystemInt32__SystemInt32__SystemInt32(int a, int b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMathf__func__Min__SystemInt32Array__SystemInt32(void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Max__SystemSingle__SystemSingle__SystemSingle(float a, float b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__Max__SystemSingleArray__SystemSingle(void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__Max__SystemInt32__SystemInt32__SystemInt32(int a, int b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineMathf__func__Max__SystemInt32Array__SystemInt32(void* valuesPointer, int valuesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Pow__SystemSingle__SystemSingle__SystemSingle(float f, float p);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Exp__SystemSingle__SystemSingle(float power);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Log__SystemSingle__SystemSingle__SystemSingle(float f, float p);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Log__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Log10__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Ceil__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Floor__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Round__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__CeilToInt__SystemSingle__SystemInt32(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__FloorToInt__SystemSingle__SystemInt32(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__RoundToInt__SystemSingle__SystemInt32(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Sign__SystemSingle__SystemSingle(float f);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Clamp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float value, float min, float max);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__Clamp__SystemInt32__SystemInt32__SystemInt32__SystemInt32(int value, int min, int max);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Clamp01__SystemSingle__SystemSingle(float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Lerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__LerpUnclamped__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__LerpAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__MoveTowards__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, float maxDelta);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__MoveTowardsAngle__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, float maxDelta);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__SmoothStep__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float from, float to, float t);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Gamma__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float value, float absmax, float gamma);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineMathf__func__Approximately__SystemSingle__SystemSingle__SystemBoolean(float a, float b);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime, float maxSpeed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDamp__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime, float maxSpeed, float deltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime, float maxSpeed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineMathf__func__SmoothDampAngle__SystemSingle__SystemSingle__SystemSingleRef__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float current, float target, void* currentVelocityPointer, float smoothTime, float maxSpeed, float deltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__Repeat__SystemSingle__SystemSingle__SystemSingle(float t, float length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__PingPong__SystemSingle__SystemSingle__SystemSingle(float t, float length);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__InverseLerp__SystemSingle__SystemSingle__SystemSingle__SystemSingle(float a, float b, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineMathf__func__DeltaAngle__SystemSingle__SystemSingle__SystemSingle(float current, float target);

        #endregion Imports
    }
}
