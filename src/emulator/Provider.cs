namespace OptimeGBA
{
    public delegate void AudioCallback(float[] stereoInterleavedData);
 
    public abstract class Provider {
        public bool OutputAudio = true;
        public AudioCallback AudioCallback;
        public string SavPath;
    }
}