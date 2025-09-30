using System.Runtime.InteropServices;
using UnityEngine;
using WasmScripting;

namespace CVR;

public class Prop(long id) : IProxyObject {
	public long WrappedId { get; set; } = id;

	public static unsafe Prop[] GetAllProps() {
		int propCount = 0;
		long* propWrappedIds = null;
		CVR_Prop_GetAllProps(&propWrappedIds, &propCount);

		Prop[] props = new Prop[propCount];
		for (int i = 0; i < propCount; i++) {
			props[i] = new(propWrappedIds![i]);
		}

		return props;
	}

	public static Prop GetCurrentProp() => new(CVR_Prop_GetCurrentProp());

	public Player Spawner => new(CVR_Prop_GetSpawner(WrappedId));

	public GameObject RootObject => new(CVR_Prop_GetRootObject(WrappedId));

	public Transform RootTransform => new(CVR_Prop_GetTransform(WrappedId));

	public unsafe string ContentId {
		get {
			int contentIdLength = 0;
			char* contentIdPtr = null;
			CVR_Prop_GetContentId(WrappedId, &contentIdPtr, &contentIdLength);
			string contentId = new(contentIdPtr, 0, contentIdLength);
			Marshal.FreeHGlobal((IntPtr)contentIdPtr);
			return contentId;
		}
	}

	public void Destroy() => CVR_Prop_Destroy(WrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Prop_GetAllProps(long** wrappedIdsPtrPtr, int* wrappedIdsLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Prop_GetCurrentProp();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Prop_GetSpawner(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Prop_GetRootObject(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long CVR_Prop_GetTransform(long wrappedId);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Prop_GetContentId(long wrappedId, char** contentIdPtrPtr, int* contentIdLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern void CVR_Prop_Destroy(long wrappedId);
}