using OGJ.View;
using System;
using UnityEngine;

namespace OGJ.Controller.PowerUps
{
    public class SpeedUpPowerUpController : PowerUpController
    {
        private PlayerView player;

        public SpeedUpPowerUpController(int powerUpTime)
        {
            this.powerUpTime = powerUpTime;
        }

        public override void DeactivatePoweUp()
        {
            base.DeactivatePoweUp();

            if (player == null)
                return;

            player.speed = 5;
        }

        public override void OnActivatePowerUp(PlayerView player)
        {
            Debug.Log("bbbb");

            if (player == null)
                return;

            this.player = player;
            this.player.speed = 10;
            base.OnActivatePowerUp(player);
        }
    }
}
