
using UnityEngine;
using UnityEngine.UI;

namespace OGJ.View.UI
{
    public class Options : CustomMonoBehaviour
    {
        public Slider musicVolume;
        public Dropdown resolutionDrpdn;
        public Toggle fullscreenToggle;

        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            musicVolume.onValueChanged.AddListener(ChangeVolume);
            resolutionDrpdn.onValueChanged.AddListener(ChangeResolution);
            fullscreenToggle.onValueChanged.AddListener(FullScreenChange);
        }

        private void ChangeVolume(float volume)
        {
            audioService.SetVolume(volume);
        }

        private void ChangeResolution(int choice)
        {

            Screen.SetResolution(640, 480, fullscreenToggle.isOn);
        }

        private void FullScreenChange(bool change)
        {
            Screen.fullScreenMode = change ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
        }

    }
}
