using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    public string horizontalAxis;
    public string verticalAxis;
    public KeyCode shootKey;

    public GameObject bullet;

    public Transform shootPoint;

    public AudioClip gearSound;



    void Start()
    {
        var source = GetComponent<AudioSource>();
        source.volume = 0f;
    }

    void Update()
    {

        var hor = Input.GetAxis(horizontalAxis);
        var ver = Input.GetAxis(verticalAxis);

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed * ver;

        //if (hor != 0 || ver != 0)
        //{
        //    print("Moving");
        //    source.volume = 100f;

        //}
        //else if (hor == 0 && ver == 0)
        //{
        //    print("NotMoving");
        //}
        //print(hor + " " + ver);
        
        

        transform.Rotate(0, rotateSpeed * Time.deltaTime * hor, 0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);

        }

    }

}
