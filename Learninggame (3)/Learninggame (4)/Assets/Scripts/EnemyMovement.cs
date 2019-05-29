using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public LayerMask enemyMask;
    public float speed = -5;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;
    public float time = 3;
    public float starter = 0;
    bool direction = false;
    private bool m_FacingRight = true;

    void Start()
    {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


// Update is called once per frame
void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        starter = starter + Time.deltaTime;

        if(starter > time)

        {
            if (direction == false)

            {

                speed = -1;
                starter = 0;
                direction = true;
                Flip();
            }
        }
        if (starter > time)
        {
          if (direction == true)
           {
                speed = 1;
                starter = 0;
                direction = false;
                Flip();
            }
        }
    }
}
