using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrash : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "VeryBadBin")
        {
            print("COLLIDAR MED OBJEKT");
            Destroy(collision.gameObject);
        }
    }
}
