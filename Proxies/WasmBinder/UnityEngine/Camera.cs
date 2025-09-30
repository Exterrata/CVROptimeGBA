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

    public partial class Camera(long id) : Behaviour(id)
    {

        #region Fields Delegates

        public static global::UnityEngine.Camera.CameraCallback onPreCull;
        public static global::UnityEngine.Camera.CameraCallback onPreRender;
        public static global::UnityEngine.Camera.CameraCallback onPostRender;

        #endregion Fields Delegates

        #region Implementation

        public float nearClipPlane 
        {
            get => internal_UnityEngineCamera__get__nearClipPlane(WrappedId);
            set => internal_UnityEngineCamera__set__nearClipPlane(WrappedId, value);
        }

        public float farClipPlane 
        {
            get => internal_UnityEngineCamera__get__farClipPlane(WrappedId);
            set => internal_UnityEngineCamera__set__farClipPlane(WrappedId, value);
        }

        public float fieldOfView 
        {
            get => internal_UnityEngineCamera__get__fieldOfView(WrappedId);
            set => internal_UnityEngineCamera__set__fieldOfView(WrappedId, value);
        }

        public global::UnityEngine.RenderingPath renderingPath 
        {
            get => internal_UnityEngineCamera__get__renderingPath(WrappedId);
            set => internal_UnityEngineCamera__set__renderingPath(WrappedId, value);
        }

        public global::UnityEngine.RenderingPath actualRenderingPath 
        {
            get => internal_UnityEngineCamera__get__actualRenderingPath(WrappedId);
        }

        public bool allowHDR 
        {
            get => internal_UnityEngineCamera__get__allowHDR(WrappedId);
            set => internal_UnityEngineCamera__set__allowHDR(WrappedId, value);
        }

        public bool allowMSAA 
        {
            get => internal_UnityEngineCamera__get__allowMSAA(WrappedId);
            set => internal_UnityEngineCamera__set__allowMSAA(WrappedId, value);
        }

        public bool allowDynamicResolution 
        {
            get => internal_UnityEngineCamera__get__allowDynamicResolution(WrappedId);
            set => internal_UnityEngineCamera__set__allowDynamicResolution(WrappedId, value);
        }

        public bool forceIntoRenderTexture 
        {
            get => internal_UnityEngineCamera__get__forceIntoRenderTexture(WrappedId);
            set => internal_UnityEngineCamera__set__forceIntoRenderTexture(WrappedId, value);
        }

        public float orthographicSize 
        {
            get => internal_UnityEngineCamera__get__orthographicSize(WrappedId);
            set => internal_UnityEngineCamera__set__orthographicSize(WrappedId, value);
        }

        public bool orthographic 
        {
            get => internal_UnityEngineCamera__get__orthographic(WrappedId);
            set => internal_UnityEngineCamera__set__orthographic(WrappedId, value);
        }

        public global::UnityEngine.Rendering.OpaqueSortMode opaqueSortMode 
        {
            get => internal_UnityEngineCamera__get__opaqueSortMode(WrappedId);
            set => internal_UnityEngineCamera__set__opaqueSortMode(WrappedId, value);
        }

        public global::UnityEngine.TransparencySortMode transparencySortMode 
        {
            get => internal_UnityEngineCamera__get__transparencySortMode(WrappedId);
            set => internal_UnityEngineCamera__set__transparencySortMode(WrappedId, value);
        }

        public global::UnityEngine.Vector3 transparencySortAxis 
        {
            get => internal_UnityEngineCamera__get__transparencySortAxis(WrappedId);
            set => internal_UnityEngineCamera__set__transparencySortAxis(WrappedId, value);
        }

        public float depth 
        {
            get => internal_UnityEngineCamera__get__depth(WrappedId);
            set => internal_UnityEngineCamera__set__depth(WrappedId, value);
        }

        public float aspect 
        {
            get => internal_UnityEngineCamera__get__aspect(WrappedId);
            set => internal_UnityEngineCamera__set__aspect(WrappedId, value);
        }

        public global::UnityEngine.Vector3 velocity 
        {
            get => internal_UnityEngineCamera__get__velocity(WrappedId);
        }

        public int cullingMask 
        {
            get => internal_UnityEngineCamera__get__cullingMask(WrappedId);
            set => internal_UnityEngineCamera__set__cullingMask(WrappedId, value);
        }

        public int eventMask 
        {
            get => internal_UnityEngineCamera__get__eventMask(WrappedId);
            set => internal_UnityEngineCamera__set__eventMask(WrappedId, value);
        }

        public bool layerCullSpherical 
        {
            get => internal_UnityEngineCamera__get__layerCullSpherical(WrappedId);
            set => internal_UnityEngineCamera__set__layerCullSpherical(WrappedId, value);
        }

        public global::UnityEngine.CameraType cameraType 
        {
            get => internal_UnityEngineCamera__get__cameraType(WrappedId);
            set => internal_UnityEngineCamera__set__cameraType(WrappedId, value);
        }

        public ulong overrideSceneCullingMask 
        {
            get => internal_UnityEngineCamera__get__overrideSceneCullingMask(WrappedId);
            set => internal_UnityEngineCamera__set__overrideSceneCullingMask(WrappedId, value);
        }

        public global::System.Single[] layerCullDistances 
        {
            get => internal_UnityEngineCamera__get__layerCullDistances(WrappedId);
            set => internal_UnityEngineCamera__set__layerCullDistances(WrappedId, value);
        }

        public bool useOcclusionCulling 
        {
            get => internal_UnityEngineCamera__get__useOcclusionCulling(WrappedId);
            set => internal_UnityEngineCamera__set__useOcclusionCulling(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 cullingMatrix 
        {
            get => internal_UnityEngineCamera__get__cullingMatrix(WrappedId);
            set => internal_UnityEngineCamera__set__cullingMatrix(WrappedId, value);
        }

        public global::UnityEngine.Color backgroundColor 
        {
            get => internal_UnityEngineCamera__get__backgroundColor(WrappedId);
            set => internal_UnityEngineCamera__set__backgroundColor(WrappedId, value);
        }

        public global::UnityEngine.CameraClearFlags clearFlags 
        {
            get => internal_UnityEngineCamera__get__clearFlags(WrappedId);
            set => internal_UnityEngineCamera__set__clearFlags(WrappedId, value);
        }

        public global::UnityEngine.DepthTextureMode depthTextureMode 
        {
            get => internal_UnityEngineCamera__get__depthTextureMode(WrappedId);
            set => internal_UnityEngineCamera__set__depthTextureMode(WrappedId, value);
        }

        public bool clearStencilAfterLightingPass 
        {
            get => internal_UnityEngineCamera__get__clearStencilAfterLightingPass(WrappedId);
            set => internal_UnityEngineCamera__set__clearStencilAfterLightingPass(WrappedId, value);
        }

        public bool usePhysicalProperties 
        {
            get => internal_UnityEngineCamera__get__usePhysicalProperties(WrappedId);
            set => internal_UnityEngineCamera__set__usePhysicalProperties(WrappedId, value);
        }

        public global::UnityEngine.Vector2 sensorSize 
        {
            get => internal_UnityEngineCamera__get__sensorSize(WrappedId);
            set => internal_UnityEngineCamera__set__sensorSize(WrappedId, value);
        }

        public global::UnityEngine.Vector2 lensShift 
        {
            get => internal_UnityEngineCamera__get__lensShift(WrappedId);
            set => internal_UnityEngineCamera__set__lensShift(WrappedId, value);
        }

        public float focalLength 
        {
            get => internal_UnityEngineCamera__get__focalLength(WrappedId);
            set => internal_UnityEngineCamera__set__focalLength(WrappedId, value);
        }

        public global::UnityEngine.Camera.GateFitMode gateFit 
        {
            get => internal_UnityEngineCamera__get__gateFit(WrappedId);
            set => internal_UnityEngineCamera__set__gateFit(WrappedId, value);
        }

        public global::UnityEngine.Rect rect 
        {
            get => internal_UnityEngineCamera__get__rect(WrappedId);
            set => internal_UnityEngineCamera__set__rect(WrappedId, value);
        }

        public global::UnityEngine.Rect pixelRect 
        {
            get => internal_UnityEngineCamera__get__pixelRect(WrappedId);
            set => internal_UnityEngineCamera__set__pixelRect(WrappedId, value);
        }

        public int pixelWidth 
        {
            get => internal_UnityEngineCamera__get__pixelWidth(WrappedId);
        }

        public int pixelHeight 
        {
            get => internal_UnityEngineCamera__get__pixelHeight(WrappedId);
        }

        public int scaledPixelWidth 
        {
            get => internal_UnityEngineCamera__get__scaledPixelWidth(WrappedId);
        }

        public int scaledPixelHeight 
        {
            get => internal_UnityEngineCamera__get__scaledPixelHeight(WrappedId);
        }

        public global::UnityEngine.RenderTexture targetTexture 
        {
            get => internal_UnityEngineCamera__get__targetTexture(WrappedId);
            set => internal_UnityEngineCamera__set__targetTexture(WrappedId, value);
        }

        public global::UnityEngine.RenderTexture activeTexture 
        {
            get => internal_UnityEngineCamera__get__activeTexture(WrappedId);
        }

        public int targetDisplay 
        {
            get => internal_UnityEngineCamera__get__targetDisplay(WrappedId);
            set => internal_UnityEngineCamera__set__targetDisplay(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 cameraToWorldMatrix 
        {
            get => internal_UnityEngineCamera__get__cameraToWorldMatrix(WrappedId);
        }

        public global::UnityEngine.Matrix4x4 worldToCameraMatrix 
        {
            get => internal_UnityEngineCamera__get__worldToCameraMatrix(WrappedId);
            set => internal_UnityEngineCamera__set__worldToCameraMatrix(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 projectionMatrix 
        {
            get => internal_UnityEngineCamera__get__projectionMatrix(WrappedId);
            set => internal_UnityEngineCamera__set__projectionMatrix(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 nonJitteredProjectionMatrix 
        {
            get => internal_UnityEngineCamera__get__nonJitteredProjectionMatrix(WrappedId);
            set => internal_UnityEngineCamera__set__nonJitteredProjectionMatrix(WrappedId, value);
        }

        public bool useJitteredProjectionMatrixForTransparentRendering 
        {
            get => internal_UnityEngineCamera__get__useJitteredProjectionMatrixForTransparentRendering(WrappedId);
            set => internal_UnityEngineCamera__set__useJitteredProjectionMatrixForTransparentRendering(WrappedId, value);
        }

        public global::UnityEngine.Matrix4x4 previousViewProjectionMatrix 
        {
            get => internal_UnityEngineCamera__get__previousViewProjectionMatrix(WrappedId);
        }

        public static global::UnityEngine.Camera main 
        {
            get => internal_UnityEngineCamera__get__main();
        }

        public static global::UnityEngine.Camera current 
        {
            get => internal_UnityEngineCamera__get__current();
        }

        public global::UnityEngine.SceneManagement.Scene scene 
        {
            get => internal_UnityEngineCamera__get__scene(WrappedId);
            set => internal_UnityEngineCamera__set__scene(WrappedId, value);
        }

        public bool stereoEnabled 
        {
            get => internal_UnityEngineCamera__get__stereoEnabled(WrappedId);
        }

        public float stereoSeparation 
        {
            get => internal_UnityEngineCamera__get__stereoSeparation(WrappedId);
            set => internal_UnityEngineCamera__set__stereoSeparation(WrappedId, value);
        }

        public float stereoConvergence 
        {
            get => internal_UnityEngineCamera__get__stereoConvergence(WrappedId);
            set => internal_UnityEngineCamera__set__stereoConvergence(WrappedId, value);
        }

        public bool areVRStereoViewMatricesWithinSingleCullTolerance 
        {
            get => internal_UnityEngineCamera__get__areVRStereoViewMatricesWithinSingleCullTolerance(WrappedId);
        }

        public global::UnityEngine.StereoTargetEyeMask stereoTargetEye 
        {
            get => internal_UnityEngineCamera__get__stereoTargetEye(WrappedId);
            set => internal_UnityEngineCamera__set__stereoTargetEye(WrappedId, value);
        }

        public global::UnityEngine.Camera.MonoOrStereoscopicEye stereoActiveEye 
        {
            get => internal_UnityEngineCamera__get__stereoActiveEye(WrappedId);
        }

        public static int allCamerasCount 
        {
            get => internal_UnityEngineCamera__get__allCamerasCount();
        }

        public static global::UnityEngine.Camera[] allCameras 
        {
            get => internal_UnityEngineCamera__get__allCameras();
        }

        public global::UnityEngine.Camera.SceneViewFilterMode sceneViewFilterMode 
        {
            get => internal_UnityEngineCamera__get__sceneViewFilterMode(WrappedId);
        }

        public int commandBufferCount 
        {
            get => internal_UnityEngineCamera__get__commandBufferCount(WrappedId);
        }

        public void Reset()
        {
            internal_UnityEngineCamera__func__Reset__SystemVoid(WrappedId);
        }

        public void ResetTransparencySortSettings()
        {
            internal_UnityEngineCamera__func__ResetTransparencySortSettings__SystemVoid(WrappedId);
        }

        public void ResetAspect()
        {
            internal_UnityEngineCamera__func__ResetAspect__SystemVoid(WrappedId);
        }

        public void ResetCullingMatrix()
        {
            internal_UnityEngineCamera__func__ResetCullingMatrix__SystemVoid(WrappedId);
        }

        public void SetReplacementShader(global::UnityEngine.Shader shader, string replacementTag)
        {
            internal_UnityEngineCamera__func__SetReplacementShader__UnityEngineShader__SystemString__SystemVoid(WrappedId, shader, replacementTag);
        }

        public void ResetReplacementShader()
        {
            internal_UnityEngineCamera__func__ResetReplacementShader__SystemVoid(WrappedId);
        }

        public float GetGateFittedFieldOfView()
        {
            return internal_UnityEngineCamera__func__GetGateFittedFieldOfView__SystemSingle(WrappedId);
        }

        public global::UnityEngine.Vector2 GetGateFittedLensShift()
        {
            return internal_UnityEngineCamera__func__GetGateFittedLensShift__UnityEngineVector2(WrappedId);
        }

        public void SetTargetBuffers(global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            internal_UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(WrappedId, colorBuffer, depthBuffer);
        }

        public void SetTargetBuffers(global::UnityEngine.RenderBuffer[] colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            internal_UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(WrappedId, colorBuffer, depthBuffer);
        }

        public void ResetWorldToCameraMatrix()
        {
            internal_UnityEngineCamera__func__ResetWorldToCameraMatrix__SystemVoid(WrappedId);
        }

        public void ResetProjectionMatrix()
        {
            internal_UnityEngineCamera__func__ResetProjectionMatrix__SystemVoid(WrappedId);
        }

        public global::UnityEngine.Matrix4x4 CalculateObliqueMatrix(global::UnityEngine.Vector4 clipPlane)
        {
            return internal_UnityEngineCamera__func__CalculateObliqueMatrix__UnityEngineVector4__UnityEngineMatrix4x4(WrappedId, clipPlane);
        }

        public global::UnityEngine.Vector3 WorldToScreenPoint(global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(WrappedId, position, eye);
        }

        public global::UnityEngine.Vector3 WorldToViewportPoint(global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(WrappedId, position, eye);
        }

        public global::UnityEngine.Vector3 ViewportToWorldPoint(global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(WrappedId, position, eye);
        }

        public global::UnityEngine.Vector3 ScreenToWorldPoint(global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(WrappedId, position, eye);
        }

        public global::UnityEngine.Vector3 WorldToScreenPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 WorldToViewportPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 ViewportToWorldPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 ScreenToWorldPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 ScreenToViewportPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__ScreenToViewportPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Vector3 ViewportToScreenPoint(global::UnityEngine.Vector3 position)
        {
            return internal_UnityEngineCamera__func__ViewportToScreenPoint__UnityEngineVector3__UnityEngineVector3(WrappedId, position);
        }

        public global::UnityEngine.Ray ViewportPointToRay(global::UnityEngine.Vector3 pos, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(WrappedId, pos, eye);
        }

        public global::UnityEngine.Ray ViewportPointToRay(global::UnityEngine.Vector3 pos)
        {
            return internal_UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineRay(WrappedId, pos);
        }

        public global::UnityEngine.Ray ScreenPointToRay(global::UnityEngine.Vector3 pos, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(WrappedId, pos, eye);
        }

        public global::UnityEngine.Ray ScreenPointToRay(global::UnityEngine.Vector3 pos)
        {
            return internal_UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineRay(WrappedId, pos);
        }

        public void CalculateFrustumCorners(global::UnityEngine.Rect viewport, float z, global::UnityEngine.Camera.MonoOrStereoscopicEye eye, global::UnityEngine.Vector3[] outCorners)
        {
            internal_UnityEngineCamera__func__CalculateFrustumCorners__UnityEngineRect__SystemSingle__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3Array__SystemVoid(WrappedId, viewport, z, eye, outCorners);
        }

        public static void CalculateProjectionMatrixFromPhysicalProperties(out global::UnityEngine.Matrix4x4 output, float focalLength, global::UnityEngine.Vector2 sensorSize, global::UnityEngine.Vector2 lensShift, float nearClip, float farClip, global::UnityEngine.Camera.GateFitParameters gateFitParameters)
        {
            internal_UnityEngineCamera__func__CalculateProjectionMatrixFromPhysicalProperties__UnityEngineMatrix4x4Ref__SystemSingle__UnityEngineVector2__UnityEngineVector2__SystemSingle__SystemSingle__UnityEngineCamera_GateFitParameters__SystemVoid(out output, focalLength, sensorSize, lensShift, nearClip, farClip, gateFitParameters);
        }

        public static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
        {
            return internal_UnityEngineCamera__func__FocalLengthToFieldOfView__SystemSingle__SystemSingle__SystemSingle(focalLength, sensorSize);
        }

        public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
        {
            return internal_UnityEngineCamera__func__FieldOfViewToFocalLength__SystemSingle__SystemSingle__SystemSingle(fieldOfView, sensorSize);
        }

        public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
        {
            return internal_UnityEngineCamera__func__HorizontalToVerticalFieldOfView__SystemSingle__SystemSingle__SystemSingle(horizontalFieldOfView, aspectRatio);
        }

        public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
        {
            return internal_UnityEngineCamera__func__VerticalToHorizontalFieldOfView__SystemSingle__SystemSingle__SystemSingle(verticalFieldOfView, aspectRatio);
        }

        public global::UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(global::UnityEngine.Camera.StereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__GetStereoNonJitteredProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(WrappedId, eye);
        }

        public global::UnityEngine.Matrix4x4 GetStereoViewMatrix(global::UnityEngine.Camera.StereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__GetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(WrappedId, eye);
        }

        public void CopyStereoDeviceProjectionMatrixToNonJittered(global::UnityEngine.Camera.StereoscopicEye eye)
        {
            internal_UnityEngineCamera__func__CopyStereoDeviceProjectionMatrixToNonJittered__UnityEngineStereoscopicEyeEnum__SystemVoid(WrappedId, eye);
        }

        public global::UnityEngine.Matrix4x4 GetStereoProjectionMatrix(global::UnityEngine.Camera.StereoscopicEye eye)
        {
            return internal_UnityEngineCamera__func__GetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(WrappedId, eye);
        }

        public void SetStereoProjectionMatrix(global::UnityEngine.Camera.StereoscopicEye eye, global::UnityEngine.Matrix4x4 matrix)
        {
            internal_UnityEngineCamera__func__SetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(WrappedId, eye, matrix);
        }

        public void ResetStereoProjectionMatrices()
        {
            internal_UnityEngineCamera__func__ResetStereoProjectionMatrices__SystemVoid(WrappedId);
        }

        public void SetStereoViewMatrix(global::UnityEngine.Camera.StereoscopicEye eye, global::UnityEngine.Matrix4x4 matrix)
        {
            internal_UnityEngineCamera__func__SetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(WrappedId, eye, matrix);
        }

        public void ResetStereoViewMatrices()
        {
            internal_UnityEngineCamera__func__ResetStereoViewMatrices__SystemVoid(WrappedId);
        }

        public static int GetAllCameras(global::UnityEngine.Camera[] cameras)
        {
            return internal_UnityEngineCamera__func__GetAllCameras__UnityEngineCameraArray__SystemInt32(cameras);
        }

        public bool RenderToCubemap(global::UnityEngine.Cubemap cubemap, int faceMask)
        {
            return internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemInt32__SystemBoolean(WrappedId, cubemap, faceMask);
        }

        public bool RenderToCubemap(global::UnityEngine.Cubemap cubemap)
        {
            return internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemBoolean(WrappedId, cubemap);
        }

        public bool RenderToCubemap(global::UnityEngine.RenderTexture cubemap, int faceMask)
        {
            return internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__SystemBoolean(WrappedId, cubemap, faceMask);
        }

        public bool RenderToCubemap(global::UnityEngine.RenderTexture cubemap)
        {
            return internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemBoolean(WrappedId, cubemap);
        }

        public bool RenderToCubemap(global::UnityEngine.RenderTexture cubemap, int faceMask, global::UnityEngine.Camera.MonoOrStereoscopicEye stereoEye)
        {
            return internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__UnityEngineMonoOrStereoscopicEyeEnum__SystemBoolean(WrappedId, cubemap, faceMask, stereoEye);
        }

        public void Render()
        {
            internal_UnityEngineCamera__func__Render__SystemVoid(WrappedId);
        }

        public void RenderWithShader(global::UnityEngine.Shader shader, string replacementTag)
        {
            internal_UnityEngineCamera__func__RenderWithShader__UnityEngineShader__SystemString__SystemVoid(WrappedId, shader, replacementTag);
        }

        public void RenderDontRestore()
        {
            internal_UnityEngineCamera__func__RenderDontRestore__SystemVoid(WrappedId);
        }

        public static void SetupCurrent(global::UnityEngine.Camera cur)
        {
            internal_UnityEngineCamera__func__SetupCurrent__UnityEngineCamera__SystemVoid(cur);
        }

        public void CopyFrom(global::UnityEngine.Camera other)
        {
            internal_UnityEngineCamera__func__CopyFrom__UnityEngineCamera__SystemVoid(WrappedId, other);
        }

        public void RemoveCommandBuffers(global::UnityEngine.Rendering.CameraEvent evt)
        {
            internal_UnityEngineCamera__func__RemoveCommandBuffers__UnityEngineRenderingCameraEventEnum__SystemVoid(WrappedId, evt);
        }

        public void RemoveAllCommandBuffers()
        {
            internal_UnityEngineCamera__func__RemoveAllCommandBuffers__SystemVoid(WrappedId);
        }

        public void AddCommandBuffer(global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            internal_UnityEngineCamera__func__AddCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(WrappedId, evt, buffer);
        }

        public void AddCommandBufferAsync(global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer, global::UnityEngine.Rendering.ComputeQueueType queueType)
        {
            internal_UnityEngineCamera__func__AddCommandBufferAsync__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(WrappedId, evt, buffer, queueType);
        }

        public void RemoveCommandBuffer(global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            internal_UnityEngineCamera__func__RemoveCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(WrappedId, evt, buffer);
        }

        public global::UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(global::UnityEngine.Rendering.CameraEvent evt)
        {
            return internal_UnityEngineCamera__func__GetCommandBuffers__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBufferArray(WrappedId, evt);
        }

        public bool TryGetCullingParameters(out global::UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
        {
            return internal_UnityEngineCamera__func__TryGetCullingParameters__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(WrappedId, out cullingParameters);
        }

        public bool TryGetCullingParameters(bool stereoAware, out global::UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
        {
            return internal_UnityEngineCamera__func__TryGetCullingParameters__SystemBoolean__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(WrappedId, stereoAware, out cullingParameters);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__nearClipPlane(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__nearClipPlane(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__nearClipPlane(long selfObjectId, float nearClipPlane)
        {
            UnityEngineCamera__set__nearClipPlane(selfObjectId, nearClipPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__farClipPlane(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__farClipPlane(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__farClipPlane(long selfObjectId, float farClipPlane)
        {
            UnityEngineCamera__set__farClipPlane(selfObjectId, farClipPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__fieldOfView(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__fieldOfView(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__fieldOfView(long selfObjectId, float fieldOfView)
        {
            UnityEngineCamera__set__fieldOfView(selfObjectId, fieldOfView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderingPath internal_UnityEngineCamera__get__renderingPath(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__renderingPath(selfObjectId);
            var returnResult = (global::UnityEngine.RenderingPath)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__renderingPath(long selfObjectId, global::UnityEngine.RenderingPath renderingPath)
        {
            UnityEngineCamera__set__renderingPath(selfObjectId, (int) renderingPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderingPath internal_UnityEngineCamera__get__actualRenderingPath(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__actualRenderingPath(selfObjectId);
            var returnResult = (global::UnityEngine.RenderingPath)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__allowHDR(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__allowHDR(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__allowHDR(long selfObjectId, bool allowHDR)
        {
            var allowHDRConverted = Unsafe.As<bool, int>(ref allowHDR);
            UnityEngineCamera__set__allowHDR(selfObjectId, allowHDRConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__allowMSAA(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__allowMSAA(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__allowMSAA(long selfObjectId, bool allowMSAA)
        {
            var allowMSAAConverted = Unsafe.As<bool, int>(ref allowMSAA);
            UnityEngineCamera__set__allowMSAA(selfObjectId, allowMSAAConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__allowDynamicResolution(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__allowDynamicResolution(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__allowDynamicResolution(long selfObjectId, bool allowDynamicResolution)
        {
            var allowDynamicResolutionConverted = Unsafe.As<bool, int>(ref allowDynamicResolution);
            UnityEngineCamera__set__allowDynamicResolution(selfObjectId, allowDynamicResolutionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__forceIntoRenderTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__forceIntoRenderTexture(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__forceIntoRenderTexture(long selfObjectId, bool forceIntoRenderTexture)
        {
            var forceIntoRenderTextureConverted = Unsafe.As<bool, int>(ref forceIntoRenderTexture);
            UnityEngineCamera__set__forceIntoRenderTexture(selfObjectId, forceIntoRenderTextureConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__orthographicSize(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__orthographicSize(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__orthographicSize(long selfObjectId, float orthographicSize)
        {
            UnityEngineCamera__set__orthographicSize(selfObjectId, orthographicSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__orthographic(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__orthographic(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__orthographic(long selfObjectId, bool orthographic)
        {
            var orthographicConverted = Unsafe.As<bool, int>(ref orthographic);
            UnityEngineCamera__set__orthographic(selfObjectId, orthographicConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.OpaqueSortMode internal_UnityEngineCamera__get__opaqueSortMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__opaqueSortMode(selfObjectId);
            var returnResult = (global::UnityEngine.Rendering.OpaqueSortMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__opaqueSortMode(long selfObjectId, global::UnityEngine.Rendering.OpaqueSortMode opaqueSortMode)
        {
            UnityEngineCamera__set__opaqueSortMode(selfObjectId, (int) opaqueSortMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.TransparencySortMode internal_UnityEngineCamera__get__transparencySortMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__transparencySortMode(selfObjectId);
            var returnResult = (global::UnityEngine.TransparencySortMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__transparencySortMode(long selfObjectId, global::UnityEngine.TransparencySortMode transparencySortMode)
        {
            UnityEngineCamera__set__transparencySortMode(selfObjectId, (int) transparencySortMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__get__transparencySortAxis(long selfObjectId)
        {
            global::UnityEngine.Vector3 transparencySortAxisValue = default;
            UnityEngineCamera__get__transparencySortAxis(selfObjectId, Unsafe.AsPointer(ref transparencySortAxisValue));
            global::UnityEngine.Vector3 returnResult = transparencySortAxisValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__transparencySortAxis(long selfObjectId, global::UnityEngine.Vector3 transparencySortAxis)
        {
            UnityEngineCamera__set__transparencySortAxis(selfObjectId, Unsafe.AsPointer(ref transparencySortAxis));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__depth(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__depth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__depth(long selfObjectId, float depth)
        {
            UnityEngineCamera__set__depth(selfObjectId, depth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__aspect(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__aspect(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__aspect(long selfObjectId, float aspect)
        {
            UnityEngineCamera__set__aspect(selfObjectId, aspect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__get__velocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 velocityValue = default;
            UnityEngineCamera__get__velocity(selfObjectId, Unsafe.AsPointer(ref velocityValue));
            global::UnityEngine.Vector3 returnResult = velocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__cullingMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__cullingMask(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__cullingMask(long selfObjectId, int cullingMask)
        {
            UnityEngineCamera__set__cullingMask(selfObjectId, cullingMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__eventMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__eventMask(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__eventMask(long selfObjectId, int eventMask)
        {
            UnityEngineCamera__set__eventMask(selfObjectId, eventMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__layerCullSpherical(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__layerCullSpherical(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__layerCullSpherical(long selfObjectId, bool layerCullSpherical)
        {
            var layerCullSphericalConverted = Unsafe.As<bool, int>(ref layerCullSpherical);
            UnityEngineCamera__set__layerCullSpherical(selfObjectId, layerCullSphericalConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.CameraType internal_UnityEngineCamera__get__cameraType(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__cameraType(selfObjectId);
            var returnResult = (global::UnityEngine.CameraType)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__cameraType(long selfObjectId, global::UnityEngine.CameraType cameraType)
        {
            UnityEngineCamera__set__cameraType(selfObjectId, (int) cameraType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe ulong internal_UnityEngineCamera__get__overrideSceneCullingMask(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__overrideSceneCullingMask(selfObjectId);
            var returnResult = Unsafe.As<long, ulong>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__overrideSceneCullingMask(long selfObjectId, ulong overrideSceneCullingMask)
        {
            var overrideSceneCullingMaskConverted = Unsafe.As<ulong, long>(ref overrideSceneCullingMask);
            UnityEngineCamera__set__overrideSceneCullingMask(selfObjectId, overrideSceneCullingMaskConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::System.Single[] internal_UnityEngineCamera__get__layerCullDistances(long selfObjectId)
        {
            float* layerCullDistancesIdsPointer = default;
            int layerCullDistancesWasmLength = default;
            UnityEngineCamera__get__layerCullDistances(selfObjectId, &layerCullDistancesIdsPointer, &layerCullDistancesWasmLength);
            float[] returnResult = new float[layerCullDistancesWasmLength];
            for (int i = 0; i < layerCullDistancesWasmLength; i++)
            {
                returnResult[i] = layerCullDistancesIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)layerCullDistancesIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__layerCullDistances(long selfObjectId, global::System.Single[] layerCullDistances)
        {
            fixed (float* layerCullDistancesPointer = layerCullDistances)
            {
                UnityEngineCamera__set__layerCullDistances(selfObjectId, layerCullDistancesPointer, layerCullDistances.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__useOcclusionCulling(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__useOcclusionCulling(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__useOcclusionCulling(long selfObjectId, bool useOcclusionCulling)
        {
            var useOcclusionCullingConverted = Unsafe.As<bool, int>(ref useOcclusionCulling);
            UnityEngineCamera__set__useOcclusionCulling(selfObjectId, useOcclusionCullingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__cullingMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 cullingMatrixValue = default;
            UnityEngineCamera__get__cullingMatrix(selfObjectId, Unsafe.AsPointer(ref cullingMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = cullingMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__cullingMatrix(long selfObjectId, global::UnityEngine.Matrix4x4 cullingMatrix)
        {
            UnityEngineCamera__set__cullingMatrix(selfObjectId, Unsafe.AsPointer(ref cullingMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Color internal_UnityEngineCamera__get__backgroundColor(long selfObjectId)
        {
            global::UnityEngine.Color backgroundColorValue = default;
            UnityEngineCamera__get__backgroundColor(selfObjectId, Unsafe.AsPointer(ref backgroundColorValue));
            global::UnityEngine.Color returnResult = backgroundColorValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__backgroundColor(long selfObjectId, global::UnityEngine.Color backgroundColor)
        {
            UnityEngineCamera__set__backgroundColor(selfObjectId, Unsafe.AsPointer(ref backgroundColor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.CameraClearFlags internal_UnityEngineCamera__get__clearFlags(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__clearFlags(selfObjectId);
            var returnResult = (global::UnityEngine.CameraClearFlags)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__clearFlags(long selfObjectId, global::UnityEngine.CameraClearFlags clearFlags)
        {
            UnityEngineCamera__set__clearFlags(selfObjectId, (int) clearFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.DepthTextureMode internal_UnityEngineCamera__get__depthTextureMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__depthTextureMode(selfObjectId);
            var returnResult = (global::UnityEngine.DepthTextureMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__depthTextureMode(long selfObjectId, global::UnityEngine.DepthTextureMode depthTextureMode)
        {
            UnityEngineCamera__set__depthTextureMode(selfObjectId, (int) depthTextureMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__clearStencilAfterLightingPass(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__clearStencilAfterLightingPass(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__clearStencilAfterLightingPass(long selfObjectId, bool clearStencilAfterLightingPass)
        {
            var clearStencilAfterLightingPassConverted = Unsafe.As<bool, int>(ref clearStencilAfterLightingPass);
            UnityEngineCamera__set__clearStencilAfterLightingPass(selfObjectId, clearStencilAfterLightingPassConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__usePhysicalProperties(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__usePhysicalProperties(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__usePhysicalProperties(long selfObjectId, bool usePhysicalProperties)
        {
            var usePhysicalPropertiesConverted = Unsafe.As<bool, int>(ref usePhysicalProperties);
            UnityEngineCamera__set__usePhysicalProperties(selfObjectId, usePhysicalPropertiesConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineCamera__get__sensorSize(long selfObjectId)
        {
            global::UnityEngine.Vector2 sensorSizeValue = default;
            UnityEngineCamera__get__sensorSize(selfObjectId, Unsafe.AsPointer(ref sensorSizeValue));
            global::UnityEngine.Vector2 returnResult = sensorSizeValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__sensorSize(long selfObjectId, global::UnityEngine.Vector2 sensorSize)
        {
            UnityEngineCamera__set__sensorSize(selfObjectId, Unsafe.AsPointer(ref sensorSize));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineCamera__get__lensShift(long selfObjectId)
        {
            global::UnityEngine.Vector2 lensShiftValue = default;
            UnityEngineCamera__get__lensShift(selfObjectId, Unsafe.AsPointer(ref lensShiftValue));
            global::UnityEngine.Vector2 returnResult = lensShiftValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__lensShift(long selfObjectId, global::UnityEngine.Vector2 lensShift)
        {
            UnityEngineCamera__set__lensShift(selfObjectId, Unsafe.AsPointer(ref lensShift));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__focalLength(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__focalLength(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__focalLength(long selfObjectId, float focalLength)
        {
            UnityEngineCamera__set__focalLength(selfObjectId, focalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera.GateFitMode internal_UnityEngineCamera__get__gateFit(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__gateFit(selfObjectId);
            var returnResult = (global::UnityEngine.Camera.GateFitMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__gateFit(long selfObjectId, global::UnityEngine.Camera.GateFitMode gateFit)
        {
            UnityEngineCamera__set__gateFit(selfObjectId, (int) gateFit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineCamera__get__rect(long selfObjectId)
        {
            global::UnityEngine.Rect rectValue = default;
            UnityEngineCamera__get__rect(selfObjectId, Unsafe.AsPointer(ref rectValue));
            global::UnityEngine.Rect returnResult = rectValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__rect(long selfObjectId, global::UnityEngine.Rect rect)
        {
            UnityEngineCamera__set__rect(selfObjectId, Unsafe.AsPointer(ref rect));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rect internal_UnityEngineCamera__get__pixelRect(long selfObjectId)
        {
            global::UnityEngine.Rect pixelRectValue = default;
            UnityEngineCamera__get__pixelRect(selfObjectId, Unsafe.AsPointer(ref pixelRectValue));
            global::UnityEngine.Rect returnResult = pixelRectValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__pixelRect(long selfObjectId, global::UnityEngine.Rect pixelRect)
        {
            UnityEngineCamera__set__pixelRect(selfObjectId, Unsafe.AsPointer(ref pixelRect));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__pixelWidth(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__pixelWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__pixelHeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__pixelHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__scaledPixelWidth(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__scaledPixelWidth(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__scaledPixelHeight(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__scaledPixelHeight(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineCamera__get__targetTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__targetTexture(selfObjectId);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__targetTexture(long selfObjectId, global::UnityEngine.RenderTexture targetTexture)
        {
            UnityEngineCamera__set__targetTexture(selfObjectId, targetTexture.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.RenderTexture internal_UnityEngineCamera__get__activeTexture(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__activeTexture(selfObjectId);
            var returnResult = new global::UnityEngine.RenderTexture(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__targetDisplay(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__targetDisplay(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__targetDisplay(long selfObjectId, int targetDisplay)
        {
            UnityEngineCamera__set__targetDisplay(selfObjectId, targetDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__cameraToWorldMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 cameraToWorldMatrixValue = default;
            UnityEngineCamera__get__cameraToWorldMatrix(selfObjectId, Unsafe.AsPointer(ref cameraToWorldMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = cameraToWorldMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__worldToCameraMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 worldToCameraMatrixValue = default;
            UnityEngineCamera__get__worldToCameraMatrix(selfObjectId, Unsafe.AsPointer(ref worldToCameraMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = worldToCameraMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__worldToCameraMatrix(long selfObjectId, global::UnityEngine.Matrix4x4 worldToCameraMatrix)
        {
            UnityEngineCamera__set__worldToCameraMatrix(selfObjectId, Unsafe.AsPointer(ref worldToCameraMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__projectionMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 projectionMatrixValue = default;
            UnityEngineCamera__get__projectionMatrix(selfObjectId, Unsafe.AsPointer(ref projectionMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = projectionMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__projectionMatrix(long selfObjectId, global::UnityEngine.Matrix4x4 projectionMatrix)
        {
            UnityEngineCamera__set__projectionMatrix(selfObjectId, Unsafe.AsPointer(ref projectionMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__nonJitteredProjectionMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 nonJitteredProjectionMatrixValue = default;
            UnityEngineCamera__get__nonJitteredProjectionMatrix(selfObjectId, Unsafe.AsPointer(ref nonJitteredProjectionMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = nonJitteredProjectionMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__nonJitteredProjectionMatrix(long selfObjectId, global::UnityEngine.Matrix4x4 nonJitteredProjectionMatrix)
        {
            UnityEngineCamera__set__nonJitteredProjectionMatrix(selfObjectId, Unsafe.AsPointer(ref nonJitteredProjectionMatrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__useJitteredProjectionMatrixForTransparentRendering(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__useJitteredProjectionMatrixForTransparentRendering(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__useJitteredProjectionMatrixForTransparentRendering(long selfObjectId, bool useJitteredProjectionMatrixForTransparentRendering)
        {
            var useJitteredProjectionMatrixForTransparentRenderingConverted = Unsafe.As<bool, int>(ref useJitteredProjectionMatrixForTransparentRendering);
            UnityEngineCamera__set__useJitteredProjectionMatrixForTransparentRendering(selfObjectId, useJitteredProjectionMatrixForTransparentRenderingConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__get__previousViewProjectionMatrix(long selfObjectId)
        {
            global::UnityEngine.Matrix4x4 previousViewProjectionMatrixValue = default;
            UnityEngineCamera__get__previousViewProjectionMatrix(selfObjectId, Unsafe.AsPointer(ref previousViewProjectionMatrixValue));
            global::UnityEngine.Matrix4x4 returnResult = previousViewProjectionMatrixValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera internal_UnityEngineCamera__get__main()
        {
            var methodCallResult = UnityEngineCamera__get__main();
            var returnResult = new global::UnityEngine.Camera(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera internal_UnityEngineCamera__get__current()
        {
            var methodCallResult = UnityEngineCamera__get__current();
            var returnResult = new global::UnityEngine.Camera(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.SceneManagement.Scene internal_UnityEngineCamera__get__scene(long selfObjectId)
        {
            global::UnityEngine.SceneManagement.Scene sceneValue = default;
            UnityEngineCamera__get__scene(selfObjectId, Unsafe.AsPointer(ref sceneValue));
            global::UnityEngine.SceneManagement.Scene returnResult = sceneValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__scene(long selfObjectId, global::UnityEngine.SceneManagement.Scene scene)
        {
            UnityEngineCamera__set__scene(selfObjectId, Unsafe.AsPointer(ref scene));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__stereoEnabled(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__stereoEnabled(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__stereoSeparation(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__stereoSeparation(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__stereoSeparation(long selfObjectId, float stereoSeparation)
        {
            UnityEngineCamera__set__stereoSeparation(selfObjectId, stereoSeparation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__get__stereoConvergence(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__stereoConvergence(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__stereoConvergence(long selfObjectId, float stereoConvergence)
        {
            UnityEngineCamera__set__stereoConvergence(selfObjectId, stereoConvergence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__get__areVRStereoViewMatricesWithinSingleCullTolerance(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__areVRStereoViewMatricesWithinSingleCullTolerance(selfObjectId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.StereoTargetEyeMask internal_UnityEngineCamera__get__stereoTargetEye(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__stereoTargetEye(selfObjectId);
            var returnResult = (global::UnityEngine.StereoTargetEyeMask)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__set__stereoTargetEye(long selfObjectId, global::UnityEngine.StereoTargetEyeMask stereoTargetEye)
        {
            UnityEngineCamera__set__stereoTargetEye(selfObjectId, (int) stereoTargetEye);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera.MonoOrStereoscopicEye internal_UnityEngineCamera__get__stereoActiveEye(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__stereoActiveEye(selfObjectId);
            var returnResult = (global::UnityEngine.Camera.MonoOrStereoscopicEye)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__allCamerasCount()
        {
            var methodCallResult = UnityEngineCamera__get__allCamerasCount();
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera[] internal_UnityEngineCamera__get__allCameras()
        {
            long* allCamerasIdsPointer = default;
            int allCamerasWasmLength = default;
            UnityEngineCamera__get__allCameras(&allCamerasIdsPointer, &allCamerasWasmLength);
            global::UnityEngine.Camera[] returnResult = new global::UnityEngine.Camera[allCamerasWasmLength];
            for (int i = 0; i < allCamerasWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Camera(allCamerasIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)allCamerasIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Camera.SceneViewFilterMode internal_UnityEngineCamera__get__sceneViewFilterMode(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__sceneViewFilterMode(selfObjectId);
            var returnResult = (global::UnityEngine.Camera.SceneViewFilterMode)methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__get__commandBufferCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__get__commandBufferCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__Reset__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__Reset__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetTransparencySortSettings__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetTransparencySortSettings__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetAspect__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetAspect__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetCullingMatrix__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetCullingMatrix__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetReplacementShader__UnityEngineShader__SystemString__SystemVoid(long selfObjectId, global::UnityEngine.Shader shader, string replacementTag)
        {
            fixed (char* replacementTagPointer = replacementTag)
            {
                UnityEngineCamera__func__SetReplacementShader__UnityEngineShader__SystemString__SystemVoid(selfObjectId, shader.WrappedId, replacementTagPointer, replacementTag.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetReplacementShader__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetReplacementShader__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__func__GetGateFittedFieldOfView__SystemSingle(long selfObjectId)
        {
            var methodCallResult = UnityEngineCamera__func__GetGateFittedFieldOfView__SystemSingle(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector2 internal_UnityEngineCamera__func__GetGateFittedLensShift__UnityEngineVector2(long selfObjectId)
        {
            global::UnityEngine.Vector2 returnResultValue = default;
            UnityEngineCamera__func__GetGateFittedLensShift__UnityEngineVector2(selfObjectId, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector2 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(long selfObjectId, global::UnityEngine.RenderBuffer colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(selfObjectId, Unsafe.AsPointer(ref colorBuffer), Unsafe.AsPointer(ref depthBuffer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(long selfObjectId, global::UnityEngine.RenderBuffer[] colorBuffer, global::UnityEngine.RenderBuffer depthBuffer)
        {
            fixed (global::UnityEngine.RenderBuffer* colorBufferPointer = colorBuffer)
            {
                UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(selfObjectId, colorBufferPointer, colorBuffer.Length, Unsafe.AsPointer(ref depthBuffer));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetWorldToCameraMatrix__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetWorldToCameraMatrix__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetProjectionMatrix__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetProjectionMatrix__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__func__CalculateObliqueMatrix__UnityEngineVector4__UnityEngineMatrix4x4(long selfObjectId, global::UnityEngine.Vector4 clipPlane)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineCamera__func__CalculateObliqueMatrix__UnityEngineVector4__UnityEngineMatrix4x4(selfObjectId, Unsafe.AsPointer(ref clipPlane), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ScreenToViewportPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ScreenToViewportPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCamera__func__ViewportToScreenPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, global::UnityEngine.Vector3 position)
        {
            global::UnityEngine.Vector3 returnResultValue = default;
            UnityEngineCamera__func__ViewportToScreenPoint__UnityEngineVector3__UnityEngineVector3(selfObjectId, Unsafe.AsPointer(ref position), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Vector3 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Ray internal_UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(long selfObjectId, global::UnityEngine.Vector3 pos, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Ray returnResultValue = default;
            UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(selfObjectId, Unsafe.AsPointer(ref pos), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Ray returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Ray internal_UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineRay(long selfObjectId, global::UnityEngine.Vector3 pos)
        {
            global::UnityEngine.Ray returnResultValue = default;
            UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineRay(selfObjectId, Unsafe.AsPointer(ref pos), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Ray returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Ray internal_UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(long selfObjectId, global::UnityEngine.Vector3 pos, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
            global::UnityEngine.Ray returnResultValue = default;
            UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(selfObjectId, Unsafe.AsPointer(ref pos), (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Ray returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Ray internal_UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineRay(long selfObjectId, global::UnityEngine.Vector3 pos)
        {
            global::UnityEngine.Ray returnResultValue = default;
            UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineRay(selfObjectId, Unsafe.AsPointer(ref pos), Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Ray returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__CalculateFrustumCorners__UnityEngineRect__SystemSingle__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3Array__SystemVoid(long selfObjectId, global::UnityEngine.Rect viewport, float z, global::UnityEngine.Camera.MonoOrStereoscopicEye eye, global::UnityEngine.Vector3[] outCorners)
        {
            fixed (global::UnityEngine.Vector3* outCornersPointer = outCorners)
            {
                UnityEngineCamera__func__CalculateFrustumCorners__UnityEngineRect__SystemSingle__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3Array__SystemVoid(selfObjectId, Unsafe.AsPointer(ref viewport), z, (int) eye, outCornersPointer, outCorners.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__CalculateProjectionMatrixFromPhysicalProperties__UnityEngineMatrix4x4Ref__SystemSingle__UnityEngineVector2__UnityEngineVector2__SystemSingle__SystemSingle__UnityEngineCamera_GateFitParameters__SystemVoid(out global::UnityEngine.Matrix4x4 output, float focalLength, global::UnityEngine.Vector2 sensorSize, global::UnityEngine.Vector2 lensShift, float nearClip, float farClip, global::UnityEngine.Camera.GateFitParameters gateFitParameters)
        {
            output = default;
            UnityEngineCamera__func__CalculateProjectionMatrixFromPhysicalProperties__UnityEngineMatrix4x4Ref__SystemSingle__UnityEngineVector2__UnityEngineVector2__SystemSingle__SystemSingle__UnityEngineCamera_GateFitParameters__SystemVoid(Unsafe.AsPointer(ref output), focalLength, Unsafe.AsPointer(ref sensorSize), Unsafe.AsPointer(ref lensShift), nearClip, farClip, Unsafe.AsPointer(ref gateFitParameters));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__func__FocalLengthToFieldOfView__SystemSingle__SystemSingle__SystemSingle(float focalLength, float sensorSize)
        {
            var methodCallResult = UnityEngineCamera__func__FocalLengthToFieldOfView__SystemSingle__SystemSingle__SystemSingle(focalLength, sensorSize);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__func__FieldOfViewToFocalLength__SystemSingle__SystemSingle__SystemSingle(float fieldOfView, float sensorSize)
        {
            var methodCallResult = UnityEngineCamera__func__FieldOfViewToFocalLength__SystemSingle__SystemSingle__SystemSingle(fieldOfView, sensorSize);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__func__HorizontalToVerticalFieldOfView__SystemSingle__SystemSingle__SystemSingle(float horizontalFieldOfView, float aspectRatio)
        {
            var methodCallResult = UnityEngineCamera__func__HorizontalToVerticalFieldOfView__SystemSingle__SystemSingle__SystemSingle(horizontalFieldOfView, aspectRatio);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float internal_UnityEngineCamera__func__VerticalToHorizontalFieldOfView__SystemSingle__SystemSingle__SystemSingle(float verticalFieldOfView, float aspectRatio)
        {
            var methodCallResult = UnityEngineCamera__func__VerticalToHorizontalFieldOfView__SystemSingle__SystemSingle__SystemSingle(verticalFieldOfView, aspectRatio);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__func__GetStereoNonJitteredProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineCamera__func__GetStereoNonJitteredProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(selfObjectId, (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__func__GetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineCamera__func__GetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(selfObjectId, (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__CopyStereoDeviceProjectionMatrixToNonJittered__UnityEngineStereoscopicEyeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye)
        {
            UnityEngineCamera__func__CopyStereoDeviceProjectionMatrixToNonJittered__UnityEngineStereoscopicEyeEnum__SystemVoid(selfObjectId, (int) eye);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Matrix4x4 internal_UnityEngineCamera__func__GetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye)
        {
            global::UnityEngine.Matrix4x4 returnResultValue = default;
            UnityEngineCamera__func__GetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(selfObjectId, (int) eye, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.Matrix4x4 returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye, global::UnityEngine.Matrix4x4 matrix)
        {
            UnityEngineCamera__func__SetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(selfObjectId, (int) eye, Unsafe.AsPointer(ref matrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetStereoProjectionMatrices__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetStereoProjectionMatrices__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, global::UnityEngine.Camera.StereoscopicEye eye, global::UnityEngine.Matrix4x4 matrix)
        {
            UnityEngineCamera__func__SetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(selfObjectId, (int) eye, Unsafe.AsPointer(ref matrix));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__ResetStereoViewMatrices__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__ResetStereoViewMatrices__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCamera__func__GetAllCameras__UnityEngineCameraArray__SystemInt32(global::UnityEngine.Camera[] cameras)
        {
            int camerasWasmLength = cameras.Length;
            long[] camerasIds = new long[camerasWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < camerasWasmLength; i++) camerasIds[i] = (cameras[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (long* camerasIdsPointer = camerasIds)
            {
                var methodCallResult = UnityEngineCamera__func__GetAllCameras__UnityEngineCameraArray__SystemInt32(camerasIdsPointer, camerasWasmLength);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemInt32__SystemBoolean(long selfObjectId, global::UnityEngine.Cubemap cubemap, int faceMask)
        {
            var methodCallResult = UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemInt32__SystemBoolean(selfObjectId, cubemap.WrappedId, faceMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemBoolean(long selfObjectId, global::UnityEngine.Cubemap cubemap)
        {
            var methodCallResult = UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemBoolean(selfObjectId, cubemap.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__SystemBoolean(long selfObjectId, global::UnityEngine.RenderTexture cubemap, int faceMask)
        {
            var methodCallResult = UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__SystemBoolean(selfObjectId, cubemap.WrappedId, faceMask);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemBoolean(long selfObjectId, global::UnityEngine.RenderTexture cubemap)
        {
            var methodCallResult = UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemBoolean(selfObjectId, cubemap.WrappedId);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__UnityEngineMonoOrStereoscopicEyeEnum__SystemBoolean(long selfObjectId, global::UnityEngine.RenderTexture cubemap, int faceMask, global::UnityEngine.Camera.MonoOrStereoscopicEye stereoEye)
        {
            var methodCallResult = UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__UnityEngineMonoOrStereoscopicEyeEnum__SystemBoolean(selfObjectId, cubemap.WrappedId, faceMask, (int) stereoEye);
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__Render__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__Render__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__RenderWithShader__UnityEngineShader__SystemString__SystemVoid(long selfObjectId, global::UnityEngine.Shader shader, string replacementTag)
        {
            fixed (char* replacementTagPointer = replacementTag)
            {
                UnityEngineCamera__func__RenderWithShader__UnityEngineShader__SystemString__SystemVoid(selfObjectId, shader.WrappedId, replacementTagPointer, replacementTag.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__RenderDontRestore__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__RenderDontRestore__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__SetupCurrent__UnityEngineCamera__SystemVoid(global::UnityEngine.Camera cur)
        {
            UnityEngineCamera__func__SetupCurrent__UnityEngineCamera__SystemVoid(cur.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__CopyFrom__UnityEngineCamera__SystemVoid(long selfObjectId, global::UnityEngine.Camera other)
        {
            UnityEngineCamera__func__CopyFrom__UnityEngineCamera__SystemVoid(selfObjectId, other.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__RemoveCommandBuffers__UnityEngineRenderingCameraEventEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraEvent evt)
        {
            UnityEngineCamera__func__RemoveCommandBuffers__UnityEngineRenderingCameraEventEnum__SystemVoid(selfObjectId, (int) evt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__RemoveAllCommandBuffers__SystemVoid(long selfObjectId)
        {
            UnityEngineCamera__func__RemoveAllCommandBuffers__SystemVoid(selfObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__AddCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            UnityEngineCamera__func__AddCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(selfObjectId, (int) evt, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__AddCommandBufferAsync__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer, global::UnityEngine.Rendering.ComputeQueueType queueType)
        {
            UnityEngineCamera__func__AddCommandBufferAsync__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(selfObjectId, (int) evt, buffer.WrappedId, (int) queueType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineCamera__func__RemoveCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(long selfObjectId, global::UnityEngine.Rendering.CameraEvent evt, global::UnityEngine.Rendering.CommandBuffer buffer)
        {
            UnityEngineCamera__func__RemoveCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(selfObjectId, (int) evt, buffer.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rendering.CommandBuffer[] internal_UnityEngineCamera__func__GetCommandBuffers__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBufferArray(long selfObjectId, global::UnityEngine.Rendering.CameraEvent evt)
        {
            long* returnResultIdsPointer = default;
            int returnResultWasmLength = default;
            UnityEngineCamera__func__GetCommandBuffers__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBufferArray(selfObjectId, (int) evt, &returnResultIdsPointer, &returnResultWasmLength);
            global::UnityEngine.Rendering.CommandBuffer[] returnResult = new global::UnityEngine.Rendering.CommandBuffer[returnResultWasmLength];
            for (int i = 0; i < returnResultWasmLength; i++)
            {
                returnResult[i] = new global::UnityEngine.Rendering.CommandBuffer(returnResultIdsPointer![i]);
            }
            Marshal.FreeHGlobal((IntPtr)returnResultIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__TryGetCullingParameters__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(long selfObjectId, out global::UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
        {
            cullingParameters = default;
            var methodCallResult = UnityEngineCamera__func__TryGetCullingParameters__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(selfObjectId, Unsafe.AsPointer(ref cullingParameters));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineCamera__func__TryGetCullingParameters__SystemBoolean__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(long selfObjectId, bool stereoAware, out global::UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
        {
            var stereoAwareConverted = Unsafe.As<bool, int>(ref stereoAware);
            cullingParameters = default;
            var methodCallResult = UnityEngineCamera__func__TryGetCullingParameters__SystemBoolean__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(selfObjectId, stereoAwareConverted, Unsafe.AsPointer(ref cullingParameters));
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__nearClipPlane(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__nearClipPlane(long selfObjectId, float nearClipPlane);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__farClipPlane(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__farClipPlane(long selfObjectId, float farClipPlane);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__fieldOfView(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__fieldOfView(long selfObjectId, float fieldOfView);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__renderingPath(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__renderingPath(long selfObjectId, int renderingPathUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__actualRenderingPath(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__allowHDR(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__allowHDR(long selfObjectId, int allowHDRConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__allowMSAA(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__allowMSAA(long selfObjectId, int allowMSAAConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__allowDynamicResolution(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__allowDynamicResolution(long selfObjectId, int allowDynamicResolutionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__forceIntoRenderTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__forceIntoRenderTexture(long selfObjectId, int forceIntoRenderTextureConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__orthographicSize(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__orthographicSize(long selfObjectId, float orthographicSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__orthographic(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__orthographic(long selfObjectId, int orthographicConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__opaqueSortMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__opaqueSortMode(long selfObjectId, int opaqueSortModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__transparencySortMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__transparencySortMode(long selfObjectId, int transparencySortModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__transparencySortAxis(long selfObjectId, void* transparencySortAxisPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__transparencySortAxis(long selfObjectId, void* transparencySortAxisPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__depth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__depth(long selfObjectId, float depth);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__aspect(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__aspect(long selfObjectId, float aspect);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__velocity(long selfObjectId, void* velocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__cullingMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__cullingMask(long selfObjectId, int cullingMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__eventMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__eventMask(long selfObjectId, int eventMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__layerCullSpherical(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__layerCullSpherical(long selfObjectId, int layerCullSphericalConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__cameraType(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__cameraType(long selfObjectId, int cameraTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCamera__get__overrideSceneCullingMask(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__overrideSceneCullingMask(long selfObjectId, long overrideSceneCullingMaskConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__layerCullDistances(long selfObjectId, void* layerCullDistancesIdsPointer, void* layerCullDistancesWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__layerCullDistances(long selfObjectId, void* layerCullDistancesPointer, int layerCullDistancesWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__useOcclusionCulling(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__useOcclusionCulling(long selfObjectId, int useOcclusionCullingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__cullingMatrix(long selfObjectId, void* cullingMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__cullingMatrix(long selfObjectId, void* cullingMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__backgroundColor(long selfObjectId, void* backgroundColorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__backgroundColor(long selfObjectId, void* backgroundColorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__clearFlags(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__clearFlags(long selfObjectId, int clearFlagsUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__depthTextureMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__depthTextureMode(long selfObjectId, int depthTextureModeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__clearStencilAfterLightingPass(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__clearStencilAfterLightingPass(long selfObjectId, int clearStencilAfterLightingPassConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__usePhysicalProperties(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__usePhysicalProperties(long selfObjectId, int usePhysicalPropertiesConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__sensorSize(long selfObjectId, void* sensorSizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__sensorSize(long selfObjectId, void* sensorSizePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__lensShift(long selfObjectId, void* lensShiftPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__lensShift(long selfObjectId, void* lensShiftPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__focalLength(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__focalLength(long selfObjectId, float focalLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__gateFit(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__gateFit(long selfObjectId, int gateFitUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__rect(long selfObjectId, void* rectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__rect(long selfObjectId, void* rectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__pixelRect(long selfObjectId, void* pixelRectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__pixelRect(long selfObjectId, void* pixelRectPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__pixelWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__pixelHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__scaledPixelWidth(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__scaledPixelHeight(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCamera__get__targetTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__targetTexture(long selfObjectId, long targetTextureObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCamera__get__activeTexture(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__targetDisplay(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__targetDisplay(long selfObjectId, int targetDisplay);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__cameraToWorldMatrix(long selfObjectId, void* cameraToWorldMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__worldToCameraMatrix(long selfObjectId, void* worldToCameraMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__worldToCameraMatrix(long selfObjectId, void* worldToCameraMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__projectionMatrix(long selfObjectId, void* projectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__projectionMatrix(long selfObjectId, void* projectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__nonJitteredProjectionMatrix(long selfObjectId, void* nonJitteredProjectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__nonJitteredProjectionMatrix(long selfObjectId, void* nonJitteredProjectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__useJitteredProjectionMatrixForTransparentRendering(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__useJitteredProjectionMatrixForTransparentRendering(long selfObjectId, int useJitteredProjectionMatrixForTransparentRenderingConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__previousViewProjectionMatrix(long selfObjectId, void* previousViewProjectionMatrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCamera__get__main();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCamera__get__current();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__scene(long selfObjectId, void* scenePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__set__scene(long selfObjectId, void* scenePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__stereoEnabled(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__stereoSeparation(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__stereoSeparation(long selfObjectId, float stereoSeparation);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__get__stereoConvergence(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__stereoConvergence(long selfObjectId, float stereoConvergence);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__areVRStereoViewMatricesWithinSingleCullTolerance(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__stereoTargetEye(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__set__stereoTargetEye(long selfObjectId, int stereoTargetEyeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__stereoActiveEye(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__allCamerasCount();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__get__allCameras(void* allCamerasIdsPointer, void* allCamerasWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__sceneViewFilterMode(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__get__commandBufferCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__Reset__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetTransparencySortSettings__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetAspect__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetCullingMatrix__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__SetReplacementShader__UnityEngineShader__SystemString__SystemVoid(long selfObjectId, long shaderObjectId, void* replacementTagPointer, int replacementTagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetReplacementShader__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__func__GetGateFittedFieldOfView__SystemSingle(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__GetGateFittedLensShift__UnityEngineVector2(long selfObjectId, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBuffer__UnityEngineRenderBuffer__SystemVoid(long selfObjectId, void* colorBufferPointer, void* depthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__SetTargetBuffers__UnityEngineRenderBufferArray__UnityEngineRenderBuffer__SystemVoid(long selfObjectId, void* colorBufferPointer, int colorBufferWasmLength, void* depthBufferPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetWorldToCameraMatrix__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetProjectionMatrix__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__CalculateObliqueMatrix__UnityEngineVector4__UnityEngineMatrix4x4(long selfObjectId, void* clipPlanePointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, void* positionPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, void* positionPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, void* positionPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3(long selfObjectId, void* positionPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__WorldToScreenPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__WorldToViewportPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ViewportToWorldPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ScreenToWorldPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ScreenToViewportPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ViewportToScreenPoint__UnityEngineVector3__UnityEngineVector3(long selfObjectId, void* positionPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(long selfObjectId, void* posPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ViewportPointToRay__UnityEngineVector3__UnityEngineRay(long selfObjectId, void* posPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineRay(long selfObjectId, void* posPointer, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__ScreenPointToRay__UnityEngineVector3__UnityEngineRay(long selfObjectId, void* posPointer, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__CalculateFrustumCorners__UnityEngineRect__SystemSingle__UnityEngineMonoOrStereoscopicEyeEnum__UnityEngineVector3Array__SystemVoid(long selfObjectId, void* viewportPointer, float z, int eyeUnderlyingValue, void* outCornersPointer, int outCornersWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__CalculateProjectionMatrixFromPhysicalProperties__UnityEngineMatrix4x4Ref__SystemSingle__UnityEngineVector2__UnityEngineVector2__SystemSingle__SystemSingle__UnityEngineCamera_GateFitParameters__SystemVoid(void* outputPointer, float focalLength, void* sensorSizePointer, void* lensShiftPointer, float nearClip, float farClip, void* gateFitParametersPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__func__FocalLengthToFieldOfView__SystemSingle__SystemSingle__SystemSingle(float focalLength, float sensorSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__func__FieldOfViewToFocalLength__SystemSingle__SystemSingle__SystemSingle(float fieldOfView, float sensorSize);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__func__HorizontalToVerticalFieldOfView__SystemSingle__SystemSingle__SystemSingle(float horizontalFieldOfView, float aspectRatio);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern float UnityEngineCamera__func__VerticalToHorizontalFieldOfView__SystemSingle__SystemSingle__SystemSingle(float verticalFieldOfView, float aspectRatio);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__GetStereoNonJitteredProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__GetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__CopyStereoDeviceProjectionMatrixToNonJittered__UnityEngineStereoscopicEyeEnum__SystemVoid(long selfObjectId, int eyeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__GetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4(long selfObjectId, int eyeUnderlyingValue, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__SetStereoProjectionMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int eyeUnderlyingValue, void* matrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetStereoProjectionMatrices__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__SetStereoViewMatrix__UnityEngineStereoscopicEyeEnum__UnityEngineMatrix4x4__SystemVoid(long selfObjectId, int eyeUnderlyingValue, void* matrixPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__ResetStereoViewMatrices__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCamera__func__GetAllCameras__UnityEngineCameraArray__SystemInt32(void* camerasIdsPointer, int camerasWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemInt32__SystemBoolean(long selfObjectId, long cubemapObjectId, int faceMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__func__RenderToCubemap__UnityEngineCubemap__SystemBoolean(long selfObjectId, long cubemapObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__SystemBoolean(long selfObjectId, long cubemapObjectId, int faceMask);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemBoolean(long selfObjectId, long cubemapObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCamera__func__RenderToCubemap__UnityEngineRenderTexture__SystemInt32__UnityEngineMonoOrStereoscopicEyeEnum__SystemBoolean(long selfObjectId, long cubemapObjectId, int faceMask, int stereoEyeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__Render__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__RenderWithShader__UnityEngineShader__SystemString__SystemVoid(long selfObjectId, long shaderObjectId, void* replacementTagPointer, int replacementTagWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__RenderDontRestore__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__SetupCurrent__UnityEngineCamera__SystemVoid(long curObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__CopyFrom__UnityEngineCamera__SystemVoid(long selfObjectId, long otherObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__RemoveCommandBuffers__UnityEngineRenderingCameraEventEnum__SystemVoid(long selfObjectId, int evtUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__RemoveAllCommandBuffers__SystemVoid(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__AddCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(long selfObjectId, int evtUnderlyingValue, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__AddCommandBufferAsync__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__UnityEngineRenderingComputeQueueTypeEnum__SystemVoid(long selfObjectId, int evtUnderlyingValue, long bufferObjectId, int queueTypeUnderlyingValue);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineCamera__func__RemoveCommandBuffer__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBuffer__SystemVoid(long selfObjectId, int evtUnderlyingValue, long bufferObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCamera__func__GetCommandBuffers__UnityEngineRenderingCameraEventEnum__UnityEngineRenderingCommandBufferArray(long selfObjectId, int evtUnderlyingValue, void* returnResultIdsPointer, void* returnResultWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCamera__func__TryGetCullingParameters__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(long selfObjectId, void* cullingParametersPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCamera__func__TryGetCullingParameters__SystemBoolean__UnityEngineRenderingScriptableCullingParametersRef__SystemBoolean(long selfObjectId, int stereoAwareConverted, void* cullingParametersPointer);

        #endregion Imports
    }
}
