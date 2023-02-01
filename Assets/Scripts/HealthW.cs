using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthW : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public Animator anim;
    void Start()
    {
        currentHealth = maxHealth;
    }

   public void TakeDamage(int amount)
   {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            anim.SetBool("loseHealth", true);
            
        }

   }
}
