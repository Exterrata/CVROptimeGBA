using System.Runtime.InteropServices;
using UnityEngine;

namespace CVR;

public static class LocalPlayer {
	public static Player PlayerObject => new(CVR_LocalPlayer_PlayerObject());

	public static float GetPlaySpaceScale() {
		return CVR_LocalPlayer_GetPlaySpaceScale();
	}

	public static unsafe Vector3 GetPlaySpaceOffset() {
		Vector3 playspaceOffset = new();
		CVR_LocalPlayer_GetPlaySpaceOffset(&playspaceOffset);
		return playspaceOffset;
	}

	public static unsafe Vector3 GetPosition() {
		Vector3 position = new();
		CVR_LocalPlayer_GetPosition(&position);
		return position;
	}

	public static unsafe void SetPosition(Vector3 position) {
		CVR_LocalPlayer_SetPosition(&position);
	}

	public static unsafe Quaternion GetRotation() {
		Quaternion rotation = new();
		CVR_LocalPlayer_GetRotation(&rotation);
		return rotation;
	}
	
	public static unsafe void SetRotation(Quaternion rotation) {
		CVR_LocalPlayer_SetRotation(&rotation);
	}

	public static unsafe void OffsetBy(Vector3 position) {
		CVR_LocalPlayer_OffsetBy(&position);
	}

	public static unsafe void MoveTo(Vector3 position) {
		CVR_LocalPlayer_MoveTo(&position);
	}

	public static unsafe void SetImmobilized(bool immobile) {
		CVR_LocalPlayer_SetImmobilized(immobile ? 1 : 0);
	}
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_LocalPlayer_PlayerObject();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern float CVR_LocalPlayer_GetPlaySpaceScale();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_GetPlaySpaceOffset(Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_GetPosition(Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_SetPosition(Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_GetRotation(Quaternion* quaternionPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_SetRotation(Quaternion* quaternionPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_OffsetBy(Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_LocalPlayer_MoveTo(Vector3* vectorPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern void CVR_LocalPlayer_SetImmobilized(int immobile);
}