using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrash : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plast" || collision.gameObject.tag == "Metall" || collision.gameObject.tag == "Glas" || collision.gameObject.tag == "Kartong")
        {
            print("COLLIDAR MED OBJEKT");
            Destroy(collision.gameObject);
        }
    }
}
