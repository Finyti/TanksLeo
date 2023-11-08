using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform TargetOne;
    public Transform TargetTwo;
    void Start()
    {
        
    }


    void Update()
    {
        var finalPos = Vector3.Lerp(TargetOne.position, TargetTwo.position, 0.5f);
        transform.position = Vector3.Lerp(TargetOne.position, TargetTwo.position, 0.1f); 
    }
}
