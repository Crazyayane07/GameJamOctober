using UnityEngine;
using OGJ.Controller;
using OGJ.Controller.Services;

namespace OGJ
{
    public class CustomMonoBehaviour : MonoBehaviour
    {
        protected GameController Controler { get { return GameController.gameController; } }

        protected IGameOverService gameOverService { get { return Controler.servicesController.gameOverService; } }
        protected IPopupsService popupsService { get { return Controler.servicesController.popupsService; } }
        protected void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
