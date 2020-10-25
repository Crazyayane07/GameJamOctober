
using OGJ.View.UI.Popups;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace OGJ.View.UI
{
    public class Options : Popup
    {
        public Slider musicVolume;
        public TMP_Dropdown resolutionDrpdn;
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
