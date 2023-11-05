using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 15;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
