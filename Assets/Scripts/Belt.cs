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
    
   // public GameObject objecty;
  //  public string script;// your secound script name
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
    public bool Holdit = false;
    private void Start()
    {
     //   (objecty.GetComponent(script) as MonoBehaviour).enabled = false;
    }
    void Update()
    {
        if (transform.parent != null)
        {
            this.enabled = false;
        }

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

        if (Holdit)
        {
            new Vector3(0, 0, 0);
            print("Holdit");
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

        // st�ng av belt scriptet n�r man blir en child av spelaren. 
        // G�r s� att powerup creatorn v�ljer ut en spawn point.
    
    // G�ra s� att en prefab randomly v�ljer att anv�nda en ut av 2 sprites.


