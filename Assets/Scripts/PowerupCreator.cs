using UnityEngine;



public class PowerupCreator : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject SpeedPrefab;
    public GameObject PluslePrefab;
    public GameObject MinunPrefab;

    public float countdown = 10;
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
               Instantiate(SpeedPrefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            else if (random == 1)
            {
                Instantiate(PluslePrefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            else if (random == 2)
            {
                Instantiate(MinunPrefab, SpawnPoint.position, SpawnPoint.rotation);
            }
            timer = 0;
        }
    }
}
