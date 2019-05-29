using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletup : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public float rando = Random.Range(-10.0f, 10.0f);
    Vector3 totalMovement = Vector3.zero;
    shipPos = Transform.position
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        shipPos += Vector3.right * speed * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemy enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
