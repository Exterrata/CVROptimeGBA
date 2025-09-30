//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.AI
{

    public enum NavMeshBuildDebugFlags : int
    {
        None = 0,
        InputGeometry = 1,
        Voxels = 2,
        Regions = 4,
        RawContours = 8,
        SimplifiedContours = 16,
        PolygonMeshes = 32,
        PolygonMeshesDetail = 64,
        All = 127,
    }
}
