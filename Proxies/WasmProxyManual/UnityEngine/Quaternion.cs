using System.Runtime.CompilerServices;

namespace UnityEngine;
// TODO: reimplement unitys methods that are implemented internally in wasm
public partial struct Quaternion(float x, float y, float z, float w) : IEquatable<Quaternion>, IFormattable {
	public float x = x;
	public float y = y;
	public float z = z;
	public float w = w;
	
	private static readonly Quaternion identityQuaternion = new(0.0f, 0.0f, 0.0f, 1f);
	public const float kEpsilon = 1E-06f;

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
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
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
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY, float newZ, float newW) {
		x = newX;
		y = newY;
		z = newZ;
		w = newW;
	}

	public static Quaternion identity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => identityQuaternion;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion operator *(Quaternion lhs, Quaternion rhs) {
		return new Quaternion((float)((double)lhs.w * (double)rhs.x + (double)lhs.x * (double)rhs.w + (double)lhs.y * (double)rhs.z - (double)lhs.z * (double)rhs.y), (float)((double)lhs.w * (double)rhs.y + (double)lhs.y * (double)rhs.w + (double)lhs.z * (double)rhs.x - (double)lhs.x * (double)rhs.z), (float)((double)lhs.w * (double)rhs.z + (double)lhs.z * (double)rhs.w + (double)lhs.x * (double)rhs.y - (double)lhs.y * (double)rhs.x), (float)((double)lhs.w * (double)rhs.w - (double)lhs.x * (double)rhs.x - (double)lhs.y * (double)rhs.y - (double)lhs.z * (double)rhs.z));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(Quaternion rotation, Vector3 point) {
		float num1 = rotation.x * 2f;
		float num2 = rotation.y * 2f;
		float num3 = rotation.z * 2f;
		float num4 = rotation.x * num1;
		float num5 = rotation.y * num2;
		float num6 = rotation.z * num3;
		float num7 = rotation.x * num2;
		float num8 = rotation.x * num3;
		float num9 = rotation.y * num3;
		float num10 = rotation.w * num1;
		float num11 = rotation.w * num2;
		float num12 = rotation.w * num3;
		Vector3 vector3;
		vector3.x = (float)((1.0 - ((double)num5 + (double)num6)) * (double)point.x + ((double)num7 - (double)num12) * (double)point.y + ((double)num8 + (double)num11) * (double)point.z);
		vector3.y = (float)(((double)num7 + (double)num12) * (double)point.x + (1.0 - ((double)num4 + (double)num6)) * (double)point.y + ((double)num9 - (double)num10) * (double)point.z);
		vector3.z = (float)(((double)num8 - (double)num11) * (double)point.x + ((double)num9 + (double)num10) * (double)point.y + (1.0 - ((double)num4 + (double)num5)) * (double)point.z);
		return vector3;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsEqualUsingDot(float dot) {
		return (double)dot > 0.9999989867210388;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Quaternion lhs, Quaternion rhs) {
		return IsEqualUsingDot(Dot(lhs, rhs));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Quaternion lhs, Quaternion rhs) {
		return !(lhs == rhs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Quaternion a, Quaternion b) {
		return (float)((double)a.x * (double)b.x + (double)a.y * (double)b.y + (double)a.z * (double)b.z + (double)a.w * (double)b.w);
	}
}