using UnityEngine;

namespace OGJ.Controller
{
    public class PlayerController : CustomMonoBehaviour
    {
        [SerializeField]
        private int speed = 1;

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }

            //TO DELETE
            if (Input.GetKey(KeyCode.K))
            {
                OnPlayerDeath();
            }
        }

        private void OnPlayerDeath()
        {
            gameOverService.GameOver();
            popupsService.OpenGameOverPopup();
        }
    }
}

