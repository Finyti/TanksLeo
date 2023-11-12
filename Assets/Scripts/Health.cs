using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float hp;
    public GameObject particleType;

    public void DamageApply(float damage)
    {
        hp -= damage;

    }
    public bool isDead()
    {
        return hp <= 0;
    }
}
