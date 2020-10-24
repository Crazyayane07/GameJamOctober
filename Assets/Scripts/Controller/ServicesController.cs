
using OGJ.Controller.Services;
using UnityEngine.Analytics;

namespace OGJ.Controller
{
    public class ServicesController
    {
        public IGameOverService gameOverService { get; private set; }
        public IPopupsService popupsService { get; private set; }
        public IScenesService scenesService { get; private set; }

        public ServicesController(PopupsSet popupsSet)
        {
            gameOverService = new GameOverService();
            popupsService = new PopupsService(popupsSet);
            scenesService = new ScenesService();
        }
    }
}
