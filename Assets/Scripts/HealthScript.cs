using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

 
    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        else if (life < 4)
        {
            Destroy(hearts[3].gameObject);
        }
        else if (life < 5)
        {
            Destroy(hearts[4].gameObject);
        }

        if (life == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void TakeDamage(int d)
    {
        life -= d;
    }

}
