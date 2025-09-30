using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnityEngine;

public partial struct Vector2(float x, float y) : IEquatable<Vector2>, IFormattable {
	public float x = x;

	public float y = y;

	private static readonly Vector2 zeroVector = new(0.0f, 0.0f);
	private static readonly Vector2 oneVector = new(1f, 1f);
	private static readonly Vector2 upVector = new(0.0f, 1f);
	private static readonly Vector2 downVector = new(0.0f, -1f);
	private static readonly Vector2 leftVector = new(-1f, 0.0f);
	private static readonly Vector2 rightVector = new(1f, 0.0f);
	private static readonly Vector2 positiveInfinityVector = new(float.PositiveInfinity, float.PositiveInfinity);
	private static readonly Vector2 negativeInfinityVector = new(float.NegativeInfinity, float.NegativeInfinity);
	public const float kEpsilon = 1E-05f;
	public const float kEpsilonNormalSqrt = 1E-15f;

	public float this[int index] {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get {
			switch (index) {
				case 0:
					return x;
				case 1:
					return y;
				default:
					throw new IndexOutOfRangeException("Invalid Vector2 index!");
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set {
			switch (index) {
				case 0:
					x = value;
					break;
				case 1:
					y = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector2 index!");
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY) {
		x = newX;
		y = newY;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) {
		t = Mathf.Clamp01(t);
		return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) {
		return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) {
		var num1 = target.x - current.x;
		var num2 = target.y - current.y;
		var d = (float)((double)num1 * (double)num1 + (double)num2 * (double)num2);
		if ((double)d == 0.0 || ((double)maxDistanceDelta >= 0.0 && (double)d <= (double)maxDistanceDelta * (double)maxDistanceDelta))
			return target;
		var num3 = (float)Math.Sqrt((double)d);
		return new Vector2(current.x + num1 / num3 * maxDistanceDelta, current.y + num2 / num3 * maxDistanceDelta);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Scale(Vector2 a, Vector2 b) {
		return new Vector2(a.x * b.x, a.y * b.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Scale(Vector2 scale) {
		x *= scale.x;
		y *= scale.y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Normalize() {
		var magnitude = this.magnitude;
		if ((double)magnitude > 9.999999747378752E-06)
			this = this / magnitude;
		else
			this = zero;
	}

	public Vector2 normalized {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get {
			var normalized = new Vector2(x, y);
			normalized.Normalize();
			return normalized;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode() {
		return x.GetHashCode() ^ (y.GetHashCode() << 2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other) {
		return other is Vector2 other1 && Equals(other1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector2 other) {
		return (double)x == (double)other.x && (double)y == (double)other.y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal) {
		var num = -2f * Dot(inNormal, inDirection);
		return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Perpendicular(Vector2 inDirection) {
		return new Vector2(-inDirection.y, inDirection.x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector2 lhs, Vector2 rhs) {
		return (float)((double)lhs.x * (double)rhs.x + (double)lhs.y * (double)rhs.y);
	}

	public float magnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y);
	}

	public float sqrMagnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (float)((double)x * (double)x + (double)y * (double)y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Angle(Vector2 from, Vector2 to) {
		var num = (float)Math.Sqrt((double)from.sqrMagnitude * (double)to.sqrMagnitude);
		return (double)num < 1.0000000036274937E-15 ? 0.0f : (float)Math.Acos((double)Mathf.Clamp(Dot(from, to) / num, -1f, 1f)) * 57.29578f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SignedAngle(Vector2 from, Vector2 to) {
		return Angle(from, to) * Mathf.Sign((float)((double)from.x * (double)to.y - (double)from.y * (double)to.x));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Distance(Vector2 a, Vector2 b) {
		var num1 = a.x - b.x;
		var num2 = a.y - b.y;
		return (float)Math.Sqrt((double)num1 * (double)num1 + (double)num2 * (double)num2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) {
		var sqrMagnitude = vector.sqrMagnitude;
		if ((double)sqrMagnitude <= (double)maxLength * (double)maxLength)
			return vector;
		var num1 = (float)Math.Sqrt((double)sqrMagnitude);
		var num2 = vector.x / num1;
		var num3 = vector.y / num1;
		return new Vector2(num2 * maxLength, num3 * maxLength);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector2 a) {
		return (float)((double)a.x * (double)a.x + (double)a.y * (double)a.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float SqrMagnitude() {
		return (float)((double)x * (double)x + (double)y * (double)y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) {
		return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) {
		return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 SmoothDamp(
		Vector2 current,
		Vector2 target,
		ref Vector2 currentVelocity,
		float smoothTime,
		float maxSpeed) {
		var deltaTime = Time.deltaTime;
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 SmoothDamp(
		Vector2 current,
		Vector2 target,
		ref Vector2 currentVelocity,
		float smoothTime) {
		var deltaTime = Time.deltaTime;
		var maxSpeed = float.PositiveInfinity;
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static Vector2 SmoothDamp(
		Vector2 current,
		Vector2 target,
		ref Vector2 currentVelocity,
		float smoothTime,
		[DefaultValue("Mathf.Infinity")] float maxSpeed,
		[DefaultValue("Time.deltaTime")] float deltaTime) {
		smoothTime = Mathf.Max(0.0001f, smoothTime);
		var num1 = 2f / smoothTime;
		var num2 = num1 * deltaTime;
		var num3 = (float)(1.0 / (1.0 + (double)num2 + 0.47999998927116394 * (double)num2 * (double)num2 + 0.23499999940395355 * (double)num2 * (double)num2 * (double)num2));
		var num4 = current.x - target.x;
		var num5 = current.y - target.y;
		var vector2 = target;
		var num6 = maxSpeed * smoothTime;
		var num7 = num6 * num6;
		var d = (float)((double)num4 * (double)num4 + (double)num5 * (double)num5);
		if ((double)d > (double)num7) {
			var num8 = (float)Math.Sqrt((double)d);
			num4 = num4 / num8 * num6;
			num5 = num5 / num8 * num6;
		}

		target.x = current.x - num4;
		target.y = current.y - num5;
		var num9 = (currentVelocity.x + num1 * num4) * deltaTime;
		var num10 = (currentVelocity.y + num1 * num5) * deltaTime;
		currentVelocity.x = (currentVelocity.x - num1 * num9) * num3;
		currentVelocity.y = (currentVelocity.y - num1 * num10) * num3;
		var x = target.x + (num4 + num9) * num3;
		var y = target.y + (num5 + num10) * num3;
		var num11 = vector2.x - current.x;
		var num12 = vector2.y - current.y;
		var num13 = x - vector2.x;
		var num14 = y - vector2.y;
		if ((double)num11 * (double)num13 + (double)num12 * (double)num14 > 0.0) {
			x = vector2.x;
			y = vector2.y;
			currentVelocity.x = (x - vector2.x) / deltaTime;
			currentVelocity.y = (y - vector2.y) / deltaTime;
		}

		return new Vector2(x, y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator +(Vector2 a, Vector2 b) {
		return new Vector2(a.x + b.x, a.y + b.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator -(Vector2 a, Vector2 b) {
		return new Vector2(a.x - b.x, a.y - b.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(Vector2 a, Vector2 b) {
		return new Vector2(a.x * b.x, a.y * b.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator /(Vector2 a, Vector2 b) {
		return new Vector2(a.x / b.x, a.y / b.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator -(Vector2 a) {
		return new Vector2(-a.x, -a.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(Vector2 a, float d) {
		return new Vector2(a.x * d, a.y * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(float d, Vector2 a) {
		return new Vector2(a.x * d, a.y * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator /(Vector2 a, float d) {
		return new Vector2(a.x / d, a.y / d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector2 lhs, Vector2 rhs) {
		var num1 = lhs.x - rhs.x;
		var num2 = lhs.y - rhs.y;
		return (double)num1 * (double)num1 + (double)num2 * (double)num2 < 9.999999439624929E-11;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector2 lhs, Vector2 rhs) {
		return !(lhs == rhs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector2(Vector3 v) {
		return new Vector2(v.x, v.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector3(Vector2 v) {
		return new Vector3(v.x, v.y, 0.0f);
	}

	public static Vector2 zero {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => zeroVector;
	}

	public static Vector2 one {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => oneVector;
	}

	public static Vector2 up {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => upVector;
	}

	public static Vector2 down {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => downVector;
	}

	public static Vector2 left {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => leftVector;
	}

	public static Vector2 right {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => rightVector;
	}

	public static Vector2 positiveInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => positiveInfinityVector;
	}

	public static Vector2 negativeInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => negativeInfinityVector;
	}
}