using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemGeneration : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject TrashPrefab;

    public float countdown = 7;
    public float timer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= countdown)
        {
             Instantiate(TrashPrefab, SpawnPoint.position, SpawnPoint.rotation);
            timer = 0;
        }
       
    }

}
