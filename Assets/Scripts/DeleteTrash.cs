using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrash : Health
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("kollision");
        if (collision.gameObject.tag == "VeryBadBin")
        {
            print("COLLIDAR MED OBJEKT");
            Destroy(gameObject);

            /*for (int i = 0; i < hearts.Length; i++) //forloop
            {
                if (i < health)
                {
                    hearts[i].sprite = fullHeart; //ifall i �r mindre �n hj�rtan, s� finns de

                }
                else
                {
                    hearts[i].sprite = emptyHeart; //ifall i �r st�rre �n hj�rtan, �r de tomma
                }

                if (i < numOfHearts)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }*/
        }
    }
}
