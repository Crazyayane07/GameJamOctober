using UnityEngine;

namespace OGJ.Controller
{
    public class PlayerController : Servicable
    {
        public void Move(Transform transform, Vector3 direction, int speed)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        public void Shoot()
        {

        }

        public void OnPlayerDeath()
        {
            gameOverService.GameOver();
            popupsService.OpenGameOverPopup();
        }
    }
}

