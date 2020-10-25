using UnityEngine;

namespace OGJ.Controller
{
    public class PauseManager : CustomMonoBehaviour
    {
        private bool canPause;
        // Update is called once per frame
        private void Awake()
        {
            canPause = true;
        }

        void Update()
        {
            if (canPause && Input.GetKeyDown(KeyCode.Escape))
            {
                canPause = false;
                pauseService.TryPauseGame();
                return;
            }
            if (!canPause && Input.GetKeyUp(KeyCode.Escape))
            {
                canPause = true;
            }
        }
    }
}
