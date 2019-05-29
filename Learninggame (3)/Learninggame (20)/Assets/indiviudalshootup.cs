using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indiviudalshootup : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float timer = 0f;

    void Start()
    {
        float random = Random.Range(0.5f, 2.0f);
    }


    void Update()
    {

        timer += Time.deltaTime;

        if (timer > Random.Range(0.5f, 10.0f))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            timer = 0;
        }

    }
}
