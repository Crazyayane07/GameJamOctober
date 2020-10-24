using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    [SerializeField]
    private int speed = 0;
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
