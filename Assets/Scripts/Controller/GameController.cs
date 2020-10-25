
using UnityEngine.Audio;

namespace OGJ.Controller
{    
    public class GameController : CustomMonoBehaviour
    {
        public static GameController gameController { get; set; }

        public ServicesController servicesController;

        public PopupsSet popupsSet;

        public AudioMixer audioMixer;

        void Awake()
        {
            if (gameController == null)
            {
                gameController = this;
                servicesController = new ServicesController(popupsSet, audioMixer);
                DontDestroyOnLoad(this);
            }
        }
    }
}
