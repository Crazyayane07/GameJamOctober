using UnityEngine;
using UnityEngine.SceneManagement;
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
            SceneManager.LoadScene(Constans.GAME_SCENE);
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