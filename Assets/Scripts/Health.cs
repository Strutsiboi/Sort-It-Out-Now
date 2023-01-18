using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : Skoj
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {

        if(health > numOfHearts) //ser till s� att spelaren kan inte ha mer hj�rtan �n max
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) //forloop
        {
            if(i < health)
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
            }

            if (binIndex != -1 && attached[binIndex] && transform.childCount > 0)
            {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }

        } 
        

    }
}
