using System.Runtime.InteropServices;
using WasmScripting;

namespace CVR;

public class Avatar(long id) : IProxyObject {
	public long WrappedId { get; set; } = id;

	public static unsafe Avatar[] GetAllAvatars() {
		int avatarCount = 0;
		long* avatarWrappedIds = null;
		CVR_Avatar_GetAllAvatars(&avatarWrappedIds, &avatarCount);

		Avatar[] avatars = new Avatar[avatarCount];
		for (int i = 0; i < avatarCount; i++) {
			avatars[i] = new(avatarWrappedIds![i]);
		}

		return avatars;
	}

	public static Avatar GetCurrentAvatar() => new(CVR_Avatar_GetCurrentAvatar());

	public Player Wearer => new(CVR_Avatar_GetWearer(WrappedId));
	
	public unsafe string Name {
		get {
			int nameLength = 0;
			char* namePtr = null;
			CVR_Avatar_GetName(WrappedId, &namePtr, &nameLength);
			string name = new(namePtr, 0, nameLength);
			Marshal.FreeHGlobal((IntPtr)namePtr);
			return name;
		}
	}

	public unsafe string ContentId {
		get {
			int contentIdLength = 0;
			char* contentIdPtr = null;
			CVR_Avatar_GetContentId(WrappedId, &contentIdPtr, &contentIdLength);
			string contentId = new(contentIdPtr, 0, contentIdLength);
			Marshal.FreeHGlobal((IntPtr)contentIdPtr);
			return contentId;
		}
	}
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Avatar_GetAllAvatars(long** wrappedIdsPtrPtr, int* wrappedIdsLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Avatar_GetCurrentAvatar();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Avatar_GetWearer(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Avatar_GetName(long wrappedId, char** namePtrPtr, int* nameLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Avatar_GetContentId(long wrappedId, char** contentIdPtrPtr, int* contentIdLengthPtr);
}