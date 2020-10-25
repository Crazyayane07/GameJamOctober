using UnityEngine;

namespace OGJ.Controller
{
    public class PauseManager : CustomMonoBehaviour
    {
        private bool isPaused;
        private bool canPause;
        // Update is called once per frame
        private void Awake()
        {
            isPaused = false;
            canPause = true;
        }

        void Update()
        {
            if (canPause && Input.GetKeyDown(KeyCode.Escape))
            {
                canPause = false;

                if (!isPaused)
                {
                    PauseGame();
                    return;
                }
                if (isPaused)
                {
                    ContinueGame();
                    return;
                }
            }
            if (!canPause && Input.GetKeyUp(KeyCode.Escape))
            {
                canPause = true;
            }
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            popupsService.OpenPausePopup();
            isPaused = true;
        }
        private void ContinueGame()
        {
            Time.timeScale = 1;
            popupsService.ClosePausePopup();
            isPaused = false;
        }
    }
}
