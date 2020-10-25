using UnityEngine;

namespace OGJ.Controller.Services
{
    public interface IPowerUpService
    {
        void TrySpawnRandomPowerUp(Transform transform, float chances);
    }
    public class PowerUpService : Servicable, IPowerUpService
    {
        public PowerUpSet powerUpSet;

        public PowerUpService(PowerUpSet powerUpSet)
        {
            this.powerUpSet = powerUpSet;
        }

        public void TrySpawnRandomPowerUp(Transform transform, float chances)
        {
            float roll = Random.Range(0.0f, 1.0f);

            if (roll > chances)
                return;

            int randomPowerUpId = (int)Random.Range(0.0f, powerUpSet.powerUps.Length - 1);
            GameObject powerUp = powerUpSet.powerUps[randomPowerUpId];
            spawner.TrySpawn(powerUp, transform);
        }
    }
}
