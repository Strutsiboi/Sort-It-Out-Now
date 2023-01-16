using UnityEngine;

public class RandomItemGeneration : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Trash1Prefab;
    public GameObject Trash2Prefab;
    public GameObject Trash3Prefab;
    public GameObject Trash4Prefab;

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
            int random = Random.Range(0, 3);
            if (random == 0)
            {
                Instantiate(Trash1Prefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            else if (random == 1)
            {
                Instantiate(Trash2Prefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            else if (random == 2)
            {
                Instantiate(Trash3Prefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            else if (random == 3) 
            {
                Instantiate(Trash4Prefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            timer = 0;
        }

    }

}
