using System.Runtime.InteropServices;
using UnityEngine;
using WasmScripting;

namespace CVR;

public class AvatarPoint(long id) : IProxyObject {
	public long WrappedId { get; set; } = id;
	
	public Transform GetPointTransform() {
		return new(CVR_AvatarPoint_GetPointTransform(WrappedId));
	}

	public unsafe Vector3 GetPointPosition() {
		Vector3 position = new();
		CVR_AvatarPoint_GetPointPosition(WrappedId, &position);
		return position;
	}

	public unsafe Vector3 GetLocalPointPosition() {
		Vector3 position = new();
		CVR_AvatarPoint_GetLocalPointPosition(WrappedId, &position);
		return position;
	}

	public unsafe Vector3 GetRelativePointPosition() {
		Vector3 position = new();
		CVR_AvatarPoint_GetRelativePointPosition(WrappedId, &position);
		return position;
	}

	public unsafe Quaternion GetPointRotation() {
		Quaternion rotation = new();
		CVR_AvatarPoint_GetPointRotation(WrappedId, &rotation);
		return rotation;
	}

	public unsafe Quaternion GetLocalPointRotation() {
		Quaternion rotation = new();
		CVR_AvatarPoint_GetLocalPointRotation(WrappedId, &rotation);
		return rotation;
	}

	public unsafe Quaternion GetRelativePointRotation() {
		Quaternion rotation = new();
		CVR_AvatarPoint_GetRelativePointRotation(WrappedId, &rotation);
		return rotation;
	}

	public unsafe Vector3 GetPointForward() {
		Vector3 forward = new();
		CVR_AvatarPoint_GetPointForward(WrappedId, &forward);
		return forward;
	}

	public unsafe Vector3 GetPointRight() {
		Vector3 right = new();
		CVR_AvatarPoint_GetPointRight(WrappedId, &right);
		return right;
	}

	public unsafe Vector3 GetPointUp() {
		Vector3 up = new();
		CVR_AvatarPoint_GetPointUp(WrappedId, &up);
		return up;
	}

	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_AvatarPoint_GetPointTransform(long wrappedId);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetPointPosition(long wrappedId, Vector3* vectorPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetLocalPointPosition(long wrappedId, Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetRelativePointPosition(long wrappedId, Vector3* vectorPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetPointRotation(long wrappedId, Quaternion* quaternionPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetLocalPointRotation(long wrappedId, Quaternion* quaternionPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetRelativePointRotation(long wrappedId, Quaternion* quaternionPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetPointForward(long wrappedId, Vector3* vectorPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetPointRight(long wrappedId, Vector3* vectorPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_AvatarPoint_GetPointUp(long wrappedId, Vector3* vectorPtr);
}