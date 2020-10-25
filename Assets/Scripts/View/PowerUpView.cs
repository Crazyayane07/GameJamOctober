using OGJ.Controller;
using OGJ.Controller.PowerUps;
using OGJ.Model;
using UnityEngine;

namespace OGJ.View
{
    public class PowerUpView : CustomMonoBehaviour
    {
        public PowerUpsTypes powerUpType;
        private PowerUpController powerUpController;
        
        private void Start()
        {
            switch (powerUpType)
            {
                case PowerUpsTypes.SpeedUp:
                    SetUp(new SpeedUpPowerUpController(4000));
                    break;
                default:
                    SetUp(new TestPowerUpController());
                    break;
            }
        }

        public void SetUp(PowerUpController powerUpController)
        {
            this.powerUpController = powerUpController;
        }

        public void ActivatePowerUp(PlayerView player)
        {
            if (powerUpController == null)
                return;

            powerUpController.ActivatePowerUpAsync(player);
            SetActive(false);
        }
    }
}
