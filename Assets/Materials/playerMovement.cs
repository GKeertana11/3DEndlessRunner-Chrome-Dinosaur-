using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float jumpForce;
    public float speed;
    Rigidbody rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }

    }
    private void FixedUpdate()
    {
        
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="IsGrounded")
        {
            isGrounded = true; 
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstacle>()!=null)
        {
            Destroy(gameObject);
        }
    }



}
