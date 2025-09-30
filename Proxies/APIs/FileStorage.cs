using System.Runtime.InteropServices;

namespace WasmScripting;

/// <summary>
/// This API is only usable by worlds<br/>
/// Store data locally for save systems, world settings, ect...<br/>
/// Files are stored at /Appdata/Local/ChilloutVR/LocalStorage/[GUID]/[fileName]
/// </summary>
public static class FileStorage {
	public static unsafe Span<byte> ReadFile(string fileName) {
		int bufferLength = 0;
		byte* buffer = null;
		
		fixed (char* str = fileName) {
			FileStorage_ReadInternal_Full(str, fileName.Length * sizeof(char), &buffer, &bufferLength);
		}

		return new(buffer, bufferLength);
	}
	
	public static unsafe Span<byte> ReadFile(string fileName, int offset, int length) {
		int bufferLength = 0;
		byte* buffer = null;
		
		fixed (char* str = fileName) {
			FileStorage_ReadInternal_Partial(str, fileName.Length * sizeof(char), offset, length, &buffer, &bufferLength);
		}

		return new(buffer, bufferLength);
	}
	
	public static unsafe void WriteFile(string fileName, Span<byte> bytes) {
		fixed (byte* buffer = bytes)
		fixed (char* str = fileName) {
			FileStorage_WriteInternal_Full(str, fileName.Length * sizeof(char), buffer, bytes.Length);
		}
	}
	
	public static unsafe void WriteFile(string fileName, Span<byte> bytes, int offset) {
		fixed (byte* buffer = bytes)
		fixed (char* str = fileName) {
			FileStorage_WriteInternal_Partial(str, fileName.Length * sizeof(char), buffer, bytes.Length, offset);
		}
	}
	
	public static unsafe void DeleteFile(string fileName) {
		fixed (char* str = fileName) {
			FileStorage_DeleteFileInternal(str, fileName.Length * sizeof(char));
		}
	}

	public static unsafe void RenameFile(string oldFileName, string newFileName) {
		fixed (char* oldStr = oldFileName)
		fixed (char* newStr = newFileName) {
			FileStorage_RenameFileInternal(oldStr, oldFileName.Length * sizeof(char), newStr, newFileName.Length);
		}
	}

	public static unsafe bool FileExists(string fileName) {
		fixed (char* str = fileName) {
			return FileStorage_FileExistsInternal(str, fileName.Length * sizeof(char)) != 0;
		}
	}
	
	public static unsafe string[] GetFiles() {
		int namesLengths = 0;
		char** namesPtrPtr = null;
		int* nameLengthsPtr = null;

		FileStorage_GetFilesInternal(&namesPtrPtr, &nameLengthsPtr, &namesLengths);

		if (namesLengths == 0) return [];

		string[] files = new string[namesLengths];

		for (int i = 0; i < namesLengths; i++) {
			files[i] = new string(namesPtrPtr![i], 0, nameLengthsPtr![i] / sizeof(char));
		}

		return files;
	}
	
	public static unsafe long GetFileSize(string fileName) {
		fixed (char* str = fileName) {
			return FileStorage_GetFileSizeInternal(str, fileName.Length * sizeof(char));
		}
	}

	public static long GetTotalSize() {
		return FileStorage_GetTotalSizeInternal();
	}

	public static long GetTotalCapacity() {
		return FileStorage_GetTotalCapacityInternal();
	}
	
	/// <summary>
	/// Returns whether the FileStorage API can be used.
	/// If you attempt to use the API when this returned false it will throw an exception.
	/// </summary>
	public static bool CanUseFileStorage() => true; // TODO: actually make this work
		
	/// <summary>
	/// this will prompt the user once and invoke the action with whether they allowed the use of storing files.
	/// any further attempts to call this will just return the first attempts response unless the user changes it later.
	/// </summary>
	public static void RequestUseFileStorage(Action<bool> onUserResult = null) => onUserResult?.Invoke(true); // TODO: actually make this work

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_ReadInternal_Full(char* namePtr, int nameLength, byte** bufferPtrPtr, int* bufferLengthPtr);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_ReadInternal_Partial(char* namePtr, int nameLength, int offset, int length, byte** bufferPtrPtr, int* bufferLengthPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_WriteInternal_Full(char* namePtr, int nameLength, byte* bufferPtr, int bufferLength);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_WriteInternal_Partial(char* namePtr, int nameLength, byte* bufferPtr, int bufferLength, int offset);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_DeleteFileInternal(char* namePtr, int nameLength);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_RenameFileInternal(char* oldNamePtr, int oldNameLength, char* newNamePtr, int newNameLength);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe int FileStorage_FileExistsInternal(char* namePtr, int nameLength);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void FileStorage_GetFilesInternal(char*** namesPtrPtr, int** nameLengthsPtrPtr, int* namesLengthPtr);

	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe long FileStorage_GetFileSizeInternal(char* namePtr, int nameLength);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long FileStorage_GetTotalSizeInternal();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern long FileStorage_GetTotalCapacityInternal();
}