//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine
{

    public partial class GraphicsBuffer
    {
        public enum Target : int
        {
            Vertex = 1,
            Index = 2,
            CopySource = 4,
            CopyDestination = 8,
            Structured = 16,
            Raw = 32,
            Append = 64,
            Counter = 128,
            IndirectArguments = 256,
            Constant = 512,
        }
    }
}
