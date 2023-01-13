using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public float lineOfSite;
    public Transform hitbox;
    public LayerMask trashLayer;
    public GameObject typeoftrash1;
    public GameObject typeoftrash2;
    public GameObject typeoftrash3;
    public bool trashinsight = false;
    void Start()
    {

    }


    void Update()
    {
        


        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(hitbox.position, lineOfSite, trashLayer);
        foreach (Collider2D player in hitEnemies)
        {

            if (typeoftrash1 && typeoftrash2 && typeoftrash3 999899 trashinsight = false)
            {
                trashinsight = true;
                //Give point to player.
                trashinsight = false;
            }
        }

        public void OnDrawGizmosSelected()
        {//Creates the gizmo that he uses when he physicaly attacks. Mattias. 
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(hitbox.position, lineOfSite); //Skapar en cirkel runt om enemyn. Melker
        }
    }
