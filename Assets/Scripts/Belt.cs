using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public float speedcountdown = 15;
    public float speedtime;
    public static float speed = 0.5f;

    public bool StopIt = false;
    public bool HurryUp = false;
   

    void Update()
    {
        if (StopIt)
        {
            speed = speed / 2;
            StopIt = false;
            print("Stop");
        }

        if (HurryUp)
        {
            speed = speed + 2;
            HurryUp = false;
            print("Hurry");
        }

        transform.position += new Vector3(speed,0,0) * Time.deltaTime;
        speedtime += Time.deltaTime; 

        if (speedtime >= speedcountdown)
        {
            speed += 0.1f;
            speedtime = 0;
        } 
       
    }

        
}
