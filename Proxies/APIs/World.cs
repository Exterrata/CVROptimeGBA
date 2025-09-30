using System.Runtime.InteropServices;
using WasmScripting;

namespace CVR;

public class World(long id) : IProxyObject {
	public long WrappedId { get; set; } = id;

	public static World GetCurrentWorld() => new(CVR_World_GetCurrentWorld());
	
	public unsafe string Name {
		get {
			int nameLength = 0;
			char* namePtr = null;
			CVR_World_GetName(WrappedId, &namePtr, &nameLength);
			string name = new(namePtr, 0, nameLength);
			Marshal.FreeHGlobal((IntPtr)namePtr);
			return name;
		}
	}

	public unsafe string ContentId {
		get {
			int contentIdLength = 0;
			char* contentIdPtr = null;
			CVR_World_GetContentId(WrappedId, &contentIdPtr, &contentIdLength);
			string contentId = new(contentIdPtr, 0, contentIdLength);
			Marshal.FreeHGlobal((IntPtr)contentIdPtr);
			return contentId;
		}
	}
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_World_GetCurrentWorld();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_World_GetName(long wrappedId, char** namePtrPtr, int* nameLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_World_GetContentId(long wrappedId, char** contentIdPtrPtr, int* contentIdLengthPtr);
}