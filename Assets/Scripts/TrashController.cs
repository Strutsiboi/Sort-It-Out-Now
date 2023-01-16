/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public GameObject objectToAttach;
    public GameObject objectToAttach2;
    public GameObject objectToAttach3;
    public GameObject objectToAttach4;
    public GameObject player;

    private bool attached;
    private bool attached2;
    private bool attached3;
    private bool attached4;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plast" && !attached)
        {
            objectToAttach.transform.parent = player.transform;
            objectToAttach.transform.position = player.transform.position;
            attached = true;
            print("TAR UPP SOPOR");
        }

        if (collision.gameObject.tag == "Metall" && !attached2)
        {
            objectToAttach2.transform.parent = player.transform;
            objectToAttach2.transform.position = player.transform.position;
            attached2 = true;
            print("TAR UPP SOPOR");
        }

        if (collision.gameObject.tag == "Glas" && !attached3)
        {
            objectToAttach3.transform.parent = player.transform;
            objectToAttach3.transform.position = player.transform.position;
            attached3 = true;
            print("TAR UPP SOPOR");
        }

        if (collision.gameObject.tag == "Kartong" && !attached4)
        {
            objectToAttach4.transform.parent = player.transform;
            objectToAttach4.transform.position = player.transform.position;
            attached4 = true;
            print("TAR UPP SOPOR");
        }

        if (collision.gameObject.tag == "Bin" && attached)
        {
            print("SLÄNG");
            Destroy(objectToAttach);
            attached = false;
        }

        if (collision.gameObject.tag == "Bin2" && attached2)
        {
            print("SLÄNG");
            Destroy(objectToAttach2);
            attached2 = false;
        }

        if (collision.gameObject.tag == "Bin3" && attached3)
        {
            print("SLÄNG");
            Destroy(objectToAttach3);
            attached3 = false;
        }

        if (collision.gameObject.tag == "Bin4" && attached4)
        {
            print("SLÄNG");
            Destroy(objectToAttach4);
            attached4 = false;
        }

    }
}*/
