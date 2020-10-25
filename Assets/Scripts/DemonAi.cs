using System;
using UnityEngine;


namespace OGJ
{
    public class DemonAi : MonoBehaviour
    {
        public GameObject bullet;

        private Vector3 desiredPosition;
        void Start()
        {
            InvokeRepeating("LaunchProjectile", 2.0f, 2.0f);
            desiredPosition = transform.position;
        }
        private void Update()
        {
            MoveToRandomPosition();
        }

        private void MoveToRandomPosition()
        {
            if (Vector3.Distance(desiredPosition, transform.position) < 0.01f)
            {
                desiredPosition = generateRandomPosition();
            }
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, 0.005f);
        }

        private Vector3 generateRandomPosition()
        {
            return new Vector3(UnityEngine.Random.Range(1.0f, 10.0f), UnityEngine.Random.Range(-3.0f, 3.0f), 0);
        }

        void LaunchProjectile()
        {
            GameObject bulletGameObject = Instantiate(bullet, transform.position, transform.rotation);
            bulletGameObject.transform.rotation = Quaternion.Euler(Vector3.forward * 90);
            Destroy(bulletGameObject, 5.0f);
        }

    }
}