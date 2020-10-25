using UnityEngine;

public class DemonAi : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, 2.0f);
    }

    void LaunchProjectile()
    {
        GameObject bulletGameObject = Instantiate(bullet, transform.position, transform.rotation);
        bulletGameObject.transform.rotation = Quaternion.Euler(Vector3.forward * 90);
        Destroy(bulletGameObject, 5.0f);
    }

}
