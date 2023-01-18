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
    public Vector3 direction;
    void Start()
    {

    }

   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= countdown)
        {
            int random = Random.Range(0, 3);
            if (random == 0)
            {
                Belt newItem = Instantiate(Trash1Prefab, SpawnPoint.position, SpawnPoint.rotation).GetComponent<Belt>();
                newItem.direction = direction;
            }
            else if (random == 1)
            {
                Belt newItem = Instantiate(Trash2Prefab, SpawnPoint.position, SpawnPoint.rotation).GetComponent<Belt>();
                newItem.direction = direction;
            }
            else if (random == 2)
            {
                Belt newItem = Instantiate(Trash3Prefab, SpawnPoint.position, SpawnPoint.rotation).GetComponent<Belt>();
                newItem.direction = direction;
            }
            else if (random == 3) 
            {
                Belt newItem = Instantiate(Trash4Prefab, SpawnPoint.position, SpawnPoint.rotation).GetComponent<Belt>();
                newItem.direction = direction;
            }
            timer = 0;
        }

    }

}
