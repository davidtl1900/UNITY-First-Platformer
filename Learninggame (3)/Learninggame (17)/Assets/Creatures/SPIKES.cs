using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPIKES : MonoBehaviour
{
    public float speed = 0f;
    public int damage1 = 10000;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        double_jump double_jump = hitInfo.GetComponent<double_jump>();
        if (double_jump != null)
        {
            double_jump.TakeDamage(damage1);
        }
    }
}
