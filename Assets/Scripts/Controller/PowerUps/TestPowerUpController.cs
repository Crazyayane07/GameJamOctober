using OGJ.View;
using UnityEngine;

namespace OGJ.Controller.PowerUps
{
    public class TestPowerUpController : PowerUpController
    {
        public override void DeactivatePoweUp()
        {
            base.DeactivatePoweUp();
        }

        public override void OnActivatePowerUp(PlayerView player)
        {
            Debug.Log("aaaaa");
            base.OnActivatePowerUp(player);
        }
    }
}
