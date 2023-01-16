using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skoj : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> objectToAttach;
    public List<string> wasteTags;
    public List<string> binTags;
    private List<bool> attached;

    private void Start()
    {
        attached = new List<bool>(new bool[objectToAttach.Count]);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        int wasteIndex = wasteTags.IndexOf(collision.gameObject.tag);
        int binIndex = binTags.IndexOf(collision.gameObject.tag);

        if (wasteIndex != -1 && !attached[wasteIndex]) //När vi kolliderara med waste tag
        {
            objectToAttach.Add(collision.gameObject);
            collision.gameObject.transform.parent = player.transform;
            //objectToAttach[wasteIndex].transform.parent = player.transform;
            collision.gameObject.transform.position = player.transform.position;
            //objectToAttach[wasteIndex].transform.position = player.transform.position;
            attached[wasteIndex] = true;
            print("TAR UPP SOPOR");
        }
        else if (binIndex != -1 && attached[binIndex])
        {
            objectToAttach[binIndex].SetActive(false);
            objectToAttach.RemoveAt(binIndex);
            attached[binIndex] = false;
            print("SLÄNG");
            //objectToAttach[binIndex].SetActive(false);
            //attached[binIndex] = false;
            //print("SLÄNG");
        }
    }
}
