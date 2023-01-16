using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpeedup : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
         //   SoundManagerScript.PlaySound("Speed");
            collision.gameObject.GetComponent<PlayerMovement>().FasterNow = true;
            Destroy(gameObject);
        }
    }
}
