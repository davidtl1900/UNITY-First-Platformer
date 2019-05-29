 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public int health = 100;
    public Transform firePoint;
    public GameObject deathEffect;
    public GameObject bulletPrefab;
    public float timer = 0f;

    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 1.7)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            timer = 0;
        }

    }

        public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(deathEffect, firePoint.position, firePoint.rotation);
    }
}
