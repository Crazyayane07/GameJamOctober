using OGJ.View;
using UnityEngine;

namespace OGJ.Controller
{
    public class PowerUpManager : CustomMonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag != Constans.POWER_UP_TAG)
                return;

            PowerUpView powerUp = collision.gameObject.GetComponent<PowerUpView>();

            if (powerUp == null)
                return;

            powerUp.ActivatePowerUp();
        }
    }
}