using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Health pl1;
    public Health pl2;
    void Start()
    {
        
    }


    void Update()
    {
        if (pl1.hp <= 0 || pl2.hp <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
