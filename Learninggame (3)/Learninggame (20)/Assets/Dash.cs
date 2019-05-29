using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dash : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    public float startDashTime;
    private float dashTime;


    void Start() {
        rb = GetComponent<Rigidbody2D>();




    }
}