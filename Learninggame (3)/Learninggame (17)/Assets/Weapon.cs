using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Collider2D m_CrouchDisableCollider;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    public int damage = 25;
    public int damage1 = 10000;
    public float timer = 0f;
    public float timer2 = 0f;
    public float timer3 = 0f;


    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Punch();
            timer3 = 0f;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetBool("IsPunching", false);
            m_CrouchDisableCollider.enabled = false;
        }


        if (timer3 > 0.5)
        {
            animator.SetBool("IsPunching", false);
            m_CrouchDisableCollider.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemy enemy = hitInfo.GetComponent<enemy>();
        spike enemy1 = hitInfo.GetComponent<spike>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        if (enemy1 != null)
        {
            enemy.TakeDamage(damage1);
        }
    }

    void Shoot ()
    {
        if (timer > 0.6)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            timer = 0;
        }
    }

    void Punch ()
    {
        if (timer2 > 1)
        {
            animator.SetBool("IsPunching", true);
            m_CrouchDisableCollider.enabled = true;
            timer2 = 0;
        }
    }
}
