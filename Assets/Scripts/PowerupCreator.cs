using UnityEngine;



public class PowerupCreator : MonoBehaviour
{
   
    public GameObject SpeedPrefab;
    public GameObject PluslePrefab;
    public GameObject MinunPrefab;

    [SerializeField]
    GameObject[] points;

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
               Instantiate(SpeedPrefab, points[Random.Range(0,points.Length)].transform.position, points[Random.Range(0, points.Length)].transform.rotation);
            }
            else if (random == 1)
            {
                Instantiate(PluslePrefab, points[Random.Range(0, points.Length)].transform.position, points[Random.Range(0, points.Length)].transform.rotation);
            }
            else if (random == 2)
            {
                Instantiate(MinunPrefab, points[Random.Range(0, points.Length)].transform.position, points[Random.Range(0, points.Length)].transform.rotation);
            }
            timer = 0;
        }
    }
}
