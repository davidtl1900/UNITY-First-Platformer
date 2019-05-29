using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class double_jump : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    private float moveinput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public int playerhealth = 100;
    public int damage = 25;
    public int health = 100;
    public GameObject gameoverPrefab;
    public Transform firePoint;



    private int extraJumps;
    public int extraJumpsValue;

    private void Update()
    {






        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }



        if (Input.GetKeyDown(KeyCode.W) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;




        }
        else if (Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;
        }




    }


    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();

    }





    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);






        moveinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);
        if (facingRight == false && moveinput > 0)
        {
            flip();

        }
        else if (facingRight == true && moveinput < 0)
        {
            flip();
        }
    }
    void flip()
    {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

      


     
        if (health <= 0) {         


            SceneManager.LoadScene("yeey");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("yeey")); }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(gameoverPrefab, firePoint.position, firePoint.rotation);
    }
}


 

