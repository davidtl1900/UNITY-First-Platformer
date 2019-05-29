using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilbulletup: MonoBehaviour
{
    public float speed = -20f;
    public int damage = 13;
    public Rigidbody2D rb;
    public float rando = Random.Range(-10.0f, 10.0f);
    private Vector3 m_Velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity += transform.up * speed;
        rb.velocity += transform.right * rando;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerMovement PlayerMovement = hitInfo.GetComponent<PlayerMovement>();
        if (PlayerMovement != null)
        {
            PlayerMovement.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}

