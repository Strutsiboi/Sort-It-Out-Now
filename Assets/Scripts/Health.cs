using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Mikhael
public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {

        if(health > numOfHearts) //ser till så att spelaren kan inte ha mer hjärtan än max
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) //forloop
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart; //ifall i är mindre än hjärtan, så finns de
                
            }
            else
            {
                hearts[i].sprite = emptyHeart; //ifall i är större än hjärtan, är de tomma
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            
        }

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plast" || collision.gameObject.tag == "Metall" || collision.gameObject.tag == "Glas" || collision.gameObject.tag == "Kartong")
        {
            for (int i = 0; i < hearts.Length; i++) //forloop
            {
                if (i < health)
                {
                    hearts[i].sprite = fullHeart; //ifall i är mindre än hjärtan, så finns de

                }
                else
                {
                    hearts[i].sprite = emptyHeart; //ifall i är större än hjärtan, är de tomma
                }

                if (i < numOfHearts)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }


            }

        }

    }

}
