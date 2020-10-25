using OGJ.Controller;
using OGJ.Controller.Services;

namespace OGJ
{
    public class Servicable
    {
        protected GameController controller { get { return GameController.gameController; } }

        protected IGameOverService gameOverService { get { return controller.servicesController.gameOverService; } }
        protected IPopupsService popupsService { get { return controller.servicesController.popupsService; } }
        protected IScenesService scenesService { get { return controller.servicesController.scenesService; } }
        protected IPauseService pauseService { get { return controller.servicesController.pauseService; } }
        protected IPowerUpService powerUpService { get { return controller.servicesController.powerUpService; } }

        protected Spawner spawner { get { return controller.spawner; } }
    }
}
