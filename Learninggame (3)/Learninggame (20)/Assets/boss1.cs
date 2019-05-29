 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1 : MonoBehaviour
{

    public int health = 100;
    public Transform firePoint;
    public GameObject deathEffect;
    public GameObject bulletPrefab;
    public Rigidbody2D rb;
    public float timer = 0f;
    float timer1 = 20;
    public float example = 0;
    public float example1 = 0;
    public float exp = 0;
    public float goupr = 0;
    public float back = 0;
    public float timer2 = 100f;
    public float lefrig = 0;
    public float agexam = 0;
    public float other = 0;

    void Start()
    {
        float random = Random.Range(0.5f, 2.0f);
    }

    void Update()
    {

        timer += Time.deltaTime;
        timer1 -= Time.deltaTime;

        if (timer > Random.Range(0.5f, 10.0f))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            timer = 0;
        }

        if (timer1 < 0)
        {
            if (transform.position.y >= 1)
            {
                transform.Translate(Vector3.down * Time.deltaTime);
            }

            else if (transform.position.y <= 1)
            {
                if (exp < 1)
                {
                    example = 1;
                }
            }
        }

        if (example >= 1)
        {
            if (Random.Range(1f, 2f) <= 1)
            {
                transform.Translate(Vector3.right * Time.deltaTime);
                example1 = 1;
                lefrig = 1;

            }

            else
            {
                transform.Translate(Vector3.left * Time.deltaTime);
                example1 = 1;
                lefrig = 2;
            }
        }

        if (example1 >= 1)
        {
            if (transform.position.x >= 98) 
            {
                example = 0;
                exp = 1;
                goupr = 1;
            }

            if (transform.position.x <= 88)
            {
                example = 0;
                exp = 1;
                goupr = 1;

            }

        }

        if (goupr >= 1)
        {
            if (other <= 0)
            {
                if (transform.position.y < 7)
                {
                    transform.Translate(Vector3.up * Time.deltaTime);
                    back = 1;
                }

                else if (transform.position.y >= 7.2)
                {
                    back = 1;
                    timer2 -= Time.deltaTime;
                }
            }
        }

        if (timer2 <= 0)
        {
            other = 2;
            if (transform.position.y >= 1)
            {
                transform.Translate(Vector3.down * Time.deltaTime);
            }

            else if (transform.position.y <= 1)
            {
                if (lefrig <= 1)
                {
                    transform.Translate(Vector3.left * Time.deltaTime);
                    agexam = 1;
                }
                else if (lefrig >= 2)
                {
                    transform.Translate(Vector3.right * Time.deltaTime);
                    agexam = 1;
                }
            }
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

