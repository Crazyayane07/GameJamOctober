using UnityEngine;

namespace OGJ.Controller
{
    public class PlayerController : CustomMonoBehaviour
    {
        float fireRate = 0.3f;
        private float timeSinceLastShot;
        public void Move(Transform transform, Vector3 direction, int speed)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        public void Shoot(GameObject bullet, Transform transform)
        {
            timeSinceLastShot += Time.deltaTime;
            
            if(timeSinceLastShot > fireRate) {
                timeSinceLastShot = 0;
                GameObject bulletGameObject = Instantiate(bullet, transform.position, transform.rotation);
                bulletGameObject.transform.rotation = Quaternion.Euler(Vector3.forward * 270);
                Object.Destroy(bulletGameObject, 5.0f);

            }
        }

        public void OnPlayerDeath()
        {
            gameOverService.GameOver();
            popupsService.OpenGameOverPopup();
        }
    }
}

