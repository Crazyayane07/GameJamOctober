using UnityEngine;
using OGJ.Controller;
using OGJ.Controller.Services;

namespace OGJ
{
    public class CustomMonoBehaviour : MonoBehaviour
    {
        protected GameController controller { get { return GameController.gameController; } }

        protected IGameOverService gameOverService { get { return controller.servicesController.gameOverService; } }
        protected IPopupsService popupsService { get { return controller.servicesController.popupsService; } }
        protected IScenesService scenesService { get { return controller.servicesController.scenesService; } }
        protected IPauseService pauseService { get { return controller.servicesController.pauseService; } }
        protected IAudioService audioService { get { return controller.servicesController.audioService; } }
        protected void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
