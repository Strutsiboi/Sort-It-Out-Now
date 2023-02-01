using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrash : MonoBehaviour
{
    [SerializeField] private HealthS _healthController;
    [SerializeField] private int trashDamage;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("kollision");
        if (collision.gameObject.tag == "VeryBadBin")
        {
            print("COLLIDAR MED OBJEKT");
            Destroy(gameObject);
            Damage();
            
        }
    }

    void Damage()
    {
        _healthController.playerHealth = _healthController.playerHealth - trashDamage;
        _healthController.UpdateHealth();
        gameObject.SetActive(false);
    }

}
