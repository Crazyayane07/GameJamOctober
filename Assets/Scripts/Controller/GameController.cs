
namespace OGJ.Controller
{    
    public class GameController : CustomMonoBehaviour
    {
        public static GameController gameController { get; set; }

        public ServicesController servicesController;

        void Awake()
        {
            if (gameController == null)
            {
                gameController = this;
                servicesController = new ServicesController();
                DontDestroyOnLoad(this);
            }
        }
    }
}
