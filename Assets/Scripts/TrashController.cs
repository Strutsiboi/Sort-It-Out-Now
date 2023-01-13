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
        if (collision.gameObject.tag == "Plast" && !attached)
        {
            objectToAttach.transform.parent = player.transform;
            objectToAttach.transform.position = player.transform.position;
            attached = true;
            print("TAR UPP SOPOR");
        }

        if (collision.gameObject.tag == "Bin" && attached)
        {
            print("SLÄNG");
            Destroy(objectToAttach);
            attached = false;
        }

    }
}
