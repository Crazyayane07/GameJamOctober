using UnityEngine.SceneManagement;

namespace OGJ.Controller.Services
{
    public interface IScenesService
    {
        void OpenGameScene();

        void OpenMainMenuScene();
    }

    public class ScenesService : IScenesService
    {
        public void OpenGameScene()
        {
            SceneManager.LoadScene(Constans.GAME_SCENE);
        }

        public void OpenMainMenuScene()
        {
            SceneManager.LoadScene(Constans.MAIN_MENU_SCENE);
        }
    }
}
