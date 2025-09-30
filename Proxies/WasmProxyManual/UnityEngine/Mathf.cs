using UnityEngineInternal;

namespace UnityEngine;

public partial struct Mathf {
    public const float PI = 3.1415927f;

    public const float Infinity = float.PositiveInfinity;

    public const float NegativeInfinity = float.NegativeInfinity;

    public const float Deg2Rad = 0.017453292f;

    public const float Rad2Deg = 57.29578f;

    public static readonly float Epsilon = MathfInternal.IsFlushToZeroEnabled ? MathfInternal.FloatMinNormal : MathfInternal.FloatMinDenormal;
}