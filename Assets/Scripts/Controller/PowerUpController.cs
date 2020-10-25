using OGJ.View;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace OGJ.Controller
{
    public class PowerUpController
    {
        //public event Action OnFinishPowerUp;
        protected int powerUpTime;

        public async Task ActivatePowerUpAsync(PlayerView player) 
        {
            OnActivatePowerUp(player);
            await Task.Delay(powerUpTime);
            DeactivatePoweUp();
        }

        public virtual void OnActivatePowerUp(PlayerView player)
        {

        }

        public virtual void DeactivatePoweUp() 
        {
           // OnFinishPowerUp();
            Debug.Log("cccc");
        }
    }
}