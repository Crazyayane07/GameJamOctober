using UnityEngine;
using UnityEngine.Audio;

namespace OGJ.Controller.Services
{
    public interface IAudioService
    {
        void SetVolume(float volume);
    }

    public class AudioService : IAudioService
    {
        private AudioMixer audioMixer;

        public AudioService(AudioMixer audioMixer)
        {
            this.audioMixer = audioMixer;
        }

        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20); ;
        }
    }
}