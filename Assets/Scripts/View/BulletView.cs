using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    [SerializeField]
    private int speed = 0;
    [SerializeField]
    public bool isPlayerBullet = false;

    public bool isLeft = false;

    private Vector3 direction;

    private void Start()
    {
        if (isLeft)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.right;
        }
    }
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
