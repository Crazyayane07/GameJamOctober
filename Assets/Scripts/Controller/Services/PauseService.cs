using UnityEngine;

namespace OGJ.Controller.Services
{
    public interface IPauseService
    {
        void TryPauseGame();
    }

    public class PauseService : Servicable, IPauseService
    {
        private bool isPaused;

        public PauseService()
        {
            isPaused = false;
        }

        public void TryPauseGame()
        {
            if (!isPaused)
            {
                PauseGame();
                return;
            }

            ContinueGame();            
        }

        private void ContinueGame()
        {
            Time.timeScale = 1;
            popupsService.ClosePausePopup();
            isPaused = false;
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            popupsService.OpenPausePopup();
            isPaused = true;
        }
    }
}