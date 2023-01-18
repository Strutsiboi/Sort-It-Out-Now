using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{

   // private SpriteRenderer spriteR;
   // private Sprite[] sprites;

    public float speedcountdown = 15;
    public float speedtime;
    static float local_speed = 0.5f;
    public Vector3 direction;

    public static float speed
    {
        get
        {
            return local_speed;
        }
        set
        {
            local_speed = value;
            if (local_speed > 3.4f)
            {
                local_speed = 3.4f;
            }
        }
    }

    public bool StopIt = false;
    public bool HurryUp = false;

    private void Start()
    {
  
    }
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

        transform.position += direction * speed * Time.deltaTime;
        speedtime += Time.deltaTime;

        if (speedtime >= speedcountdown)
        {
            speed += 0.1f;
            speedtime = 0;
        }

    }
}

        
    
    // Göra så att en prefab randomly väljer att använda en ut av 2 sprites.


