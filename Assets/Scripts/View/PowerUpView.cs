using OGJ.Controller;
using OGJ.Controller.PowerUps;
using OGJ.Model;

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
                    SetUp(new SpeedUpPowerUpController());
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

        public void ActivatePowerUp()
        {
            if (powerUpController == null)
                return;

            powerUpController.ActivatePowerUp();
            SetActive(false);
        }
    }
}
