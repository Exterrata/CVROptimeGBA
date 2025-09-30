using System.Runtime.CompilerServices;

namespace UnityEngine;
// TODO: reimplement unitys methods that are implemented internally in wasm
public partial struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable {
	public float m00;
	public float m10;
	public float m20;
	public float m30;
	public float m01;
	public float m11;
	public float m21;
	public float m31;
	public float m02;
	public float m12;
	public float m22;
	public float m32;
	public float m03;
	public float m13;
	public float m23;
	public float m33;
	private static readonly Matrix4x4 zeroMatrix = new(new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
	private static readonly Matrix4x4 identityMatrix = new(new Vector4(1f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 1f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 1f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 1f));

	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) {
		m00 = column0.x;
		m01 = column1.x;
		m02 = column2.x;
		m03 = column3.x;
		m10 = column0.y;
		m11 = column1.y;
		m12 = column2.y;
		m13 = column3.y;
		m20 = column0.z;
		m21 = column1.z;
		m22 = column2.z;
		m23 = column3.z;
		m30 = column0.w;
		m31 = column1.w;
		m32 = column2.w;
		m33 = column3.w;
	}

	public float this[int row, int column] {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => this[row + column * 4];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => this[row + column * 4] = value;
	}

	public float this[int index] {
		get {
			switch (index) {
				case 0:
					return m00;
				case 1:
					return m10;
				case 2:
					return m20;
				case 3:
					return m30;
				case 4:
					return m01;
				case 5:
					return m11;
				case 6:
					return m21;
				case 7:
					return m31;
				case 8:
					return m02;
				case 9:
					return m12;
				case 10:
					return m22;
				case 11:
					return m32;
				case 12:
					return m03;
				case 13:
					return m13;
				case 14:
					return m23;
				case 15:
					return m33;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
			}
		}
		set {
			switch (index) {
				case 0:
					m00 = value;
					break;
				case 1:
					m10 = value;
					break;
				case 2:
					m20 = value;
					break;
				case 3:
					m30 = value;
					break;
				case 4:
					m01 = value;
					break;
				case 5:
					m11 = value;
					break;
				case 6:
					m21 = value;
					break;
				case 7:
					m31 = value;
					break;
				case 8:
					m02 = value;
					break;
				case 9:
					m12 = value;
					break;
				case 10:
					m22 = value;
					break;
				case 11:
					m32 = value;
					break;
				case 12:
					m03 = value;
					break;
				case 13:
					m13 = value;
					break;
				case 14:
					m23 = value;
					break;
				case 15:
					m33 = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode() {
		Vector4 column = GetColumn(0);
		int hashCode = column.GetHashCode();
		column = GetColumn(1);
		int num1 = column.GetHashCode() << 2;
		int num2 = hashCode ^ num1;
		column = GetColumn(2);
		int num3 = column.GetHashCode() >> 2;
		int num4 = num2 ^ num3;
		column = GetColumn(3);
		int num5 = column.GetHashCode() >> 1;
		return num4 ^ num5;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other) {
		return other is Matrix4x4 other1 && Equals(other1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Matrix4x4 other) {
		Vector4 column = GetColumn(0);
		if (column.Equals(other.GetColumn(0))) {
			column = GetColumn(1);
			if (column.Equals(other.GetColumn(1))) {
				column = GetColumn(2);
				if (column.Equals(other.GetColumn(2))) {
					column = GetColumn(3);
					return column.Equals(other.GetColumn(3));
				}
			}
		}

		return false;
	}

	public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) {
		Matrix4x4 matrix4x4;
		matrix4x4.m00 = (float)((double)lhs.m00 * (double)rhs.m00 + (double)lhs.m01 * (double)rhs.m10 + (double)lhs.m02 * (double)rhs.m20 + (double)lhs.m03 * (double)rhs.m30);
		matrix4x4.m01 = (float)((double)lhs.m00 * (double)rhs.m01 + (double)lhs.m01 * (double)rhs.m11 + (double)lhs.m02 * (double)rhs.m21 + (double)lhs.m03 * (double)rhs.m31);
		matrix4x4.m02 = (float)((double)lhs.m00 * (double)rhs.m02 + (double)lhs.m01 * (double)rhs.m12 + (double)lhs.m02 * (double)rhs.m22 + (double)lhs.m03 * (double)rhs.m32);
		matrix4x4.m03 = (float)((double)lhs.m00 * (double)rhs.m03 + (double)lhs.m01 * (double)rhs.m13 + (double)lhs.m02 * (double)rhs.m23 + (double)lhs.m03 * (double)rhs.m33);
		matrix4x4.m10 = (float)((double)lhs.m10 * (double)rhs.m00 + (double)lhs.m11 * (double)rhs.m10 + (double)lhs.m12 * (double)rhs.m20 + (double)lhs.m13 * (double)rhs.m30);
		matrix4x4.m11 = (float)((double)lhs.m10 * (double)rhs.m01 + (double)lhs.m11 * (double)rhs.m11 + (double)lhs.m12 * (double)rhs.m21 + (double)lhs.m13 * (double)rhs.m31);
		matrix4x4.m12 = (float)((double)lhs.m10 * (double)rhs.m02 + (double)lhs.m11 * (double)rhs.m12 + (double)lhs.m12 * (double)rhs.m22 + (double)lhs.m13 * (double)rhs.m32);
		matrix4x4.m13 = (float)((double)lhs.m10 * (double)rhs.m03 + (double)lhs.m11 * (double)rhs.m13 + (double)lhs.m12 * (double)rhs.m23 + (double)lhs.m13 * (double)rhs.m33);
		matrix4x4.m20 = (float)((double)lhs.m20 * (double)rhs.m00 + (double)lhs.m21 * (double)rhs.m10 + (double)lhs.m22 * (double)rhs.m20 + (double)lhs.m23 * (double)rhs.m30);
		matrix4x4.m21 = (float)((double)lhs.m20 * (double)rhs.m01 + (double)lhs.m21 * (double)rhs.m11 + (double)lhs.m22 * (double)rhs.m21 + (double)lhs.m23 * (double)rhs.m31);
		matrix4x4.m22 = (float)((double)lhs.m20 * (double)rhs.m02 + (double)lhs.m21 * (double)rhs.m12 + (double)lhs.m22 * (double)rhs.m22 + (double)lhs.m23 * (double)rhs.m32);
		matrix4x4.m23 = (float)((double)lhs.m20 * (double)rhs.m03 + (double)lhs.m21 * (double)rhs.m13 + (double)lhs.m22 * (double)rhs.m23 + (double)lhs.m23 * (double)rhs.m33);
		matrix4x4.m30 = (float)((double)lhs.m30 * (double)rhs.m00 + (double)lhs.m31 * (double)rhs.m10 + (double)lhs.m32 * (double)rhs.m20 + (double)lhs.m33 * (double)rhs.m30);
		matrix4x4.m31 = (float)((double)lhs.m30 * (double)rhs.m01 + (double)lhs.m31 * (double)rhs.m11 + (double)lhs.m32 * (double)rhs.m21 + (double)lhs.m33 * (double)rhs.m31);
		matrix4x4.m32 = (float)((double)lhs.m30 * (double)rhs.m02 + (double)lhs.m31 * (double)rhs.m12 + (double)lhs.m32 * (double)rhs.m22 + (double)lhs.m33 * (double)rhs.m32);
		matrix4x4.m33 = (float)((double)lhs.m30 * (double)rhs.m03 + (double)lhs.m31 * (double)rhs.m13 + (double)lhs.m32 * (double)rhs.m23 + (double)lhs.m33 * (double)rhs.m33);
		return matrix4x4;
	}

	public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector) {
		Vector4 vector4;
		vector4.x = (float)((double)lhs.m00 * (double)vector.x + (double)lhs.m01 * (double)vector.y + (double)lhs.m02 * (double)vector.z + (double)lhs.m03 * (double)vector.w);
		vector4.y = (float)((double)lhs.m10 * (double)vector.x + (double)lhs.m11 * (double)vector.y + (double)lhs.m12 * (double)vector.z + (double)lhs.m13 * (double)vector.w);
		vector4.z = (float)((double)lhs.m20 * (double)vector.x + (double)lhs.m21 * (double)vector.y + (double)lhs.m22 * (double)vector.z + (double)lhs.m23 * (double)vector.w);
		vector4.w = (float)((double)lhs.m30 * (double)vector.x + (double)lhs.m31 * (double)vector.y + (double)lhs.m32 * (double)vector.z + (double)lhs.m33 * (double)vector.w);
		return vector4;
	}

	public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs) {
		return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
	}

	public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs) {
		return !(lhs == rhs);
	}

	public Vector4 GetColumn(int index) {
		switch (index) {
			case 0:
				return new Vector4(m00, m10, m20, m30);
			case 1:
				return new Vector4(m01, m11, m21, m31);
			case 2:
				return new Vector4(m02, m12, m22, m32);
			case 3:
				return new Vector4(m03, m13, m23, m33);
			default:
				throw new IndexOutOfRangeException("Invalid column index!");
		}
	}

	public Vector4 GetRow(int index) {
		switch (index) {
			case 0:
				return new Vector4(m00, m01, m02, m03);
			case 1:
				return new Vector4(m10, m11, m12, m13);
			case 2:
				return new Vector4(m20, m21, m22, m23);
			case 3:
				return new Vector4(m30, m31, m32, m33);
			default:
				throw new IndexOutOfRangeException("Invalid row index!");
		}
	}

	public Vector3 GetPosition() {
		return new Vector3(m03, m13, m23);
	}

	public void SetColumn(int index, Vector4 column) {
		this[0, index] = column.x;
		this[1, index] = column.y;
		this[2, index] = column.z;
		this[3, index] = column.w;
	}

	public void SetRow(int index, Vector4 row) {
		this[index, 0] = row.x;
		this[index, 1] = row.y;
		this[index, 2] = row.z;
		this[index, 3] = row.w;
	}

	public Vector3 MultiplyPoint(Vector3 point) {
		Vector3 vector3;
		vector3.x = (float)((double)m00 * (double)point.x + (double)m01 * (double)point.y + (double)m02 * (double)point.z) + m03;
		vector3.y = (float)((double)m10 * (double)point.x + (double)m11 * (double)point.y + (double)m12 * (double)point.z) + m13;
		vector3.z = (float)((double)m20 * (double)point.x + (double)m21 * (double)point.y + (double)m22 * (double)point.z) + m23;
		float num = 1f / ((float)((double)m30 * (double)point.x + (double)m31 * (double)point.y + (double)m32 * (double)point.z) + m33);
		vector3.x *= num;
		vector3.y *= num;
		vector3.z *= num;
		return vector3;
	}

	public Vector3 MultiplyPoint3x4(Vector3 point) {
		Vector3 vector3;
		vector3.x = (float)((double)m00 * (double)point.x + (double)m01 * (double)point.y + (double)m02 * (double)point.z) + m03;
		vector3.y = (float)((double)m10 * (double)point.x + (double)m11 * (double)point.y + (double)m12 * (double)point.z) + m13;
		vector3.z = (float)((double)m20 * (double)point.x + (double)m21 * (double)point.y + (double)m22 * (double)point.z) + m23;
		return vector3;
	}

	public Vector3 MultiplyVector(Vector3 vector) {
		Vector3 vector3;
		vector3.x = (float)((double)m00 * (double)vector.x + (double)m01 * (double)vector.y + (double)m02 * (double)vector.z);
		vector3.y = (float)((double)m10 * (double)vector.x + (double)m11 * (double)vector.y + (double)m12 * (double)vector.z);
		vector3.z = (float)((double)m20 * (double)vector.x + (double)m21 * (double)vector.y + (double)m22 * (double)vector.z);
		return vector3;
	}

	public Plane TransformPlane(Plane plane) {
		Matrix4x4 inverse = this.inverse;
		float x = plane.normal.x;
		float y = plane.normal.y;
		float z = plane.normal.z;
		float distance = plane.distance;
		return new Plane(new Vector3((float)((double)inverse.m00 * (double)x + (double)inverse.m10 * (double)y + (double)inverse.m20 * (double)z + (double)inverse.m30 * (double)distance), (float)((double)inverse.m01 * (double)x + (double)inverse.m11 * (double)y + (double)inverse.m21 * (double)z + (double)inverse.m31 * (double)distance), (float)((double)inverse.m02 * (double)x + (double)inverse.m12 * (double)y + (double)inverse.m22 * (double)z + (double)inverse.m32 * (double)distance)), (float)((double)inverse.m03 * (double)x + (double)inverse.m13 * (double)y + (double)inverse.m23 * (double)z + (double)inverse.m33 * (double)distance));
	}

	public static Matrix4x4 Scale(Vector3 vector) {
		Matrix4x4 matrix4x4;
		matrix4x4.m00 = vector.x;
		matrix4x4.m01 = 0.0f;
		matrix4x4.m02 = 0.0f;
		matrix4x4.m03 = 0.0f;
		matrix4x4.m10 = 0.0f;
		matrix4x4.m11 = vector.y;
		matrix4x4.m12 = 0.0f;
		matrix4x4.m13 = 0.0f;
		matrix4x4.m20 = 0.0f;
		matrix4x4.m21 = 0.0f;
		matrix4x4.m22 = vector.z;
		matrix4x4.m23 = 0.0f;
		matrix4x4.m30 = 0.0f;
		matrix4x4.m31 = 0.0f;
		matrix4x4.m32 = 0.0f;
		matrix4x4.m33 = 1f;
		return matrix4x4;
	}

	public static Matrix4x4 Translate(Vector3 vector) {
		Matrix4x4 matrix4x4;
		matrix4x4.m00 = 1f;
		matrix4x4.m01 = 0.0f;
		matrix4x4.m02 = 0.0f;
		matrix4x4.m03 = vector.x;
		matrix4x4.m10 = 0.0f;
		matrix4x4.m11 = 1f;
		matrix4x4.m12 = 0.0f;
		matrix4x4.m13 = vector.y;
		matrix4x4.m20 = 0.0f;
		matrix4x4.m21 = 0.0f;
		matrix4x4.m22 = 1f;
		matrix4x4.m23 = vector.z;
		matrix4x4.m30 = 0.0f;
		matrix4x4.m31 = 0.0f;
		matrix4x4.m32 = 0.0f;
		matrix4x4.m33 = 1f;
		return matrix4x4;
	}

	public static Matrix4x4 Rotate(Quaternion q) {
		float num1 = q.x * 2f;
		float num2 = q.y * 2f;
		float num3 = q.z * 2f;
		float num4 = q.x * num1;
		float num5 = q.y * num2;
		float num6 = q.z * num3;
		float num7 = q.x * num2;
		float num8 = q.x * num3;
		float num9 = q.y * num3;
		float num10 = q.w * num1;
		float num11 = q.w * num2;
		float num12 = q.w * num3;
		Matrix4x4 matrix4x4;
		matrix4x4.m00 = (float)(1.0 - ((double)num5 + (double)num6));
		matrix4x4.m10 = num7 + num12;
		matrix4x4.m20 = num8 - num11;
		matrix4x4.m30 = 0.0f;
		matrix4x4.m01 = num7 - num12;
		matrix4x4.m11 = (float)(1.0 - ((double)num4 + (double)num6));
		matrix4x4.m21 = num9 + num10;
		matrix4x4.m31 = 0.0f;
		matrix4x4.m02 = num8 + num11;
		matrix4x4.m12 = num9 - num10;
		matrix4x4.m22 = (float)(1.0 - ((double)num4 + (double)num5));
		matrix4x4.m32 = 0.0f;
		matrix4x4.m03 = 0.0f;
		matrix4x4.m13 = 0.0f;
		matrix4x4.m23 = 0.0f;
		matrix4x4.m33 = 1f;
		return matrix4x4;
	}

	public static Matrix4x4 zero {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => zeroMatrix;
	}

	public static Matrix4x4 identity {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => identityMatrix;
	}
}