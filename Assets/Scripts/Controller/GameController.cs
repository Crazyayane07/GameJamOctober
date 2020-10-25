
using UnityEngine.Audio;

namespace OGJ.Controller
{    
    public class GameController : CustomMonoBehaviour
    {
        public static GameController gameController { get; set; }

        public ServicesController servicesController;

        public PopupsSet popupsSet;
        public PowerUpSet powerUpSet;

        public AudioMixer audioMixer;

        public Spawner spawner;

        void Awake()
        {
            if (gameController == null)
            {
                gameController = this;
                servicesController = new ServicesController(popupsSet);
                DontDestroyOnLoad(this);
            }
        }
    }
}
