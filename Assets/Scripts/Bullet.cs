using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 15;

    public GameObject stoneParticle;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Stone"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            for(int i = 0; i < 5; i++)
            {
                StoneParticleCreation(collision.gameObject.transform);
            }
        }
    }

    private void StoneParticleCreation(Transform Transf)
    {
        Quaternion newRot = new Quaternion(Transf.rotation.x + Rand(-0.5f, 0.5f), 0, Transf.rotation.z, 0 + Rand(-0.5f, 0.5f));
        Instantiate(stoneParticle, Transf.position + new Vector3(Rand(-0.5f, 0.5f), 0, Rand(-0.5f, 0.5f)), newRot);
    }

    private float Rand(float start, float end)
    {
        return Random.Range(start, end);
    }
}
