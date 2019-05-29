using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapplehook : MonoBehaviour
{
    DistanceJoint2D joint;
    Vector3 targetPos;
    RaycastHit2D hit;
    public float distance = 10f;
    public LayerMask mask;








    // Start is called before the first frame update
    void Start()
    {
        joint=GetComponent<DistanceJoint2D>();
        joint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;



            hit = Physics2D.Raycast(transform.position, targetPos - transform.position, mask);

            if (hit.collider != null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {


                joint.enabled = true;
                joint.connectedBody = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                joint.distance = Vector2.Distance(transform.position, hit.point);


            }

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            joint.enabled = false;
        }





    }












}
