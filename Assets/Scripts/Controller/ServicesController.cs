
using OGJ.Controller.Services;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Audio;

namespace OGJ.Controller
{
    public class ServicesController
    {
        public IGameOverService gameOverService { get; private set; }
        public IPopupsService popupsService { get; private set; }
        public IScenesService scenesService { get; private set; }
        public IPauseService pauseService { get; private set; }
        public IPowerUpService powerUpService { get; private set; }
        public IAudioService audioService { get; private set; }
        
        public ServicesController(PopupsSet popupsSet, PowerUpSet powerUpSet, AudioMixer audioMixer)
        {
            gameOverService = new GameOverService();
            popupsService = new PopupsService(popupsSet);
            scenesService = new ScenesService();
            pauseService = new PauseService();
            audioService = new AudioService(audioMixer);
            powerUpService = new PowerUpService(powerUpSet);
        }
    }
}
