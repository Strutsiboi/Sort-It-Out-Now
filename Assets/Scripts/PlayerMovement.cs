using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MelkerJ
public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed = 5f;
    public float moveSpeed = 5f;

    private Vector2 movement;

    public bool FasterNow;
    public float slowcountDown = 15;
    public float speedtimer;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + movement.x,transform.position.y + movement.y);

        if (FasterNow)
        {
            moveSpeed = baseSpeed * 2;

            speedtimer += Time.deltaTime;
            if (speedtimer >= slowcountDown)
            {
                moveSpeed = baseSpeed;
                speedtimer = 0;
                FasterNow = false;
            }
        }
    }
}
