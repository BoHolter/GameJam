using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int amountOfJumps = 2;
    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up);
            if (amountOfJumps > 0)
            {
                rb.AddForce(Vector2.up * 10);
                amountOfJumps--;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down);
        }



        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float distanceToHitObject = Vector2.Distance(transform.position, hit.point);
            //Debug.Log(distanceToHitObject);
            if (distanceToHitObject < 2.0f)
            {
                //Debug.Log(hit.collider.gameObject.name);
                isGrounded = true;
                amountOfJumps = 2;
                //Debug.Log("mijn code is hier aangekomen");
            }
        }
    }


}

