using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public float speedcountdown = 15;
    public float speedtime;
    public float speed;
    void Start()
    {
        speed = 1;
    }

    
    void Update()
    {
        speedtime += Time.deltaTime; 
        if (speedtime >= speedcountdown)
        {
            speed += 1;
        }
    }
}
