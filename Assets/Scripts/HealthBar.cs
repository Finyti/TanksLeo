using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Health health;
    void Start()
    {
        
    }

    void Update()
    {
        var healthScale = health.hp / 50;
        if(healthScale < 0)
        {
            healthScale = 0;
        }
        transform.localScale = new Vector3(healthScale, 0.1f, 1);
    }
}
