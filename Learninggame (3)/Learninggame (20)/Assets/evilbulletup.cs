using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilbulletup: MonoBehaviour
{
    public float speed = -20f;
    public int damage = 13;
    public Rigidbody2D rb;
    private Vector3 m_Velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        float rando = Random.Range(5f, 20f);
        rb.velocity = transform.up * rando;
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

