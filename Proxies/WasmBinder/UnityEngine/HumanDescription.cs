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

    public partial struct HumanDescription(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public global::UnityEngine.HumanBone[] human
        {
            get => internal_UnityEngineHumanDescription__get__human(WrappedId);
            set => internal_UnityEngineHumanDescription__set__human(WrappedId, value);
        }

        public global::UnityEngine.SkeletonBone[] skeleton
        {
            get => internal_UnityEngineHumanDescription__get__skeleton(WrappedId);
            set => internal_UnityEngineHumanDescription__set__skeleton(WrappedId, value);
        }

        public float upperArmTwist 
        {
            get => internal_UnityEngineHumanDescription__get__upperArmTwist(WrappedId);
            set => internal_UnityEngineHumanDescription__set__upperArmTwist(WrappedId, value);
        }

        public float lowerArmTwist 
        {
            get => internal_UnityEngineHumanDescription__get__lowerArmTwist(WrappedId);
            set => internal_UnityEngineHumanDescription__set__lowerArmTwist(WrappedId, value);
        }

        public float upperLegTwist 
        {
            get => internal_UnityEngineHumanDescription__get__upperLegTwist(WrappedId);
            set => internal_UnityEngineHumanDescription__set__upperLegTwist(WrappedId, value);
        }

        public float lowerLegTwist 
        {
            get => internal_UnityEngineHumanDescription__get__lowerLegTwist(WrappedId);
            set => internal_UnityEngineHumanDescription__set__lowerLegTwist(WrappedId, value);
        }

        public float armStretch 
        {
            get => internal_UnityEngineHumanDescription__get__armStretch(WrappedId);
            set => internal_UnityEngineHumanDescription__set__armStretch(WrappedId, value);
        }

        public float legStretch 
        {
            get => internal_UnityEngineHumanDescription__get__legStretch(WrappedId);
            set => internal_UnityEngineHumanDescription__set__legStretch(WrappedId, value);
        }

        public float feetSpacing 
        {
            get => internal_UnityEngineHumanDescription__get__feetSpacing(WrappedId);
            set => internal_UnityEngineHumanDescription__set__feetSpacing(WrappedId, value);
        }

        public bool hasTranslationDoF 
        {
            get => internal_UnityEngineHumanDescription__get__hasTranslationDoF(WrappedId);
            set => internal_UnityEngineHumanDescription__set__hasTranslationDoF(WrappedId, value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.HumanBone[] internal_UnityEngineHumanDescription__get__human(long selfObjectId)
        {
            long* humanIdsPointer = default;
            int humanWasmLength = default;
            UnityEngineHumanDescription__get__human(selfObjectId, &humanIdsPointer, &humanWasmLength);
            global::UnityEngine.HumanBone[] returnResult = new global::UnityEngine.HumanBone[humanWasmLength];
            for (int i = 0; i < humanWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.HumanBone(humanIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)humanIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__human(long selfObjectId, global::UnityEngine.HumanBone[] human)
        {
            int humanWasmLength = human.Length;
            long[] humanIds = new long[humanWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < humanWasmLength; i++) humanIds[i] = (human[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* humanIdsPointer = humanIds)
            {
                UnityEngineHumanDescription__set__human(selfObjectId, humanIdsPointer, humanWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.SkeletonBone[] internal_UnityEngineHumanDescription__get__skeleton(long selfObjectId)
        {
            long* skeletonIdsPointer = default;
            int skeletonWasmLength = default;
            UnityEngineHumanDescription__get__skeleton(selfObjectId, &skeletonIdsPointer, &skeletonWasmLength);
            global::UnityEngine.SkeletonBone[] returnResult = new global::UnityEngine.SkeletonBone[skeletonWasmLength];
            for (int i = 0; i < skeletonWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.SkeletonBone(skeletonIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)skeletonIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__skeleton(long selfObjectId, global::UnityEngine.SkeletonBone[] skeleton)
        {
            int skeletonWasmLength = skeleton.Length;
            long[] skeletonIds = new long[skeletonWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < skeletonWasmLength; i++) skeletonIds[i] = (skeleton[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* skeletonIdsPointer = skeletonIds)
            {
                UnityEngineHumanDescription__set__skeleton(selfObjectId, skeletonIdsPointer, skeletonWasmLength);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__upperArmTwist(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__upperArmTwist(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__upperArmTwist(long selfObjectId, float upperArmTwist)
        {
            UnityEngineHumanDescription__set__upperArmTwist(selfObjectId, upperArmTwist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__lowerArmTwist(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__lowerArmTwist(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__lowerArmTwist(long selfObjectId, float lowerArmTwist)
        {
            UnityEngineHumanDescription__set__lowerArmTwist(selfObjectId, lowerArmTwist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__upperLegTwist(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__upperLegTwist(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__upperLegTwist(long selfObjectId, float upperLegTwist)
        {
            UnityEngineHumanDescription__set__upperLegTwist(selfObjectId, upperLegTwist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__lowerLegTwist(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__lowerLegTwist(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__lowerLegTwist(long selfObjectId, float lowerLegTwist)
        {
            UnityEngineHumanDescription__set__lowerLegTwist(selfObjectId, lowerLegTwist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__armStretch(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__armStretch(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__armStretch(long selfObjectId, float armStretch)
        {
            UnityEngineHumanDescription__set__armStretch(selfObjectId, armStretch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__legStretch(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__legStretch(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__legStretch(long selfObjectId, float legStretch)
        {
            UnityEngineHumanDescription__set__legStretch(selfObjectId, legStretch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineHumanDescription__get__feetSpacing(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__feetSpacing(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__feetSpacing(long selfObjectId, float feetSpacing)
        {
            UnityEngineHumanDescription__set__feetSpacing(selfObjectId, feetSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineHumanDescription__get__hasTranslationDoF(long selfObjectId)
        {
            var methodCallResult = UnityEngineHumanDescription__get__hasTranslationDoF(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineHumanDescription__set__hasTranslationDoF(long selfObjectId, bool hasTranslationDoF)
        {
            var hasTranslationDoFConverted = Unsafe.As<bool, int>(ref hasTranslationDoF);
            UnityEngineHumanDescription__set__hasTranslationDoF(selfObjectId, hasTranslationDoFConverted);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanDescription__get__human(long selfObjectId, void* humanIdsPointer, void* humanWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanDescription__set__human(long selfObjectId, void* humanIdsPointer, int humanWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanDescription__get__skeleton(long selfObjectId, void* skeletonIdsPointer, void* skeletonWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineHumanDescription__set__skeleton(long selfObjectId, void* skeletonIdsPointer, int skeletonWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__upperArmTwist(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__upperArmTwist(long selfObjectId, float upperArmTwist);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__lowerArmTwist(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__lowerArmTwist(long selfObjectId, float lowerArmTwist);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__upperLegTwist(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__upperLegTwist(long selfObjectId, float upperLegTwist);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__lowerLegTwist(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__lowerLegTwist(long selfObjectId, float lowerLegTwist);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__armStretch(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__armStretch(long selfObjectId, float armStretch);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__legStretch(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__legStretch(long selfObjectId, float legStretch);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineHumanDescription__get__feetSpacing(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__feetSpacing(long selfObjectId, float feetSpacing);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineHumanDescription__get__hasTranslationDoF(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineHumanDescription__set__hasTranslationDoF(long selfObjectId, int hasTranslationDoFConverted);

        #endregion Imports
    }
}
