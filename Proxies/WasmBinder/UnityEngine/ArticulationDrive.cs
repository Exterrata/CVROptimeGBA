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

    [StructLayout(LayoutKind.Sequential)]
    public partial struct ArticulationDrive
    {

        #region Implementation

        // [FieldOffset(0)] (implicit field offset from sequential layout kind)
        public float lowerLimit;

        // [FieldOffset(4)] (implicit field offset from sequential layout kind)
        public float upperLimit;

        // [FieldOffset(8)] (implicit field offset from sequential layout kind)
        public float stiffness;

        // [FieldOffset(12)] (implicit field offset from sequential layout kind)
        public float damping;

        // [FieldOffset(16)] (implicit field offset from sequential layout kind)
        public float forceLimit;

        // [FieldOffset(20)] (implicit field offset from sequential layout kind)
        public float target;

        // [FieldOffset(24)] (implicit field offset from sequential layout kind)
        public float targetVelocity;

        #endregion Implementation

        #region Marshaling

        #endregion Marshaling

        #region Imports

        #endregion Imports
    }
}
