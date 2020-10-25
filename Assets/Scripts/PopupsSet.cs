using UnityEngine;
using OGJ.View.UI.Popups;

namespace OGJ
{
    [System.Serializable]
    public class PopupsSet
    {
        public Canvas canvas;

        public GameOverPopup gameOverPopup;
        public PausePopup pausePopup;
    }
}
