using UnityEngine;
using OGJ.View.UI.Popups;
using OGJ.View.UI;

namespace OGJ
{
    [System.Serializable]
    public class PopupsSet
    {
        public Canvas canvas;

        public GameOverPopup gameOverPopup;
        public PausePopup pausePopup;
        public Options options;
    }
}
