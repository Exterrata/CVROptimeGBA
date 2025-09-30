//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine.Audio
{

    public partial class AudioMixer(long id) : Object(id)
    {

        #region Implementation

        public global::UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup 
        {
            get => internal_UnityEngineAudioAudioMixer__get__outputAudioMixerGroup(WrappedId);
            set => internal_UnityEngineAudioAudioMixer__set__outputAudioMixerGroup(WrappedId, value);
        }

        public global::UnityEngine.Audio.AudioMixerUpdateMode updateMode 
        {
            get => internal_UnityEngineAudioAudioMixer__get__updateMode(WrappedId);
            set => internal_UnityEngineAudioAudioMixer__set__updateMode(WrappedId, value);
        }

        public global::UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(string name)
        {
            return internal_UnityEngineAudioAudioMixer__func__FindSnapshot__SystemString__UnityEngineAudioAudioMixerSnapshot(WrappedId, name);
        }

        public global::UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(string subPath)
        {
            return internal_UnityEngineAudioAudioMixer__func__FindMatchingGroups__SystemString__UnityEngineAudioAudioMixerGroupArray(WrappedId, subPath);
        }

        public void TransitionToSnapshots(global::UnityEngine.Audio.AudioMixerSnapshot[] snapshots, global::System.Single[] weights, float timeToReach)
        {
            internal_UnityEngineAudioAudioMixer__func__TransitionToSnapshots__UnityEngineAudioAudioMixerSnapshotArray__SystemSingleArray__SystemSingle__SystemVoid(WrappedId, snapshots, weights, timeToReach);
        }

        public bool SetFloat(string name, float value)
        {
            return internal_UnityEngineAudioAudioMixer__func__SetFloat__SystemString__SystemSingle__SystemBoolean(WrappedId, name, value);
        }

        public bool ClearFloat(string name)
        {
            return internal_UnityEngineAudioAudioMixer__func__ClearFloat__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool GetFloat(string name, out float value)
        {
            return internal_UnityEngineAudioAudioMixer__func__GetFloat__SystemString__SystemSingleRef__SystemBoolean(WrappedId, name, out value);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixerGroup internal_UnityEngineAudioAudioMixer__get__outputAudioMixerGroup(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioAudioMixer__get__outputAudioMixerGroup(selfObjectId);
            var returnResult = new global::UnityEngine.Audio.AudioMixerGroup(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioAudioMixer__set__outputAudioMixerGroup(long selfObjectId, global::UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup)
        {
            UnityEngineAudioAudioMixer__set__outputAudioMixerGroup(selfObjectId, outputAudioMixerGroup.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixerUpdateMode internal_UnityEngineAudioAudioMixer__get__updateMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAudioAudioMixer__get__updateMode(selfObjectId);
            var returnResult = (global::UnityEngine.Audio.AudioMixerUpdateMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioAudioMixer__set__updateMode(long selfObjectId, global::UnityEngine.Audio.AudioMixerUpdateMode updateMode)
        {
            UnityEngineAudioAudioMixer__set__updateMode(selfObjectId, (int) updateMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixerSnapshot internal_UnityEngineAudioAudioMixer__func__FindSnapshot__SystemString__UnityEngineAudioAudioMixerSnapshot(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAudioAudioMixer__func__FindSnapshot__SystemString__UnityEngineAudioAudioMixerSnapshot(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = new global::UnityEngine.Audio.AudioMixerSnapshot(methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Audio.AudioMixerGroup[] internal_UnityEngineAudioAudioMixer__func__FindMatchingGroups__SystemString__UnityEngineAudioAudioMixerGroupArray(long selfObjectId, string subPath)
        {
            fixed (char* subPathPointer = subPath)
            {
                long* returnResultIdsPointer = default;
                int returnResultWasmLength = default;
                UnityEngineAudioAudioMixer__func__FindMatchingGroups__SystemString__UnityEngineAudioAudioMixerGroupArray(selfObjectId, subPathPointer, subPath.Length * sizeof(char), &returnResultIdsPointer, &returnResultWasmLength);
                global::UnityEngine.Audio.AudioMixerGroup[] returnResult = new global::UnityEngine.Audio.AudioMixerGroup[returnResultWasmLength];
                for (int i = 0; i < returnResultWasmLength; i++)
                {
                    returnResult[i] = new global::UnityEngine.Audio.AudioMixerGroup(returnResultIdsPointer![i]);
                }
                Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAudioAudioMixer__func__TransitionToSnapshots__UnityEngineAudioAudioMixerSnapshotArray__SystemSingleArray__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Audio.AudioMixerSnapshot[] snapshots, global::System.Single[] weights, float timeToReach)
        {
            int snapshotsWasmLength = snapshots.Length;
            long[] snapshotsIds = new long[snapshotsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < snapshotsWasmLength; i++) snapshotsIds[i] = (snapshots[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* snapshotsIdsPointer = snapshotsIds)
            {
                fixed (float* weightsPointer = weights)
                {
                    UnityEngineAudioAudioMixer__func__TransitionToSnapshots__UnityEngineAudioAudioMixerSnapshotArray__SystemSingleArray__SystemSingle__SystemVoid(selfObjectId, snapshotsIdsPointer, snapshotsWasmLength, weightsPointer, weights.Length, timeToReach);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioAudioMixer__func__SetFloat__SystemString__SystemSingle__SystemBoolean(long selfObjectId, string name, float value)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAudioAudioMixer__func__SetFloat__SystemString__SystemSingle__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char), value);
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioAudioMixer__func__ClearFloat__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAudioAudioMixer__func__ClearFloat__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAudioAudioMixer__func__GetFloat__SystemString__SystemSingleRef__SystemBoolean(long selfObjectId, string name, out float value)
        {
            fixed (char* namePointer = name)
            {
                value = default;
                var methodCallResult = UnityEngineAudioAudioMixer__func__GetFloat__SystemString__SystemSingleRef__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char), Unsafe.AsPointer(ref value));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAudioAudioMixer__get__outputAudioMixerGroup(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioAudioMixer__set__outputAudioMixerGroup(long selfObjectId, long outputAudioMixerGroupObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAudioAudioMixer__get__updateMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAudioAudioMixer__set__updateMode(long selfObjectId, int updateModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe long UnityEngineAudioAudioMixer__func__FindSnapshot__SystemString__UnityEngineAudioAudioMixerSnapshot(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioAudioMixer__func__FindMatchingGroups__SystemString__UnityEngineAudioAudioMixerGroupArray(long selfObjectId, void* subPathPointer, int subPathWasmLength, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAudioAudioMixer__func__TransitionToSnapshots__UnityEngineAudioAudioMixerSnapshotArray__SystemSingleArray__SystemSingle__SystemVoid(long selfObjectId, void* snapshotsIdsPointer, int snapshotsWasmLength, void* weightsPointer, int weightsWasmLength, float timeToReach);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioAudioMixer__func__SetFloat__SystemString__SystemSingle__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioAudioMixer__func__ClearFloat__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAudioAudioMixer__func__GetFloat__SystemString__SystemSingleRef__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength, void* valuePointer);

        #endregion Imports
    }
}
