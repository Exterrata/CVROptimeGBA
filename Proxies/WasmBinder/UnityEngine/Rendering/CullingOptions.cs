//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Rendering
{

    public enum CullingOptions : int
    {
        None = 0,
        ForceEvenIfCameraIsNotActive = 1,
        OcclusionCull = 2,
        NeedsLighting = 4,
        NeedsReflectionProbes = 8,
        Stereo = 16,
        DisablePerObjectCulling = 32,
        ShadowCasters = 64,
    }
}
