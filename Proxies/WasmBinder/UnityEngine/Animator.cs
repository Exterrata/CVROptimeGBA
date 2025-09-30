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

    public partial class Animator(long id) : Behaviour(id)
    {

        #region Implementation

        public bool isOptimizable 
        {
            get => internal_UnityEngineAnimator__get__isOptimizable(WrappedId);
        }

        public bool isHuman 
        {
            get => internal_UnityEngineAnimator__get__isHuman(WrappedId);
        }

        public bool hasRootMotion 
        {
            get => internal_UnityEngineAnimator__get__hasRootMotion(WrappedId);
        }

        public float humanScale 
        {
            get => internal_UnityEngineAnimator__get__humanScale(WrappedId);
        }

        public bool isInitialized 
        {
            get => internal_UnityEngineAnimator__get__isInitialized(WrappedId);
        }

        public global::UnityEngine.Vector3 deltaPosition 
        {
            get => internal_UnityEngineAnimator__get__deltaPosition(WrappedId);
        }

        public global::UnityEngine.Quaternion deltaRotation 
        {
            get => internal_UnityEngineAnimator__get__deltaRotation(WrappedId);
        }

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineAnimator__get__velocity(WrappedId);
        }

        public global::UnityEngine.Vector3 angularVelocity 
        {
            get => internal_UnityEngineAnimator__get__angularVelocity(WrappedId);
        }

        public global::UnityEngine.Vector3 rootPosition 
        {
            get => internal_UnityEngineAnimator__get__rootPosition(WrappedId);
            set => internal_UnityEngineAnimator__set__rootPosition(WrappedId, value);
        }

        public global::UnityEngine.Quaternion rootRotation 
        {
            get => internal_UnityEngineAnimator__get__rootRotation(WrappedId);
            set => internal_UnityEngineAnimator__set__rootRotation(WrappedId, value);
        }

        public bool applyRootMotion 
        {
            get => internal_UnityEngineAnimator__get__applyRootMotion(WrappedId);
            set => internal_UnityEngineAnimator__set__applyRootMotion(WrappedId, value);
        }

        public global::UnityEngine.AnimatorUpdateMode updateMode 
        {
            get => internal_UnityEngineAnimator__get__updateMode(WrappedId);
            set => internal_UnityEngineAnimator__set__updateMode(WrappedId, value);
        }

        public bool hasTransformHierarchy 
        {
            get => internal_UnityEngineAnimator__get__hasTransformHierarchy(WrappedId);
        }

        public float gravityWeight 
        {
            get => internal_UnityEngineAnimator__get__gravityWeight(WrappedId);
        }

        public global::UnityEngine.Vector3 bodyPosition 
        {
            get => internal_UnityEngineAnimator__get__bodyPosition(WrappedId);
            set => internal_UnityEngineAnimator__set__bodyPosition(WrappedId, value);
        }

        public global::UnityEngine.Quaternion bodyRotation 
        {
            get => internal_UnityEngineAnimator__get__bodyRotation(WrappedId);
            set => internal_UnityEngineAnimator__set__bodyRotation(WrappedId, value);
        }

        public bool stabilizeFeet 
        {
            get => internal_UnityEngineAnimator__get__stabilizeFeet(WrappedId);
            set => internal_UnityEngineAnimator__set__stabilizeFeet(WrappedId, value);
        }

        public int layerCount 
        {
            get => internal_UnityEngineAnimator__get__layerCount(WrappedId);
        }

        public global::UnityEngine.AnimatorControllerParameter[] parameters 
        {
            get => internal_UnityEngineAnimator__get__parameters(WrappedId);
        }

        public int parameterCount 
        {
            get => internal_UnityEngineAnimator__get__parameterCount(WrappedId);
        }

        public float feetPivotActive 
        {
            get => internal_UnityEngineAnimator__get__feetPivotActive(WrappedId);
            set => internal_UnityEngineAnimator__set__feetPivotActive(WrappedId, value);
        }

        public float pivotWeight 
        {
            get => internal_UnityEngineAnimator__get__pivotWeight(WrappedId);
        }

        public global::UnityEngine.Vector3 pivotPosition 
        {
            get => internal_UnityEngineAnimator__get__pivotPosition(WrappedId);
        }

        public bool isMatchingTarget 
        {
            get => internal_UnityEngineAnimator__get__isMatchingTarget(WrappedId);
        }

        public float speed 
        {
            get => internal_UnityEngineAnimator__get__speed(WrappedId);
            set => internal_UnityEngineAnimator__set__speed(WrappedId, value);
        }

        public global::UnityEngine.Vector3 targetPosition 
        {
            get => internal_UnityEngineAnimator__get__targetPosition(WrappedId);
        }

        public global::UnityEngine.Quaternion targetRotation 
        {
            get => internal_UnityEngineAnimator__get__targetRotation(WrappedId);
        }

        public global::UnityEngine.AnimatorCullingMode cullingMode 
        {
            get => internal_UnityEngineAnimator__get__cullingMode(WrappedId);
            set => internal_UnityEngineAnimator__set__cullingMode(WrappedId, value);
        }

        public float playbackTime 
        {
            get => internal_UnityEngineAnimator__get__playbackTime(WrappedId);
            set => internal_UnityEngineAnimator__set__playbackTime(WrappedId, value);
        }

        public float recorderStartTime 
        {
            get => internal_UnityEngineAnimator__get__recorderStartTime(WrappedId);
            set => internal_UnityEngineAnimator__set__recorderStartTime(WrappedId, value);
        }

        public float recorderStopTime 
        {
            get => internal_UnityEngineAnimator__get__recorderStopTime(WrappedId);
            set => internal_UnityEngineAnimator__set__recorderStopTime(WrappedId, value);
        }

        public global::UnityEngine.AnimatorRecorderMode recorderMode 
        {
            get => internal_UnityEngineAnimator__get__recorderMode(WrappedId);
        }

        public global::UnityEngine.RuntimeAnimatorController runtimeAnimatorController 
        {
            get => internal_UnityEngineAnimator__get__runtimeAnimatorController(WrappedId);
            set => internal_UnityEngineAnimator__set__runtimeAnimatorController(WrappedId, value);
        }

        public bool hasBoundPlayables 
        {
            get => internal_UnityEngineAnimator__get__hasBoundPlayables(WrappedId);
        }

        public global::UnityEngine.Avatar avatar 
        {
            get => internal_UnityEngineAnimator__get__avatar(WrappedId);
            set => internal_UnityEngineAnimator__set__avatar(WrappedId, value);
        }

        public bool layersAffectMassCenter 
        {
            get => internal_UnityEngineAnimator__get__layersAffectMassCenter(WrappedId);
            set => internal_UnityEngineAnimator__set__layersAffectMassCenter(WrappedId, value);
        }

        public float leftFeetBottomHeight 
        {
            get => internal_UnityEngineAnimator__get__leftFeetBottomHeight(WrappedId);
        }

        public float rightFeetBottomHeight 
        {
            get => internal_UnityEngineAnimator__get__rightFeetBottomHeight(WrappedId);
        }

        public bool logWarnings 
        {
            get => internal_UnityEngineAnimator__get__logWarnings(WrappedId);
            set => internal_UnityEngineAnimator__set__logWarnings(WrappedId, value);
        }

        public bool fireEvents 
        {
            get => internal_UnityEngineAnimator__get__fireEvents(WrappedId);
            set => internal_UnityEngineAnimator__set__fireEvents(WrappedId, value);
        }

        public bool keepAnimatorStateOnDisable 
        {
            get => internal_UnityEngineAnimator__get__keepAnimatorStateOnDisable(WrappedId);
            set => internal_UnityEngineAnimator__set__keepAnimatorStateOnDisable(WrappedId, value);
        }

        public bool writeDefaultValuesOnDisable 
        {
            get => internal_UnityEngineAnimator__get__writeDefaultValuesOnDisable(WrappedId);
            set => internal_UnityEngineAnimator__set__writeDefaultValuesOnDisable(WrappedId, value);
        }

        public float GetFloat(string name)
        {
            return internal_UnityEngineAnimator__func__GetFloat__SystemString__SystemSingle(WrappedId, name);
        }

        public float GetFloat(int id)
        {
            return internal_UnityEngineAnimator__func__GetFloat__SystemInt32__SystemSingle(WrappedId, id);
        }

        public void SetFloat(string name, float value)
        {
            internal_UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemVoid(WrappedId, name, value);
        }

        public void SetFloat(string name, float value, float dampTime, float deltaTime)
        {
            internal_UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, name, value, dampTime, deltaTime);
        }

        public void SetFloat(int id, float value)
        {
            internal_UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(WrappedId, id, value);
        }

        public void SetFloat(int id, float value, float dampTime, float deltaTime)
        {
            internal_UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, id, value, dampTime, deltaTime);
        }

        public bool GetBool(string name)
        {
            return internal_UnityEngineAnimator__func__GetBool__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool GetBool(int id)
        {
            return internal_UnityEngineAnimator__func__GetBool__SystemInt32__SystemBoolean(WrappedId, id);
        }

        public void SetBool(string name, bool value)
        {
            internal_UnityEngineAnimator__func__SetBool__SystemString__SystemBoolean__SystemVoid(WrappedId, name, value);
        }

        public void SetBool(int id, bool value)
        {
            internal_UnityEngineAnimator__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(WrappedId, id, value);
        }

        public int GetInteger(string name)
        {
            return internal_UnityEngineAnimator__func__GetInteger__SystemString__SystemInt32(WrappedId, name);
        }

        public int GetInteger(int id)
        {
            return internal_UnityEngineAnimator__func__GetInteger__SystemInt32__SystemInt32(WrappedId, id);
        }

        public void SetInteger(string name, int value)
        {
            internal_UnityEngineAnimator__func__SetInteger__SystemString__SystemInt32__SystemVoid(WrappedId, name, value);
        }

        public void SetInteger(int id, int value)
        {
            internal_UnityEngineAnimator__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(WrappedId, id, value);
        }

        public void SetTrigger(string name)
        {
            internal_UnityEngineAnimator__func__SetTrigger__SystemString__SystemVoid(WrappedId, name);
        }

        public void SetTrigger(int id)
        {
            internal_UnityEngineAnimator__func__SetTrigger__SystemInt32__SystemVoid(WrappedId, id);
        }

        public void ResetTrigger(string name)
        {
            internal_UnityEngineAnimator__func__ResetTrigger__SystemString__SystemVoid(WrappedId, name);
        }

        public void ResetTrigger(int id)
        {
            internal_UnityEngineAnimator__func__ResetTrigger__SystemInt32__SystemVoid(WrappedId, id);
        }

        public bool IsParameterControlledByCurve(string name)
        {
            return internal_UnityEngineAnimator__func__IsParameterControlledByCurve__SystemString__SystemBoolean(WrappedId, name);
        }

        public bool IsParameterControlledByCurve(int id)
        {
            return internal_UnityEngineAnimator__func__IsParameterControlledByCurve__SystemInt32__SystemBoolean(WrappedId, id);
        }

        public global::UnityEngine.Vector3 GetIKPosition(global::UnityEngine.AvatarIKGoal goal)
        {
            return internal_UnityEngineAnimator__func__GetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3(WrappedId, goal);
        }

        public void SetIKPosition(global::UnityEngine.AvatarIKGoal goal, global::UnityEngine.Vector3 goalPosition)
        {
            internal_UnityEngineAnimator__func__SetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3__SystemVoid(WrappedId, goal, goalPosition);
        }

        public global::UnityEngine.Quaternion GetIKRotation(global::UnityEngine.AvatarIKGoal goal)
        {
            return internal_UnityEngineAnimator__func__GetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion(WrappedId, goal);
        }

        public void SetIKRotation(global::UnityEngine.AvatarIKGoal goal, global::UnityEngine.Quaternion goalRotation)
        {
            internal_UnityEngineAnimator__func__SetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion__SystemVoid(WrappedId, goal, goalRotation);
        }

        public float GetIKPositionWeight(global::UnityEngine.AvatarIKGoal goal)
        {
            return internal_UnityEngineAnimator__func__GetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(WrappedId, goal);
        }

        public void SetIKPositionWeight(global::UnityEngine.AvatarIKGoal goal, float value)
        {
            internal_UnityEngineAnimator__func__SetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(WrappedId, goal, value);
        }

        public float GetIKRotationWeight(global::UnityEngine.AvatarIKGoal goal)
        {
            return internal_UnityEngineAnimator__func__GetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(WrappedId, goal);
        }

        public void SetIKRotationWeight(global::UnityEngine.AvatarIKGoal goal, float value)
        {
            internal_UnityEngineAnimator__func__SetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(WrappedId, goal, value);
        }

        public global::UnityEngine.Vector3 GetIKHintPosition(global::UnityEngine.AvatarIKHint hint)
        {
            return internal_UnityEngineAnimator__func__GetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3(WrappedId, hint);
        }

        public void SetIKHintPosition(global::UnityEngine.AvatarIKHint hint, global::UnityEngine.Vector3 hintPosition)
        {
            internal_UnityEngineAnimator__func__SetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3__SystemVoid(WrappedId, hint, hintPosition);
        }

        public float GetIKHintPositionWeight(global::UnityEngine.AvatarIKHint hint)
        {
            return internal_UnityEngineAnimator__func__GetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle(WrappedId, hint);
        }

        public void SetIKHintPositionWeight(global::UnityEngine.AvatarIKHint hint, float value)
        {
            internal_UnityEngineAnimator__func__SetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle__SystemVoid(WrappedId, hint, value);
        }

        public void SetLookAtPosition(global::UnityEngine.Vector3 lookAtPosition)
        {
            internal_UnityEngineAnimator__func__SetLookAtPosition__UnityEngineVector3__SystemVoid(WrappedId, lookAtPosition);
        }

        public void SetLookAtWeight(float weight)
        {
            internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemVoid(WrappedId, weight);
        }

        public void SetLookAtWeight(float weight, float bodyWeight)
        {
            internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemVoid(WrappedId, weight, bodyWeight);
        }

        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
        {
            internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, weight, bodyWeight, headWeight);
        }

        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
        {
            internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, weight, bodyWeight, headWeight, eyesWeight);
        }

        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
        {
            internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(WrappedId, weight, bodyWeight, headWeight, eyesWeight, clampWeight);
        }

        public void SetBoneLocalRotation(global::UnityEngine.HumanBodyBones humanBoneId, global::UnityEngine.Quaternion rotation)
        {
            internal_UnityEngineAnimator__func__SetBoneLocalRotation__UnityEngineHumanBodyBonesEnum__UnityEngineQuaternion__SystemVoid(WrappedId, humanBoneId, rotation);
        }

        public string GetLayerName(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetLayerName__SystemInt32__SystemString(WrappedId, layerIndex);
        }

        public int GetLayerIndex(string layerName)
        {
            return internal_UnityEngineAnimator__func__GetLayerIndex__SystemString__SystemInt32(WrappedId, layerName);
        }

        public float GetLayerWeight(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetLayerWeight__SystemInt32__SystemSingle(WrappedId, layerIndex);
        }

        public void SetLayerWeight(int layerIndex, float weight)
        {
            internal_UnityEngineAnimator__func__SetLayerWeight__SystemInt32__SystemSingle__SystemVoid(WrappedId, layerIndex, weight);
        }

        public global::UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetCurrentAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(WrappedId, layerIndex);
        }

        public global::UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetNextAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(WrappedId, layerIndex);
        }

        public global::UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetAnimatorTransitionInfo__SystemInt32__UnityEngineAnimatorTransitionInfo(WrappedId, layerIndex);
        }

        public int GetCurrentAnimatorClipInfoCount(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfoCount__SystemInt32__SystemInt32(WrappedId, layerIndex);
        }

        public int GetNextAnimatorClipInfoCount(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetNextAnimatorClipInfoCount__SystemInt32__SystemInt32(WrappedId, layerIndex);
        }

        public global::UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(WrappedId, layerIndex);
        }

        public global::UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(WrappedId, layerIndex);
        }

        public void GetCurrentAnimatorClipInfo(int layerIndex, global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> clips)
        {
            internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(WrappedId, layerIndex, clips);
        }

        public void GetNextAnimatorClipInfo(int layerIndex, global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> clips)
        {
            internal_UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(WrappedId, layerIndex, clips);
        }

        public bool IsInTransition(int layerIndex)
        {
            return internal_UnityEngineAnimator__func__IsInTransition__SystemInt32__SystemBoolean(WrappedId, layerIndex);
        }

        public global::UnityEngine.AnimatorControllerParameter GetParameter(int index)
        {
            return internal_UnityEngineAnimator__func__GetParameter__SystemInt32__UnityEngineAnimatorControllerParameter(WrappedId, index);
        }

        public void MatchTarget(global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime)
        {
            internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemVoid(WrappedId, matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime);
        }

        public void MatchTarget(global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime)
        {
            internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemVoid(WrappedId, matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime);
        }

        public void MatchTarget(global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
        {
            internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(WrappedId, matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime, completeMatch);
        }

        public void InterruptMatchTarget()
        {
            internal_UnityEngineAnimator__func__InterruptMatchTarget__SystemVoid(WrappedId);
        }

        public void InterruptMatchTarget(bool completeMatch)
        {
            internal_UnityEngineAnimator__func__InterruptMatchTarget__SystemBoolean__SystemVoid(WrappedId, completeMatch);
        }

        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemVoid(WrappedId, stateName, fixedTransitionDuration);
        }

        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemVoid(WrappedId, stateName, fixedTransitionDuration, layer);
        }

        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateName, fixedTransitionDuration, layer, fixedTimeOffset);
        }

        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(WrappedId, stateName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
        }

        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateHashName, fixedTransitionDuration, layer, fixedTimeOffset);
        }

        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemVoid(WrappedId, stateHashName, fixedTransitionDuration, layer);
        }

        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateHashName, fixedTransitionDuration);
        }

        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
        {
            internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(WrappedId, stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
        }

        public void WriteDefaultValues()
        {
            internal_UnityEngineAnimator__func__WriteDefaultValues__SystemVoid(WrappedId);
        }

        public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateName, normalizedTransitionDuration, layer, normalizedTimeOffset);
        }

        public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemVoid(WrappedId, stateName, normalizedTransitionDuration, layer);
        }

        public void CrossFade(string stateName, float normalizedTransitionDuration)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemVoid(WrappedId, stateName, normalizedTransitionDuration);
        }

        public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(WrappedId, stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
        }

        public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(WrappedId, stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
        }

        public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset);
        }

        public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemVoid(WrappedId, stateHashName, normalizedTransitionDuration, layer);
        }

        public void CrossFade(int stateHashName, float normalizedTransitionDuration)
        {
            internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateHashName, normalizedTransitionDuration);
        }

        public void PlayInFixedTime(string stateName, int layer)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemVoid(WrappedId, stateName, layer);
        }

        public void PlayInFixedTime(string stateName)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemVoid(WrappedId, stateName);
        }

        public void PlayInFixedTime(string stateName, int layer, float fixedTime)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateName, layer, fixedTime);
        }

        public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateNameHash, layer, fixedTime);
        }

        public void PlayInFixedTime(int stateNameHash, int layer)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemVoid(WrappedId, stateNameHash, layer);
        }

        public void PlayInFixedTime(int stateNameHash)
        {
            internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemVoid(WrappedId, stateNameHash);
        }

        public void Play(string stateName, int layer)
        {
            internal_UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemVoid(WrappedId, stateName, layer);
        }

        public void Play(string stateName)
        {
            internal_UnityEngineAnimator__func__Play__SystemString__SystemVoid(WrappedId, stateName);
        }

        public void Play(string stateName, int layer, float normalizedTime)
        {
            internal_UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateName, layer, normalizedTime);
        }

        public void Play(int stateNameHash, int layer, float normalizedTime)
        {
            internal_UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemSingle__SystemVoid(WrappedId, stateNameHash, layer, normalizedTime);
        }

        public void Play(int stateNameHash, int layer)
        {
            internal_UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemVoid(WrappedId, stateNameHash, layer);
        }

        public void Play(int stateNameHash)
        {
            internal_UnityEngineAnimator__func__Play__SystemInt32__SystemVoid(WrappedId, stateNameHash);
        }

        public void SetTarget(global::UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime)
        {
            internal_UnityEngineAnimator__func__SetTarget__UnityEngineAvatarTargetEnum__SystemSingle__SystemVoid(WrappedId, targetIndex, targetNormalizedTime);
        }

        public global::UnityEngine.Transform GetBoneTransform(global::UnityEngine.HumanBodyBones humanBoneId)
        {
            return internal_UnityEngineAnimator__func__GetBoneTransform__UnityEngineHumanBodyBonesEnum__UnityEngineTransform(WrappedId, humanBoneId);
        }

        public void StartPlayback()
        {
            internal_UnityEngineAnimator__func__StartPlayback__SystemVoid(WrappedId);
        }

        public void StopPlayback()
        {
            internal_UnityEngineAnimator__func__StopPlayback__SystemVoid(WrappedId);
        }

        public void StartRecording(int frameCount)
        {
            internal_UnityEngineAnimator__func__StartRecording__SystemInt32__SystemVoid(WrappedId, frameCount);
        }

        public void StopRecording()
        {
            internal_UnityEngineAnimator__func__StopRecording__SystemVoid(WrappedId);
        }

        public bool HasState(int layerIndex, int stateID)
        {
            return internal_UnityEngineAnimator__func__HasState__SystemInt32__SystemInt32__SystemBoolean(WrappedId, layerIndex, stateID);
        }

        public static int StringToHash(string name)
        {
            return internal_UnityEngineAnimator__func__StringToHash__SystemString__SystemInt32(name);
        }

        public void Update(float deltaTime)
        {
            internal_UnityEngineAnimator__func__Update__SystemSingle__SystemVoid(WrappedId, deltaTime);
        }

        public void Rebind()
        {
            internal_UnityEngineAnimator__func__Rebind__SystemVoid(WrappedId);
        }

        public void ApplyBuiltinRootMotion()
        {
            internal_UnityEngineAnimator__func__ApplyBuiltinRootMotion__SystemVoid(WrappedId);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__isOptimizable(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__isOptimizable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__isHuman(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__isHuman(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__hasRootMotion(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__hasRootMotion(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__humanScale(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__humanScale(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__isInitialized(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__isInitialized(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__deltaPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 deltaPositionValue = default;
            UnityEngineAnimator__get__deltaPosition(selfObjectId, Unsafe.AsPointer(ref deltaPositionValue));
            global::UnityEngine.Vector3 returnResult = deltaPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAnimator__get__deltaRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion deltaRotationValue = default;
            UnityEngineAnimator__get__deltaRotation(selfObjectId, Unsafe.AsPointer(ref deltaRotationValue));
            global::UnityEngine.Quaternion returnResult = deltaRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineAnimator__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__angularVelocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 angularVelocityValue = default;
            UnityEngineAnimator__get__angularVelocity(selfObjectId, Unsafe.AsPointer(ref angularVelocityValue));
            global::UnityEngine.Vector3 returnResult = angularVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__rootPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 rootPositionValue = default;
            UnityEngineAnimator__get__rootPosition(selfObjectId, Unsafe.AsPointer(ref rootPositionValue));
            global::UnityEngine.Vector3 returnResult = rootPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__rootPosition(long selfObjectId, global::UnityEngine.Vector3 rootPosition)
        {
            UnityEngineAnimator__set__rootPosition(selfObjectId, Unsafe.AsPointer(ref rootPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAnimator__get__rootRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion rootRotationValue = default;
            UnityEngineAnimator__get__rootRotation(selfObjectId, Unsafe.AsPointer(ref rootRotationValue));
            global::UnityEngine.Quaternion returnResult = rootRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__rootRotation(long selfObjectId, global::UnityEngine.Quaternion rootRotation)
        {
            UnityEngineAnimator__set__rootRotation(selfObjectId, Unsafe.AsPointer(ref rootRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__applyRootMotion(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__applyRootMotion(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__applyRootMotion(long selfObjectId, bool applyRootMotion)
        {
            var applyRootMotionConverted = Unsafe.As<bool, int>(ref applyRootMotion);
            UnityEngineAnimator__set__applyRootMotion(selfObjectId, applyRootMotionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorUpdateMode internal_UnityEngineAnimator__get__updateMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__updateMode(selfObjectId);
            var returnResult = (global::UnityEngine.AnimatorUpdateMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__updateMode(long selfObjectId, global::UnityEngine.AnimatorUpdateMode updateMode)
        {
            UnityEngineAnimator__set__updateMode(selfObjectId, (int) updateMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__hasTransformHierarchy(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__hasTransformHierarchy(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__gravityWeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__gravityWeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__bodyPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 bodyPositionValue = default;
            UnityEngineAnimator__get__bodyPosition(selfObjectId, Unsafe.AsPointer(ref bodyPositionValue));
            global::UnityEngine.Vector3 returnResult = bodyPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__bodyPosition(long selfObjectId, global::UnityEngine.Vector3 bodyPosition)
        {
            UnityEngineAnimator__set__bodyPosition(selfObjectId, Unsafe.AsPointer(ref bodyPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAnimator__get__bodyRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion bodyRotationValue = default;
            UnityEngineAnimator__get__bodyRotation(selfObjectId, Unsafe.AsPointer(ref bodyRotationValue));
            global::UnityEngine.Quaternion returnResult = bodyRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__bodyRotation(long selfObjectId, global::UnityEngine.Quaternion bodyRotation)
        {
            UnityEngineAnimator__set__bodyRotation(selfObjectId, Unsafe.AsPointer(ref bodyRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__stabilizeFeet(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__stabilizeFeet(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__stabilizeFeet(long selfObjectId, bool stabilizeFeet)
        {
            var stabilizeFeetConverted = Unsafe.As<bool, int>(ref stabilizeFeet);
            UnityEngineAnimator__set__stabilizeFeet(selfObjectId, stabilizeFeetConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__get__layerCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__layerCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorControllerParameter[] internal_UnityEngineAnimator__get__parameters(long selfObjectId)
        {
            long* parametersIdsPointer = default;
            int parametersWasmLength = default;
            UnityEngineAnimator__get__parameters(selfObjectId, &parametersIdsPointer, &parametersWasmLength);
            global::UnityEngine.AnimatorControllerParameter[] returnResult = new global::UnityEngine.AnimatorControllerParameter[parametersWasmLength];
            for (int i = 0; i < parametersWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.AnimatorControllerParameter(parametersIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)parametersIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__get__parameterCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__parameterCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__feetPivotActive(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__feetPivotActive(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__feetPivotActive(long selfObjectId, float feetPivotActive)
        {
            UnityEngineAnimator__set__feetPivotActive(selfObjectId, feetPivotActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__pivotWeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__pivotWeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__pivotPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 pivotPositionValue = default;
            UnityEngineAnimator__get__pivotPosition(selfObjectId, Unsafe.AsPointer(ref pivotPositionValue));
            global::UnityEngine.Vector3 returnResult = pivotPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__isMatchingTarget(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__isMatchingTarget(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__speed(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__speed(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__speed(long selfObjectId, float speed)
        {
            UnityEngineAnimator__set__speed(selfObjectId, speed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__get__targetPosition(long selfObjectId)
        {
            global::UnityEngine.Vector3 targetPositionValue = default;
            UnityEngineAnimator__get__targetPosition(selfObjectId, Unsafe.AsPointer(ref targetPositionValue));
            global::UnityEngine.Vector3 returnResult = targetPositionValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAnimator__get__targetRotation(long selfObjectId)
        {
            global::UnityEngine.Quaternion targetRotationValue = default;
            UnityEngineAnimator__get__targetRotation(selfObjectId, Unsafe.AsPointer(ref targetRotationValue));
            global::UnityEngine.Quaternion returnResult = targetRotationValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorCullingMode internal_UnityEngineAnimator__get__cullingMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__cullingMode(selfObjectId);
            var returnResult = (global::UnityEngine.AnimatorCullingMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__cullingMode(long selfObjectId, global::UnityEngine.AnimatorCullingMode cullingMode)
        {
            UnityEngineAnimator__set__cullingMode(selfObjectId, (int) cullingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__playbackTime(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__playbackTime(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__playbackTime(long selfObjectId, float playbackTime)
        {
            UnityEngineAnimator__set__playbackTime(selfObjectId, playbackTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__recorderStartTime(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__recorderStartTime(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__recorderStartTime(long selfObjectId, float recorderStartTime)
        {
            UnityEngineAnimator__set__recorderStartTime(selfObjectId, recorderStartTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__recorderStopTime(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__recorderStopTime(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__recorderStopTime(long selfObjectId, float recorderStopTime)
        {
            UnityEngineAnimator__set__recorderStopTime(selfObjectId, recorderStopTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorRecorderMode internal_UnityEngineAnimator__get__recorderMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__recorderMode(selfObjectId);
            var returnResult = (global::UnityEngine.AnimatorRecorderMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RuntimeAnimatorController internal_UnityEngineAnimator__get__runtimeAnimatorController(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__runtimeAnimatorController(selfObjectId);
            var returnResult = new global::UnityEngine.RuntimeAnimatorController(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__runtimeAnimatorController(long selfObjectId, global::UnityEngine.RuntimeAnimatorController runtimeAnimatorController)
        {
            UnityEngineAnimator__set__runtimeAnimatorController(selfObjectId, runtimeAnimatorController.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__hasBoundPlayables(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__hasBoundPlayables(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Avatar internal_UnityEngineAnimator__get__avatar(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__avatar(selfObjectId);
            var returnResult = new global::UnityEngine.Avatar(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__avatar(long selfObjectId, global::UnityEngine.Avatar avatar)
        {
            UnityEngineAnimator__set__avatar(selfObjectId, avatar.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__layersAffectMassCenter(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__layersAffectMassCenter(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__layersAffectMassCenter(long selfObjectId, bool layersAffectMassCenter)
        {
            var layersAffectMassCenterConverted = Unsafe.As<bool, int>(ref layersAffectMassCenter);
            UnityEngineAnimator__set__layersAffectMassCenter(selfObjectId, layersAffectMassCenterConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__leftFeetBottomHeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__leftFeetBottomHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__get__rightFeetBottomHeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__rightFeetBottomHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__logWarnings(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__logWarnings(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__logWarnings(long selfObjectId, bool logWarnings)
        {
            var logWarningsConverted = Unsafe.As<bool, int>(ref logWarnings);
            UnityEngineAnimator__set__logWarnings(selfObjectId, logWarningsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__fireEvents(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__fireEvents(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__fireEvents(long selfObjectId, bool fireEvents)
        {
            var fireEventsConverted = Unsafe.As<bool, int>(ref fireEvents);
            UnityEngineAnimator__set__fireEvents(selfObjectId, fireEventsConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__keepAnimatorStateOnDisable(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__keepAnimatorStateOnDisable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__keepAnimatorStateOnDisable(long selfObjectId, bool keepAnimatorStateOnDisable)
        {
            var keepAnimatorStateOnDisableConverted = Unsafe.As<bool, int>(ref keepAnimatorStateOnDisable);
            UnityEngineAnimator__set__keepAnimatorStateOnDisable(selfObjectId, keepAnimatorStateOnDisableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__get__writeDefaultValuesOnDisable(long selfObjectId)
        {
            var methodCallResult = UnityEngineAnimator__get__writeDefaultValuesOnDisable(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__set__writeDefaultValuesOnDisable(long selfObjectId, bool writeDefaultValuesOnDisable)
        {
            var writeDefaultValuesOnDisableConverted = Unsafe.As<bool, int>(ref writeDefaultValuesOnDisable);
            UnityEngineAnimator__set__writeDefaultValuesOnDisable(selfObjectId, writeDefaultValuesOnDisableConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetFloat__SystemString__SystemSingle(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAnimator__func__GetFloat__SystemString__SystemSingle(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int id)
        {
            var methodCallResult = UnityEngineAnimator__func__GetFloat__SystemInt32__SystemSingle(selfObjectId, id);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, string name, float value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string name, float value, float dampTime, float deltaTime)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value, dampTime, deltaTime);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int id, float value)
        {
            UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(selfObjectId, id, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int id, float value, float dampTime, float deltaTime)
        {
            UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, id, value, dampTime, deltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__GetBool__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAnimator__func__GetBool__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__GetBool__SystemInt32__SystemBoolean(long selfObjectId, int id)
        {
            var methodCallResult = UnityEngineAnimator__func__GetBool__SystemInt32__SystemBoolean(selfObjectId, id);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, string name, bool value)
        {
            fixed (char* namePointer = name)
            {
                var valueConverted = Unsafe.As<bool, int>(ref value);
                UnityEngineAnimator__func__SetBool__SystemString__SystemBoolean__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), valueConverted);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int id, bool value)
        {
            var valueConverted = Unsafe.As<bool, int>(ref value);
            UnityEngineAnimator__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(selfObjectId, id, valueConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__GetInteger__SystemString__SystemInt32(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAnimator__func__GetInteger__SystemString__SystemInt32(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int id)
        {
            var methodCallResult = UnityEngineAnimator__func__GetInteger__SystemInt32__SystemInt32(selfObjectId, id);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, string name, int value)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineAnimator__func__SetInteger__SystemString__SystemInt32__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char), value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int id, int value)
        {
            UnityEngineAnimator__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(selfObjectId, id, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetTrigger__SystemString__SystemVoid(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineAnimator__func__SetTrigger__SystemString__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetTrigger__SystemInt32__SystemVoid(long selfObjectId, int id)
        {
            UnityEngineAnimator__func__SetTrigger__SystemInt32__SystemVoid(selfObjectId, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__ResetTrigger__SystemString__SystemVoid(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                UnityEngineAnimator__func__ResetTrigger__SystemString__SystemVoid(selfObjectId, namePointer, name.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__ResetTrigger__SystemInt32__SystemVoid(long selfObjectId, int id)
        {
            UnityEngineAnimator__func__ResetTrigger__SystemInt32__SystemVoid(selfObjectId, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__IsParameterControlledByCurve__SystemString__SystemBoolean(long selfObjectId, string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAnimator__func__IsParameterControlledByCurve__SystemString__SystemBoolean(selfObjectId, namePointer, name.Length * sizeof(char));
                var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__IsParameterControlledByCurve__SystemInt32__SystemBoolean(long selfObjectId, int id)
        {
            var methodCallResult = UnityEngineAnimator__func__IsParameterControlledByCurve__SystemInt32__SystemBoolean(selfObjectId, id);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__func__GetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.AvatarIKGoal goal)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineAnimator__func__GetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3(selfObjectId, (int) goal, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKGoal goal, global::UnityEngine.Vector3 goalPosition)
        {
            UnityEngineAnimator__func__SetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3__SystemVoid(selfObjectId, (int) goal, Unsafe.AsPointer(ref goalPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Quaternion internal_UnityEngineAnimator__func__GetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion(long selfObjectId, global::UnityEngine.AvatarIKGoal goal)
        {
            global::UnityEngine.Quaternion returnResultValue = default;
            UnityEngineAnimator__func__GetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion(selfObjectId, (int) goal, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Quaternion returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKGoal goal, global::UnityEngine.Quaternion goalRotation)
        {
            UnityEngineAnimator__func__SetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion__SystemVoid(selfObjectId, (int) goal, Unsafe.AsPointer(ref goalRotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(long selfObjectId, global::UnityEngine.AvatarIKGoal goal)
        {
            var methodCallResult = UnityEngineAnimator__func__GetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(selfObjectId, (int) goal);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKGoal goal, float value)
        {
            UnityEngineAnimator__func__SetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(selfObjectId, (int) goal, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(long selfObjectId, global::UnityEngine.AvatarIKGoal goal)
        {
            var methodCallResult = UnityEngineAnimator__func__GetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(selfObjectId, (int) goal);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKGoal goal, float value)
        {
            UnityEngineAnimator__func__SetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(selfObjectId, (int) goal, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineAnimator__func__GetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.AvatarIKHint hint)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineAnimator__func__GetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3(selfObjectId, (int) hint, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKHint hint, global::UnityEngine.Vector3 hintPosition)
        {
            UnityEngineAnimator__func__SetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3__SystemVoid(selfObjectId, (int) hint, Unsafe.AsPointer(ref hintPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle(long selfObjectId, global::UnityEngine.AvatarIKHint hint)
        {
            var methodCallResult = UnityEngineAnimator__func__GetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle(selfObjectId, (int) hint);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.AvatarIKHint hint, float value)
        {
            UnityEngineAnimator__func__SetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle__SystemVoid(selfObjectId, (int) hint, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtPosition__UnityEngineVector3__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 lookAtPosition)
        {
            UnityEngineAnimator__func__SetLookAtPosition__UnityEngineVector3__SystemVoid(selfObjectId, Unsafe.AsPointer(ref lookAtPosition));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemVoid(long selfObjectId, float weight)
        {
            UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemVoid(selfObjectId, weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight)
        {
            UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemVoid(selfObjectId, weight, bodyWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight)
        {
            UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, weight, bodyWeight, headWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight, float eyesWeight)
        {
            UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, weight, bodyWeight, headWeight, eyesWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
        {
            UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(selfObjectId, weight, bodyWeight, headWeight, eyesWeight, clampWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetBoneLocalRotation__UnityEngineHumanBodyBonesEnum__UnityEngineQuaternion__SystemVoid(long selfObjectId, global::UnityEngine.HumanBodyBones humanBoneId, global::UnityEngine.Quaternion rotation)
        {
            UnityEngineAnimator__func__SetBoneLocalRotation__UnityEngineHumanBodyBonesEnum__UnityEngineQuaternion__SystemVoid(selfObjectId, (int) humanBoneId, Unsafe.AsPointer(ref rotation));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe string internal_UnityEngineAnimator__func__GetLayerName__SystemInt32__SystemString(long selfObjectId, int layerIndex)
        {
            char* returnResultPointer = default;
            int returnResultWasmLength = default;
            UnityEngineAnimator__func__GetLayerName__SystemInt32__SystemString(selfObjectId, layerIndex, &returnResultPointer, &returnResultWasmLength);
            string returnResult = new(returnResultPointer, 0, returnResultWasmLength);
            Marshal.FreeHGlobal((IntPtr)returnResultPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__GetLayerIndex__SystemString__SystemInt32(long selfObjectId, string layerName)
        {
            fixed (char* layerNamePointer = layerName)
            {
                var methodCallResult = UnityEngineAnimator__func__GetLayerIndex__SystemString__SystemInt32(selfObjectId, layerNamePointer, layerName.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineAnimator__func__GetLayerWeight__SystemInt32__SystemSingle(long selfObjectId, int layerIndex)
        {
            var methodCallResult = UnityEngineAnimator__func__GetLayerWeight__SystemInt32__SystemSingle(selfObjectId, layerIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetLayerWeight__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int layerIndex, float weight)
        {
            UnityEngineAnimator__func__SetLayerWeight__SystemInt32__SystemSingle__SystemVoid(selfObjectId, layerIndex, weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorStateInfo internal_UnityEngineAnimator__func__GetCurrentAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(long selfObjectId, int layerIndex)
        {
            global::UnityEngine.AnimatorStateInfo returnResultValue = default;
            UnityEngineAnimator__func__GetCurrentAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(selfObjectId, layerIndex, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AnimatorStateInfo returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorStateInfo internal_UnityEngineAnimator__func__GetNextAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(long selfObjectId, int layerIndex)
        {
            global::UnityEngine.AnimatorStateInfo returnResultValue = default;
            UnityEngineAnimator__func__GetNextAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(selfObjectId, layerIndex, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AnimatorStateInfo returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorTransitionInfo internal_UnityEngineAnimator__func__GetAnimatorTransitionInfo__SystemInt32__UnityEngineAnimatorTransitionInfo(long selfObjectId, int layerIndex)
        {
            global::UnityEngine.AnimatorTransitionInfo returnResultValue = default;
            UnityEngineAnimator__func__GetAnimatorTransitionInfo__SystemInt32__UnityEngineAnimatorTransitionInfo(selfObjectId, layerIndex, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.AnimatorTransitionInfo returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfoCount__SystemInt32__SystemInt32(long selfObjectId, int layerIndex)
        {
            var methodCallResult = UnityEngineAnimator__func__GetCurrentAnimatorClipInfoCount__SystemInt32__SystemInt32(selfObjectId, layerIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__GetNextAnimatorClipInfoCount__SystemInt32__SystemInt32(long selfObjectId, int layerIndex)
        {
            var methodCallResult = UnityEngineAnimator__func__GetNextAnimatorClipInfoCount__SystemInt32__SystemInt32(selfObjectId, layerIndex);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorClipInfo[] internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(long selfObjectId, int layerIndex)
        {
            global::UnityEngine.AnimatorClipInfo* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(selfObjectId, layerIndex, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.AnimatorClipInfo[] returnResult = new global::UnityEngine.AnimatorClipInfo[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorClipInfo[] internal_UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(long selfObjectId, int layerIndex)
        {
            global::UnityEngine.AnimatorClipInfo* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(selfObjectId, layerIndex, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.AnimatorClipInfo[] returnResult = new global::UnityEngine.AnimatorClipInfo[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = returnResultIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(long selfObjectId, int layerIndex, global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> clipsList)
        {
            Span<global::UnityEngine.AnimatorClipInfo> clips = CollectionsMarshal.AsSpan(clipsList);
            fixed (global::UnityEngine.AnimatorClipInfo* clipsPointer = clips)
            {
                UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(selfObjectId, layerIndex, clipsPointer, clips.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(long selfObjectId, int layerIndex, global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> clipsList)
        {
            Span<global::UnityEngine.AnimatorClipInfo> clips = CollectionsMarshal.AsSpan(clipsList);
            fixed (global::UnityEngine.AnimatorClipInfo* clipsPointer = clips)
            {
                UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(selfObjectId, layerIndex, clipsPointer, clips.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__IsInTransition__SystemInt32__SystemBoolean(long selfObjectId, int layerIndex)
        {
            var methodCallResult = UnityEngineAnimator__func__IsInTransition__SystemInt32__SystemBoolean(selfObjectId, layerIndex);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.AnimatorControllerParameter internal_UnityEngineAnimator__func__GetParameter__SystemInt32__UnityEngineAnimatorControllerParameter(long selfObjectId, int index)
        {
            var methodCallResult = UnityEngineAnimator__func__GetParameter__SystemInt32__UnityEngineAnimatorControllerParameter(selfObjectId, index);
            var returnResult = new global::UnityEngine.AnimatorControllerParameter(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime)
        {
            UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matchPosition), Unsafe.AsPointer(ref matchRotation), (int) targetBodyPart, Unsafe.AsPointer(ref weightMask), startNormalizedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime)
        {
            UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matchPosition), Unsafe.AsPointer(ref matchRotation), (int) targetBodyPart, Unsafe.AsPointer(ref weightMask), startNormalizedTime, targetNormalizedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, global::UnityEngine.Vector3 matchPosition, global::UnityEngine.Quaternion matchRotation, global::UnityEngine.AvatarTarget targetBodyPart, global::UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
        {
            var completeMatchConverted = Unsafe.As<bool, int>(ref completeMatch);
            UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(selfObjectId, Unsafe.AsPointer(ref matchPosition), Unsafe.AsPointer(ref matchRotation), (int) targetBodyPart, Unsafe.AsPointer(ref weightMask), startNormalizedTime, targetNormalizedTime, completeMatchConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__InterruptMatchTarget__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__InterruptMatchTarget__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__InterruptMatchTarget__SystemBoolean__SystemVoid(long selfObjectId, bool completeMatch)
        {
            var completeMatchConverted = Unsafe.As<bool, int>(ref completeMatch);
            UnityEngineAnimator__func__InterruptMatchTarget__SystemBoolean__SystemVoid(selfObjectId, completeMatchConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemVoid(long selfObjectId, string stateName, float fixedTransitionDuration)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), fixedTransitionDuration);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, string stateName, float fixedTransitionDuration, int layer)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), fixedTransitionDuration, layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), fixedTransitionDuration, layer, fixedTimeOffset);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
        {
            UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateHashName, fixedTransitionDuration, layer, fixedTimeOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer)
        {
            UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemVoid(selfObjectId, stateHashName, fixedTransitionDuration, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration)
        {
            UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateHashName, fixedTransitionDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
        {
            UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(selfObjectId, stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__WriteDefaultValues__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__WriteDefaultValues__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), normalizedTransitionDuration, layer, normalizedTimeOffset);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, string stateName, float normalizedTransitionDuration, int layer)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), normalizedTransitionDuration, layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemVoid(long selfObjectId, string stateName, float normalizedTransitionDuration)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), normalizedTransitionDuration);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
        {
            UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(selfObjectId, stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
        {
            UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer)
        {
            UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemVoid(selfObjectId, stateHashName, normalizedTransitionDuration, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration)
        {
            UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateHashName, normalizedTransitionDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemVoid(long selfObjectId, string stateName, int layer)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemVoid(long selfObjectId, string stateName)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, string stateName, int layer, float fixedTime)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), layer, fixedTime);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateNameHash, int layer, float fixedTime)
        {
            UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNameHash, layer, fixedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash, int layer)
        {
            UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemVoid(selfObjectId, stateNameHash, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash)
        {
            UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemVoid(selfObjectId, stateNameHash);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemVoid(long selfObjectId, string stateName, int layer)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), layer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemString__SystemVoid(long selfObjectId, string stateName)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__Play__SystemString__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, string stateName, int layer, float normalizedTime)
        {
            fixed (char* stateNamePointer = stateName)
            {
                UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNamePointer, stateName.Length * sizeof(char), layer, normalizedTime);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateNameHash, int layer, float normalizedTime)
        {
            UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemSingle__SystemVoid(selfObjectId, stateNameHash, layer, normalizedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash, int layer)
        {
            UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemVoid(selfObjectId, stateNameHash, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Play__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash)
        {
            UnityEngineAnimator__func__Play__SystemInt32__SystemVoid(selfObjectId, stateNameHash);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__SetTarget__UnityEngineAvatarTargetEnum__SystemSingle__SystemVoid(long selfObjectId, global::UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime)
        {
            UnityEngineAnimator__func__SetTarget__UnityEngineAvatarTargetEnum__SystemSingle__SystemVoid(selfObjectId, (int) targetIndex, targetNormalizedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineAnimator__func__GetBoneTransform__UnityEngineHumanBodyBonesEnum__UnityEngineTransform(long selfObjectId, global::UnityEngine.HumanBodyBones humanBoneId)
        {
            var methodCallResult = UnityEngineAnimator__func__GetBoneTransform__UnityEngineHumanBodyBonesEnum__UnityEngineTransform(selfObjectId, (int) humanBoneId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__StartPlayback__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__StartPlayback__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__StopPlayback__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__StopPlayback__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__StartRecording__SystemInt32__SystemVoid(long selfObjectId, int frameCount)
        {
            UnityEngineAnimator__func__StartRecording__SystemInt32__SystemVoid(selfObjectId, frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__StopRecording__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__StopRecording__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineAnimator__func__HasState__SystemInt32__SystemInt32__SystemBoolean(long selfObjectId, int layerIndex, int stateID)
        {
            var methodCallResult = UnityEngineAnimator__func__HasState__SystemInt32__SystemInt32__SystemBoolean(selfObjectId, layerIndex, stateID);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineAnimator__func__StringToHash__SystemString__SystemInt32(string name)
        {
            fixed (char* namePointer = name)
            {
                var methodCallResult = UnityEngineAnimator__func__StringToHash__SystemString__SystemInt32(namePointer, name.Length * sizeof(char));
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Update__SystemSingle__SystemVoid(long selfObjectId, float deltaTime)
        {
            UnityEngineAnimator__func__Update__SystemSingle__SystemVoid(selfObjectId, deltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__Rebind__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__Rebind__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineAnimator__func__ApplyBuiltinRootMotion__SystemVoid(long selfObjectId)
        {
            UnityEngineAnimator__func__ApplyBuiltinRootMotion__SystemVoid(selfObjectId);
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__isOptimizable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__isHuman(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__hasRootMotion(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__humanScale(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__isInitialized(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__deltaPosition(long selfObjectId, void* deltaPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__deltaRotation(long selfObjectId, void* deltaRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__angularVelocity(long selfObjectId, void* angularVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__rootPosition(long selfObjectId, void* rootPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__set__rootPosition(long selfObjectId, void* rootPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__rootRotation(long selfObjectId, void* rootRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__set__rootRotation(long selfObjectId, void* rootRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__applyRootMotion(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__applyRootMotion(long selfObjectId, int applyRootMotionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__updateMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__updateMode(long selfObjectId, int updateModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__hasTransformHierarchy(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__gravityWeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__bodyPosition(long selfObjectId, void* bodyPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__set__bodyPosition(long selfObjectId, void* bodyPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__bodyRotation(long selfObjectId, void* bodyRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__set__bodyRotation(long selfObjectId, void* bodyRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__stabilizeFeet(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__stabilizeFeet(long selfObjectId, int stabilizeFeetConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__layerCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__parameters(long selfObjectId, void* parametersIdsPointer, void* parametersWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__parameterCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__feetPivotActive(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__feetPivotActive(long selfObjectId, float feetPivotActive);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__pivotWeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__pivotPosition(long selfObjectId, void* pivotPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__isMatchingTarget(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__speed(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__speed(long selfObjectId, float speed);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__targetPosition(long selfObjectId, void* targetPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__get__targetRotation(long selfObjectId, void* targetRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__cullingMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__cullingMode(long selfObjectId, int cullingModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__playbackTime(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__playbackTime(long selfObjectId, float playbackTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__recorderStartTime(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__recorderStartTime(long selfObjectId, float recorderStartTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__recorderStopTime(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__recorderStopTime(long selfObjectId, float recorderStopTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__recorderMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimator__get__runtimeAnimatorController(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__runtimeAnimatorController(long selfObjectId, long runtimeAnimatorControllerObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__hasBoundPlayables(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimator__get__avatar(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__avatar(long selfObjectId, long avatarObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__layersAffectMassCenter(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__layersAffectMassCenter(long selfObjectId, int layersAffectMassCenterConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__leftFeetBottomHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__get__rightFeetBottomHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__logWarnings(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__logWarnings(long selfObjectId, int logWarningsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__fireEvents(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__fireEvents(long selfObjectId, int fireEventsConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__keepAnimatorStateOnDisable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__keepAnimatorStateOnDisable(long selfObjectId, int keepAnimatorStateOnDisableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__get__writeDefaultValuesOnDisable(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__set__writeDefaultValuesOnDisable(long selfObjectId, int writeDefaultValuesOnDisableConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe float UnityEngineAnimator__func__GetFloat__SystemString__SystemSingle(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__func__GetFloat__SystemInt32__SystemSingle(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetFloat__SystemString__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, float value, float dampTime, float deltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int id, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetFloat__SystemInt32__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int id, float value, float dampTime, float deltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimator__func__GetBool__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__GetBool__SystemInt32__SystemBoolean(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetBool__SystemString__SystemBoolean__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetBool__SystemInt32__SystemBoolean__SystemVoid(long selfObjectId, int id, int valueConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimator__func__GetInteger__SystemString__SystemInt32(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__GetInteger__SystemInt32__SystemInt32(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetInteger__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetInteger__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int id, int value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetTrigger__SystemString__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetTrigger__SystemInt32__SystemVoid(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__ResetTrigger__SystemString__SystemVoid(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__ResetTrigger__SystemInt32__SystemVoid(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimator__func__IsParameterControlledByCurve__SystemString__SystemBoolean(long selfObjectId, void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__IsParameterControlledByCurve__SystemInt32__SystemBoolean(long selfObjectId, int id);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3(long selfObjectId, int goalUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetIKPosition__UnityEngineAvatarIKGoalEnum__UnityEngineVector3__SystemVoid(long selfObjectId, int goalUnderlyingValue, void* goalPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion(long selfObjectId, int goalUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetIKRotation__UnityEngineAvatarIKGoalEnum__UnityEngineQuaternion__SystemVoid(long selfObjectId, int goalUnderlyingValue, void* goalRotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__func__GetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(long selfObjectId, int goalUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetIKPositionWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(long selfObjectId, int goalUnderlyingValue, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__func__GetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle(long selfObjectId, int goalUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetIKRotationWeight__UnityEngineAvatarIKGoalEnum__SystemSingle__SystemVoid(long selfObjectId, int goalUnderlyingValue, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3(long selfObjectId, int hintUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetIKHintPosition__UnityEngineAvatarIKHintEnum__UnityEngineVector3__SystemVoid(long selfObjectId, int hintUnderlyingValue, void* hintPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__func__GetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle(long selfObjectId, int hintUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetIKHintPositionWeight__UnityEngineAvatarIKHintEnum__SystemSingle__SystemVoid(long selfObjectId, int hintUnderlyingValue, float value);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetLookAtPosition__UnityEngineVector3__SystemVoid(long selfObjectId, void* lookAtPositionPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemVoid(long selfObjectId, float weight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight, float eyesWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLookAtWeight__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__SetBoneLocalRotation__UnityEngineHumanBodyBonesEnum__UnityEngineQuaternion__SystemVoid(long selfObjectId, int humanBoneIdUnderlyingValue, void* rotationPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetLayerName__SystemInt32__SystemString(long selfObjectId, int layerIndex, void* returnResultPointer, void* returnResultWasmLengthsPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimator__func__GetLayerIndex__SystemString__SystemInt32(long selfObjectId, void* layerNamePointer, int layerNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineAnimator__func__GetLayerWeight__SystemInt32__SystemSingle(long selfObjectId, int layerIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetLayerWeight__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int layerIndex, float weight);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetCurrentAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(long selfObjectId, int layerIndex, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetNextAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(long selfObjectId, int layerIndex, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetAnimatorTransitionInfo__SystemInt32__UnityEngineAnimatorTransitionInfo(long selfObjectId, int layerIndex, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__GetCurrentAnimatorClipInfoCount__SystemInt32__SystemInt32(long selfObjectId, int layerIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__GetNextAnimatorClipInfoCount__SystemInt32__SystemInt32(long selfObjectId, int layerIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(long selfObjectId, int layerIndex, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(long selfObjectId, int layerIndex, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetCurrentAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(long selfObjectId, int layerIndex, void* clipsPointer, int clipsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__GetNextAnimatorClipInfo__SystemInt32__SystemCollectionsGeneric_List_UnityEngineAnimatorClipInfo__SystemVoid(long selfObjectId, int layerIndex, void* clipsPointer, int clipsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__IsInTransition__SystemInt32__SystemBoolean(long selfObjectId, int layerIndex);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimator__func__GetParameter__SystemInt32__UnityEngineAnimatorControllerParameter(long selfObjectId, int index);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemVoid(long selfObjectId, void* matchPositionPointer, void* matchRotationPointer, int targetBodyPartUnderlyingValue, void* weightMaskPointer, float startNormalizedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* matchPositionPointer, void* matchRotationPointer, int targetBodyPartUnderlyingValue, void* weightMaskPointer, float startNormalizedTime, float targetNormalizedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__MatchTarget__UnityEngineVector3__UnityEngineQuaternion__UnityEngineAvatarTargetEnum__UnityEngineMatchTargetWeightMask__SystemSingle__SystemSingle__SystemBoolean__SystemVoid(long selfObjectId, void* matchPositionPointer, void* matchRotationPointer, int targetBodyPartUnderlyingValue, void* weightMaskPointer, float startNormalizedTime, float targetNormalizedTime, int completeMatchConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__InterruptMatchTarget__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__InterruptMatchTarget__SystemBoolean__SystemVoid(long selfObjectId, int completeMatchConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float fixedTransitionDuration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float fixedTransitionDuration, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float fixedTransitionDuration, int layer, float fixedTimeOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFadeInFixedTime__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__WriteDefaultValues__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float normalizedTransitionDuration, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float normalizedTransitionDuration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__CrossFade__SystemString__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemInt32__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__CrossFade__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateHashName, float normalizedTransitionDuration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__PlayInFixedTime__SystemString__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, int layer, float fixedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateNameHash, int layer, float fixedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__PlayInFixedTime__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__Play__SystemString__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineAnimator__func__Play__SystemString__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, void* stateNamePointer, int stateNameWasmLength, int layer, float normalizedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemSingle__SystemVoid(long selfObjectId, int stateNameHash, int layer, float normalizedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__Play__SystemInt32__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash, int layer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__Play__SystemInt32__SystemVoid(long selfObjectId, int stateNameHash);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__SetTarget__UnityEngineAvatarTargetEnum__SystemSingle__SystemVoid(long selfObjectId, int targetIndexUnderlyingValue, float targetNormalizedTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineAnimator__func__GetBoneTransform__UnityEngineHumanBodyBonesEnum__UnityEngineTransform(long selfObjectId, int humanBoneIdUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__StartPlayback__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__StopPlayback__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__StartRecording__SystemInt32__SystemVoid(long selfObjectId, int frameCount);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__StopRecording__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineAnimator__func__HasState__SystemInt32__SystemInt32__SystemBoolean(long selfObjectId, int layerIndex, int stateID);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineAnimator__func__StringToHash__SystemString__SystemInt32(void* namePointer, int nameWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__Update__SystemSingle__SystemVoid(long selfObjectId, float deltaTime);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__Rebind__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineAnimator__func__ApplyBuiltinRootMotion__SystemVoid(long selfObjectId);

        #endregion Imports
    }
}
