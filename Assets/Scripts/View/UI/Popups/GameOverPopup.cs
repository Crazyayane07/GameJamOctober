using UnityEngine.UI;

namespace OGJ.View.UI.Popups
{
    public class GameOverPopup : Popup
    {
        public Button startOverBtn;
        public Button quitBtn;

        private void Awake()
        {
            SetUpButtons();
        }

        private void SetUpButtons()
        {
            startOverBtn.onClick.AddListener(StartOver);
            quitBtn.onClick.AddListener(QuitGame);
        }

        private void StartOver()
        {
            scenesService.OpenGameScene();
            ClosePopup();
        }

        private void QuitGame()
        {
            scenesService.OpenMainMenuScene();
            ClosePopup();
        }

        protected override void OnOpenPopup()
        {
            base.OnOpenPopup();
            pauseService.TryPauseGame();
        }

        protected override void OnClosePopup()
        {
            base.OnClosePopup();
            pauseService.TryPauseGame();
        }
    }
}
