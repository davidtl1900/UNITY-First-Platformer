using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }
    private void Update()
    {
        if(direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                direction = 1;

            }else if (Input.GetKeyDown(KeyCode.Q))
            {
                direction = 2;

            }


        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity -= Vector2.zero;


            }
            else
            {
                dashTime -= Time.deltaTime;
                if(direction == 1)
                {
                    rb.velocity = Vector2.right * dashSpeed * 2;


                }else if(direction == 2)
                {
                    rb.velocity = Vector2.left * dashSpeed * 2;


                }
            }



        }
    }
}
   