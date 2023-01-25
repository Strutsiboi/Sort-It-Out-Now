using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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

              
        }
        
        if(health == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    

}
