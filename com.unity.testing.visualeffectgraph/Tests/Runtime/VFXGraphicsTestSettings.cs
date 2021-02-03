using System;
using UnityEngine.Rendering;
using UnityEngine.TestTools.Graphics;

namespace UnityEngine.VFX.Test
{
    public class VFXGraphicsTestSettings : GraphicsTestSettings
    {
        static public readonly int defaultCaptureFrameRate = 20;
        static public readonly float defaultCapturePeriod = 1.0f / (float)defaultCaptureFrameRate;
        static public readonly float defaultSimulateTime = 6.0f - defaultCapturePeriod;
        static public readonly float defaultAverageCorrectnessThreshold = 5e-4f;

        public int captureFrameRate = defaultCaptureFrameRate;
        public float simulateTime = defaultSimulateTime;

        public bool xrCompatible = true;

        [Serializable]
        public struct ExclusionPattern
        {
            public RuntimePlatform runtimePlatform;
            public GraphicsDeviceType graphicDevice;
            public string operatingSystem;
            public string graphicDeviceName;
        }
        public ExclusionPattern[] exclusions = new ExclusionPattern[] { };

        VFXGraphicsTestSettings()
        {
            base.ImageComparisonSettings.AverageCorrectnessThreshold = defaultAverageCorrectnessThreshold;
        }
    }
}
