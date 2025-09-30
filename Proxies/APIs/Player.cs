using System.Runtime.InteropServices;
using UnityEngine;
using WasmScripting;

namespace CVR;

public class Player(long id) : IProxyObject {
	public long WrappedId { get; set; } = id;

	public static unsafe Player[] GetAllPlayers() {
		int playerCount = 0;
		long* playerWrappedIds = null;
		CVR_Player_GetAllPlayers(&playerWrappedIds, &playerCount);

		Player[] players = new Player[playerCount];
		for (int i = 0; i < playerCount; i++) {
			players[i] = new(playerWrappedIds![i]);
		}

		return players;
	}

	public static unsafe Player[] GetRemotePlayers() {
		int playerCount = 0;
		long* playerWrappedIds = null;
		CVR_Player_GetRemotePlayers(&playerWrappedIds, &playerCount);
		
		Player[] players = new Player[playerCount];
		for (int i = 0; i < playerCount; i++) {
			players[i] = new(playerWrappedIds![i]);
		}

		return players;
	}
	
	public unsafe string UserId {
		get {
			int userIdLength = 0;
			char* userIdPtr = null;
			CVR_Player_UserId(WrappedId, &userIdPtr, &userIdLength);
			string userId = new(userIdPtr, 0, userIdLength);
			Marshal.FreeHGlobal((IntPtr)userIdPtr);
			return userId;
		}
	}
	
	public unsafe string Username {
		get {
			int usernameLength = 0;
			char* usernamePtr = null;
			CVR_Player_Username(WrappedId, &usernamePtr, &usernameLength);
			string username = new(usernamePtr, 0, usernameLength);
			Marshal.FreeHGlobal((IntPtr)usernamePtr);
			return username;
		}
	}

	public short NetworkId => (short)CVR_Player_NetworkId(WrappedId);
	
	public GameObject GameObject => new(CVR_Player_GameObject(WrappedId));

	public AvatarPoint ViewPoint => new(CVR_Player_ViewPoint(WrappedId));

	public AvatarPoint VoicePoint => new(CVR_Player_VoicePoint(WrappedId));
	
	public float GetInitialHeight() => CVR_Player_GetInitialHeight(WrappedId);

	public float GetCurrentHeight() => CVR_Player_GetCurrentHeight(WrappedId);

	public unsafe Vector3 GetGravity() {
		Vector3 gravity = new();
		CVR_Player_GetGravity(WrappedId, &gravity);
		return gravity;
	}
	
	public unsafe void SetOriginPosition(Vector3 targetPos) {
		CVR_Player_SetOriginPosition(WrappedId, &targetPos);
	}
	
	public unsafe void SetOriginRotation(Quaternion targetRot) {
		CVR_Player_SetOriginRotation(WrappedId, &targetRot);
	}

	public Avatar GetWornAvatar() => new(CVR_Player_GetWornAvatar(WrappedId));

	public unsafe Prop[] GetSpawnedProps() {
		int propCount = 0;
		long* propWrappedIds = null;
		CVR_Player_GetSpawnedProps(WrappedId, &propWrappedIds, &propCount);

		Prop[] props = new Prop[propCount];
		for (int i = 0; i < propCount; i++) {
			props[i] = new(propWrappedIds![i]);
		}

		return props;
	}
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_GetAllPlayers(long** wrappedIdsPtrPtr, int* wrappedIdsLengthPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_GetRemotePlayers(long** wrappedIdsPtrPtr, int* wrappedIdsLengthPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_UserId(long wrappedId, char** userIdPtrPtr, int* userIdLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_Username(long wrappedId, char** usernamePtrPtr, int* usernameLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern int CVR_Player_NetworkId(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Player_GameObject(long wrappedId);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Player_ViewPoint(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Player_VoicePoint(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern float CVR_Player_GetInitialHeight(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern float CVR_Player_GetCurrentHeight(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_GetGravity(long wrappedId, Vector3* gravityPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_SetOriginPosition(long wrappedId, Vector3* positionPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_SetOriginRotation(long wrappedId, Quaternion* rotationPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Player_GetWornAvatar(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Player_GetSpawnedProps(long wrappedId, long** wrappedIdsPtrPtr, int* wrappedIdsLengthPtr);
}