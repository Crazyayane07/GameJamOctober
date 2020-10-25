
using OGJ.Controller.Services;
using System.Diagnostics;
using UnityEngine;

namespace OGJ.Controller
{
    public class ServicesController
    {
        public IGameOverService gameOverService { get; private set; }
        public IPopupsService popupsService { get; private set; }
        public IScenesService scenesService { get; private set; }
        public IPauseService pauseService { get; private set; }

        public ServicesController(PopupsSet popupsSet)
        {
            gameOverService = new GameOverService();
            popupsService = new PopupsService(popupsSet);
            scenesService = new ScenesService();
            pauseService = new PauseService();
        }
    }
}
