using System.Runtime.CompilerServices;

namespace UnityEngine;

[method: MethodImpl(MethodImplOptions.AggressiveInlining)]
public partial struct Vector4(float x, float y, float z, float w) : IEquatable<Vector4>, IFormattable {
	public const float kEpsilon = 1E-05f;
	
	public float x = x;
	public float y = y;
	public float z = z;
	public float w = w;
	
	private static readonly Vector4 zeroVector = new(0.0f, 0.0f, 0.0f, 0.0f);
	private static readonly Vector4 oneVector = new(1f, 1f, 1f, 1f);
	private static readonly Vector4 positiveInfinityVector = new(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
	private static readonly Vector4 negativeInfinityVector = new(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);

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
				case 3:
					return w;
				default:
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
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
				case 3:
					w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector4(float x, float y, float z) : this(x, y, z, 0.0f) { }

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector4(float x, float y) : this(x, y, 0.0f, 0.0f) { }

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY, float newZ, float newW) {
		x = newX;
		y = newY;
		z = newZ;
		w = newW;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) {
		t = Mathf.Clamp01(t);
		return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t) {
		return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta) {
		var num1 = target.x - current.x;
		var num2 = target.y - current.y;
		var num3 = target.z - current.z;
		var num4 = target.w - current.w;
		var d = (float)((double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3 + (double)num4 * (double)num4);
		if ((double)d == 0.0 || ((double)maxDistanceDelta >= 0.0 && (double)d <= (double)maxDistanceDelta * (double)maxDistanceDelta))
			return target;
		var num5 = (float)Math.Sqrt((double)d);
		return new Vector4(current.x + num1 / num5 * maxDistanceDelta, current.y + num2 / num5 * maxDistanceDelta, current.z + num3 / num5 * maxDistanceDelta, current.w + num4 / num5 * maxDistanceDelta);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Scale(Vector4 a, Vector4 b) {
		return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Scale(Vector4 scale) {
		x *= scale.x;
		y *= scale.y;
		z *= scale.z;
		w *= scale.w;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode() {
		return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2) ^ (w.GetHashCode() >> 1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other) {
		return other is Vector4 other1 && Equals(other1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector4 other) {
		return (double)x == (double)other.x && (double)y == (double)other.y && (double)z == (double)other.z && (double)w == (double)other.w;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Normalize(Vector4 a) {
		var num = Magnitude(a);
		return (double)num > 9.999999747378752E-06 ? a / num : zero;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Normalize() {
		var num = Magnitude(this);
		if ((double)num > 9.999999747378752E-06)
			this = this / num;
		else
			this = zero;
	}

	public Vector4 normalized {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Normalize(this);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector4 a, Vector4 b) {
		return (float)((double)a.x * (double)b.x + (double)a.y * (double)b.y + (double)a.z * (double)b.z + (double)a.w * (double)b.w);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Project(Vector4 a, Vector4 b) {
		return b * (Dot(a, b) / Dot(b, b));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Distance(Vector4 a, Vector4 b) {
		return Magnitude(a - b);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Magnitude(Vector4 a) {
		return (float)Math.Sqrt((double)Dot(a, a));
	}

	public float magnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (float)Math.Sqrt((double)Dot(this, this));
	}

	public float sqrMagnitude {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Dot(this, this);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Min(Vector4 lhs, Vector4 rhs) {
		return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Max(Vector4 lhs, Vector4 rhs) {
		return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
	}

	public static Vector4 zero {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => zeroVector;
	}

	public static Vector4 one {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => oneVector;
	}

	public static Vector4 positiveInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => positiveInfinityVector;
	}

	public static Vector4 negativeInfinity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => negativeInfinityVector;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator +(Vector4 a, Vector4 b) {
		return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator -(Vector4 a, Vector4 b) {
		return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator -(Vector4 a) {
		return new Vector4(-a.x, -a.y, -a.z, -a.w);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator *(Vector4 a, float d) {
		return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator *(float d, Vector4 a) {
		return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator /(Vector4 a, float d) {
		return new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector4 lhs, Vector4 rhs) {
		var num1 = lhs.x - rhs.x;
		var num2 = lhs.y - rhs.y;
		var num3 = lhs.z - rhs.z;
		var num4 = lhs.w - rhs.w;
		return (double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3 + (double)num4 * (double)num4 < 9.999999439624929E-11;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector4 lhs, Vector4 rhs) {
		return !(lhs == rhs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector4(Vector3 v) {
		return new Vector4(v.x, v.y, v.z, 0.0f);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector3(Vector4 v) {
		return new Vector3(v.x, v.y, v.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector4(Vector2 v) {
		return new Vector4(v.x, v.y, 0.0f, 0.0f);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector2(Vector4 v) {
		return new Vector2(v.x, v.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector4 a) {
		return Dot(a, a);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float SqrMagnitude() {
		return Dot(this, this);
	}
}