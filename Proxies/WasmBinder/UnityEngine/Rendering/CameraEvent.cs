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

    public enum CameraEvent : int
    {
        BeforeDepthTexture = 0,
        AfterDepthTexture = 1,
        BeforeDepthNormalsTexture = 2,
        AfterDepthNormalsTexture = 3,
        BeforeGBuffer = 4,
        AfterGBuffer = 5,
        BeforeLighting = 6,
        AfterLighting = 7,
        BeforeFinalPass = 8,
        AfterFinalPass = 9,
        BeforeForwardOpaque = 10,
        AfterForwardOpaque = 11,
        BeforeImageEffectsOpaque = 12,
        AfterImageEffectsOpaque = 13,
        BeforeSkybox = 14,
        AfterSkybox = 15,
        BeforeForwardAlpha = 16,
        AfterForwardAlpha = 17,
        BeforeImageEffects = 18,
        AfterImageEffects = 19,
        AfterEverything = 20,
        BeforeReflections = 21,
        AfterReflections = 22,
        BeforeHaloAndLensFlares = 23,
        AfterHaloAndLensFlares = 24,
    }
}
