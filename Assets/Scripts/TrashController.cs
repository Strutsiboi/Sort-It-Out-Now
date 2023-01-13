using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public GameObject objectToAttach;
    public GameObject player;

    private bool attached;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trash" && !attached)
        {
            objectToAttach.transform.parent = player.transform;
            objectToAttach.transform.position = player.transform.position;
            attached = true;
        }

        if (collision.gameObject.tag == "Bin" && attached)
        {
            Destroy(objectToAttach);
            attached = false;
        }

    }
}
