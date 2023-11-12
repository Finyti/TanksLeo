using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public GameObject TankBlue;
    public GameObject TankRed;
    void Start()
    {
        
    }

    void Update()
    {
        if (TankBlue.GetComponent<Rigidbody>().velocity.x != 0 || TankBlue.GetComponent<Rigidbody>().velocity.z != 0) 
        {
            TankBlue.GetComponent<AudioSource>().volume = Mathf.Lerp(TankBlue.GetComponent<AudioSource>().volume, 70f, 0.1f);
        }
        else
        {
            TankBlue.GetComponent<AudioSource>().volume = Mathf.Lerp(TankBlue.GetComponent<AudioSource>().volume, 0f, 0.1f);
        }

        if (TankRed.GetComponent<Rigidbody>().velocity.x != 0 || TankRed.GetComponent<Rigidbody>().velocity.z != 0)
        {
            TankRed.GetComponent<AudioSource>().volume = Mathf.Lerp(TankRed.GetComponent<AudioSource>().volume, 70f, 0.1f);
        }
    
        else
        {
            TankRed.GetComponent<AudioSource>().volume = Mathf.Lerp(TankRed.GetComponent<AudioSource>().volume, 0f, 0.1f);
        }

    }
}
