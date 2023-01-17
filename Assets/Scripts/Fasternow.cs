using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fasternow : MonoBehaviour
{
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
                item.HurryUp = true;
            }
            Destroy(gameObject);
        }
    }
}
