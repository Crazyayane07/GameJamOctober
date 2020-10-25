
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
        public Button backBtn;

        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            musicVolume.onValueChanged.AddListener(ChangeVolume);
            resolutionDrpdn.onValueChanged.AddListener(ChangeResolution);
            fullscreenToggle.onValueChanged.AddListener(FullScreenChange);
            backBtn.onClick.AddListener(Back);        }

        private void ChangeVolume(float volume)
        {
            audioService.SetVolume(volume);
        }

        private void ChangeResolution(int choice)
        {
            switch (choice)
            {
                case 0:
                    Screen.SetResolution(1920, 1080, fullscreenToggle.isOn);
                    break;
                case 1:
                    Screen.SetResolution(1280, 720, fullscreenToggle.isOn);
                    break;
                case 2:
                    Screen.SetResolution(640, 480, fullscreenToggle.isOn);
                    break;
                default:
                    break;
            }
            
        }

        private void FullScreenChange(bool change)
        {
            Screen.fullScreenMode = change ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
        }

        private void Back()
        {
            ClosePopup();
            scenesService.OpenMainMenuScene();
        }

    }
}
