using UnityEngine;

namespace OGJ.Controller
{
    public class PlayerController : CustomMonoBehaviour
    {
        float fireRate = 0.3f;
        float timeSinceLastShot;
        public void Move(Transform transform, Vector3 direction, int speed)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        public void Shoot(GameObject bullet, Transform transform)
        {
            timeSinceLastShot += Time.deltaTime;
            if(timeSinceLastShot > 0.3f) {
                timeSinceLastShot = 0;
                Instantiate(bullet, transform.position, transform.rotation);
                Debug.Log(timeSinceLastShot);
            }
        }

        public void OnPlayerDeath()
        {
            gameOverService.GameOver();
            popupsService.OpenGameOverPopup();
        }
    }
}

