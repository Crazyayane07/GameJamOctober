﻿
using OGJ.Controller;
using UnityEngine;

namespace OGJ.View
{
    public class PlayerView : CustomMonoBehaviour
    {
        [SerializeField]
        private int speed = 1;

        private PlayerController playerController;
        public GameObject bullet;
        private void Awake()
        {
            playerController = gameObject.AddComponent<PlayerController>() as PlayerController;
        }
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                playerController.Move(transform, Vector3.left, speed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                playerController.Move(transform, Vector3.right, speed);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerController.Move(transform, Vector3.up, speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                playerController.Move(transform, Vector3.down, speed);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                playerController.Shoot(bullet, transform);
            }
            //TO DELETE
            if (Input.GetKey(KeyCode.K))
            {
                playerController.OnPlayerDeath();
            }
        }
    }
}