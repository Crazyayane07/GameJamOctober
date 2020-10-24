using UnityEngine;

namespace OGJ.Controller.Services
{
    public interface IGameOverService
    {
        void GameOver();
    }

    public class GameOverService : IGameOverService
    {
        public void GameOver()
        {
            Debug.Log("GAME OVER !");
        }
    }
}
