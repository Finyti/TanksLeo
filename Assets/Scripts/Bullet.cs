using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 15;

    public GameObject stoneParticle;
    public GameObject mushroomParticle;
    public GameObject mark;
    public AudioClip explosionSound;
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
            AudioSource.PlayClipAtPoint(explosionSound, collision.gameObject.transform.position);

            Destroy(collision.gameObject);
            Destroy(gameObject);

            StoneParticleCreation(collision.gameObject.transform, stoneParticle, 5);
            Instantiate(mark, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 0.1f,
                collision.gameObject.transform.position.z), new Quaternion(0, Rand(0f, 360f), 0, 360));
        }
        if (collision.gameObject.name.Contains("Mushroom"))
        {
            AudioSource.PlayClipAtPoint(explosionSound, collision.gameObject.transform.position);

            Destroy(collision.gameObject);
            Destroy(gameObject);

            StoneParticleCreation(collision.gameObject.transform, mushroomParticle, 6);
            Instantiate(mark, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 0.1f,
                collision.gameObject.transform.position.z), new Quaternion(0, Rand(0f, 360f), 0, 360));
        }
    }

    private void StoneParticleCreation(Transform Transf, GameObject particle, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Quaternion newRot = new Quaternion(Transf.rotation.x + Rand(-0.5f, 0.5f), 0, Transf.rotation.z, 0 + Rand(-0.5f, 0.5f));
            Instantiate(particle, Transf.position + new Vector3(Rand(-0.5f, 0.5f), 0.01f, Rand(-0.5f, 0.5f)), newRot);
        }
    }

    private float Rand(float start, float end)
    {
        return Random.Range(start, end);
    }
}
