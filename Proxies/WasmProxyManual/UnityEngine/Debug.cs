using System.Runtime.InteropServices;

namespace UnityEngine;

public partial class Debug {
    #region Implementation

    public static unsafe void Log(object obj) {
        string str = obj.ToString() ?? "null";
        fixed (char* chr = str) {
            debug_log(chr, str.Length * sizeof(char));
        }
    }

    public static unsafe void LogWarning(object obj) {
        string str = obj.ToString() ?? "null";
        fixed (char* chr = str) {
            debug_logWarning(chr, str.Length * sizeof(char));
        }
    }

    public static unsafe void LogError(object obj) {
        string str = obj.ToString() ?? "null";
        fixed (char* chr = str) {
            debug_logError(chr, str.Length * sizeof(char));
        }
    }

    #endregion Implementation

    #region Imports

    [WasmImportLinkage, DllImport("unity")]
    private static extern unsafe void debug_log(char* strPtr, int strSize);

    [WasmImportLinkage, DllImport("unity")]
    private static extern unsafe void debug_logWarning(char* strPtr, int strSize);

    [WasmImportLinkage, DllImport("unity")]
    private static extern unsafe void debug_logError(char* strPtr, int strSize);

    #endregion Imports
}