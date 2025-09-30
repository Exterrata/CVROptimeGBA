using System.Runtime.CompilerServices;

namespace UnityEngine;
// TODO: reimplement unitys methods that are implemented internally in wasm
public partial struct Vector3(float x, float y, float z) : IEquatable<Vector3>, IFormattable {
	public const float kEpsilon = 1E-05f;
	public const float kEpsilonNormalSqrt = 1E-15f;

	private static readonly Vector3 zeroVector = new(0.0f, 0.0f, 0.0f);
	private static readonly Vector3 oneVector = new(1f, 1f, 1f);
	private static readonly Vector3 upVector = new(0.0f, 1f, 0.0f);
	private static readonly Vector3 downVector = new(0.0f, -1f, 0.0f);
	private static readonly Vector3 leftVector = new(-1f, 0.0f, 0.0f);
	private static readonly Vector3 rightVector = new(1f, 0.0f, 0.0f);
	private static readonly Vector3 forwardVector = new(0.0f, 0.0f, 1f);
	private static readonly Vector3 backVector = new(0.0f, 0.0f, -1f);
	private static readonly Vector3 positiveInfinityVector = new(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
	private static readonly Vector3 negativeInfinityVector = new(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
	
	public float x = x;

	public float y = y;

	public float z = z;

	public Vector3(float x, float y) : this(x, y, 0.0f) { }

	public Vector3() : this(0.0f, 0.0f, 0.0f) { }

	public void Set(float newX, float newY, float newZ) {
		x = newX;
		y = newY;
		z = newZ;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
		t = Mathf.Clamp01(t);
		return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) {
		return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) {
		var num1 = target.x - current.x;
		var num2 = target.y - current.y;
		var num3 = target.z - current.z;
		var d = (float)((double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3);
		if ((double)d == 0.0 || ((double)maxDistanceDelta >= 0.0 && (double)d <= (double)maxDistanceDelta * (double)maxDistanceDelta))
			return target;
		var num4 = (float)Math.Sqrt((double)d);
		return new Vector3(current.x + num1 / num4 * maxDistanceDelta, current.y + num2 / num4 * maxDistanceDelta, current.z + num3 / num4 * maxDistanceDelta);
	}

	public float this[int index] {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get {
			switch (index) {
				case 0:
					return x;
				case 1:
					return y;
				case 2:
					return z;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
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
				case 2:
					z = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Scale(Vector3 a, Vector3 b) {
		return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Scale(Vector3 scale) {
		x *= scale.x;
		y *= scale.y;
		z *= scale.z;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) {
		return new Vector3((float)((double)lhs.y * (double)rhs.z - (double)lhs.z * (double)rhs.y), (float)((double)lhs.z * (double)rhs.x - (double)lhs.x * (double)rhs.z), (float)((double)lhs.x * (double)rhs.y - (double)lhs.y * (double)rhs.x));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode() {
		return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other) {
		return other is Vector3 other1 && Equals(other1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3 other) {
		return (double)x == (double)other.x && (double)y == (double)other.y && (double)z == (double)other.z;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) {
		var num = -2f * Dot(inNormal, inDirection);
		return new Vector3(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y, num * inNormal.z + inDirection.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Normalize(Vector3 value) {
		var num = Magnitude(value);
		return (double)num > 9.999999747378752E-06 ? value / num : zero;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Normalize() {
		var num = Magnitude(this);
		if ((double)num > 9.999999747378752E-06)
			this = this / num;
		else
			this = zero;
	}

	public Vector3 normalized {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Normalize(this);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector3 lhs, Vector3 rhs) {
		return (float)((double)lhs.x * (double)rhs.x + (double)lhs.y * (double)rhs.y + (double)lhs.z * (double)rhs.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) {
		var num1 = Dot(onNormal, onNormal);
		if ((double)num1 < (double)Mathf.Epsilon)
			return zero;
		var num2 = Dot(vector, onNormal);
		return new Vector3(onNormal.x * num2 / num1, onNormal.y * num2 / num1, onNormal.z * num2 / num1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) {
		var num1 = Dot(planeNormal, planeNormal);
		if ((double)num1 < (double)Mathf.Epsilon)
			return vector;
		var num2 = Dot(vector, planeNormal);
		return new Vector3(vector.x - planeNormal.x * num2 / num1, vector.y - planeNormal.y * num2 / num1, vector.z - planeNormal.z * num2 / num1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Angle(Vector3 from, Vector3 to) {
		var num = (float)Math.Sqrt((double)from.sqrMagnitude * (double)to.sqrMagnitude);
		return (double)num < 1.0000000036274937E-15 ? 0.0f : (float)Math.Acos((double)Mathf.Clamp(Dot(from, to) / num, -1f, 1f)) * 57.29578f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) {
		var num1 = Angle(from, to);
		var num2 = (float)((double)from.y * (double)to.z - (double)from.z * (double)to.y);
		var num3 = (float)((double)from.z * (double)to.x - (double)from.x * (double)to.z);
		var num4 = (float)((double)from.x * (double)to.y - (double)from.y * (double)to.x);
		var num5 = Mathf.Sign((float)((double)axis.x * (double)num2 + (double)axis.y * (double)num3 + (double)axis.z * (double)num4));
		return num1 * num5;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Distance(Vector3 a, Vector3 b) {
		var num1 = a.x - b.x;
		var num2 = a.y - b.y;
		var num3 = a.z - b.z;
		return (float)Math.Sqrt((double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) {
		var sqrMagnitude = vector.sqrMagnitude;
		if ((double)sqrMagnitude <= (double)maxLength * (double)maxLength)
			return vector;
		var num1 = (float)Math.Sqrt((double)sqrMagnitude);
		var num2 = vector.x / num1;
		var num3 = vector.y / num1;
		var num4 = vector.z / num1;
		return new Vector3(num2 * maxLength, num3 * maxLength, num4 * maxLength);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Magnitude(Vector3 vector) {
		return (float)Math.Sqrt((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y + (double)vector.z * (double)vector.z);
	}

	public float magnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y + (double)z * (double)z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector3 vector) {
		return (float)((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y + (double)vector.z * (double)vector.z);
	}

	public float sqrMagnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (float)((double)x * (double)x + (double)y * (double)y + (double)z * (double)z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) {
		return new Vector3(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) {
		return new Vector3(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));
	}

	public static Vector3 zero {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => zeroVector;
	}

	public static Vector3 one {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => oneVector;
	}

	public static Vector3 forward {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => forwardVector;
	}

	public static Vector3 back {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => backVector;
	}

	public static Vector3 up {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => upVector;
	}

	public static Vector3 down {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => downVector;
	}

	public static Vector3 left {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => leftVector;
	}

	public static Vector3 right {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => rightVector;
	}

	public static Vector3 positiveInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => positiveInfinityVector;
	}

	public static Vector3 negativeInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => negativeInfinityVector;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator +(Vector3 a, Vector3 b) {
		return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator -(Vector3 a, Vector3 b) {
		return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator -(Vector3 a) {
		return new Vector3(-a.x, -a.y, -a.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(Vector3 a, float d) {
		return new Vector3(a.x * d, a.y * d, a.z * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(float d, Vector3 a) {
		return new Vector3(a.x * d, a.y * d, a.z * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator /(Vector3 a, float d) {
		return new Vector3(a.x / d, a.y / d, a.z / d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3 lhs, Vector3 rhs) {
		var num1 = lhs.x - rhs.x;
		var num2 = lhs.y - rhs.y;
		var num3 = lhs.z - rhs.z;
		return (double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3 < 9.999999439624929E-11;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector3 lhs, Vector3 rhs) {
		return !(lhs == rhs);
	}
}