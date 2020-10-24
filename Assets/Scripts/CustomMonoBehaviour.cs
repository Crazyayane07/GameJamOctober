using UnityEngine;
using OGJ.Controller;

namespace OGJ
{
    public class CustomMonoBehaviour : MonoBehaviour
    {
        protected GameController Controler { get { return GameController.gameController; } }

        protected void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
