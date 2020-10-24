using UnityEngine;
using UnityEngine.UI;

namespace OGJ.View.UI
{
    public class MainMenu : CustomMonoBehaviour
    {
        public Button startBtn;
        public Button optionsBtn;
        public Button exitBtn;

        private void Awake()
        {
            SetUpButtons();
        }
        private void SetUpButtons()
        {
            startBtn.onClick.AddListener(StartGame);
            optionsBtn.onClick.AddListener(OpenOptions);
            exitBtn.onClick.AddListener(ExitGame);
        }

        private void StartGame()
        {
            Debug.Log("OpenGameScene");

            scenesService.OpenGameScene();
        }

        private void OpenOptions()
        {
            //TO DO
        }

        private void ExitGame()
        {
            Application.Quit();
        }
    }
}