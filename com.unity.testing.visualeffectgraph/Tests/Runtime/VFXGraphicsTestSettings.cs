using UnityEngine.TestTools.Graphics;

namespace UnityEngine.VFX.Test
{
    public class VFXGraphicsTestSettings : GraphicsTestSettings
    {
        static public readonly int defaultCaptureFrameRate = 20;
        static public readonly float defaultCapturePeriod = 1.0f / (float)defaultCaptureFrameRate;
        static public readonly float defaultSimulateTime = 6.0f - defaultCapturePeriod;

        public int captureFrameRate = defaultCaptureFrameRate;
        public float simulateTime = defaultSimulateTime;

        public bool xrCompatible = true;
    }
}
