using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdownalready : MonoBehaviour
{
    public GameObject Trash1;
    public GameObject Trash2;
    public GameObject Trash3;
    public GameObject Trash4;

    Belt[] trash;

    private void Awake()
    {
       Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            trash = FindObjectsOfType<Belt>();
            foreach (Belt item in trash)
            {
                item.StopIt = true;
            }
            Destroy(gameObject);
            //SoundManagerScript.PlaySound("Slow");
         /*   Trash1.GetComponent<Belt>().StopIt = true;
            Trash2.GetComponent<Belt>().StopIt = true;
            Trash3.GetComponent<Belt>().StopIt = true;
            Trash4.GetComponent<Belt>().StopIt = true;
            */
        }
    }
}
