using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skoj  : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> objectToAttach;
    public List<string> wasteTags;
    public List<string> binTags;
    public List<bool> attached;

    Belt[] trash;
    public void Start()
    {
        attached = new List<bool>(new bool[objectToAttach.Count]);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        int wasteIndex = wasteTags.IndexOf(collision.gameObject.tag);
        int binIndex = binTags.IndexOf(collision.gameObject.tag);

        if (collision.gameObject.tag == "Plast" || collision.gameObject.tag == "Metall" || collision.gameObject.tag == "Glas" || collision.gameObject.tag == "Kartong")
        {
            objectToAttach.Add(collision.gameObject);
            collision.gameObject.transform.parent = player.transform;
            collision.gameObject.transform.position = player.transform.position;
            attached[wasteIndex] = true;
        }

        if (binIndex != -1 && attached[binIndex] && transform.childCount > 0)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
            ScoreManager.instance.AddPoint(); //Lägga till poäng till scoreboarden
        }
    }
}
