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
        if (TargetOne != null && TargetTwo != null)
        {
            var finalPos = Vector3.Lerp(TargetOne.position, TargetTwo.position, 0.5f);
            transform.position = Vector3.Lerp(TargetOne.position, TargetTwo.position, 0.1f);
        }
        if (TargetOne == null && TargetTwo != null)
        {
            var finalPos = Vector3.Lerp(TargetTwo.position, TargetTwo.position, 0.5f);
            transform.position = Vector3.Lerp(TargetTwo.position, TargetTwo.position, 0.1f);
        }
        if (TargetOne != null && TargetTwo == null)
        {
            var finalPos = Vector3.Lerp(TargetOne.position, TargetOne.position, 0.5f);
            transform.position = Vector3.Lerp(TargetOne.position, TargetOne.position, 0.1f);
        }


    }
}
