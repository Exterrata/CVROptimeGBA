using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine;

public partial class Object
{
    #region Implementation
    
    public static implicit operator bool(Object exists)
    {
        return exists != null;
    }
    
    public static bool operator ==(Object x, Object y)
    {
        // Check if either are dead on our side before needlessly calling back to Unity
        if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            return false;
        
        int methodCallResult = UnityEngineObject__op__Equality__UnityEngineObject__UnityEngineObject__SystemBoolean(x.WrappedId, y.WrappedId);
        bool returnResult = Unsafe.As<int, bool>(ref methodCallResult);
        return returnResult;
    }
    
    public static bool operator !=(Object x, Object y)
    {
        return !(x == y);
    }
    
    public override string ToString()
    {
        return internal_UnityEngineObject__func__ToString__SystemString(WrappedId);
    }
    
    public override int GetHashCode()
    {
        return internal_UnityEngineObject__func__GetHashCode__SystemInt32(WrappedId);
    }

    public override bool Equals(object other)
    {
        return internal_UnityEngineObject__func__Equals__SystemObject__SystemBoolean(WrappedId, other);
    }
    
    #endregion Implementation
    
    #region Marshaling
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe string internal_UnityEngineObject__func__ToString__SystemString(long selfObjectId)
    {
        char* returnResultPointer = default;
        int returnResultWasmLength = default;
        UnityEngineObject__func__ToString__SystemString(selfObjectId, &returnResultPointer, &returnResultWasmLength);
        string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
        Marshal.FreeHGlobal((IntPtr)returnResultPointer);
        return returnResult;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe int internal_UnityEngineObject__func__GetHashCode__SystemInt32(long selfObjectId)
    {
        var methodCallResult = UnityEngineObject__func__GetHashCode__SystemInt32(selfObjectId);
        var returnResult = methodCallResult;
        return returnResult;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe bool internal_UnityEngineObject__func__Equals__SystemObject__SystemBoolean(long selfObjectId, object other)
    {
        // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
        var methodCallResult = UnityEngineObject__func__Equals__SystemObject__SystemBoolean(selfObjectId, (other as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
        var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
        return returnResult;
    }
    
    #endregion Marshaling

    #region Imports

    [WasmImportLinkage, DllImport("UnityEngine")]
    private static extern int UnityEngineObject__op__Equality__UnityEngineObject__UnityEngineObject__SystemBoolean(long xObjectId, long yObjectId);
    
    [WasmImportLinkage, DllImport("UnityEngine")]
    private static extern unsafe void UnityEngineObject__func__ToString__SystemString(long selfObjectId, void* returnResultPointer, void* returnResultWasmLengthsPointer);
    
    [WasmImportLinkage, DllImport("UnityEngine")]
    private static extern int UnityEngineObject__func__GetHashCode__SystemInt32(long selfObjectId);

    [WasmImportLinkage, DllImport("UnityEngine")]
    private static extern int UnityEngineObject__func__Equals__SystemObject__SystemBoolean(long selfObjectId, long otherObjectId);

    #endregion Imports
}