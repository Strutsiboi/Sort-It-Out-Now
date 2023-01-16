using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public float speedcountdown = 15;
    public float speedtime;
    public static float speed;
    void Start()
    {
        speed = 0.5f;
    }

    
    void Update()
    {
        transform.position += new Vector3(speed,0,0) * Time.deltaTime;
        speedtime += Time.deltaTime; 
        if (speedtime >= speedcountdown)
        {
            speed += 0.2f;
            speedtime = 0;
        }
    }
}
