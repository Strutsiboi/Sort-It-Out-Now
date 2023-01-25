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

              
        }
        
        if(health == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    

}
