using UnityEngine.Rendering;

namespace UnityEngine.Rendering.HighDefinition
{
    internal enum HDProfileId
    {
        CopyDepthBuffer,
        CopyDepthInTargetTexture,
        BuildCoarseStencilAndResolveIfNeeded,
        AmbientOcclusion,
        HorizonSSAO,
        UpSampleSSAO,
        ScreenSpaceShadows,
        ScreenSpaceShadowsDebug,
        BuildLightList,
        GenerateLightAABBs,
        Distortion,
        AccumulateDistortion,
        ApplyDistortion,
        ForwardDepthPrepass,
        DeferredDepthPrepass,
        TransparentDepthPrepass,
        GBuffer,
        DBufferRender,
        DBufferPrepareDrawData,
        DBufferNormal,
        DisplayDebugDecalsAtlas,
        DisplayDebugViewMaterial,
        DebugViewMaterialGBuffer,
        SubsurfaceScattering,
        SsrTracing,
        SsrReprojection,
        SsrAccumulate,

        // SSGI
        SSGIPass,
        SSGITrace,
        SSGIDenoise,
        SSGIUpscale,
        SSGIConvert,

        ForwardEmissive,
        ForwardOpaque,
        ForwardOpaqueDebug,
        ForwardTransparent,
        ForwardTransparentDebug,

        ForwardPreRefraction,
        ForwardPreRefractionDebug,
        ForwardTransparentDepthPrepass,
        RenderForwardError,
        TransparentDepthPostpass,
        ObjectsMotionVector,
        CameraMotionVectors,
        ColorPyramid,
        DepthPyramid,
        PostProcessing,
        AfterPostProcessing,
        RenderFullScreenDebug,
        ClearBuffers,
        ClearStencil,
        HDRenderPipelineRenderCamera,
        HDRenderPipelineRenderAOV,
        HDRenderPipelineAllRenderRequest,
        CullResultsCull,
        CustomPassCullResultsCull,
        DisplayCookieAtlas,
        RenderWireFrame,
        ConvolveReflectionProbe,
        ConvolvePlanarReflectionProbe,
        PreIntegradeWardCookTorrance,
        FilterCubemapCharlie,
        FilterCubemapGGX,
        DisplayPlanarReflectionProbeAtlas,
        BlitTextureInPotAtlas,
        AreaLightCookieConvolution,
        DisplayDensityVolumeAtlas,

        UpdateSkyEnvironmentConvolution,
        RenderSkyToCubemap,
        UpdateSkyEnvironment,
        UpdateSkyAmbientProbe,
        PreRenderSky,
        RenderSky,
        RenderClouds,
        OpaqueAtmosphericScattering,
        InScatteredRadiancePrecomputation,

        VolumeVoxelization,
        VolumetricLighting,
        VolumetricLightingFiltering,
        PrepareVisibleDensityVolumeList,
        UpdateDensityVolumeAtlas,

        VolumetricClouds,
        VolumetricCloudsPrepare,
        VolumetricCloudsTrace,
        VolumetricCloudsReproject,
        VolumetricCloudsUpscaleAndCombine,
        VolumetricCloudsShadow,
        VolumetricCloudMapGeneration,

        // RT Cluster
        RaytracingBuildCluster,
        RaytracingCullLights,
        RaytracingDebugCluster,
        // RTR
        RaytracingReflectionDirectionGeneration,
        RaytracingReflectionEvaluation,
        RaytracingReflectionAdjustWeight,
        RaytracingReflectionFilter,
        RaytracingReflectionUpscale,
        // RTAO
        RaytracingAmbientOcclusion,
        RaytracingFilterAmbientOcclusion,
        RaytracingComposeAmbientOcclusion,
        // RT Shadows
        RaytracingDirectionalLightShadow,
        RaytracingLightShadow,
        RaytracingAreaLightShadow,
        // RTGI
        RaytracingIndirectDiffuseDirectionGeneration,
        RaytracingIndirectDiffuseEvaluation,
        RaytracingIndirectDiffuseUpscale,
        RaytracingFilterIndirectDiffuse,
        RaytracingIndirectDiffuseAdjustWeight,

        // RTSSS
        RaytracingSSS,
        RaytracingSSSTrace,
        RaytracingSSSCompose,
        // RTShadow
        RaytracingWriteShadow,
        // Other ray tracing
        RaytracingDebugOverlay,
        RayTracingRecursiveRendering,
        RayTracingDepthPrepass,
        RayTracingFlagMask,
        // RT Deferred Lighting
        RaytracingDeferredLighting,
        // Denoisers
        TemporalFilter,
        DiffuseFilter,

        PrepareLightsForGPU,

        // Profile sampler for shadow
        RenderShadowMaps,
        RenderMomentShadowMaps,
        RenderEVSMShadowMaps,
        RenderEVSMShadowMapsBlur,
        RenderEVSMShadowMapsCopyToAtlas,
        BlitPunctualMixedCachedShadowMaps,
        BlitAreaMixedCachedShadowMaps,

        // Profile sampler for tile pass
        TileClusterLightingDebug,
        DisplayShadows,

        RenderDeferredLightingCompute,
        RenderDeferredLightingComputeAsPixel,
        RenderDeferredLightingSinglePass,
        RenderDeferredLightingSinglePassMRT,

        // Misc
        VolumeUpdate,
        CustomPassVolumeUpdate,

        // XR
        XRMirrorView,
        XRCustomMirrorView,
        XRDepthCopy,

        // Low res transparency
        DownsampleDepth,
        LowResTransparent,
        UpsampleLowResTransparent,

        // Post-processing
        AlphaCopy,
        StopNaNs,
        FixedExposure,
        DynamicExposure,
        ApplyExposure,
        TemporalAntialiasing,
        DepthOfField,
        DepthOfFieldKernel,
        DepthOfFieldCoC,
        DepthOfFieldPrefilter,
        DepthOfFieldPyramid,
        DepthOfFieldDilate,
        DepthOfFieldTileMax,
        DepthOfFieldGatherFar,
        DepthOfFieldGatherNear,
        DepthOfFieldPreCombine,
        DepthOfFieldCombine,
        MotionBlur,
        MotionBlurMotionVecPrep,
        MotionBlurTileMinMax,
        MotionBlurTileNeighbourhood,
        MotionBlurTileScattering,
        MotionBlurKernel,
        PaniniProjection,
        Bloom,
        ColorGradingLUTBuilder,
        UberPost,
        FXAA,
        SMAA,
        FinalPost,
        FinalImageHistogram,
        CustomPostProcessBeforeTAA,
        CustomPostProcessBeforePP,
        CustomPostProcessAfterPP,
        CustomPostProcessAfterOpaqueAndSky,
        ContrastAdaptiveSharpen,
        PrepareProbeVolumeList,
        ProbeVolumeDebug,

        AOVExecute,
        AOVOutput,
#if ENABLE_VIRTUALTEXTURES
        VTFeedbackDownsample,
#endif
    }
}
